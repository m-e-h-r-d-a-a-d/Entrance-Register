using System.Diagnostics;
using EntranceRegister.Models;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Color = System.Drawing.Color;

namespace EntranceRegister.Forms;

public partial class FormReport : Form
{
    private int _maxExportCount;
    private bool _alwaysOnTop;
    private bool _allowExit;
    private readonly IConfigurationRoot _configuration;

    private readonly EntranceContext _dbContext;

    public FormReport(EntranceContext dbContext, IConfigurationRoot configuration)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _configuration = configuration;
        buttonExit.Visible = Globals.GatewayExists;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        FillGatesComboBox();
        // FillHostsComboBox();
        ReadConfiguration();
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
        }
    }

    private void buttonLogout_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void dataGridViewPresence_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var currentPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
        if (currentPresence.EndDate.HasValue)
        {
            e.CellStyle!.BackColor = Color.Gray;
            e.CellStyle.SelectionBackColor = Color.DimGray;
        }
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        var hostId = ((Host)comboBoxHosts.SelectedValue!)?.Id ?? Guid.Empty;
        var gateId = ((Gate)comboBoxGates.SelectedValue!)?.Id ?? Guid.Empty;
        var fromDate = DateUtils.ParsePersianDate(textBoxDateFrom.Text) ?? DateTime.Today;
        var toDate = DateUtils.ParsePersianDate(textBoxDateTo.Text) ?? fromDate.AddDays(1);
        textBoxDateFrom.Text = DateUtils.ToPersianDateString(fromDate);
        textBoxDateTo.Text = DateUtils.ToPersianDateString(toDate);

        bindingSourcePresences.DataSource = _dbContext.Presences.Where(p =>
                p.StartDate >= fromDate && p.StartDate < toDate && p.Person.Fullname.Contains(textBoxName.Text) &&
                (hostId == Guid.Empty || p.HostId == hostId) && (gateId == Guid.Empty || p.GateId == gateId))
            .OrderByDescending(p => p.StartDate).ToList();
    }

    private void buttonExport_Click(object sender, EventArgs e)
    {
        ExportToExcel(bindingSourcePresences.DataSource as List<Presence>);
    }

    private void ExportToExcel(IReadOnlyCollection<Presence>? list)
    {
        if (list == null || list.Count == 0)
        {
            MessageBox.Show(@"داده‌ای برای خروجی وجود ندارد", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (list.Count > _maxExportCount)
        {
            MessageBox.Show(@"تعداد داده‌های انتخاب شده از ۱۰۰۰ بیشتر است", @"خطا", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        using var stream = new FileStream(saveFileDialog.FileName, FileMode.Create);
        using var package = new ExcelPackage(stream);
        var ws = package.Workbook.Worksheets.Add("ترددها");
        ws.Cells.LoadFromCollection(list.Select(
            x =>
                new
                {
                    Fullname = x.PersonTitle,
                    x.StartDatePersian,
                    StartDate = x.StartDate.ToShortDateString(),
                    x.StartTime,
                    x.EndTime
                }));

        ws.InsertRow(1, 1);
        ws.Cells[1, 1, 1, 10].Style.Font.Bold = true;
        ws.Cells[1, 1].Value = "نام";
        ws.Cells[1, 2].Value = "تاریخ ورود (شمسی)";
        ws.Cells[1, 3].Value = "تاریخ ورود";
        ws.Cells[1, 4].Value = "ساعت ورود";
        ws.Cells[1, 5].Value = "ساعت خروج";
        ws.Cells[1, 6].Value = "تصویر";

        ws.Cells.AutoFitColumns();
        ws.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
        ws.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        ws.View.RightToLeft = true;
        ws.Cells.Style.ReadingOrder = ExcelReadingOrder.RightToLeft;

        const int picColumn = 6;
        const int columnWidth = 100;
        const int rowHeight = 70;
        const int picMargin = 6;
        ws.Column(picColumn).Width = PixelToColumnWidth(columnWidth + picMargin * 6);
        ws.DefaultRowHeight = rowHeight;

        int index = 0;
        foreach (var presence in list)
        {
            if (presence.Photo != null)
            {
                using var memoryStream = new MemoryStream(presence.Photo);
                var picture = ws.Drawings.AddPicture(index.ToString(), memoryStream);


                picture.SetSize(columnWidth, columnWidth);
                picture.SetPosition(index + 1, picMargin / 2, picColumn - 1, picMargin * 3);
            }

            ++index;
        }

        package.Save();
    }

    private double PixelToColumnWidth(int i)
    {
        return (i - 12 + 5) / 7d + 1;
    }

    private void ReadConfiguration()
    {
        _maxExportCount = _configuration.GetValue("GlobalSettings:MaxExportCount", defaultValue: 1000);
        _alwaysOnTop = _configuration.GetValue("GlobalSettings:AlwaysOnTop", defaultValue: false);
        _allowExit = _configuration.GetValue("GlobalSettings:AllowExit", defaultValue: true);
        TopMost = _alwaysOnTop;
        buttonLogOut.Visible = _allowExit;
    }

    private void FillHostsComboBox()
    {
        comboBoxHosts.DisplayMember = "Name";
        comboBoxHosts.DataSource = _dbContext.Hosts.Where(h => h.GateId == ((Gate)comboBoxGates.SelectedValue!).Id).ToList();
        comboBoxHosts.SelectedItem = null;
    }

    private void FillGatesComboBox()
    {
        comboBoxGates.DisplayMember = "Name";
        var ds = _dbContext.Gates.OrderBy(h => h.Name).ToList();
        comboBoxGates.DataSource = ds;
        if (Globals.Gate == null)
        {
            comboBoxGates.SelectedIndex = 0;
        }
        else
        {
            comboBoxGates.SelectedIndex = ds.FindIndex(a => a.Id == Globals.Gate.Id);
            comboBoxGates.Enabled = false;
        }
    }

    private void buttonLogOut_Click_1(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"آیا مطمئنید؟", @"خروج از سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
            DialogResult.OK)
        {
            Application.Exit();
        }
    }

    private void buttonShutdown_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"آیا مطمئنید؟", @"خاموش کردن سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
            DialogResult.OK)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        string yourPath = @"Resources\help.chm";
        if (File.Exists(yourPath))
        {
            Help.ShowHelp(this, yourPath);
        }
        else
        {
            MessageBox.Show(@"فایل راهنما موجود نمی باشد.‏");
        }
    }

    private void comboBoxGates_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillHostsComboBox();
    }
}

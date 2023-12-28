using EntranceRegister.Models;
using System.Configuration;
using System.Diagnostics;
// using BehFarma.Model;
// using OfficeOpenXml;
// using OfficeOpenXml.Style;
using Color = System.Drawing.Color;

namespace EntranceRegister.Forms;

public partial class FormReport : Form
{
    // private BehFarmaEntities _entities = new BehFarmaEntities();
    private int _maxExportCount;
    private bool _alwaysOnTop;
    private bool _allowExit;

    private readonly EntranceContext _dbContext;
    
    public FormReport(EntranceContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
        buttonExit.Visible = Globals.GatewayExists;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        FillGatesComboBox();
        //FillHostsComboBox();
        ReadConfiguration();
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
            e.Cancel = true;
    }

    private void buttonLogout_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void dataGridViewPresence_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        // var currentPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
        // if (currentPresence.EndDate.HasValue)
        {
            e.CellStyle.BackColor = Color.Gray;
            e.CellStyle.SelectionBackColor = Color.DimGray;
        }
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        // var hostId = comboBoxHosts.SelectedValue != null ? ((Host)comboBoxHosts.SelectedValue).Id : Guid.Empty;
        // var gateId = comboBoxGates.SelectedValue != null ? ((Gate)comboBoxGates.SelectedValue).Id : Guid.Empty;
        // var fromDate = DateUtils.ParsePersianDate(textBoxDateFrom.Text) ?? DateTime.Today;
        // var toDate = DateUtils.ParsePersianDate(textBoxDateTo.Text) ?? fromDate.AddDays(1);
        // textBoxDateFrom.Text = DateUtils.ToPersianDateString(fromDate);
        // textBoxDateTo.Text = DateUtils.ToPersianDateString(toDate);
        //
        // var list = (from p in _entities.Presences
        //             where p.StartDate >= fromDate && p.StartDate < toDate
        //             && p.Person.Fullname.Contains(textBoxName.Text)
        //             && (hostId == Guid.Empty || p.HostId == hostId)
        //             && (gateId == Guid.Empty || p.GateId == gateId)
        //             orderby p.StartDate descending
        //             select p).ToList();
        // bindingSourcePresences.DataSource = list;
    }

    private void buttonExport_Click(object sender, EventArgs e)
    {
        // ExportToExcel(bindingSourcePresences.DataSource as List<Presence>);
    }

    // private void ExportToExcel(IReadOnlyCollection<Presence> list)
    // {
    //     if (list == null || list.Count == 0)
    //     {
    //         MessageBox.Show("داده‌ای برای خروجی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //         return;
    //     }
    //
    //     if (list.Count > _maxExportCount)
    //     {
    //         MessageBox.Show("تعداد داده‌های انتخاب شده از ۱۰۰۰ بیشتر است", "خطا", MessageBoxButtons.OK,
    //             MessageBoxIcon.Error);
    //         return;
    //     }
    //
    //     if (saveFileDialog.ShowDialog() != DialogResult.OK) 
    //         return;
    //
    //     using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
    //     using (var package = new ExcelPackage(stream))
    //     {
    //         var ws = package.Workbook.Worksheets.Add("ترددها");
    //
    //         ws.Cells.LoadFromCollection(list.Select(
    //             x =>
    //                 new
    //                 {
    //                     Fullname = x.PersonTitle,
    //                     x.StartDatePersian,
    //                     StartDate = x.StartDate.ToShortDateString(),
    //                     x.StartTime,
    //                     x.EndTime,
    //                 }));
    //
    //         ws.InsertRow(1, 1);
    //         ws.Cells[1, 1, 1, 10].Style.Font.Bold = true;
    //         ws.Cells[1, 1].Value = "نام";
    //         ws.Cells[1, 2].Value = "تاریخ ورود (شمسی)";
    //         ws.Cells[1, 3].Value = "تاریخ ورود";
    //         ws.Cells[1, 4].Value = "ساعت ورود";
    //         ws.Cells[1, 5].Value = "ساعت خروج";
    //         ws.Cells[1, 6].Value = "تصویر";
    //
    //         ws.Cells.AutoFitColumns();
    //         ws.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
    //         ws.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
    //         ws.View.RightToLeft = true;
    //         ws.Cells.Style.ReadingOrder = ExcelReadingOrder.RightToLeft;
    //
    //         const int picColumn = 6;
    //         const int columnWidth = 100;
    //         const int rowHeight = 70;
    //         const int picMargin = 6;
    //         ws.Column(picColumn).Width = PixelToColumnWidth(columnWidth + picMargin*6);
    //         ws.DefaultRowHeight = rowHeight;
    //
    //         int index = 0;
    //         foreach (var presence in list)
    //         {
    //             if (presence.Photo != null)
    //             {
    //                 var picture = ws.Drawings.AddPicture(index.ToString(), (Image) new ImageConverter().ConvertFrom(presence.Photo));
    //                 picture.SetSize(columnWidth, columnWidth);
    //                 picture.SetPosition(index + 1, picMargin / 2, picColumn - 1, picMargin * 3);
    //             }
    //
    //             ++index;
    //         }
    //
    //         package.Save();
    //     }
    // }

    private double PixelToColumnWidth(int i)
    {
        return (i - 12 + 5) / 7d + 1;
    }

    private void ReadConfiguration()
    {
        if (!int.TryParse(ConfigurationManager.AppSettings["MaxExportCount"], out _maxExportCount))
            _maxExportCount = 1000;
        bool.TryParse(ConfigurationManager.AppSettings["AlwaysOnTop"], out _alwaysOnTop);
        TopMost = _alwaysOnTop;
        bool.TryParse(ConfigurationManager.AppSettings["AllowExit"], out _allowExit);
        buttonLogOut.Visible = _allowExit;
    }

    private void FillHostsComboBox()
    {
        comboBoxHosts.DisplayMember = "Name";
        // comboBoxHosts.DataSource = (from h in _entities.Hosts
        //                             where h.GateId == ((Gate)comboBoxGates.SelectedValue).Id
        //                             select h).ToList();
        comboBoxHosts.SelectedItem = null;
    }

    private void FillGatesComboBox()
    {
        comboBoxGates.DisplayMember = "Name";
        // var ds = (from h in _entities.Gates
        //                             orderby h.Name
        //                             select h).ToList();
        // comboBoxGates.DataSource = ds;
        // if (Globals.Gate == null)
        {
            comboBoxGates.SelectedIndex = 0;
        }
        // else
        // {
        //     comboBoxGates.SelectedIndex = ds.FindIndex(a => a.Id == Globals.Gate.Id);
        //     comboBoxGates.Enabled = false;
        // }
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void buttonLogOut_Click_1(object sender, EventArgs e)
    {
        if (MessageBox.Show("آیا مطمئنید؟", "خروج از سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            Application.Exit();
    }

    private void buttonShutdown_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("آیا مطمئنید؟", "خاموش کردن سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            Process.Start("shutdown", "/s /t 0");
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        string yourpath = Environment.CurrentDirectory + @"\help\help.chm";
        if (File.Exists(yourpath))
        {
            Help.ShowHelp(this, yourpath);
        }
        else
            MessageBox.Show("فایل راهنما موجود نمی باشد.‏");
    }

    private void comboBoxGates_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillHostsComboBox();
    }
}
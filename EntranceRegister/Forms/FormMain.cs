using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using EntranceRegister.Models;
// using Microsoft.Reporting.WinForms;
using Stream = System.IO.Stream;
using Application = System.Windows.Forms.Application;
using Microsoft.Extensions.Configuration;
using Emgu.CV.Face;
using System.Threading;
using Microsoft.Reporting.WinForms;

// using Microsoft.Reporting.NETCore;

namespace EntranceRegister;

public partial class FormMain : Form
{
    private readonly EntranceContext _dbContext;
    private readonly IConfigurationRoot _configuration;
    private DateTime _today;
    private List<Bitmap> _lastDetectedFaces = new List<Bitmap>();
    private IList<Stream> _streams;
    private int _currentPageIndex;
    private int _detectionSize;
    private int _detectionNeighbors;
    private string _printerDeviceInfo;
    private int _width;
    private int _height;
    private string _cameraStreamUrl;
    private string _cameraUsername;
    private string _cameraPassword;
    private string _cameraDeviceName;
    private double _detectionScaleFactor;
    private int _facesIndex;
    private int _frameSkip;
    private int _skipIndex;
    private string _faceFileName;
    private bool _alwaysOnTop;
    private bool _allowExit;
    private bool _isMotionDetected;
    private Guid _gateId;
    private int _visitorsCount;
    private CascadeClassifier _cascadeClassifier;
    private BackgroundSubtractorMOG2 _backgroundSubtractor;
    private CancellationTokenSource _cancellationTokenSource;

    private VideoCapture _videoCapture;

    public int VisitorsCount
    {
        get => _visitorsCount;
        set
        {
            _visitorsCount = value;
            UpdateLabels();
        }
    }

    public FormMain(EntranceContext dbContext, IConfigurationRoot configuration)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _configuration = configuration;
        _cancellationTokenSource = new CancellationTokenSource();
        ReadConfiguration();

    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        comboBoxGender.SelectedIndex = 0;
        timerDateTime.Start();
        RefreshDateTime();
        LoadTodayPresences();
        FillHostsComboBox();
        CaptureCamera();
    }

    private void buttonTakePhoto_Click(object sender, EventArgs e)
    {
        _facesIndex = 0;
        ExtractFace();
        textBoxName.Focus();
    }

    private void buttonRegisterAndPrint_Click(object sender, EventArgs e)
    {
        if (textBoxName.Text == string.Empty)
        {
            MessageBox.Show(@"لطفا نام مراجعه کننده را وارد کنید.‏");
            return;
        }

        var presence = SavePersonAndPresence();
        VisitorsCount++;
        PrintCard(presence);
        ClearForm();
    }

    private void timerDateTime_Tick(object sender, EventArgs e)
    {
        if (DateTime.Now.Date != _today)
        {
            LoadTodayPresences();
        }
        RefreshDateTime();
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            _cancellationTokenSource.Cancel();
        }
        catch (Exception)
        {
            // ignored
        }
    }

    private void buttonLogout_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"آیا مطمئنید؟", @"خروج از سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
            DialogResult.OK)
            Application.Exit();
    }

    private void buttonShutdown_Click(object sender, EventArgs e)
    {
        if (
            MessageBox.Show(@"آیا مطمئنید؟", @"خاموش کردن سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
            DialogResult.OK)
            Process.Start("shutdown", "/s /t 0");
    }

    private void dataGridViewPresence_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var selectedPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
        if (e.ColumnIndex == ColumnButtonReprint.Index)
            PrintCard(selectedPresence);
        else if (e.ColumnIndex == ColumnButtonExit.Index)
            if (selectedPresence.EndDate == null)
                RegisterExit(selectedPresence);
    }

    private void dataGridViewPresence_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        var currentPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
        if (!currentPresence.EndDate.HasValue)
        {
            return;
        }

        if (e.ColumnIndex != ColumnButtonExit.Index)
        {
            e.CellStyle!.BackColor = Color.Gray;
            e.CellStyle!.SelectionBackColor = Color.DimGray;
        }
        else
        {
            e.CellStyle!.BackColor = e.CellStyle.SelectionBackColor = Color.LightGray;
        }
    }

    private void buttonReport_Click(object sender, EventArgs e)
    {
        new FormReport(_dbContext).ShowDialog();
    }

    private void FormMain_KeyDown(object sender, KeyEventArgs e)
    {
        if (e is { Alt: true, Control: true, Shift: true, KeyCode: Keys.X })
        {
            buttonLogout_Click(buttonExit, EventArgs.Empty);
        }
    }

    private void pictureBoxFace_Click(object sender, EventArgs e)
    {
        if (_lastDetectedFaces.Count == 0)
        {
            return;
        }

        if (++_facesIndex >= _lastDetectedFaces.Count)
        {
            _facesIndex = 0;
        }

        pictureBoxFace.Image = _lastDetectedFaces[_facesIndex];
    }

    private void ReadConfiguration()
    {
        _printerDeviceInfo = _configuration.GetValue("GlobalSettings:PrinterDeviceInfo", defaultValue: string.Empty)!;
        _gateId = new Guid(_configuration.GetValue("GlobalSettings:GateId", defaultValue: "DF3113F8-09A9-4B0F-9DD7-0843EC4F4A5C")!);
        _alwaysOnTop = _configuration.GetValue<bool>("GlobalSettings:AlwaysOnTop");
        _allowExit = _configuration.GetValue<bool>("GlobalSettings:AllowExit");
        _cameraStreamUrl = _configuration.GetValue("FaceDetectionSettings:CameraStreamUrl", defaultValue: string.Empty)!;
        _cameraUsername = _configuration.GetValue("FaceDetectionSettings:CameraUsername", defaultValue: string.Empty)!;
        _cameraPassword = _configuration.GetValue("FaceDetectionSettings:CameraPassword", defaultValue: string.Empty)!;
        _cameraDeviceName = _configuration.GetValue("FaceDetectionSettings:CameraDeviceName", defaultValue: string.Empty)!;
        _isMotionDetected = _configuration.GetValue<bool>("FaceDetectionSettings:IsMotionDetected");
        _faceFileName = @"Resources\" + _configuration.GetValue("FaceDetectionSettings:FaceFileName", defaultValue: "lbpcascade_frontalface.xml")!;
        _detectionNeighbors = _configuration.GetValue("FaceDetectionSettings:DetectionNeighbors", defaultValue: 5);
        _detectionSize = _configuration.GetValue("FaceDetectionSettings:DetectionSize", defaultValue: 20);
        _detectionScaleFactor = _configuration.GetValue("FaceDetectionSettings:DetectionScaleFactor", defaultValue: 1.2);
        _width = _configuration.GetValue("FaceDetectionSettings:Width", defaultValue: 640);
        _height = _configuration.GetValue("FaceDetectionSettings:Height", defaultValue: 480);

        var gate = _dbContext.Gates.SingleOrDefault(g => g.Id == _gateId);
        if (gate == null)
        {
            MessageBox.Show(@"خطا در انتخاب ورودی");
            Application.Exit();
            Environment.Exit(0);
        }
        else
        {
            Globals.Gate = gate;
        }

        TopMost = _alwaysOnTop;
        buttonExit.Visible = _allowExit;

        _cascadeClassifier = new CascadeClassifier(_faceFileName);
        _backgroundSubtractor = new BackgroundSubtractorMOG2(50, 30, false);
    }

    private void ClearForm()
    {
        pictureBoxFace.Image = null;
        textBoxName.Text = string.Empty;
    }

    private void RegisterExit(Presence selectedPresence)
    {
        selectedPresence.EndDate = DateTime.Now;
        _dbContext.SaveChanges();
    }

    private async void CaptureCamera()
    {
        try
        {
            if (!string.IsNullOrEmpty(_cameraStreamUrl))
            {
                _videoCapture = new VideoCapture(_cameraStreamUrl);

            }
            else
            {
                _videoCapture = new VideoCapture(1);
            }

            if (!_videoCapture.IsOpened)
            {
                MessageBox.Show("دوربینی به سیستم متصل نیست.", "خطا", MessageBoxButtons.OK);
                return;
            }

            await Task.Run(() => ProcessFrame(_cancellationTokenSource.Token));
            // _camera.NewFrame += ProcessFrame;
            // _camera.Start();
        }
        catch (Exception e)
        {
            MessageBox.Show("خطا در اتصال به دوربین: " + e.Message, "خطا", MessageBoxButtons.OK);
        }
    }

    private void ProcessFrame(CancellationToken cancellationToken)
    {
        using var frame = new Mat();
        while (!cancellationToken.IsCancellationRequested && _videoCapture.IsOpened)
        {
            
            if (!_videoCapture.Read(frame) || (_frameSkip != 0 && ++_skipIndex % _frameSkip != 0))
            {
                continue;
            }
            
            if (frame.Width > _width)
            {
                CvInvoke.Resize(frame, frame, new Size(_width, _height), 2, 2, Inter.Linear);
            }

            var faces = new List<Bitmap>();
            try
            {
                pictureBoxCamera.Image = DetectFace(frame, out faces);
            }
            catch
            {
                // ignored
            }

            if (faces is { Count: > 0 })
            {
                _lastDetectedFaces = faces;
            }
        }
    }

    private Bitmap DetectFace(Mat inputImage, out List<Bitmap> outputFaces)
    {
        outputFaces = new List<Bitmap>();
        
        using var gray = new Mat();
        if (_isMotionDetected)
        {
            using var resizedImage = new Mat();
            CvInvoke.Resize(inputImage, resizedImage, new Size(_width, _height), 2, 2, Inter.Linear);
            CvInvoke.GaussianBlur(resizedImage, resizedImage, new Size(7, 7), 0, 0);

            _backgroundSubtractor.Apply(resizedImage, gray);
            CvInvoke.Threshold(gray, gray, 50, 1, ThresholdType.Binary);
            CvInvoke.Dilate(gray, gray, null,
                new Point(-1, -1), 7, BorderType.Default, new MCvScalar(1));
            CvInvoke.Resize(gray, gray, new Size(inputImage.Width, inputImage.Height), 2, 2, Inter.Linear);
            CvInvoke.CvtColor(inputImage, resizedImage, ColorConversion.Bgr2Gray);
            CvInvoke.Multiply(resizedImage, gray, gray);
        }
        else
        {
            CvInvoke.CvtColor(inputImage, gray, ColorConversion.Bgr2Gray);
        }

        CvInvoke.EqualizeHist(gray, gray);


        var facesDetected = _cascadeClassifier.DetectMultiScale(
            gray,
            _detectionScaleFactor,
            _detectionNeighbors,
            new Size(_detectionSize, _detectionSize));

        foreach (var f in facesDetected)
        {
            int x = Math.Min(Math.Min(f.Width / 10, f.X), inputImage.Width - f.Right);
            int y = Math.Min(Math.Min(f.Height / 5, f.Y), inputImage.Height - f.Bottom);
            outputFaces.Add(inputImage.ToBitmap().Clone(Rectangle.Inflate(f, x, y), PixelFormat.DontCare));
            CvInvoke.Rectangle(inputImage, f, new Bgr(Color.Blue).MCvScalar, 2);
        }

        return inputImage.ToBitmap().Clone(new Rectangle(0, 0, inputImage.Width, inputImage.Height), PixelFormat.DontCare);
    }

    private void Export(Report report)
    {
        _streams = new List<Stream>();
        _streams.Add(new MemoryStream(report.Render("Image", _printerDeviceInfo)));
        foreach (var stream in _streams)
        {
            stream.Position = 0;
        }
    }

    private void Print()
    {
        if (_streams == null || _streams.Count == 0)
        {
            throw new Exception("Error: no stream to print.");
        }

        var printDoc = new PrintDocument();
        if (!printDoc.PrinterSettings.IsValid)
        {
            throw new Exception("Error: cannot find the default printer.");
        }

        printDoc.PrintPage += PrintPage;
        _currentPageIndex = 0;
        printDoc.Print();
    }

    private void PrintCard(Presence presence)
    {
        var report = new LocalReport
        {
            ReportPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Card.rdlc"
        };
        
        report.DataSources.Add(new ReportDataSource("DataSetPresence", new BindingSource(presence, null)));
        Export(report);
        Print();
    }

    private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
    {
        Stream stream = new MemoryStream();
        _streams.Add(stream);
        return stream;
    }

    private void PrintPage(object sender, PrintPageEventArgs ev)
    {
        var pageImage = new Metafile(_streams[_currentPageIndex]);

        var adjustedRect = new Rectangle(
            ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
            ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
            ev.PageBounds.Width,
            ev.PageBounds.Height);

        ev.Graphics!.FillRectangle(Brushes.White, adjustedRect);
        ev.Graphics!.DrawImage(pageImage, adjustedRect);

        _currentPageIndex++;
        ev.HasMorePages = (_currentPageIndex < _streams.Count);
    }

    private Presence SavePersonAndPresence()
    {
        var person = _dbContext.People.SingleOrDefault(p => p.Fullname == textBoxName.Text && p.Gender == comboBoxGender.SelectedIndex > 0);

        if (person == null)
        {
            person = new Person { Id = Guid.NewGuid(), Fullname = textBoxName.Text };
            _dbContext.People.Add(person);
        }

        person.Gender ??= comboBoxGender.SelectedIndex > 0;

        var presence = new Presence
        {
            Id = Guid.NewGuid(),
            Person = person,
            Host = (Host)comboBoxHosts.SelectedValue!,
            StartDate = DateTime.Now,
            RegistrarUsername = Globals.User.Username,
            Gate = Globals.Gate!
        };

        if (pictureBoxFace.Image != null)
        {
            using var imageStream = new MemoryStream();
            pictureBoxFace.Image.Save(imageStream, ImageFormat.Jpeg);
            presence.Photo = imageStream.ToArray();
        }

        _dbContext.Presences.Add(presence);
        _dbContext.SaveChanges();
        bindingSourceTodayPresences.Insert(0, presence);

        return presence;
    }

    private void ExtractFace()
    {
        pictureBoxFace.Image = _lastDetectedFaces.Count > 0 ? _lastDetectedFaces[0] : null;
        var now = DateTime.Now;
        textBoxDate.Text = DateUtils.ToPersianDateString(now);
        textBoxStartTime.Text = DateUtils.ToPersianTimeString(now);
    }

    private void RefreshDateTime()
    {
        labelDateTime.Text = DateUtils.ToLongPersianDateTimeString(DateTime.Now);
    }

    private void FillHostsComboBox()
    {
        comboBoxHosts.DisplayMember = "Name";
        comboBoxHosts.DataSource = _dbContext.Hosts.Where(h => h.GateId == Globals.Gate!.Id).OrderBy(h => h.Name).ToList();
    }

    private void LoadTodayPresences()
    {
        _today = DateTime.Now.Date;
        var tomorrow = _today.AddDays(1);
        var list = _dbContext.Presences
            .Where(p => p.StartDate >= _today && p.StartDate < tomorrow && p.GateId == Globals.Gate.Id)
            .OrderByDescending(p => p.StartDate).ToList();

        bindingSourceTodayPresences.DataSource = list;
        VisitorsCount = list.Count;
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        string yourPath = Environment.CurrentDirectory + @"\help\help.chm";

        if (!File.Exists(yourPath))
        {
            MessageBox.Show(@"فایل راهنما موجود نمی باشد.‏");
            return;
        }

        Help.ShowHelp(this, yourPath);
    }

    private void UpdateLabels()
    {
        labelVisitorsCount.Text = @"تعداد مراجعین " + VisitorsCount;
    }
}
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using EntranceRegister.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Reporting.WinForms;
using Application = System.Windows.Forms.Application;
using Stream = System.IO.Stream;


namespace EntranceRegister.Forms;

public partial class FormMain : Form
{
    private readonly EntranceContext _dbContext;
    private readonly IConfigurationRoot _configuration;
    private DateTime _today;
    private List<Bitmap> _lastDetectedFaces = new List<Bitmap>();
    private IList<Stream> _streams = null!;
    private int _currentPageIndex;
    private int _detectionSize;
    private int _detectionNeighbors;
    private string _printerDeviceInfo = null!;
    private int _width;
    private int _height;
    private string _cameraStreamUrl = null!;
    private string _cameraUsername = null!;
    private string _cameraPassword = null!;
    private string _cameraDeviceName = null!;
    private double _detectionScaleFactor;
    private int _detectionType;
    private int _facesIndex;
    private int _detectionFrameRate;
    private string _faceFileName = null!;
    private bool _alwaysOnTop;
    private bool _allowExit;
    private bool _isMotionDetected;
    private Guid _gateId;
    private int _visitorsCount;
    private FaceDetectorCascade _faceDetector;
    private FaceDetectorYunet _faceDetectorYunet = null!;
    private readonly CancellationTokenSource _cancellationTokenSource;
    private MotionDetector _motionDetector;

    private VideoCapture? _videoCapture;

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
        _dbContext = dbContext;
        _configuration = configuration;
        _cancellationTokenSource = new CancellationTokenSource();
        InitializeComponent();
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
        {
            Application.Exit();
        }
    }

    private void buttonShutdown_Click(object sender, EventArgs e)
    {
        if (
            MessageBox.Show(@"آیا مطمئنید؟", @"خاموش کردن سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
            DialogResult.OK)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }

    private void dataGridViewPresence_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var selectedPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
        if (e.ColumnIndex == ColumnButtonReprint.Index)
        {
            PrintCard(selectedPresence);
        }
        else if (e.ColumnIndex == ColumnButtonExit.Index)
        {
            if (selectedPresence.EndDate == null)
            {
                RegisterExit(selectedPresence);
            }
        }
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
        new FormReport(_dbContext, _configuration).ShowDialog();
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
        _alwaysOnTop = _configuration.GetValue("GlobalSettings:AlwaysOnTop", defaultValue: false);
        _allowExit = _configuration.GetValue("GlobalSettings:AllowExit", defaultValue: true);
        _cameraStreamUrl = _configuration.GetValue("FaceDetectionSettings:CameraStreamUrl", defaultValue: string.Empty)!;
        _cameraUsername = _configuration.GetValue("FaceDetectionSettings:CameraUsername", defaultValue: string.Empty)!;
        _cameraPassword = _configuration.GetValue("FaceDetectionSettings:CameraPassword", defaultValue: string.Empty)!;
        _cameraDeviceName = _configuration.GetValue("FaceDetectionSettings:CameraDeviceName", defaultValue: string.Empty)!;
        _isMotionDetected = _configuration.GetValue("FaceDetectionSettings:IsMotionDetected", defaultValue: false);
        _faceFileName = @"Resources\" + _configuration.GetValue("FaceDetectionSettings:DetectionFileName", defaultValue: "lbpcascade_frontalface.xml")!;
        _detectionNeighbors = _configuration.GetValue("FaceDetectionSettings:DetectionNeighbors", defaultValue: 5);
        _detectionSize = _configuration.GetValue("FaceDetectionSettings:DetectionSize", defaultValue: 20);
        _detectionScaleFactor = _configuration.GetValue("FaceDetectionSettings:DetectionScaleFactor", defaultValue: 1.2);
        _detectionType = _configuration.GetValue("FaceDetectionSettings:DetectionType", defaultValue: 0);
        _width = _configuration.GetValue("FaceDetectionSettings:DetectionWidth", defaultValue: 640);
        _height = _configuration.GetValue("FaceDetectionSettings:DetectionHeight", defaultValue: _detectionType == 0 ? 640 : 480);
        _detectionFrameRate = _configuration.GetValue("FaceDetectionSettings:DetectionFrameRate", defaultValue: 20);

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

        BackgroundSubtractorMOG2 backgroundSubtractor = new BackgroundSubtractorMOG2(50, 30, false);
        MotionDetector mg = new MotionDetector(backgroundSubtractor, 150);
        switch (_detectionType)
        {
            case 0:
            default:
                FaceDetectorYN faceDetectorYN = new FaceDetectorYN(@"Resources\face_detection_yunet_2023mar.onnx", "", new Size(_width, _height));
                _faceDetectorYunet = new FaceDetectorYunet(faceDetectorYN, mg, _isMotionDetected);

                break;
            case 1:
                CascadeClassifier cascadeClassifier = new CascadeClassifier(_faceFileName);

                _faceDetector = new FaceDetectorCascade(cascadeClassifier, mg, _detectionScaleFactor,
                    _detectionNeighbors, _detectionSize, _isMotionDetected, _width, _height);


                break;
        }
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
        await Task.Run(() => ProcessFrame(_cancellationTokenSource.Token));
    }

    private void ProcessFrame(CancellationToken cancellationToken)
    {
        bool isParsed = int.TryParse(_cameraStreamUrl, out int cameraId);

        using var frame = new Mat();
        var lastTimeDetect = DateTime.Now;
        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                if (_videoCapture is not { IsOpened: true } || !_videoCapture.Read(frame) || frame.GetData() == null)
                {
                    if (_videoCapture != null)
                    {
                        MessageBox.Show(@"دوربینی به سیستم متصل نیست.", @"خطا", MessageBoxButtons.OK);
                    }

                    _videoCapture = !string.IsNullOrEmpty(_cameraStreamUrl)
                        ? (isParsed ? new VideoCapture(cameraId) : new VideoCapture(_cameraStreamUrl))
                        : new VideoCapture(1);


                    switch (_detectionType)
                    {
                        case 0:
                        default:
                            int frameWidth = (int)_videoCapture.Get(CapProp.FrameWidth);
                            int frameHeight = (int)_videoCapture.Get(CapProp.FrameHeight);
                            _faceDetectorYunet.InputSize = new Size(frameWidth, frameHeight);
                            break;
                        case 1:
                            break;
                    }
                    continue;
                }

                double df = (DateTime.Now - lastTimeDetect).TotalMilliseconds;
                if (_detectionFrameRate != 0 && (1000.0 / _detectionFrameRate) > df)
                {
                    continue;
                }

                lastTimeDetect = DateTime.Now;
                List<Rectangle> facesDetected = _detectionType switch
                {
                    0 => _faceDetectorYunet.DetectFace(frame),
                    1 => _faceDetector.DetectFace(frame),
                    _ => _faceDetectorYunet.DetectFace(frame)
                };

                DetectFacePostProcess(frame, facesDetected, out List<Bitmap>? faces);
                pictureBoxCamera.Image = frame.ToBitmap().Clone(new Rectangle(0, 0, frame.Width, frame.Height), PixelFormat.DontCare);

                if (faces is { Count: > 0 })
                {
                    _lastDetectedFaces = faces;
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }


    private void DetectFacePostProcess(Mat inputImage, List<Rectangle> faces, out List<Bitmap> outputFaces)
    {
        outputFaces = new List<Bitmap>();
        foreach (var f in faces)
        {
            int x = Math.Min(Math.Min(f.Width / 10, f.X), inputImage.Width - f.Right);
            int y = Math.Min(Math.Min(f.Height / 5, f.Y), inputImage.Height - f.Bottom);
            outputFaces.Add(inputImage.ToBitmap().Clone(Rectangle.Inflate(f, x, y), PixelFormat.DontCare));
            CvInvoke.Rectangle(inputImage, f, new Bgr(Color.Blue).MCvScalar, 2);
        }
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
            ReportPath = @"Resources\Card.rdlc"
        };

        report.DataSources.Add(new ReportDataSource("DataSetPresence", new BindingSource(presence, null)));
        Export(report);
        Print();
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
            RegistrarUsername = Globals.User!.Username,
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
        var list = _dbContext.Presences
            .Where(p => p.StartDate >= _today && p.StartDate < _today.AddDays(1) && p.GateId == Globals.Gate!.Id)
            .OrderByDescending(p => p.StartDate).Include(b => b.Person).ToList();

        bindingSourceTodayPresences.DataSource = list;
        VisitorsCount = list.Count;
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

    private void UpdateLabels()
    {
        labelVisitorsCount.Text = @"تعداد مراجعین " + VisitorsCount;
    }
}

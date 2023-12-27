using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Reg;
using Emgu.CV.Structure;
// using Emgu.CV.VideoSurveillance;
// using Microsoft.Reporting.WinForms;
// using AForge.Video;
// using AForge.Video.DirectShow;
using Stream = System.IO.Stream;
using static System.Net.Mime.MediaTypeNames;
using static Emgu.CV.Ccm.ColorCorrectionModel;
using Application = System.Windows.Forms.Application;

namespace View
{
    public partial class FormMain : Form
    {
        private DateTime _today;
        private List<Bitmap> _lastDetectedFaces = new List<Bitmap>();
        // private BehFarmaEntities _entities = new BehFarmaEntities();
        private IList<Stream> _streams;
        private int _currentPageIndex;
        private int _detectionSize;
        private int _detectionNeighbors;
        private string? _printerDeviceInfo;
        private int _width;
        private int _height;
        private string? _cameraStreamUrl;
        private string? _cameraUsername;
        private string _cameraPassword;
        private string _cameraDeviceName;
        private double _detectionScaleFactor;
        // private IVideoSource _camera;
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
        private int counter = 0;

        private VideoCapture _videoCapture;

        public int VisitorsCount
        {
            get { return _visitorsCount; }
            set
            {
                _visitorsCount = value;
                UpdateLabels();
            }
        }

        public FormMain()
        {
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
            // ExtractFace();
            textBoxName.Focus();
        }

        private void buttonRegisterAndPrint_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("لطفا نام مراجعه کننده را وارد کنید.‏");
                return;
            }

            // var presence = SavePersonAndPresence();
            VisitorsCount++;
            // PrintCard(presence);
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
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            else
            {
                try
                {
                    // _camera.Stop();
                    // _camera.NewFrame -= ProcessFrame;
                }
                catch (Exception) { }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئنید؟", "خروج از سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
                Application.Exit();
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("آیا مطمئنید؟", "خاموش کردن سیستم", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                DialogResult.OK)
                Process.Start("shutdown", "/s /t 0");
        }

        private void dataGridViewPresence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // var selectedPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
            // if (e.ColumnIndex == ColumnButtonReprint.Index)
            //     PrintCard(selectedPresence);
            // else if (e.ColumnIndex == ColumnButtonExit.Index)
            //     if (selectedPresence.EndDate == null)
            //         RegisterExit(selectedPresence);
        }

        private void dataGridViewPresence_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // var currentPresence = (Presence)dataGridViewPresence.Rows[e.RowIndex].DataBoundItem;
            // if (currentPresence.EndDate.HasValue)
            // {
            //     if (e.ColumnIndex != ColumnButtonExit.Index)
            //     {
            //         e.CellStyle.BackColor = Color.Gray;
            //         e.CellStyle.SelectionBackColor = Color.DimGray;
            //     }
            //     else
            //     {
            //         e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = Color.LightGray;
            //     }
            // }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            new FormReport().ShowDialog();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control && e.Shift && e.KeyCode == Keys.X)
                buttonLogout_Click(buttonExit, new EventArgs());
        }

        private void pictureBoxFace_Click(object sender, EventArgs e)
        {
            if (_lastDetectedFaces.Count == 0)
                return;

            if (++_facesIndex >= _lastDetectedFaces.Count)
                _facesIndex = 0;

            pictureBoxFace.Image = _lastDetectedFaces[_facesIndex];
        }

        private void ReadConfiguration()
        {
            if (!int.TryParse(ConfigurationManager.AppSettings["DetectionSize"], out _detectionSize))
                _detectionSize = 20;
            if (!int.TryParse(ConfigurationManager.AppSettings["DetectionNeighbors"], out _detectionNeighbors))
                _detectionNeighbors = 5;
            _printerDeviceInfo = ConfigurationManager.AppSettings["PrinterDeviceInfo"];
            if (!int.TryParse(ConfigurationManager.AppSettings["Width"], out _width))
                _width = 640;
            if (!int.TryParse(ConfigurationManager.AppSettings["Height"], out _height))
                _height = 480;
            if (!double.TryParse(ConfigurationManager.AppSettings["DetectionScaleFactor"], out _detectionScaleFactor))
                _detectionScaleFactor = 1.2;
            if (!int.TryParse(ConfigurationManager.AppSettings["FrameSkip"], out _frameSkip))
                _frameSkip = 0;
            _faceFileName = ConfigurationManager.AppSettings["FaceFileName"] ?? "lbpcascade_frontalface.xml";
            _cameraStreamUrl = ConfigurationManager.AppSettings["CameraStreamUrl"];
            _cameraUsername = ConfigurationManager.AppSettings["CameraUsername"];
            _cameraPassword = ConfigurationManager.AppSettings["CameraPassword"];
            _cameraDeviceName = ConfigurationManager.AppSettings["CameraDeviceName"];
            bool.TryParse(ConfigurationManager.AppSettings["AllowExit"], out _allowExit);
            buttonExit.Visible = _allowExit;
            bool.TryParse(ConfigurationManager.AppSettings["AlwaysOnTop"], out _alwaysOnTop);
            TopMost = _alwaysOnTop;
            bool.TryParse(ConfigurationManager.AppSettings["IsMotionDetected"], out _isMotionDetected);
            if (!Guid.TryParse(ConfigurationManager.AppSettings["GateId"], out _gateId)) return;
            // var gate = _entities.Gates.SingleOrDefault(g => g.Id == _gateId);
            // if (gate == null)
            {
                MessageBox.Show("خطا در انتخاب ورودی");
                Application.Exit();
                Environment.Exit(0);
            }
            // else
            // {
                // Globals.Gate = gate;
            // }

            _cascadeClassifier = new CascadeClassifier(_faceFileName);
            _backgroundSubtractor = new BackgroundSubtractorMOG2(50, 30, false);
        }

        private void ClearForm()
        {
            pictureBoxFace.Image = null;
            textBoxName.Text = string.Empty;
        }

        // private void RegisterExit(Presence selectedPresence)
        // {
        //     selectedPresence.EndDate = DateTime.Now;
        //     _entities.SaveChanges();
        // }

        private void CaptureCamera()
        {
            try
            {
                if (!string.IsNullOrEmpty(_cameraStreamUrl))
                {
                    _videoCapture = new VideoCapture(_cameraStreamUrl);
                    // if (_cameraStreamUrl.Contains("mjpg") || _cameraStreamUrl.Contains("mjpeg"))
                    // {
                        
                        // _camera = new MJPEGStream(_cameraStreamUrl)
                        // {
                        //     Login = _cameraUsername,
                        //     Password = _cameraPassword
                        // };
                    // }
                    // else
                    // {
                        // _camera = new JPEGStream(_cameraStreamUrl);
                        // ((JPEGStream)_camera).Login = _cameraUsername;
                        // ((JPEGStream)_camera).Password = _cameraPassword;
                    // }
                }
                else
                {
                    _videoCapture = new VideoCapture(1);
                    // var videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    // if (videoCaptureDevices.Count == 0)
                    if (_videoCapture.IsOpened)
                    {
                        MessageBox.Show("دوربینی به سیستم متصل نیست.", "خطا", MessageBoxButtons.OK);
                        return;
                    }

                    if (string.IsNullOrEmpty(_cameraDeviceName))
                    {
                        // var captureDevice = new VideoCaptureDevice(videoCaptureDevices[0].MonikerString);
                        // foreach (var capability in captureDevice.VideoCapabilities)
                        // {
                        //     if (capability.FrameSize.Width == _width || capability.FrameSize.Height == _height)
                        //         captureDevice.VideoResolution = capability;
                        //
                        //     if (capability.FrameSize.Width == _width && capability.FrameSize.Height == _height)
                        //         break;
                        // }
                        // _camera = captureDevice;
                    }
                    else
                    {
                        // foreach (FilterInfo device in videoCaptureDevices)
                        //     if (device.Name == _cameraDeviceName)
                        //     {
                        //         _camera = new VideoCaptureDevice(device.MonikerString);
                        //         break;
                        //     }
                        //
                        // if (_camera == null)
                        // {
                        //     MessageBox.Show("دوربین به سیستم متصل نیست: " + _cameraDeviceName, "خطا",
                        //         MessageBoxButtons.OK);
                        //     return;
                        // }
                    }
                }

                _videoCapture.ImageGrabbed += ProcessFrame;
                // _camera.NewFrame += ProcessFrame;
                // _camera.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show("خطا در اتصال به دوربین: " + e.Message, "خطا", MessageBoxButtons.OK);
            }
        }

        private void ProcessFrame(object? sender, EventArgs e)
        {
            if (_frameSkip != 0 && ++_skipIndex % _frameSkip != 0)
            {
                return;
            }
            Mat frame = new Mat();
            _videoCapture.Retrieve(frame);

            List<Bitmap> faces = null;
            
            // var frame = new Image<Bgr, byte>(e.Frame);
            if (frame.Width > _width)
            {
                CvInvoke.Resize(frame, frame, new Size(_width, _height), 2, 2, Inter.Linear);
            }
        
            try
            {
                pictureBoxCamera.Image = DetectFace(frame, out faces);
            }
            catch
            {
            }
        
            frame.Dispose();
        
            if (faces != null && faces.Count > 0)
                _lastDetectedFaces = faces;
        }

        private Bitmap DetectFace(Mat inputImage, out List<Bitmap> outputFaces)
        {
            outputFaces = new List<Bitmap>();
            Mat gray = new Mat();

            if (_isMotionDetected)
            {
                Mat resizedImage = new Mat();
                CvInvoke.Resize(inputImage, resizedImage, new Size(_width, _height), 2, 2, Inter.Linear);
                // var resizedImage = inputImage.Resize(150 * 1.0 / inputImage.Width, INTER.CV_INTER_LINEAR);

                
                CvInvoke.GaussianBlur(resizedImage, resizedImage, new Size(7, 7), 0, 0);
                
                _backgroundSubtractor.Apply(resizedImage, gray);
                resizedImage.Dispose();
                CvInvoke.Threshold(gray, gray, 50, 1, ThresholdType.Binary);
                CvInvoke.Dilate(gray, gray, null,
                    new Point(-1, -1), 7, BorderType.Default, new MCvScalar(1));
                CvInvoke.Resize(gray, gray, new Size(inputImage.Width, inputImage.Height), 2, 2, Inter.Linear);
                CvInvoke.CvtColor(inputImage, inputImage, ColorConversion.Bgr2Gray);
                CvInvoke.Multiply(inputImage, gray,gray);
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
                new Size(_detectionSize, _detectionSize),
                new Size());

            foreach (var f in facesDetected)
            {
                int x = Math.Min(Math.Min(f.Width / 10, f.X), inputImage.Width - f.Right);
                int y = Math.Min(Math.Min(f.Height / 5, f.Y), inputImage.Height - f.Bottom);
                outputFaces.Add(inputImage.ToBitmap().Clone(Rectangle.Inflate(f, x, y), PixelFormat.DontCare));
                CvInvoke.Rectangle(inputImage, f, new Bgr(Color.Blue).MCvScalar, 2);
            }

            gray.Dispose();
            return inputImage.ToBitmap().Clone(new Rectangle(0, 0, inputImage.Width, inputImage.Height), PixelFormat.DontCare);
        }


        private Bitmap DetectFaceOld(Mat image, out List<Bitmap> faces)
        {
            faces = new List<Bitmap>();
            // Image<Gray, byte> gray;

            if (_isMotionDetected)
            {
                // var resizedImage = inputImage.Resize(150 * 1.0 / inputImage.Width, INTER.CV_INTER_LINEAR);
                //
                // resizedImage._SmoothGaussian(7);
                //
                // _backgroundSubtractor.Update(resizedImage);
                // resizedImage.Dispose();
                // gray = _backgroundSubtractor.VarMax;
                // gray._ThresholdBinary(new Gray(50), new Gray(1));
                // gray._Dilate(7);
                // gray = gray.Resize(inputImage.Width, inputImage.Height, INTER.CV_INTER_LINEAR);
                // gray = inputImage.Convert<Gray, byte>().Mul(gray);
            }
            else
            {
                // gray = inputImage.Convert<Gray, byte>();
            }

            // gray._EqualizeHist();

            // var facesDetected = cascadeClassifier.DetectMultiScale(
            //     gray,
            //     _detectionScaleFactor,
            //     _detectionNeighbors,
            //     new Size(_detectionSize, _detectionSize),
            //     new Size());

            // foreach (var f in facesDetected)
            {
                // int x = Math.Min(Math.Min(f.Width / 10, f.X), inputImage.Width - f.Right);
                // int y = Math.Min(Math.Min(f.Height / 5, f.Y), inputImage.Height - f.Bottom);
                // outputFaces.Add(inputImage.Bitmap.Clone(Rectangle.Inflate(f, x, y), PixelFormat.DontCare));
                // inputImage.Draw(f, new Bgr(Color.Blue), 2);
            }

            // gray.Dispose();
            // return inputImage.Bitmap.Clone(new Rectangle(0, 0, inputImage.Width, inputImage.Height), PixelFormat.DontCare);
            return new Bitmap(0, 0);
        }

        // private void Export(LocalReport report)
        // {
        //     Warning[]
        //     Warning[] warnings;
        //     _streams = new List<Stream>();
        //     report.Render("Image", _printerDeviceInfo, CreateStream, out warnings);
        //     foreach (Stream stream in _streams)
        //         stream.Position = 0;
        // }

        private void Print()
        {
            if (_streams == null || _streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            var printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
                throw new Exception("Error: cannot find the default printer.");

            printDoc.PrintPage += PrintPage;
            _currentPageIndex = 0;
            printDoc.Print();
        }

        // private void PrintCard(Presence presence)
        // {
        //     var report = new LocalReport
        //     {
        //         ReportPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Card.rdlc"
        //     };
        //
        //     report.DataSources.Add(new ReportDataSource("DataSetPresence", new BindingSource(presence, null)));
        //     Export(report);
        //     Print();
        // }

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

            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            _currentPageIndex++;
            ev.HasMorePages = (_currentPageIndex < _streams.Count);
        }

        // private Presence SavePersonAndPresence()
        // {
        //     var person = _entities.People.SingleOrDefault(p => p.Fullname == textBoxName.Text && p.Gender == comboBoxGender.SelectedIndex > 0);
        //
        //     if (person == null)
        //     {
        //         person = new Person { Id = Guid.NewGuid(), Fullname = textBoxName.Text };
        //         _entities.People.Add(person);
        //     }
        //
        //     if (!person.Gender.HasValue)
        //         person.Gender = comboBoxGender.SelectedIndex > 0;
        //
        //     var presence = new Presence
        //     {
        //         Id = Guid.NewGuid(),
        //         Person = person,
        //         Host = (Host)comboBoxHosts.SelectedValue,
        //         StartDate = DateTime.Now,
        //         RegistrarUsername = Globals.User.Username,
        //         Gate = Globals.Gate
        //     };
        //
        //     if (pictureBoxFace.Image != null)
        //     {
        //         using (var imageStream = new MemoryStream())
        //         {
        //             pictureBoxFace.Image.Save(imageStream, ImageFormat.Jpeg);
        //             presence.Photo = imageStream.ToArray();
        //         }
        //     }
        //
        //     _entities.Presences.Add(presence);
        //     _entities.SaveChanges();
        //     bindingSourceTodayPresences.Insert(0, presence);
        //
        //     return presence;
        // }

        // private void ExtractFace()
        // {
        //     pictureBoxFace.Image = _lastDetectedFaces.Count > 0 ? _lastDetectedFaces[0] : null;
        //     var now = DateTime.Now;
        //     textBoxDate.Text = DateUtils.ToPersianDateString(now);
        //     textBoxStartTime.Text = DateUtils.ToPersianTimeString(now);
        // }

        private void RefreshDateTime()
        {
            // labelDateTime.Text = DateUtils.ToLongPersianDateTimeString(DateTime.Now);
        }

        private void FillHostsComboBox()
        {
            comboBoxHosts.DisplayMember = "Name";
            // comboBoxHosts.DataSource = (from h in _entities.Hosts
            //                             where h.GateId == Globals.Gate.Id
            //                             orderby h.Name
            //                             select h).ToList();
        }

        private void LoadTodayPresences()
        {
            _today = DateTime.Now.Date;
            var tomorrow = _today.AddDays(1);

            // var list = (from p in _entities.Presences
            //             where p.StartDate >= _today && p.StartDate < tomorrow && p.GateId == Globals.Gate.Id
            //             orderby p.StartDate descending
            //             select p).ToList();

            // bindingSourceTodayPresences.DataSource = list;
            // VisitorsCount = list.Count;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string yourpath = Environment.CurrentDirectory + @"\help\help.chm";

            if (File.Exists(yourpath))
            {
                Help.ShowHelp(this, yourpath);
            }
            else
            {
                MessageBox.Show("فایل راهنما موجود نمی باشد.‏");
            }
        }

        private void UpdateLabels()
        {
            labelVisitorsCount.Text = "تعداد مراجعین " + VisitorsCount;
        }
    }
}

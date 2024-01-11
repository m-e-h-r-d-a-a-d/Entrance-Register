using Emgu.CV;
using Emgu.CV.CvEnum;

namespace EntranceRegister.AI;
internal class FaceDetectorCascade : IFaceDetectior
{

    private CascadeClassifier _cascadeClassifier;
    private MotionDetector _motionDetector;
    private double _detectionScaleFactor;
    private int _detectionNeighbors;
    private int _detectionSize;
    private bool _isMotionDetected;
    private int _width;
    private int _height;


    public FaceDetectorCascade(CascadeClassifier cascadeClassifier, MotionDetector motionDetector, double detectionScaleFactor, int detectionNeighbors, int detectionSize, bool isMotionDetected, int width, int height)
    {
        _cascadeClassifier = cascadeClassifier;
        _motionDetector = motionDetector;
        _detectionScaleFactor = detectionScaleFactor;
        _detectionNeighbors = detectionNeighbors;
        _detectionSize = detectionSize;
        _isMotionDetected = isMotionDetected;
        _height = height;
        _width = width;
    }

    public Size InputSize { get; set; }

    public List<Rectangle> DetectFace(Mat inputImage)
    {
        //todo not important
        if (inputImage.Width > _width)
        {
            double scale = (double)_width / inputImage.Width;
            CvInvoke.Resize(inputImage, inputImage, new Size((int)(scale * inputImage.Width), (int)(scale * inputImage.Height)), 2, 2, Inter.Linear);
        }



        using var gray = new Mat();
        if (_isMotionDetected)
        {
            var outputImage = new Mat();
            _motionDetector.DetectMotion(inputImage, outputImage);
            CvInvoke.CvtColor(outputImage, gray, ColorConversion.Bgr2Gray);
        }
        else
        {
            CvInvoke.CvtColor(inputImage, gray, ColorConversion.Bgr2Gray);
        }

        CvInvoke.EqualizeHist(gray, gray);
        var facesDetected = _cascadeClassifier.DetectMultiScale(gray, _detectionScaleFactor, _detectionNeighbors,
            new Size(_detectionSize, _detectionSize));

        return facesDetected.ToList();
    }


}

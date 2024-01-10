using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EntranceRegister;
internal class FaceDetectorYunet : IFaceDetectior
{
    private FaceDetectorYN _faceDetector;
    private MotionDetector _motionDetector;
    private bool _isMotionDetected;


    public FaceDetectorYunet(FaceDetectorYN faceDetector, MotionDetector motionDetector, bool isMotionDetected)
    {
        _faceDetector = faceDetector;
        _motionDetector = motionDetector;
        _isMotionDetected = isMotionDetected;
    }

    public Size InputSize
    {
        get
        {
            return _faceDetector.InputSize;
        }

        set
        {
            _faceDetector.InputSize = value;
        }
    }

    public List<Rectangle> DetectFace(Mat inputImage)
    {
        using var faces = new Mat();
        if (_isMotionDetected)
        {
            Mat outputImage = new Mat();
            _motionDetector.DetectMotion(inputImage, outputImage);
            _faceDetector.Detect(outputImage, faces);
        }
        else
        {
            _faceDetector.Detect(inputImage, faces);
        }

        List<Rectangle> facesRectangle = new List<Rectangle>();
        for (int i = 0; i < faces.Rows; i++)
        {
            facesRectangle.Add(new Rectangle((int)GetValue(faces, i, 0), (int)GetValue(faces, i, 1),
                (int)GetValue(faces, i, 2), (int)GetValue(faces, i, 3)));
        }

        return facesRectangle;
    }

    private dynamic GetValue(Mat mat, int row, int col)
    {
        dynamic value = CreateElement(mat.Depth);
        Marshal.Copy(mat.DataPointer + (row * mat.Cols + col) * mat.ElementSize, value, 0, 1);
        return value[0];
    }

    private dynamic CreateElement(DepthType depthType)
    {
        return depthType switch
        {
            DepthType.Cv8S => new sbyte[1],
            DepthType.Cv8U => new byte[1],
            DepthType.Cv16S => new short[1],
            DepthType.Cv16U => new ushort[1],
            DepthType.Cv32S => new int[1],
            DepthType.Cv32F => new float[1],
            DepthType.Cv64F => new double[1],
            _ => new float[1]
        };
    }

    private void Visualize(Mat input, Mat faces, double fps = 30, int thickness = 2)
    {
        for (int i = 0; i < faces.Rows; i++)
        {

            // Draw bounding box
            CvInvoke.Rectangle(input, new Rectangle((int)GetValue(faces, i, 0), (int)GetValue(faces, i, 1), (int)GetValue(faces, i, 2), (int)GetValue(faces, i, 3)), new Bgr(Color.Blue).MCvScalar, thickness);
            // // Draw landmarks
            CvInvoke.Circle(input, new Point((int)GetValue(faces, i, 4), (int)GetValue(faces, i, 5)), 2, new Bgr(Color.Red).MCvScalar, thickness);
            CvInvoke.Circle(input, new Point((int)GetValue(faces, i, 6), (int)GetValue(faces, i, 7)), 2, new Bgr(Color.Red).MCvScalar, thickness);
            CvInvoke.Circle(input, new Point((int)GetValue(faces, i, 8), (int)GetValue(faces, i, 9)), 2, new Bgr(Color.Red).MCvScalar, thickness);
            CvInvoke.Circle(input, new Point((int)GetValue(faces, i, 10), (int)GetValue(faces, i, 11)), 2, new Bgr(Color.Red).MCvScalar, thickness);
            CvInvoke.Circle(input, new Point((int)GetValue(faces, i, 12), (int)GetValue(faces, i, 13)), 2, new Bgr(Color.Red).MCvScalar, thickness);
        }
    }
}

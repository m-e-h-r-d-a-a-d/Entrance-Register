
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EntranceRegister;

internal class MotionDetector
{
    private readonly BackgroundSubtractorMOG2 _backgroundSubtractor;
    private readonly double _subtractorWith;
    private readonly Mat _mask;
    private readonly Mat _background;

    public MotionDetector(BackgroundSubtractorMOG2 backgroundSubtractor, int subtractorWith)
    {
        _subtractorWith = subtractorWith;
        _backgroundSubtractor = backgroundSubtractor;
        _mask = new Mat();
        _background = new Mat();
    }

    public void DetectMotion(Mat inputImage, Mat outputImage)
    {
        double scale = _subtractorWith / inputImage.Width;
        CvInvoke.Resize(inputImage, _background, new Size((int)(scale * inputImage.Width), (int)(scale * inputImage.Height)), 2, 2, Inter.Linear);
        CvInvoke.GaussianBlur(_background, _background, new Size(7, 7), 0, 0);

        _backgroundSubtractor.Apply(_background, _mask);
        CvInvoke.Threshold(_mask, _mask, 50, 1, ThresholdType.Binary);
        CvInvoke.Dilate(_mask, _mask, null,
            new Point(-1, -1), 7, BorderType.Default, new MCvScalar(1));
        CvInvoke.Resize(_mask, _mask, new Size(inputImage.Width, inputImage.Height), 2, 2, Inter.Linear);
        CvInvoke.CvtColor(_mask, _mask, ColorConversion.Gray2Bgr);
        CvInvoke.Multiply(_mask, inputImage, outputImage);
    }
}

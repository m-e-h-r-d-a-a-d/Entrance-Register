using Emgu.CV;

namespace EntranceRegister;
internal interface IFaceDetectior
{
    Size InputSize { get; set; }
    List<Rectangle> DetectFace(Mat inputImage);
}

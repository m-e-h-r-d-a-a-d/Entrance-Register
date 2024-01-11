using Emgu.CV;

namespace EntranceRegister.AI;
internal interface IFaceDetectior
{
    Size InputSize { get; set; }
    List<Rectangle> DetectFace(Mat inputImage);
}

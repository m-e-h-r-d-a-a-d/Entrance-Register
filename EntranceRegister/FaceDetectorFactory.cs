﻿using Emgu.CV;

namespace EntranceRegister;

internal enum FaceDetectionType
{
    Yunet = 0,
    Cascade = 1

}

internal class FaceDetectorFactory
{
    public IFaceDetectior FactoryMethod(FaceDetectionType detectionType, string faceFileName, double detectionScaleFactor, int detectionNeighbors, int detectionSize, bool isMotionDetected, int width, int height)
    {
        BackgroundSubtractorMOG2 backgroundSubtractor = new BackgroundSubtractorMOG2(50, 30, false);
        MotionDetector mg = new MotionDetector(backgroundSubtractor, 150);
        switch (detectionType)
        {
            case FaceDetectionType.Cascade:
                CascadeClassifier cascadeClassifier = new CascadeClassifier(faceFileName);
                return new FaceDetectorCascade(cascadeClassifier, mg, detectionScaleFactor,
                    detectionNeighbors, detectionSize, isMotionDetected, width, height);


            case FaceDetectionType.Yunet:
            default:
                FaceDetectorYN faceDetectorYn = new FaceDetectorYN(@"Resources\face_detection_yunet_2023mar.onnx", "", new Size(width, height));
                return new FaceDetectorYunet(faceDetectorYn, mg, isMotionDetected);
        }
    }
}

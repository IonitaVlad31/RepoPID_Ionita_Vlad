using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace Algorithms.Sections
{
    public class PointwiseOperations
    {
        #region Contrast and Brightness

        public static byte[] ContrastBrightness(double a, double b)
        {
            byte[] LUT = new byte[256];
            for (int r = 0; r < 256; r++)
            {
                double s = a * r + b;
                s = Math.Max(0, Math.Min(255, s));
                LUT[r] = (byte)(Math.Round(a * r + b));
            }
            return LUT;
        }

        public static Image<Gray, byte> ContrastBrightness(Image<Gray, byte> inputImage, double a, double b)
        {
            Image<Gray, byte> outputImage = new Image<Gray, byte>(inputImage.Size);

        }
    }
}
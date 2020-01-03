using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.GLFW
{
    public sealed class GLFWImage
    {
        internal IntPtr Handle { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public byte[] Pixels {get; private set;}

        public GLFWImage(int width, int height, byte[] pixeldata)
        {
            if (pixeldata.Length != (width * height) * 4)
                throw new ArgumentException($"Expected a pixel array of size {(width * height) * 4} but got {pixeldata.Length}. " +
                    $"The pixels need to be 4 byte each. 1 byte per color channel (R,G,B,A). The pixeldata array needs to be width * height * 4 in length.");
            Handle = Glfw_HelperFunctions.__CreateGlfwImage();
            Width = width;
            Height = height;
            SetPixels(pixeldata);
        }

        void SetPixels(byte[] pixels)
        {
            unsafe
            {
                fixed (byte* p = &pixels[0])
                Glfw_HelperFunctions.__SetGlfwImagePixels(Handle, Width,Height,p, pixels.Length);
                this.Pixels = pixels;
            }
        }
    }
}

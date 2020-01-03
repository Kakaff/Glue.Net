using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public sealed class GLFWgammaramp
    {
        IntPtr nativeHandle;
        ushort[] red, green, blue;
        uint size;

        public ushort[] Red => red;
        public ushort[] Blue => blue;
        public ushort[] Green => green;
        public uint Size => size;
        internal IntPtr Handle => nativeHandle;

        internal GLFWgammaramp()
        {
            nativeHandle = Glfw_HelperFunctions.__CreateGammaRamp();
        }

        ~GLFWgammaramp()
        {
            Glfw_HelperFunctions.__DestroyGammaRamp(Handle);
        }

        internal GLFWgammaramp(IntPtr nativeHandle)
        {
            this.nativeHandle = nativeHandle;
            __GetValues();
        }

        public void SetValues(ushort[] red, ushort[] blue, ushort[] green)
        {
            if (red.Length != blue.Length && red.Length != green.Length)
                throw new ArgumentException("The arrays need to be of the same size");

            this.red = red;
            this.green = green;
            this.blue = blue;
            size = (uint)red.Length;
            unsafe
            {
                fixed (ushort* r = &red[0])
                fixed (ushort* g = &green[0])
                fixed (ushort* b = &blue[0])
                    Glfw_HelperFunctions.__UpdateGammaRampValues(Handle,r, g, b, size);
            }
        }

        void __GetValues()
        {
            //probably not the best way of doing things but it should do the trick, 
            //this isn't something that should be called often anyways.
            unsafe
            {
                Glfw_HelperFunctions.__GetGammaRampValues(Handle,out ushort* r, out ushort* g, out ushort* b, out uint size);
                red = new ushort[size];
                green = new ushort[size];
                blue = new ushort[size];
                
                for (int i = 0; i < this.size; i++)
                {
                    red[i] = r[i];
                    green[i] = g[i];
                    blue[i] = b[i];
                }
            }
        }
    }
}

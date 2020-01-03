using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public sealed class GLFWVideoMode
    {
        internal IntPtr Handle { get; private set; }

        public int Width { get; private set; }
        public int Height { get; private set; }
        
        public int RedBits { get; private set; }
        public int GreenBits { get; private set; }
        public int BlueBits { get; private set; }
        public int RefreshRate { get; private set; }
 
        private GLFWVideoMode() { }

        internal GLFWVideoMode(IntPtr handle)
        {
            Handle = handle;
            Glfw_HelperFunctions.__GetVideoModeValues(handle,
                    out int width,
                    out int height, out int red, out int green, out int blue, out int refresh);
            Width = width;
            Height = height;
            RedBits = red;
            GreenBits = green;
            BlueBits = blue;
            RefreshRate = refresh;
        }

        internal static unsafe GLFWVideoMode[] __LoadVideoModes(GLFWMonitor monitor, out GLFWVideoMode activeMode)
        {
            IntPtr* nptrArr = Glfw_HelperFunctions.__GetVideoModes(monitor.Handle, out int count);
            IntPtr active = Glfw.__GetVideoMode(monitor.Handle);

            GLFWVideoMode[] modeArr = new GLFWVideoMode[count];
            activeMode = null;

            for (int i = 0; i < count; i++)
            {
                modeArr[i] = new GLFWVideoMode(nptrArr[i]);
                if (nptrArr[i].Equals(active))
                    activeMode = modeArr[i];
            }

            //Cleanup the array we created to store the pointers to the videomodes.
            Glfw_HelperFunctions.__DeleteVideoModeArr(nptrArr);

            return modeArr;
        }
    }
}

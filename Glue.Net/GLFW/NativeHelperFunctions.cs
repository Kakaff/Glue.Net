/* Provides various functions for retrieving and 
 * setting the values of structs used by glfw.
 * 
 * As well as for retrieving those structs.
 */


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    internal static partial class Glfw_HelperFunctions
    {
        public static void GetVideoModeValues(GLFWVideoMode vidmode, out int width, out int height, out int redbits, out int greenbits, out int bluebits, out int refreshrate)
        {
            width = vidmode.Width;
            height = vidmode.Height;
            redbits = vidmode.RedBits;
            greenbits = vidmode.GreenBits;
            bluebits = vidmode.BlueBits;
            refreshrate = vidmode.RefreshRate;
        }

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "GetVideoModeValues"
            )]
        internal static extern void __GetVideoModeValues(IntPtr videoMode, out int width, out int height, out int redbits, out int greenbits, out int bluebits, out int refreshrate);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "GetVideoModes"
            )]
        internal static unsafe extern IntPtr* __GetVideoModes(IntPtr monitor, out int count);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "DeleteVideoModeArr"
            )]
        internal static unsafe extern IntPtr* __DeleteVideoModeArr(IntPtr* arr);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "CreateIconArray"
            )]
        internal static unsafe extern IntPtr __CreateIconArray(IntPtr[] iconArr, int count);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "DeleteWindowIconArr"
            )]
        internal static extern void __DeleteWindowIconArr(IntPtr iconArr);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "CreateGammaRamp"
            )]
        internal static extern IntPtr __CreateGammaRamp();

        /// <summary>
        /// Creates a new gamma ramp as a clone of another gammaramp.
        /// </summary>
        /// <param name="gammaramp"></param>
        /// <returns></returns>
        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "CreateGammaRampClone"
            )]
        internal static extern IntPtr __CreateGammaRamp(IntPtr gammaramp);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "DestroyGammaRamp"
            )]
        internal static extern void __DestroyGammaRamp(IntPtr handle);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "SetGammaRampValues"
            )]
        internal static unsafe extern void __UpdateGammaRampValues(IntPtr handle, ushort* red, ushort* green, ushort* blue, uint size);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "GetGammaRampValues"
            )]
        internal static unsafe extern void __GetGammaRampValues(IntPtr handle, out ushort* red, out ushort* green, out ushort* blue, out uint size);

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "CreateGLFWImage"
            )]
        internal static extern IntPtr __CreateGlfwImage();

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "SetGlfwImageData"
            )]
        internal static unsafe extern void __SetGlfwImagePixels(IntPtr handle, int width, int height, byte* pixels, int length);
    }
}

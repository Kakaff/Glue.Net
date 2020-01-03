using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace GlueNet.Freetype
{
    public sealed class FT_Face
    {
        internal IntPtr handle;
        private FT_Face() { handle = __CreateNativeFT_FACE_Handle(); }

        ~FT_Face()
        {
            __DeleteNativeHandle(handle);
        }

        public void SetPixelSize(uint width, uint height)
        {
            int err = __FT_Set_PixelSize(handle, width, height);
            if (err != 0)
                throw new Exception($"Error setting pixel size, error: {err}");
        }

        public static unsafe FT_Face Create(FT_Library lib, string fontPath, int index)
        {
            FT_Face ff = new FT_Face();
            int err = __CreateNativeFT_FACE(lib.handle, fontPath, index, ff.handle);

            if (ff.handle == IntPtr.Zero)
                Console.WriteLine("ERROR, POINTER IS ZERO");

            if (err != 0)
                throw new Exception($"Error: {err}");

            return ff;
        }


        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "CreateFT_FACE"), SuppressUnmanagedCodeSecurity]
        private static unsafe extern int __CreateNativeFT_FACE(IntPtr lib,string path,int index, IntPtr face);

        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "Create_FT_FACE_Handle"), SuppressUnmanagedCodeSecurity]
        private static extern IntPtr __CreateNativeFT_FACE_Handle();

        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "DestroyFT_FACE"), SuppressUnmanagedCodeSecurity]
        private static extern void __DeleteNativeHandle(IntPtr nativeHandle);

        [DllImport("Glue.Net-Native.dll",
            CharSet = CharSet.Unicode,
            CallingConvention = CallingConvention.StdCall,
            EntryPoint = "FTFACE_Set_PixelSize"), SuppressUnmanagedCodeSecurity]
        private static extern int __FT_Set_PixelSize(IntPtr face,uint width, uint height);
    }
}

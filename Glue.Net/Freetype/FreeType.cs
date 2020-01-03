using GlueNet.Freetype;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet
{
    public static partial class FreeType
    {
        public static bool Init(out FT_Library lib,out int err)
        {
            lib = new FT_Library(__InitFreeType(out err));
            return err == 0;
        }


        [DllImport("Glue.Net-Native.dll",EntryPoint = "InitFreeType")]
        internal static unsafe extern IntPtr __InitFreeType(out int err);
    }
}

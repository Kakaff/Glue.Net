using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.Freetype
{
    public sealed class FT_Library
    {
        public IntPtr Handle => handle;

        internal IntPtr handle;

        private FT_Library() { }
        internal FT_Library(IntPtr handle) { this.handle = handle; }
    }
}

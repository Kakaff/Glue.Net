using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_pixel_buffer_object {get; private set;}

		public const int GL_PIXEL_PACK_BUFFER_EXT = 0x88EB;
		public const int GL_PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
		public const int GL_PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
		public const int GL_PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;

   

	}
}


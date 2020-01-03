using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_pixel_buffer_object {get; private set;}

		public const int GL_PIXEL_PACK_BUFFER_ARB = 0x88EB;
		public const int GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
		public const int GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
		public const int GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;

   

	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_swizzle {get; private set;}

		public const int GL_TEXTURE_SWIZZLE_R = 0x8E42;
		public const int GL_TEXTURE_SWIZZLE_G = 0x8E43;
		public const int GL_TEXTURE_SWIZZLE_B = 0x8E44;
		public const int GL_TEXTURE_SWIZZLE_A = 0x8E45;
		public const int GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;

   

	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_compression_bptc {get; private set;}

		public const int GL_COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;
		public const int GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;
		public const int GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;
		public const int GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;

   

	}
}


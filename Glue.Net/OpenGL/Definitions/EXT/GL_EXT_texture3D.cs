using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture3D {get; private set;}

		public const int GL_PACK_SKIP_IMAGES_EXT = 0x806B;
		public const int GL_PACK_IMAGE_HEIGHT_EXT = 0x806C;
		public const int GL_UNPACK_SKIP_IMAGES_EXT = 0x806D;
		public const int GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E;
		public const int GL_TEXTURE_3D_EXT = 0x806F;
		public const int GL_PROXY_TEXTURE_3D_EXT = 0x8070;
		public const int GL_TEXTURE_DEPTH_EXT = 0x8071;
		public const int GL_TEXTURE_WRAP_R_EXT = 0x8072;
		public const int GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexImage3DEXT(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);

 		static __glTexImage3DEXT __GlueTexImage3DEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexImage3DEXT(uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels) => __GlueTexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels);



	}
}


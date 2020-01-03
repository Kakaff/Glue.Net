using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_storage {get; private set;}

		public const int GL_R32F_EXT = 0x822E;
		public const int GL_RG32F_EXT = 0x8230;
		public const int GL_RGBA32F_EXT = 0x8814;
		public const int GL_RGB32F_EXT = 0x8815;
		public const int GL_ALPHA32F_EXT = 0x8816;
		public const int GL_LUMINANCE32F_EXT = 0x8818;
		public const int GL_LUMINANCE_ALPHA32F_EXT = 0x8819;
		public const int GL_ALPHA16F_EXT = 0x881C;
		public const int GL_LUMINANCE16F_EXT = 0x881E;
		public const int GL_LUMINANCE_ALPHA16F_EXT = 0x881F;
		public const int GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage1DEXT(uint target, int levels, uint internalformat, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage2DEXT(uint target, int levels, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage3DEXT(uint target, int levels, uint internalformat, int width, int height, int depth);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage1DEXT(uint texture, uint target, int levels, uint internalformat, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage2DEXT(uint texture, uint target, int levels, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage3DEXT(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth);

 		static __glTexStorage1DEXT __GlueTexStorage1DEXT;
		static __glTexStorage2DEXT __GlueTexStorage2DEXT;
		static __glTexStorage3DEXT __GlueTexStorage3DEXT;
		static __glTextureStorage1DEXT __GlueTextureStorage1DEXT;
		static __glTextureStorage2DEXT __GlueTextureStorage2DEXT;
		static __glTextureStorage3DEXT __GlueTextureStorage3DEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage1DEXT(uint target, int levels, uint internalformat, int width) => __GlueTexStorage1DEXT(target, levels, internalformat, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage2DEXT(uint target, int levels, uint internalformat, int width, int height) => __GlueTexStorage2DEXT(target, levels, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage3DEXT(uint target, int levels, uint internalformat, int width, int height, int depth) => __GlueTexStorage3DEXT(target, levels, internalformat, width, height, depth);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage1DEXT(uint texture, uint target, int levels, uint internalformat, int width) => __GlueTextureStorage1DEXT(texture, target, levels, internalformat, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage2DEXT(uint texture, uint target, int levels, uint internalformat, int width, int height) => __GlueTextureStorage2DEXT(texture, target, levels, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage3DEXT(uint texture, uint target, int levels, uint internalformat, int width, int height, int depth) => __GlueTextureStorage3DEXT(texture, target, levels, internalformat, width, height, depth);



	}
}


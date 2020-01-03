using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_compression {get; private set;}

		public const int GL_COMPRESSED_ALPHA_ARB = 0x84E9;
		public const int GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
		public const int GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
		public const int GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
		public const int GL_COMPRESSED_RGB_ARB = 0x84ED;
		public const int GL_COMPRESSED_RGBA_ARB = 0x84EE;
		public const int GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
		public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
		public const int GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
		public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
		public const int GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCompressedTexImageARB(uint target, int lod, IntPtr img);

 		static __glCompressedTexImage1DARB __GlueCompressedTexImage1DARB;
		static __glCompressedTexImage2DARB __GlueCompressedTexImage2DARB;
		static __glCompressedTexImage3DARB __GlueCompressedTexImage3DARB;
		static __glCompressedTexSubImage1DARB __GlueCompressedTexSubImage1DARB;
		static __glCompressedTexSubImage2DARB __GlueCompressedTexSubImage2DARB;
		static __glCompressedTexSubImage3DARB __GlueCompressedTexSubImage3DARB;
		static __glGetCompressedTexImageARB __GlueGetCompressedTexImageARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data) => __GlueCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data) => __GlueCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data) => __GlueCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => __GlueCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => __GlueCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => __GlueCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCompressedTexImageARB(uint target, int lod, IntPtr img) => __GlueGetCompressedTexImageARB(target, lod, img);



	}
}


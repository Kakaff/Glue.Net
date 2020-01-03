using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_get_texture_sub_image {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);

 		static __glGetCompressedTextureSubImage __GlueGetCompressedTextureSubImage;
		static __glGetTextureSubImage __GlueGetTextureSubImage;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels) => __GlueGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels) => __GlueGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);



	}
}


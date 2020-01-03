using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_subtexture {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexSubImage1DEXT(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

 		static __glTexSubImage1DEXT __GlueTexSubImage1DEXT;
		static __glTexSubImage2DEXT __GlueTexSubImage2DEXT;
		static __glTexSubImage3DEXT __GlueTexSubImage3DEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexSubImage1DEXT(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => __GlueTexSubImage1DEXT(target, level, xoffset, width, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => __GlueTexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => __GlueTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);



	}
}


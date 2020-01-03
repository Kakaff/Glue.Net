using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_copy_texture {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexImage1DEXT(uint target, int level, uint internalformat, int x, int y, int width, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexImage2DEXT(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexSubImage1DEXT(uint target, int level, int xoffset, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

 		static __glCopyTexImage1DEXT __GlueCopyTexImage1DEXT;
		static __glCopyTexImage2DEXT __GlueCopyTexImage2DEXT;
		static __glCopyTexSubImage1DEXT __GlueCopyTexSubImage1DEXT;
		static __glCopyTexSubImage2DEXT __GlueCopyTexSubImage2DEXT;
		static __glCopyTexSubImage3DEXT __GlueCopyTexSubImage3DEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexImage1DEXT(uint target, int level, uint internalformat, int x, int y, int width, int border) => __GlueCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexImage2DEXT(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) => __GlueCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexSubImage1DEXT(uint target, int level, int xoffset, int x, int y, int width) => __GlueCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexSubImage2DEXT(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => __GlueCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexSubImage3DEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => __GlueCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);



	}
}


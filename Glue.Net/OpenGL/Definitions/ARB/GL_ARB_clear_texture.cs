using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_clear_texture {get; private set;}

		public const int GL_CLEAR_TEXTURE = 0x9365;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearTexImage(uint texture, int level, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);

 		static __glClearTexImage __GlueClearTexImage;
		static __glClearTexSubImage __GlueClearTexSubImage;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearTexImage(uint texture, int level, uint format, uint type, IntPtr data) => __GlueClearTexImage(texture, level, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data) => __GlueClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);



	}
}


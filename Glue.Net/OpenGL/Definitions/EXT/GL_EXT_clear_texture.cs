using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_clear_texture {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearTexImageEXT(uint texture, int level, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearTexSubImageEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);

 		static __glClearTexImageEXT __GlueClearTexImageEXT;
		static __glClearTexSubImageEXT __GlueClearTexSubImageEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearTexImageEXT(uint texture, int level, uint format, uint type, IntPtr data) => __GlueClearTexImageEXT(texture, level, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearTexSubImageEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data) => __GlueClearTexSubImageEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);



	}
}


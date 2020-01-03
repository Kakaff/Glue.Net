using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_color_subtable {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorSubTableEXT(uint target, int start, int count, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyColorSubTableEXT(uint target, int start, int x, int y, int width);

 		static __glColorSubTableEXT __GlueColorSubTableEXT;
		static __glCopyColorSubTableEXT __GlueCopyColorSubTableEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorSubTableEXT(uint target, int start, int count, uint format, uint type, IntPtr data) => __GlueColorSubTableEXT(target, start, count, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyColorSubTableEXT(uint target, int start, int x, int y, int width) => __GlueCopyColorSubTableEXT(target, start, x, y, width);



	}
}


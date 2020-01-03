using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_multi_draw_indirect {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawArraysIndirectEXT(uint mode, IntPtr indirect, int drawcount, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsIndirectEXT(uint mode, uint type, IntPtr indirect, int drawcount, int stride);

 		static __glMultiDrawArraysIndirectEXT __GlueMultiDrawArraysIndirectEXT;
		static __glMultiDrawElementsIndirectEXT __GlueMultiDrawElementsIndirectEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawArraysIndirectEXT(uint mode, IntPtr indirect, int drawcount, int stride) => __GlueMultiDrawArraysIndirectEXT(mode, indirect, drawcount, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsIndirectEXT(uint mode, uint type, IntPtr indirect, int drawcount, int stride) => __GlueMultiDrawElementsIndirectEXT(mode, type, indirect, drawcount, stride);



	}
}


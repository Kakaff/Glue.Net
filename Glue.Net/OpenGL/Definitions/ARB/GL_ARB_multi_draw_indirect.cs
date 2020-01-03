using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_multi_draw_indirect {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawArraysIndirect(uint mode, IntPtr indirect, int primcount, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int primcount, int stride);

 		static __glMultiDrawArraysIndirect __GlueMultiDrawArraysIndirect;
		static __glMultiDrawElementsIndirect __GlueMultiDrawElementsIndirect;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawArraysIndirect(uint mode, IntPtr indirect, int primcount, int stride) => __GlueMultiDrawArraysIndirect(mode, indirect, primcount, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsIndirect(uint mode, uint type, IntPtr indirect, int primcount, int stride) => __GlueMultiDrawElementsIndirect(mode, type, indirect, primcount, stride);



	}
}


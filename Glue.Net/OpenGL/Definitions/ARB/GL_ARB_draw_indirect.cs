using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_draw_indirect {get; private set;}

		public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
		public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysIndirect(uint mode, IntPtr indirect);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsIndirect(uint mode, uint type, IntPtr indirect);

 		static __glDrawArraysIndirect __GlueDrawArraysIndirect;
		static __glDrawElementsIndirect __GlueDrawElementsIndirect;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysIndirect(uint mode, IntPtr indirect) => __GlueDrawArraysIndirect(mode, indirect);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsIndirect(uint mode, uint type, IntPtr indirect) => __GlueDrawElementsIndirect(mode, type, indirect);



	}
}


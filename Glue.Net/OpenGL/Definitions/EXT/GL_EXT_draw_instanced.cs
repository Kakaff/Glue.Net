using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_draw_instanced {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysInstancedEXT(uint mode, int start, int count, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedEXT(uint mode, int count, uint type, IntPtr indices, int primcount);

 		static __glDrawArraysInstancedEXT __GlueDrawArraysInstancedEXT;
		static __glDrawElementsInstancedEXT __GlueDrawElementsInstancedEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysInstancedEXT(uint mode, int start, int count, int primcount) => __GlueDrawArraysInstancedEXT(mode, start, count, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedEXT(uint mode, int count, uint type, IntPtr indices, int primcount) => __GlueDrawElementsInstancedEXT(mode, count, type, indices, primcount);



	}
}


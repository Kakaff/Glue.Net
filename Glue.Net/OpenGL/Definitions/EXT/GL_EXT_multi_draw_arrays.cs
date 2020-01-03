using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_multi_draw_arrays {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawArraysEXT(uint mode, int* first, int* count, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsEXT(uint mode, int* count, uint type, IntPtr* indices, int primcount);

 		static __glMultiDrawArraysEXT __GlueMultiDrawArraysEXT;
		static __glMultiDrawElementsEXT __GlueMultiDrawElementsEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawArraysEXT(uint mode, int* first, int* count, int primcount) => __GlueMultiDrawArraysEXT(mode, first, count, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsEXT(uint mode, int* count, uint type, IntPtr* indices, int primcount) => __GlueMultiDrawElementsEXT(mode, count, type, indices, primcount);



	}
}


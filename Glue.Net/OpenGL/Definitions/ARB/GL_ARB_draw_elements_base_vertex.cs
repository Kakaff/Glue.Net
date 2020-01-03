using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_draw_elements_base_vertex {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int primcount, int basevertex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsBaseVertex(uint mode, int* count, uint type, IntPtr* indices, int primcount, int* basevertex);

 		static __glDrawElementsBaseVertex __GlueDrawElementsBaseVertex;
		static __glDrawElementsInstancedBaseVertex __GlueDrawElementsInstancedBaseVertex;
		static __glDrawRangeElementsBaseVertex __GlueDrawRangeElementsBaseVertex;
		static __glMultiDrawElementsBaseVertex __GlueMultiDrawElementsBaseVertex;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int basevertex) => __GlueDrawElementsBaseVertex(mode, count, type, indices, basevertex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, IntPtr indices, int primcount, int basevertex) => __GlueDrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex) => __GlueDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsBaseVertex(uint mode, int* count, uint type, IntPtr* indices, int primcount, int* basevertex) => __GlueMultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);



	}
}


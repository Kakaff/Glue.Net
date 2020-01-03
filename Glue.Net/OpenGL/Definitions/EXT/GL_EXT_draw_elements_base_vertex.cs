using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_draw_elements_base_vertex {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsBaseVertexEXT(uint mode, int count, uint type, IntPtr indices, int basevertex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedBaseVertexEXT(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawRangeElementsBaseVertexEXT(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsBaseVertexEXT(uint mode, int* count, uint type, IntPtr* indices, int primcount, int* basevertex);

 		static __glDrawElementsBaseVertexEXT __GlueDrawElementsBaseVertexEXT;
		static __glDrawElementsInstancedBaseVertexEXT __GlueDrawElementsInstancedBaseVertexEXT;
		static __glDrawRangeElementsBaseVertexEXT __GlueDrawRangeElementsBaseVertexEXT;
		static __glMultiDrawElementsBaseVertexEXT __GlueMultiDrawElementsBaseVertexEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsBaseVertexEXT(uint mode, int count, uint type, IntPtr indices, int basevertex) => __GlueDrawElementsBaseVertexEXT(mode, count, type, indices, basevertex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedBaseVertexEXT(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex) => __GlueDrawElementsInstancedBaseVertexEXT(mode, count, type, indices, instancecount, basevertex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawRangeElementsBaseVertexEXT(uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex) => __GlueDrawRangeElementsBaseVertexEXT(mode, start, end, count, type, indices, basevertex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsBaseVertexEXT(uint mode, int* count, uint type, IntPtr* indices, int primcount, int* basevertex) => __GlueMultiDrawElementsBaseVertexEXT(mode, count, type, indices, primcount, basevertex);



	}
}


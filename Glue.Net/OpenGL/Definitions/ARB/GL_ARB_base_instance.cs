using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_base_instance {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int primcount, uint baseinstance);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int primcount, uint baseinstance);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int primcount, int basevertex, uint baseinstance);

 		static __glDrawArraysInstancedBaseInstance __GlueDrawArraysInstancedBaseInstance;
		static __glDrawElementsInstancedBaseInstance __GlueDrawElementsInstancedBaseInstance;
		static __glDrawElementsInstancedBaseVertexBaseInstance __GlueDrawElementsInstancedBaseVertexBaseInstance;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int primcount, uint baseinstance) => __GlueDrawArraysInstancedBaseInstance(mode, first, count, primcount, baseinstance);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, IntPtr indices, int primcount, uint baseinstance) => __GlueDrawElementsInstancedBaseInstance(mode, count, type, indices, primcount, baseinstance);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, IntPtr indices, int primcount, int basevertex, uint baseinstance) => __GlueDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, primcount, basevertex, baseinstance);



	}
}


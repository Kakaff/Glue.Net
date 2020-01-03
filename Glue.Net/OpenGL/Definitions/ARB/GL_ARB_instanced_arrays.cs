using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_instanced_arrays {get; private set;}

		public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysInstancedARB(uint mode, int first, int count, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedARB(uint mode, int count, uint type, IntPtr indices, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribDivisorARB(uint index, uint divisor);

 		static __glDrawArraysInstancedARB __GlueDrawArraysInstancedARB;
		static __glDrawElementsInstancedARB __GlueDrawElementsInstancedARB;
		static __glVertexAttribDivisorARB __GlueVertexAttribDivisorARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysInstancedARB(uint mode, int first, int count, int primcount) => __GlueDrawArraysInstancedARB(mode, first, count, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedARB(uint mode, int count, uint type, IntPtr indices, int primcount) => __GlueDrawElementsInstancedARB(mode, count, type, indices, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribDivisorARB(uint index, uint divisor) => __GlueVertexAttribDivisorARB(index, divisor);



	}
}


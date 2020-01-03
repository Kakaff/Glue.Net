using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_3_3 {get; private set;}

		public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
		public const int GL_RGB10_A2UI = 0x906F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribDivisor(uint index, uint divisor);

 		static __glVertexAttribDivisor __GlueVertexAttribDivisor;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribDivisor(uint index, uint divisor) => __GlueVertexAttribDivisor(index, divisor);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_instanced_arrays {get; private set;}

		public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT = 0x88FE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribDivisorEXT(uint index, uint divisor);

 		static __glVertexAttribDivisorEXT __GlueVertexAttribDivisorEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribDivisorEXT(uint index, uint divisor) => __GlueVertexAttribDivisorEXT(index, divisor);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_provoking_vertex {get; private set;}

		public const int GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
		public const int GL_PROVOKING_VERTEX_EXT = 0x8E4F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProvokingVertexEXT(uint mode);

 		static __glProvokingVertexEXT __GlueProvokingVertexEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProvokingVertexEXT(uint mode) => __GlueProvokingVertexEXT(mode);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_provoking_vertex {get; private set;}

		public const int GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
		public const int GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
		public const int GL_LAST_VERTEX_CONVENTION = 0x8E4E;
		public const int GL_PROVOKING_VERTEX = 0x8E4F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProvokingVertex(uint mode);

 		static __glProvokingVertex __GlueProvokingVertex;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProvokingVertex(uint mode) => __GlueProvokingVertex(mode);



	}
}


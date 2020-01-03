using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_array_object {get; private set;}

		public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindVertexArray(uint array);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteVertexArrays(int n, uint* arrays);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenVertexArrays(int n, uint* arrays);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsVertexArray(uint array);

 		static __glBindVertexArray __GlueBindVertexArray;
		static __glDeleteVertexArrays __GlueDeleteVertexArrays;
		static __glGenVertexArrays __GlueGenVertexArrays;
		static __glIsVertexArray __GlueIsVertexArray;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindVertexArray(uint array) => __GlueBindVertexArray(array);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteVertexArrays(int n, uint* arrays) => __GlueDeleteVertexArrays(n, arrays);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenVertexArrays(int n, uint* arrays) => __GlueGenVertexArrays(n, arrays);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsVertexArray(uint array) => __GlueIsVertexArray(array);



	}
}


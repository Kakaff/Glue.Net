using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_vertex_array_setXXX {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindArraySetEXT(IntPtr arrayset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate  IntPtr  __glCreateArraySetExt( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteArraySetsEXT(int n, IntPtr* arrayset);

 		static __glBindArraySetEXT __GlueBindArraySetEXT;
		static __glCreateArraySetExt __GlueCreateArraySetExt;
		static __glDeleteArraySetsEXT __GlueDeleteArraySetsEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindArraySetEXT(IntPtr arrayset) => __GlueBindArraySetEXT(arrayset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe  IntPtr  glCreateArraySetExt( ) => __GlueCreateArraySetExt();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteArraySetsEXT(int n, IntPtr* arrayset) => __GlueDeleteArraySetsEXT(n, arrayset);



	}
}


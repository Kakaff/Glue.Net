using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_index_func {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexFuncEXT(uint func, float reference);

 		static __glIndexFuncEXT __GlueIndexFuncEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexFuncEXT(uint func, float reference) => __GlueIndexFuncEXT(func, reference);



	}
}


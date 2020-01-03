using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_internalformat_query {get; private set;}

		public const int GL_NUM_SAMPLE_COUNTS = 0x9380;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int* parameters);

 		static __glGetInternalformativ __GlueGetInternalformativ;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInternalformativ(uint target, uint internalformat, uint pname, int bufSize, int* parameters) => __GlueGetInternalformativ(target, internalformat, pname, bufSize, parameters);



	}
}


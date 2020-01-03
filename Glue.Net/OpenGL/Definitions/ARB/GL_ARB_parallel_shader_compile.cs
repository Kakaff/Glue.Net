using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_parallel_shader_compile {get; private set;}

		public const int GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
		public const int GL_COMPLETION_STATUS_ARB = 0x91B1;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMaxShaderCompilerThreadsARB(uint count);

 		static __glMaxShaderCompilerThreadsARB __GlueMaxShaderCompilerThreadsARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMaxShaderCompilerThreadsARB(uint count) => __GlueMaxShaderCompilerThreadsARB(count);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_gpu_program_parameters {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramEnvParameters4fvEXT(uint target, uint index, int count, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramLocalParameters4fvEXT(uint target, uint index, int count, float* parameters);

 		static __glProgramEnvParameters4fvEXT __GlueProgramEnvParameters4fvEXT;
		static __glProgramLocalParameters4fvEXT __GlueProgramLocalParameters4fvEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramEnvParameters4fvEXT(uint target, uint index, int count, float* parameters) => __GlueProgramEnvParameters4fvEXT(target, index, count, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramLocalParameters4fvEXT(uint target, uint index, int count, float* parameters) => __GlueProgramLocalParameters4fvEXT(target, index, count, parameters);



	}
}


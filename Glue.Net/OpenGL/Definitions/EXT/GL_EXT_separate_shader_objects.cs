using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_separate_shader_objects {get; private set;}

		public const int GL_ACTIVE_PROGRAM_EXT = 0x8B8D;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glActiveProgramEXT(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCreateShaderProgramEXT(uint type, char* str);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUseShaderProgramEXT(uint type, uint program);

 		static __glActiveProgramEXT __GlueActiveProgramEXT;
		static __glCreateShaderProgramEXT __GlueCreateShaderProgramEXT;
		static __glUseShaderProgramEXT __GlueUseShaderProgramEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glActiveProgramEXT(uint program) => __GlueActiveProgramEXT(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCreateShaderProgramEXT(uint type, char* str) => __GlueCreateShaderProgramEXT(type, str);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUseShaderProgramEXT(uint type, uint program) => __GlueUseShaderProgramEXT(type, program);



	}
}


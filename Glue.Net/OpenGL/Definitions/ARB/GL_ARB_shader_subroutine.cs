using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_shader_subroutine {get; private set;}

		public const int GL_ACTIVE_SUBROUTINES = 0x8DE5;
		public const int GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
		public const int GL_MAX_SUBROUTINES = 0x8DE7;
		public const int GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
		public const int GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
		public const int GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
		public const int GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
		public const int GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
		public const int GL_COMPATIBLE_SUBROUTINES = 0x8E4B;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int* length, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int* length, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramStageiv(uint program, uint shadertype, uint pname, int* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetSubroutineIndex(uint program, uint shadertype, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetSubroutineUniformLocation(uint program, uint shadertype, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformSubroutineuiv(uint shadertype, int location, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformSubroutinesuiv(uint shadertype, int count, uint* indices);

 		static __glGetActiveSubroutineName __GlueGetActiveSubroutineName;
		static __glGetActiveSubroutineUniformName __GlueGetActiveSubroutineUniformName;
		static __glGetActiveSubroutineUniformiv __GlueGetActiveSubroutineUniformiv;
		static __glGetProgramStageiv __GlueGetProgramStageiv;
		static __glGetSubroutineIndex __GlueGetSubroutineIndex;
		static __glGetSubroutineUniformLocation __GlueGetSubroutineUniformLocation;
		static __glGetUniformSubroutineuiv __GlueGetUniformSubroutineuiv;
		static __glUniformSubroutinesuiv __GlueUniformSubroutinesuiv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufsize, int* length, char* name) => __GlueGetActiveSubroutineName(program, shadertype, index, bufsize, length, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufsize, int* length, char* name) => __GlueGetActiveSubroutineUniformName(program, shadertype, index, bufsize, length, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) => __GlueGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramStageiv(uint program, uint shadertype, uint pname, int* values) => __GlueGetProgramStageiv(program, shadertype, pname, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetSubroutineIndex(uint program, uint shadertype, char* name) => __GlueGetSubroutineIndex(program, shadertype, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetSubroutineUniformLocation(uint program, uint shadertype, char* name) => __GlueGetSubroutineUniformLocation(program, shadertype, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformSubroutineuiv(uint shadertype, int location, uint* parameters) => __GlueGetUniformSubroutineuiv(shadertype, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformSubroutinesuiv(uint shadertype, int count, uint* indices) => __GlueUniformSubroutinesuiv(shadertype, count, indices);



	}
}


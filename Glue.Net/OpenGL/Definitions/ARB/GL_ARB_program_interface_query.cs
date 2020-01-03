using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_program_interface_query {get; private set;}

		public const int GL_UNIFORM = 0x92E1;
		public const int GL_UNIFORM_BLOCK = 0x92E2;
		public const int GL_PROGRAM_INPUT = 0x92E3;
		public const int GL_PROGRAM_OUTPUT = 0x92E4;
		public const int GL_BUFFER_VARIABLE = 0x92E5;
		public const int GL_SHADER_STORAGE_BLOCK = 0x92E6;
		public const int GL_IS_PER_PATCH = 0x92E7;
		public const int GL_VERTEX_SUBROUTINE = 0x92E8;
		public const int GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
		public const int GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
		public const int GL_GEOMETRY_SUBROUTINE = 0x92EB;
		public const int GL_FRAGMENT_SUBROUTINE = 0x92EC;
		public const int GL_COMPUTE_SUBROUTINE = 0x92ED;
		public const int GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
		public const int GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
		public const int GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
		public const int GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
		public const int GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
		public const int GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
		public const int GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
		public const int GL_ACTIVE_RESOURCES = 0x92F5;
		public const int GL_MAX_NAME_LENGTH = 0x92F6;
		public const int GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
		public const int GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
		public const int GL_NAME_LENGTH = 0x92F9;
		public const int GL_TYPE = 0x92FA;
		public const int GL_ARRAY_SIZE = 0x92FB;
		public const int GL_OFFSET = 0x92FC;
		public const int GL_BLOCK_INDEX = 0x92FD;
		public const int GL_ARRAY_STRIDE = 0x92FE;
		public const int GL_MATRIX_STRIDE = 0x92FF;
		public const int GL_IS_ROW_MAJOR = 0x9300;
		public const int GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
		public const int GL_BUFFER_BINDING = 0x9302;
		public const int GL_BUFFER_DATA_SIZE = 0x9303;
		public const int GL_NUM_ACTIVE_VARIABLES = 0x9304;
		public const int GL_ACTIVE_VARIABLES = 0x9305;
		public const int GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
		public const int GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
		public const int GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
		public const int GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
		public const int GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
		public const int GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
		public const int GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
		public const int GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
		public const int GL_LOCATION = 0x930E;
		public const int GL_LOCATION_INDEX = 0x930F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetProgramResourceIndex(uint program, uint programInterface, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetProgramResourceLocation(uint program, uint programInterface, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetProgramResourceLocationIndex(uint program, uint programInterface, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, int* parameters);

 		static __glGetProgramInterfaceiv __GlueGetProgramInterfaceiv;
		static __glGetProgramResourceIndex __GlueGetProgramResourceIndex;
		static __glGetProgramResourceLocation __GlueGetProgramResourceLocation;
		static __glGetProgramResourceLocationIndex __GlueGetProgramResourceLocationIndex;
		static __glGetProgramResourceName __GlueGetProgramResourceName;
		static __glGetProgramResourceiv __GlueGetProgramResourceiv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* parameters) => __GlueGetProgramInterfaceiv(program, programInterface, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetProgramResourceIndex(uint program, uint programInterface, char* name) => __GlueGetProgramResourceIndex(program, programInterface, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetProgramResourceLocation(uint program, uint programInterface, char* name) => __GlueGetProgramResourceLocation(program, programInterface, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetProgramResourceLocationIndex(uint program, uint programInterface, char* name) => __GlueGetProgramResourceLocationIndex(program, programInterface, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name) => __GlueGetProgramResourceName(program, programInterface, index, bufSize, length, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, int* parameters) => __GlueGetProgramResourceiv(program, programInterface, index, propCount, props, bufSize, length, parameters);



	}
}


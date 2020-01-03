using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_get_program_binary {get; private set;}

		public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
		public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
		public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
		public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, IntPtr binary);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramParameteri(uint program, uint pname, int value);

 		static __glGetProgramBinary __GlueGetProgramBinary;
		static __glProgramBinary __GlueProgramBinary;
		static __glProgramParameteri __GlueProgramParameteri;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, IntPtr binary) => __GlueGetProgramBinary(program, bufSize, length, binaryFormat, binary);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramBinary(uint program, uint binaryFormat, IntPtr binary, int length) => __GlueProgramBinary(program, binaryFormat, binary, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramParameteri(uint program, uint pname, int value) => __GlueProgramParameteri(program, pname, value);



	}
}


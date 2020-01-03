using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_ES2_compatibility {get; private set;}

		public const int GL_FIXED = 0x140C;
		public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
		public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
		public const int GL_RGB565 = 0x8D62;
		public const int GL_LOW_FLOAT = 0x8DF0;
		public const int GL_MEDIUM_FLOAT = 0x8DF1;
		public const int GL_HIGH_FLOAT = 0x8DF2;
		public const int GL_LOW_INT = 0x8DF3;
		public const int GL_MEDIUM_INT = 0x8DF4;
		public const int GL_HIGH_INT = 0x8DF5;
		public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
		public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
		public const int GL_SHADER_COMPILER = 0x8DFA;
		public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
		public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearDepthf(float d);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthRangef(float n, float f);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glReleaseShaderCompiler( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderBinary(int count, uint* shaders, uint binaryformat, IntPtr binary, int length);

 		static __glClearDepthf __GlueClearDepthf;
		static __glDepthRangef __GlueDepthRangef;
		static __glGetShaderPrecisionFormat __GlueGetShaderPrecisionFormat;
		static __glReleaseShaderCompiler __GlueReleaseShaderCompiler;
		static __glShaderBinary __GlueShaderBinary;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearDepthf(float d) => __GlueClearDepthf(d);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthRangef(float n, float f) => __GlueDepthRangef(n, f);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) => __GlueGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glReleaseShaderCompiler( ) => __GlueReleaseShaderCompiler();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderBinary(int count, uint* shaders, uint binaryformat, IntPtr binary, int length) => __GlueShaderBinary(count, shaders, binaryformat, binary, length);



	}
}


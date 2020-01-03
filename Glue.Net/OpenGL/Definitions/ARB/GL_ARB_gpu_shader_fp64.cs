using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_gpu_shader_fp64 {get; private set;}

		public const int GL_DOUBLE_MAT2 = 0x8F46;
		public const int GL_DOUBLE_MAT3 = 0x8F47;
		public const int GL_DOUBLE_MAT4 = 0x8F48;
		public const int GL_DOUBLE_MAT2x3 = 0x8F49;
		public const int GL_DOUBLE_MAT2x4 = 0x8F4A;
		public const int GL_DOUBLE_MAT3x2 = 0x8F4B;
		public const int GL_DOUBLE_MAT3x4 = 0x8F4C;
		public const int GL_DOUBLE_MAT4x2 = 0x8F4D;
		public const int GL_DOUBLE_MAT4x3 = 0x8F4E;
		public const int GL_DOUBLE_VEC2 = 0x8FFC;
		public const int GL_DOUBLE_VEC3 = 0x8FFD;
		public const int GL_DOUBLE_VEC4 = 0x8FFE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformdv(uint program, int location, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1d(int location, double x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1dv(int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2d(int location, double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2dv(int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3d(int location, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3dv(int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4d(int location, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4dv(int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2x3dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2x4dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3x2dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3x4dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4x2dv(int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4x3dv(int location, int count, bool transpose, double* value);

 		static __glGetUniformdv __GlueGetUniformdv;
		static __glUniform1d __GlueUniform1d;
		static __glUniform1dv __GlueUniform1dv;
		static __glUniform2d __GlueUniform2d;
		static __glUniform2dv __GlueUniform2dv;
		static __glUniform3d __GlueUniform3d;
		static __glUniform3dv __GlueUniform3dv;
		static __glUniform4d __GlueUniform4d;
		static __glUniform4dv __GlueUniform4dv;
		static __glUniformMatrix2dv __GlueUniformMatrix2dv;
		static __glUniformMatrix2x3dv __GlueUniformMatrix2x3dv;
		static __glUniformMatrix2x4dv __GlueUniformMatrix2x4dv;
		static __glUniformMatrix3dv __GlueUniformMatrix3dv;
		static __glUniformMatrix3x2dv __GlueUniformMatrix3x2dv;
		static __glUniformMatrix3x4dv __GlueUniformMatrix3x4dv;
		static __glUniformMatrix4dv __GlueUniformMatrix4dv;
		static __glUniformMatrix4x2dv __GlueUniformMatrix4x2dv;
		static __glUniformMatrix4x3dv __GlueUniformMatrix4x3dv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformdv(uint program, int location, double* parameters) => __GlueGetUniformdv(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1d(int location, double x) => __GlueUniform1d(location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1dv(int location, int count, double* value) => __GlueUniform1dv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2d(int location, double x, double y) => __GlueUniform2d(location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2dv(int location, int count, double* value) => __GlueUniform2dv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3d(int location, double x, double y, double z) => __GlueUniform3d(location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3dv(int location, int count, double* value) => __GlueUniform3dv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4d(int location, double x, double y, double z, double w) => __GlueUniform4d(location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4dv(int location, int count, double* value) => __GlueUniform4dv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix2dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2x3dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix2x3dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2x4dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix2x4dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix3dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3x2dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix3x2dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3x4dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix3x4dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix4dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4x2dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix4x2dv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4x3dv(int location, int count, bool transpose, double* value) => __GlueUniformMatrix4x3dv(location, count, transpose, value);



	}
}


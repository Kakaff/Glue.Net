using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_gpu_shader_int64 {get; private set;}

		public const int GL_INT64_ARB = 0x140E;
		public const int GL_INT64_VEC2_ARB = 0x8FE9;
		public const int GL_INT64_VEC3_ARB = 0x8FEA;
		public const int GL_INT64_VEC4_ARB = 0x8FEB;
		public const int GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5;
		public const int GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6;
		public const int GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformi64vARB(uint program, int location, long* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformui64vARB(uint program, int location, ulong* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformi64vARB(uint program, int location, int bufSize, long* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformui64vARB(uint program, int location, int bufSize, ulong* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1i64ARB(uint program, int location, long x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1i64vARB(uint program, int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1ui64ARB(uint program, int location, ulong x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1ui64vARB(uint program, int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2i64ARB(uint program, int location, long x, long y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2i64vARB(uint program, int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2ui64vARB(uint program, int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3i64ARB(uint program, int location, long x, long y, long z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3i64vARB(uint program, int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3ui64vARB(uint program, int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4i64vARB(uint program, int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4ui64vARB(uint program, int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1i64ARB(int location, long x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1i64vARB(int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1ui64ARB(int location, ulong x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1ui64vARB(int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2i64ARB(int location, long x, long y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2i64vARB(int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2ui64ARB(int location, ulong x, ulong y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2ui64vARB(int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3i64ARB(int location, long x, long y, long z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3i64vARB(int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3ui64ARB(int location, ulong x, ulong y, ulong z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3ui64vARB(int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4i64ARB(int location, long x, long y, long z, long w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4i64vARB(int location, int count, long* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4ui64vARB(int location, int count, ulong* value);

 		static __glGetUniformi64vARB __GlueGetUniformi64vARB;
		static __glGetUniformui64vARB __GlueGetUniformui64vARB;
		static __glGetnUniformi64vARB __GlueGetnUniformi64vARB;
		static __glGetnUniformui64vARB __GlueGetnUniformui64vARB;
		static __glProgramUniform1i64ARB __GlueProgramUniform1i64ARB;
		static __glProgramUniform1i64vARB __GlueProgramUniform1i64vARB;
		static __glProgramUniform1ui64ARB __GlueProgramUniform1ui64ARB;
		static __glProgramUniform1ui64vARB __GlueProgramUniform1ui64vARB;
		static __glProgramUniform2i64ARB __GlueProgramUniform2i64ARB;
		static __glProgramUniform2i64vARB __GlueProgramUniform2i64vARB;
		static __glProgramUniform2ui64ARB __GlueProgramUniform2ui64ARB;
		static __glProgramUniform2ui64vARB __GlueProgramUniform2ui64vARB;
		static __glProgramUniform3i64ARB __GlueProgramUniform3i64ARB;
		static __glProgramUniform3i64vARB __GlueProgramUniform3i64vARB;
		static __glProgramUniform3ui64ARB __GlueProgramUniform3ui64ARB;
		static __glProgramUniform3ui64vARB __GlueProgramUniform3ui64vARB;
		static __glProgramUniform4i64ARB __GlueProgramUniform4i64ARB;
		static __glProgramUniform4i64vARB __GlueProgramUniform4i64vARB;
		static __glProgramUniform4ui64ARB __GlueProgramUniform4ui64ARB;
		static __glProgramUniform4ui64vARB __GlueProgramUniform4ui64vARB;
		static __glUniform1i64ARB __GlueUniform1i64ARB;
		static __glUniform1i64vARB __GlueUniform1i64vARB;
		static __glUniform1ui64ARB __GlueUniform1ui64ARB;
		static __glUniform1ui64vARB __GlueUniform1ui64vARB;
		static __glUniform2i64ARB __GlueUniform2i64ARB;
		static __glUniform2i64vARB __GlueUniform2i64vARB;
		static __glUniform2ui64ARB __GlueUniform2ui64ARB;
		static __glUniform2ui64vARB __GlueUniform2ui64vARB;
		static __glUniform3i64ARB __GlueUniform3i64ARB;
		static __glUniform3i64vARB __GlueUniform3i64vARB;
		static __glUniform3ui64ARB __GlueUniform3ui64ARB;
		static __glUniform3ui64vARB __GlueUniform3ui64vARB;
		static __glUniform4i64ARB __GlueUniform4i64ARB;
		static __glUniform4i64vARB __GlueUniform4i64vARB;
		static __glUniform4ui64ARB __GlueUniform4ui64ARB;
		static __glUniform4ui64vARB __GlueUniform4ui64vARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformi64vARB(uint program, int location, long* parameters) => __GlueGetUniformi64vARB(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformui64vARB(uint program, int location, ulong* parameters) => __GlueGetUniformui64vARB(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformi64vARB(uint program, int location, int bufSize, long* parameters) => __GlueGetnUniformi64vARB(program, location, bufSize, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformui64vARB(uint program, int location, int bufSize, ulong* parameters) => __GlueGetnUniformui64vARB(program, location, bufSize, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1i64ARB(uint program, int location, long x) => __GlueProgramUniform1i64ARB(program, location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1i64vARB(uint program, int location, int count, long* value) => __GlueProgramUniform1i64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1ui64ARB(uint program, int location, ulong x) => __GlueProgramUniform1ui64ARB(program, location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1ui64vARB(uint program, int location, int count, ulong* value) => __GlueProgramUniform1ui64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2i64ARB(uint program, int location, long x, long y) => __GlueProgramUniform2i64ARB(program, location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2i64vARB(uint program, int location, int count, long* value) => __GlueProgramUniform2i64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y) => __GlueProgramUniform2ui64ARB(program, location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2ui64vARB(uint program, int location, int count, ulong* value) => __GlueProgramUniform2ui64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3i64ARB(uint program, int location, long x, long y, long z) => __GlueProgramUniform3i64ARB(program, location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3i64vARB(uint program, int location, int count, long* value) => __GlueProgramUniform3i64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z) => __GlueProgramUniform3ui64ARB(program, location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3ui64vARB(uint program, int location, int count, ulong* value) => __GlueProgramUniform3ui64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w) => __GlueProgramUniform4i64ARB(program, location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4i64vARB(uint program, int location, int count, long* value) => __GlueProgramUniform4i64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w) => __GlueProgramUniform4ui64ARB(program, location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4ui64vARB(uint program, int location, int count, ulong* value) => __GlueProgramUniform4ui64vARB(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1i64ARB(int location, long x) => __GlueUniform1i64ARB(location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1i64vARB(int location, int count, long* value) => __GlueUniform1i64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1ui64ARB(int location, ulong x) => __GlueUniform1ui64ARB(location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1ui64vARB(int location, int count, ulong* value) => __GlueUniform1ui64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2i64ARB(int location, long x, long y) => __GlueUniform2i64ARB(location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2i64vARB(int location, int count, long* value) => __GlueUniform2i64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2ui64ARB(int location, ulong x, ulong y) => __GlueUniform2ui64ARB(location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2ui64vARB(int location, int count, ulong* value) => __GlueUniform2ui64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3i64ARB(int location, long x, long y, long z) => __GlueUniform3i64ARB(location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3i64vARB(int location, int count, long* value) => __GlueUniform3i64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3ui64ARB(int location, ulong x, ulong y, ulong z) => __GlueUniform3ui64ARB(location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3ui64vARB(int location, int count, ulong* value) => __GlueUniform3ui64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4i64ARB(int location, long x, long y, long z, long w) => __GlueUniform4i64ARB(location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4i64vARB(int location, int count, long* value) => __GlueUniform4i64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w) => __GlueUniform4ui64ARB(location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4ui64vARB(int location, int count, ulong* value) => __GlueUniform4ui64vARB(location, count, value);



	}
}


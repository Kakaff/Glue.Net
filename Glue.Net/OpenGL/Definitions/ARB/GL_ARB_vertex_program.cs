using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_program {get; private set;}

		public const int GL_COLOR_SUM_ARB = 0x8458;
		public const int GL_VERTEX_PROGRAM_ARB = 0x8620;
		public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
		public const int GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
		public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
		public const int GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
		public const int GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
		public const int GL_PROGRAM_LENGTH_ARB = 0x8627;
		public const int GL_PROGRAM_STRING_ARB = 0x8628;
		public const int GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
		public const int GL_MAX_PROGRAM_MATRICES_ARB = 0x862F;
		public const int GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
		public const int GL_CURRENT_MATRIX_ARB = 0x8641;
		public const int GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
		public const int GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
		public const int GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
		public const int GL_PROGRAM_ERROR_POSITION_ARB = 0x864B;
		public const int GL_PROGRAM_BINDING_ARB = 0x8677;
		public const int GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869;
		public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
		public const int GL_PROGRAM_ERROR_STRING_ARB = 0x8874;
		public const int GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875;
		public const int GL_PROGRAM_FORMAT_ARB = 0x8876;
		public const int GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
		public const int GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
		public const int GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
		public const int GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
		public const int GL_PROGRAM_TEMPORARIES_ARB = 0x88A4;
		public const int GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
		public const int GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
		public const int GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
		public const int GL_PROGRAM_PARAMETERS_ARB = 0x88A8;
		public const int GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
		public const int GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
		public const int GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
		public const int GL_PROGRAM_ATTRIBS_ARB = 0x88AC;
		public const int GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
		public const int GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
		public const int GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
		public const int GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
		public const int GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
		public const int GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
		public const int GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
		public const int GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
		public const int GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
		public const int GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
		public const int GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
		public const int GL_MATRIX0_ARB = 0x88C0;
		public const int GL_MATRIX1_ARB = 0x88C1;
		public const int GL_MATRIX2_ARB = 0x88C2;
		public const int GL_MATRIX3_ARB = 0x88C3;
		public const int GL_MATRIX4_ARB = 0x88C4;
		public const int GL_MATRIX5_ARB = 0x88C5;
		public const int GL_MATRIX6_ARB = 0x88C6;
		public const int GL_MATRIX7_ARB = 0x88C7;
		public const int GL_MATRIX8_ARB = 0x88C8;
		public const int GL_MATRIX9_ARB = 0x88C9;
		public const int GL_MATRIX10_ARB = 0x88CA;
		public const int GL_MATRIX11_ARB = 0x88CB;
		public const int GL_MATRIX12_ARB = 0x88CC;
		public const int GL_MATRIX13_ARB = 0x88CD;
		public const int GL_MATRIX14_ARB = 0x88CE;
		public const int GL_MATRIX15_ARB = 0x88CF;
		public const int GL_MATRIX16_ARB = 0x88D0;
		public const int GL_MATRIX17_ARB = 0x88D1;
		public const int GL_MATRIX18_ARB = 0x88D2;
		public const int GL_MATRIX19_ARB = 0x88D3;
		public const int GL_MATRIX20_ARB = 0x88D4;
		public const int GL_MATRIX21_ARB = 0x88D5;
		public const int GL_MATRIX22_ARB = 0x88D6;
		public const int GL_MATRIX23_ARB = 0x88D7;
		public const int GL_MATRIX24_ARB = 0x88D8;
		public const int GL_MATRIX25_ARB = 0x88D9;
		public const int GL_MATRIX26_ARB = 0x88DA;
		public const int GL_MATRIX27_ARB = 0x88DB;
		public const int GL_MATRIX28_ARB = 0x88DC;
		public const int GL_MATRIX29_ARB = 0x88DD;
		public const int GL_MATRIX30_ARB = 0x88DE;
		public const int GL_MATRIX31_ARB = 0x88DF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindProgramARB(uint target, uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteProgramsARB(int n, uint* programs);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableVertexAttribArrayARB(uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableVertexAttribArrayARB(uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenProgramsARB(int n, uint* programs);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramEnvParameterdvARB(uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramEnvParameterfvARB(uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramLocalParameterdvARB(uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramLocalParameterfvARB(uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramStringARB(uint target, uint pname, IntPtr str);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramivARB(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribPointervARB(uint index, uint pname, IntPtr* pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribdvARB(uint index, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribfvARB(uint index, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribivARB(uint index, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsProgramARB(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramEnvParameter4dvARB(uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramEnvParameter4fvARB(uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramLocalParameter4dvARB(uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramLocalParameter4fvARB(uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramStringARB(uint target, uint format, int len, IntPtr str);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1dARB(uint index, double x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1dvARB(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1fARB(uint index, float x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1fvARB(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1sARB(uint index, short x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1svARB(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2dARB(uint index, double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2dvARB(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2fARB(uint index, float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2fvARB(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2sARB(uint index, short x, short y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2svARB(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3dARB(uint index, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3dvARB(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3fARB(uint index, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3fvARB(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3sARB(uint index, short x, short y, short z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3svARB(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NbvARB(uint index, sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NivARB(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NsvARB(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NubvARB(uint index, byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NuivARB(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4NusvARB(uint index, ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4bvARB(uint index, sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4dARB(uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4dvARB(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4fARB(uint index, float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4fvARB(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4ivARB(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4sARB(uint index, short x, short y, short z, short w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4svARB(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4ubvARB(uint index, byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4uivARB(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4usvARB(uint index, ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

 		static __glBindProgramARB __GlueBindProgramARB;
		static __glDeleteProgramsARB __GlueDeleteProgramsARB;
		static __glDisableVertexAttribArrayARB __GlueDisableVertexAttribArrayARB;
		static __glEnableVertexAttribArrayARB __GlueEnableVertexAttribArrayARB;
		static __glGenProgramsARB __GlueGenProgramsARB;
		static __glGetProgramEnvParameterdvARB __GlueGetProgramEnvParameterdvARB;
		static __glGetProgramEnvParameterfvARB __GlueGetProgramEnvParameterfvARB;
		static __glGetProgramLocalParameterdvARB __GlueGetProgramLocalParameterdvARB;
		static __glGetProgramLocalParameterfvARB __GlueGetProgramLocalParameterfvARB;
		static __glGetProgramStringARB __GlueGetProgramStringARB;
		static __glGetProgramivARB __GlueGetProgramivARB;
		static __glGetVertexAttribPointervARB __GlueGetVertexAttribPointervARB;
		static __glGetVertexAttribdvARB __GlueGetVertexAttribdvARB;
		static __glGetVertexAttribfvARB __GlueGetVertexAttribfvARB;
		static __glGetVertexAttribivARB __GlueGetVertexAttribivARB;
		static __glIsProgramARB __GlueIsProgramARB;
		static __glProgramEnvParameter4dARB __GlueProgramEnvParameter4dARB;
		static __glProgramEnvParameter4dvARB __GlueProgramEnvParameter4dvARB;
		static __glProgramEnvParameter4fARB __GlueProgramEnvParameter4fARB;
		static __glProgramEnvParameter4fvARB __GlueProgramEnvParameter4fvARB;
		static __glProgramLocalParameter4dARB __GlueProgramLocalParameter4dARB;
		static __glProgramLocalParameter4dvARB __GlueProgramLocalParameter4dvARB;
		static __glProgramLocalParameter4fARB __GlueProgramLocalParameter4fARB;
		static __glProgramLocalParameter4fvARB __GlueProgramLocalParameter4fvARB;
		static __glProgramStringARB __GlueProgramStringARB;
		static __glVertexAttrib1dARB __GlueVertexAttrib1dARB;
		static __glVertexAttrib1dvARB __GlueVertexAttrib1dvARB;
		static __glVertexAttrib1fARB __GlueVertexAttrib1fARB;
		static __glVertexAttrib1fvARB __GlueVertexAttrib1fvARB;
		static __glVertexAttrib1sARB __GlueVertexAttrib1sARB;
		static __glVertexAttrib1svARB __GlueVertexAttrib1svARB;
		static __glVertexAttrib2dARB __GlueVertexAttrib2dARB;
		static __glVertexAttrib2dvARB __GlueVertexAttrib2dvARB;
		static __glVertexAttrib2fARB __GlueVertexAttrib2fARB;
		static __glVertexAttrib2fvARB __GlueVertexAttrib2fvARB;
		static __glVertexAttrib2sARB __GlueVertexAttrib2sARB;
		static __glVertexAttrib2svARB __GlueVertexAttrib2svARB;
		static __glVertexAttrib3dARB __GlueVertexAttrib3dARB;
		static __glVertexAttrib3dvARB __GlueVertexAttrib3dvARB;
		static __glVertexAttrib3fARB __GlueVertexAttrib3fARB;
		static __glVertexAttrib3fvARB __GlueVertexAttrib3fvARB;
		static __glVertexAttrib3sARB __GlueVertexAttrib3sARB;
		static __glVertexAttrib3svARB __GlueVertexAttrib3svARB;
		static __glVertexAttrib4NbvARB __GlueVertexAttrib4NbvARB;
		static __glVertexAttrib4NivARB __GlueVertexAttrib4NivARB;
		static __glVertexAttrib4NsvARB __GlueVertexAttrib4NsvARB;
		static __glVertexAttrib4NubARB __GlueVertexAttrib4NubARB;
		static __glVertexAttrib4NubvARB __GlueVertexAttrib4NubvARB;
		static __glVertexAttrib4NuivARB __GlueVertexAttrib4NuivARB;
		static __glVertexAttrib4NusvARB __GlueVertexAttrib4NusvARB;
		static __glVertexAttrib4bvARB __GlueVertexAttrib4bvARB;
		static __glVertexAttrib4dARB __GlueVertexAttrib4dARB;
		static __glVertexAttrib4dvARB __GlueVertexAttrib4dvARB;
		static __glVertexAttrib4fARB __GlueVertexAttrib4fARB;
		static __glVertexAttrib4fvARB __GlueVertexAttrib4fvARB;
		static __glVertexAttrib4ivARB __GlueVertexAttrib4ivARB;
		static __glVertexAttrib4sARB __GlueVertexAttrib4sARB;
		static __glVertexAttrib4svARB __GlueVertexAttrib4svARB;
		static __glVertexAttrib4ubvARB __GlueVertexAttrib4ubvARB;
		static __glVertexAttrib4uivARB __GlueVertexAttrib4uivARB;
		static __glVertexAttrib4usvARB __GlueVertexAttrib4usvARB;
		static __glVertexAttribPointerARB __GlueVertexAttribPointerARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindProgramARB(uint target, uint program) => __GlueBindProgramARB(target, program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteProgramsARB(int n, uint* programs) => __GlueDeleteProgramsARB(n, programs);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableVertexAttribArrayARB(uint index) => __GlueDisableVertexAttribArrayARB(index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableVertexAttribArrayARB(uint index) => __GlueEnableVertexAttribArrayARB(index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenProgramsARB(int n, uint* programs) => __GlueGenProgramsARB(n, programs);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramEnvParameterdvARB(uint target, uint index, double* parameters) => __GlueGetProgramEnvParameterdvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramEnvParameterfvARB(uint target, uint index, float* parameters) => __GlueGetProgramEnvParameterfvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramLocalParameterdvARB(uint target, uint index, double* parameters) => __GlueGetProgramLocalParameterdvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramLocalParameterfvARB(uint target, uint index, float* parameters) => __GlueGetProgramLocalParameterfvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramStringARB(uint target, uint pname, IntPtr str) => __GlueGetProgramStringARB(target, pname, str);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramivARB(uint target, uint pname, int* parameters) => __GlueGetProgramivARB(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribPointervARB(uint index, uint pname, IntPtr* pointer) => __GlueGetVertexAttribPointervARB(index, pname, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribdvARB(uint index, uint pname, double* parameters) => __GlueGetVertexAttribdvARB(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribfvARB(uint index, uint pname, float* parameters) => __GlueGetVertexAttribfvARB(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribivARB(uint index, uint pname, int* parameters) => __GlueGetVertexAttribivARB(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsProgramARB(uint program) => __GlueIsProgramARB(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w) => __GlueProgramEnvParameter4dARB(target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramEnvParameter4dvARB(uint target, uint index, double* parameters) => __GlueProgramEnvParameter4dvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w) => __GlueProgramEnvParameter4fARB(target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramEnvParameter4fvARB(uint target, uint index, float* parameters) => __GlueProgramEnvParameter4fvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w) => __GlueProgramLocalParameter4dARB(target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramLocalParameter4dvARB(uint target, uint index, double* parameters) => __GlueProgramLocalParameter4dvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w) => __GlueProgramLocalParameter4fARB(target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramLocalParameter4fvARB(uint target, uint index, float* parameters) => __GlueProgramLocalParameter4fvARB(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramStringARB(uint target, uint format, int len, IntPtr str) => __GlueProgramStringARB(target, format, len, str);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1dARB(uint index, double x) => __GlueVertexAttrib1dARB(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1dvARB(uint index, double* v) => __GlueVertexAttrib1dvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1fARB(uint index, float x) => __GlueVertexAttrib1fARB(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1fvARB(uint index, float* v) => __GlueVertexAttrib1fvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1sARB(uint index, short x) => __GlueVertexAttrib1sARB(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1svARB(uint index, short* v) => __GlueVertexAttrib1svARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2dARB(uint index, double x, double y) => __GlueVertexAttrib2dARB(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2dvARB(uint index, double* v) => __GlueVertexAttrib2dvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2fARB(uint index, float x, float y) => __GlueVertexAttrib2fARB(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2fvARB(uint index, float* v) => __GlueVertexAttrib2fvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2sARB(uint index, short x, short y) => __GlueVertexAttrib2sARB(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2svARB(uint index, short* v) => __GlueVertexAttrib2svARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3dARB(uint index, double x, double y, double z) => __GlueVertexAttrib3dARB(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3dvARB(uint index, double* v) => __GlueVertexAttrib3dvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3fARB(uint index, float x, float y, float z) => __GlueVertexAttrib3fARB(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3fvARB(uint index, float* v) => __GlueVertexAttrib3fvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3sARB(uint index, short x, short y, short z) => __GlueVertexAttrib3sARB(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3svARB(uint index, short* v) => __GlueVertexAttrib3svARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NbvARB(uint index, sbyte* v) => __GlueVertexAttrib4NbvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NivARB(uint index, int* v) => __GlueVertexAttrib4NivARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NsvARB(uint index, short* v) => __GlueVertexAttrib4NsvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) => __GlueVertexAttrib4NubARB(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NubvARB(uint index, byte* v) => __GlueVertexAttrib4NubvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NuivARB(uint index, uint* v) => __GlueVertexAttrib4NuivARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4NusvARB(uint index, ushort* v) => __GlueVertexAttrib4NusvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4bvARB(uint index, sbyte* v) => __GlueVertexAttrib4bvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4dARB(uint index, double x, double y, double z, double w) => __GlueVertexAttrib4dARB(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4dvARB(uint index, double* v) => __GlueVertexAttrib4dvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4fARB(uint index, float x, float y, float z, float w) => __GlueVertexAttrib4fARB(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4fvARB(uint index, float* v) => __GlueVertexAttrib4fvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4ivARB(uint index, int* v) => __GlueVertexAttrib4ivARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4sARB(uint index, short x, short y, short z, short w) => __GlueVertexAttrib4sARB(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4svARB(uint index, short* v) => __GlueVertexAttrib4svARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4ubvARB(uint index, byte* v) => __GlueVertexAttrib4ubvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4uivARB(uint index, uint* v) => __GlueVertexAttrib4uivARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4usvARB(uint index, ushort* v) => __GlueVertexAttrib4usvARB(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer) => __GlueVertexAttribPointerARB(index, size, type, normalized, stride, pointer);



	}
}


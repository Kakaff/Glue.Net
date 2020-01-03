using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_2_0 {get; private set;}

		public const int GL_BLEND_EQUATION_RGB = 0x8009;
		public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
		public const int GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
		public const int GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643;
		public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		public const int GL_STENCIL_BACK_FUNC = 0x8800;
		public const int GL_STENCIL_BACK_FAIL = 0x8801;
		public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		public const int GL_MAX_DRAW_BUFFERS = 0x8824;
		public const int GL_DRAW_BUFFER0 = 0x8825;
		public const int GL_DRAW_BUFFER1 = 0x8826;
		public const int GL_DRAW_BUFFER2 = 0x8827;
		public const int GL_DRAW_BUFFER3 = 0x8828;
		public const int GL_DRAW_BUFFER4 = 0x8829;
		public const int GL_DRAW_BUFFER5 = 0x882A;
		public const int GL_DRAW_BUFFER6 = 0x882B;
		public const int GL_DRAW_BUFFER7 = 0x882C;
		public const int GL_DRAW_BUFFER8 = 0x882D;
		public const int GL_DRAW_BUFFER9 = 0x882E;
		public const int GL_DRAW_BUFFER10 = 0x882F;
		public const int GL_DRAW_BUFFER11 = 0x8830;
		public const int GL_DRAW_BUFFER12 = 0x8831;
		public const int GL_DRAW_BUFFER13 = 0x8832;
		public const int GL_DRAW_BUFFER14 = 0x8833;
		public const int GL_DRAW_BUFFER15 = 0x8834;
		public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
		public const int GL_POINT_SPRITE = 0x8861;
		public const int GL_COORD_REPLACE = 0x8862;
		public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
		public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		public const int GL_MAX_TEXTURE_COORDS = 0x8871;
		public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		public const int GL_FRAGMENT_SHADER = 0x8B30;
		public const int GL_VERTEX_SHADER = 0x8B31;
		public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
		public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
		public const int GL_MAX_VARYING_FLOATS = 0x8B4B;
		public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		public const int GL_SHADER_TYPE = 0x8B4F;
		public const int GL_FLOAT_VEC2 = 0x8B50;
		public const int GL_FLOAT_VEC3 = 0x8B51;
		public const int GL_FLOAT_VEC4 = 0x8B52;
		public const int GL_INT_VEC2 = 0x8B53;
		public const int GL_INT_VEC3 = 0x8B54;
		public const int GL_INT_VEC4 = 0x8B55;
		public const int GL_BOOL = 0x8B56;
		public const int GL_BOOL_VEC2 = 0x8B57;
		public const int GL_BOOL_VEC3 = 0x8B58;
		public const int GL_BOOL_VEC4 = 0x8B59;
		public const int GL_FLOAT_MAT2 = 0x8B5A;
		public const int GL_FLOAT_MAT3 = 0x8B5B;
		public const int GL_FLOAT_MAT4 = 0x8B5C;
		public const int GL_SAMPLER_1D = 0x8B5D;
		public const int GL_SAMPLER_2D = 0x8B5E;
		public const int GL_SAMPLER_3D = 0x8B5F;
		public const int GL_SAMPLER_CUBE = 0x8B60;
		public const int GL_SAMPLER_1D_SHADOW = 0x8B61;
		public const int GL_SAMPLER_2D_SHADOW = 0x8B62;
		public const int GL_DELETE_STATUS = 0x8B80;
		public const int GL_COMPILE_STATUS = 0x8B81;
		public const int GL_LINK_STATUS = 0x8B82;
		public const int GL_VALIDATE_STATUS = 0x8B83;
		public const int GL_INFO_LOG_LENGTH = 0x8B84;
		public const int GL_ATTACHED_SHADERS = 0x8B85;
		public const int GL_ACTIVE_UNIFORMS = 0x8B86;
		public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
		public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
		public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
		public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
		public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
		public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
		public const int GL_CURRENT_PROGRAM = 0x8B8D;
		public const int GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
		public const int GL_LOWER_LEFT = 0x8CA1;
		public const int GL_UPPER_LEFT = 0x8CA2;
		public const int GL_STENCIL_BACK_REF = 0x8CA3;
		public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
		public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glAttachShader(uint program, uint shader);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindAttribLocation(uint program, uint index, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationSeparate(uint modeRGB, uint modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompileShader(uint shader);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCreateProgram( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCreateShader(uint type);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteProgram(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteShader(uint shader);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDetachShader(uint program, uint shader);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableVertexAttribArray(uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawBuffers(int n, uint* bufs);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableVertexAttribArray(uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveAttrib(uint program, uint index, int maxLength, int* length, int* size, uint* type, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveUniform(uint program, uint index, int maxLength, int* length, int* size, uint* type, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetAttribLocation(uint program, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramiv(uint program, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetShaderSource(uint obj, int maxLength, int* length, char* source);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetShaderiv(uint shader, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetUniformLocation(uint program, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformfv(uint program, int location, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformiv(uint program, int location, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribPointerv(uint index, uint pname, IntPtr* pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribdv(uint index, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribfv(uint index, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribiv(uint index, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsProgram(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsShader(uint shader);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLinkProgram(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderSource(uint shader, int count, char** str, int* length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glStencilFuncSeparate(uint frontfunc, uint backfunc, int reference, uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glStencilMaskSeparate(uint face, uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1f(int location, float v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1fv(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1i(int location, int v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1iv(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2f(int location, float v0, float v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2fv(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2i(int location, int v0, int v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2iv(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3f(int location, float v0, float v1, float v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3fv(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3i(int location, int v0, int v1, int v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3iv(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4f(int location, float v0, float v1, float v2, float v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4fv(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4i(int location, int v0, int v1, int v2, int v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4iv(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUseProgram(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glValidateProgram(uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1d(uint index, double x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1f(uint index, float x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1fv(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1s(uint index, short x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib1sv(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2d(uint index, double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2f(uint index, float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2fv(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2s(uint index, short x, short y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib2sv(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3d(uint index, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3f(uint index, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3fv(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3s(uint index, short x, short y, short z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib3sv(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Nbv(uint index, sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Niv(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Nsv(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Nubv(uint index, byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Nuiv(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4Nusv(uint index, ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4bv(uint index, sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4d(uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4f(uint index, float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4fv(uint index, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4iv(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4s(uint index, short x, short y, short z, short w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4sv(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4ubv(uint index, byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4uiv(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttrib4usv(uint index, ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);

 		static __glAttachShader __GlueAttachShader;
		static __glBindAttribLocation __GlueBindAttribLocation;
		static __glBlendEquationSeparate __GlueBlendEquationSeparate;
		static __glCompileShader __GlueCompileShader;
		static __glCreateProgram __GlueCreateProgram;
		static __glCreateShader __GlueCreateShader;
		static __glDeleteProgram __GlueDeleteProgram;
		static __glDeleteShader __GlueDeleteShader;
		static __glDetachShader __GlueDetachShader;
		static __glDisableVertexAttribArray __GlueDisableVertexAttribArray;
		static __glDrawBuffers __GlueDrawBuffers;
		static __glEnableVertexAttribArray __GlueEnableVertexAttribArray;
		static __glGetActiveAttrib __GlueGetActiveAttrib;
		static __glGetActiveUniform __GlueGetActiveUniform;
		static __glGetAttachedShaders __GlueGetAttachedShaders;
		static __glGetAttribLocation __GlueGetAttribLocation;
		static __glGetProgramInfoLog __GlueGetProgramInfoLog;
		static __glGetProgramiv __GlueGetProgramiv;
		static __glGetShaderInfoLog __GlueGetShaderInfoLog;
		static __glGetShaderSource __GlueGetShaderSource;
		static __glGetShaderiv __GlueGetShaderiv;
		static __glGetUniformLocation __GlueGetUniformLocation;
		static __glGetUniformfv __GlueGetUniformfv;
		static __glGetUniformiv __GlueGetUniformiv;
		static __glGetVertexAttribPointerv __GlueGetVertexAttribPointerv;
		static __glGetVertexAttribdv __GlueGetVertexAttribdv;
		static __glGetVertexAttribfv __GlueGetVertexAttribfv;
		static __glGetVertexAttribiv __GlueGetVertexAttribiv;
		static __glIsProgram __GlueIsProgram;
		static __glIsShader __GlueIsShader;
		static __glLinkProgram __GlueLinkProgram;
		static __glShaderSource __GlueShaderSource;
		static __glStencilFuncSeparate __GlueStencilFuncSeparate;
		static __glStencilMaskSeparate __GlueStencilMaskSeparate;
		static __glStencilOpSeparate __GlueStencilOpSeparate;
		static __glUniform1f __GlueUniform1f;
		static __glUniform1fv __GlueUniform1fv;
		static __glUniform1i __GlueUniform1i;
		static __glUniform1iv __GlueUniform1iv;
		static __glUniform2f __GlueUniform2f;
		static __glUniform2fv __GlueUniform2fv;
		static __glUniform2i __GlueUniform2i;
		static __glUniform2iv __GlueUniform2iv;
		static __glUniform3f __GlueUniform3f;
		static __glUniform3fv __GlueUniform3fv;
		static __glUniform3i __GlueUniform3i;
		static __glUniform3iv __GlueUniform3iv;
		static __glUniform4f __GlueUniform4f;
		static __glUniform4fv __GlueUniform4fv;
		static __glUniform4i __GlueUniform4i;
		static __glUniform4iv __GlueUniform4iv;
		static __glUniformMatrix2fv __GlueUniformMatrix2fv;
		static __glUniformMatrix3fv __GlueUniformMatrix3fv;
		static __glUniformMatrix4fv __GlueUniformMatrix4fv;
		static __glUseProgram __GlueUseProgram;
		static __glValidateProgram __GlueValidateProgram;
		static __glVertexAttrib1d __GlueVertexAttrib1d;
		static __glVertexAttrib1dv __GlueVertexAttrib1dv;
		static __glVertexAttrib1f __GlueVertexAttrib1f;
		static __glVertexAttrib1fv __GlueVertexAttrib1fv;
		static __glVertexAttrib1s __GlueVertexAttrib1s;
		static __glVertexAttrib1sv __GlueVertexAttrib1sv;
		static __glVertexAttrib2d __GlueVertexAttrib2d;
		static __glVertexAttrib2dv __GlueVertexAttrib2dv;
		static __glVertexAttrib2f __GlueVertexAttrib2f;
		static __glVertexAttrib2fv __GlueVertexAttrib2fv;
		static __glVertexAttrib2s __GlueVertexAttrib2s;
		static __glVertexAttrib2sv __GlueVertexAttrib2sv;
		static __glVertexAttrib3d __GlueVertexAttrib3d;
		static __glVertexAttrib3dv __GlueVertexAttrib3dv;
		static __glVertexAttrib3f __GlueVertexAttrib3f;
		static __glVertexAttrib3fv __GlueVertexAttrib3fv;
		static __glVertexAttrib3s __GlueVertexAttrib3s;
		static __glVertexAttrib3sv __GlueVertexAttrib3sv;
		static __glVertexAttrib4Nbv __GlueVertexAttrib4Nbv;
		static __glVertexAttrib4Niv __GlueVertexAttrib4Niv;
		static __glVertexAttrib4Nsv __GlueVertexAttrib4Nsv;
		static __glVertexAttrib4Nub __GlueVertexAttrib4Nub;
		static __glVertexAttrib4Nubv __GlueVertexAttrib4Nubv;
		static __glVertexAttrib4Nuiv __GlueVertexAttrib4Nuiv;
		static __glVertexAttrib4Nusv __GlueVertexAttrib4Nusv;
		static __glVertexAttrib4bv __GlueVertexAttrib4bv;
		static __glVertexAttrib4d __GlueVertexAttrib4d;
		static __glVertexAttrib4dv __GlueVertexAttrib4dv;
		static __glVertexAttrib4f __GlueVertexAttrib4f;
		static __glVertexAttrib4fv __GlueVertexAttrib4fv;
		static __glVertexAttrib4iv __GlueVertexAttrib4iv;
		static __glVertexAttrib4s __GlueVertexAttrib4s;
		static __glVertexAttrib4sv __GlueVertexAttrib4sv;
		static __glVertexAttrib4ubv __GlueVertexAttrib4ubv;
		static __glVertexAttrib4uiv __GlueVertexAttrib4uiv;
		static __glVertexAttrib4usv __GlueVertexAttrib4usv;
		static __glVertexAttribPointer __GlueVertexAttribPointer;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glAttachShader(uint program, uint shader) => __GlueAttachShader(program, shader);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindAttribLocation(uint program, uint index, char* name) => __GlueBindAttribLocation(program, index, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationSeparate(uint modeRGB, uint modeAlpha) => __GlueBlendEquationSeparate(modeRGB, modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompileShader(uint shader) => __GlueCompileShader(shader);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCreateProgram( ) => __GlueCreateProgram();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCreateShader(uint type) => __GlueCreateShader(type);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteProgram(uint program) => __GlueDeleteProgram(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteShader(uint shader) => __GlueDeleteShader(shader);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDetachShader(uint program, uint shader) => __GlueDetachShader(program, shader);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableVertexAttribArray(uint index) => __GlueDisableVertexAttribArray(index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawBuffers(int n, uint* bufs) => __GlueDrawBuffers(n, bufs);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableVertexAttribArray(uint index) => __GlueEnableVertexAttribArray(index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveAttrib(uint program, uint index, int maxLength, int* length, int* size, uint* type, char* name) => __GlueGetActiveAttrib(program, index, maxLength, length, size, type, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveUniform(uint program, uint index, int maxLength, int* length, int* size, uint* type, char* name) => __GlueGetActiveUniform(program, index, maxLength, length, size, type, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) => __GlueGetAttachedShaders(program, maxCount, count, shaders);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetAttribLocation(uint program, char* name) => __GlueGetAttribLocation(program, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) => __GlueGetProgramInfoLog(program, bufSize, length, infoLog);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramiv(uint program, uint pname, int* param) => __GlueGetProgramiv(program, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) => __GlueGetShaderInfoLog(shader, bufSize, length, infoLog);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetShaderSource(uint obj, int maxLength, int* length, char* source) => __GlueGetShaderSource(obj, maxLength, length, source);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetShaderiv(uint shader, uint pname, int* param) => __GlueGetShaderiv(shader, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetUniformLocation(uint program, char* name) => __GlueGetUniformLocation(program, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformfv(uint program, int location, float* parameters) => __GlueGetUniformfv(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformiv(uint program, int location, int* parameters) => __GlueGetUniformiv(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribPointerv(uint index, uint pname, IntPtr* pointer) => __GlueGetVertexAttribPointerv(index, pname, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribdv(uint index, uint pname, double* parameters) => __GlueGetVertexAttribdv(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribfv(uint index, uint pname, float* parameters) => __GlueGetVertexAttribfv(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribiv(uint index, uint pname, int* parameters) => __GlueGetVertexAttribiv(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsProgram(uint program) => __GlueIsProgram(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsShader(uint shader) => __GlueIsShader(shader);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLinkProgram(uint program) => __GlueLinkProgram(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderSource(uint shader, int count, char** str, int* length) => __GlueShaderSource(shader, count, str, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glStencilFuncSeparate(uint frontfunc, uint backfunc, int reference, uint mask) => __GlueStencilFuncSeparate(frontfunc, backfunc, reference, mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glStencilMaskSeparate(uint face, uint mask) => __GlueStencilMaskSeparate(face, mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) => __GlueStencilOpSeparate(face, sfail, dpfail, dppass);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1f(int location, float v0) => __GlueUniform1f(location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1fv(int location, int count, float* value) => __GlueUniform1fv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1i(int location, int v0) => __GlueUniform1i(location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1iv(int location, int count, int* value) => __GlueUniform1iv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2f(int location, float v0, float v1) => __GlueUniform2f(location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2fv(int location, int count, float* value) => __GlueUniform2fv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2i(int location, int v0, int v1) => __GlueUniform2i(location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2iv(int location, int count, int* value) => __GlueUniform2iv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3f(int location, float v0, float v1, float v2) => __GlueUniform3f(location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3fv(int location, int count, float* value) => __GlueUniform3fv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3i(int location, int v0, int v1, int v2) => __GlueUniform3i(location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3iv(int location, int count, int* value) => __GlueUniform3iv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4f(int location, float v0, float v1, float v2, float v3) => __GlueUniform4f(location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4fv(int location, int count, float* value) => __GlueUniform4fv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4i(int location, int v0, int v1, int v2, int v3) => __GlueUniform4i(location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4iv(int location, int count, int* value) => __GlueUniform4iv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix2fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix3fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix4fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUseProgram(uint program) => __GlueUseProgram(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glValidateProgram(uint program) => __GlueValidateProgram(program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1d(uint index, double x) => __GlueVertexAttrib1d(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1dv(uint index, double* v) => __GlueVertexAttrib1dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1f(uint index, float x) => __GlueVertexAttrib1f(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1fv(uint index, float* v) => __GlueVertexAttrib1fv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1s(uint index, short x) => __GlueVertexAttrib1s(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib1sv(uint index, short* v) => __GlueVertexAttrib1sv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2d(uint index, double x, double y) => __GlueVertexAttrib2d(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2dv(uint index, double* v) => __GlueVertexAttrib2dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2f(uint index, float x, float y) => __GlueVertexAttrib2f(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2fv(uint index, float* v) => __GlueVertexAttrib2fv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2s(uint index, short x, short y) => __GlueVertexAttrib2s(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib2sv(uint index, short* v) => __GlueVertexAttrib2sv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3d(uint index, double x, double y, double z) => __GlueVertexAttrib3d(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3dv(uint index, double* v) => __GlueVertexAttrib3dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3f(uint index, float x, float y, float z) => __GlueVertexAttrib3f(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3fv(uint index, float* v) => __GlueVertexAttrib3fv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3s(uint index, short x, short y, short z) => __GlueVertexAttrib3s(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib3sv(uint index, short* v) => __GlueVertexAttrib3sv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Nbv(uint index, sbyte* v) => __GlueVertexAttrib4Nbv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Niv(uint index, int* v) => __GlueVertexAttrib4Niv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Nsv(uint index, short* v) => __GlueVertexAttrib4Nsv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) => __GlueVertexAttrib4Nub(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Nubv(uint index, byte* v) => __GlueVertexAttrib4Nubv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Nuiv(uint index, uint* v) => __GlueVertexAttrib4Nuiv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4Nusv(uint index, ushort* v) => __GlueVertexAttrib4Nusv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4bv(uint index, sbyte* v) => __GlueVertexAttrib4bv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4d(uint index, double x, double y, double z, double w) => __GlueVertexAttrib4d(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4dv(uint index, double* v) => __GlueVertexAttrib4dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4f(uint index, float x, float y, float z, float w) => __GlueVertexAttrib4f(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4fv(uint index, float* v) => __GlueVertexAttrib4fv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4iv(uint index, int* v) => __GlueVertexAttrib4iv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4s(uint index, short x, short y, short z, short w) => __GlueVertexAttrib4s(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4sv(uint index, short* v) => __GlueVertexAttrib4sv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4ubv(uint index, byte* v) => __GlueVertexAttrib4ubv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4uiv(uint index, uint* v) => __GlueVertexAttrib4uiv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttrib4usv(uint index, ushort* v) => __GlueVertexAttrib4usv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer) => __GlueVertexAttribPointer(index, size, type, normalized, stride, pointer);



	}
}


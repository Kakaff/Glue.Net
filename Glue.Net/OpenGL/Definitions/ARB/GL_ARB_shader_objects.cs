using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_shader_objects {get; private set;}

		public const int GL_PROGRAM_OBJECT_ARB = 0x8B40;
		public const int GL_SHADER_OBJECT_ARB = 0x8B48;
		public const int GL_OBJECT_TYPE_ARB = 0x8B4E;
		public const int GL_OBJECT_SUBTYPE_ARB = 0x8B4F;
		public const int GL_FLOAT_VEC2_ARB = 0x8B50;
		public const int GL_FLOAT_VEC3_ARB = 0x8B51;
		public const int GL_FLOAT_VEC4_ARB = 0x8B52;
		public const int GL_INT_VEC2_ARB = 0x8B53;
		public const int GL_INT_VEC3_ARB = 0x8B54;
		public const int GL_INT_VEC4_ARB = 0x8B55;
		public const int GL_BOOL_ARB = 0x8B56;
		public const int GL_BOOL_VEC2_ARB = 0x8B57;
		public const int GL_BOOL_VEC3_ARB = 0x8B58;
		public const int GL_BOOL_VEC4_ARB = 0x8B59;
		public const int GL_FLOAT_MAT2_ARB = 0x8B5A;
		public const int GL_FLOAT_MAT3_ARB = 0x8B5B;
		public const int GL_FLOAT_MAT4_ARB = 0x8B5C;
		public const int GL_SAMPLER_1D_ARB = 0x8B5D;
		public const int GL_SAMPLER_2D_ARB = 0x8B5E;
		public const int GL_SAMPLER_3D_ARB = 0x8B5F;
		public const int GL_SAMPLER_CUBE_ARB = 0x8B60;
		public const int GL_SAMPLER_1D_SHADOW_ARB = 0x8B61;
		public const int GL_SAMPLER_2D_SHADOW_ARB = 0x8B62;
		public const int GL_SAMPLER_2D_RECT_ARB = 0x8B63;
		public const int GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
		public const int GL_OBJECT_DELETE_STATUS_ARB = 0x8B80;
		public const int GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81;
		public const int GL_OBJECT_LINK_STATUS_ARB = 0x8B82;
		public const int GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
		public const int GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
		public const int GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
		public const int GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
		public const int GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
		public const int GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glAttachObjectARB(uint containerObj, uint obj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompileShaderARB(uint shaderObj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCreateProgramObjectARB( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCreateShaderObjectARB(uint shaderType);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteObjectARB(uint obj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDetachObjectARB(uint containerObj, uint attachedObj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetHandleARB(uint pname);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInfoLogARB(uint obj, int maxLength, int* length, char* infoLog);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetObjectParameterfvARB(uint obj, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetObjectParameterivARB(uint obj, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetShaderSourceARB(uint obj, int maxLength, int* length, char* source);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetUniformLocationARB(uint programObj, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformfvARB(uint programObj, int location, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformivARB(uint programObj, int location, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLinkProgramARB(uint programObj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderSourceARB(uint shaderObj, int count, char** str, int* length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1fARB(int location, float v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1fvARB(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1iARB(int location, int v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1ivARB(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2fARB(int location, float v0, float v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2fvARB(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2iARB(int location, int v0, int v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2ivARB(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3fARB(int location, float v0, float v1, float v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3fvARB(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3iARB(int location, int v0, int v1, int v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3ivARB(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4fARB(int location, float v0, float v1, float v2, float v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4fvARB(int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4iARB(int location, int v0, int v1, int v2, int v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4ivARB(int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2fvARB(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3fvARB(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4fvARB(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUseProgramObjectARB(uint programObj);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glValidateProgramARB(uint programObj);

 		static __glAttachObjectARB __GlueAttachObjectARB;
		static __glCompileShaderARB __GlueCompileShaderARB;
		static __glCreateProgramObjectARB __GlueCreateProgramObjectARB;
		static __glCreateShaderObjectARB __GlueCreateShaderObjectARB;
		static __glDeleteObjectARB __GlueDeleteObjectARB;
		static __glDetachObjectARB __GlueDetachObjectARB;
		static __glGetActiveUniformARB __GlueGetActiveUniformARB;
		static __glGetAttachedObjectsARB __GlueGetAttachedObjectsARB;
		static __glGetHandleARB __GlueGetHandleARB;
		static __glGetInfoLogARB __GlueGetInfoLogARB;
		static __glGetObjectParameterfvARB __GlueGetObjectParameterfvARB;
		static __glGetObjectParameterivARB __GlueGetObjectParameterivARB;
		static __glGetShaderSourceARB __GlueGetShaderSourceARB;
		static __glGetUniformLocationARB __GlueGetUniformLocationARB;
		static __glGetUniformfvARB __GlueGetUniformfvARB;
		static __glGetUniformivARB __GlueGetUniformivARB;
		static __glLinkProgramARB __GlueLinkProgramARB;
		static __glShaderSourceARB __GlueShaderSourceARB;
		static __glUniform1fARB __GlueUniform1fARB;
		static __glUniform1fvARB __GlueUniform1fvARB;
		static __glUniform1iARB __GlueUniform1iARB;
		static __glUniform1ivARB __GlueUniform1ivARB;
		static __glUniform2fARB __GlueUniform2fARB;
		static __glUniform2fvARB __GlueUniform2fvARB;
		static __glUniform2iARB __GlueUniform2iARB;
		static __glUniform2ivARB __GlueUniform2ivARB;
		static __glUniform3fARB __GlueUniform3fARB;
		static __glUniform3fvARB __GlueUniform3fvARB;
		static __glUniform3iARB __GlueUniform3iARB;
		static __glUniform3ivARB __GlueUniform3ivARB;
		static __glUniform4fARB __GlueUniform4fARB;
		static __glUniform4fvARB __GlueUniform4fvARB;
		static __glUniform4iARB __GlueUniform4iARB;
		static __glUniform4ivARB __GlueUniform4ivARB;
		static __glUniformMatrix2fvARB __GlueUniformMatrix2fvARB;
		static __glUniformMatrix3fvARB __GlueUniformMatrix3fvARB;
		static __glUniformMatrix4fvARB __GlueUniformMatrix4fvARB;
		static __glUseProgramObjectARB __GlueUseProgramObjectARB;
		static __glValidateProgramARB __GlueValidateProgramARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glAttachObjectARB(uint containerObj, uint obj) => __GlueAttachObjectARB(containerObj, obj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompileShaderARB(uint shaderObj) => __GlueCompileShaderARB(shaderObj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCreateProgramObjectARB( ) => __GlueCreateProgramObjectARB();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCreateShaderObjectARB(uint shaderType) => __GlueCreateShaderObjectARB(shaderType);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteObjectARB(uint obj) => __GlueDeleteObjectARB(obj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDetachObjectARB(uint containerObj, uint attachedObj) => __GlueDetachObjectARB(containerObj, attachedObj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveUniformARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) => __GlueGetActiveUniformARB(programObj, index, maxLength, length, size, type, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetAttachedObjectsARB(uint containerObj, int maxCount, int* count, uint* obj) => __GlueGetAttachedObjectsARB(containerObj, maxCount, count, obj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetHandleARB(uint pname) => __GlueGetHandleARB(pname);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInfoLogARB(uint obj, int maxLength, int* length, char* infoLog) => __GlueGetInfoLogARB(obj, maxLength, length, infoLog);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetObjectParameterfvARB(uint obj, uint pname, float* parameters) => __GlueGetObjectParameterfvARB(obj, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetObjectParameterivARB(uint obj, uint pname, int* parameters) => __GlueGetObjectParameterivARB(obj, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetShaderSourceARB(uint obj, int maxLength, int* length, char* source) => __GlueGetShaderSourceARB(obj, maxLength, length, source);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetUniformLocationARB(uint programObj, char* name) => __GlueGetUniformLocationARB(programObj, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformfvARB(uint programObj, int location, float* parameters) => __GlueGetUniformfvARB(programObj, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformivARB(uint programObj, int location, int* parameters) => __GlueGetUniformivARB(programObj, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLinkProgramARB(uint programObj) => __GlueLinkProgramARB(programObj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderSourceARB(uint shaderObj, int count, char** str, int* length) => __GlueShaderSourceARB(shaderObj, count, str, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1fARB(int location, float v0) => __GlueUniform1fARB(location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1fvARB(int location, int count, float* value) => __GlueUniform1fvARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1iARB(int location, int v0) => __GlueUniform1iARB(location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1ivARB(int location, int count, int* value) => __GlueUniform1ivARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2fARB(int location, float v0, float v1) => __GlueUniform2fARB(location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2fvARB(int location, int count, float* value) => __GlueUniform2fvARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2iARB(int location, int v0, int v1) => __GlueUniform2iARB(location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2ivARB(int location, int count, int* value) => __GlueUniform2ivARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3fARB(int location, float v0, float v1, float v2) => __GlueUniform3fARB(location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3fvARB(int location, int count, float* value) => __GlueUniform3fvARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3iARB(int location, int v0, int v1, int v2) => __GlueUniform3iARB(location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3ivARB(int location, int count, int* value) => __GlueUniform3ivARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4fARB(int location, float v0, float v1, float v2, float v3) => __GlueUniform4fARB(location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4fvARB(int location, int count, float* value) => __GlueUniform4fvARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4iARB(int location, int v0, int v1, int v2, int v3) => __GlueUniform4iARB(location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4ivARB(int location, int count, int* value) => __GlueUniform4ivARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2fvARB(int location, int count, bool transpose, float* value) => __GlueUniformMatrix2fvARB(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3fvARB(int location, int count, bool transpose, float* value) => __GlueUniformMatrix3fvARB(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4fvARB(int location, int count, bool transpose, float* value) => __GlueUniformMatrix4fvARB(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUseProgramObjectARB(uint programObj) => __GlueUseProgramObjectARB(programObj);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glValidateProgramARB(uint programObj) => __GlueValidateProgramARB(programObj);



	}
}


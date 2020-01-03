using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_shader {get; private set;}

		public const int GL_VERTEX_SHADER_ARB = 0x8B31;
		public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
		public const int GL_MAX_VARYING_FLOATS_ARB = 0x8B4B;
		public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
		public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
		public const int GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
		public const int GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindAttribLocationARB(uint programObj, uint index, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetAttribLocationARB(uint programObj, char* name);

 		static __glBindAttribLocationARB __GlueBindAttribLocationARB;
		static __glGetActiveAttribARB __GlueGetActiveAttribARB;
		static __glGetAttribLocationARB __GlueGetAttribLocationARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindAttribLocationARB(uint programObj, uint index, char* name) => __GlueBindAttribLocationARB(programObj, index, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveAttribARB(uint programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name) => __GlueGetActiveAttribARB(programObj, index, maxLength, length, size, type, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetAttribLocationARB(uint programObj, char* name) => __GlueGetAttribLocationARB(programObj, name);



	}
}


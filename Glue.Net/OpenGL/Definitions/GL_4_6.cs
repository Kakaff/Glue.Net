using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_4_6 {get; private set;}

		public const int GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
		public const int GL_PARAMETER_BUFFER = 0x80EE;
		public const int GL_PARAMETER_BUFFER_BINDING = 0x80EF;
		public const int GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;
		public const int GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
		public const int GL_VERTICES_SUBMITTED = 0x82EE;
		public const int GL_PRIMITIVES_SUBMITTED = 0x82EF;
		public const int GL_VERTEX_SHADER_INVOCATIONS = 0x82F0;
		public const int GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1;
		public const int GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
		public const int GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
		public const int GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
		public const int GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5;
		public const int GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6;
		public const int GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
		public const int GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
		public const int GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
		public const int GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
		public const int GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
		public const int GL_SPIR_V_BINARY = 0x9552;
		public const int GL_SPIR_V_EXTENSIONS = 0x9553;
		public const int GL_NUM_SPIR_V_EXTENSIONS = 0x9554;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawArraysIndirectCount(uint mode, IntPtr indirect, int drawcount, int maxdrawcount, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsIndirectCount(uint mode, uint type, IntPtr indirect, int drawcount, int maxdrawcount, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSpecializeShader(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

 		static __glMultiDrawArraysIndirectCount __GlueMultiDrawArraysIndirectCount;
		static __glMultiDrawElementsIndirectCount __GlueMultiDrawElementsIndirectCount;
		static __glSpecializeShader __GlueSpecializeShader;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawArraysIndirectCount(uint mode, IntPtr indirect, int drawcount, int maxdrawcount, int stride) => __GlueMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsIndirectCount(uint mode, uint type, IntPtr indirect, int drawcount, int maxdrawcount, int stride) => __GlueMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSpecializeShader(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) => __GlueSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_gl_spirv {get; private set;}

		public const int GL_SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;
		public const int GL_SPIR_V_BINARY_ARB = 0x9552;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSpecializeShaderARB(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

 		static __glSpecializeShaderARB __GlueSpecializeShaderARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSpecializeShaderARB(uint shader, char* pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue) => __GlueSpecializeShaderARB(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);



	}
}


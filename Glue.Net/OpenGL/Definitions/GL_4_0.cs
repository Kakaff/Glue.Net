using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_4_0 {get; private set;}

		public const int GL_SAMPLE_SHADING = 0x8C36;
		public const int GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
		public const int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
		public const int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
		public const int GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS = 0x8F9F;
		public const int GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
		public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
		public const int GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
		public const int GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
		public const int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
		public const int GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
		public const int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationi(uint buf, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFunci(uint buf, uint src, uint dst);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMinSampleShading(float value);

 		static __glBlendEquationSeparatei __GlueBlendEquationSeparatei;
		static __glBlendEquationi __GlueBlendEquationi;
		static __glBlendFuncSeparatei __GlueBlendFuncSeparatei;
		static __glBlendFunci __GlueBlendFunci;
		static __glMinSampleShading __GlueMinSampleShading;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) => __GlueBlendEquationSeparatei(buf, modeRGB, modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationi(uint buf, uint mode) => __GlueBlendEquationi(buf, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) => __GlueBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFunci(uint buf, uint src, uint dst) => __GlueBlendFunci(buf, src, dst);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMinSampleShading(float value) => __GlueMinSampleShading(value);



	}
}


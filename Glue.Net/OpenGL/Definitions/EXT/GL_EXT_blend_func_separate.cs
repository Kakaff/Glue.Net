using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_blend_func_separate {get; private set;}

		public const int GL_BLEND_DST_RGB_EXT = 0x80C8;
		public const int GL_BLEND_SRC_RGB_EXT = 0x80C9;
		public const int GL_BLEND_DST_ALPHA_EXT = 0x80CA;
		public const int GL_BLEND_SRC_ALPHA_EXT = 0x80CB;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFuncSeparateEXT(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

 		static __glBlendFuncSeparateEXT __GlueBlendFuncSeparateEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFuncSeparateEXT(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) => __GlueBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);



	}
}


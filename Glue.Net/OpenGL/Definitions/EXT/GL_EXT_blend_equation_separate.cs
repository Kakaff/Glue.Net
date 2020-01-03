using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_blend_equation_separate {get; private set;}

		public const int GL_BLEND_EQUATION_RGB_EXT = 0x8009;
		public const int GL_BLEND_EQUATION_ALPHA_EXT = 0x883D;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationSeparateEXT(uint modeRGB, uint modeAlpha);

 		static __glBlendEquationSeparateEXT __GlueBlendEquationSeparateEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationSeparateEXT(uint modeRGB, uint modeAlpha) => __GlueBlendEquationSeparateEXT(modeRGB, modeAlpha);



	}
}


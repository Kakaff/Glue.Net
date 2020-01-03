using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_blend_minmax {get; private set;}

		public const int GL_FUNC_ADD_EXT = 0x8006;
		public const int GL_MIN_EXT = 0x8007;
		public const int GL_MAX_EXT = 0x8008;
		public const int GL_BLEND_EQUATION_EXT = 0x8009;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationEXT(uint mode);

 		static __glBlendEquationEXT __GlueBlendEquationEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationEXT(uint mode) => __GlueBlendEquationEXT(mode);



	}
}


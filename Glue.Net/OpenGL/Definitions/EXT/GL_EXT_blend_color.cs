using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_blend_color {get; private set;}

		public const int GL_CONSTANT_COLOR_EXT = 0x8001;
		public const int GL_ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
		public const int GL_CONSTANT_ALPHA_EXT = 0x8003;
		public const int GL_ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
		public const int GL_BLEND_COLOR_EXT = 0x8005;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendColorEXT(float red, float green, float blue, float alpha);

 		static __glBlendColorEXT __GlueBlendColorEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendColorEXT(float red, float green, float blue, float alpha) => __GlueBlendColorEXT(red, green, blue, alpha);



	}
}


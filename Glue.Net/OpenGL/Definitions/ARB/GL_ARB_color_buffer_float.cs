using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_color_buffer_float {get; private set;}

		public const int GL_RGBA_FLOAT_MODE_ARB = 0x8820;
		public const int GL_CLAMP_VERTEX_COLOR_ARB = 0x891A;
		public const int GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
		public const int GL_CLAMP_READ_COLOR_ARB = 0x891C;
		public const int GL_FIXED_ONLY_ARB = 0x891D;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClampColorARB(uint target, uint clamp);

 		static __glClampColorARB __GlueClampColorARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClampColorARB(uint target, uint clamp) => __GlueClampColorARB(target, clamp);



	}
}


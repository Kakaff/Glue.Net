using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_window_rectangles {get; private set;}

		public const int GL_INCLUSIVE_EXT = 0x8F10;
		public const int GL_EXCLUSIVE_EXT = 0x8F11;
		public const int GL_WINDOW_RECTANGLE_EXT = 0x8F12;
		public const int GL_WINDOW_RECTANGLE_MODE_EXT = 0x8F13;
		public const int GL_MAX_WINDOW_RECTANGLES_EXT = 0x8F14;
		public const int GL_NUM_WINDOW_RECTANGLES_EXT = 0x8F15;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowRectanglesEXT(uint mode, int count, int* box);

 		static __glWindowRectanglesEXT __GlueWindowRectanglesEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowRectanglesEXT(uint mode, int count, int* box) => __GlueWindowRectanglesEXT(mode, count, box);



	}
}


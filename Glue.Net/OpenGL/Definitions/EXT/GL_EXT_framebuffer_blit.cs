using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_framebuffer_blit {get; private set;}

		public const int GL_DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
		public const int GL_READ_FRAMEBUFFER_EXT = 0x8CA8;
		public const int GL_DRAW_FRAMEBUFFER_EXT = 0x8CA9;
		public const int GL_READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

 		static __glBlitFramebufferEXT __GlueBlitFramebufferEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlitFramebufferEXT(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) => __GlueBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);



	}
}


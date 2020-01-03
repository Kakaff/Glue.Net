using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_discard_framebuffer {get; private set;}

		public const int GL_COLOR_EXT = 0x1800;
		public const int GL_DEPTH_EXT = 0x1801;
		public const int GL_STENCIL_EXT = 0x1802;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDiscardFramebufferEXT(uint target, int numAttachments, uint* attachments);

 		static __glDiscardFramebufferEXT __GlueDiscardFramebufferEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDiscardFramebufferEXT(uint target, int numAttachments, uint* attachments) => __GlueDiscardFramebufferEXT(target, numAttachments, attachments);



	}
}


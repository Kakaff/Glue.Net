using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_multisampled_render_to_texture {get; private set;}

		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture2DMultisampleEXT(uint target, uint attachment, uint textarget, uint texture, int level, int samples);

 		static __glFramebufferTexture2DMultisampleEXT __GlueFramebufferTexture2DMultisampleEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture2DMultisampleEXT(uint target, uint attachment, uint textarget, uint texture, int level, int samples) => __GlueFramebufferTexture2DMultisampleEXT(target, attachment, textarget, texture, level, samples);



	}
}


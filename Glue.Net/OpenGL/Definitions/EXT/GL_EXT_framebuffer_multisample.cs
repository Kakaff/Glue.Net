using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_framebuffer_multisample {get; private set;}

		public const int GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB;
		public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
		public const int GL_MAX_SAMPLES_EXT = 0x8D57;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRenderbufferStorageMultisampleEXT(uint target, int samples, uint internalformat, int width, int height);

 		static __glRenderbufferStorageMultisampleEXT __GlueRenderbufferStorageMultisampleEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRenderbufferStorageMultisampleEXT(uint target, int samples, uint internalformat, int width, int height) => __GlueRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_shader_pixel_local_storage2 {get; private set;}

		public const int GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;
		public const int GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;
		public const int GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearPixelLocalStorageuiEXT(int offset, int n, uint* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferPixelLocalStorageSizeEXT(uint target, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetFramebufferPixelLocalStorageSizeEXT(uint target);

 		static __glClearPixelLocalStorageuiEXT __GlueClearPixelLocalStorageuiEXT;
		static __glFramebufferPixelLocalStorageSizeEXT __GlueFramebufferPixelLocalStorageSizeEXT;
		static __glGetFramebufferPixelLocalStorageSizeEXT __GlueGetFramebufferPixelLocalStorageSizeEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearPixelLocalStorageuiEXT(int offset, int n, uint* values) => __GlueClearPixelLocalStorageuiEXT(offset, n, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferPixelLocalStorageSizeEXT(uint target, int size) => __GlueFramebufferPixelLocalStorageSizeEXT(target, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetFramebufferPixelLocalStorageSizeEXT(uint target) => __GlueGetFramebufferPixelLocalStorageSizeEXT(target);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_multiview_draw_buffers {get; private set;}

		public const int GL_DRAW_BUFFER_EXT = 0x0C01;
		public const int GL_READ_BUFFER_EXT = 0x0C02;
		public const int GL_COLOR_ATTACHMENT_EXT = 0x90F0;
		public const int GL_MULTIVIEW_EXT = 0x90F1;
		public const int GL_MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawBuffersIndexedEXT(int n, uint* location, int* indices);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetIntegeri_vEXT(uint target, uint index, int* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glReadBufferIndexedEXT(uint src, int index);

 		static __glDrawBuffersIndexedEXT __GlueDrawBuffersIndexedEXT;
		static __glGetIntegeri_vEXT __GlueGetIntegeri_vEXT;
		static __glReadBufferIndexedEXT __GlueReadBufferIndexedEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawBuffersIndexedEXT(int n, uint* location, int* indices) => __GlueDrawBuffersIndexedEXT(n, location, indices);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetIntegeri_vEXT(uint target, uint index, int* data) => __GlueGetIntegeri_vEXT(target, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glReadBufferIndexedEXT(uint src, int index) => __GlueReadBufferIndexedEXT(src, index);



	}
}


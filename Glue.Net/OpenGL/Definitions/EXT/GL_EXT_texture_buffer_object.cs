using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_buffer_object {get; private set;}

		public const int GL_TEXTURE_BUFFER_EXT = 0x8C2A;
		public const int GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
		public const int GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
		public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
		public const int GL_TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexBufferEXT(uint target, uint internalformat, uint buffer);

 		static __glTexBufferEXT __GlueTexBufferEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexBufferEXT(uint target, uint internalformat, uint buffer) => __GlueTexBufferEXT(target, internalformat, buffer);



	}
}


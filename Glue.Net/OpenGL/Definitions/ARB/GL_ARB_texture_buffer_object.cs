using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_buffer_object {get; private set;}

		public const int GL_TEXTURE_BUFFER_ARB = 0x8C2A;
		public const int GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
		public const int GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
		public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
		public const int GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexBufferARB(uint target, uint internalformat, uint buffer);

 		static __glTexBufferARB __GlueTexBufferARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexBufferARB(uint target, uint internalformat, uint buffer) => __GlueTexBufferARB(target, internalformat, buffer);



	}
}


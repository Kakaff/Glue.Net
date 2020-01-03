using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_buffer_range {get; private set;}

		public const int GL_TEXTURE_BUFFER_OFFSET = 0x919D;
		public const int GL_TEXTURE_BUFFER_SIZE = 0x919E;
		public const int GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureBufferRangeEXT(uint texture, uint target, uint internalformat, uint buffer, int offset, int size);

 		static __glTexBufferRange __GlueTexBufferRange;
		static __glTextureBufferRangeEXT __GlueTextureBufferRangeEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexBufferRange(uint target, uint internalformat, uint buffer, int offset, int size) => __GlueTexBufferRange(target, internalformat, buffer, offset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureBufferRangeEXT(uint texture, uint target, uint internalformat, uint buffer, int offset, int size) => __GlueTextureBufferRangeEXT(texture, target, internalformat, buffer, offset, size);



	}
}


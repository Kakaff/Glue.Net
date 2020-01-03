using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_map_buffer_range {get; private set;}

		public const int GL_MAP_READ_BIT_EXT = 0x0001;
		public const int GL_MAP_WRITE_BIT_EXT = 0x0002;
		public const int GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;
		public const int GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;
		public const int GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;
		public const int GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFlushMappedBufferRangeEXT(uint target, int offset, int length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapBufferRangeEXT(uint target, int offset, int length, uint access);

 		static __glFlushMappedBufferRangeEXT __GlueFlushMappedBufferRangeEXT;
		static __glMapBufferRangeEXT __GlueMapBufferRangeEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFlushMappedBufferRangeEXT(uint target, int offset, int length) => __GlueFlushMappedBufferRangeEXT(target, offset, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapBufferRangeEXT(uint target, int offset, int length, uint access) => __GlueMapBufferRangeEXT(target, offset, length, access);



	}
}


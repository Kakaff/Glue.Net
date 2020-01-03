using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_map_buffer_range {get; private set;}

		public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
		public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
		public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
		public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFlushMappedBufferRange(uint target, int offset, int length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapBufferRange(uint target, int offset, int length, uint access);

 		static __glFlushMappedBufferRange __GlueFlushMappedBufferRange;
		static __glMapBufferRange __GlueMapBufferRange;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFlushMappedBufferRange(uint target, int offset, int length) => __GlueFlushMappedBufferRange(target, offset, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapBufferRange(uint target, int offset, int length, uint access) => __GlueMapBufferRange(target, offset, length, access);



	}
}


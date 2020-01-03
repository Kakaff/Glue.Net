using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_buffer_storage {get; private set;}

		public const int GL_MAP_READ_BIT = 0x0001;
		public const int GL_MAP_WRITE_BIT = 0x0002;
		public const int GL_MAP_PERSISTENT_BIT = 0x00000040;
		public const int GL_MAP_COHERENT_BIT = 0x00000080;
		public const int GL_DYNAMIC_STORAGE_BIT = 0x0100;
		public const int GL_CLIENT_STORAGE_BIT = 0x0200;
		public const int GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
		public const int GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
		public const int GL_BUFFER_STORAGE_FLAGS = 0x8220;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferStorage(uint target, int size, IntPtr data, uint flags);

 		static __glBufferStorage __GlueBufferStorage;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferStorage(uint target, int size, IntPtr data, uint flags) => __GlueBufferStorage(target, size, data, flags);



	}
}


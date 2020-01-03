using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_buffer_storage {get; private set;}

		public const int GL_MAP_PERSISTENT_BIT_EXT = 0x0040;
		public const int GL_MAP_COHERENT_BIT_EXT = 0x0080;
		public const int GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100;
		public const int GL_CLIENT_STORAGE_BIT_EXT = 0x0200;
		public const int GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000;
		public const int GL_BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F;
		public const int GL_BUFFER_STORAGE_FLAGS_EXT = 0x8220;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferStorageEXT(uint target, int size, IntPtr data, uint flags);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferStorageEXT(uint buffer, int size, IntPtr data, uint flags);

 		static __glBufferStorageEXT __GlueBufferStorageEXT;
		static __glNamedBufferStorageEXT __GlueNamedBufferStorageEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferStorageEXT(uint target, int size, IntPtr data, uint flags) => __GlueBufferStorageEXT(target, size, data, flags);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferStorageEXT(uint buffer, int size, IntPtr data, uint flags) => __GlueNamedBufferStorageEXT(buffer, size, data, flags);



	}
}


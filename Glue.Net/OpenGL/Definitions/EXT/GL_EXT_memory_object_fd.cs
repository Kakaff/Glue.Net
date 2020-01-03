using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_memory_object_fd {get; private set;}

		public const int GL_HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glImportMemoryFdEXT(uint memory, ulong size, uint handleType, int fd);

 		static __glImportMemoryFdEXT __GlueImportMemoryFdEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glImportMemoryFdEXT(uint memory, ulong size, uint handleType, int fd) => __GlueImportMemoryFdEXT(memory, size, handleType, fd);



	}
}


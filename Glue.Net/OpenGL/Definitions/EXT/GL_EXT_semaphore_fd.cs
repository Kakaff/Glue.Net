using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_semaphore_fd {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glImportSemaphoreFdEXT(uint semaphore, uint handleType, int fd);

 		static __glImportSemaphoreFdEXT __GlueImportSemaphoreFdEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glImportSemaphoreFdEXT(uint semaphore, uint handleType, int fd) => __GlueImportSemaphoreFdEXT(semaphore, handleType, fd);



	}
}


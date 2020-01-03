using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_semaphore_win32 {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glImportSemaphoreWin32HandleEXT(uint semaphore, uint handleType, IntPtr handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glImportSemaphoreWin32NameEXT(uint semaphore, uint handleType, IntPtr name);

 		static __glImportSemaphoreWin32HandleEXT __GlueImportSemaphoreWin32HandleEXT;
		static __glImportSemaphoreWin32NameEXT __GlueImportSemaphoreWin32NameEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glImportSemaphoreWin32HandleEXT(uint semaphore, uint handleType, IntPtr handle) => __GlueImportSemaphoreWin32HandleEXT(semaphore, handleType, handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glImportSemaphoreWin32NameEXT(uint semaphore, uint handleType, IntPtr name) => __GlueImportSemaphoreWin32NameEXT(semaphore, handleType, name);



	}
}


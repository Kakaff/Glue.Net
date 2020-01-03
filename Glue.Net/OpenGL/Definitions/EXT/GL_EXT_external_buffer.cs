using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_external_buffer {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferStorageExternalEXT(uint target, int offset, int size, IntPtr clientBuffer, uint flags);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferStorageExternalEXT(uint buffer, int offset, int size, IntPtr clientBuffer, uint flags);

 		static __glBufferStorageExternalEXT __GlueBufferStorageExternalEXT;
		static __glNamedBufferStorageExternalEXT __GlueNamedBufferStorageExternalEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferStorageExternalEXT(uint target, int offset, int size, IntPtr clientBuffer, uint flags) => __GlueBufferStorageExternalEXT(target, offset, size, clientBuffer, flags);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferStorageExternalEXT(uint buffer, int offset, int size, IntPtr clientBuffer, uint flags) => __GlueNamedBufferStorageExternalEXT(buffer, offset, size, clientBuffer, flags);



	}
}


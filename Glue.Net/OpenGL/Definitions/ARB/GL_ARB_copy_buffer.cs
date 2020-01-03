using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_copy_buffer {get; private set;}

		public const int GL_COPY_READ_BUFFER = 0x8F36;
		public const int GL_COPY_WRITE_BUFFER = 0x8F37;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyBufferSubData(uint readtarget, uint writetarget, int readoffset, int writeoffset, int size);

 		static __glCopyBufferSubData __GlueCopyBufferSubData;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyBufferSubData(uint readtarget, uint writetarget, int readoffset, int writeoffset, int size) => __GlueCopyBufferSubData(readtarget, writetarget, readoffset, writeoffset, size);



	}
}


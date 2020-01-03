using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_sparse_buffer {get; private set;}

		public const int GL_SPARSE_STORAGE_BIT_ARB = 0x0400;
		public const int GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferPageCommitmentARB(uint target, int offset, int size, bool commit);

 		static __glBufferPageCommitmentARB __GlueBufferPageCommitmentARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferPageCommitmentARB(uint target, int offset, int size, bool commit) => __GlueBufferPageCommitmentARB(target, offset, size, commit);



	}
}


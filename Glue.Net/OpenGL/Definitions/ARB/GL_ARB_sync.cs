using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_sync {get; private set;}

		public const int GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const int GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
		public const int GL_OBJECT_TYPE = 0x9112;
		public const int GL_SYNC_CONDITION = 0x9113;
		public const int GL_SYNC_STATUS = 0x9114;
		public const int GL_SYNC_FLAGS = 0x9115;
		public const int GL_SYNC_FENCE = 0x9116;
		public const int GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
		public const int GL_UNSIGNALED = 0x9118;
		public const int GL_SIGNALED = 0x9119;
		public const int GL_ALREADY_SIGNALED = 0x911A;
		public const int GL_TIMEOUT_EXPIRED = 0x911B;
		public const int GL_CONDITION_SATISFIED = 0x911C;
		public const int GL_WAIT_FAILED = 0x911D;
		public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glClientWaitSync(IntPtr GLsync, uint flags, ulong timeout);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteSync(IntPtr GLsync);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr __glFenceSync(uint condition, uint flags);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInteger64v(uint pname, long* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSynciv(IntPtr GLsync, uint pname, int bufSize, int* length, int* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsSync(IntPtr GLsync);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWaitSync(IntPtr GLsync, uint flags, ulong timeout);

 		static __glClientWaitSync __GlueClientWaitSync;
		static __glDeleteSync __GlueDeleteSync;
		static __glFenceSync __GlueFenceSync;
		static __glGetInteger64v __GlueGetInteger64v;
		static __glGetSynciv __GlueGetSynciv;
		static __glIsSync __GlueIsSync;
		static __glWaitSync __GlueWaitSync;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glClientWaitSync(IntPtr GLsync, uint flags, ulong timeout) => __GlueClientWaitSync(GLsync, flags, timeout);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteSync(IntPtr GLsync) => __GlueDeleteSync(GLsync);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr glFenceSync(uint condition, uint flags) => __GlueFenceSync(condition, flags);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInteger64v(uint pname, long* parameters) => __GlueGetInteger64v(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSynciv(IntPtr GLsync, uint pname, int bufSize, int* length, int* values) => __GlueGetSynciv(GLsync, pname, bufSize, length, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsSync(IntPtr GLsync) => __GlueIsSync(GLsync);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWaitSync(IntPtr GLsync, uint flags, ulong timeout) => __GlueWaitSync(GLsync, flags, timeout);



	}
}


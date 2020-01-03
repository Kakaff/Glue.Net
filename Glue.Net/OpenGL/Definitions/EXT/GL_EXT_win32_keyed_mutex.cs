using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_win32_keyed_mutex {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glAcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glReleaseKeyedMutexWin32EXT(uint memory, ulong key);

 		static __glAcquireKeyedMutexWin32EXT __GlueAcquireKeyedMutexWin32EXT;
		static __glReleaseKeyedMutexWin32EXT __GlueReleaseKeyedMutexWin32EXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glAcquireKeyedMutexWin32EXT(uint memory, ulong key, uint timeout) => __GlueAcquireKeyedMutexWin32EXT(memory, key, timeout);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glReleaseKeyedMutexWin32EXT(uint memory, ulong key) => __GlueReleaseKeyedMutexWin32EXT(memory, key);



	}
}


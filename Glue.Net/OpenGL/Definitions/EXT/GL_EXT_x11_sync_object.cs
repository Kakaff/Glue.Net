using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_x11_sync_object {get; private set;}

		public const int GL_SYNC_X11_FENCE_EXT = 0x90E1;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr __glImportSyncEXT(uint external_sync_type, int external_sync, uint flags);

 		static __glImportSyncEXT __GlueImportSyncEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr glImportSyncEXT(uint external_sync_type, int external_sync, uint flags) => __GlueImportSyncEXT(external_sync_type, external_sync, flags);



	}
}


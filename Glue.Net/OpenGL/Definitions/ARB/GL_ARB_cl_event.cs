using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_cl_event {get; private set;}

		public const int GL_SYNC_CL_EVENT_ARB = 0x8240;
		public const int GL_SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr __glCreateSyncFromCLeventARB(IntPtr context, IntPtr event_, uint flags);

 		static __glCreateSyncFromCLeventARB __GlueCreateSyncFromCLeventARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr glCreateSyncFromCLeventARB(IntPtr context, IntPtr event_, uint flags) => __GlueCreateSyncFromCLeventARB(context, event_, flags);



	}
}


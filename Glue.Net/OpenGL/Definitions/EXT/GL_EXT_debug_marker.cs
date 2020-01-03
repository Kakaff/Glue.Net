using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_debug_marker {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInsertEventMarkerEXT(int length, char* marker);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPopGroupMarkerEXT( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPushGroupMarkerEXT(int length, char* marker);

 		static __glInsertEventMarkerEXT __GlueInsertEventMarkerEXT;
		static __glPopGroupMarkerEXT __GluePopGroupMarkerEXT;
		static __glPushGroupMarkerEXT __GluePushGroupMarkerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInsertEventMarkerEXT(int length, char* marker) => __GlueInsertEventMarkerEXT(length, marker);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPopGroupMarkerEXT( ) => __GluePopGroupMarkerEXT();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPushGroupMarkerEXT(int length, char* marker) => __GluePushGroupMarkerEXT(length, marker);



	}
}


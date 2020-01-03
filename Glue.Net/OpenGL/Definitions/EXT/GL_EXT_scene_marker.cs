using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_scene_marker {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginSceneEXT( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndSceneEXT( );

 		static __glBeginSceneEXT __GlueBeginSceneEXT;
		static __glEndSceneEXT __GlueEndSceneEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginSceneEXT( ) => __GlueBeginSceneEXT();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndSceneEXT( ) => __GlueEndSceneEXT();



	}
}


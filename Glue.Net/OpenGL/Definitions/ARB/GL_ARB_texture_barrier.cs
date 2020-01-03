using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_barrier {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureBarrier( );

 		static __glTextureBarrier __GlueTextureBarrier;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureBarrier( ) => __GlueTextureBarrier();



	}
}


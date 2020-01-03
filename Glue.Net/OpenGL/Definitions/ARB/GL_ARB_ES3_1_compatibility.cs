using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_ES3_1_compatibility {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMemoryBarrierByRegion(uint barriers);

 		static __glMemoryBarrierByRegion __GlueMemoryBarrierByRegion;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMemoryBarrierByRegion(uint barriers) => __GlueMemoryBarrierByRegion(barriers);



	}
}


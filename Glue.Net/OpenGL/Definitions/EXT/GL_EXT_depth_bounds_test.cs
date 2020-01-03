using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_depth_bounds_test {get; private set;}

		public const int GL_DEPTH_BOUNDS_TEST_EXT = 0x8890;
		public const int GL_DEPTH_BOUNDS_EXT = 0x8891;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthBoundsEXT(double zmin, double zmax);

 		static __glDepthBoundsEXT __GlueDepthBoundsEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthBoundsEXT(double zmin, double zmax) => __GlueDepthBoundsEXT(zmin, zmax);



	}
}


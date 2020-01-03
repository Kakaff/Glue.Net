using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_stencil_two_side {get; private set;}

		public const int GL_STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
		public const int GL_ACTIVE_STENCIL_FACE_EXT = 0x8911;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glActiveStencilFaceEXT(uint face);

 		static __glActiveStencilFaceEXT __GlueActiveStencilFaceEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glActiveStencilFaceEXT(uint face) => __GlueActiveStencilFaceEXT(face);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_conditional_render_inverted {get; private set;}

		public const int GL_QUERY_WAIT_INVERTED = 0x8E17;
		public const int GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
		public const int GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
		public const int GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

   

	}
}


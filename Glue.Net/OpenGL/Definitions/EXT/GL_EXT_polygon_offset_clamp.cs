using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_polygon_offset_clamp {get; private set;}

		public const int GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPolygonOffsetClampEXT(float factor, float units, float clamp);

 		static __glPolygonOffsetClampEXT __GluePolygonOffsetClampEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPolygonOffsetClampEXT(float factor, float units, float clamp) => __GluePolygonOffsetClampEXT(factor, units, clamp);



	}
}


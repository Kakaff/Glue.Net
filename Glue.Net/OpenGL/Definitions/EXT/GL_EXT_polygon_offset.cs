using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_polygon_offset {get; private set;}

		public const int GL_POLYGON_OFFSET_EXT = 0x8037;
		public const int GL_POLYGON_OFFSET_FACTOR_EXT = 0x8038;
		public const int GL_POLYGON_OFFSET_BIAS_EXT = 0x8039;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPolygonOffsetEXT(float factor, float bias);

 		static __glPolygonOffsetEXT __GluePolygonOffsetEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPolygonOffsetEXT(float factor, float bias) => __GluePolygonOffsetEXT(factor, bias);



	}
}


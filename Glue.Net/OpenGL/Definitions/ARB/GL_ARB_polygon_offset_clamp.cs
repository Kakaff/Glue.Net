using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_polygon_offset_clamp {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPolygonOffsetClamp(float factor, float units, float clamp);

 		static __glPolygonOffsetClamp __GluePolygonOffsetClamp;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPolygonOffsetClamp(float factor, float units, float clamp) => __GluePolygonOffsetClamp(factor, units, clamp);



	}
}


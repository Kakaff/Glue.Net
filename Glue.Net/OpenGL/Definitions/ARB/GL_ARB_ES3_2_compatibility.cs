using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_ES3_2_compatibility {get; private set;}

		public const int GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
		public const int GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
		public const int GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);

 		static __glPrimitiveBoundingBoxARB __GluePrimitiveBoundingBoxARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) => __GluePrimitiveBoundingBoxARB(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_fog_coord {get; private set;}

		public const int GL_FOG_COORDINATE_SOURCE_EXT = 0x8450;
		public const int GL_FOG_COORDINATE_EXT = 0x8451;
		public const int GL_FRAGMENT_DEPTH_EXT = 0x8452;
		public const int GL_CURRENT_FOG_COORDINATE_EXT = 0x8453;
		public const int GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
		public const int GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
		public const int GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
		public const int GL_FOG_COORDINATE_ARRAY_EXT = 0x8457;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordPointerEXT(uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoorddEXT(double coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoorddvEXT(double* coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordfEXT(float coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordfvEXT(float* coord);

 		static __glFogCoordPointerEXT __GlueFogCoordPointerEXT;
		static __glFogCoorddEXT __GlueFogCoorddEXT;
		static __glFogCoorddvEXT __GlueFogCoorddvEXT;
		static __glFogCoordfEXT __GlueFogCoordfEXT;
		static __glFogCoordfvEXT __GlueFogCoordfvEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordPointerEXT(uint type, int stride, IntPtr pointer) => __GlueFogCoordPointerEXT(type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoorddEXT(double coord) => __GlueFogCoorddEXT(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoorddvEXT(double* coord) => __GlueFogCoorddvEXT(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordfEXT(float coord) => __GlueFogCoordfEXT(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordfvEXT(float* coord) => __GlueFogCoordfvEXT(coord);



	}
}


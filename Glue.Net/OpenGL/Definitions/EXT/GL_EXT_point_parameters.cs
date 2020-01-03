using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_point_parameters {get; private set;}

		public const int GL_POINT_SIZE_MIN_EXT = 0x8126;
		public const int GL_POINT_SIZE_MAX_EXT = 0x8127;
		public const int GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128;
		public const int GL_DISTANCE_ATTENUATION_EXT = 0x8129;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameterfEXT(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameterfvEXT(uint pname, float* parameters);

 		static __glPointParameterfEXT __GluePointParameterfEXT;
		static __glPointParameterfvEXT __GluePointParameterfvEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameterfEXT(uint pname, float param) => __GluePointParameterfEXT(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameterfvEXT(uint pname, float* parameters) => __GluePointParameterfvEXT(pname, parameters);



	}
}


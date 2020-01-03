using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_point_parameters {get; private set;}

		public const int GL_POINT_SIZE_MIN_ARB = 0x8126;
		public const int GL_POINT_SIZE_MAX_ARB = 0x8127;
		public const int GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
		public const int GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameterfARB(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameterfvARB(uint pname, float* parameters);

 		static __glPointParameterfARB __GluePointParameterfARB;
		static __glPointParameterfvARB __GluePointParameterfvARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameterfARB(uint pname, float param) => __GluePointParameterfARB(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameterfvARB(uint pname, float* parameters) => __GluePointParameterfvARB(pname, parameters);



	}
}


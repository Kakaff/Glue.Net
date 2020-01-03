using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_sample_shading {get; private set;}

		public const int GL_SAMPLE_SHADING_ARB = 0x8C36;
		public const int GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMinSampleShadingARB(float value);

 		static __glMinSampleShadingARB __GlueMinSampleShadingARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMinSampleShadingARB(float value) => __GlueMinSampleShadingARB(value);



	}
}


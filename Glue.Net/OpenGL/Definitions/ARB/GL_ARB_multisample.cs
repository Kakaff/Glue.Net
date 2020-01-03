using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_multisample {get; private set;}

		public const int GL_MULTISAMPLE_ARB = 0x809D;
		public const int GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
		public const int GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
		public const int GL_SAMPLE_COVERAGE_ARB = 0x80A0;
		public const int GL_SAMPLE_BUFFERS_ARB = 0x80A8;
		public const int GL_SAMPLES_ARB = 0x80A9;
		public const int GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
		public const int GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
		public const int GL_MULTISAMPLE_BIT_ARB = 0x20000000;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSampleCoverageARB(float value, bool invert);

 		static __glSampleCoverageARB __GlueSampleCoverageARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSampleCoverageARB(float value, bool invert) => __GlueSampleCoverageARB(value, invert);



	}
}


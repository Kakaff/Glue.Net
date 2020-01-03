using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_multisample {get; private set;}

		public const int GL_MULTISAMPLE_EXT = 0x809D;
		public const int GL_SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;
		public const int GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
		public const int GL_SAMPLE_MASK_EXT = 0x80A0;
		public const int GL_1PASS_EXT = 0x80A1;
		public const int GL_2PASS_0_EXT = 0x80A2;
		public const int GL_2PASS_1_EXT = 0x80A3;
		public const int GL_4PASS_0_EXT = 0x80A4;
		public const int GL_4PASS_1_EXT = 0x80A5;
		public const int GL_4PASS_2_EXT = 0x80A6;
		public const int GL_4PASS_3_EXT = 0x80A7;
		public const int GL_SAMPLE_BUFFERS_EXT = 0x80A8;
		public const int GL_SAMPLES_EXT = 0x80A9;
		public const int GL_SAMPLE_MASK_VALUE_EXT = 0x80AA;
		public const int GL_SAMPLE_MASK_INVERT_EXT = 0x80AB;
		public const int GL_SAMPLE_PATTERN_EXT = 0x80AC;
		public const int GL_MULTISAMPLE_BIT_EXT = 0x20000000;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSampleMaskEXT(float value, bool invert);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplePatternEXT(uint pattern);

 		static __glSampleMaskEXT __GlueSampleMaskEXT;
		static __glSamplePatternEXT __GlueSamplePatternEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSampleMaskEXT(float value, bool invert) => __GlueSampleMaskEXT(value, invert);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplePatternEXT(uint pattern) => __GlueSamplePatternEXT(pattern);



	}
}


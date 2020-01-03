using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_multisample {get; private set;}

		public const int GL_SAMPLE_POSITION = 0x8E50;
		public const int GL_SAMPLE_MASK = 0x8E51;
		public const int GL_SAMPLE_MASK_VALUE = 0x8E52;
		public const int GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
		public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
		public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
		public const int GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
		public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
		public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
		public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
		public const int GL_TEXTURE_SAMPLES = 0x9106;
		public const int GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
		public const int GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
		public const int GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
		public const int GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
		public const int GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
		public const int GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
		public const int GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
		public const int GL_MAX_INTEGER_SAMPLES = 0x9110;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultisamplefv(uint pname, uint index, float* val);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSampleMaski(uint index, uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

 		static __glGetMultisamplefv __GlueGetMultisamplefv;
		static __glSampleMaski __GlueSampleMaski;
		static __glTexImage2DMultisample __GlueTexImage2DMultisample;
		static __glTexImage3DMultisample __GlueTexImage3DMultisample;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultisamplefv(uint pname, uint index, float* val) => __GlueGetMultisamplefv(pname, index, val);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSampleMaski(uint index, uint mask) => __GlueSampleMaski(index, mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => __GlueTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => __GlueTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_sample_locations {get; private set;}

		public const int GL_SAMPLE_LOCATION_ARB = 0x8E50;
		public const int GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;
		public const int GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;
		public const int GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;
		public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;
		public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;
		public const int GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;
		public const int GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v);

 		static __glFramebufferSampleLocationsfvARB __GlueFramebufferSampleLocationsfvARB;
		static __glNamedFramebufferSampleLocationsfvARB __GlueNamedFramebufferSampleLocationsfvARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v) => __GlueFramebufferSampleLocationsfvARB(target, start, count, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v) => __GlueNamedFramebufferSampleLocationsfvARB(framebuffer, start, count, v);



	}
}


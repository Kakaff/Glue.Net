using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_raster_multisample {get; private set;}

		public const int GL_COLOR_SAMPLES_NV = 0x8E20;
		public const int GL_RASTER_MULTISAMPLE_EXT = 0x9327;
		public const int GL_RASTER_SAMPLES_EXT = 0x9328;
		public const int GL_MAX_RASTER_SAMPLES_EXT = 0x9329;
		public const int GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
		public const int GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
		public const int GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
		public const int GL_DEPTH_SAMPLES_NV = 0x932D;
		public const int GL_STENCIL_SAMPLES_NV = 0x932E;
		public const int GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;
		public const int GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;
		public const int GL_COVERAGE_MODULATION_TABLE_NV = 0x9331;
		public const int GL_COVERAGE_MODULATION_NV = 0x9332;
		public const int GL_COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCoverageModulationNV(uint components);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCoverageModulationTableNV(int n, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCoverageModulationTableNV(int bufsize, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterSamplesEXT(uint samples, bool fixedsamplelocations);

 		static __glCoverageModulationNV __GlueCoverageModulationNV;
		static __glCoverageModulationTableNV __GlueCoverageModulationTableNV;
		static __glGetCoverageModulationTableNV __GlueGetCoverageModulationTableNV;
		static __glRasterSamplesEXT __GlueRasterSamplesEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCoverageModulationNV(uint components) => __GlueCoverageModulationNV(components);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCoverageModulationTableNV(int n, float* v) => __GlueCoverageModulationTableNV(n, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCoverageModulationTableNV(int bufsize, float* v) => __GlueGetCoverageModulationTableNV(bufsize, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterSamplesEXT(uint samples, bool fixedsamplelocations) => __GlueRasterSamplesEXT(samples, fixedsamplelocations);



	}
}


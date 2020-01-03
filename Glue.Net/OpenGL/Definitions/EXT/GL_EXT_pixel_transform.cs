using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_pixel_transform {get; private set;}

		public const int GL_PIXEL_TRANSFORM_2D_EXT = 0x8330;
		public const int GL_PIXEL_MAG_FILTER_EXT = 0x8331;
		public const int GL_PIXEL_MIN_FILTER_EXT = 0x8332;
		public const int GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333;
		public const int GL_CUBIC_EXT = 0x8334;
		public const int GL_AVERAGE_EXT = 0x8335;
		public const int GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
		public const int GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
		public const int GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPixelTransformParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPixelTransformParameterivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelTransformParameterfEXT(uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelTransformParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelTransformParameteriEXT(uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelTransformParameterivEXT(uint target, uint pname, int* parameters);

 		static __glGetPixelTransformParameterfvEXT __GlueGetPixelTransformParameterfvEXT;
		static __glGetPixelTransformParameterivEXT __GlueGetPixelTransformParameterivEXT;
		static __glPixelTransformParameterfEXT __GluePixelTransformParameterfEXT;
		static __glPixelTransformParameterfvEXT __GluePixelTransformParameterfvEXT;
		static __glPixelTransformParameteriEXT __GluePixelTransformParameteriEXT;
		static __glPixelTransformParameterivEXT __GluePixelTransformParameterivEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPixelTransformParameterfvEXT(uint target, uint pname, float* parameters) => __GlueGetPixelTransformParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPixelTransformParameterivEXT(uint target, uint pname, int* parameters) => __GlueGetPixelTransformParameterivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelTransformParameterfEXT(uint target, uint pname, float param) => __GluePixelTransformParameterfEXT(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelTransformParameterfvEXT(uint target, uint pname, float* parameters) => __GluePixelTransformParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelTransformParameteriEXT(uint target, uint pname, int param) => __GluePixelTransformParameteriEXT(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelTransformParameterivEXT(uint target, uint pname, int* parameters) => __GluePixelTransformParameterivEXT(target, pname, parameters);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_convolution {get; private set;}

		public const int GL_CONVOLUTION_1D_EXT = 0x8010;
		public const int GL_CONVOLUTION_2D_EXT = 0x8011;
		public const int GL_SEPARABLE_2D_EXT = 0x8012;
		public const int GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013;
		public const int GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014;
		public const int GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015;
		public const int GL_REDUCE_EXT = 0x8016;
		public const int GL_CONVOLUTION_FORMAT_EXT = 0x8017;
		public const int GL_CONVOLUTION_WIDTH_EXT = 0x8018;
		public const int GL_CONVOLUTION_HEIGHT_EXT = 0x8019;
		public const int GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A;
		public const int GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B;
		public const int GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;
		public const int GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;
		public const int GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;
		public const int GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;
		public const int GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020;
		public const int GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;
		public const int GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;
		public const int GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionFilter1DEXT(uint target, uint internalformat, int width, uint format, uint type, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionFilter2DEXT(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameterfEXT(uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameteriEXT(uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameterivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyConvolutionFilter1DEXT(uint target, uint internalformat, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyConvolutionFilter2DEXT(uint target, uint internalformat, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetConvolutionFilterEXT(uint target, uint format, uint type, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetConvolutionParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetConvolutionParameterivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSeparableFilterEXT(uint target, uint format, uint type, IntPtr row, IntPtr column, IntPtr span);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSeparableFilter2DEXT(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr row, IntPtr column);

 		static __glConvolutionFilter1DEXT __GlueConvolutionFilter1DEXT;
		static __glConvolutionFilter2DEXT __GlueConvolutionFilter2DEXT;
		static __glConvolutionParameterfEXT __GlueConvolutionParameterfEXT;
		static __glConvolutionParameterfvEXT __GlueConvolutionParameterfvEXT;
		static __glConvolutionParameteriEXT __GlueConvolutionParameteriEXT;
		static __glConvolutionParameterivEXT __GlueConvolutionParameterivEXT;
		static __glCopyConvolutionFilter1DEXT __GlueCopyConvolutionFilter1DEXT;
		static __glCopyConvolutionFilter2DEXT __GlueCopyConvolutionFilter2DEXT;
		static __glGetConvolutionFilterEXT __GlueGetConvolutionFilterEXT;
		static __glGetConvolutionParameterfvEXT __GlueGetConvolutionParameterfvEXT;
		static __glGetConvolutionParameterivEXT __GlueGetConvolutionParameterivEXT;
		static __glGetSeparableFilterEXT __GlueGetSeparableFilterEXT;
		static __glSeparableFilter2DEXT __GlueSeparableFilter2DEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionFilter1DEXT(uint target, uint internalformat, int width, uint format, uint type, IntPtr image) => __GlueConvolutionFilter1DEXT(target, internalformat, width, format, type, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionFilter2DEXT(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr image) => __GlueConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameterfEXT(uint target, uint pname, float param) => __GlueConvolutionParameterfEXT(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameterfvEXT(uint target, uint pname, float* parameters) => __GlueConvolutionParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameteriEXT(uint target, uint pname, int param) => __GlueConvolutionParameteriEXT(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameterivEXT(uint target, uint pname, int* parameters) => __GlueConvolutionParameterivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyConvolutionFilter1DEXT(uint target, uint internalformat, int x, int y, int width) => __GlueCopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyConvolutionFilter2DEXT(uint target, uint internalformat, int x, int y, int width, int height) => __GlueCopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetConvolutionFilterEXT(uint target, uint format, uint type, IntPtr image) => __GlueGetConvolutionFilterEXT(target, format, type, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetConvolutionParameterfvEXT(uint target, uint pname, float* parameters) => __GlueGetConvolutionParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetConvolutionParameterivEXT(uint target, uint pname, int* parameters) => __GlueGetConvolutionParameterivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSeparableFilterEXT(uint target, uint format, uint type, IntPtr row, IntPtr column, IntPtr span) => __GlueGetSeparableFilterEXT(target, format, type, row, column, span);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSeparableFilter2DEXT(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr row, IntPtr column) => __GlueSeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column);



	}
}


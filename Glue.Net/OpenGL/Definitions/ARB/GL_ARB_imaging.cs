using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_imaging {get; private set;}

		public const int GL_CONSTANT_COLOR = 0x8001;
		public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const int GL_CONSTANT_ALPHA = 0x8003;
		public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const int GL_BLEND_COLOR = 0x8005;
		public const int GL_FUNC_ADD = 0x8006;
		public const int GL_MIN = 0x8007;
		public const int GL_MAX = 0x8008;
		public const int GL_BLEND_EQUATION = 0x8009;
		public const int GL_FUNC_SUBTRACT = 0x800A;
		public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const int GL_CONVOLUTION_1D = 0x8010;
		public const int GL_CONVOLUTION_2D = 0x8011;
		public const int GL_SEPARABLE_2D = 0x8012;
		public const int GL_CONVOLUTION_BORDER_MODE = 0x8013;
		public const int GL_CONVOLUTION_FILTER_SCALE = 0x8014;
		public const int GL_CONVOLUTION_FILTER_BIAS = 0x8015;
		public const int GL_REDUCE = 0x8016;
		public const int GL_CONVOLUTION_FORMAT = 0x8017;
		public const int GL_CONVOLUTION_WIDTH = 0x8018;
		public const int GL_CONVOLUTION_HEIGHT = 0x8019;
		public const int GL_MAX_CONVOLUTION_WIDTH = 0x801A;
		public const int GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
		public const int GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
		public const int GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
		public const int GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
		public const int GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
		public const int GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
		public const int GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
		public const int GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
		public const int GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
		public const int GL_HISTOGRAM = 0x8024;
		public const int GL_PROXY_HISTOGRAM = 0x8025;
		public const int GL_HISTOGRAM_WIDTH = 0x8026;
		public const int GL_HISTOGRAM_FORMAT = 0x8027;
		public const int GL_HISTOGRAM_RED_SIZE = 0x8028;
		public const int GL_HISTOGRAM_GREEN_SIZE = 0x8029;
		public const int GL_HISTOGRAM_BLUE_SIZE = 0x802A;
		public const int GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
		public const int GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
		public const int GL_HISTOGRAM_SINK = 0x802D;
		public const int GL_MINMAX = 0x802E;
		public const int GL_MINMAX_FORMAT = 0x802F;
		public const int GL_MINMAX_SINK = 0x8030;
		public const int GL_TABLE_TOO_LARGE = 0x8031;
		public const int GL_COLOR_MATRIX = 0x80B1;
		public const int GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
		public const int GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
		public const int GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
		public const int GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
		public const int GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
		public const int GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
		public const int GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
		public const int GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
		public const int GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
		public const int GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
		public const int GL_COLOR_TABLE = 0x80D0;
		public const int GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
		public const int GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
		public const int GL_PROXY_COLOR_TABLE = 0x80D3;
		public const int GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
		public const int GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
		public const int GL_COLOR_TABLE_SCALE = 0x80D6;
		public const int GL_COLOR_TABLE_BIAS = 0x80D7;
		public const int GL_COLOR_TABLE_FORMAT = 0x80D8;
		public const int GL_COLOR_TABLE_WIDTH = 0x80D9;
		public const int GL_COLOR_TABLE_RED_SIZE = 0x80DA;
		public const int GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
		public const int GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
		public const int GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
		public const int GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
		public const int GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
		public const int GL_IGNORE_BORDER = 0x8150;
		public const int GL_CONSTANT_BORDER = 0x8151;
		public const int GL_WRAP_BORDER = 0x8152;
		public const int GL_REPLICATE_BORDER = 0x8153;
		public const int GL_CONVOLUTION_BORDER_COLOR = 0x8154;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorSubTable(uint target, int start, int count, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorTable(uint target, uint internalformat, int width, uint format, uint type, IntPtr table);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorTableParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorTableParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameterf(uint target, uint pname, float parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameteri(uint target, uint pname, int parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glConvolutionParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyColorSubTable(uint target, int start, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyColorTable(uint target, uint internalformat, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetColorTable(uint target, uint format, uint type, IntPtr table);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetColorTableParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetColorTableParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetConvolutionFilter(uint target, uint format, uint type, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetConvolutionParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetConvolutionParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetHistogram(uint target, bool reset, uint format, uint type, IntPtr values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetHistogramParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetHistogramParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMinmax(uint target, bool reset, uint format, uint types, IntPtr values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMinmaxParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMinmaxParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSeparableFilter(uint target, uint format, uint type, IntPtr row, IntPtr column, IntPtr span);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glHistogram(uint target, int width, uint internalformat, bool sink);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMinmax(uint target, uint internalformat, bool sink);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glResetHistogram(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glResetMinmax(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr row, IntPtr column);

 		static __glColorSubTable __GlueColorSubTable;
		static __glColorTable __GlueColorTable;
		static __glColorTableParameterfv __GlueColorTableParameterfv;
		static __glColorTableParameteriv __GlueColorTableParameteriv;
		static __glConvolutionFilter1D __GlueConvolutionFilter1D;
		static __glConvolutionFilter2D __GlueConvolutionFilter2D;
		static __glConvolutionParameterf __GlueConvolutionParameterf;
		static __glConvolutionParameterfv __GlueConvolutionParameterfv;
		static __glConvolutionParameteri __GlueConvolutionParameteri;
		static __glConvolutionParameteriv __GlueConvolutionParameteriv;
		static __glCopyColorSubTable __GlueCopyColorSubTable;
		static __glCopyColorTable __GlueCopyColorTable;
		static __glCopyConvolutionFilter1D __GlueCopyConvolutionFilter1D;
		static __glCopyConvolutionFilter2D __GlueCopyConvolutionFilter2D;
		static __glGetColorTable __GlueGetColorTable;
		static __glGetColorTableParameterfv __GlueGetColorTableParameterfv;
		static __glGetColorTableParameteriv __GlueGetColorTableParameteriv;
		static __glGetConvolutionFilter __GlueGetConvolutionFilter;
		static __glGetConvolutionParameterfv __GlueGetConvolutionParameterfv;
		static __glGetConvolutionParameteriv __GlueGetConvolutionParameteriv;
		static __glGetHistogram __GlueGetHistogram;
		static __glGetHistogramParameterfv __GlueGetHistogramParameterfv;
		static __glGetHistogramParameteriv __GlueGetHistogramParameteriv;
		static __glGetMinmax __GlueGetMinmax;
		static __glGetMinmaxParameterfv __GlueGetMinmaxParameterfv;
		static __glGetMinmaxParameteriv __GlueGetMinmaxParameteriv;
		static __glGetSeparableFilter __GlueGetSeparableFilter;
		static __glHistogram __GlueHistogram;
		static __glMinmax __GlueMinmax;
		static __glResetHistogram __GlueResetHistogram;
		static __glResetMinmax __GlueResetMinmax;
		static __glSeparableFilter2D __GlueSeparableFilter2D;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorSubTable(uint target, int start, int count, uint format, uint type, IntPtr data) => __GlueColorSubTable(target, start, count, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorTable(uint target, uint internalformat, int width, uint format, uint type, IntPtr table) => __GlueColorTable(target, internalformat, width, format, type, table);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorTableParameterfv(uint target, uint pname, float* parameters) => __GlueColorTableParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorTableParameteriv(uint target, uint pname, int* parameters) => __GlueColorTableParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, IntPtr image) => __GlueConvolutionFilter1D(target, internalformat, width, format, type, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr image) => __GlueConvolutionFilter2D(target, internalformat, width, height, format, type, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameterf(uint target, uint pname, float parameters) => __GlueConvolutionParameterf(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameterfv(uint target, uint pname, float* parameters) => __GlueConvolutionParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameteri(uint target, uint pname, int parameters) => __GlueConvolutionParameteri(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glConvolutionParameteriv(uint target, uint pname, int* parameters) => __GlueConvolutionParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyColorSubTable(uint target, int start, int x, int y, int width) => __GlueCopyColorSubTable(target, start, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyColorTable(uint target, uint internalformat, int x, int y, int width) => __GlueCopyColorTable(target, internalformat, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width) => __GlueCopyConvolutionFilter1D(target, internalformat, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height) => __GlueCopyConvolutionFilter2D(target, internalformat, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetColorTable(uint target, uint format, uint type, IntPtr table) => __GlueGetColorTable(target, format, type, table);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetColorTableParameterfv(uint target, uint pname, float* parameters) => __GlueGetColorTableParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetColorTableParameteriv(uint target, uint pname, int* parameters) => __GlueGetColorTableParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetConvolutionFilter(uint target, uint format, uint type, IntPtr image) => __GlueGetConvolutionFilter(target, format, type, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetConvolutionParameterfv(uint target, uint pname, float* parameters) => __GlueGetConvolutionParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetConvolutionParameteriv(uint target, uint pname, int* parameters) => __GlueGetConvolutionParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetHistogram(uint target, bool reset, uint format, uint type, IntPtr values) => __GlueGetHistogram(target, reset, format, type, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetHistogramParameterfv(uint target, uint pname, float* parameters) => __GlueGetHistogramParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetHistogramParameteriv(uint target, uint pname, int* parameters) => __GlueGetHistogramParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMinmax(uint target, bool reset, uint format, uint types, IntPtr values) => __GlueGetMinmax(target, reset, format, types, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMinmaxParameterfv(uint target, uint pname, float* parameters) => __GlueGetMinmaxParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMinmaxParameteriv(uint target, uint pname, int* parameters) => __GlueGetMinmaxParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSeparableFilter(uint target, uint format, uint type, IntPtr row, IntPtr column, IntPtr span) => __GlueGetSeparableFilter(target, format, type, row, column, span);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glHistogram(uint target, int width, uint internalformat, bool sink) => __GlueHistogram(target, width, internalformat, sink);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMinmax(uint target, uint internalformat, bool sink) => __GlueMinmax(target, internalformat, sink);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glResetHistogram(uint target) => __GlueResetHistogram(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glResetMinmax(uint target) => __GlueResetMinmax(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr row, IntPtr column) => __GlueSeparableFilter2D(target, internalformat, width, height, format, type, row, column);



	}
}


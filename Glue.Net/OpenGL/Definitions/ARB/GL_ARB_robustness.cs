using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_robustness {get; private set;}

		public const int GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;
		public const int GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
		public const int GL_GUILTY_CONTEXT_RESET_ARB = 0x8253;
		public const int GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254;
		public const int GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
		public const int GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
		public const int GL_NO_RESET_NOTIFICATION_ARB = 0x8261;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetGraphicsResetStatusARB( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnColorTableARB(uint target, uint format, uint type, int bufSize, IntPtr table);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnCompressedTexImageARB(uint target, int lod, int bufSize, IntPtr img);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnConvolutionFilterARB(uint target, uint format, uint type, int bufSize, IntPtr image);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnHistogramARB(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnMapdvARB(uint target, uint query, int bufSize, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnMapfvARB(uint target, uint query, int bufSize, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnMapivARB(uint target, uint query, int bufSize, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnMinmaxARB(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnPixelMapfvARB(uint map, int bufSize, float* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnPixelMapuivARB(uint map, int bufSize, uint* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnPixelMapusvARB(uint map, int bufSize, ushort* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnPolygonStippleARB(int bufSize, byte* pattern);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnSeparableFilterARB(uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnTexImageARB(uint target, int level, uint format, uint type, int bufSize, IntPtr img);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformdvARB(uint program, int location, int bufSize, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformfvARB(uint program, int location, int bufSize, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformivARB(uint program, int location, int bufSize, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformuivARB(uint program, int location, int bufSize, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glReadnPixelsARB(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);

 		static __glGetGraphicsResetStatusARB __GlueGetGraphicsResetStatusARB;
		static __glGetnColorTableARB __GlueGetnColorTableARB;
		static __glGetnCompressedTexImageARB __GlueGetnCompressedTexImageARB;
		static __glGetnConvolutionFilterARB __GlueGetnConvolutionFilterARB;
		static __glGetnHistogramARB __GlueGetnHistogramARB;
		static __glGetnMapdvARB __GlueGetnMapdvARB;
		static __glGetnMapfvARB __GlueGetnMapfvARB;
		static __glGetnMapivARB __GlueGetnMapivARB;
		static __glGetnMinmaxARB __GlueGetnMinmaxARB;
		static __glGetnPixelMapfvARB __GlueGetnPixelMapfvARB;
		static __glGetnPixelMapuivARB __GlueGetnPixelMapuivARB;
		static __glGetnPixelMapusvARB __GlueGetnPixelMapusvARB;
		static __glGetnPolygonStippleARB __GlueGetnPolygonStippleARB;
		static __glGetnSeparableFilterARB __GlueGetnSeparableFilterARB;
		static __glGetnTexImageARB __GlueGetnTexImageARB;
		static __glGetnUniformdvARB __GlueGetnUniformdvARB;
		static __glGetnUniformfvARB __GlueGetnUniformfvARB;
		static __glGetnUniformivARB __GlueGetnUniformivARB;
		static __glGetnUniformuivARB __GlueGetnUniformuivARB;
		static __glReadnPixelsARB __GlueReadnPixelsARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetGraphicsResetStatusARB( ) => __GlueGetGraphicsResetStatusARB();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnColorTableARB(uint target, uint format, uint type, int bufSize, IntPtr table) => __GlueGetnColorTableARB(target, format, type, bufSize, table);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnCompressedTexImageARB(uint target, int lod, int bufSize, IntPtr img) => __GlueGetnCompressedTexImageARB(target, lod, bufSize, img);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnConvolutionFilterARB(uint target, uint format, uint type, int bufSize, IntPtr image) => __GlueGetnConvolutionFilterARB(target, format, type, bufSize, image);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnHistogramARB(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values) => __GlueGetnHistogramARB(target, reset, format, type, bufSize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnMapdvARB(uint target, uint query, int bufSize, double* v) => __GlueGetnMapdvARB(target, query, bufSize, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnMapfvARB(uint target, uint query, int bufSize, float* v) => __GlueGetnMapfvARB(target, query, bufSize, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnMapivARB(uint target, uint query, int bufSize, int* v) => __GlueGetnMapivARB(target, query, bufSize, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnMinmaxARB(uint target, bool reset, uint format, uint type, int bufSize, IntPtr values) => __GlueGetnMinmaxARB(target, reset, format, type, bufSize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnPixelMapfvARB(uint map, int bufSize, float* values) => __GlueGetnPixelMapfvARB(map, bufSize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnPixelMapuivARB(uint map, int bufSize, uint* values) => __GlueGetnPixelMapuivARB(map, bufSize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnPixelMapusvARB(uint map, int bufSize, ushort* values) => __GlueGetnPixelMapusvARB(map, bufSize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnPolygonStippleARB(int bufSize, byte* pattern) => __GlueGetnPolygonStippleARB(bufSize, pattern);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnSeparableFilterARB(uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span) => __GlueGetnSeparableFilterARB(target, format, type, rowBufSize, row, columnBufSize, column, span);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnTexImageARB(uint target, int level, uint format, uint type, int bufSize, IntPtr img) => __GlueGetnTexImageARB(target, level, format, type, bufSize, img);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformdvARB(uint program, int location, int bufSize, double* parameters) => __GlueGetnUniformdvARB(program, location, bufSize, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformfvARB(uint program, int location, int bufSize, float* parameters) => __GlueGetnUniformfvARB(program, location, bufSize, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformivARB(uint program, int location, int bufSize, int* parameters) => __GlueGetnUniformivARB(program, location, bufSize, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformuivARB(uint program, int location, int bufSize, uint* parameters) => __GlueGetnUniformuivARB(program, location, bufSize, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glReadnPixelsARB(int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data) => __GlueReadnPixelsARB(x, y, width, height, format, type, bufSize, data);



	}
}


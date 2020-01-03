using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_histogram {get; private set;}

		public const int GL_HISTOGRAM_EXT = 0x8024;
		public const int GL_PROXY_HISTOGRAM_EXT = 0x8025;
		public const int GL_HISTOGRAM_WIDTH_EXT = 0x8026;
		public const int GL_HISTOGRAM_FORMAT_EXT = 0x8027;
		public const int GL_HISTOGRAM_RED_SIZE_EXT = 0x8028;
		public const int GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029;
		public const int GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A;
		public const int GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B;
		public const int GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C;
		public const int GL_HISTOGRAM_SINK_EXT = 0x802D;
		public const int GL_MINMAX_EXT = 0x802E;
		public const int GL_MINMAX_FORMAT_EXT = 0x802F;
		public const int GL_MINMAX_SINK_EXT = 0x8030;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetHistogramEXT(uint target, bool reset, uint format, uint type, IntPtr values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetHistogramParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetHistogramParameterivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMinmaxEXT(uint target, bool reset, uint format, uint type, IntPtr values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMinmaxParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMinmaxParameterivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glHistogramEXT(uint target, int width, uint internalformat, bool sink);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMinmaxEXT(uint target, uint internalformat, bool sink);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glResetHistogramEXT(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glResetMinmaxEXT(uint target);

 		static __glGetHistogramEXT __GlueGetHistogramEXT;
		static __glGetHistogramParameterfvEXT __GlueGetHistogramParameterfvEXT;
		static __glGetHistogramParameterivEXT __GlueGetHistogramParameterivEXT;
		static __glGetMinmaxEXT __GlueGetMinmaxEXT;
		static __glGetMinmaxParameterfvEXT __GlueGetMinmaxParameterfvEXT;
		static __glGetMinmaxParameterivEXT __GlueGetMinmaxParameterivEXT;
		static __glHistogramEXT __GlueHistogramEXT;
		static __glMinmaxEXT __GlueMinmaxEXT;
		static __glResetHistogramEXT __GlueResetHistogramEXT;
		static __glResetMinmaxEXT __GlueResetMinmaxEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetHistogramEXT(uint target, bool reset, uint format, uint type, IntPtr values) => __GlueGetHistogramEXT(target, reset, format, type, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetHistogramParameterfvEXT(uint target, uint pname, float* parameters) => __GlueGetHistogramParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetHistogramParameterivEXT(uint target, uint pname, int* parameters) => __GlueGetHistogramParameterivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMinmaxEXT(uint target, bool reset, uint format, uint type, IntPtr values) => __GlueGetMinmaxEXT(target, reset, format, type, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMinmaxParameterfvEXT(uint target, uint pname, float* parameters) => __GlueGetMinmaxParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMinmaxParameterivEXT(uint target, uint pname, int* parameters) => __GlueGetMinmaxParameterivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glHistogramEXT(uint target, int width, uint internalformat, bool sink) => __GlueHistogramEXT(target, width, internalformat, sink);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMinmaxEXT(uint target, uint internalformat, bool sink) => __GlueMinmaxEXT(target, internalformat, sink);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glResetHistogramEXT(uint target) => __GlueResetHistogramEXT(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glResetMinmaxEXT(uint target) => __GlueResetMinmaxEXT(target);



	}
}


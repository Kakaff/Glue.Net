using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_viewport_array {get; private set;}

		public const int GL_MAX_VIEWPORTS = 0x825B;
		public const int GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
		public const int GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
		public const int GL_LAYER_PROVOKING_VERTEX = 0x825E;
		public const int GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
		public const int GL_UNDEFINED_VERTEX = 0x8260;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthRangeArrayv(uint first, int count, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthRangeIndexed(uint index, double n, double f);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetDoublei_v(uint target, uint index, double* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFloati_v(uint target, uint index, float* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glScissorArrayv(uint first, int count, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glScissorIndexed(uint index, int left, int bottom, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glScissorIndexedv(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glViewportArrayv(uint first, int count, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glViewportIndexedf(uint index, float x, float y, float w, float h);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glViewportIndexedfv(uint index, float* v);

 		static __glDepthRangeArrayv __GlueDepthRangeArrayv;
		static __glDepthRangeIndexed __GlueDepthRangeIndexed;
		static __glGetDoublei_v __GlueGetDoublei_v;
		static __glGetFloati_v __GlueGetFloati_v;
		static __glScissorArrayv __GlueScissorArrayv;
		static __glScissorIndexed __GlueScissorIndexed;
		static __glScissorIndexedv __GlueScissorIndexedv;
		static __glViewportArrayv __GlueViewportArrayv;
		static __glViewportIndexedf __GlueViewportIndexedf;
		static __glViewportIndexedfv __GlueViewportIndexedfv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthRangeArrayv(uint first, int count, double* v) => __GlueDepthRangeArrayv(first, count, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthRangeIndexed(uint index, double n, double f) => __GlueDepthRangeIndexed(index, n, f);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetDoublei_v(uint target, uint index, double* data) => __GlueGetDoublei_v(target, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFloati_v(uint target, uint index, float* data) => __GlueGetFloati_v(target, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glScissorArrayv(uint first, int count, int* v) => __GlueScissorArrayv(first, count, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glScissorIndexed(uint index, int left, int bottom, int width, int height) => __GlueScissorIndexed(index, left, bottom, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glScissorIndexedv(uint index, int* v) => __GlueScissorIndexedv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glViewportArrayv(uint first, int count, float* v) => __GlueViewportArrayv(first, count, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glViewportIndexedf(uint index, float x, float y, float w, float h) => __GlueViewportIndexedf(index, x, y, w, h);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glViewportIndexedfv(uint index, float* v) => __GlueViewportIndexedfv(index, v);



	}
}


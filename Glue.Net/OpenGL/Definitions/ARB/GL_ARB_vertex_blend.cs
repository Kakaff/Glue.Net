using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_blend {get; private set;}

		public const int GL_MODELVIEW0_ARB = 0x1700;
		public const int GL_MODELVIEW1_ARB = 0x850A;
		public const int GL_MAX_VERTEX_UNITS_ARB = 0x86A4;
		public const int GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
		public const int GL_WEIGHT_SUM_UNITY_ARB = 0x86A6;
		public const int GL_VERTEX_BLEND_ARB = 0x86A7;
		public const int GL_CURRENT_WEIGHT_ARB = 0x86A8;
		public const int GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
		public const int GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
		public const int GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
		public const int GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
		public const int GL_WEIGHT_ARRAY_ARB = 0x86AD;
		public const int GL_MODELVIEW2_ARB = 0x8722;
		public const int GL_MODELVIEW3_ARB = 0x8723;
		public const int GL_MODELVIEW4_ARB = 0x8724;
		public const int GL_MODELVIEW5_ARB = 0x8725;
		public const int GL_MODELVIEW6_ARB = 0x8726;
		public const int GL_MODELVIEW7_ARB = 0x8727;
		public const int GL_MODELVIEW8_ARB = 0x8728;
		public const int GL_MODELVIEW9_ARB = 0x8729;
		public const int GL_MODELVIEW10_ARB = 0x872A;
		public const int GL_MODELVIEW11_ARB = 0x872B;
		public const int GL_MODELVIEW12_ARB = 0x872C;
		public const int GL_MODELVIEW13_ARB = 0x872D;
		public const int GL_MODELVIEW14_ARB = 0x872E;
		public const int GL_MODELVIEW15_ARB = 0x872F;
		public const int GL_MODELVIEW16_ARB = 0x8730;
		public const int GL_MODELVIEW17_ARB = 0x8731;
		public const int GL_MODELVIEW18_ARB = 0x8732;
		public const int GL_MODELVIEW19_ARB = 0x8733;
		public const int GL_MODELVIEW20_ARB = 0x8734;
		public const int GL_MODELVIEW21_ARB = 0x8735;
		public const int GL_MODELVIEW22_ARB = 0x8736;
		public const int GL_MODELVIEW23_ARB = 0x8737;
		public const int GL_MODELVIEW24_ARB = 0x8738;
		public const int GL_MODELVIEW25_ARB = 0x8739;
		public const int GL_MODELVIEW26_ARB = 0x873A;
		public const int GL_MODELVIEW27_ARB = 0x873B;
		public const int GL_MODELVIEW28_ARB = 0x873C;
		public const int GL_MODELVIEW29_ARB = 0x873D;
		public const int GL_MODELVIEW30_ARB = 0x873E;
		public const int GL_MODELVIEW31_ARB = 0x873F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexBlendARB(int count);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightPointerARB(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightbvARB(int size, sbyte* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightdvARB(int size, double* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightfvARB(int size, float* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightivARB(int size, int* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightsvARB(int size, short* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightubvARB(int size, byte* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightuivARB(int size, uint* weights);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWeightusvARB(int size, ushort* weights);

 		static __glVertexBlendARB __GlueVertexBlendARB;
		static __glWeightPointerARB __GlueWeightPointerARB;
		static __glWeightbvARB __GlueWeightbvARB;
		static __glWeightdvARB __GlueWeightdvARB;
		static __glWeightfvARB __GlueWeightfvARB;
		static __glWeightivARB __GlueWeightivARB;
		static __glWeightsvARB __GlueWeightsvARB;
		static __glWeightubvARB __GlueWeightubvARB;
		static __glWeightuivARB __GlueWeightuivARB;
		static __glWeightusvARB __GlueWeightusvARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexBlendARB(int count) => __GlueVertexBlendARB(count);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightPointerARB(int size, uint type, int stride, IntPtr pointer) => __GlueWeightPointerARB(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightbvARB(int size, sbyte* weights) => __GlueWeightbvARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightdvARB(int size, double* weights) => __GlueWeightdvARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightfvARB(int size, float* weights) => __GlueWeightfvARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightivARB(int size, int* weights) => __GlueWeightivARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightsvARB(int size, short* weights) => __GlueWeightsvARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightubvARB(int size, byte* weights) => __GlueWeightubvARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightuivARB(int size, uint* weights) => __GlueWeightuivARB(size, weights);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWeightusvARB(int size, ushort* weights) => __GlueWeightusvARB(size, weights);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_vertex_weighting {get; private set;}

		public const int GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;
		public const int GL_MODELVIEW0_MATRIX_EXT = 0x0BA6;
		public const int GL_MODELVIEW0_EXT = 0x1700;
		public const int GL_MODELVIEW1_STACK_DEPTH_EXT = 0x8502;
		public const int GL_MODELVIEW1_MATRIX_EXT = 0x8506;
		public const int GL_VERTEX_WEIGHTING_EXT = 0x8509;
		public const int GL_MODELVIEW1_EXT = 0x850A;
		public const int GL_CURRENT_VERTEX_WEIGHT_EXT = 0x850B;
		public const int GL_VERTEX_WEIGHT_ARRAY_EXT = 0x850C;
		public const int GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;
		public const int GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;
		public const int GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
		public const int GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexWeightPointerEXT(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexWeightfEXT(float weight);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexWeightfvEXT(float* weight);

 		static __glVertexWeightPointerEXT __GlueVertexWeightPointerEXT;
		static __glVertexWeightfEXT __GlueVertexWeightfEXT;
		static __glVertexWeightfvEXT __GlueVertexWeightfvEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexWeightPointerEXT(int size, uint type, int stride, IntPtr pointer) => __GlueVertexWeightPointerEXT(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexWeightfEXT(float weight) => __GlueVertexWeightfEXT(weight);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexWeightfvEXT(float* weight) => __GlueVertexWeightfvEXT(weight);



	}
}


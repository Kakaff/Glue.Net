using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_transpose_matrix {get; private set;}

		public const int GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
		public const int GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
		public const int GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
		public const int GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadTransposeMatrixdARB(double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadTransposeMatrixfARB(float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultTransposeMatrixdARB(double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultTransposeMatrixfARB(float* m);

 		static __glLoadTransposeMatrixdARB __GlueLoadTransposeMatrixdARB;
		static __glLoadTransposeMatrixfARB __GlueLoadTransposeMatrixfARB;
		static __glMultTransposeMatrixdARB __GlueMultTransposeMatrixdARB;
		static __glMultTransposeMatrixfARB __GlueMultTransposeMatrixfARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadTransposeMatrixdARB(double* m) => __GlueLoadTransposeMatrixdARB(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadTransposeMatrixfARB(float* m) => __GlueLoadTransposeMatrixfARB(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultTransposeMatrixdARB(double* m) => __GlueMultTransposeMatrixdARB(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultTransposeMatrixfARB(float* m) => __GlueMultTransposeMatrixfARB(m);



	}
}


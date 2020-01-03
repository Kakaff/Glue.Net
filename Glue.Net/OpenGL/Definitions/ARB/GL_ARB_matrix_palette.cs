using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_matrix_palette {get; private set;}

		public const int GL_MATRIX_PALETTE_ARB = 0x8840;
		public const int GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
		public const int GL_MAX_PALETTE_MATRICES_ARB = 0x8842;
		public const int GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843;
		public const int GL_MATRIX_INDEX_ARRAY_ARB = 0x8844;
		public const int GL_CURRENT_MATRIX_INDEX_ARB = 0x8845;
		public const int GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
		public const int GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
		public const int GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
		public const int GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCurrentPaletteMatrixARB(int index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixIndexPointerARB(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixIndexubvARB(int size, byte* indices);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixIndexuivARB(int size, uint* indices);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixIndexusvARB(int size, ushort* indices);

 		static __glCurrentPaletteMatrixARB __GlueCurrentPaletteMatrixARB;
		static __glMatrixIndexPointerARB __GlueMatrixIndexPointerARB;
		static __glMatrixIndexubvARB __GlueMatrixIndexubvARB;
		static __glMatrixIndexuivARB __GlueMatrixIndexuivARB;
		static __glMatrixIndexusvARB __GlueMatrixIndexusvARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCurrentPaletteMatrixARB(int index) => __GlueCurrentPaletteMatrixARB(index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixIndexPointerARB(int size, uint type, int stride, IntPtr pointer) => __GlueMatrixIndexPointerARB(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixIndexubvARB(int size, byte* indices) => __GlueMatrixIndexubvARB(size, indices);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixIndexuivARB(int size, uint* indices) => __GlueMatrixIndexuivARB(size, indices);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixIndexusvARB(int size, ushort* indices) => __GlueMatrixIndexusvARB(size, indices);



	}
}


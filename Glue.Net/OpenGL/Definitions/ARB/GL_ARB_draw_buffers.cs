using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_draw_buffers {get; private set;}

		public const int GL_MAX_DRAW_BUFFERS_ARB = 0x8824;
		public const int GL_DRAW_BUFFER0_ARB = 0x8825;
		public const int GL_DRAW_BUFFER1_ARB = 0x8826;
		public const int GL_DRAW_BUFFER2_ARB = 0x8827;
		public const int GL_DRAW_BUFFER3_ARB = 0x8828;
		public const int GL_DRAW_BUFFER4_ARB = 0x8829;
		public const int GL_DRAW_BUFFER5_ARB = 0x882A;
		public const int GL_DRAW_BUFFER6_ARB = 0x882B;
		public const int GL_DRAW_BUFFER7_ARB = 0x882C;
		public const int GL_DRAW_BUFFER8_ARB = 0x882D;
		public const int GL_DRAW_BUFFER9_ARB = 0x882E;
		public const int GL_DRAW_BUFFER10_ARB = 0x882F;
		public const int GL_DRAW_BUFFER11_ARB = 0x8830;
		public const int GL_DRAW_BUFFER12_ARB = 0x8831;
		public const int GL_DRAW_BUFFER13_ARB = 0x8832;
		public const int GL_DRAW_BUFFER14_ARB = 0x8833;
		public const int GL_DRAW_BUFFER15_ARB = 0x8834;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawBuffersARB(int n, uint* bufs);

 		static __glDrawBuffersARB __GlueDrawBuffersARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawBuffersARB(int n, uint* bufs) => __GlueDrawBuffersARB(n, bufs);



	}
}


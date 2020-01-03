using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_draw_buffers {get; private set;}

		public const int GL_MAX_DRAW_BUFFERS_EXT = 0x8824;
		public const int GL_DRAW_BUFFER0_EXT = 0x8825;
		public const int GL_DRAW_BUFFER1_EXT = 0x8826;
		public const int GL_DRAW_BUFFER2_EXT = 0x8827;
		public const int GL_DRAW_BUFFER3_EXT = 0x8828;
		public const int GL_DRAW_BUFFER4_EXT = 0x8829;
		public const int GL_DRAW_BUFFER5_EXT = 0x882A;
		public const int GL_DRAW_BUFFER6_EXT = 0x882B;
		public const int GL_DRAW_BUFFER7_EXT = 0x882C;
		public const int GL_DRAW_BUFFER8_EXT = 0x882D;
		public const int GL_DRAW_BUFFER9_EXT = 0x882E;
		public const int GL_DRAW_BUFFER10_EXT = 0x882F;
		public const int GL_DRAW_BUFFER11_EXT = 0x8830;
		public const int GL_DRAW_BUFFER12_EXT = 0x8831;
		public const int GL_DRAW_BUFFER13_EXT = 0x8832;
		public const int GL_DRAW_BUFFER14_EXT = 0x8833;
		public const int GL_DRAW_BUFFER15_EXT = 0x8834;
		public const int GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF;
		public const int GL_COLOR_ATTACHMENT0_EXT = 0x8CE0;
		public const int GL_COLOR_ATTACHMENT1_EXT = 0x8CE1;
		public const int GL_COLOR_ATTACHMENT2_EXT = 0x8CE2;
		public const int GL_COLOR_ATTACHMENT3_EXT = 0x8CE3;
		public const int GL_COLOR_ATTACHMENT4_EXT = 0x8CE4;
		public const int GL_COLOR_ATTACHMENT5_EXT = 0x8CE5;
		public const int GL_COLOR_ATTACHMENT6_EXT = 0x8CE6;
		public const int GL_COLOR_ATTACHMENT7_EXT = 0x8CE7;
		public const int GL_COLOR_ATTACHMENT8_EXT = 0x8CE8;
		public const int GL_COLOR_ATTACHMENT9_EXT = 0x8CE9;
		public const int GL_COLOR_ATTACHMENT10_EXT = 0x8CEA;
		public const int GL_COLOR_ATTACHMENT11_EXT = 0x8CEB;
		public const int GL_COLOR_ATTACHMENT12_EXT = 0x8CEC;
		public const int GL_COLOR_ATTACHMENT13_EXT = 0x8CED;
		public const int GL_COLOR_ATTACHMENT14_EXT = 0x8CEE;
		public const int GL_COLOR_ATTACHMENT15_EXT = 0x8CEF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawBuffersEXT(int n, uint* bufs);

 		static __glDrawBuffersEXT __GlueDrawBuffersEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawBuffersEXT(int n, uint* bufs) => __GlueDrawBuffersEXT(n, bufs);



	}
}


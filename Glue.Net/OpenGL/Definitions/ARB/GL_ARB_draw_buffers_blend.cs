using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_draw_buffers_blend {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationiARB(uint buf, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFunciARB(uint buf, uint src, uint dst);

 		static __glBlendEquationSeparateiARB __GlueBlendEquationSeparateiARB;
		static __glBlendEquationiARB __GlueBlendEquationiARB;
		static __glBlendFuncSeparateiARB __GlueBlendFuncSeparateiARB;
		static __glBlendFunciARB __GlueBlendFunciARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha) => __GlueBlendEquationSeparateiARB(buf, modeRGB, modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationiARB(uint buf, uint mode) => __GlueBlendEquationiARB(buf, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) => __GlueBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFunciARB(uint buf, uint src, uint dst) => __GlueBlendFunciARB(buf, src, dst);



	}
}


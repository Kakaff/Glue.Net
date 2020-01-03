using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_draw_buffers_indexed {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationSeparateiEXT(uint buf, uint modeRGB, uint modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquationiEXT(uint buf, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFuncSeparateiEXT(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFunciEXT(uint buf, uint src, uint dst);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorMaskiEXT(uint buf, bool r, bool g, bool b, bool a);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableiEXT(uint target, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableiEXT(uint target, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsEnablediEXT(uint target, uint index);

 		static __glBlendEquationSeparateiEXT __GlueBlendEquationSeparateiEXT;
		static __glBlendEquationiEXT __GlueBlendEquationiEXT;
		static __glBlendFuncSeparateiEXT __GlueBlendFuncSeparateiEXT;
		static __glBlendFunciEXT __GlueBlendFunciEXT;
		static __glColorMaskiEXT __GlueColorMaskiEXT;
		static __glDisableiEXT __GlueDisableiEXT;
		static __glEnableiEXT __GlueEnableiEXT;
		static __glIsEnablediEXT __GlueIsEnablediEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationSeparateiEXT(uint buf, uint modeRGB, uint modeAlpha) => __GlueBlendEquationSeparateiEXT(buf, modeRGB, modeAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquationiEXT(uint buf, uint mode) => __GlueBlendEquationiEXT(buf, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFuncSeparateiEXT(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) => __GlueBlendFuncSeparateiEXT(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFunciEXT(uint buf, uint src, uint dst) => __GlueBlendFunciEXT(buf, src, dst);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorMaskiEXT(uint buf, bool r, bool g, bool b, bool a) => __GlueColorMaskiEXT(buf, r, g, b, a);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableiEXT(uint target, uint index) => __GlueDisableiEXT(target, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableiEXT(uint target, uint index) => __GlueEnableiEXT(target, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsEnablediEXT(uint target, uint index) => __GlueIsEnablediEXT(target, index);



	}
}


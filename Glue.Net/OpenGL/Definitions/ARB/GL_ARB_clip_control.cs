using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_clip_control {get; private set;}

		public const int GL_CLIP_ORIGIN = 0x935C;
		public const int GL_CLIP_DEPTH_MODE = 0x935D;
		public const int GL_NEGATIVE_ONE_TO_ONE = 0x935E;
		public const int GL_ZERO_TO_ONE = 0x935F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClipControl(uint origin, uint depth);

 		static __glClipControl __GlueClipControl;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClipControl(uint origin, uint depth) => __GlueClipControl(origin, depth);



	}
}


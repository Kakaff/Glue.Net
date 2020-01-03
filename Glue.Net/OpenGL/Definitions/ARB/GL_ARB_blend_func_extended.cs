using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_blend_func_extended {get; private set;}

		public const int GL_SRC1_COLOR = 0x88F9;
		public const int GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
		public const int GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
		public const int GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetFragDataIndex(uint program, char* name);

 		static __glBindFragDataLocationIndexed __GlueBindFragDataLocationIndexed;
		static __glGetFragDataIndex __GlueGetFragDataIndex;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, char* name) => __GlueBindFragDataLocationIndexed(program, colorNumber, index, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetFragDataIndex(uint program, char* name) => __GlueGetFragDataIndex(program, name);



	}
}


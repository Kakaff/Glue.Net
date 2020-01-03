using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_blend_func_extended {get; private set;}

		public const int GL_SRC_ALPHA_SATURATE_EXT = 0x0308;
		public const int GL_SRC1_ALPHA_EXT = 0x8589;
		public const int GL_SRC1_COLOR_EXT = 0x88F9;
		public const int GL_ONE_MINUS_SRC1_COLOR_EXT = 0x88FA;
		public const int GL_ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB;
		public const int GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC;
		public const int GL_LOCATION_INDEX_EXT = 0x930F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetFragDataIndexEXT(uint program, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetProgramResourceLocationIndexEXT(uint program, uint programInterface, char* name);

 		static __glBindFragDataLocationIndexedEXT __GlueBindFragDataLocationIndexedEXT;
		static __glGetFragDataIndexEXT __GlueGetFragDataIndexEXT;
		static __glGetProgramResourceLocationIndexEXT __GlueGetProgramResourceLocationIndexEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindFragDataLocationIndexedEXT(uint program, uint colorNumber, uint index, char* name) => __GlueBindFragDataLocationIndexedEXT(program, colorNumber, index, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetFragDataIndexEXT(uint program, char* name) => __GlueGetFragDataIndexEXT(program, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetProgramResourceLocationIndexEXT(uint program, uint programInterface, char* name) => __GlueGetProgramResourceLocationIndexEXT(program, programInterface, name);



	}
}


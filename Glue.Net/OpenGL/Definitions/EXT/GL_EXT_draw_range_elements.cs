using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_draw_range_elements {get; private set;}

		public const int GL_MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
		public const int GL_MAX_ELEMENTS_INDICES_EXT = 0x80E9;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, IntPtr indices);

 		static __glDrawRangeElementsEXT __GlueDrawRangeElementsEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawRangeElementsEXT(uint mode, uint start, uint end, int count, uint type, IntPtr indices) => __GlueDrawRangeElementsEXT(mode, start, end, count, type, indices);



	}
}


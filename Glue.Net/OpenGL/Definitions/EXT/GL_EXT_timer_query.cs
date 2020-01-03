using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_timer_query {get; private set;}

		public const int GL_TIME_ELAPSED_EXT = 0x88BF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjecti64vEXT(uint id, uint pname, long* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjectui64vEXT(uint id, uint pname, ulong* parameters);

 		static __glGetQueryObjecti64vEXT __GlueGetQueryObjecti64vEXT;
		static __glGetQueryObjectui64vEXT __GlueGetQueryObjectui64vEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjecti64vEXT(uint id, uint pname, long* parameters) => __GlueGetQueryObjecti64vEXT(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjectui64vEXT(uint id, uint pname, ulong* parameters) => __GlueGetQueryObjectui64vEXT(id, pname, parameters);



	}
}


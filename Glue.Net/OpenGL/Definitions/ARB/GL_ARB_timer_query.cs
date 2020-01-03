using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_timer_query {get; private set;}

		public const int GL_TIME_ELAPSED = 0x88BF;
		public const int GL_TIMESTAMP = 0x8E28;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjecti64v(uint id, uint pname, long* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjectui64v(uint id, uint pname, ulong* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glQueryCounter(uint id, uint target);

 		static __glGetQueryObjecti64v __GlueGetQueryObjecti64v;
		static __glGetQueryObjectui64v __GlueGetQueryObjectui64v;
		static __glQueryCounter __GlueQueryCounter;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjecti64v(uint id, uint pname, long* parameters) => __GlueGetQueryObjecti64v(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjectui64v(uint id, uint pname, ulong* parameters) => __GlueGetQueryObjectui64v(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glQueryCounter(uint id, uint target) => __GlueQueryCounter(id, target);



	}
}


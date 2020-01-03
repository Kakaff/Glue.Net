using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_occlusion_query {get; private set;}

		public const int GL_QUERY_COUNTER_BITS_ARB = 0x8864;
		public const int GL_CURRENT_QUERY_ARB = 0x8865;
		public const int GL_QUERY_RESULT_ARB = 0x8866;
		public const int GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867;
		public const int GL_SAMPLES_PASSED_ARB = 0x8914;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginQueryARB(uint target, uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteQueriesARB(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndQueryARB(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenQueriesARB(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjectivARB(uint id, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjectuivARB(uint id, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryivARB(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsQueryARB(uint id);

 		static __glBeginQueryARB __GlueBeginQueryARB;
		static __glDeleteQueriesARB __GlueDeleteQueriesARB;
		static __glEndQueryARB __GlueEndQueryARB;
		static __glGenQueriesARB __GlueGenQueriesARB;
		static __glGetQueryObjectivARB __GlueGetQueryObjectivARB;
		static __glGetQueryObjectuivARB __GlueGetQueryObjectuivARB;
		static __glGetQueryivARB __GlueGetQueryivARB;
		static __glIsQueryARB __GlueIsQueryARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginQueryARB(uint target, uint id) => __GlueBeginQueryARB(target, id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteQueriesARB(int n, uint* ids) => __GlueDeleteQueriesARB(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndQueryARB(uint target) => __GlueEndQueryARB(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenQueriesARB(int n, uint* ids) => __GlueGenQueriesARB(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjectivARB(uint id, uint pname, int* parameters) => __GlueGetQueryObjectivARB(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjectuivARB(uint id, uint pname, uint* parameters) => __GlueGetQueryObjectuivARB(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryivARB(uint target, uint pname, int* parameters) => __GlueGetQueryivARB(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsQueryARB(uint id) => __GlueIsQueryARB(id);



	}
}


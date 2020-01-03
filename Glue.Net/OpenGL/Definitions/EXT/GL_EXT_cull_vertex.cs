using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_cull_vertex {get; private set;}

		public const int GL_CULL_VERTEX_EXT = 0x81AA;
		public const int GL_CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;
		public const int GL_CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCullParameterdvEXT(uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCullParameterfvEXT(uint pname, float* parameters);

 		static __glCullParameterdvEXT __GlueCullParameterdvEXT;
		static __glCullParameterfvEXT __GlueCullParameterfvEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCullParameterdvEXT(uint pname, double* parameters) => __GlueCullParameterdvEXT(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCullParameterfvEXT(uint pname, float* parameters) => __GlueCullParameterfvEXT(pname, parameters);



	}
}


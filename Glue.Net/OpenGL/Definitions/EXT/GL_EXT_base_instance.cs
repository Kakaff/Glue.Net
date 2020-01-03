using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_base_instance {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysInstancedBaseInstanceEXT(uint mode, int first, int count, int instancecount, uint baseinstance);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedBaseInstanceEXT(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstancedBaseVertexBaseInstanceEXT(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);

 		static __glDrawArraysInstancedBaseInstanceEXT __GlueDrawArraysInstancedBaseInstanceEXT;
		static __glDrawElementsInstancedBaseInstanceEXT __GlueDrawElementsInstancedBaseInstanceEXT;
		static __glDrawElementsInstancedBaseVertexBaseInstanceEXT __GlueDrawElementsInstancedBaseVertexBaseInstanceEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysInstancedBaseInstanceEXT(uint mode, int first, int count, int instancecount, uint baseinstance) => __GlueDrawArraysInstancedBaseInstanceEXT(mode, first, count, instancecount, baseinstance);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedBaseInstanceEXT(uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance) => __GlueDrawElementsInstancedBaseInstanceEXT(mode, count, type, indices, instancecount, baseinstance);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstancedBaseVertexBaseInstanceEXT(uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance) => __GlueDrawElementsInstancedBaseVertexBaseInstanceEXT(mode, count, type, indices, instancecount, basevertex, baseinstance);



	}
}


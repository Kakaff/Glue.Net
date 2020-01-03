using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_clear_buffer_object {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedBufferDataEXT(uint buffer, uint internalformat, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedBufferSubDataEXT(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);

 		static __glClearBufferData __GlueClearBufferData;
		static __glClearBufferSubData __GlueClearBufferSubData;
		static __glClearNamedBufferDataEXT __GlueClearNamedBufferDataEXT;
		static __glClearNamedBufferSubDataEXT __GlueClearNamedBufferSubDataEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearBufferData(uint target, uint internalformat, uint format, uint type, IntPtr data) => __GlueClearBufferData(target, internalformat, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearBufferSubData(uint target, uint internalformat, int offset, int size, uint format, uint type, IntPtr data) => __GlueClearBufferSubData(target, internalformat, offset, size, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedBufferDataEXT(uint buffer, uint internalformat, uint format, uint type, IntPtr data) => __GlueClearNamedBufferDataEXT(buffer, internalformat, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedBufferSubDataEXT(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data) => __GlueClearNamedBufferSubDataEXT(buffer, internalformat, offset, size, format, type, data);



	}
}


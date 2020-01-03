using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_attrib_binding {get; private set;}

		public const int GL_VERTEX_ATTRIB_BINDING = 0x82D4;
		public const int GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
		public const int GL_VERTEX_BINDING_DIVISOR = 0x82D6;
		public const int GL_VERTEX_BINDING_OFFSET = 0x82D7;
		public const int GL_VERTEX_BINDING_STRIDE = 0x82D8;
		public const int GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
		public const int GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
		public const int GL_VERTEX_BINDING_BUFFER = 0x8F4F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayBindVertexBufferEXT(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribBindingEXT(uint vaobj, uint attribindex, uint bindingindex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribFormatEXT(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribIFormatEXT(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribLFormatEXT(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexBindingDivisorEXT(uint vaobj, uint bindingindex, uint divisor);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribBinding(uint attribindex, uint bindingindex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexBindingDivisor(uint bindingindex, uint divisor);

 		static __glBindVertexBuffer __GlueBindVertexBuffer;
		static __glVertexArrayBindVertexBufferEXT __GlueVertexArrayBindVertexBufferEXT;
		static __glVertexArrayVertexAttribBindingEXT __GlueVertexArrayVertexAttribBindingEXT;
		static __glVertexArrayVertexAttribFormatEXT __GlueVertexArrayVertexAttribFormatEXT;
		static __glVertexArrayVertexAttribIFormatEXT __GlueVertexArrayVertexAttribIFormatEXT;
		static __glVertexArrayVertexAttribLFormatEXT __GlueVertexArrayVertexAttribLFormatEXT;
		static __glVertexArrayVertexBindingDivisorEXT __GlueVertexArrayVertexBindingDivisorEXT;
		static __glVertexAttribBinding __GlueVertexAttribBinding;
		static __glVertexAttribFormat __GlueVertexAttribFormat;
		static __glVertexAttribIFormat __GlueVertexAttribIFormat;
		static __glVertexAttribLFormat __GlueVertexAttribLFormat;
		static __glVertexBindingDivisor __GlueVertexBindingDivisor;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindVertexBuffer(uint bindingindex, uint buffer, int offset, int stride) => __GlueBindVertexBuffer(bindingindex, buffer, offset, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayBindVertexBufferEXT(uint vaobj, uint bindingindex, uint buffer, int offset, int stride) => __GlueVertexArrayBindVertexBufferEXT(vaobj, bindingindex, buffer, offset, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribBindingEXT(uint vaobj, uint attribindex, uint bindingindex) => __GlueVertexArrayVertexAttribBindingEXT(vaobj, attribindex, bindingindex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribFormatEXT(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset) => __GlueVertexArrayVertexAttribFormatEXT(vaobj, attribindex, size, type, normalized, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribIFormatEXT(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) => __GlueVertexArrayVertexAttribIFormatEXT(vaobj, attribindex, size, type, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribLFormatEXT(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) => __GlueVertexArrayVertexAttribLFormatEXT(vaobj, attribindex, size, type, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexBindingDivisorEXT(uint vaobj, uint bindingindex, uint divisor) => __GlueVertexArrayVertexBindingDivisorEXT(vaobj, bindingindex, divisor);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribBinding(uint attribindex, uint bindingindex) => __GlueVertexAttribBinding(attribindex, bindingindex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset) => __GlueVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) => __GlueVertexAttribIFormat(attribindex, size, type, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) => __GlueVertexAttribLFormat(attribindex, size, type, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexBindingDivisor(uint bindingindex, uint divisor) => __GlueVertexBindingDivisor(bindingindex, divisor);



	}
}


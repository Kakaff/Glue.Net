using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_vertex_attrib_64bit {get; private set;}

		public const int GL_DOUBLE_MAT2_EXT = 0x8F46;
		public const int GL_DOUBLE_MAT3_EXT = 0x8F47;
		public const int GL_DOUBLE_MAT4_EXT = 0x8F48;
		public const int GL_DOUBLE_MAT2x3_EXT = 0x8F49;
		public const int GL_DOUBLE_MAT2x4_EXT = 0x8F4A;
		public const int GL_DOUBLE_MAT3x2_EXT = 0x8F4B;
		public const int GL_DOUBLE_MAT3x4_EXT = 0x8F4C;
		public const int GL_DOUBLE_MAT4x2_EXT = 0x8F4D;
		public const int GL_DOUBLE_MAT4x3_EXT = 0x8F4E;
		public const int GL_DOUBLE_VEC2_EXT = 0x8FFC;
		public const int GL_DOUBLE_VEC3_EXT = 0x8FFD;
		public const int GL_DOUBLE_VEC4_EXT = 0x8FFE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribLdvEXT(uint index, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL1dEXT(uint index, double x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL1dvEXT(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL2dEXT(uint index, double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL2dvEXT(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL3dEXT(uint index, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL3dvEXT(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL4dEXT(uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL4dvEXT(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribLPointerEXT(uint index, int size, uint type, int stride, IntPtr pointer);

 		static __glGetVertexAttribLdvEXT __GlueGetVertexAttribLdvEXT;
		static __glVertexArrayVertexAttribLOffsetEXT __GlueVertexArrayVertexAttribLOffsetEXT;
		static __glVertexAttribL1dEXT __GlueVertexAttribL1dEXT;
		static __glVertexAttribL1dvEXT __GlueVertexAttribL1dvEXT;
		static __glVertexAttribL2dEXT __GlueVertexAttribL2dEXT;
		static __glVertexAttribL2dvEXT __GlueVertexAttribL2dvEXT;
		static __glVertexAttribL3dEXT __GlueVertexAttribL3dEXT;
		static __glVertexAttribL3dvEXT __GlueVertexAttribL3dvEXT;
		static __glVertexAttribL4dEXT __GlueVertexAttribL4dEXT;
		static __glVertexAttribL4dvEXT __GlueVertexAttribL4dvEXT;
		static __glVertexAttribLPointerEXT __GlueVertexAttribLPointerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribLdvEXT(uint index, uint pname, double* parameters) => __GlueGetVertexAttribLdvEXT(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, int stride, int offset) => __GlueVertexArrayVertexAttribLOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL1dEXT(uint index, double x) => __GlueVertexAttribL1dEXT(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL1dvEXT(uint index, double* v) => __GlueVertexAttribL1dvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL2dEXT(uint index, double x, double y) => __GlueVertexAttribL2dEXT(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL2dvEXT(uint index, double* v) => __GlueVertexAttribL2dvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL3dEXT(uint index, double x, double y, double z) => __GlueVertexAttribL3dEXT(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL3dvEXT(uint index, double* v) => __GlueVertexAttribL3dvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL4dEXT(uint index, double x, double y, double z, double w) => __GlueVertexAttribL4dEXT(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL4dvEXT(uint index, double* v) => __GlueVertexAttribL4dvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribLPointerEXT(uint index, int size, uint type, int stride, IntPtr pointer) => __GlueVertexAttribLPointerEXT(index, size, type, stride, pointer);



	}
}


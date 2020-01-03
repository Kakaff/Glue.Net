using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_attrib_64bit {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribLdv(uint index, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL1d(uint index, double x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL1dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL2d(uint index, double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL2dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL3d(uint index, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL3dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL4d(uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL4dv(uint index, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer);

 		static __glGetVertexAttribLdv __GlueGetVertexAttribLdv;
		static __glVertexAttribL1d __GlueVertexAttribL1d;
		static __glVertexAttribL1dv __GlueVertexAttribL1dv;
		static __glVertexAttribL2d __GlueVertexAttribL2d;
		static __glVertexAttribL2dv __GlueVertexAttribL2dv;
		static __glVertexAttribL3d __GlueVertexAttribL3d;
		static __glVertexAttribL3dv __GlueVertexAttribL3dv;
		static __glVertexAttribL4d __GlueVertexAttribL4d;
		static __glVertexAttribL4dv __GlueVertexAttribL4dv;
		static __glVertexAttribLPointer __GlueVertexAttribLPointer;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribLdv(uint index, uint pname, double* parameters) => __GlueGetVertexAttribLdv(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL1d(uint index, double x) => __GlueVertexAttribL1d(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL1dv(uint index, double* v) => __GlueVertexAttribL1dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL2d(uint index, double x, double y) => __GlueVertexAttribL2d(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL2dv(uint index, double* v) => __GlueVertexAttribL2dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL3d(uint index, double x, double y, double z) => __GlueVertexAttribL3d(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL3dv(uint index, double* v) => __GlueVertexAttribL3dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL4d(uint index, double x, double y, double z, double w) => __GlueVertexAttribL4d(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL4dv(uint index, double* v) => __GlueVertexAttribL4dv(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribLPointer(uint index, int size, uint type, int stride, IntPtr pointer) => __GlueVertexAttribLPointer(index, size, type, stride, pointer);



	}
}


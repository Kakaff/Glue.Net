using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_vertex_array {get; private set;}

		public const int GL_DOUBLE_EXT = 0x140A;
		public const int GL_VERTEX_ARRAY_EXT = 0x8074;
		public const int GL_NORMAL_ARRAY_EXT = 0x8075;
		public const int GL_COLOR_ARRAY_EXT = 0x8076;
		public const int GL_INDEX_ARRAY_EXT = 0x8077;
		public const int GL_TEXTURE_COORD_ARRAY_EXT = 0x8078;
		public const int GL_EDGE_FLAG_ARRAY_EXT = 0x8079;
		public const int GL_VERTEX_ARRAY_SIZE_EXT = 0x807A;
		public const int GL_VERTEX_ARRAY_TYPE_EXT = 0x807B;
		public const int GL_VERTEX_ARRAY_STRIDE_EXT = 0x807C;
		public const int GL_VERTEX_ARRAY_COUNT_EXT = 0x807D;
		public const int GL_NORMAL_ARRAY_TYPE_EXT = 0x807E;
		public const int GL_NORMAL_ARRAY_STRIDE_EXT = 0x807F;
		public const int GL_NORMAL_ARRAY_COUNT_EXT = 0x8080;
		public const int GL_COLOR_ARRAY_SIZE_EXT = 0x8081;
		public const int GL_COLOR_ARRAY_TYPE_EXT = 0x8082;
		public const int GL_COLOR_ARRAY_STRIDE_EXT = 0x8083;
		public const int GL_COLOR_ARRAY_COUNT_EXT = 0x8084;
		public const int GL_INDEX_ARRAY_TYPE_EXT = 0x8085;
		public const int GL_INDEX_ARRAY_STRIDE_EXT = 0x8086;
		public const int GL_INDEX_ARRAY_COUNT_EXT = 0x8087;
		public const int GL_TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088;
		public const int GL_TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089;
		public const int GL_TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;
		public const int GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B;
		public const int GL_EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C;
		public const int GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D;
		public const int GL_VERTEX_ARRAY_POINTER_EXT = 0x808E;
		public const int GL_NORMAL_ARRAY_POINTER_EXT = 0x808F;
		public const int GL_COLOR_ARRAY_POINTER_EXT = 0x8090;
		public const int GL_INDEX_ARRAY_POINTER_EXT = 0x8091;
		public const int GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092;
		public const int GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glArrayElementEXT(int i);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorPointerEXT(int size, uint type, int stride, int count, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysEXT(uint mode, int first, int count);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEdgeFlagPointerEXT(int stride, int count, bool* pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexPointerEXT(uint type, int stride, int count, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormalPointerEXT(uint type, int stride, int count, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordPointerEXT(int size, uint type, int stride, int count, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexPointerEXT(int size, uint type, int stride, int count, IntPtr pointer);

 		static __glArrayElementEXT __GlueArrayElementEXT;
		static __glColorPointerEXT __GlueColorPointerEXT;
		static __glDrawArraysEXT __GlueDrawArraysEXT;
		static __glEdgeFlagPointerEXT __GlueEdgeFlagPointerEXT;
		static __glIndexPointerEXT __GlueIndexPointerEXT;
		static __glNormalPointerEXT __GlueNormalPointerEXT;
		static __glTexCoordPointerEXT __GlueTexCoordPointerEXT;
		static __glVertexPointerEXT __GlueVertexPointerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glArrayElementEXT(int i) => __GlueArrayElementEXT(i);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorPointerEXT(int size, uint type, int stride, int count, IntPtr pointer) => __GlueColorPointerEXT(size, type, stride, count, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysEXT(uint mode, int first, int count) => __GlueDrawArraysEXT(mode, first, count);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEdgeFlagPointerEXT(int stride, int count, bool* pointer) => __GlueEdgeFlagPointerEXT(stride, count, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexPointerEXT(uint type, int stride, int count, IntPtr pointer) => __GlueIndexPointerEXT(type, stride, count, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormalPointerEXT(uint type, int stride, int count, IntPtr pointer) => __GlueNormalPointerEXT(type, stride, count, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordPointerEXT(int size, uint type, int stride, int count, IntPtr pointer) => __GlueTexCoordPointerEXT(size, type, stride, count, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexPointerEXT(int size, uint type, int stride, int count, IntPtr pointer) => __GlueVertexPointerEXT(size, type, stride, count, pointer);



	}
}


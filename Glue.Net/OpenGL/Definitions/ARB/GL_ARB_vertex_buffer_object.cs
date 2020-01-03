using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_buffer_object {get; private set;}

		public const int GL_BUFFER_SIZE_ARB = 0x8764;
		public const int GL_BUFFER_USAGE_ARB = 0x8765;
		public const int GL_ARRAY_BUFFER_ARB = 0x8892;
		public const int GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
		public const int GL_ARRAY_BUFFER_BINDING_ARB = 0x8894;
		public const int GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
		public const int GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
		public const int GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
		public const int GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
		public const int GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
		public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
		public const int GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
		public const int GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
		public const int GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
		public const int GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
		public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
		public const int GL_READ_ONLY_ARB = 0x88B8;
		public const int GL_WRITE_ONLY_ARB = 0x88B9;
		public const int GL_READ_WRITE_ARB = 0x88BA;
		public const int GL_BUFFER_ACCESS_ARB = 0x88BB;
		public const int GL_BUFFER_MAPPED_ARB = 0x88BC;
		public const int GL_BUFFER_MAP_POINTER_ARB = 0x88BD;
		public const int GL_STREAM_DRAW_ARB = 0x88E0;
		public const int GL_STREAM_READ_ARB = 0x88E1;
		public const int GL_STREAM_COPY_ARB = 0x88E2;
		public const int GL_STATIC_DRAW_ARB = 0x88E4;
		public const int GL_STATIC_READ_ARB = 0x88E5;
		public const int GL_STATIC_COPY_ARB = 0x88E6;
		public const int GL_DYNAMIC_DRAW_ARB = 0x88E8;
		public const int GL_DYNAMIC_READ_ARB = 0x88E9;
		public const int GL_DYNAMIC_COPY_ARB = 0x88EA;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBufferARB(uint target, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferDataARB(uint target, int size, IntPtr data, uint usage);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferSubDataARB(uint target, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteBuffersARB(int n, uint* buffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenBuffersARB(int n, uint* buffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferParameterivARB(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferPointervARB(uint target, uint pname, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferSubDataARB(uint target, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsBufferARB(uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapBufferARB(uint target, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glUnmapBufferARB(uint target);

 		static __glBindBufferARB __GlueBindBufferARB;
		static __glBufferDataARB __GlueBufferDataARB;
		static __glBufferSubDataARB __GlueBufferSubDataARB;
		static __glDeleteBuffersARB __GlueDeleteBuffersARB;
		static __glGenBuffersARB __GlueGenBuffersARB;
		static __glGetBufferParameterivARB __GlueGetBufferParameterivARB;
		static __glGetBufferPointervARB __GlueGetBufferPointervARB;
		static __glGetBufferSubDataARB __GlueGetBufferSubDataARB;
		static __glIsBufferARB __GlueIsBufferARB;
		static __glMapBufferARB __GlueMapBufferARB;
		static __glUnmapBufferARB __GlueUnmapBufferARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBufferARB(uint target, uint buffer) => __GlueBindBufferARB(target, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferDataARB(uint target, int size, IntPtr data, uint usage) => __GlueBufferDataARB(target, size, data, usage);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferSubDataARB(uint target, int offset, int size, IntPtr data) => __GlueBufferSubDataARB(target, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteBuffersARB(int n, uint* buffers) => __GlueDeleteBuffersARB(n, buffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenBuffersARB(int n, uint* buffers) => __GlueGenBuffersARB(n, buffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferParameterivARB(uint target, uint pname, int* parameters) => __GlueGetBufferParameterivARB(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferPointervARB(uint target, uint pname, IntPtr* parameters) => __GlueGetBufferPointervARB(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferSubDataARB(uint target, int offset, int size, IntPtr data) => __GlueGetBufferSubDataARB(target, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsBufferARB(uint buffer) => __GlueIsBufferARB(buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapBufferARB(uint target, uint access) => __GlueMapBufferARB(target, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glUnmapBufferARB(uint target) => __GlueUnmapBufferARB(target);



	}
}


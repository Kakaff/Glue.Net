using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_1_5 {get; private set;}

		public const int GL_CURRENT_FOG_COORD = 0x8453;
		public const int GL_FOG_COORD = 0x8451;
		public const int GL_FOG_COORD_ARRAY = 0x8457;
		public const int GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
		public const int GL_FOG_COORD_ARRAY_POINTER = 0x8456;
		public const int GL_FOG_COORD_ARRAY_STRIDE = 0x8455;
		public const int GL_FOG_COORD_ARRAY_TYPE = 0x8454;
		public const int GL_FOG_COORD_SRC = 0x8450;
		public const int GL_SRC0_ALPHA = 0x8588;
		public const int GL_SRC0_RGB = 0x8580;
		public const int GL_SRC1_ALPHA = 0x8589;
		public const int GL_SRC1_RGB = 0x8581;
		public const int GL_SRC2_ALPHA = 0x858A;
		public const int GL_SRC2_RGB = 0x8582;
		public const int GL_BUFFER_SIZE = 0x8764;
		public const int GL_BUFFER_USAGE = 0x8765;
		public const int GL_QUERY_COUNTER_BITS = 0x8864;
		public const int GL_CURRENT_QUERY = 0x8865;
		public const int GL_QUERY_RESULT = 0x8866;
		public const int GL_QUERY_RESULT_AVAILABLE = 0x8867;
		public const int GL_ARRAY_BUFFER = 0x8892;
		public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
		public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
		public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		public const int GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
		public const int GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
		public const int GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
		public const int GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899;
		public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
		public const int GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
		public const int GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
		public const int GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
		public const int GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
		public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		public const int GL_READ_ONLY = 0x88B8;
		public const int GL_WRITE_ONLY = 0x88B9;
		public const int GL_READ_WRITE = 0x88BA;
		public const int GL_BUFFER_ACCESS = 0x88BB;
		public const int GL_BUFFER_MAPPED = 0x88BC;
		public const int GL_BUFFER_MAP_POINTER = 0x88BD;
		public const int GL_STREAM_DRAW = 0x88E0;
		public const int GL_STREAM_READ = 0x88E1;
		public const int GL_STREAM_COPY = 0x88E2;
		public const int GL_STATIC_DRAW = 0x88E4;
		public const int GL_STATIC_READ = 0x88E5;
		public const int GL_STATIC_COPY = 0x88E6;
		public const int GL_DYNAMIC_DRAW = 0x88E8;
		public const int GL_DYNAMIC_READ = 0x88E9;
		public const int GL_DYNAMIC_COPY = 0x88EA;
		public const int GL_SAMPLES_PASSED = 0x8914;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginQuery(uint target, uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBuffer(uint target, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferData(uint target, int size, IntPtr data, uint usage);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferSubData(uint target, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteBuffers(int n, uint* buffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteQueries(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndQuery(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenBuffers(int n, uint* buffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenQueries(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferPointerv(uint target, uint pname, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferSubData(uint target, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjectiv(uint id, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryObjectuiv(uint id, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryiv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsBuffer(uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsQuery(uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapBuffer(uint target, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glUnmapBuffer(uint target);

 		static __glBeginQuery __GlueBeginQuery;
		static __glBindBuffer __GlueBindBuffer;
		static __glBufferData __GlueBufferData;
		static __glBufferSubData __GlueBufferSubData;
		static __glDeleteBuffers __GlueDeleteBuffers;
		static __glDeleteQueries __GlueDeleteQueries;
		static __glEndQuery __GlueEndQuery;
		static __glGenBuffers __GlueGenBuffers;
		static __glGenQueries __GlueGenQueries;
		static __glGetBufferParameteriv __GlueGetBufferParameteriv;
		static __glGetBufferPointerv __GlueGetBufferPointerv;
		static __glGetBufferSubData __GlueGetBufferSubData;
		static __glGetQueryObjectiv __GlueGetQueryObjectiv;
		static __glGetQueryObjectuiv __GlueGetQueryObjectuiv;
		static __glGetQueryiv __GlueGetQueryiv;
		static __glIsBuffer __GlueIsBuffer;
		static __glIsQuery __GlueIsQuery;
		static __glMapBuffer __GlueMapBuffer;
		static __glUnmapBuffer __GlueUnmapBuffer;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginQuery(uint target, uint id) => __GlueBeginQuery(target, id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBuffer(uint target, uint buffer) => __GlueBindBuffer(target, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferData(uint target, int size, IntPtr data, uint usage) => __GlueBufferData(target, size, data, usage);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferSubData(uint target, int offset, int size, IntPtr data) => __GlueBufferSubData(target, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteBuffers(int n, uint* buffers) => __GlueDeleteBuffers(n, buffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteQueries(int n, uint* ids) => __GlueDeleteQueries(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndQuery(uint target) => __GlueEndQuery(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenBuffers(int n, uint* buffers) => __GlueGenBuffers(n, buffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenQueries(int n, uint* ids) => __GlueGenQueries(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferParameteriv(uint target, uint pname, int* parameters) => __GlueGetBufferParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferPointerv(uint target, uint pname, IntPtr* parameters) => __GlueGetBufferPointerv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferSubData(uint target, int offset, int size, IntPtr data) => __GlueGetBufferSubData(target, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjectiv(uint id, uint pname, int* parameters) => __GlueGetQueryObjectiv(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryObjectuiv(uint id, uint pname, uint* parameters) => __GlueGetQueryObjectuiv(id, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryiv(uint target, uint pname, int* parameters) => __GlueGetQueryiv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsBuffer(uint buffer) => __GlueIsBuffer(buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsQuery(uint id) => __GlueIsQuery(id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapBuffer(uint target, uint access) => __GlueMapBuffer(target, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glUnmapBuffer(uint target) => __GlueUnmapBuffer(target);



	}
}


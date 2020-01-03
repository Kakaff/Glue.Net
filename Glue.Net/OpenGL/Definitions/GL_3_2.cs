using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_3_2 {get; private set;}

		public const int GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const int GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const int GL_LINES_ADJACENCY = 0x000A;
		public const int GL_LINE_STRIP_ADJACENCY = 0x000B;
		public const int GL_TRIANGLES_ADJACENCY = 0x000C;
		public const int GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
		public const int GL_PROGRAM_POINT_SIZE = 0x8642;
		public const int GL_GEOMETRY_VERTICES_OUT = 0x8916;
		public const int GL_GEOMETRY_INPUT_TYPE = 0x8917;
		public const int GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
		public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
		public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
		public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
		public const int GL_GEOMETRY_SHADER = 0x8DD9;
		public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
		public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
		public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
		public const int GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
		public const int GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
		public const int GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
		public const int GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
		public const int GL_CONTEXT_PROFILE_MASK = 0x9126;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture(uint target, uint attachment, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBufferParameteri64v(uint target, uint value, long* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInteger64i_v(uint pname, uint index, long* data);

 		static __glFramebufferTexture __GlueFramebufferTexture;
		static __glGetBufferParameteri64v __GlueGetBufferParameteri64v;
		static __glGetInteger64i_v __GlueGetInteger64i_v;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture(uint target, uint attachment, uint texture, int level) => __GlueFramebufferTexture(target, attachment, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBufferParameteri64v(uint target, uint value, long* data) => __GlueGetBufferParameteri64v(target, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInteger64i_v(uint pname, uint index, long* data) => __GlueGetInteger64i_v(pname, index, data);



	}
}


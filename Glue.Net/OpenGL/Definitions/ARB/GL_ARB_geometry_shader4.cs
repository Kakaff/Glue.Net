using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_geometry_shader4 {get; private set;}

		public const int GL_LINES_ADJACENCY_ARB = 0xA;
		public const int GL_LINE_STRIP_ADJACENCY_ARB = 0xB;
		public const int GL_TRIANGLES_ADJACENCY_ARB = 0xC;
		public const int GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0xD;
		public const int GL_PROGRAM_POINT_SIZE_ARB = 0x8642;
		public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
		public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;
		public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
		public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
		public const int GL_GEOMETRY_SHADER_ARB = 0x8DD9;
		public const int GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
		public const int GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
		public const int GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
		public const int GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
		public const int GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
		public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
		public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
		public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureARB(uint target, uint attachment, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramParameteriARB(uint program, uint pname, int value);

 		static __glFramebufferTextureARB __GlueFramebufferTextureARB;
		static __glFramebufferTextureFaceARB __GlueFramebufferTextureFaceARB;
		static __glFramebufferTextureLayerARB __GlueFramebufferTextureLayerARB;
		static __glProgramParameteriARB __GlueProgramParameteriARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureARB(uint target, uint attachment, uint texture, int level) => __GlueFramebufferTextureARB(target, attachment, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face) => __GlueFramebufferTextureFaceARB(target, attachment, texture, level, face);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer) => __GlueFramebufferTextureLayerARB(target, attachment, texture, level, layer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramParameteriARB(uint program, uint pname, int value) => __GlueProgramParameteriARB(program, pname, value);



	}
}


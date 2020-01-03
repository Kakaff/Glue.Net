using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_geometry_shader4 {get; private set;}

		public const int GL_PROGRAM_POINT_SIZE_EXT = 0x8642;
		public const int GL_MAX_VARYING_COMPONENTS_EXT = 0x8B4B;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
		public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
		public const int GL_GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;
		public const int GL_GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;
		public const int GL_GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;
		public const int GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;
		public const int GL_MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureEXT(uint target, uint attachment, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureFaceEXT(uint target, uint attachment, uint texture, int level, uint face);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramParameteriEXT(uint program, uint pname, int value);

 		static __glFramebufferTextureEXT __GlueFramebufferTextureEXT;
		static __glFramebufferTextureFaceEXT __GlueFramebufferTextureFaceEXT;
		static __glProgramParameteriEXT __GlueProgramParameteriEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureEXT(uint target, uint attachment, uint texture, int level) => __GlueFramebufferTextureEXT(target, attachment, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureFaceEXT(uint target, uint attachment, uint texture, int level, uint face) => __GlueFramebufferTextureFaceEXT(target, attachment, texture, level, face);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramParameteriEXT(uint program, uint pname, int value) => __GlueProgramParameteriEXT(program, pname, value);



	}
}


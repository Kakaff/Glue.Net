using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_tessellation_shader {get; private set;}

		public const int GL_PATCHES = 0xE;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
		public const int GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
		public const int GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
		public const int GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
		public const int GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
		public const int GL_PATCH_VERTICES = 0x8E72;
		public const int GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
		public const int GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
		public const int GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
		public const int GL_TESS_GEN_MODE = 0x8E76;
		public const int GL_TESS_GEN_SPACING = 0x8E77;
		public const int GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
		public const int GL_TESS_GEN_POINT_MODE = 0x8E79;
		public const int GL_ISOLINES = 0x8E7A;
		public const int GL_FRACTIONAL_ODD = 0x8E7B;
		public const int GL_FRACTIONAL_EVEN = 0x8E7C;
		public const int GL_MAX_PATCH_VERTICES = 0x8E7D;
		public const int GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
		public const int GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
		public const int GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
		public const int GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
		public const int GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
		public const int GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
		public const int GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
		public const int GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
		public const int GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
		public const int GL_TESS_EVALUATION_SHADER = 0x8E87;
		public const int GL_TESS_CONTROL_SHADER = 0x8E88;
		public const int GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
		public const int GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPatchParameterfv(uint pname, float* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPatchParameteri(uint pname, int value);

 		static __glPatchParameterfv __GluePatchParameterfv;
		static __glPatchParameteri __GluePatchParameteri;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPatchParameterfv(uint pname, float* values) => __GluePatchParameterfv(pname, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPatchParameteri(uint pname, int value) => __GluePatchParameteri(pname, value);



	}
}


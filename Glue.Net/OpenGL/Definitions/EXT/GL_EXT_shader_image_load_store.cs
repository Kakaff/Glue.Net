using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_shader_image_load_store {get; private set;}

		public const int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
		public const int GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
		public const int GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004;
		public const int GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
		public const int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
		public const int GL_COMMAND_BARRIER_BIT_EXT = 0x00000040;
		public const int GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
		public const int GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
		public const int GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
		public const int GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
		public const int GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
		public const int GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
		public const int GL_MAX_IMAGE_UNITS_EXT = 0x8F38;
		public const int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
		public const int GL_IMAGE_BINDING_NAME_EXT = 0x8F3A;
		public const int GL_IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
		public const int GL_IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
		public const int GL_IMAGE_BINDING_LAYER_EXT = 0x8F3D;
		public const int GL_IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
		public const int GL_IMAGE_1D_EXT = 0x904C;
		public const int GL_IMAGE_2D_EXT = 0x904D;
		public const int GL_IMAGE_3D_EXT = 0x904E;
		public const int GL_IMAGE_2D_RECT_EXT = 0x904F;
		public const int GL_IMAGE_CUBE_EXT = 0x9050;
		public const int GL_IMAGE_BUFFER_EXT = 0x9051;
		public const int GL_IMAGE_1D_ARRAY_EXT = 0x9052;
		public const int GL_IMAGE_2D_ARRAY_EXT = 0x9053;
		public const int GL_IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
		public const int GL_IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
		public const int GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
		public const int GL_INT_IMAGE_1D_EXT = 0x9057;
		public const int GL_INT_IMAGE_2D_EXT = 0x9058;
		public const int GL_INT_IMAGE_3D_EXT = 0x9059;
		public const int GL_INT_IMAGE_2D_RECT_EXT = 0x905A;
		public const int GL_INT_IMAGE_CUBE_EXT = 0x905B;
		public const int GL_INT_IMAGE_BUFFER_EXT = 0x905C;
		public const int GL_INT_IMAGE_1D_ARRAY_EXT = 0x905D;
		public const int GL_INT_IMAGE_2D_ARRAY_EXT = 0x905E;
		public const int GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
		public const int GL_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
		public const int GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
		public const int GL_UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
		public const int GL_UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
		public const int GL_UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
		public const int GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
		public const int GL_UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
		public const int GL_UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
		public const int GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
		public const int GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
		public const int GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
		public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
		public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
		public const int GL_MAX_IMAGE_SAMPLES_EXT = 0x906D;
		public const int GL_IMAGE_BINDING_FORMAT_EXT = 0x906E;
		public const uint GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, uint access, int format);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMemoryBarrierEXT(uint barriers);

 		static __glBindImageTextureEXT __GlueBindImageTextureEXT;
		static __glMemoryBarrierEXT __GlueMemoryBarrierEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindImageTextureEXT(uint index, uint texture, int level, bool layered, int layer, uint access, int format) => __GlueBindImageTextureEXT(index, texture, level, layered, layer, access, format);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMemoryBarrierEXT(uint barriers) => __GlueMemoryBarrierEXT(barriers);



	}
}


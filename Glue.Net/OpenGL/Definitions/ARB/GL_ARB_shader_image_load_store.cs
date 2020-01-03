using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_shader_image_load_store {get; private set;}

		public const int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
		public const int GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
		public const int GL_UNIFORM_BARRIER_BIT = 0x00000004;
		public const int GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
		public const int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
		public const int GL_COMMAND_BARRIER_BIT = 0x00000040;
		public const int GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
		public const int GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
		public const int GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
		public const int GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400;
		public const int GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
		public const int GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
		public const int GL_MAX_IMAGE_UNITS = 0x8F38;
		public const int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
		public const int GL_IMAGE_BINDING_NAME = 0x8F3A;
		public const int GL_IMAGE_BINDING_LEVEL = 0x8F3B;
		public const int GL_IMAGE_BINDING_LAYERED = 0x8F3C;
		public const int GL_IMAGE_BINDING_LAYER = 0x8F3D;
		public const int GL_IMAGE_BINDING_ACCESS = 0x8F3E;
		public const int GL_IMAGE_1D = 0x904C;
		public const int GL_IMAGE_2D = 0x904D;
		public const int GL_IMAGE_3D = 0x904E;
		public const int GL_IMAGE_2D_RECT = 0x904F;
		public const int GL_IMAGE_CUBE = 0x9050;
		public const int GL_IMAGE_BUFFER = 0x9051;
		public const int GL_IMAGE_1D_ARRAY = 0x9052;
		public const int GL_IMAGE_2D_ARRAY = 0x9053;
		public const int GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
		public const int GL_IMAGE_2D_MULTISAMPLE = 0x9055;
		public const int GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
		public const int GL_INT_IMAGE_1D = 0x9057;
		public const int GL_INT_IMAGE_2D = 0x9058;
		public const int GL_INT_IMAGE_3D = 0x9059;
		public const int GL_INT_IMAGE_2D_RECT = 0x905A;
		public const int GL_INT_IMAGE_CUBE = 0x905B;
		public const int GL_INT_IMAGE_BUFFER = 0x905C;
		public const int GL_INT_IMAGE_1D_ARRAY = 0x905D;
		public const int GL_INT_IMAGE_2D_ARRAY = 0x905E;
		public const int GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
		public const int GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
		public const int GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
		public const int GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
		public const int GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
		public const int GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
		public const int GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
		public const int GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
		public const int GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
		public const int GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
		public const int GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
		public const int GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
		public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
		public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
		public const int GL_MAX_IMAGE_SAMPLES = 0x906D;
		public const int GL_IMAGE_BINDING_FORMAT = 0x906E;
		public const int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
		public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
		public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
		public const int GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
		public const int GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
		public const int GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
		public const int GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
		public const int GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
		public const int GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
		public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMemoryBarrier(uint barriers);

 		static __glBindImageTexture __GlueBindImageTexture;
		static __glMemoryBarrier __GlueMemoryBarrier;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format) => __GlueBindImageTexture(unit, texture, level, layered, layer, access, format);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMemoryBarrier(uint barriers) => __GlueMemoryBarrier(barriers);



	}
}


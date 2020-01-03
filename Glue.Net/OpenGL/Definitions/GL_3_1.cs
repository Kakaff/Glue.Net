using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_3_1 {get; private set;}

		public const int GL_TEXTURE_RECTANGLE = 0x84F5;
		public const int GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
		public const int GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
		public const int GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
		public const int GL_SAMPLER_2D_RECT = 0x8B63;
		public const int GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
		public const int GL_TEXTURE_BUFFER = 0x8C2A;
		public const int GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
		public const int GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
		public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
		public const int GL_TEXTURE_BUFFER_FORMAT = 0x8C2E;
		public const int GL_SAMPLER_BUFFER = 0x8DC2;
		public const int GL_INT_SAMPLER_2D_RECT = 0x8DCD;
		public const int GL_INT_SAMPLER_BUFFER = 0x8DD0;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
		public const int GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
		public const int GL_RED_SNORM = 0x8F90;
		public const int GL_RG_SNORM = 0x8F91;
		public const int GL_RGB_SNORM = 0x8F92;
		public const int GL_RGBA_SNORM = 0x8F93;
		public const int GL_R8_SNORM = 0x8F94;
		public const int GL_RG8_SNORM = 0x8F95;
		public const int GL_RGB8_SNORM = 0x8F96;
		public const int GL_RGBA8_SNORM = 0x8F97;
		public const int GL_R16_SNORM = 0x8F98;
		public const int GL_RG16_SNORM = 0x8F99;
		public const int GL_RGB16_SNORM = 0x8F9A;
		public const int GL_RGBA16_SNORM = 0x8F9B;
		public const int GL_SIGNED_NORMALIZED = 0x8F9C;
		public const int GL_PRIMITIVE_RESTART = 0x8F9D;
		public const int GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
		public const int GL_BUFFER_ACCESS_FLAGS = 0x911F;
		public const int GL_BUFFER_MAP_LENGTH = 0x9120;
		public const int GL_BUFFER_MAP_OFFSET = 0x9121;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArraysInstanced(uint mode, int first, int count, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPrimitiveRestartIndex(uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexBuffer(uint target, uint internalFormat, uint buffer);

 		static __glDrawArraysInstanced __GlueDrawArraysInstanced;
		static __glDrawElementsInstanced __GlueDrawElementsInstanced;
		static __glPrimitiveRestartIndex __GluePrimitiveRestartIndex;
		static __glTexBuffer __GlueTexBuffer;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArraysInstanced(uint mode, int first, int count, int primcount) => __GlueDrawArraysInstanced(mode, first, count, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElementsInstanced(uint mode, int count, uint type, IntPtr indices, int primcount) => __GlueDrawElementsInstanced(mode, count, type, indices, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPrimitiveRestartIndex(uint buffer) => __GluePrimitiveRestartIndex(buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexBuffer(uint target, uint internalFormat, uint buffer) => __GlueTexBuffer(target, internalFormat, buffer);



	}
}


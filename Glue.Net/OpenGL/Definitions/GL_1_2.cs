using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_1_2 {get; private set;}

		public const int GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const int GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const int GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const int GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const int GL_RESCALE_NORMAL = 0x803A;
		public const int GL_TEXTURE_BINDING_3D = 0x806A;
		public const int GL_PACK_SKIP_IMAGES = 0x806B;
		public const int GL_PACK_IMAGE_HEIGHT = 0x806C;
		public const int GL_UNPACK_SKIP_IMAGES = 0x806D;
		public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;
		public const int GL_TEXTURE_3D = 0x806F;
		public const int GL_PROXY_TEXTURE_3D = 0x8070;
		public const int GL_TEXTURE_DEPTH = 0x8071;
		public const int GL_TEXTURE_WRAP_R = 0x8072;
		public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;
		public const int GL_BGR = 0x80E0;
		public const int GL_BGRA = 0x80E1;
		public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;
		public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;
		public const int GL_CLAMP_TO_EDGE = 0x812F;
		public const int GL_TEXTURE_MIN_LOD = 0x813A;
		public const int GL_TEXTURE_MAX_LOD = 0x813B;
		public const int GL_TEXTURE_BASE_LEVEL = 0x813C;
		public const int GL_TEXTURE_MAX_LEVEL = 0x813D;
		public const int GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
		public const int GL_SINGLE_COLOR = 0x81F9;
		public const int GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
		public const int GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const int GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const int GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
		public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

 		static __glCopyTexSubImage3D __GlueCopyTexSubImage3D;
		static __glDrawRangeElements __GlueDrawRangeElements;
		static __glTexImage3D __GlueTexImage3D;
		static __glTexSubImage3D __GlueTexSubImage3D;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => __GlueCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices) => __GlueDrawRangeElements(mode, start, end, count, type, indices);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels) => __GlueTexImage3D(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => __GlueTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);



	}
}


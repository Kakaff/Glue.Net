using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_paletted_texture {get; private set;}

		public const int GL_COLOR_TABLE_FORMAT_EXT = 0x80D8;
		public const int GL_COLOR_TABLE_WIDTH_EXT = 0x80D9;
		public const int GL_COLOR_TABLE_RED_SIZE_EXT = 0x80DA;
		public const int GL_COLOR_TABLE_GREEN_SIZE_EXT = 0x80DB;
		public const int GL_COLOR_TABLE_BLUE_SIZE_EXT = 0x80DC;
		public const int GL_COLOR_TABLE_ALPHA_SIZE_EXT = 0x80DD;
		public const int GL_COLOR_TABLE_LUMINANCE_SIZE_EXT = 0x80DE;
		public const int GL_COLOR_TABLE_INTENSITY_SIZE_EXT = 0x80DF;
		public const int GL_TEXTURE_INDEX_SIZE_EXT = 0x80ED;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorTableEXT(uint target, uint internalFormat, int width, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetColorTableEXT(uint target, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetColorTableParameterfvEXT(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetColorTableParameterivEXT(uint target, uint pname, int* parameters);

 		static __glColorTableEXT __GlueColorTableEXT;
		static __glGetColorTableEXT __GlueGetColorTableEXT;
		static __glGetColorTableParameterfvEXT __GlueGetColorTableParameterfvEXT;
		static __glGetColorTableParameterivEXT __GlueGetColorTableParameterivEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorTableEXT(uint target, uint internalFormat, int width, uint format, uint type, IntPtr data) => __GlueColorTableEXT(target, internalFormat, width, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetColorTableEXT(uint target, uint format, uint type, IntPtr data) => __GlueGetColorTableEXT(target, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetColorTableParameterfvEXT(uint target, uint pname, float* parameters) => __GlueGetColorTableParameterfvEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetColorTableParameterivEXT(uint target, uint pname, int* parameters) => __GlueGetColorTableParameterivEXT(target, pname, parameters);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_integer {get; private set;}

		public const int GL_RGBA32UI_EXT = 0x8D70;
		public const int GL_RGB32UI_EXT = 0x8D71;
		public const int GL_ALPHA32UI_EXT = 0x8D72;
		public const int GL_INTENSITY32UI_EXT = 0x8D73;
		public const int GL_LUMINANCE32UI_EXT = 0x8D74;
		public const int GL_LUMINANCE_ALPHA32UI_EXT = 0x8D75;
		public const int GL_RGBA16UI_EXT = 0x8D76;
		public const int GL_RGB16UI_EXT = 0x8D77;
		public const int GL_ALPHA16UI_EXT = 0x8D78;
		public const int GL_INTENSITY16UI_EXT = 0x8D79;
		public const int GL_LUMINANCE16UI_EXT = 0x8D7A;
		public const int GL_LUMINANCE_ALPHA16UI_EXT = 0x8D7B;
		public const int GL_RGBA8UI_EXT = 0x8D7C;
		public const int GL_RGB8UI_EXT = 0x8D7D;
		public const int GL_ALPHA8UI_EXT = 0x8D7E;
		public const int GL_INTENSITY8UI_EXT = 0x8D7F;
		public const int GL_LUMINANCE8UI_EXT = 0x8D80;
		public const int GL_LUMINANCE_ALPHA8UI_EXT = 0x8D81;
		public const int GL_RGBA32I_EXT = 0x8D82;
		public const int GL_RGB32I_EXT = 0x8D83;
		public const int GL_ALPHA32I_EXT = 0x8D84;
		public const int GL_INTENSITY32I_EXT = 0x8D85;
		public const int GL_LUMINANCE32I_EXT = 0x8D86;
		public const int GL_LUMINANCE_ALPHA32I_EXT = 0x8D87;
		public const int GL_RGBA16I_EXT = 0x8D88;
		public const int GL_RGB16I_EXT = 0x8D89;
		public const int GL_ALPHA16I_EXT = 0x8D8A;
		public const int GL_INTENSITY16I_EXT = 0x8D8B;
		public const int GL_LUMINANCE16I_EXT = 0x8D8C;
		public const int GL_LUMINANCE_ALPHA16I_EXT = 0x8D8D;
		public const int GL_RGBA8I_EXT = 0x8D8E;
		public const int GL_RGB8I_EXT = 0x8D8F;
		public const int GL_ALPHA8I_EXT = 0x8D90;
		public const int GL_INTENSITY8I_EXT = 0x8D91;
		public const int GL_LUMINANCE8I_EXT = 0x8D92;
		public const int GL_LUMINANCE_ALPHA8I_EXT = 0x8D93;
		public const int GL_RED_INTEGER_EXT = 0x8D94;
		public const int GL_GREEN_INTEGER_EXT = 0x8D95;
		public const int GL_BLUE_INTEGER_EXT = 0x8D96;
		public const int GL_ALPHA_INTEGER_EXT = 0x8D97;
		public const int GL_RGB_INTEGER_EXT = 0x8D98;
		public const int GL_RGBA_INTEGER_EXT = 0x8D99;
		public const int GL_BGR_INTEGER_EXT = 0x8D9A;
		public const int GL_BGRA_INTEGER_EXT = 0x8D9B;
		public const int GL_LUMINANCE_INTEGER_EXT = 0x8D9C;
		public const int GL_LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D;
		public const int GL_RGBA_INTEGER_MODE_EXT = 0x8D9E;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearColorIiEXT(int red, int green, int blue, int alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexParameterIivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexParameterIuivEXT(uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameterIivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameterIuivEXT(uint target, uint pname, uint* parameters);

 		static __glClearColorIiEXT __GlueClearColorIiEXT;
		static __glClearColorIuiEXT __GlueClearColorIuiEXT;
		static __glGetTexParameterIivEXT __GlueGetTexParameterIivEXT;
		static __glGetTexParameterIuivEXT __GlueGetTexParameterIuivEXT;
		static __glTexParameterIivEXT __GlueTexParameterIivEXT;
		static __glTexParameterIuivEXT __GlueTexParameterIuivEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearColorIiEXT(int red, int green, int blue, int alpha) => __GlueClearColorIiEXT(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha) => __GlueClearColorIuiEXT(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexParameterIivEXT(uint target, uint pname, int* parameters) => __GlueGetTexParameterIivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexParameterIuivEXT(uint target, uint pname, uint* parameters) => __GlueGetTexParameterIuivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameterIivEXT(uint target, uint pname, int* parameters) => __GlueTexParameterIivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameterIuivEXT(uint target, uint pname, uint* parameters) => __GlueTexParameterIuivEXT(target, pname, parameters);



	}
}


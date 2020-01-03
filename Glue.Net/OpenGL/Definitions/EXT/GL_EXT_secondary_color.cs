using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_secondary_color {get; private set;}

		public const int GL_COLOR_SUM_EXT = 0x8458;
		public const int GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459;
		public const int GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
		public const int GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
		public const int GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
		public const int GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
		public const int GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3bvEXT(sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3dEXT(double red, double green, double blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3dvEXT(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3fEXT(float red, float green, float blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3fvEXT(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3iEXT(int red, int green, int blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3ivEXT(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3sEXT(short red, short green, short blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3svEXT(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3ubEXT(byte red, byte green, byte blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3ubvEXT(byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3uiEXT(uint red, uint green, uint blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3uivEXT(uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3usEXT(ushort red, ushort green, ushort blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3usvEXT(ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColorPointerEXT(int size, uint type, int stride, IntPtr pointer);

 		static __glSecondaryColor3bEXT __GlueSecondaryColor3bEXT;
		static __glSecondaryColor3bvEXT __GlueSecondaryColor3bvEXT;
		static __glSecondaryColor3dEXT __GlueSecondaryColor3dEXT;
		static __glSecondaryColor3dvEXT __GlueSecondaryColor3dvEXT;
		static __glSecondaryColor3fEXT __GlueSecondaryColor3fEXT;
		static __glSecondaryColor3fvEXT __GlueSecondaryColor3fvEXT;
		static __glSecondaryColor3iEXT __GlueSecondaryColor3iEXT;
		static __glSecondaryColor3ivEXT __GlueSecondaryColor3ivEXT;
		static __glSecondaryColor3sEXT __GlueSecondaryColor3sEXT;
		static __glSecondaryColor3svEXT __GlueSecondaryColor3svEXT;
		static __glSecondaryColor3ubEXT __GlueSecondaryColor3ubEXT;
		static __glSecondaryColor3ubvEXT __GlueSecondaryColor3ubvEXT;
		static __glSecondaryColor3uiEXT __GlueSecondaryColor3uiEXT;
		static __glSecondaryColor3uivEXT __GlueSecondaryColor3uivEXT;
		static __glSecondaryColor3usEXT __GlueSecondaryColor3usEXT;
		static __glSecondaryColor3usvEXT __GlueSecondaryColor3usvEXT;
		static __glSecondaryColorPointerEXT __GlueSecondaryColorPointerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue) => __GlueSecondaryColor3bEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3bvEXT(sbyte* v) => __GlueSecondaryColor3bvEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3dEXT(double red, double green, double blue) => __GlueSecondaryColor3dEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3dvEXT(double* v) => __GlueSecondaryColor3dvEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3fEXT(float red, float green, float blue) => __GlueSecondaryColor3fEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3fvEXT(float* v) => __GlueSecondaryColor3fvEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3iEXT(int red, int green, int blue) => __GlueSecondaryColor3iEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3ivEXT(int* v) => __GlueSecondaryColor3ivEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3sEXT(short red, short green, short blue) => __GlueSecondaryColor3sEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3svEXT(short* v) => __GlueSecondaryColor3svEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3ubEXT(byte red, byte green, byte blue) => __GlueSecondaryColor3ubEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3ubvEXT(byte* v) => __GlueSecondaryColor3ubvEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3uiEXT(uint red, uint green, uint blue) => __GlueSecondaryColor3uiEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3uivEXT(uint* v) => __GlueSecondaryColor3uivEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue) => __GlueSecondaryColor3usEXT(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3usvEXT(ushort* v) => __GlueSecondaryColor3usvEXT(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColorPointerEXT(int size, uint type, int stride, IntPtr pointer) => __GlueSecondaryColorPointerEXT(size, type, stride, pointer);



	}
}


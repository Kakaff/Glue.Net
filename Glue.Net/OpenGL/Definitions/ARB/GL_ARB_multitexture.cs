using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_multitexture {get; private set;}

		public const int GL_TEXTURE0_ARB = 0x84C0;
		public const int GL_TEXTURE1_ARB = 0x84C1;
		public const int GL_TEXTURE2_ARB = 0x84C2;
		public const int GL_TEXTURE3_ARB = 0x84C3;
		public const int GL_TEXTURE4_ARB = 0x84C4;
		public const int GL_TEXTURE5_ARB = 0x84C5;
		public const int GL_TEXTURE6_ARB = 0x84C6;
		public const int GL_TEXTURE7_ARB = 0x84C7;
		public const int GL_TEXTURE8_ARB = 0x84C8;
		public const int GL_TEXTURE9_ARB = 0x84C9;
		public const int GL_TEXTURE10_ARB = 0x84CA;
		public const int GL_TEXTURE11_ARB = 0x84CB;
		public const int GL_TEXTURE12_ARB = 0x84CC;
		public const int GL_TEXTURE13_ARB = 0x84CD;
		public const int GL_TEXTURE14_ARB = 0x84CE;
		public const int GL_TEXTURE15_ARB = 0x84CF;
		public const int GL_TEXTURE16_ARB = 0x84D0;
		public const int GL_TEXTURE17_ARB = 0x84D1;
		public const int GL_TEXTURE18_ARB = 0x84D2;
		public const int GL_TEXTURE19_ARB = 0x84D3;
		public const int GL_TEXTURE20_ARB = 0x84D4;
		public const int GL_TEXTURE21_ARB = 0x84D5;
		public const int GL_TEXTURE22_ARB = 0x84D6;
		public const int GL_TEXTURE23_ARB = 0x84D7;
		public const int GL_TEXTURE24_ARB = 0x84D8;
		public const int GL_TEXTURE25_ARB = 0x84D9;
		public const int GL_TEXTURE26_ARB = 0x84DA;
		public const int GL_TEXTURE27_ARB = 0x84DB;
		public const int GL_TEXTURE28_ARB = 0x84DC;
		public const int GL_TEXTURE29_ARB = 0x84DD;
		public const int GL_TEXTURE30_ARB = 0x84DE;
		public const int GL_TEXTURE31_ARB = 0x84DF;
		public const int GL_ACTIVE_TEXTURE_ARB = 0x84E0;
		public const int GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
		public const int GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glActiveTextureARB(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClientActiveTextureARB(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1dARB(uint target, double s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1dvARB(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1fARB(uint target, float s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1fvARB(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1iARB(uint target, int s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1ivARB(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1sARB(uint target, short s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1svARB(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2dARB(uint target, double s, double t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2dvARB(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2fARB(uint target, float s, float t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2fvARB(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2iARB(uint target, int s, int t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2ivARB(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2sARB(uint target, short s, short t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2svARB(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3dARB(uint target, double s, double t, double r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3dvARB(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3fARB(uint target, float s, float t, float r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3fvARB(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3iARB(uint target, int s, int t, int r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3ivARB(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3sARB(uint target, short s, short t, short r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3svARB(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4dARB(uint target, double s, double t, double r, double q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4dvARB(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4fARB(uint target, float s, float t, float r, float q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4fvARB(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4iARB(uint target, int s, int t, int r, int q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4ivARB(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4sARB(uint target, short s, short t, short r, short q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4svARB(uint target, short* v);

 		static __glActiveTextureARB __GlueActiveTextureARB;
		static __glClientActiveTextureARB __GlueClientActiveTextureARB;
		static __glMultiTexCoord1dARB __GlueMultiTexCoord1dARB;
		static __glMultiTexCoord1dvARB __GlueMultiTexCoord1dvARB;
		static __glMultiTexCoord1fARB __GlueMultiTexCoord1fARB;
		static __glMultiTexCoord1fvARB __GlueMultiTexCoord1fvARB;
		static __glMultiTexCoord1iARB __GlueMultiTexCoord1iARB;
		static __glMultiTexCoord1ivARB __GlueMultiTexCoord1ivARB;
		static __glMultiTexCoord1sARB __GlueMultiTexCoord1sARB;
		static __glMultiTexCoord1svARB __GlueMultiTexCoord1svARB;
		static __glMultiTexCoord2dARB __GlueMultiTexCoord2dARB;
		static __glMultiTexCoord2dvARB __GlueMultiTexCoord2dvARB;
		static __glMultiTexCoord2fARB __GlueMultiTexCoord2fARB;
		static __glMultiTexCoord2fvARB __GlueMultiTexCoord2fvARB;
		static __glMultiTexCoord2iARB __GlueMultiTexCoord2iARB;
		static __glMultiTexCoord2ivARB __GlueMultiTexCoord2ivARB;
		static __glMultiTexCoord2sARB __GlueMultiTexCoord2sARB;
		static __glMultiTexCoord2svARB __GlueMultiTexCoord2svARB;
		static __glMultiTexCoord3dARB __GlueMultiTexCoord3dARB;
		static __glMultiTexCoord3dvARB __GlueMultiTexCoord3dvARB;
		static __glMultiTexCoord3fARB __GlueMultiTexCoord3fARB;
		static __glMultiTexCoord3fvARB __GlueMultiTexCoord3fvARB;
		static __glMultiTexCoord3iARB __GlueMultiTexCoord3iARB;
		static __glMultiTexCoord3ivARB __GlueMultiTexCoord3ivARB;
		static __glMultiTexCoord3sARB __GlueMultiTexCoord3sARB;
		static __glMultiTexCoord3svARB __GlueMultiTexCoord3svARB;
		static __glMultiTexCoord4dARB __GlueMultiTexCoord4dARB;
		static __glMultiTexCoord4dvARB __GlueMultiTexCoord4dvARB;
		static __glMultiTexCoord4fARB __GlueMultiTexCoord4fARB;
		static __glMultiTexCoord4fvARB __GlueMultiTexCoord4fvARB;
		static __glMultiTexCoord4iARB __GlueMultiTexCoord4iARB;
		static __glMultiTexCoord4ivARB __GlueMultiTexCoord4ivARB;
		static __glMultiTexCoord4sARB __GlueMultiTexCoord4sARB;
		static __glMultiTexCoord4svARB __GlueMultiTexCoord4svARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glActiveTextureARB(uint texture) => __GlueActiveTextureARB(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClientActiveTextureARB(uint texture) => __GlueClientActiveTextureARB(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1dARB(uint target, double s) => __GlueMultiTexCoord1dARB(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1dvARB(uint target, double* v) => __GlueMultiTexCoord1dvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1fARB(uint target, float s) => __GlueMultiTexCoord1fARB(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1fvARB(uint target, float* v) => __GlueMultiTexCoord1fvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1iARB(uint target, int s) => __GlueMultiTexCoord1iARB(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1ivARB(uint target, int* v) => __GlueMultiTexCoord1ivARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1sARB(uint target, short s) => __GlueMultiTexCoord1sARB(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1svARB(uint target, short* v) => __GlueMultiTexCoord1svARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2dARB(uint target, double s, double t) => __GlueMultiTexCoord2dARB(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2dvARB(uint target, double* v) => __GlueMultiTexCoord2dvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2fARB(uint target, float s, float t) => __GlueMultiTexCoord2fARB(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2fvARB(uint target, float* v) => __GlueMultiTexCoord2fvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2iARB(uint target, int s, int t) => __GlueMultiTexCoord2iARB(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2ivARB(uint target, int* v) => __GlueMultiTexCoord2ivARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2sARB(uint target, short s, short t) => __GlueMultiTexCoord2sARB(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2svARB(uint target, short* v) => __GlueMultiTexCoord2svARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3dARB(uint target, double s, double t, double r) => __GlueMultiTexCoord3dARB(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3dvARB(uint target, double* v) => __GlueMultiTexCoord3dvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3fARB(uint target, float s, float t, float r) => __GlueMultiTexCoord3fARB(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3fvARB(uint target, float* v) => __GlueMultiTexCoord3fvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3iARB(uint target, int s, int t, int r) => __GlueMultiTexCoord3iARB(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3ivARB(uint target, int* v) => __GlueMultiTexCoord3ivARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3sARB(uint target, short s, short t, short r) => __GlueMultiTexCoord3sARB(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3svARB(uint target, short* v) => __GlueMultiTexCoord3svARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4dARB(uint target, double s, double t, double r, double q) => __GlueMultiTexCoord4dARB(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4dvARB(uint target, double* v) => __GlueMultiTexCoord4dvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4fARB(uint target, float s, float t, float r, float q) => __GlueMultiTexCoord4fARB(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4fvARB(uint target, float* v) => __GlueMultiTexCoord4fvARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4iARB(uint target, int s, int t, int r, int q) => __GlueMultiTexCoord4iARB(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4ivARB(uint target, int* v) => __GlueMultiTexCoord4ivARB(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4sARB(uint target, short s, short t, short r, short q) => __GlueMultiTexCoord4sARB(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4svARB(uint target, short* v) => __GlueMultiTexCoord4svARB(target, v);



	}
}


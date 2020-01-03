using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_window_pos {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2dARB(double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2dvARB(double* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2fARB(float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2fvARB(float* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2iARB(int x, int y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2ivARB(int* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2sARB(short x, short y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2svARB(short* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3dARB(double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3dvARB(double* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3fARB(float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3fvARB(float* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3iARB(int x, int y, int z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3ivARB(int* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3sARB(short x, short y, short z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3svARB(short* p);

 		static __glWindowPos2dARB __GlueWindowPos2dARB;
		static __glWindowPos2dvARB __GlueWindowPos2dvARB;
		static __glWindowPos2fARB __GlueWindowPos2fARB;
		static __glWindowPos2fvARB __GlueWindowPos2fvARB;
		static __glWindowPos2iARB __GlueWindowPos2iARB;
		static __glWindowPos2ivARB __GlueWindowPos2ivARB;
		static __glWindowPos2sARB __GlueWindowPos2sARB;
		static __glWindowPos2svARB __GlueWindowPos2svARB;
		static __glWindowPos3dARB __GlueWindowPos3dARB;
		static __glWindowPos3dvARB __GlueWindowPos3dvARB;
		static __glWindowPos3fARB __GlueWindowPos3fARB;
		static __glWindowPos3fvARB __GlueWindowPos3fvARB;
		static __glWindowPos3iARB __GlueWindowPos3iARB;
		static __glWindowPos3ivARB __GlueWindowPos3ivARB;
		static __glWindowPos3sARB __GlueWindowPos3sARB;
		static __glWindowPos3svARB __GlueWindowPos3svARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2dARB(double x, double y) => __GlueWindowPos2dARB(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2dvARB(double* p) => __GlueWindowPos2dvARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2fARB(float x, float y) => __GlueWindowPos2fARB(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2fvARB(float* p) => __GlueWindowPos2fvARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2iARB(int x, int y) => __GlueWindowPos2iARB(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2ivARB(int* p) => __GlueWindowPos2ivARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2sARB(short x, short y) => __GlueWindowPos2sARB(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2svARB(short* p) => __GlueWindowPos2svARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3dARB(double x, double y, double z) => __GlueWindowPos3dARB(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3dvARB(double* p) => __GlueWindowPos3dvARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3fARB(float x, float y, float z) => __GlueWindowPos3fARB(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3fvARB(float* p) => __GlueWindowPos3fvARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3iARB(int x, int y, int z) => __GlueWindowPos3iARB(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3ivARB(int* p) => __GlueWindowPos3ivARB(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3sARB(short x, short y, short z) => __GlueWindowPos3sARB(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3svARB(short* p) => __GlueWindowPos3svARB(p);



	}
}


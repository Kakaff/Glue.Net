using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_storage {get; private set;}

		public const int GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage1D(uint target, int levels, uint internalformat, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage2D(uint target, int levels, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth);

 		static __glTexStorage1D __GlueTexStorage1D;
		static __glTexStorage2D __GlueTexStorage2D;
		static __glTexStorage3D __GlueTexStorage3D;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage1D(uint target, int levels, uint internalformat, int width) => __GlueTexStorage1D(target, levels, internalformat, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height) => __GlueTexStorage2D(target, levels, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) => __GlueTexStorage3D(target, levels, internalformat, width, height, depth);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_storage_multisample {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage2DMultisampleEXT(uint texture, uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage3DMultisampleEXT(uint texture, uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

 		static __glTexStorage2DMultisample __GlueTexStorage2DMultisample;
		static __glTexStorage3DMultisample __GlueTexStorage3DMultisample;
		static __glTextureStorage2DMultisampleEXT __GlueTextureStorage2DMultisampleEXT;
		static __glTextureStorage3DMultisampleEXT __GlueTextureStorage3DMultisampleEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => __GlueTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => __GlueTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage2DMultisampleEXT(uint texture, uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => __GlueTextureStorage2DMultisampleEXT(texture, target, samples, internalformat, width, height, fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage3DMultisampleEXT(uint texture, uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => __GlueTextureStorage3DMultisampleEXT(texture, target, samples, internalformat, width, height, depth, fixedsamplelocations);



	}
}


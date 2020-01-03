using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_texture_view {get; private set;}

		public const int GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
		public const int GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
		public const int GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
		public const int GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

 		static __glTextureView __GlueTextureView;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => __GlueTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);



	}
}


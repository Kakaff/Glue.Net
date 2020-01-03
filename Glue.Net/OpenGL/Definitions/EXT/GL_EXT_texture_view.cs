using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_view {get; private set;}

		public const int GL_TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB;
		public const int GL_TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC;
		public const int GL_TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD;
		public const int GL_TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureViewEXT(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

 		static __glTextureViewEXT __GlueTextureViewEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureViewEXT(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) => __GlueTextureViewEXT(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);



	}
}


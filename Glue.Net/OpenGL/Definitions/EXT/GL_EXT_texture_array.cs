using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_array {get; private set;}

		public const int GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
		public const int GL_MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
		public const int GL_TEXTURE_1D_ARRAY_EXT = 0x8C18;
		public const int GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19;
		public const int GL_TEXTURE_2D_ARRAY_EXT = 0x8C1A;
		public const int GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B;
		public const int GL_TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
		public const int GL_TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureLayerEXT(uint target, uint attachment, uint texture, int level, int layer);

 		static __glFramebufferTextureLayerEXT __GlueFramebufferTextureLayerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureLayerEXT(uint target, uint attachment, uint texture, int level, int layer) => __GlueFramebufferTextureLayerEXT(target, attachment, texture, level, layer);



	}
}


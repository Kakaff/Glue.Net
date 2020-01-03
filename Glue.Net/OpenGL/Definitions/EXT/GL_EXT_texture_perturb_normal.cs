using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_perturb_normal {get; private set;}

		public const int GL_PERTURB_EXT = 0x85AE;
		public const int GL_TEXTURE_NORMAL_EXT = 0x85AF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureNormalEXT(uint mode);

 		static __glTextureNormalEXT __GlueTextureNormalEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureNormalEXT(uint mode) => __GlueTextureNormalEXT(mode);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_light_texture {get; private set;}

		public const int GL_FRAGMENT_MATERIAL_EXT = 0x8349;
		public const int GL_FRAGMENT_NORMAL_EXT = 0x834A;
		public const int GL_FRAGMENT_COLOR_EXT = 0x834C;
		public const int GL_ATTENUATION_EXT = 0x834D;
		public const int GL_SHADOW_ATTENUATION_EXT = 0x834E;
		public const int GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F;
		public const int GL_TEXTURE_LIGHT_EXT = 0x8350;
		public const int GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351;
		public const int GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glApplyTextureEXT(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureLightEXT(uint pname);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureMaterialEXT(uint face, uint mode);

 		static __glApplyTextureEXT __GlueApplyTextureEXT;
		static __glTextureLightEXT __GlueTextureLightEXT;
		static __glTextureMaterialEXT __GlueTextureMaterialEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glApplyTextureEXT(uint mode) => __GlueApplyTextureEXT(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureLightEXT(uint pname) => __GlueTextureLightEXT(pname);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureMaterialEXT(uint face, uint mode) => __GlueTextureMaterialEXT(face, mode);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_object {get; private set;}

		public const int GL_TEXTURE_PRIORITY_EXT = 0x8066;
		public const int GL_TEXTURE_RESIDENT_EXT = 0x8067;
		public const int GL_TEXTURE_1D_BINDING_EXT = 0x8068;
		public const int GL_TEXTURE_2D_BINDING_EXT = 0x8069;
		public const int GL_TEXTURE_3D_BINDING_EXT = 0x806A;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glAreTexturesResidentEXT(int n, uint* textures, bool* residences);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindTextureEXT(uint target, uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteTexturesEXT(int n, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenTexturesEXT(int n, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsTextureEXT(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPrioritizeTexturesEXT(int n, uint* textures, float* priorities);

 		static __glAreTexturesResidentEXT __GlueAreTexturesResidentEXT;
		static __glBindTextureEXT __GlueBindTextureEXT;
		static __glDeleteTexturesEXT __GlueDeleteTexturesEXT;
		static __glGenTexturesEXT __GlueGenTexturesEXT;
		static __glIsTextureEXT __GlueIsTextureEXT;
		static __glPrioritizeTexturesEXT __GluePrioritizeTexturesEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glAreTexturesResidentEXT(int n, uint* textures, bool* residences) => __GlueAreTexturesResidentEXT(n, textures, residences);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindTextureEXT(uint target, uint texture) => __GlueBindTextureEXT(target, texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteTexturesEXT(int n, uint* textures) => __GlueDeleteTexturesEXT(n, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenTexturesEXT(int n, uint* textures) => __GlueGenTexturesEXT(n, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsTextureEXT(uint texture) => __GlueIsTextureEXT(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPrioritizeTexturesEXT(int n, uint* textures, float* priorities) => __GluePrioritizeTexturesEXT(n, textures, priorities);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_sparse_texture {get; private set;}

		public const int GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009;
		public const int GL_VIRTUAL_PAGE_SIZE_X_EXT = 0x9195;
		public const int GL_VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196;
		public const int GL_VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197;
		public const int GL_MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198;
		public const int GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199;
		public const int GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A;
		public const int GL_TEXTURE_SPARSE_EXT = 0x91A6;
		public const int GL_VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7;
		public const int GL_NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8;
		public const int GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9;
		public const int GL_NUM_SPARSE_LEVELS_EXT = 0x91AA;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexPageCommitmentEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexturePageCommitmentEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);

 		static __glTexPageCommitmentEXT __GlueTexPageCommitmentEXT;
		static __glTexturePageCommitmentEXT __GlueTexturePageCommitmentEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexPageCommitmentEXT(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => __GlueTexPageCommitmentEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexturePageCommitmentEXT(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => __GlueTexturePageCommitmentEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, commit);



	}
}


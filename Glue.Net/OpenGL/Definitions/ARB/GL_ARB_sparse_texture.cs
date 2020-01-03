using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_sparse_texture {get; private set;}

		public const int GL_VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;
		public const int GL_VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;
		public const int GL_VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;
		public const int GL_MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;
		public const int GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;
		public const int GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;
		public const int GL_TEXTURE_SPARSE_ARB = 0x91A6;
		public const int GL_VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;
		public const int GL_NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;
		public const int GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;
		public const int GL_NUM_SPARSE_LEVELS_ARB = 0x91AA;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexPageCommitmentARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);

 		static __glTexPageCommitmentARB __GlueTexPageCommitmentARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexPageCommitmentARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit) => __GlueTexPageCommitmentARB(target, level, xoffset, yoffset, zoffset, width, height, depth, commit);



	}
}


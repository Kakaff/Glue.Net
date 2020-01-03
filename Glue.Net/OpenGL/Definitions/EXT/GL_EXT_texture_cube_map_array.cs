using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_texture_cube_map_array {get; private set;}

		public const int GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009;
		public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;
		public const int GL_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;
		public const int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;
		public const int GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;
		public const int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;

   

	}
}


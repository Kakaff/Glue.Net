using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_index_material {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexMaterialEXT(uint face, uint mode);

 		static __glIndexMaterialEXT __GlueIndexMaterialEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexMaterialEXT(uint face, uint mode) => __GlueIndexMaterialEXT(face, mode);



	}
}


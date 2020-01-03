using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_coordinate_frame {get; private set;}

		public const int GL_TANGENT_ARRAY_EXT = 0x8439;
		public const int GL_BINORMAL_ARRAY_EXT = 0x843A;
		public const int GL_CURRENT_TANGENT_EXT = 0x843B;
		public const int GL_CURRENT_BINORMAL_EXT = 0x843C;
		public const int GL_TANGENT_ARRAY_TYPE_EXT = 0x843E;
		public const int GL_TANGENT_ARRAY_STRIDE_EXT = 0x843F;
		public const int GL_BINORMAL_ARRAY_TYPE_EXT = 0x8440;
		public const int GL_BINORMAL_ARRAY_STRIDE_EXT = 0x8441;
		public const int GL_TANGENT_ARRAY_POINTER_EXT = 0x8442;
		public const int GL_BINORMAL_ARRAY_POINTER_EXT = 0x8443;
		public const int GL_MAP1_TANGENT_EXT = 0x8444;
		public const int GL_MAP2_TANGENT_EXT = 0x8445;
		public const int GL_MAP1_BINORMAL_EXT = 0x8446;
		public const int GL_MAP2_BINORMAL_EXT = 0x8447;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBinormalPointerEXT(uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTangentPointerEXT(uint type, int stride, IntPtr pointer);

 		static __glBinormalPointerEXT __GlueBinormalPointerEXT;
		static __glTangentPointerEXT __GlueTangentPointerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBinormalPointerEXT(uint type, int stride, IntPtr pointer) => __GlueBinormalPointerEXT(type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTangentPointerEXT(uint type, int stride, IntPtr pointer) => __GlueTangentPointerEXT(type, stride, pointer);



	}
}


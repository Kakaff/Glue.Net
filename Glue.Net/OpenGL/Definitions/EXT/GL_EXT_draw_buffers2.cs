using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_draw_buffers2 {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorMaskIndexedEXT(uint buf, bool r, bool g, bool b, bool a);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableIndexedEXT(uint target, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableIndexedEXT(uint target, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBooleanIndexedvEXT(uint value, uint index, bool* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetIntegerIndexedvEXT(uint value, uint index, int* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsEnabledIndexedEXT(uint target, uint index);

 		static __glColorMaskIndexedEXT __GlueColorMaskIndexedEXT;
		static __glDisableIndexedEXT __GlueDisableIndexedEXT;
		static __glEnableIndexedEXT __GlueEnableIndexedEXT;
		static __glGetBooleanIndexedvEXT __GlueGetBooleanIndexedvEXT;
		static __glGetIntegerIndexedvEXT __GlueGetIntegerIndexedvEXT;
		static __glIsEnabledIndexedEXT __GlueIsEnabledIndexedEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorMaskIndexedEXT(uint buf, bool r, bool g, bool b, bool a) => __GlueColorMaskIndexedEXT(buf, r, g, b, a);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableIndexedEXT(uint target, uint index) => __GlueDisableIndexedEXT(target, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableIndexedEXT(uint target, uint index) => __GlueEnableIndexedEXT(target, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBooleanIndexedvEXT(uint value, uint index, bool* data) => __GlueGetBooleanIndexedvEXT(value, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetIntegerIndexedvEXT(uint value, uint index, int* data) => __GlueGetIntegerIndexedvEXT(value, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsEnabledIndexedEXT(uint target, uint index) => __GlueIsEnabledIndexedEXT(target, index);



	}
}


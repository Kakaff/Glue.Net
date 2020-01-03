using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_compiled_vertex_array {get; private set;}

		public const int GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
		public const int GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLockArraysEXT(int first, int count);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUnlockArraysEXT( );

 		static __glLockArraysEXT __GlueLockArraysEXT;
		static __glUnlockArraysEXT __GlueUnlockArraysEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLockArraysEXT(int first, int count) => __GlueLockArraysEXT(first, count);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUnlockArraysEXT( ) => __GlueUnlockArraysEXT();



	}
}


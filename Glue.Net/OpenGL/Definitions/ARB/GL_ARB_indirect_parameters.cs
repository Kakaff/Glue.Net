using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_indirect_parameters {get; private set;}

		public const int GL_PARAMETER_BUFFER_ARB = 0x80EE;
		public const int GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawArraysIndirectCountARB(uint mode, IntPtr indirect, int drawcount, int maxdrawcount, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElementsIndirectCountARB(uint mode, uint type, IntPtr indirect, int drawcount, int maxdrawcount, int stride);

 		static __glMultiDrawArraysIndirectCountARB __GlueMultiDrawArraysIndirectCountARB;
		static __glMultiDrawElementsIndirectCountARB __GlueMultiDrawElementsIndirectCountARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawArraysIndirectCountARB(uint mode, IntPtr indirect, int drawcount, int maxdrawcount, int stride) => __GlueMultiDrawArraysIndirectCountARB(mode, indirect, drawcount, maxdrawcount, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElementsIndirectCountARB(uint mode, uint type, IntPtr indirect, int drawcount, int maxdrawcount, int stride) => __GlueMultiDrawElementsIndirectCountARB(mode, type, indirect, drawcount, maxdrawcount, stride);



	}
}


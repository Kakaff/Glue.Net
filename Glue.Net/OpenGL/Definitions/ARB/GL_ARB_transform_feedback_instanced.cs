using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_transform_feedback_instanced {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawTransformFeedbackInstanced(uint mode, uint id, int primcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int primcount);

 		static __glDrawTransformFeedbackInstanced __GlueDrawTransformFeedbackInstanced;
		static __glDrawTransformFeedbackStreamInstanced __GlueDrawTransformFeedbackStreamInstanced;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawTransformFeedbackInstanced(uint mode, uint id, int primcount) => __GlueDrawTransformFeedbackInstanced(mode, id, primcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int primcount) => __GlueDrawTransformFeedbackStreamInstanced(mode, id, stream, primcount);



	}
}


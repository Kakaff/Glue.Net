using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_transform_feedback2 {get; private set;}

		public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
		public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindTransformFeedback(uint target, uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteTransformFeedbacks(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawTransformFeedback(uint mode, uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenTransformFeedbacks(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsTransformFeedback(uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPauseTransformFeedback( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glResumeTransformFeedback( );

 		static __glBindTransformFeedback __GlueBindTransformFeedback;
		static __glDeleteTransformFeedbacks __GlueDeleteTransformFeedbacks;
		static __glDrawTransformFeedback __GlueDrawTransformFeedback;
		static __glGenTransformFeedbacks __GlueGenTransformFeedbacks;
		static __glIsTransformFeedback __GlueIsTransformFeedback;
		static __glPauseTransformFeedback __GluePauseTransformFeedback;
		static __glResumeTransformFeedback __GlueResumeTransformFeedback;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindTransformFeedback(uint target, uint id) => __GlueBindTransformFeedback(target, id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteTransformFeedbacks(int n, uint* ids) => __GlueDeleteTransformFeedbacks(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawTransformFeedback(uint mode, uint id) => __GlueDrawTransformFeedback(mode, id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenTransformFeedbacks(int n, uint* ids) => __GlueGenTransformFeedbacks(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsTransformFeedback(uint id) => __GlueIsTransformFeedback(id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPauseTransformFeedback( ) => __GluePauseTransformFeedback();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glResumeTransformFeedback( ) => __GlueResumeTransformFeedback();



	}
}


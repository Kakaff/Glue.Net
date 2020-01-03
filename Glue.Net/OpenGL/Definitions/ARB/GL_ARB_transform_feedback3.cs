using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_transform_feedback3 {get; private set;}

		public const int GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginQueryIndexed(uint target, uint index, uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawTransformFeedbackStream(uint mode, uint id, uint stream);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndQueryIndexed(uint target, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryIndexediv(uint target, uint index, uint pname, int* parameters);

 		static __glBeginQueryIndexed __GlueBeginQueryIndexed;
		static __glDrawTransformFeedbackStream __GlueDrawTransformFeedbackStream;
		static __glEndQueryIndexed __GlueEndQueryIndexed;
		static __glGetQueryIndexediv __GlueGetQueryIndexediv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginQueryIndexed(uint target, uint index, uint id) => __GlueBeginQueryIndexed(target, index, id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawTransformFeedbackStream(uint mode, uint id, uint stream) => __GlueDrawTransformFeedbackStream(mode, id, stream);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndQueryIndexed(uint target, uint index) => __GlueEndQueryIndexed(target, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryIndexediv(uint target, uint index, uint pname, int* parameters) => __GlueGetQueryIndexediv(target, index, pname, parameters);



	}
}


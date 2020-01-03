using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_transform_feedback {get; private set;}

		public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;
		public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;
		public const int GL_TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;
		public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;
		public const int GL_RASTERIZER_DISCARD_EXT = 0x8C89;
		public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;
		public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;
		public const int GL_INTERLEAVED_ATTRIBS_EXT = 0x8C8C;
		public const int GL_SEPARATE_ATTRIBS_EXT = 0x8C8D;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginTransformFeedbackEXT(uint primitiveMode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBufferBaseEXT(uint target, uint index, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBufferOffsetEXT(uint target, uint index, uint buffer, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBufferRangeEXT(uint target, uint index, uint buffer, int offset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndTransformFeedbackEXT( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTransformFeedbackVaryingsEXT(uint program, int count, char** varyings, uint bufferMode);

 		static __glBeginTransformFeedbackEXT __GlueBeginTransformFeedbackEXT;
		static __glBindBufferBaseEXT __GlueBindBufferBaseEXT;
		static __glBindBufferOffsetEXT __GlueBindBufferOffsetEXT;
		static __glBindBufferRangeEXT __GlueBindBufferRangeEXT;
		static __glEndTransformFeedbackEXT __GlueEndTransformFeedbackEXT;
		static __glGetTransformFeedbackVaryingEXT __GlueGetTransformFeedbackVaryingEXT;
		static __glTransformFeedbackVaryingsEXT __GlueTransformFeedbackVaryingsEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginTransformFeedbackEXT(uint primitiveMode) => __GlueBeginTransformFeedbackEXT(primitiveMode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBufferBaseEXT(uint target, uint index, uint buffer) => __GlueBindBufferBaseEXT(target, index, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBufferOffsetEXT(uint target, uint index, uint buffer, int offset) => __GlueBindBufferOffsetEXT(target, index, buffer, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBufferRangeEXT(uint target, uint index, uint buffer, int offset, int size) => __GlueBindBufferRangeEXT(target, index, buffer, offset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndTransformFeedbackEXT( ) => __GlueEndTransformFeedbackEXT();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTransformFeedbackVaryingEXT(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) => __GlueGetTransformFeedbackVaryingEXT(program, index, bufSize, length, size, type, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTransformFeedbackVaryingsEXT(uint program, int count, char** varyings, uint bufferMode) => __GlueTransformFeedbackVaryingsEXT(program, count, varyings, bufferMode);



	}
}


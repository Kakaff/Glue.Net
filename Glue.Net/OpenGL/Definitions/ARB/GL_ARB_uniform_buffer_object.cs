using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_uniform_buffer_object {get; private set;}

		public const int GL_UNIFORM_BUFFER = 0x8A11;
		public const int GL_UNIFORM_BUFFER_BINDING = 0x8A28;
		public const int GL_UNIFORM_BUFFER_START = 0x8A29;
		public const int GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
		public const int GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
		public const int GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
		public const int GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
		public const int GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
		public const int GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
		public const int GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
		public const int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
		public const int GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
		public const int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
		public const int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
		public const int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
		public const int GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
		public const int GL_UNIFORM_TYPE = 0x8A37;
		public const int GL_UNIFORM_SIZE = 0x8A38;
		public const int GL_UNIFORM_NAME_LENGTH = 0x8A39;
		public const int GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
		public const int GL_UNIFORM_OFFSET = 0x8A3B;
		public const int GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
		public const int GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
		public const int GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
		public const int GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
		public const int GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
		public const int GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
		public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
		public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
		public const uint GL_INVALID_INDEX = 0xFFFFFFFF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBufferBase(uint target, uint index, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBufferRange(uint target, uint index, uint buffer, int offset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetIntegeri_v(uint target, uint index, int* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetUniformBlockIndex(uint program, char* uniformBlockName);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

 		static __glBindBufferBase __GlueBindBufferBase;
		static __glBindBufferRange __GlueBindBufferRange;
		static __glGetActiveUniformBlockName __GlueGetActiveUniformBlockName;
		static __glGetActiveUniformBlockiv __GlueGetActiveUniformBlockiv;
		static __glGetActiveUniformName __GlueGetActiveUniformName;
		static __glGetActiveUniformsiv __GlueGetActiveUniformsiv;
		static __glGetIntegeri_v __GlueGetIntegeri_v;
		static __glGetUniformBlockIndex __GlueGetUniformBlockIndex;
		static __glGetUniformIndices __GlueGetUniformIndices;
		static __glUniformBlockBinding __GlueUniformBlockBinding;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBufferBase(uint target, uint index, uint buffer) => __GlueBindBufferBase(target, index, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBufferRange(uint target, uint index, uint buffer, int offset, int size) => __GlueBindBufferRange(target, index, buffer, offset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName) => __GlueGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* parameters) => __GlueGetActiveUniformBlockiv(program, uniformBlockIndex, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName) => __GlueGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* parameters) => __GlueGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetIntegeri_v(uint target, uint index, int* data) => __GlueGetIntegeri_v(target, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetUniformBlockIndex(uint program, char* uniformBlockName) => __GlueGetUniformBlockIndex(program, uniformBlockName);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformIndices(uint program, int uniformCount, char** uniformNames, uint* uniformIndices) => __GlueGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) => __GlueUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);



	}
}


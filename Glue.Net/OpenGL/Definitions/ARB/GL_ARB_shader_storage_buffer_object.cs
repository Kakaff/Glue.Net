using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_shader_storage_buffer_object {get; private set;}

		public const int GL_SHADER_STORAGE_BARRIER_BIT = 0x2000;
		public const int GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
		public const int GL_SHADER_STORAGE_BUFFER = 0x90D2;
		public const int GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
		public const int GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
		public const int GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
		public const int GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
		public const int GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
		public const int GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
		public const int GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
		public const int GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
		public const int GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
		public const int GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
		public const int GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
		public const int GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
		public const int GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

 		static __glShaderStorageBlockBinding __GlueShaderStorageBlockBinding;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) => __GlueShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);



	}
}


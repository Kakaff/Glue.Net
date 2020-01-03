using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_memory_object {get; private set;}

		public const int GL_UUID_SIZE_EXT = 16;
		public const int GL_TEXTURE_TILING_EXT = 0x9580;
		public const int GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581;
		public const int GL_NUM_TILING_TYPES_EXT = 0x9582;
		public const int GL_TILING_TYPES_EXT = 0x9583;
		public const int GL_OPTIMAL_TILING_EXT = 0x9584;
		public const int GL_LINEAR_TILING_EXT = 0x9585;
		public const int GL_LAYOUT_GENERAL_EXT = 0x958D;
		public const int GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E;
		public const int GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F;
		public const int GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590;
		public const int GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591;
		public const int GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592;
		public const int GL_LAYOUT_TRANSFER_DST_EXT = 0x9593;
		public const int GL_NUM_DEVICE_UUIDS_EXT = 0x9596;
		public const int GL_DEVICE_UUID_EXT = 0x9597;
		public const int GL_DRIVER_UUID_EXT = 0x9598;
		public const int GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBufferStorageMemEXT(uint target, int size, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateMemoryObjectsEXT(int n, uint* memoryObjects);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteMemoryObjectsEXT(int n, uint* memoryObjects);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMemoryObjectParameterivEXT(uint memoryObject, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUnsignedBytei_vEXT(uint target, uint index, byte* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUnsignedBytevEXT(uint pname, byte* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsMemoryObjectEXT(uint memoryObject);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMemoryObjectParameterivEXT(uint memoryObject, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferStorageMemEXT(uint buffer, int size, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorageMem1DEXT(uint target, int levels, uint internalFormat, int width, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorageMem2DEXT(uint target, int levels, uint internalFormat, int width, int height, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorageMem2DMultisampleEXT(uint target, int samples, uint internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorageMem3DEXT(uint target, int levels, uint internalFormat, int width, int height, int depth, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexStorageMem3DMultisampleEXT(uint target, int samples, uint internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorageMem1DEXT(uint texture, int levels, uint internalFormat, int width, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorageMem2DEXT(uint texture, int levels, uint internalFormat, int width, int height, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorageMem2DMultisampleEXT(uint texture, int samples, uint internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorageMem3DEXT(uint texture, int levels, uint internalFormat, int width, int height, int depth, uint memory, ulong offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorageMem3DMultisampleEXT(uint texture, int samples, uint internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset);

 		static __glBufferStorageMemEXT __GlueBufferStorageMemEXT;
		static __glCreateMemoryObjectsEXT __GlueCreateMemoryObjectsEXT;
		static __glDeleteMemoryObjectsEXT __GlueDeleteMemoryObjectsEXT;
		static __glGetMemoryObjectParameterivEXT __GlueGetMemoryObjectParameterivEXT;
		static __glGetUnsignedBytei_vEXT __GlueGetUnsignedBytei_vEXT;
		static __glGetUnsignedBytevEXT __GlueGetUnsignedBytevEXT;
		static __glIsMemoryObjectEXT __GlueIsMemoryObjectEXT;
		static __glMemoryObjectParameterivEXT __GlueMemoryObjectParameterivEXT;
		static __glNamedBufferStorageMemEXT __GlueNamedBufferStorageMemEXT;
		static __glTexStorageMem1DEXT __GlueTexStorageMem1DEXT;
		static __glTexStorageMem2DEXT __GlueTexStorageMem2DEXT;
		static __glTexStorageMem2DMultisampleEXT __GlueTexStorageMem2DMultisampleEXT;
		static __glTexStorageMem3DEXT __GlueTexStorageMem3DEXT;
		static __glTexStorageMem3DMultisampleEXT __GlueTexStorageMem3DMultisampleEXT;
		static __glTextureStorageMem1DEXT __GlueTextureStorageMem1DEXT;
		static __glTextureStorageMem2DEXT __GlueTextureStorageMem2DEXT;
		static __glTextureStorageMem2DMultisampleEXT __GlueTextureStorageMem2DMultisampleEXT;
		static __glTextureStorageMem3DEXT __GlueTextureStorageMem3DEXT;
		static __glTextureStorageMem3DMultisampleEXT __GlueTextureStorageMem3DMultisampleEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBufferStorageMemEXT(uint target, int size, uint memory, ulong offset) => __GlueBufferStorageMemEXT(target, size, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateMemoryObjectsEXT(int n, uint* memoryObjects) => __GlueCreateMemoryObjectsEXT(n, memoryObjects);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteMemoryObjectsEXT(int n, uint* memoryObjects) => __GlueDeleteMemoryObjectsEXT(n, memoryObjects);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMemoryObjectParameterivEXT(uint memoryObject, uint pname, int* parameters) => __GlueGetMemoryObjectParameterivEXT(memoryObject, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUnsignedBytei_vEXT(uint target, uint index, byte* data) => __GlueGetUnsignedBytei_vEXT(target, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUnsignedBytevEXT(uint pname, byte* data) => __GlueGetUnsignedBytevEXT(pname, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsMemoryObjectEXT(uint memoryObject) => __GlueIsMemoryObjectEXT(memoryObject);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMemoryObjectParameterivEXT(uint memoryObject, uint pname, int* parameters) => __GlueMemoryObjectParameterivEXT(memoryObject, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferStorageMemEXT(uint buffer, int size, uint memory, ulong offset) => __GlueNamedBufferStorageMemEXT(buffer, size, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorageMem1DEXT(uint target, int levels, uint internalFormat, int width, uint memory, ulong offset) => __GlueTexStorageMem1DEXT(target, levels, internalFormat, width, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorageMem2DEXT(uint target, int levels, uint internalFormat, int width, int height, uint memory, ulong offset) => __GlueTexStorageMem2DEXT(target, levels, internalFormat, width, height, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorageMem2DMultisampleEXT(uint target, int samples, uint internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => __GlueTexStorageMem2DMultisampleEXT(target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorageMem3DEXT(uint target, int levels, uint internalFormat, int width, int height, int depth, uint memory, ulong offset) => __GlueTexStorageMem3DEXT(target, levels, internalFormat, width, height, depth, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexStorageMem3DMultisampleEXT(uint target, int samples, uint internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => __GlueTexStorageMem3DMultisampleEXT(target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorageMem1DEXT(uint texture, int levels, uint internalFormat, int width, uint memory, ulong offset) => __GlueTextureStorageMem1DEXT(texture, levels, internalFormat, width, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorageMem2DEXT(uint texture, int levels, uint internalFormat, int width, int height, uint memory, ulong offset) => __GlueTextureStorageMem2DEXT(texture, levels, internalFormat, width, height, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorageMem2DMultisampleEXT(uint texture, int samples, uint internalFormat, int width, int height, bool fixedSampleLocations, uint memory, ulong offset) => __GlueTextureStorageMem2DMultisampleEXT(texture, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorageMem3DEXT(uint texture, int levels, uint internalFormat, int width, int height, int depth, uint memory, ulong offset) => __GlueTextureStorageMem3DEXT(texture, levels, internalFormat, width, height, depth, memory, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorageMem3DMultisampleEXT(uint texture, int samples, uint internalFormat, int width, int height, int depth, bool fixedSampleLocations, uint memory, ulong offset) => __GlueTextureStorageMem3DMultisampleEXT(texture, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);



	}
}


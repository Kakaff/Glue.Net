using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_memory_object_win32 {get; private set;}

		public const int GL_LUID_SIZE_EXT = 8;
		public const int GL_HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587;
		public const int GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588;
		public const int GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589;
		public const int GL_HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A;
		public const int GL_HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B;
		public const int GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C;
		public const int GL_HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594;
		public const int GL_D3D12_FENCE_VALUE_EXT = 0x9595;
		public const int GL_DEVICE_LUID_EXT = 0x9599;
		public const int GL_DEVICE_NODE_MASK_EXT = 0x959A;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glImportMemoryWin32HandleEXT(uint memory, ulong size, uint handleType, IntPtr handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glImportMemoryWin32NameEXT(uint memory, ulong size, uint handleType, IntPtr name);

 		static __glImportMemoryWin32HandleEXT __GlueImportMemoryWin32HandleEXT;
		static __glImportMemoryWin32NameEXT __GlueImportMemoryWin32NameEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glImportMemoryWin32HandleEXT(uint memory, ulong size, uint handleType, IntPtr handle) => __GlueImportMemoryWin32HandleEXT(memory, size, handleType, handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glImportMemoryWin32NameEXT(uint memory, ulong size, uint handleType, IntPtr name) => __GlueImportMemoryWin32NameEXT(memory, size, handleType, name);



	}
}


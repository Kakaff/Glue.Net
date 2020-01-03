using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_semaphore {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteSemaphoresEXT(int n, uint* semaphores);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenSemaphoresEXT(int n, uint* semaphores);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSemaphoreParameterui64vEXT(uint semaphore, uint pname, ulong* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsSemaphoreEXT(uint semaphore);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSemaphoreParameterui64vEXT(uint semaphore, uint pname, ulong* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* dstLayouts);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* srcLayouts);

 		static __glDeleteSemaphoresEXT __GlueDeleteSemaphoresEXT;
		static __glGenSemaphoresEXT __GlueGenSemaphoresEXT;
		static __glGetSemaphoreParameterui64vEXT __GlueGetSemaphoreParameterui64vEXT;
		static __glIsSemaphoreEXT __GlueIsSemaphoreEXT;
		static __glSemaphoreParameterui64vEXT __GlueSemaphoreParameterui64vEXT;
		static __glSignalSemaphoreEXT __GlueSignalSemaphoreEXT;
		static __glWaitSemaphoreEXT __GlueWaitSemaphoreEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteSemaphoresEXT(int n, uint* semaphores) => __GlueDeleteSemaphoresEXT(n, semaphores);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenSemaphoresEXT(int n, uint* semaphores) => __GlueGenSemaphoresEXT(n, semaphores);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSemaphoreParameterui64vEXT(uint semaphore, uint pname, ulong* parameters) => __GlueGetSemaphoreParameterui64vEXT(semaphore, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsSemaphoreEXT(uint semaphore) => __GlueIsSemaphoreEXT(semaphore);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSemaphoreParameterui64vEXT(uint semaphore, uint pname, ulong* parameters) => __GlueSemaphoreParameterui64vEXT(semaphore, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* dstLayouts) => __GlueSignalSemaphoreEXT(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, uint* srcLayouts) => __GlueWaitSemaphoreEXT(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);



	}
}


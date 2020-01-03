using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_multi_bind {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBuffersBase(uint target, uint first, int count, uint* buffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindBuffersRange(uint target, uint first, int count, uint* buffers, int* offsets, int* sizes);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindImageTextures(uint first, int count, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindSamplers(uint first, int count, uint* samplers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindTextures(uint first, int count, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindVertexBuffers(uint first, int count, uint* buffers, int* offsets, int* strides);

 		static __glBindBuffersBase __GlueBindBuffersBase;
		static __glBindBuffersRange __GlueBindBuffersRange;
		static __glBindImageTextures __GlueBindImageTextures;
		static __glBindSamplers __GlueBindSamplers;
		static __glBindTextures __GlueBindTextures;
		static __glBindVertexBuffers __GlueBindVertexBuffers;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBuffersBase(uint target, uint first, int count, uint* buffers) => __GlueBindBuffersBase(target, first, count, buffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindBuffersRange(uint target, uint first, int count, uint* buffers, int* offsets, int* sizes) => __GlueBindBuffersRange(target, first, count, buffers, offsets, sizes);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindImageTextures(uint first, int count, uint* textures) => __GlueBindImageTextures(first, count, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindSamplers(uint first, int count, uint* samplers) => __GlueBindSamplers(first, count, samplers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindTextures(uint first, int count, uint* textures) => __GlueBindTextures(first, count, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindVertexBuffers(uint first, int count, uint* buffers, int* offsets, int* strides) => __GlueBindVertexBuffers(first, count, buffers, offsets, strides);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_invalidate_subdata {get; private set;}

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateBufferData(uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateBufferSubData(uint buffer, int offset, int length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateTexImage(uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

 		static __glInvalidateBufferData __GlueInvalidateBufferData;
		static __glInvalidateBufferSubData __GlueInvalidateBufferSubData;
		static __glInvalidateFramebuffer __GlueInvalidateFramebuffer;
		static __glInvalidateSubFramebuffer __GlueInvalidateSubFramebuffer;
		static __glInvalidateTexImage __GlueInvalidateTexImage;
		static __glInvalidateTexSubImage __GlueInvalidateTexSubImage;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateBufferData(uint buffer) => __GlueInvalidateBufferData(buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateBufferSubData(uint buffer, int offset, int length) => __GlueInvalidateBufferSubData(buffer, offset, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments) => __GlueInvalidateFramebuffer(target, numAttachments, attachments);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) => __GlueInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateTexImage(uint texture, int level) => __GlueInvalidateTexImage(texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) => __GlueInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);



	}
}


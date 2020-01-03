using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_framebuffer_object {get; private set;}

		public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
		public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
		public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
		public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
		public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
		public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
		public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
		public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
		public const int GL_FRAMEBUFFER_DEFAULT = 0x8218;
		public const int GL_FRAMEBUFFER_UNDEFINED = 0x8219;
		public const int GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
		public const int GL_INDEX = 0x8222;
		public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
		public const int GL_DEPTH_STENCIL = 0x84F9;
		public const int GL_UNSIGNED_INT_24_8 = 0x84FA;
		public const int GL_DEPTH24_STENCIL8 = 0x88F0;
		public const int GL_TEXTURE_STENCIL_SIZE = 0x88F1;
		public const int GL_UNSIGNED_NORMALIZED = 0x8C17;
		public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
		public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
		public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
		public const int GL_READ_FRAMEBUFFER = 0x8CA8;
		public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
		public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
		public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;
		public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
		public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
		public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
		public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
		public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
		public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
		public const int GL_COLOR_ATTACHMENT1 = 0x8CE1;
		public const int GL_COLOR_ATTACHMENT2 = 0x8CE2;
		public const int GL_COLOR_ATTACHMENT3 = 0x8CE3;
		public const int GL_COLOR_ATTACHMENT4 = 0x8CE4;
		public const int GL_COLOR_ATTACHMENT5 = 0x8CE5;
		public const int GL_COLOR_ATTACHMENT6 = 0x8CE6;
		public const int GL_COLOR_ATTACHMENT7 = 0x8CE7;
		public const int GL_COLOR_ATTACHMENT8 = 0x8CE8;
		public const int GL_COLOR_ATTACHMENT9 = 0x8CE9;
		public const int GL_COLOR_ATTACHMENT10 = 0x8CEA;
		public const int GL_COLOR_ATTACHMENT11 = 0x8CEB;
		public const int GL_COLOR_ATTACHMENT12 = 0x8CEC;
		public const int GL_COLOR_ATTACHMENT13 = 0x8CED;
		public const int GL_COLOR_ATTACHMENT14 = 0x8CEE;
		public const int GL_COLOR_ATTACHMENT15 = 0x8CEF;
		public const int GL_DEPTH_ATTACHMENT = 0x8D00;
		public const int GL_STENCIL_ATTACHMENT = 0x8D20;
		public const int GL_FRAMEBUFFER = 0x8D40;
		public const int GL_RENDERBUFFER = 0x8D41;
		public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
		public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
		public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		public const int GL_STENCIL_INDEX1 = 0x8D46;
		public const int GL_STENCIL_INDEX4 = 0x8D47;
		public const int GL_STENCIL_INDEX8 = 0x8D48;
		public const int GL_STENCIL_INDEX16 = 0x8D49;
		public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
		public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
		public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
		public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
		public const int GL_MAX_SAMPLES = 0x8D57;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindFramebuffer(uint target, uint framebuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindRenderbuffer(uint target, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCheckFramebufferStatus(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteFramebuffers(int n, uint* framebuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteRenderbuffers(int n, uint* renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int layer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenFramebuffers(int n, uint* framebuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenRenderbuffers(int n, uint* renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenerateMipmap(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetRenderbufferParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsFramebuffer(uint framebuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsRenderbuffer(uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRenderbufferStorage(uint target, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);

 		static __glBindFramebuffer __GlueBindFramebuffer;
		static __glBindRenderbuffer __GlueBindRenderbuffer;
		static __glBlitFramebuffer __GlueBlitFramebuffer;
		static __glCheckFramebufferStatus __GlueCheckFramebufferStatus;
		static __glDeleteFramebuffers __GlueDeleteFramebuffers;
		static __glDeleteRenderbuffers __GlueDeleteRenderbuffers;
		static __glFramebufferRenderbuffer __GlueFramebufferRenderbuffer;
		static __glFramebufferTexture1D __GlueFramebufferTexture1D;
		static __glFramebufferTexture2D __GlueFramebufferTexture2D;
		static __glFramebufferTexture3D __GlueFramebufferTexture3D;
		static __glFramebufferTextureLayer __GlueFramebufferTextureLayer;
		static __glGenFramebuffers __GlueGenFramebuffers;
		static __glGenRenderbuffers __GlueGenRenderbuffers;
		static __glGenerateMipmap __GlueGenerateMipmap;
		static __glGetFramebufferAttachmentParameteriv __GlueGetFramebufferAttachmentParameteriv;
		static __glGetRenderbufferParameteriv __GlueGetRenderbufferParameteriv;
		static __glIsFramebuffer __GlueIsFramebuffer;
		static __glIsRenderbuffer __GlueIsRenderbuffer;
		static __glRenderbufferStorage __GlueRenderbufferStorage;
		static __glRenderbufferStorageMultisample __GlueRenderbufferStorageMultisample;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindFramebuffer(uint target, uint framebuffer) => __GlueBindFramebuffer(target, framebuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindRenderbuffer(uint target, uint renderbuffer) => __GlueBindRenderbuffer(target, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) => __GlueBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCheckFramebufferStatus(uint target) => __GlueCheckFramebufferStatus(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteFramebuffers(int n, uint* framebuffers) => __GlueDeleteFramebuffers(n, framebuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteRenderbuffers(int n, uint* renderbuffers) => __GlueDeleteRenderbuffers(n, renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) => __GlueFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) => __GlueFramebufferTexture1D(target, attachment, textarget, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) => __GlueFramebufferTexture2D(target, attachment, textarget, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int layer) => __GlueFramebufferTexture3D(target, attachment, textarget, texture, level, layer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) => __GlueFramebufferTextureLayer(target, attachment, texture, level, layer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenFramebuffers(int n, uint* framebuffers) => __GlueGenFramebuffers(n, framebuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenRenderbuffers(int n, uint* renderbuffers) => __GlueGenRenderbuffers(n, renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenerateMipmap(uint target) => __GlueGenerateMipmap(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* parameters) => __GlueGetFramebufferAttachmentParameteriv(target, attachment, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetRenderbufferParameteriv(uint target, uint pname, int* parameters) => __GlueGetRenderbufferParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsFramebuffer(uint framebuffer) => __GlueIsFramebuffer(framebuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsRenderbuffer(uint renderbuffer) => __GlueIsRenderbuffer(renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRenderbufferStorage(uint target, uint internalformat, int width, int height) => __GlueRenderbufferStorage(target, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) => __GlueRenderbufferStorageMultisample(target, samples, internalformat, width, height);



	}
}


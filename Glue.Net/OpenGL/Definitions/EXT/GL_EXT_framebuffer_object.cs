using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_framebuffer_object {get; private set;}

		public const int GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506;
		public const int GL_MAX_RENDERBUFFER_SIZE_EXT = 0x84E8;
		public const int GL_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
		public const int GL_RENDERBUFFER_BINDING_EXT = 0x8CA7;
		public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0;
		public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3;
		public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;
		public const int GL_FRAMEBUFFER_COMPLETE_EXT = 0x8CD5;
		public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;
		public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;
		public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;
		public const int GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;
		public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;
		public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;
		public const int GL_FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD;
		public const int GL_DEPTH_ATTACHMENT_EXT = 0x8D00;
		public const int GL_STENCIL_ATTACHMENT_EXT = 0x8D20;
		public const int GL_FRAMEBUFFER_EXT = 0x8D40;
		public const int GL_RENDERBUFFER_EXT = 0x8D41;
		public const int GL_RENDERBUFFER_WIDTH_EXT = 0x8D42;
		public const int GL_RENDERBUFFER_HEIGHT_EXT = 0x8D43;
		public const int GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44;
		public const int GL_STENCIL_INDEX1_EXT = 0x8D46;
		public const int GL_STENCIL_INDEX4_EXT = 0x8D47;
		public const int GL_STENCIL_INDEX8_EXT = 0x8D48;
		public const int GL_STENCIL_INDEX16_EXT = 0x8D49;
		public const int GL_RENDERBUFFER_RED_SIZE_EXT = 0x8D50;
		public const int GL_RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51;
		public const int GL_RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52;
		public const int GL_RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53;
		public const int GL_RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54;
		public const int GL_RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindFramebufferEXT(uint target, uint framebuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindRenderbufferEXT(uint target, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCheckFramebufferStatusEXT(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteFramebuffersEXT(int n, uint* framebuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteRenderbuffersEXT(int n, uint* renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenFramebuffersEXT(int n, uint* framebuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenRenderbuffersEXT(int n, uint* renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenerateMipmapEXT(uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetRenderbufferParameterivEXT(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsFramebufferEXT(uint framebuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsRenderbufferEXT(uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRenderbufferStorageEXT(uint target, uint internalformat, int width, int height);

 		static __glBindFramebufferEXT __GlueBindFramebufferEXT;
		static __glBindRenderbufferEXT __GlueBindRenderbufferEXT;
		static __glCheckFramebufferStatusEXT __GlueCheckFramebufferStatusEXT;
		static __glDeleteFramebuffersEXT __GlueDeleteFramebuffersEXT;
		static __glDeleteRenderbuffersEXT __GlueDeleteRenderbuffersEXT;
		static __glFramebufferRenderbufferEXT __GlueFramebufferRenderbufferEXT;
		static __glFramebufferTexture1DEXT __GlueFramebufferTexture1DEXT;
		static __glFramebufferTexture2DEXT __GlueFramebufferTexture2DEXT;
		static __glFramebufferTexture3DEXT __GlueFramebufferTexture3DEXT;
		static __glGenFramebuffersEXT __GlueGenFramebuffersEXT;
		static __glGenRenderbuffersEXT __GlueGenRenderbuffersEXT;
		static __glGenerateMipmapEXT __GlueGenerateMipmapEXT;
		static __glGetFramebufferAttachmentParameterivEXT __GlueGetFramebufferAttachmentParameterivEXT;
		static __glGetRenderbufferParameterivEXT __GlueGetRenderbufferParameterivEXT;
		static __glIsFramebufferEXT __GlueIsFramebufferEXT;
		static __glIsRenderbufferEXT __GlueIsRenderbufferEXT;
		static __glRenderbufferStorageEXT __GlueRenderbufferStorageEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindFramebufferEXT(uint target, uint framebuffer) => __GlueBindFramebufferEXT(target, framebuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindRenderbufferEXT(uint target, uint renderbuffer) => __GlueBindRenderbufferEXT(target, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCheckFramebufferStatusEXT(uint target) => __GlueCheckFramebufferStatusEXT(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteFramebuffersEXT(int n, uint* framebuffers) => __GlueDeleteFramebuffersEXT(n, framebuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteRenderbuffersEXT(int n, uint* renderbuffers) => __GlueDeleteRenderbuffersEXT(n, renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferRenderbufferEXT(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) => __GlueFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture1DEXT(uint target, uint attachment, uint textarget, uint texture, int level) => __GlueFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture2DEXT(uint target, uint attachment, uint textarget, uint texture, int level) => __GlueFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferTexture3DEXT(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) => __GlueFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenFramebuffersEXT(int n, uint* framebuffers) => __GlueGenFramebuffersEXT(n, framebuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenRenderbuffersEXT(int n, uint* renderbuffers) => __GlueGenRenderbuffersEXT(n, renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenerateMipmapEXT(uint target) => __GlueGenerateMipmapEXT(target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFramebufferAttachmentParameterivEXT(uint target, uint attachment, uint pname, int* parameters) => __GlueGetFramebufferAttachmentParameterivEXT(target, attachment, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetRenderbufferParameterivEXT(uint target, uint pname, int* parameters) => __GlueGetRenderbufferParameterivEXT(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsFramebufferEXT(uint framebuffer) => __GlueIsFramebufferEXT(framebuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsRenderbufferEXT(uint renderbuffer) => __GlueIsRenderbufferEXT(renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRenderbufferStorageEXT(uint target, uint internalformat, int width, int height) => __GlueRenderbufferStorageEXT(target, internalformat, width, height);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_framebuffer_no_attachments {get; private set;}

		public const int GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
		public const int GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
		public const int GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
		public const int GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
		public const int GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
		public const int GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
		public const int GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
		public const int GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
		public const int GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferParameteri(uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFramebufferParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedFramebufferParameterivEXT(uint framebuffer, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferParameteriEXT(uint framebuffer, uint pname, int param);

 		static __glFramebufferParameteri __GlueFramebufferParameteri;
		static __glGetFramebufferParameteriv __GlueGetFramebufferParameteriv;
		static __glGetNamedFramebufferParameterivEXT __GlueGetNamedFramebufferParameterivEXT;
		static __glNamedFramebufferParameteriEXT __GlueNamedFramebufferParameteriEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferParameteri(uint target, uint pname, int param) => __GlueFramebufferParameteri(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFramebufferParameteriv(uint target, uint pname, int* parameters) => __GlueGetFramebufferParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedFramebufferParameterivEXT(uint framebuffer, uint pname, int* parameters) => __GlueGetNamedFramebufferParameterivEXT(framebuffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferParameteriEXT(uint framebuffer, uint pname, int param) => __GlueNamedFramebufferParameteriEXT(framebuffer, pname, param);



	}
}


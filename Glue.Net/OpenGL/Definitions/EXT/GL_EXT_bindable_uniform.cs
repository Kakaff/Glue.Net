using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_bindable_uniform {get; private set;}

		public const int GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
		public const int GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
		public const int GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
		public const int GL_MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
		public const int GL_UNIFORM_BUFFER_EXT = 0x8DEE;
		public const int GL_UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetUniformBufferSizeEXT(uint program, int location);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetUniformOffsetEXT(uint program, int location);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformBufferEXT(uint program, int location, uint buffer);

 		static __glGetUniformBufferSizeEXT __GlueGetUniformBufferSizeEXT;
		static __glGetUniformOffsetEXT __GlueGetUniformOffsetEXT;
		static __glUniformBufferEXT __GlueUniformBufferEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetUniformBufferSizeEXT(uint program, int location) => __GlueGetUniformBufferSizeEXT(program, location);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetUniformOffsetEXT(uint program, int location) => __GlueGetUniformOffsetEXT(program, location);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformBufferEXT(uint program, int location, uint buffer) => __GlueUniformBufferEXT(program, location, buffer);



	}
}


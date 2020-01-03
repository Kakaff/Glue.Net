using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_compute_shader {get; private set;}

		public const int GL_COMPUTE_SHADER_BIT = 0x00000020;
		public const int GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
		public const int GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
		public const int GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
		public const int GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
		public const int GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
		public const int GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
		public const int GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
		public const int GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
		public const int GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
		public const int GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
		public const int GL_COMPUTE_SHADER = 0x91B9;
		public const int GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
		public const int GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
		public const int GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
		public const int GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
		public const int GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDispatchComputeIndirect(int indirect);

 		static __glDispatchCompute __GlueDispatchCompute;
		static __glDispatchComputeIndirect __GlueDispatchComputeIndirect;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) => __GlueDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDispatchComputeIndirect(int indirect) => __GlueDispatchComputeIndirect(indirect);



	}
}


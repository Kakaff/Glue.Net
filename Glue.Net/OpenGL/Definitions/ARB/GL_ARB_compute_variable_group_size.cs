using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_compute_variable_group_size {get; private set;}

		public const int GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
		public const int GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
		public const int GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
		public const int GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);

 		static __glDispatchComputeGroupSizeARB __GlueDispatchComputeGroupSizeARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDispatchComputeGroupSizeARB(uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z) => __GlueDispatchComputeGroupSizeARB(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);



	}
}


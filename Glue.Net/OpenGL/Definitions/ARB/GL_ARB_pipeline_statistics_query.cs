using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_pipeline_statistics_query {get; private set;}

		public const int GL_VERTICES_SUBMITTED_ARB = 0x82EE;
		public const int GL_PRIMITIVES_SUBMITTED_ARB = 0x82EF;
		public const int GL_VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;
		public const int GL_TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;
		public const int GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;
		public const int GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;
		public const int GL_FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;
		public const int GL_COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;
		public const int GL_CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;
		public const int GL_CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;

   

	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_query_buffer_object {get; private set;}

		public const int GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000;
		public const int GL_QUERY_BUFFER = 0x9192;
		public const int GL_QUERY_BUFFER_BINDING = 0x9193;
		public const int GL_QUERY_RESULT_NO_WAIT = 0x9194;

   

	}
}


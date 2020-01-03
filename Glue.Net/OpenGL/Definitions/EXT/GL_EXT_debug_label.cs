using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_debug_label {get; private set;}

		public const int GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;
		public const int GL_PROGRAM_OBJECT_EXT = 0x8B40;
		public const int GL_SHADER_OBJECT_EXT = 0x8B48;
		public const int GL_BUFFER_OBJECT_EXT = 0x9151;
		public const int GL_QUERY_OBJECT_EXT = 0x9153;
		public const int GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetObjectLabelEXT(uint type, uint obj, int bufSize, int* length, char* label);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLabelObjectEXT(uint type, uint obj, int length, char* label);

 		static __glGetObjectLabelEXT __GlueGetObjectLabelEXT;
		static __glLabelObjectEXT __GlueLabelObjectEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetObjectLabelEXT(uint type, uint obj, int bufSize, int* length, char* label) => __GlueGetObjectLabelEXT(type, obj, bufSize, length, label);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLabelObjectEXT(uint type, uint obj, int length, char* label) => __GlueLabelObjectEXT(type, obj, length, label);



	}
}


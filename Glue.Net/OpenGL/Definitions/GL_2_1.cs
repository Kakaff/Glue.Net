using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_2_1 {get; private set;}

		public const int GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
		public const int GL_PIXEL_PACK_BUFFER = 0x88EB;
		public const int GL_PIXEL_UNPACK_BUFFER = 0x88EC;
		public const int GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
		public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
		public const int GL_FLOAT_MAT2x3 = 0x8B65;
		public const int GL_FLOAT_MAT2x4 = 0x8B66;
		public const int GL_FLOAT_MAT3x2 = 0x8B67;
		public const int GL_FLOAT_MAT3x4 = 0x8B68;
		public const int GL_FLOAT_MAT4x2 = 0x8B69;
		public const int GL_FLOAT_MAT4x3 = 0x8B6A;
		public const int GL_SRGB = 0x8C40;
		public const int GL_SRGB8 = 0x8C41;
		public const int GL_SRGB_ALPHA = 0x8C42;
		public const int GL_SRGB8_ALPHA8 = 0x8C43;
		public const int GL_SLUMINANCE_ALPHA = 0x8C44;
		public const int GL_SLUMINANCE8_ALPHA8 = 0x8C45;
		public const int GL_SLUMINANCE = 0x8C46;
		public const int GL_SLUMINANCE8 = 0x8C47;
		public const int GL_COMPRESSED_SRGB = 0x8C48;
		public const int GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
		public const int GL_COMPRESSED_SLUMINANCE = 0x8C4A;
		public const int GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2x3fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix2x4fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3x2fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix3x4fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4x2fv(int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformMatrix4x3fv(int location, int count, bool transpose, float* value);

 		static __glUniformMatrix2x3fv __GlueUniformMatrix2x3fv;
		static __glUniformMatrix2x4fv __GlueUniformMatrix2x4fv;
		static __glUniformMatrix3x2fv __GlueUniformMatrix3x2fv;
		static __glUniformMatrix3x4fv __GlueUniformMatrix3x4fv;
		static __glUniformMatrix4x2fv __GlueUniformMatrix4x2fv;
		static __glUniformMatrix4x3fv __GlueUniformMatrix4x3fv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2x3fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix2x3fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix2x4fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix2x4fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3x2fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix3x2fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix3x4fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix3x4fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4x2fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix4x2fv(location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformMatrix4x3fv(int location, int count, bool transpose, float* value) => __GlueUniformMatrix4x3fv(location, count, transpose, value);



	}
}


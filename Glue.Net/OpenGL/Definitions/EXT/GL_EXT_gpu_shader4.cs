using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_gpu_shader4 {get; private set;}

		public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD;
		public const int GL_SAMPLER_1D_ARRAY_EXT = 0x8DC0;
		public const int GL_SAMPLER_2D_ARRAY_EXT = 0x8DC1;
		public const int GL_SAMPLER_BUFFER_EXT = 0x8DC2;
		public const int GL_SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3;
		public const int GL_SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4;
		public const int GL_SAMPLER_CUBE_SHADOW_EXT = 0x8DC5;
		public const int GL_UNSIGNED_INT_VEC2_EXT = 0x8DC6;
		public const int GL_UNSIGNED_INT_VEC3_EXT = 0x8DC7;
		public const int GL_UNSIGNED_INT_VEC4_EXT = 0x8DC8;
		public const int GL_INT_SAMPLER_1D_EXT = 0x8DC9;
		public const int GL_INT_SAMPLER_2D_EXT = 0x8DCA;
		public const int GL_INT_SAMPLER_3D_EXT = 0x8DCB;
		public const int GL_INT_SAMPLER_CUBE_EXT = 0x8DCC;
		public const int GL_INT_SAMPLER_2D_RECT_EXT = 0x8DCD;
		public const int GL_INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE;
		public const int GL_INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF;
		public const int GL_INT_SAMPLER_BUFFER_EXT = 0x8DD0;
		public const int GL_UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2;
		public const int GL_UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3;
		public const int GL_UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;
		public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;
		public const int GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindFragDataLocationEXT(uint program, uint color, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetFragDataLocationEXT(uint program, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformuivEXT(uint program, int location, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribIivEXT(uint index, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribIuivEXT(uint index, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1uiEXT(int location, uint v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1uivEXT(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2uiEXT(int location, uint v0, uint v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2uivEXT(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3uiEXT(int location, uint v0, uint v1, uint v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3uivEXT(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4uivEXT(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1iEXT(uint index, int x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1ivEXT(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1uiEXT(uint index, uint x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1uivEXT(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2iEXT(uint index, int x, int y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2ivEXT(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2uiEXT(uint index, uint x, uint y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2uivEXT(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3iEXT(uint index, int x, int y, int z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3ivEXT(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3uiEXT(uint index, uint x, uint y, uint z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3uivEXT(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4bvEXT(uint index, sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4iEXT(uint index, int x, int y, int z, int w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4ivEXT(uint index, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4svEXT(uint index, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4ubvEXT(uint index, byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4uivEXT(uint index, uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4usvEXT(uint index, ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribIPointerEXT(uint index, int size, uint type, int stride, IntPtr pointer);

 		static __glBindFragDataLocationEXT __GlueBindFragDataLocationEXT;
		static __glGetFragDataLocationEXT __GlueGetFragDataLocationEXT;
		static __glGetUniformuivEXT __GlueGetUniformuivEXT;
		static __glGetVertexAttribIivEXT __GlueGetVertexAttribIivEXT;
		static __glGetVertexAttribIuivEXT __GlueGetVertexAttribIuivEXT;
		static __glUniform1uiEXT __GlueUniform1uiEXT;
		static __glUniform1uivEXT __GlueUniform1uivEXT;
		static __glUniform2uiEXT __GlueUniform2uiEXT;
		static __glUniform2uivEXT __GlueUniform2uivEXT;
		static __glUniform3uiEXT __GlueUniform3uiEXT;
		static __glUniform3uivEXT __GlueUniform3uivEXT;
		static __glUniform4uiEXT __GlueUniform4uiEXT;
		static __glUniform4uivEXT __GlueUniform4uivEXT;
		static __glVertexAttribI1iEXT __GlueVertexAttribI1iEXT;
		static __glVertexAttribI1ivEXT __GlueVertexAttribI1ivEXT;
		static __glVertexAttribI1uiEXT __GlueVertexAttribI1uiEXT;
		static __glVertexAttribI1uivEXT __GlueVertexAttribI1uivEXT;
		static __glVertexAttribI2iEXT __GlueVertexAttribI2iEXT;
		static __glVertexAttribI2ivEXT __GlueVertexAttribI2ivEXT;
		static __glVertexAttribI2uiEXT __GlueVertexAttribI2uiEXT;
		static __glVertexAttribI2uivEXT __GlueVertexAttribI2uivEXT;
		static __glVertexAttribI3iEXT __GlueVertexAttribI3iEXT;
		static __glVertexAttribI3ivEXT __GlueVertexAttribI3ivEXT;
		static __glVertexAttribI3uiEXT __GlueVertexAttribI3uiEXT;
		static __glVertexAttribI3uivEXT __GlueVertexAttribI3uivEXT;
		static __glVertexAttribI4bvEXT __GlueVertexAttribI4bvEXT;
		static __glVertexAttribI4iEXT __GlueVertexAttribI4iEXT;
		static __glVertexAttribI4ivEXT __GlueVertexAttribI4ivEXT;
		static __glVertexAttribI4svEXT __GlueVertexAttribI4svEXT;
		static __glVertexAttribI4ubvEXT __GlueVertexAttribI4ubvEXT;
		static __glVertexAttribI4uiEXT __GlueVertexAttribI4uiEXT;
		static __glVertexAttribI4uivEXT __GlueVertexAttribI4uivEXT;
		static __glVertexAttribI4usvEXT __GlueVertexAttribI4usvEXT;
		static __glVertexAttribIPointerEXT __GlueVertexAttribIPointerEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindFragDataLocationEXT(uint program, uint color, char* name) => __GlueBindFragDataLocationEXT(program, color, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetFragDataLocationEXT(uint program, char* name) => __GlueGetFragDataLocationEXT(program, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformuivEXT(uint program, int location, uint* parameters) => __GlueGetUniformuivEXT(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribIivEXT(uint index, uint pname, int* parameters) => __GlueGetVertexAttribIivEXT(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribIuivEXT(uint index, uint pname, uint* parameters) => __GlueGetVertexAttribIuivEXT(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1uiEXT(int location, uint v0) => __GlueUniform1uiEXT(location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1uivEXT(int location, int count, uint* value) => __GlueUniform1uivEXT(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2uiEXT(int location, uint v0, uint v1) => __GlueUniform2uiEXT(location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2uivEXT(int location, int count, uint* value) => __GlueUniform2uivEXT(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3uiEXT(int location, uint v0, uint v1, uint v2) => __GlueUniform3uiEXT(location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3uivEXT(int location, int count, uint* value) => __GlueUniform3uivEXT(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4uiEXT(int location, uint v0, uint v1, uint v2, uint v3) => __GlueUniform4uiEXT(location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4uivEXT(int location, int count, uint* value) => __GlueUniform4uivEXT(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1iEXT(uint index, int x) => __GlueVertexAttribI1iEXT(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1ivEXT(uint index, int* v) => __GlueVertexAttribI1ivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1uiEXT(uint index, uint x) => __GlueVertexAttribI1uiEXT(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1uivEXT(uint index, uint* v) => __GlueVertexAttribI1uivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2iEXT(uint index, int x, int y) => __GlueVertexAttribI2iEXT(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2ivEXT(uint index, int* v) => __GlueVertexAttribI2ivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2uiEXT(uint index, uint x, uint y) => __GlueVertexAttribI2uiEXT(index, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2uivEXT(uint index, uint* v) => __GlueVertexAttribI2uivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3iEXT(uint index, int x, int y, int z) => __GlueVertexAttribI3iEXT(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3ivEXT(uint index, int* v) => __GlueVertexAttribI3ivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3uiEXT(uint index, uint x, uint y, uint z) => __GlueVertexAttribI3uiEXT(index, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3uivEXT(uint index, uint* v) => __GlueVertexAttribI3uivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4bvEXT(uint index, sbyte* v) => __GlueVertexAttribI4bvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4iEXT(uint index, int x, int y, int z, int w) => __GlueVertexAttribI4iEXT(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4ivEXT(uint index, int* v) => __GlueVertexAttribI4ivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4svEXT(uint index, short* v) => __GlueVertexAttribI4svEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4ubvEXT(uint index, byte* v) => __GlueVertexAttribI4ubvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4uiEXT(uint index, uint x, uint y, uint z, uint w) => __GlueVertexAttribI4uiEXT(index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4uivEXT(uint index, uint* v) => __GlueVertexAttribI4uivEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4usvEXT(uint index, ushort* v) => __GlueVertexAttribI4usvEXT(index, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribIPointerEXT(uint index, int size, uint type, int stride, IntPtr pointer) => __GlueVertexAttribIPointerEXT(index, size, type, stride, pointer);



	}
}


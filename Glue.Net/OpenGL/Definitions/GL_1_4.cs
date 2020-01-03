using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_1_4 {get; private set;}

		public const int GL_BLEND_DST_RGB = 0x80C8;
		public const int GL_BLEND_SRC_RGB = 0x80C9;
		public const int GL_BLEND_DST_ALPHA = 0x80CA;
		public const int GL_BLEND_SRC_ALPHA = 0x80CB;
		public const int GL_POINT_SIZE_MIN = 0x8126;
		public const int GL_POINT_SIZE_MAX = 0x8127;
		public const int GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
		public const int GL_POINT_DISTANCE_ATTENUATION = 0x8129;
		public const int GL_GENERATE_MIPMAP = 0x8191;
		public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
		public const int GL_DEPTH_COMPONENT16 = 0x81A5;
		public const int GL_DEPTH_COMPONENT24 = 0x81A6;
		public const int GL_DEPTH_COMPONENT32 = 0x81A7;
		public const int GL_MIRRORED_REPEAT = 0x8370;
		public const int GL_FOG_COORDINATE_SOURCE = 0x8450;
		public const int GL_FOG_COORDINATE = 0x8451;
		public const int GL_FRAGMENT_DEPTH = 0x8452;
		public const int GL_CURRENT_FOG_COORDINATE = 0x8453;
		public const int GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
		public const int GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
		public const int GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
		public const int GL_FOG_COORDINATE_ARRAY = 0x8457;
		public const int GL_COLOR_SUM = 0x8458;
		public const int GL_CURRENT_SECONDARY_COLOR = 0x8459;
		public const int GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
		public const int GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
		public const int GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
		public const int GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
		public const int GL_SECONDARY_COLOR_ARRAY = 0x845E;
		public const int GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
		public const int GL_TEXTURE_FILTER_CONTROL = 0x8500;
		public const int GL_TEXTURE_LOD_BIAS = 0x8501;
		public const int GL_INCR_WRAP = 0x8507;
		public const int GL_DECR_WRAP = 0x8508;
		public const int GL_TEXTURE_DEPTH_SIZE = 0x884A;
		public const int GL_DEPTH_TEXTURE_MODE = 0x884B;
		public const int GL_TEXTURE_COMPARE_MODE = 0x884C;
		public const int GL_TEXTURE_COMPARE_FUNC = 0x884D;
		public const int GL_COMPARE_R_TO_TEXTURE = 0x884E;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendColor(float red, float green, float blue, float alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendEquation(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordPointer(uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordd(double coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoorddv(double* coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordf(float coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogCoordfv(float* coord);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawArrays(uint mode, int* first, int* count, int drawcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiDrawElements(uint mode, int* count, uint type, IntPtr* indices, int drawcount);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameterf(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameterfv(uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameteri(uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointParameteriv(uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3bv(sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3d(double red, double green, double blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3f(float red, float green, float blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3i(int red, int green, int blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3s(short red, short green, short blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3ub(byte red, byte green, byte blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3ubv(byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3ui(uint red, uint green, uint blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3uiv(uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3us(ushort red, ushort green, ushort blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColor3usv(ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColorPointer(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2d(double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2dv(double* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2f(float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2fv(float* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2i(int x, int y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2iv(int* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2s(short x, short y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos2sv(short* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3d(double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3dv(double* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3f(float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3fv(float* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3i(int x, int y, int z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3iv(int* p);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3s(short x, short y, short z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWindowPos3sv(short* p);

 		static __glBlendColor __GlueBlendColor;
		static __glBlendEquation __GlueBlendEquation;
		static __glBlendFuncSeparate __GlueBlendFuncSeparate;
		static __glFogCoordPointer __GlueFogCoordPointer;
		static __glFogCoordd __GlueFogCoordd;
		static __glFogCoorddv __GlueFogCoorddv;
		static __glFogCoordf __GlueFogCoordf;
		static __glFogCoordfv __GlueFogCoordfv;
		static __glMultiDrawArrays __GlueMultiDrawArrays;
		static __glMultiDrawElements __GlueMultiDrawElements;
		static __glPointParameterf __GluePointParameterf;
		static __glPointParameterfv __GluePointParameterfv;
		static __glPointParameteri __GluePointParameteri;
		static __glPointParameteriv __GluePointParameteriv;
		static __glSecondaryColor3b __GlueSecondaryColor3b;
		static __glSecondaryColor3bv __GlueSecondaryColor3bv;
		static __glSecondaryColor3d __GlueSecondaryColor3d;
		static __glSecondaryColor3dv __GlueSecondaryColor3dv;
		static __glSecondaryColor3f __GlueSecondaryColor3f;
		static __glSecondaryColor3fv __GlueSecondaryColor3fv;
		static __glSecondaryColor3i __GlueSecondaryColor3i;
		static __glSecondaryColor3iv __GlueSecondaryColor3iv;
		static __glSecondaryColor3s __GlueSecondaryColor3s;
		static __glSecondaryColor3sv __GlueSecondaryColor3sv;
		static __glSecondaryColor3ub __GlueSecondaryColor3ub;
		static __glSecondaryColor3ubv __GlueSecondaryColor3ubv;
		static __glSecondaryColor3ui __GlueSecondaryColor3ui;
		static __glSecondaryColor3uiv __GlueSecondaryColor3uiv;
		static __glSecondaryColor3us __GlueSecondaryColor3us;
		static __glSecondaryColor3usv __GlueSecondaryColor3usv;
		static __glSecondaryColorPointer __GlueSecondaryColorPointer;
		static __glWindowPos2d __GlueWindowPos2d;
		static __glWindowPos2dv __GlueWindowPos2dv;
		static __glWindowPos2f __GlueWindowPos2f;
		static __glWindowPos2fv __GlueWindowPos2fv;
		static __glWindowPos2i __GlueWindowPos2i;
		static __glWindowPos2iv __GlueWindowPos2iv;
		static __glWindowPos2s __GlueWindowPos2s;
		static __glWindowPos2sv __GlueWindowPos2sv;
		static __glWindowPos3d __GlueWindowPos3d;
		static __glWindowPos3dv __GlueWindowPos3dv;
		static __glWindowPos3f __GlueWindowPos3f;
		static __glWindowPos3fv __GlueWindowPos3fv;
		static __glWindowPos3i __GlueWindowPos3i;
		static __glWindowPos3iv __GlueWindowPos3iv;
		static __glWindowPos3s __GlueWindowPos3s;
		static __glWindowPos3sv __GlueWindowPos3sv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendColor(float red, float green, float blue, float alpha) => __GlueBlendColor(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendEquation(uint mode) => __GlueBlendEquation(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) => __GlueBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordPointer(uint type, int stride, IntPtr pointer) => __GlueFogCoordPointer(type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordd(double coord) => __GlueFogCoordd(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoorddv(double* coord) => __GlueFogCoorddv(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordf(float coord) => __GlueFogCoordf(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogCoordfv(float* coord) => __GlueFogCoordfv(coord);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawArrays(uint mode, int* first, int* count, int drawcount) => __GlueMultiDrawArrays(mode, first, count, drawcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiDrawElements(uint mode, int* count, uint type, IntPtr* indices, int drawcount) => __GlueMultiDrawElements(mode, count, type, indices, drawcount);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameterf(uint pname, float param) => __GluePointParameterf(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameterfv(uint pname, float* parameters) => __GluePointParameterfv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameteri(uint pname, int param) => __GluePointParameteri(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointParameteriv(uint pname, int* parameters) => __GluePointParameteriv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue) => __GlueSecondaryColor3b(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3bv(sbyte* v) => __GlueSecondaryColor3bv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3d(double red, double green, double blue) => __GlueSecondaryColor3d(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3dv(double* v) => __GlueSecondaryColor3dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3f(float red, float green, float blue) => __GlueSecondaryColor3f(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3fv(float* v) => __GlueSecondaryColor3fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3i(int red, int green, int blue) => __GlueSecondaryColor3i(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3iv(int* v) => __GlueSecondaryColor3iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3s(short red, short green, short blue) => __GlueSecondaryColor3s(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3sv(short* v) => __GlueSecondaryColor3sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3ub(byte red, byte green, byte blue) => __GlueSecondaryColor3ub(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3ubv(byte* v) => __GlueSecondaryColor3ubv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3ui(uint red, uint green, uint blue) => __GlueSecondaryColor3ui(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3uiv(uint* v) => __GlueSecondaryColor3uiv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3us(ushort red, ushort green, ushort blue) => __GlueSecondaryColor3us(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColor3usv(ushort* v) => __GlueSecondaryColor3usv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColorPointer(int size, uint type, int stride, IntPtr pointer) => __GlueSecondaryColorPointer(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2d(double x, double y) => __GlueWindowPos2d(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2dv(double* p) => __GlueWindowPos2dv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2f(float x, float y) => __GlueWindowPos2f(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2fv(float* p) => __GlueWindowPos2fv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2i(int x, int y) => __GlueWindowPos2i(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2iv(int* p) => __GlueWindowPos2iv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2s(short x, short y) => __GlueWindowPos2s(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos2sv(short* p) => __GlueWindowPos2sv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3d(double x, double y, double z) => __GlueWindowPos3d(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3dv(double* p) => __GlueWindowPos3dv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3f(float x, float y, float z) => __GlueWindowPos3f(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3fv(float* p) => __GlueWindowPos3fv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3i(int x, int y, int z) => __GlueWindowPos3i(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3iv(int* p) => __GlueWindowPos3iv(p);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3s(short x, short y, short z) => __GlueWindowPos3s(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWindowPos3sv(short* p) => __GlueWindowPos3sv(p);



	}
}


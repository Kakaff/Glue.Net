using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_1_3 {get; private set;}

		public const int GL_MULTISAMPLE = 0x809D;
		public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const int GL_SAMPLE_COVERAGE = 0x80A0;
		public const int GL_SAMPLE_BUFFERS = 0x80A8;
		public const int GL_SAMPLES = 0x80A9;
		public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const int GL_CLAMP_TO_BORDER = 0x812D;
		public const int GL_TEXTURE0 = 0x84C0;
		public const int GL_TEXTURE1 = 0x84C1;
		public const int GL_TEXTURE2 = 0x84C2;
		public const int GL_TEXTURE3 = 0x84C3;
		public const int GL_TEXTURE4 = 0x84C4;
		public const int GL_TEXTURE5 = 0x84C5;
		public const int GL_TEXTURE6 = 0x84C6;
		public const int GL_TEXTURE7 = 0x84C7;
		public const int GL_TEXTURE8 = 0x84C8;
		public const int GL_TEXTURE9 = 0x84C9;
		public const int GL_TEXTURE10 = 0x84CA;
		public const int GL_TEXTURE11 = 0x84CB;
		public const int GL_TEXTURE12 = 0x84CC;
		public const int GL_TEXTURE13 = 0x84CD;
		public const int GL_TEXTURE14 = 0x84CE;
		public const int GL_TEXTURE15 = 0x84CF;
		public const int GL_TEXTURE16 = 0x84D0;
		public const int GL_TEXTURE17 = 0x84D1;
		public const int GL_TEXTURE18 = 0x84D2;
		public const int GL_TEXTURE19 = 0x84D3;
		public const int GL_TEXTURE20 = 0x84D4;
		public const int GL_TEXTURE21 = 0x84D5;
		public const int GL_TEXTURE22 = 0x84D6;
		public const int GL_TEXTURE23 = 0x84D7;
		public const int GL_TEXTURE24 = 0x84D8;
		public const int GL_TEXTURE25 = 0x84D9;
		public const int GL_TEXTURE26 = 0x84DA;
		public const int GL_TEXTURE27 = 0x84DB;
		public const int GL_TEXTURE28 = 0x84DC;
		public const int GL_TEXTURE29 = 0x84DD;
		public const int GL_TEXTURE30 = 0x84DE;
		public const int GL_TEXTURE31 = 0x84DF;
		public const int GL_ACTIVE_TEXTURE = 0x84E0;
		public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
		public const int GL_MAX_TEXTURE_UNITS = 0x84E2;
		public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
		public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
		public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
		public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
		public const int GL_SUBTRACT = 0x84E7;
		public const int GL_COMPRESSED_ALPHA = 0x84E9;
		public const int GL_COMPRESSED_LUMINANCE = 0x84EA;
		public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
		public const int GL_COMPRESSED_INTENSITY = 0x84EC;
		public const int GL_COMPRESSED_RGB = 0x84ED;
		public const int GL_COMPRESSED_RGBA = 0x84EE;
		public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const int GL_NORMAL_MAP = 0x8511;
		public const int GL_REFLECTION_MAP = 0x8512;
		public const int GL_TEXTURE_CUBE_MAP = 0x8513;
		public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const int GL_COMBINE = 0x8570;
		public const int GL_COMBINE_RGB = 0x8571;
		public const int GL_COMBINE_ALPHA = 0x8572;
		public const int GL_RGB_SCALE = 0x8573;
		public const int GL_ADD_SIGNED = 0x8574;
		public const int GL_INTERPOLATE = 0x8575;
		public const int GL_CONSTANT = 0x8576;
		public const int GL_PRIMARY_COLOR = 0x8577;
		public const int GL_PREVIOUS = 0x8578;
		public const int GL_SOURCE0_RGB = 0x8580;
		public const int GL_SOURCE1_RGB = 0x8581;
		public const int GL_SOURCE2_RGB = 0x8582;
		public const int GL_SOURCE0_ALPHA = 0x8588;
		public const int GL_SOURCE1_ALPHA = 0x8589;
		public const int GL_SOURCE2_ALPHA = 0x858A;
		public const int GL_OPERAND0_RGB = 0x8590;
		public const int GL_OPERAND1_RGB = 0x8591;
		public const int GL_OPERAND2_RGB = 0x8592;
		public const int GL_OPERAND0_ALPHA = 0x8598;
		public const int GL_OPERAND1_ALPHA = 0x8599;
		public const int GL_OPERAND2_ALPHA = 0x859A;
		public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const int GL_TEXTURE_COMPRESSED = 0x86A1;
		public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const int GL_DOT3_RGB = 0x86AE;
		public const int GL_DOT3_RGBA = 0x86AF;
		public const int GL_MULTISAMPLE_BIT = 0x20000000;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glActiveTexture(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClientActiveTexture(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCompressedTexImage(uint target, int lod, IntPtr img);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadTransposeMatrixd(double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadTransposeMatrixf(float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultTransposeMatrixd(double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultTransposeMatrixf(float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1d(uint target, double s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1dv(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1f(uint target, float s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1fv(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1i(uint target, int s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1iv(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1s(uint target, short s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord1sv(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2d(uint target, double s, double t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2dv(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2f(uint target, float s, float t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2fv(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2i(uint target, int s, int t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2iv(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2s(uint target, short s, short t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord2sv(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3d(uint target, double s, double t, double r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3dv(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3f(uint target, float s, float t, float r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3fv(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3i(uint target, int s, int t, int r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3iv(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3s(uint target, short s, short t, short r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord3sv(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4d(uint target, double s, double t, double r, double q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4dv(uint target, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4f(uint target, float s, float t, float r, float q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4fv(uint target, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4i(uint target, int s, int t, int r, int q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4iv(uint target, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4s(uint target, short s, short t, short r, short q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoord4sv(uint target, short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSampleCoverage(float value, bool invert);

 		static __glActiveTexture __GlueActiveTexture;
		static __glClientActiveTexture __GlueClientActiveTexture;
		static __glCompressedTexImage1D __GlueCompressedTexImage1D;
		static __glCompressedTexImage2D __GlueCompressedTexImage2D;
		static __glCompressedTexImage3D __GlueCompressedTexImage3D;
		static __glCompressedTexSubImage1D __GlueCompressedTexSubImage1D;
		static __glCompressedTexSubImage2D __GlueCompressedTexSubImage2D;
		static __glCompressedTexSubImage3D __GlueCompressedTexSubImage3D;
		static __glGetCompressedTexImage __GlueGetCompressedTexImage;
		static __glLoadTransposeMatrixd __GlueLoadTransposeMatrixd;
		static __glLoadTransposeMatrixf __GlueLoadTransposeMatrixf;
		static __glMultTransposeMatrixd __GlueMultTransposeMatrixd;
		static __glMultTransposeMatrixf __GlueMultTransposeMatrixf;
		static __glMultiTexCoord1d __GlueMultiTexCoord1d;
		static __glMultiTexCoord1dv __GlueMultiTexCoord1dv;
		static __glMultiTexCoord1f __GlueMultiTexCoord1f;
		static __glMultiTexCoord1fv __GlueMultiTexCoord1fv;
		static __glMultiTexCoord1i __GlueMultiTexCoord1i;
		static __glMultiTexCoord1iv __GlueMultiTexCoord1iv;
		static __glMultiTexCoord1s __GlueMultiTexCoord1s;
		static __glMultiTexCoord1sv __GlueMultiTexCoord1sv;
		static __glMultiTexCoord2d __GlueMultiTexCoord2d;
		static __glMultiTexCoord2dv __GlueMultiTexCoord2dv;
		static __glMultiTexCoord2f __GlueMultiTexCoord2f;
		static __glMultiTexCoord2fv __GlueMultiTexCoord2fv;
		static __glMultiTexCoord2i __GlueMultiTexCoord2i;
		static __glMultiTexCoord2iv __GlueMultiTexCoord2iv;
		static __glMultiTexCoord2s __GlueMultiTexCoord2s;
		static __glMultiTexCoord2sv __GlueMultiTexCoord2sv;
		static __glMultiTexCoord3d __GlueMultiTexCoord3d;
		static __glMultiTexCoord3dv __GlueMultiTexCoord3dv;
		static __glMultiTexCoord3f __GlueMultiTexCoord3f;
		static __glMultiTexCoord3fv __GlueMultiTexCoord3fv;
		static __glMultiTexCoord3i __GlueMultiTexCoord3i;
		static __glMultiTexCoord3iv __GlueMultiTexCoord3iv;
		static __glMultiTexCoord3s __GlueMultiTexCoord3s;
		static __glMultiTexCoord3sv __GlueMultiTexCoord3sv;
		static __glMultiTexCoord4d __GlueMultiTexCoord4d;
		static __glMultiTexCoord4dv __GlueMultiTexCoord4dv;
		static __glMultiTexCoord4f __GlueMultiTexCoord4f;
		static __glMultiTexCoord4fv __GlueMultiTexCoord4fv;
		static __glMultiTexCoord4i __GlueMultiTexCoord4i;
		static __glMultiTexCoord4iv __GlueMultiTexCoord4iv;
		static __glMultiTexCoord4s __GlueMultiTexCoord4s;
		static __glMultiTexCoord4sv __GlueMultiTexCoord4sv;
		static __glSampleCoverage __GlueSampleCoverage;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glActiveTexture(uint texture) => __GlueActiveTexture(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClientActiveTexture(uint texture) => __GlueClientActiveTexture(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data) => __GlueCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data) => __GlueCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data) => __GlueCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => __GlueCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => __GlueCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => __GlueCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCompressedTexImage(uint target, int lod, IntPtr img) => __GlueGetCompressedTexImage(target, lod, img);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadTransposeMatrixd(double* m) => __GlueLoadTransposeMatrixd(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadTransposeMatrixf(float* m) => __GlueLoadTransposeMatrixf(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultTransposeMatrixd(double* m) => __GlueMultTransposeMatrixd(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultTransposeMatrixf(float* m) => __GlueMultTransposeMatrixf(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1d(uint target, double s) => __GlueMultiTexCoord1d(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1dv(uint target, double* v) => __GlueMultiTexCoord1dv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1f(uint target, float s) => __GlueMultiTexCoord1f(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1fv(uint target, float* v) => __GlueMultiTexCoord1fv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1i(uint target, int s) => __GlueMultiTexCoord1i(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1iv(uint target, int* v) => __GlueMultiTexCoord1iv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1s(uint target, short s) => __GlueMultiTexCoord1s(target, s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord1sv(uint target, short* v) => __GlueMultiTexCoord1sv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2d(uint target, double s, double t) => __GlueMultiTexCoord2d(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2dv(uint target, double* v) => __GlueMultiTexCoord2dv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2f(uint target, float s, float t) => __GlueMultiTexCoord2f(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2fv(uint target, float* v) => __GlueMultiTexCoord2fv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2i(uint target, int s, int t) => __GlueMultiTexCoord2i(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2iv(uint target, int* v) => __GlueMultiTexCoord2iv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2s(uint target, short s, short t) => __GlueMultiTexCoord2s(target, s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord2sv(uint target, short* v) => __GlueMultiTexCoord2sv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3d(uint target, double s, double t, double r) => __GlueMultiTexCoord3d(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3dv(uint target, double* v) => __GlueMultiTexCoord3dv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3f(uint target, float s, float t, float r) => __GlueMultiTexCoord3f(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3fv(uint target, float* v) => __GlueMultiTexCoord3fv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3i(uint target, int s, int t, int r) => __GlueMultiTexCoord3i(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3iv(uint target, int* v) => __GlueMultiTexCoord3iv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3s(uint target, short s, short t, short r) => __GlueMultiTexCoord3s(target, s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord3sv(uint target, short* v) => __GlueMultiTexCoord3sv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4d(uint target, double s, double t, double r, double q) => __GlueMultiTexCoord4d(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4dv(uint target, double* v) => __GlueMultiTexCoord4dv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4f(uint target, float s, float t, float r, float q) => __GlueMultiTexCoord4f(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4fv(uint target, float* v) => __GlueMultiTexCoord4fv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4i(uint target, int s, int t, int r, int q) => __GlueMultiTexCoord4i(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4iv(uint target, int* v) => __GlueMultiTexCoord4iv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4s(uint target, short s, short t, short r, short q) => __GlueMultiTexCoord4s(target, s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoord4sv(uint target, short* v) => __GlueMultiTexCoord4sv(target, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSampleCoverage(float value, bool invert) => __GlueSampleCoverage(value, invert);



	}
}


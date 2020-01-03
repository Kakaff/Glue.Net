using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_3_0 {get; private set;}

		public const int GL_CLIP_DISTANCE0 = 0x3000;
		public const int GL_CLIP_DISTANCE1 = 0x3001;
		public const int GL_CLIP_DISTANCE2 = 0x3002;
		public const int GL_CLIP_DISTANCE3 = 0x3003;
		public const int GL_CLIP_DISTANCE4 = 0x3004;
		public const int GL_CLIP_DISTANCE5 = 0x3005;
		public const int GL_COMPARE_REF_TO_TEXTURE = 0x884E;
		public const int GL_MAX_CLIP_DISTANCES = 0x0D32;
		public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;
		public const int GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x0001;
		public const int GL_MAJOR_VERSION = 0x821B;
		public const int GL_MINOR_VERSION = 0x821C;
		public const int GL_NUM_EXTENSIONS = 0x821D;
		public const int GL_CONTEXT_FLAGS = 0x821E;
		public const int GL_DEPTH_BUFFER = 0x8223;
		public const int GL_STENCIL_BUFFER = 0x8224;
		public const int GL_RGBA32F = 0x8814;
		public const int GL_RGB32F = 0x8815;
		public const int GL_RGBA16F = 0x881A;
		public const int GL_RGB16F = 0x881B;
		public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
		public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
		public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
		public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
		public const int GL_CLAMP_VERTEX_COLOR = 0x891A;
		public const int GL_CLAMP_FRAGMENT_COLOR = 0x891B;
		public const int GL_CLAMP_READ_COLOR = 0x891C;
		public const int GL_FIXED_ONLY = 0x891D;
		public const int GL_TEXTURE_RED_TYPE = 0x8C10;
		public const int GL_TEXTURE_GREEN_TYPE = 0x8C11;
		public const int GL_TEXTURE_BLUE_TYPE = 0x8C12;
		public const int GL_TEXTURE_ALPHA_TYPE = 0x8C13;
		public const int GL_TEXTURE_LUMINANCE_TYPE = 0x8C14;
		public const int GL_TEXTURE_INTENSITY_TYPE = 0x8C15;
		public const int GL_TEXTURE_DEPTH_TYPE = 0x8C16;
		public const int GL_TEXTURE_1D_ARRAY = 0x8C18;
		public const int GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
		public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;
		public const int GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
		public const int GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
		public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
		public const int GL_R11F_G11F_B10F = 0x8C3A;
		public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
		public const int GL_RGB9_E5 = 0x8C3D;
		public const int GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
		public const int GL_TEXTURE_SHARED_SIZE = 0x8C3F;
		public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
		public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
		public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
		public const int GL_PRIMITIVES_GENERATED = 0x8C87;
		public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
		public const int GL_RASTERIZER_DISCARD = 0x8C89;
		public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
		public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
		public const int GL_INTERLEAVED_ATTRIBS = 0x8C8C;
		public const int GL_SEPARATE_ATTRIBS = 0x8C8D;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
		public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
		public const int GL_RGBA32UI = 0x8D70;
		public const int GL_RGB32UI = 0x8D71;
		public const int GL_RGBA16UI = 0x8D76;
		public const int GL_RGB16UI = 0x8D77;
		public const int GL_RGBA8UI = 0x8D7C;
		public const int GL_RGB8UI = 0x8D7D;
		public const int GL_RGBA32I = 0x8D82;
		public const int GL_RGB32I = 0x8D83;
		public const int GL_RGBA16I = 0x8D88;
		public const int GL_RGB16I = 0x8D89;
		public const int GL_RGBA8I = 0x8D8E;
		public const int GL_RGB8I = 0x8D8F;
		public const int GL_RED_INTEGER = 0x8D94;
		public const int GL_GREEN_INTEGER = 0x8D95;
		public const int GL_BLUE_INTEGER = 0x8D96;
		public const int GL_ALPHA_INTEGER = 0x8D97;
		public const int GL_RGB_INTEGER = 0x8D98;
		public const int GL_RGBA_INTEGER = 0x8D99;
		public const int GL_BGR_INTEGER = 0x8D9A;
		public const int GL_BGRA_INTEGER = 0x8D9B;
		public const int GL_SAMPLER_1D_ARRAY = 0x8DC0;
		public const int GL_SAMPLER_2D_ARRAY = 0x8DC1;
		public const int GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
		public const int GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
		public const int GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
		public const int GL_UNSIGNED_INT_VEC2 = 0x8DC6;
		public const int GL_UNSIGNED_INT_VEC3 = 0x8DC7;
		public const int GL_UNSIGNED_INT_VEC4 = 0x8DC8;
		public const int GL_INT_SAMPLER_1D = 0x8DC9;
		public const int GL_INT_SAMPLER_2D = 0x8DCA;
		public const int GL_INT_SAMPLER_3D = 0x8DCB;
		public const int GL_INT_SAMPLER_CUBE = 0x8DCC;
		public const int GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
		public const int GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
		public const int GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
		public const int GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
		public const int GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
		public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
		public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
		public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
		public const int GL_QUERY_WAIT = 0x8E13;
		public const int GL_QUERY_NO_WAIT = 0x8E14;
		public const int GL_QUERY_BY_REGION_WAIT = 0x8E15;
		public const int GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginConditionalRender(uint id, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginTransformFeedback(uint primitiveMode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindFragDataLocation(uint program, uint colorNumber, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClampColor(uint target, uint clamp);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearBufferfi(uint buffer, int drawBuffer, float depth, int stencil);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearBufferfv(uint buffer, int drawBuffer, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearBufferiv(uint buffer, int drawBuffer, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearBufferuiv(uint buffer, int drawBuffer, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorMaski(uint buf, bool red, bool green, bool blue, bool alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisablei(uint cap, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnablei(uint cap, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndConditionalRender( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndTransformFeedback( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBooleani_v(uint pname, uint index, bool* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glGetFragDataLocation(uint program, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate  byte* __glGetStringi(uint name, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexParameterIiv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexParameterIuiv(uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetUniformuiv(uint program, int location, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribIiv(uint index, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribIuiv(uint index, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsEnabledi(uint cap, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameterIiv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameterIuiv(uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1ui(int location, uint v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform1uiv(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2ui(int location, uint v0, uint v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform2uiv(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3ui(int location, uint v0, uint v1, uint v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform3uiv(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniform4uiv(int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1i(uint index, int v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1iv(uint index, int* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1ui(uint index, uint v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI1uiv(uint index, uint* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2i(uint index, int v0, int v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2iv(uint index, int* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2ui(uint index, uint v0, uint v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI2uiv(uint index, uint* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3i(uint index, int v0, int v1, int v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3iv(uint index, int* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3ui(uint index, uint v0, uint v1, uint v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI3uiv(uint index, uint* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4bv(uint index, sbyte* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4i(uint index, int v0, int v1, int v2, int v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4iv(uint index, int* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4sv(uint index, short* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4ubv(uint index, byte* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4ui(uint index, uint v0, uint v1, uint v2, uint v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4uiv(uint index, uint* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribI4usv(uint index, ushort* v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer);

 		static __glBeginConditionalRender __GlueBeginConditionalRender;
		static __glBeginTransformFeedback __GlueBeginTransformFeedback;
		static __glBindFragDataLocation __GlueBindFragDataLocation;
		static __glClampColor __GlueClampColor;
		static __glClearBufferfi __GlueClearBufferfi;
		static __glClearBufferfv __GlueClearBufferfv;
		static __glClearBufferiv __GlueClearBufferiv;
		static __glClearBufferuiv __GlueClearBufferuiv;
		static __glColorMaski __GlueColorMaski;
		static __glDisablei __GlueDisablei;
		static __glEnablei __GlueEnablei;
		static __glEndConditionalRender __GlueEndConditionalRender;
		static __glEndTransformFeedback __GlueEndTransformFeedback;
		static __glGetBooleani_v __GlueGetBooleani_v;
		static __glGetFragDataLocation __GlueGetFragDataLocation;
		static __glGetStringi __GlueGetStringi;
		static __glGetTexParameterIiv __GlueGetTexParameterIiv;
		static __glGetTexParameterIuiv __GlueGetTexParameterIuiv;
		static __glGetTransformFeedbackVarying __GlueGetTransformFeedbackVarying;
		static __glGetUniformuiv __GlueGetUniformuiv;
		static __glGetVertexAttribIiv __GlueGetVertexAttribIiv;
		static __glGetVertexAttribIuiv __GlueGetVertexAttribIuiv;
		static __glIsEnabledi __GlueIsEnabledi;
		static __glTexParameterIiv __GlueTexParameterIiv;
		static __glTexParameterIuiv __GlueTexParameterIuiv;
		static __glTransformFeedbackVaryings __GlueTransformFeedbackVaryings;
		static __glUniform1ui __GlueUniform1ui;
		static __glUniform1uiv __GlueUniform1uiv;
		static __glUniform2ui __GlueUniform2ui;
		static __glUniform2uiv __GlueUniform2uiv;
		static __glUniform3ui __GlueUniform3ui;
		static __glUniform3uiv __GlueUniform3uiv;
		static __glUniform4ui __GlueUniform4ui;
		static __glUniform4uiv __GlueUniform4uiv;
		static __glVertexAttribI1i __GlueVertexAttribI1i;
		static __glVertexAttribI1iv __GlueVertexAttribI1iv;
		static __glVertexAttribI1ui __GlueVertexAttribI1ui;
		static __glVertexAttribI1uiv __GlueVertexAttribI1uiv;
		static __glVertexAttribI2i __GlueVertexAttribI2i;
		static __glVertexAttribI2iv __GlueVertexAttribI2iv;
		static __glVertexAttribI2ui __GlueVertexAttribI2ui;
		static __glVertexAttribI2uiv __GlueVertexAttribI2uiv;
		static __glVertexAttribI3i __GlueVertexAttribI3i;
		static __glVertexAttribI3iv __GlueVertexAttribI3iv;
		static __glVertexAttribI3ui __GlueVertexAttribI3ui;
		static __glVertexAttribI3uiv __GlueVertexAttribI3uiv;
		static __glVertexAttribI4bv __GlueVertexAttribI4bv;
		static __glVertexAttribI4i __GlueVertexAttribI4i;
		static __glVertexAttribI4iv __GlueVertexAttribI4iv;
		static __glVertexAttribI4sv __GlueVertexAttribI4sv;
		static __glVertexAttribI4ubv __GlueVertexAttribI4ubv;
		static __glVertexAttribI4ui __GlueVertexAttribI4ui;
		static __glVertexAttribI4uiv __GlueVertexAttribI4uiv;
		static __glVertexAttribI4usv __GlueVertexAttribI4usv;
		static __glVertexAttribIPointer __GlueVertexAttribIPointer;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginConditionalRender(uint id, uint mode) => __GlueBeginConditionalRender(id, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginTransformFeedback(uint primitiveMode) => __GlueBeginTransformFeedback(primitiveMode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindFragDataLocation(uint program, uint colorNumber, char* name) => __GlueBindFragDataLocation(program, colorNumber, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClampColor(uint target, uint clamp) => __GlueClampColor(target, clamp);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearBufferfi(uint buffer, int drawBuffer, float depth, int stencil) => __GlueClearBufferfi(buffer, drawBuffer, depth, stencil);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearBufferfv(uint buffer, int drawBuffer, float* value) => __GlueClearBufferfv(buffer, drawBuffer, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearBufferiv(uint buffer, int drawBuffer, int* value) => __GlueClearBufferiv(buffer, drawBuffer, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearBufferuiv(uint buffer, int drawBuffer, uint* value) => __GlueClearBufferuiv(buffer, drawBuffer, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorMaski(uint buf, bool red, bool green, bool blue, bool alpha) => __GlueColorMaski(buf, red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisablei(uint cap, uint index) => __GlueDisablei(cap, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnablei(uint cap, uint index) => __GlueEnablei(cap, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndConditionalRender( ) => __GlueEndConditionalRender();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndTransformFeedback( ) => __GlueEndTransformFeedback();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBooleani_v(uint pname, uint index, bool* data) => __GlueGetBooleani_v(pname, index, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glGetFragDataLocation(uint program, char* name) => __GlueGetFragDataLocation(program, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe  byte* glGetStringi(uint name, uint index) => __GlueGetStringi(name, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexParameterIiv(uint target, uint pname, int* parameters) => __GlueGetTexParameterIiv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexParameterIuiv(uint target, uint pname, uint* parameters) => __GlueGetTexParameterIuiv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) => __GlueGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetUniformuiv(uint program, int location, uint* parameters) => __GlueGetUniformuiv(program, location, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribIiv(uint index, uint pname, int* parameters) => __GlueGetVertexAttribIiv(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribIuiv(uint index, uint pname, uint* parameters) => __GlueGetVertexAttribIuiv(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsEnabledi(uint cap, uint index) => __GlueIsEnabledi(cap, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameterIiv(uint target, uint pname, int* parameters) => __GlueTexParameterIiv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameterIuiv(uint target, uint pname, uint* parameters) => __GlueTexParameterIuiv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode) => __GlueTransformFeedbackVaryings(program, count, varyings, bufferMode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1ui(int location, uint v0) => __GlueUniform1ui(location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform1uiv(int location, int count, uint* value) => __GlueUniform1uiv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2ui(int location, uint v0, uint v1) => __GlueUniform2ui(location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform2uiv(int location, int count, uint* value) => __GlueUniform2uiv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3ui(int location, uint v0, uint v1, uint v2) => __GlueUniform3ui(location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform3uiv(int location, int count, uint* value) => __GlueUniform3uiv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => __GlueUniform4ui(location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniform4uiv(int location, int count, uint* value) => __GlueUniform4uiv(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1i(uint index, int v0) => __GlueVertexAttribI1i(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1iv(uint index, int* v0) => __GlueVertexAttribI1iv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1ui(uint index, uint v0) => __GlueVertexAttribI1ui(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI1uiv(uint index, uint* v0) => __GlueVertexAttribI1uiv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2i(uint index, int v0, int v1) => __GlueVertexAttribI2i(index, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2iv(uint index, int* v0) => __GlueVertexAttribI2iv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2ui(uint index, uint v0, uint v1) => __GlueVertexAttribI2ui(index, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI2uiv(uint index, uint* v0) => __GlueVertexAttribI2uiv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3i(uint index, int v0, int v1, int v2) => __GlueVertexAttribI3i(index, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3iv(uint index, int* v0) => __GlueVertexAttribI3iv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3ui(uint index, uint v0, uint v1, uint v2) => __GlueVertexAttribI3ui(index, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI3uiv(uint index, uint* v0) => __GlueVertexAttribI3uiv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4bv(uint index, sbyte* v0) => __GlueVertexAttribI4bv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4i(uint index, int v0, int v1, int v2, int v3) => __GlueVertexAttribI4i(index, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4iv(uint index, int* v0) => __GlueVertexAttribI4iv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4sv(uint index, short* v0) => __GlueVertexAttribI4sv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4ubv(uint index, byte* v0) => __GlueVertexAttribI4ubv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4ui(uint index, uint v0, uint v1, uint v2, uint v3) => __GlueVertexAttribI4ui(index, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4uiv(uint index, uint* v0) => __GlueVertexAttribI4uiv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribI4usv(uint index, ushort* v0) => __GlueVertexAttribI4usv(index, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribIPointer(uint index, int size, uint type, int stride, IntPtr pointer) => __GlueVertexAttribIPointer(index, size, type, stride, pointer);



	}
}


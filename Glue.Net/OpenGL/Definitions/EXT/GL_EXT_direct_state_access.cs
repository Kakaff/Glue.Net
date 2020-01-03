using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_direct_state_access {get; private set;}

		public const int GL_PROGRAM_MATRIX_EXT = 0x8E2D;
		public const int GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
		public const int GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindMultiTextureEXT(uint texunit, uint target, uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCheckNamedFramebufferStatusEXT(uint framebuffer, uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClientAttribDefaultEXT(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedMultiTexImage1DEXT(uint texunit, uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedMultiTexImage2DEXT(uint texunit, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedMultiTexImage3DEXT(uint texunit, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureImage1DEXT(uint texture, uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureImage2DEXT(uint texture, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureImage3DEXT(uint texture, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyMultiTexImage1DEXT(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyMultiTexImage2DEXT(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureImage1DEXT(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureImage2DEXT(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableClientStateIndexedEXT(uint array, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableClientStateiEXT(uint array, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableVertexArrayAttribEXT(uint vaobj, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableVertexArrayEXT(uint vaobj, uint array);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableClientStateIndexedEXT(uint array, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableClientStateiEXT(uint array, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableVertexArrayAttribEXT(uint vaobj, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableVertexArrayEXT(uint vaobj, uint array);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFlushMappedNamedBufferRangeEXT(uint buffer, int offset, int length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferDrawBufferEXT(uint framebuffer, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferDrawBuffersEXT(uint framebuffer, int n, uint* bufs);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFramebufferReadBufferEXT(uint framebuffer, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenerateMultiTexMipmapEXT(uint texunit, uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenerateTextureMipmapEXT(uint texture, uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCompressedMultiTexImageEXT(uint texunit, uint target, int level, IntPtr img);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCompressedTextureImageEXT(uint texture, uint target, int level, IntPtr img);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetDoubleIndexedvEXT(uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetDoublei_vEXT(uint pname, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFloatIndexedvEXT(uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFloati_vEXT(uint pname, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFramebufferParameterivEXT(uint framebuffer, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexEnvfvEXT(uint texunit, uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexEnvivEXT(uint texunit, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexGendvEXT(uint texunit, uint coord, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexGenfvEXT(uint texunit, uint coord, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexGenivEXT(uint texunit, uint coord, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexImageEXT(uint texunit, uint target, int level, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexLevelParameterfvEXT(uint texunit, uint target, int level, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexLevelParameterivEXT(uint texunit, uint target, int level, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexParameterIivEXT(uint texunit, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexParameterIuivEXT(uint texunit, uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexParameterfvEXT(uint texunit, uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMultiTexParameterivEXT(uint texunit, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferParameterivEXT(uint buffer, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferPointervEXT(uint buffer, uint pname, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferSubDataEXT(uint buffer, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedFramebufferAttachmentParameterivEXT(uint framebuffer, uint attachment, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedProgramLocalParameterIivEXT(uint program, uint target, uint index, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedProgramLocalParameterIuivEXT(uint program, uint target, uint index, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedProgramLocalParameterdvEXT(uint program, uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedProgramLocalParameterfvEXT(uint program, uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedProgramStringEXT(uint program, uint target, uint pname, IntPtr str);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedProgramivEXT(uint program, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedRenderbufferParameterivEXT(uint renderbuffer, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPointerIndexedvEXT(uint target, uint index, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPointeri_vEXT(uint pname, uint index, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureImageEXT(uint texture, uint target, int level, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureLevelParameterfvEXT(uint texture, uint target, int level, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureLevelParameterivEXT(uint texture, uint target, int level, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterIivEXT(uint texture, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterIuivEXT(uint texture, uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterfvEXT(uint texture, uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterivEXT(uint texture, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayIntegervEXT(uint vaobj, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayPointeri_vEXT(uint vaobj, uint index, uint pname, IntPtr* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayPointervEXT(uint vaobj, uint pname, IntPtr* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapNamedBufferEXT(uint buffer, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapNamedBufferRangeEXT(uint buffer, int offset, int length, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixFrustumEXT(uint matrixMode, double l, double r, double b, double t, double n, double f);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixLoadIdentityEXT(uint matrixMode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixLoadTransposedEXT(uint matrixMode, double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixLoadTransposefEXT(uint matrixMode, float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixLoaddEXT(uint matrixMode, double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixLoadfEXT(uint matrixMode, float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixMultTransposedEXT(uint matrixMode, double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixMultTransposefEXT(uint matrixMode, float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixMultdEXT(uint matrixMode, double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixMultfEXT(uint matrixMode, float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixOrthoEXT(uint matrixMode, double l, double r, double b, double t, double n, double f);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixPopEXT(uint matrixMode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixPushEXT(uint matrixMode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixRotatedEXT(uint matrixMode, double angle, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixRotatefEXT(uint matrixMode, float angle, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixScaledEXT(uint matrixMode, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixScalefEXT(uint matrixMode, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixTranslatedEXT(uint matrixMode, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixTranslatefEXT(uint matrixMode, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexBufferEXT(uint texunit, uint target, uint internalformat, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordPointerEXT(uint texunit, int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexEnvfEXT(uint texunit, uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexEnvfvEXT(uint texunit, uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexEnviEXT(uint texunit, uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexEnvivEXT(uint texunit, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexGendEXT(uint texunit, uint coord, uint pname, double param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexGendvEXT(uint texunit, uint coord, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexGenfEXT(uint texunit, uint coord, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexGenfvEXT(uint texunit, uint coord, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexGeniEXT(uint texunit, uint coord, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexGenivEXT(uint texunit, uint coord, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexImage1DEXT(uint texunit, uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexImage2DEXT(uint texunit, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexImage3DEXT(uint texunit, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexParameterIivEXT(uint texunit, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexParameterIuivEXT(uint texunit, uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexParameterfEXT(uint texunit, uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexParameterfvEXT(uint texunit, uint target, uint pname, float* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexParameteriEXT(uint texunit, uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexParameterivEXT(uint texunit, uint target, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexRenderbufferEXT(uint texunit, uint target, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferDataEXT(uint buffer, int size, IntPtr data, uint usage);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferSubDataEXT(uint buffer, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedCopyBufferSubDataEXT(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferRenderbufferEXT(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTexture1DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTexture2DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTexture3DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level, int zoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTextureEXT(uint framebuffer, uint attachment, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTextureFaceEXT(uint framebuffer, uint attachment, uint texture, int level, uint face);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTextureLayerEXT(uint framebuffer, uint attachment, uint texture, int level, int layer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameter4dEXT(uint program, uint target, uint index, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameter4dvEXT(uint program, uint target, uint index, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameter4fEXT(uint program, uint target, uint index, float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameter4fvEXT(uint program, uint target, uint index, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameterI4iEXT(uint program, uint target, uint index, int x, int y, int z, int w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameterI4ivEXT(uint program, uint target, uint index, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameterI4uiEXT(uint program, uint target, uint index, uint x, uint y, uint z, uint w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameterI4uivEXT(uint program, uint target, uint index, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParameters4fvEXT(uint program, uint target, uint index, int count, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParametersI4ivEXT(uint program, uint target, uint index, int count, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramLocalParametersI4uivEXT(uint program, uint target, uint index, int count, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedProgramStringEXT(uint program, uint target, uint format, int len, IntPtr str);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedRenderbufferStorageEXT(uint renderbuffer, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedRenderbufferStorageMultisampleCoverageEXT(uint renderbuffer, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedRenderbufferStorageMultisampleEXT(uint renderbuffer, int samples, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1fEXT(uint program, int location, float v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1fvEXT(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1iEXT(uint program, int location, int v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1ivEXT(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1uiEXT(uint program, int location, uint v0);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1uivEXT(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2fEXT(uint program, int location, float v0, float v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2fvEXT(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2iEXT(uint program, int location, int v0, int v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2ivEXT(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2uiEXT(uint program, int location, uint v0, uint v1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2uivEXT(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3fvEXT(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3ivEXT(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3uivEXT(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4fvEXT(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4ivEXT(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4uivEXT(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2x3fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2x4fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3x2fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3x4fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4x2fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4x3fvEXT(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPushClientAttribDefaultEXT(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureBufferEXT(uint texture, uint target, uint internalformat, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureImage1DEXT(uint texture, uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureImage2DEXT(uint texture, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureImage3DEXT(uint texture, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterIivEXT(uint texture, uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterIuivEXT(uint texture, uint target, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterfEXT(uint texture, uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterfvEXT(uint texture, uint target, uint pname, float* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameteriEXT(uint texture, uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterivEXT(uint texture, uint target, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureRenderbufferEXT(uint texture, uint target, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glUnmapNamedBufferEXT(uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayColorOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayEdgeFlagOffsetEXT(uint vaobj, uint buffer, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayFogCoordOffsetEXT(uint vaobj, uint buffer, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayIndexOffsetEXT(uint vaobj, uint buffer, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayMultiTexCoordOffsetEXT(uint vaobj, uint buffer, uint texunit, int size, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayNormalOffsetEXT(uint vaobj, uint buffer, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArraySecondaryColorOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayTexCoordOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexAttribOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, bool normalized, int stride, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset);

 		static __glBindMultiTextureEXT __GlueBindMultiTextureEXT;
		static __glCheckNamedFramebufferStatusEXT __GlueCheckNamedFramebufferStatusEXT;
		static __glClientAttribDefaultEXT __GlueClientAttribDefaultEXT;
		static __glCompressedMultiTexImage1DEXT __GlueCompressedMultiTexImage1DEXT;
		static __glCompressedMultiTexImage2DEXT __GlueCompressedMultiTexImage2DEXT;
		static __glCompressedMultiTexImage3DEXT __GlueCompressedMultiTexImage3DEXT;
		static __glCompressedMultiTexSubImage1DEXT __GlueCompressedMultiTexSubImage1DEXT;
		static __glCompressedMultiTexSubImage2DEXT __GlueCompressedMultiTexSubImage2DEXT;
		static __glCompressedMultiTexSubImage3DEXT __GlueCompressedMultiTexSubImage3DEXT;
		static __glCompressedTextureImage1DEXT __GlueCompressedTextureImage1DEXT;
		static __glCompressedTextureImage2DEXT __GlueCompressedTextureImage2DEXT;
		static __glCompressedTextureImage3DEXT __GlueCompressedTextureImage3DEXT;
		static __glCompressedTextureSubImage1DEXT __GlueCompressedTextureSubImage1DEXT;
		static __glCompressedTextureSubImage2DEXT __GlueCompressedTextureSubImage2DEXT;
		static __glCompressedTextureSubImage3DEXT __GlueCompressedTextureSubImage3DEXT;
		static __glCopyMultiTexImage1DEXT __GlueCopyMultiTexImage1DEXT;
		static __glCopyMultiTexImage2DEXT __GlueCopyMultiTexImage2DEXT;
		static __glCopyMultiTexSubImage1DEXT __GlueCopyMultiTexSubImage1DEXT;
		static __glCopyMultiTexSubImage2DEXT __GlueCopyMultiTexSubImage2DEXT;
		static __glCopyMultiTexSubImage3DEXT __GlueCopyMultiTexSubImage3DEXT;
		static __glCopyTextureImage1DEXT __GlueCopyTextureImage1DEXT;
		static __glCopyTextureImage2DEXT __GlueCopyTextureImage2DEXT;
		static __glCopyTextureSubImage1DEXT __GlueCopyTextureSubImage1DEXT;
		static __glCopyTextureSubImage2DEXT __GlueCopyTextureSubImage2DEXT;
		static __glCopyTextureSubImage3DEXT __GlueCopyTextureSubImage3DEXT;
		static __glDisableClientStateIndexedEXT __GlueDisableClientStateIndexedEXT;
		static __glDisableClientStateiEXT __GlueDisableClientStateiEXT;
		static __glDisableVertexArrayAttribEXT __GlueDisableVertexArrayAttribEXT;
		static __glDisableVertexArrayEXT __GlueDisableVertexArrayEXT;
		static __glEnableClientStateIndexedEXT __GlueEnableClientStateIndexedEXT;
		static __glEnableClientStateiEXT __GlueEnableClientStateiEXT;
		static __glEnableVertexArrayAttribEXT __GlueEnableVertexArrayAttribEXT;
		static __glEnableVertexArrayEXT __GlueEnableVertexArrayEXT;
		static __glFlushMappedNamedBufferRangeEXT __GlueFlushMappedNamedBufferRangeEXT;
		static __glFramebufferDrawBufferEXT __GlueFramebufferDrawBufferEXT;
		static __glFramebufferDrawBuffersEXT __GlueFramebufferDrawBuffersEXT;
		static __glFramebufferReadBufferEXT __GlueFramebufferReadBufferEXT;
		static __glGenerateMultiTexMipmapEXT __GlueGenerateMultiTexMipmapEXT;
		static __glGenerateTextureMipmapEXT __GlueGenerateTextureMipmapEXT;
		static __glGetCompressedMultiTexImageEXT __GlueGetCompressedMultiTexImageEXT;
		static __glGetCompressedTextureImageEXT __GlueGetCompressedTextureImageEXT;
		static __glGetDoubleIndexedvEXT __GlueGetDoubleIndexedvEXT;
		static __glGetDoublei_vEXT __GlueGetDoublei_vEXT;
		static __glGetFloatIndexedvEXT __GlueGetFloatIndexedvEXT;
		static __glGetFloati_vEXT __GlueGetFloati_vEXT;
		static __glGetFramebufferParameterivEXT __GlueGetFramebufferParameterivEXT;
		static __glGetMultiTexEnvfvEXT __GlueGetMultiTexEnvfvEXT;
		static __glGetMultiTexEnvivEXT __GlueGetMultiTexEnvivEXT;
		static __glGetMultiTexGendvEXT __GlueGetMultiTexGendvEXT;
		static __glGetMultiTexGenfvEXT __GlueGetMultiTexGenfvEXT;
		static __glGetMultiTexGenivEXT __GlueGetMultiTexGenivEXT;
		static __glGetMultiTexImageEXT __GlueGetMultiTexImageEXT;
		static __glGetMultiTexLevelParameterfvEXT __GlueGetMultiTexLevelParameterfvEXT;
		static __glGetMultiTexLevelParameterivEXT __GlueGetMultiTexLevelParameterivEXT;
		static __glGetMultiTexParameterIivEXT __GlueGetMultiTexParameterIivEXT;
		static __glGetMultiTexParameterIuivEXT __GlueGetMultiTexParameterIuivEXT;
		static __glGetMultiTexParameterfvEXT __GlueGetMultiTexParameterfvEXT;
		static __glGetMultiTexParameterivEXT __GlueGetMultiTexParameterivEXT;
		static __glGetNamedBufferParameterivEXT __GlueGetNamedBufferParameterivEXT;
		static __glGetNamedBufferPointervEXT __GlueGetNamedBufferPointervEXT;
		static __glGetNamedBufferSubDataEXT __GlueGetNamedBufferSubDataEXT;
		static __glGetNamedFramebufferAttachmentParameterivEXT __GlueGetNamedFramebufferAttachmentParameterivEXT;
		static __glGetNamedProgramLocalParameterIivEXT __GlueGetNamedProgramLocalParameterIivEXT;
		static __glGetNamedProgramLocalParameterIuivEXT __GlueGetNamedProgramLocalParameterIuivEXT;
		static __glGetNamedProgramLocalParameterdvEXT __GlueGetNamedProgramLocalParameterdvEXT;
		static __glGetNamedProgramLocalParameterfvEXT __GlueGetNamedProgramLocalParameterfvEXT;
		static __glGetNamedProgramStringEXT __GlueGetNamedProgramStringEXT;
		static __glGetNamedProgramivEXT __GlueGetNamedProgramivEXT;
		static __glGetNamedRenderbufferParameterivEXT __GlueGetNamedRenderbufferParameterivEXT;
		static __glGetPointerIndexedvEXT __GlueGetPointerIndexedvEXT;
		static __glGetPointeri_vEXT __GlueGetPointeri_vEXT;
		static __glGetTextureImageEXT __GlueGetTextureImageEXT;
		static __glGetTextureLevelParameterfvEXT __GlueGetTextureLevelParameterfvEXT;
		static __glGetTextureLevelParameterivEXT __GlueGetTextureLevelParameterivEXT;
		static __glGetTextureParameterIivEXT __GlueGetTextureParameterIivEXT;
		static __glGetTextureParameterIuivEXT __GlueGetTextureParameterIuivEXT;
		static __glGetTextureParameterfvEXT __GlueGetTextureParameterfvEXT;
		static __glGetTextureParameterivEXT __GlueGetTextureParameterivEXT;
		static __glGetVertexArrayIntegeri_vEXT __GlueGetVertexArrayIntegeri_vEXT;
		static __glGetVertexArrayIntegervEXT __GlueGetVertexArrayIntegervEXT;
		static __glGetVertexArrayPointeri_vEXT __GlueGetVertexArrayPointeri_vEXT;
		static __glGetVertexArrayPointervEXT __GlueGetVertexArrayPointervEXT;
		static __glMapNamedBufferEXT __GlueMapNamedBufferEXT;
		static __glMapNamedBufferRangeEXT __GlueMapNamedBufferRangeEXT;
		static __glMatrixFrustumEXT __GlueMatrixFrustumEXT;
		static __glMatrixLoadIdentityEXT __GlueMatrixLoadIdentityEXT;
		static __glMatrixLoadTransposedEXT __GlueMatrixLoadTransposedEXT;
		static __glMatrixLoadTransposefEXT __GlueMatrixLoadTransposefEXT;
		static __glMatrixLoaddEXT __GlueMatrixLoaddEXT;
		static __glMatrixLoadfEXT __GlueMatrixLoadfEXT;
		static __glMatrixMultTransposedEXT __GlueMatrixMultTransposedEXT;
		static __glMatrixMultTransposefEXT __GlueMatrixMultTransposefEXT;
		static __glMatrixMultdEXT __GlueMatrixMultdEXT;
		static __glMatrixMultfEXT __GlueMatrixMultfEXT;
		static __glMatrixOrthoEXT __GlueMatrixOrthoEXT;
		static __glMatrixPopEXT __GlueMatrixPopEXT;
		static __glMatrixPushEXT __GlueMatrixPushEXT;
		static __glMatrixRotatedEXT __GlueMatrixRotatedEXT;
		static __glMatrixRotatefEXT __GlueMatrixRotatefEXT;
		static __glMatrixScaledEXT __GlueMatrixScaledEXT;
		static __glMatrixScalefEXT __GlueMatrixScalefEXT;
		static __glMatrixTranslatedEXT __GlueMatrixTranslatedEXT;
		static __glMatrixTranslatefEXT __GlueMatrixTranslatefEXT;
		static __glMultiTexBufferEXT __GlueMultiTexBufferEXT;
		static __glMultiTexCoordPointerEXT __GlueMultiTexCoordPointerEXT;
		static __glMultiTexEnvfEXT __GlueMultiTexEnvfEXT;
		static __glMultiTexEnvfvEXT __GlueMultiTexEnvfvEXT;
		static __glMultiTexEnviEXT __GlueMultiTexEnviEXT;
		static __glMultiTexEnvivEXT __GlueMultiTexEnvivEXT;
		static __glMultiTexGendEXT __GlueMultiTexGendEXT;
		static __glMultiTexGendvEXT __GlueMultiTexGendvEXT;
		static __glMultiTexGenfEXT __GlueMultiTexGenfEXT;
		static __glMultiTexGenfvEXT __GlueMultiTexGenfvEXT;
		static __glMultiTexGeniEXT __GlueMultiTexGeniEXT;
		static __glMultiTexGenivEXT __GlueMultiTexGenivEXT;
		static __glMultiTexImage1DEXT __GlueMultiTexImage1DEXT;
		static __glMultiTexImage2DEXT __GlueMultiTexImage2DEXT;
		static __glMultiTexImage3DEXT __GlueMultiTexImage3DEXT;
		static __glMultiTexParameterIivEXT __GlueMultiTexParameterIivEXT;
		static __glMultiTexParameterIuivEXT __GlueMultiTexParameterIuivEXT;
		static __glMultiTexParameterfEXT __GlueMultiTexParameterfEXT;
		static __glMultiTexParameterfvEXT __GlueMultiTexParameterfvEXT;
		static __glMultiTexParameteriEXT __GlueMultiTexParameteriEXT;
		static __glMultiTexParameterivEXT __GlueMultiTexParameterivEXT;
		static __glMultiTexRenderbufferEXT __GlueMultiTexRenderbufferEXT;
		static __glMultiTexSubImage1DEXT __GlueMultiTexSubImage1DEXT;
		static __glMultiTexSubImage2DEXT __GlueMultiTexSubImage2DEXT;
		static __glMultiTexSubImage3DEXT __GlueMultiTexSubImage3DEXT;
		static __glNamedBufferDataEXT __GlueNamedBufferDataEXT;
		static __glNamedBufferSubDataEXT __GlueNamedBufferSubDataEXT;
		static __glNamedCopyBufferSubDataEXT __GlueNamedCopyBufferSubDataEXT;
		static __glNamedFramebufferRenderbufferEXT __GlueNamedFramebufferRenderbufferEXT;
		static __glNamedFramebufferTexture1DEXT __GlueNamedFramebufferTexture1DEXT;
		static __glNamedFramebufferTexture2DEXT __GlueNamedFramebufferTexture2DEXT;
		static __glNamedFramebufferTexture3DEXT __GlueNamedFramebufferTexture3DEXT;
		static __glNamedFramebufferTextureEXT __GlueNamedFramebufferTextureEXT;
		static __glNamedFramebufferTextureFaceEXT __GlueNamedFramebufferTextureFaceEXT;
		static __glNamedFramebufferTextureLayerEXT __GlueNamedFramebufferTextureLayerEXT;
		static __glNamedProgramLocalParameter4dEXT __GlueNamedProgramLocalParameter4dEXT;
		static __glNamedProgramLocalParameter4dvEXT __GlueNamedProgramLocalParameter4dvEXT;
		static __glNamedProgramLocalParameter4fEXT __GlueNamedProgramLocalParameter4fEXT;
		static __glNamedProgramLocalParameter4fvEXT __GlueNamedProgramLocalParameter4fvEXT;
		static __glNamedProgramLocalParameterI4iEXT __GlueNamedProgramLocalParameterI4iEXT;
		static __glNamedProgramLocalParameterI4ivEXT __GlueNamedProgramLocalParameterI4ivEXT;
		static __glNamedProgramLocalParameterI4uiEXT __GlueNamedProgramLocalParameterI4uiEXT;
		static __glNamedProgramLocalParameterI4uivEXT __GlueNamedProgramLocalParameterI4uivEXT;
		static __glNamedProgramLocalParameters4fvEXT __GlueNamedProgramLocalParameters4fvEXT;
		static __glNamedProgramLocalParametersI4ivEXT __GlueNamedProgramLocalParametersI4ivEXT;
		static __glNamedProgramLocalParametersI4uivEXT __GlueNamedProgramLocalParametersI4uivEXT;
		static __glNamedProgramStringEXT __GlueNamedProgramStringEXT;
		static __glNamedRenderbufferStorageEXT __GlueNamedRenderbufferStorageEXT;
		static __glNamedRenderbufferStorageMultisampleCoverageEXT __GlueNamedRenderbufferStorageMultisampleCoverageEXT;
		static __glNamedRenderbufferStorageMultisampleEXT __GlueNamedRenderbufferStorageMultisampleEXT;
		static __glProgramUniform1fEXT __GlueProgramUniform1fEXT;
		static __glProgramUniform1fvEXT __GlueProgramUniform1fvEXT;
		static __glProgramUniform1iEXT __GlueProgramUniform1iEXT;
		static __glProgramUniform1ivEXT __GlueProgramUniform1ivEXT;
		static __glProgramUniform1uiEXT __GlueProgramUniform1uiEXT;
		static __glProgramUniform1uivEXT __GlueProgramUniform1uivEXT;
		static __glProgramUniform2fEXT __GlueProgramUniform2fEXT;
		static __glProgramUniform2fvEXT __GlueProgramUniform2fvEXT;
		static __glProgramUniform2iEXT __GlueProgramUniform2iEXT;
		static __glProgramUniform2ivEXT __GlueProgramUniform2ivEXT;
		static __glProgramUniform2uiEXT __GlueProgramUniform2uiEXT;
		static __glProgramUniform2uivEXT __GlueProgramUniform2uivEXT;
		static __glProgramUniform3fEXT __GlueProgramUniform3fEXT;
		static __glProgramUniform3fvEXT __GlueProgramUniform3fvEXT;
		static __glProgramUniform3iEXT __GlueProgramUniform3iEXT;
		static __glProgramUniform3ivEXT __GlueProgramUniform3ivEXT;
		static __glProgramUniform3uiEXT __GlueProgramUniform3uiEXT;
		static __glProgramUniform3uivEXT __GlueProgramUniform3uivEXT;
		static __glProgramUniform4fEXT __GlueProgramUniform4fEXT;
		static __glProgramUniform4fvEXT __GlueProgramUniform4fvEXT;
		static __glProgramUniform4iEXT __GlueProgramUniform4iEXT;
		static __glProgramUniform4ivEXT __GlueProgramUniform4ivEXT;
		static __glProgramUniform4uiEXT __GlueProgramUniform4uiEXT;
		static __glProgramUniform4uivEXT __GlueProgramUniform4uivEXT;
		static __glProgramUniformMatrix2fvEXT __GlueProgramUniformMatrix2fvEXT;
		static __glProgramUniformMatrix2x3fvEXT __GlueProgramUniformMatrix2x3fvEXT;
		static __glProgramUniformMatrix2x4fvEXT __GlueProgramUniformMatrix2x4fvEXT;
		static __glProgramUniformMatrix3fvEXT __GlueProgramUniformMatrix3fvEXT;
		static __glProgramUniformMatrix3x2fvEXT __GlueProgramUniformMatrix3x2fvEXT;
		static __glProgramUniformMatrix3x4fvEXT __GlueProgramUniformMatrix3x4fvEXT;
		static __glProgramUniformMatrix4fvEXT __GlueProgramUniformMatrix4fvEXT;
		static __glProgramUniformMatrix4x2fvEXT __GlueProgramUniformMatrix4x2fvEXT;
		static __glProgramUniformMatrix4x3fvEXT __GlueProgramUniformMatrix4x3fvEXT;
		static __glPushClientAttribDefaultEXT __GluePushClientAttribDefaultEXT;
		static __glTextureBufferEXT __GlueTextureBufferEXT;
		static __glTextureImage1DEXT __GlueTextureImage1DEXT;
		static __glTextureImage2DEXT __GlueTextureImage2DEXT;
		static __glTextureImage3DEXT __GlueTextureImage3DEXT;
		static __glTextureParameterIivEXT __GlueTextureParameterIivEXT;
		static __glTextureParameterIuivEXT __GlueTextureParameterIuivEXT;
		static __glTextureParameterfEXT __GlueTextureParameterfEXT;
		static __glTextureParameterfvEXT __GlueTextureParameterfvEXT;
		static __glTextureParameteriEXT __GlueTextureParameteriEXT;
		static __glTextureParameterivEXT __GlueTextureParameterivEXT;
		static __glTextureRenderbufferEXT __GlueTextureRenderbufferEXT;
		static __glTextureSubImage1DEXT __GlueTextureSubImage1DEXT;
		static __glTextureSubImage2DEXT __GlueTextureSubImage2DEXT;
		static __glTextureSubImage3DEXT __GlueTextureSubImage3DEXT;
		static __glUnmapNamedBufferEXT __GlueUnmapNamedBufferEXT;
		static __glVertexArrayColorOffsetEXT __GlueVertexArrayColorOffsetEXT;
		static __glVertexArrayEdgeFlagOffsetEXT __GlueVertexArrayEdgeFlagOffsetEXT;
		static __glVertexArrayFogCoordOffsetEXT __GlueVertexArrayFogCoordOffsetEXT;
		static __glVertexArrayIndexOffsetEXT __GlueVertexArrayIndexOffsetEXT;
		static __glVertexArrayMultiTexCoordOffsetEXT __GlueVertexArrayMultiTexCoordOffsetEXT;
		static __glVertexArrayNormalOffsetEXT __GlueVertexArrayNormalOffsetEXT;
		static __glVertexArraySecondaryColorOffsetEXT __GlueVertexArraySecondaryColorOffsetEXT;
		static __glVertexArrayTexCoordOffsetEXT __GlueVertexArrayTexCoordOffsetEXT;
		static __glVertexArrayVertexAttribDivisorEXT __GlueVertexArrayVertexAttribDivisorEXT;
		static __glVertexArrayVertexAttribIOffsetEXT __GlueVertexArrayVertexAttribIOffsetEXT;
		static __glVertexArrayVertexAttribOffsetEXT __GlueVertexArrayVertexAttribOffsetEXT;
		static __glVertexArrayVertexOffsetEXT __GlueVertexArrayVertexOffsetEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindMultiTextureEXT(uint texunit, uint target, uint texture) => __GlueBindMultiTextureEXT(texunit, target, texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCheckNamedFramebufferStatusEXT(uint framebuffer, uint target) => __GlueCheckNamedFramebufferStatusEXT(framebuffer, target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClientAttribDefaultEXT(uint mask) => __GlueClientAttribDefaultEXT(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedMultiTexImage1DEXT(uint texunit, uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data) => __GlueCompressedMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedMultiTexImage2DEXT(uint texunit, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data) => __GlueCompressedMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedMultiTexImage3DEXT(uint texunit, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data) => __GlueCompressedMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => __GlueCompressedMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => __GlueCompressedMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => __GlueCompressedMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureImage1DEXT(uint texture, uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data) => __GlueCompressedTextureImage1DEXT(texture, target, level, internalformat, width, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureImage2DEXT(uint texture, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data) => __GlueCompressedTextureImage2DEXT(texture, target, level, internalformat, width, height, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureImage3DEXT(uint texture, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data) => __GlueCompressedTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => __GlueCompressedTextureSubImage1DEXT(texture, target, level, xoffset, width, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => __GlueCompressedTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => __GlueCompressedTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyMultiTexImage1DEXT(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int border) => __GlueCopyMultiTexImage1DEXT(texunit, target, level, internalformat, x, y, width, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyMultiTexImage2DEXT(uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int height, int border) => __GlueCopyMultiTexImage2DEXT(texunit, target, level, internalformat, x, y, width, height, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int x, int y, int width) => __GlueCopyMultiTexSubImage1DEXT(texunit, target, level, xoffset, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => __GlueCopyMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => __GlueCopyMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureImage1DEXT(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int border) => __GlueCopyTextureImage1DEXT(texture, target, level, internalformat, x, y, width, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureImage2DEXT(uint texture, uint target, int level, uint internalformat, int x, int y, int width, int height, int border) => __GlueCopyTextureImage2DEXT(texture, target, level, internalformat, x, y, width, height, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int x, int y, int width) => __GlueCopyTextureSubImage1DEXT(texture, target, level, xoffset, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => __GlueCopyTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => __GlueCopyTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableClientStateIndexedEXT(uint array, uint index) => __GlueDisableClientStateIndexedEXT(array, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableClientStateiEXT(uint array, uint index) => __GlueDisableClientStateiEXT(array, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableVertexArrayAttribEXT(uint vaobj, uint index) => __GlueDisableVertexArrayAttribEXT(vaobj, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableVertexArrayEXT(uint vaobj, uint array) => __GlueDisableVertexArrayEXT(vaobj, array);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableClientStateIndexedEXT(uint array, uint index) => __GlueEnableClientStateIndexedEXT(array, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableClientStateiEXT(uint array, uint index) => __GlueEnableClientStateiEXT(array, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableVertexArrayAttribEXT(uint vaobj, uint index) => __GlueEnableVertexArrayAttribEXT(vaobj, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableVertexArrayEXT(uint vaobj, uint array) => __GlueEnableVertexArrayEXT(vaobj, array);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFlushMappedNamedBufferRangeEXT(uint buffer, int offset, int length) => __GlueFlushMappedNamedBufferRangeEXT(buffer, offset, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferDrawBufferEXT(uint framebuffer, uint mode) => __GlueFramebufferDrawBufferEXT(framebuffer, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferDrawBuffersEXT(uint framebuffer, int n, uint* bufs) => __GlueFramebufferDrawBuffersEXT(framebuffer, n, bufs);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFramebufferReadBufferEXT(uint framebuffer, uint mode) => __GlueFramebufferReadBufferEXT(framebuffer, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenerateMultiTexMipmapEXT(uint texunit, uint target) => __GlueGenerateMultiTexMipmapEXT(texunit, target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenerateTextureMipmapEXT(uint texture, uint target) => __GlueGenerateTextureMipmapEXT(texture, target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCompressedMultiTexImageEXT(uint texunit, uint target, int level, IntPtr img) => __GlueGetCompressedMultiTexImageEXT(texunit, target, level, img);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCompressedTextureImageEXT(uint texture, uint target, int level, IntPtr img) => __GlueGetCompressedTextureImageEXT(texture, target, level, img);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetDoubleIndexedvEXT(uint target, uint index, double* parameters) => __GlueGetDoubleIndexedvEXT(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetDoublei_vEXT(uint pname, uint index, double* parameters) => __GlueGetDoublei_vEXT(pname, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFloatIndexedvEXT(uint target, uint index, float* parameters) => __GlueGetFloatIndexedvEXT(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFloati_vEXT(uint pname, uint index, float* parameters) => __GlueGetFloati_vEXT(pname, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFramebufferParameterivEXT(uint framebuffer, uint pname, int* param) => __GlueGetFramebufferParameterivEXT(framebuffer, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexEnvfvEXT(uint texunit, uint target, uint pname, float* parameters) => __GlueGetMultiTexEnvfvEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexEnvivEXT(uint texunit, uint target, uint pname, int* parameters) => __GlueGetMultiTexEnvivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexGendvEXT(uint texunit, uint coord, uint pname, double* parameters) => __GlueGetMultiTexGendvEXT(texunit, coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexGenfvEXT(uint texunit, uint coord, uint pname, float* parameters) => __GlueGetMultiTexGenfvEXT(texunit, coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexGenivEXT(uint texunit, uint coord, uint pname, int* parameters) => __GlueGetMultiTexGenivEXT(texunit, coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexImageEXT(uint texunit, uint target, int level, uint format, uint type, IntPtr pixels) => __GlueGetMultiTexImageEXT(texunit, target, level, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexLevelParameterfvEXT(uint texunit, uint target, int level, uint pname, float* parameters) => __GlueGetMultiTexLevelParameterfvEXT(texunit, target, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexLevelParameterivEXT(uint texunit, uint target, int level, uint pname, int* parameters) => __GlueGetMultiTexLevelParameterivEXT(texunit, target, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexParameterIivEXT(uint texunit, uint target, uint pname, int* parameters) => __GlueGetMultiTexParameterIivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexParameterIuivEXT(uint texunit, uint target, uint pname, uint* parameters) => __GlueGetMultiTexParameterIuivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexParameterfvEXT(uint texunit, uint target, uint pname, float* parameters) => __GlueGetMultiTexParameterfvEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMultiTexParameterivEXT(uint texunit, uint target, uint pname, int* parameters) => __GlueGetMultiTexParameterivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferParameterivEXT(uint buffer, uint pname, int* parameters) => __GlueGetNamedBufferParameterivEXT(buffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferPointervEXT(uint buffer, uint pname, IntPtr* parameters) => __GlueGetNamedBufferPointervEXT(buffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferSubDataEXT(uint buffer, int offset, int size, IntPtr data) => __GlueGetNamedBufferSubDataEXT(buffer, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedFramebufferAttachmentParameterivEXT(uint framebuffer, uint attachment, uint pname, int* parameters) => __GlueGetNamedFramebufferAttachmentParameterivEXT(framebuffer, attachment, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedProgramLocalParameterIivEXT(uint program, uint target, uint index, int* parameters) => __GlueGetNamedProgramLocalParameterIivEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedProgramLocalParameterIuivEXT(uint program, uint target, uint index, uint* parameters) => __GlueGetNamedProgramLocalParameterIuivEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedProgramLocalParameterdvEXT(uint program, uint target, uint index, double* parameters) => __GlueGetNamedProgramLocalParameterdvEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedProgramLocalParameterfvEXT(uint program, uint target, uint index, float* parameters) => __GlueGetNamedProgramLocalParameterfvEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedProgramStringEXT(uint program, uint target, uint pname, IntPtr str) => __GlueGetNamedProgramStringEXT(program, target, pname, str);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedProgramivEXT(uint program, uint target, uint pname, int* parameters) => __GlueGetNamedProgramivEXT(program, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedRenderbufferParameterivEXT(uint renderbuffer, uint pname, int* parameters) => __GlueGetNamedRenderbufferParameterivEXT(renderbuffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPointerIndexedvEXT(uint target, uint index, IntPtr* parameters) => __GlueGetPointerIndexedvEXT(target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPointeri_vEXT(uint pname, uint index, IntPtr* parameters) => __GlueGetPointeri_vEXT(pname, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureImageEXT(uint texture, uint target, int level, uint format, uint type, IntPtr pixels) => __GlueGetTextureImageEXT(texture, target, level, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureLevelParameterfvEXT(uint texture, uint target, int level, uint pname, float* parameters) => __GlueGetTextureLevelParameterfvEXT(texture, target, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureLevelParameterivEXT(uint texture, uint target, int level, uint pname, int* parameters) => __GlueGetTextureLevelParameterivEXT(texture, target, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterIivEXT(uint texture, uint target, uint pname, int* parameters) => __GlueGetTextureParameterIivEXT(texture, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterIuivEXT(uint texture, uint target, uint pname, uint* parameters) => __GlueGetTextureParameterIuivEXT(texture, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterfvEXT(uint texture, uint target, uint pname, float* parameters) => __GlueGetTextureParameterfvEXT(texture, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterivEXT(uint texture, uint target, uint pname, int* parameters) => __GlueGetTextureParameterivEXT(texture, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, uint pname, int* param) => __GlueGetVertexArrayIntegeri_vEXT(vaobj, index, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayIntegervEXT(uint vaobj, uint pname, int* param) => __GlueGetVertexArrayIntegervEXT(vaobj, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayPointeri_vEXT(uint vaobj, uint index, uint pname, IntPtr* param) => __GlueGetVertexArrayPointeri_vEXT(vaobj, index, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayPointervEXT(uint vaobj, uint pname, IntPtr* param) => __GlueGetVertexArrayPointervEXT(vaobj, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapNamedBufferEXT(uint buffer, uint access) => __GlueMapNamedBufferEXT(buffer, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapNamedBufferRangeEXT(uint buffer, int offset, int length, uint access) => __GlueMapNamedBufferRangeEXT(buffer, offset, length, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixFrustumEXT(uint matrixMode, double l, double r, double b, double t, double n, double f) => __GlueMatrixFrustumEXT(matrixMode, l, r, b, t, n, f);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixLoadIdentityEXT(uint matrixMode) => __GlueMatrixLoadIdentityEXT(matrixMode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixLoadTransposedEXT(uint matrixMode, double* m) => __GlueMatrixLoadTransposedEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixLoadTransposefEXT(uint matrixMode, float* m) => __GlueMatrixLoadTransposefEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixLoaddEXT(uint matrixMode, double* m) => __GlueMatrixLoaddEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixLoadfEXT(uint matrixMode, float* m) => __GlueMatrixLoadfEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixMultTransposedEXT(uint matrixMode, double* m) => __GlueMatrixMultTransposedEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixMultTransposefEXT(uint matrixMode, float* m) => __GlueMatrixMultTransposefEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixMultdEXT(uint matrixMode, double* m) => __GlueMatrixMultdEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixMultfEXT(uint matrixMode, float* m) => __GlueMatrixMultfEXT(matrixMode, m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixOrthoEXT(uint matrixMode, double l, double r, double b, double t, double n, double f) => __GlueMatrixOrthoEXT(matrixMode, l, r, b, t, n, f);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixPopEXT(uint matrixMode) => __GlueMatrixPopEXT(matrixMode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixPushEXT(uint matrixMode) => __GlueMatrixPushEXT(matrixMode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixRotatedEXT(uint matrixMode, double angle, double x, double y, double z) => __GlueMatrixRotatedEXT(matrixMode, angle, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixRotatefEXT(uint matrixMode, float angle, float x, float y, float z) => __GlueMatrixRotatefEXT(matrixMode, angle, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixScaledEXT(uint matrixMode, double x, double y, double z) => __GlueMatrixScaledEXT(matrixMode, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixScalefEXT(uint matrixMode, float x, float y, float z) => __GlueMatrixScalefEXT(matrixMode, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixTranslatedEXT(uint matrixMode, double x, double y, double z) => __GlueMatrixTranslatedEXT(matrixMode, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixTranslatefEXT(uint matrixMode, float x, float y, float z) => __GlueMatrixTranslatefEXT(matrixMode, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexBufferEXT(uint texunit, uint target, uint internalformat, uint buffer) => __GlueMultiTexBufferEXT(texunit, target, internalformat, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordPointerEXT(uint texunit, int size, uint type, int stride, IntPtr pointer) => __GlueMultiTexCoordPointerEXT(texunit, size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexEnvfEXT(uint texunit, uint target, uint pname, float param) => __GlueMultiTexEnvfEXT(texunit, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexEnvfvEXT(uint texunit, uint target, uint pname, float* parameters) => __GlueMultiTexEnvfvEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexEnviEXT(uint texunit, uint target, uint pname, int param) => __GlueMultiTexEnviEXT(texunit, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexEnvivEXT(uint texunit, uint target, uint pname, int* parameters) => __GlueMultiTexEnvivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexGendEXT(uint texunit, uint coord, uint pname, double param) => __GlueMultiTexGendEXT(texunit, coord, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexGendvEXT(uint texunit, uint coord, uint pname, double* parameters) => __GlueMultiTexGendvEXT(texunit, coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexGenfEXT(uint texunit, uint coord, uint pname, float param) => __GlueMultiTexGenfEXT(texunit, coord, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexGenfvEXT(uint texunit, uint coord, uint pname, float* parameters) => __GlueMultiTexGenfvEXT(texunit, coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexGeniEXT(uint texunit, uint coord, uint pname, int param) => __GlueMultiTexGeniEXT(texunit, coord, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexGenivEXT(uint texunit, uint coord, uint pname, int* parameters) => __GlueMultiTexGenivEXT(texunit, coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexImage1DEXT(uint texunit, uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels) => __GlueMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexImage2DEXT(uint texunit, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels) => __GlueMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexImage3DEXT(uint texunit, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels) => __GlueMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexParameterIivEXT(uint texunit, uint target, uint pname, int* parameters) => __GlueMultiTexParameterIivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexParameterIuivEXT(uint texunit, uint target, uint pname, uint* parameters) => __GlueMultiTexParameterIuivEXT(texunit, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexParameterfEXT(uint texunit, uint target, uint pname, float param) => __GlueMultiTexParameterfEXT(texunit, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexParameterfvEXT(uint texunit, uint target, uint pname, float* param) => __GlueMultiTexParameterfvEXT(texunit, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexParameteriEXT(uint texunit, uint target, uint pname, int param) => __GlueMultiTexParameteriEXT(texunit, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexParameterivEXT(uint texunit, uint target, uint pname, int* param) => __GlueMultiTexParameterivEXT(texunit, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexRenderbufferEXT(uint texunit, uint target, uint renderbuffer) => __GlueMultiTexRenderbufferEXT(texunit, target, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexSubImage1DEXT(uint texunit, uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => __GlueMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexSubImage2DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => __GlueMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexSubImage3DEXT(uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => __GlueMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferDataEXT(uint buffer, int size, IntPtr data, uint usage) => __GlueNamedBufferDataEXT(buffer, size, data, usage);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferSubDataEXT(uint buffer, int offset, int size, IntPtr data) => __GlueNamedBufferSubDataEXT(buffer, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedCopyBufferSubDataEXT(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size) => __GlueNamedCopyBufferSubDataEXT(readBuffer, writeBuffer, readOffset, writeOffset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferRenderbufferEXT(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) => __GlueNamedFramebufferRenderbufferEXT(framebuffer, attachment, renderbuffertarget, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTexture1DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level) => __GlueNamedFramebufferTexture1DEXT(framebuffer, attachment, textarget, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTexture2DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level) => __GlueNamedFramebufferTexture2DEXT(framebuffer, attachment, textarget, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTexture3DEXT(uint framebuffer, uint attachment, uint textarget, uint texture, int level, int zoffset) => __GlueNamedFramebufferTexture3DEXT(framebuffer, attachment, textarget, texture, level, zoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTextureEXT(uint framebuffer, uint attachment, uint texture, int level) => __GlueNamedFramebufferTextureEXT(framebuffer, attachment, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTextureFaceEXT(uint framebuffer, uint attachment, uint texture, int level, uint face) => __GlueNamedFramebufferTextureFaceEXT(framebuffer, attachment, texture, level, face);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTextureLayerEXT(uint framebuffer, uint attachment, uint texture, int level, int layer) => __GlueNamedFramebufferTextureLayerEXT(framebuffer, attachment, texture, level, layer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameter4dEXT(uint program, uint target, uint index, double x, double y, double z, double w) => __GlueNamedProgramLocalParameter4dEXT(program, target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameter4dvEXT(uint program, uint target, uint index, double* parameters) => __GlueNamedProgramLocalParameter4dvEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameter4fEXT(uint program, uint target, uint index, float x, float y, float z, float w) => __GlueNamedProgramLocalParameter4fEXT(program, target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameter4fvEXT(uint program, uint target, uint index, float* parameters) => __GlueNamedProgramLocalParameter4fvEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameterI4iEXT(uint program, uint target, uint index, int x, int y, int z, int w) => __GlueNamedProgramLocalParameterI4iEXT(program, target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameterI4ivEXT(uint program, uint target, uint index, int* parameters) => __GlueNamedProgramLocalParameterI4ivEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameterI4uiEXT(uint program, uint target, uint index, uint x, uint y, uint z, uint w) => __GlueNamedProgramLocalParameterI4uiEXT(program, target, index, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameterI4uivEXT(uint program, uint target, uint index, uint* parameters) => __GlueNamedProgramLocalParameterI4uivEXT(program, target, index, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParameters4fvEXT(uint program, uint target, uint index, int count, float* parameters) => __GlueNamedProgramLocalParameters4fvEXT(program, target, index, count, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParametersI4ivEXT(uint program, uint target, uint index, int count, int* parameters) => __GlueNamedProgramLocalParametersI4ivEXT(program, target, index, count, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramLocalParametersI4uivEXT(uint program, uint target, uint index, int count, uint* parameters) => __GlueNamedProgramLocalParametersI4uivEXT(program, target, index, count, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedProgramStringEXT(uint program, uint target, uint format, int len, IntPtr str) => __GlueNamedProgramStringEXT(program, target, format, len, str);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedRenderbufferStorageEXT(uint renderbuffer, uint internalformat, int width, int height) => __GlueNamedRenderbufferStorageEXT(renderbuffer, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedRenderbufferStorageMultisampleCoverageEXT(uint renderbuffer, int coverageSamples, int colorSamples, uint internalformat, int width, int height) => __GlueNamedRenderbufferStorageMultisampleCoverageEXT(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedRenderbufferStorageMultisampleEXT(uint renderbuffer, int samples, uint internalformat, int width, int height) => __GlueNamedRenderbufferStorageMultisampleEXT(renderbuffer, samples, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1fEXT(uint program, int location, float v0) => __GlueProgramUniform1fEXT(program, location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1fvEXT(uint program, int location, int count, float* value) => __GlueProgramUniform1fvEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1iEXT(uint program, int location, int v0) => __GlueProgramUniform1iEXT(program, location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1ivEXT(uint program, int location, int count, int* value) => __GlueProgramUniform1ivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1uiEXT(uint program, int location, uint v0) => __GlueProgramUniform1uiEXT(program, location, v0);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1uivEXT(uint program, int location, int count, uint* value) => __GlueProgramUniform1uivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2fEXT(uint program, int location, float v0, float v1) => __GlueProgramUniform2fEXT(program, location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2fvEXT(uint program, int location, int count, float* value) => __GlueProgramUniform2fvEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2iEXT(uint program, int location, int v0, int v1) => __GlueProgramUniform2iEXT(program, location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2ivEXT(uint program, int location, int count, int* value) => __GlueProgramUniform2ivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2uiEXT(uint program, int location, uint v0, uint v1) => __GlueProgramUniform2uiEXT(program, location, v0, v1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2uivEXT(uint program, int location, int count, uint* value) => __GlueProgramUniform2uivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3fEXT(uint program, int location, float v0, float v1, float v2) => __GlueProgramUniform3fEXT(program, location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3fvEXT(uint program, int location, int count, float* value) => __GlueProgramUniform3fvEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3iEXT(uint program, int location, int v0, int v1, int v2) => __GlueProgramUniform3iEXT(program, location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3ivEXT(uint program, int location, int count, int* value) => __GlueProgramUniform3ivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3uiEXT(uint program, int location, uint v0, uint v1, uint v2) => __GlueProgramUniform3uiEXT(program, location, v0, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3uivEXT(uint program, int location, int count, uint* value) => __GlueProgramUniform3uivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4fEXT(uint program, int location, float v0, float v1, float v2, float v3) => __GlueProgramUniform4fEXT(program, location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4fvEXT(uint program, int location, int count, float* value) => __GlueProgramUniform4fvEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4iEXT(uint program, int location, int v0, int v1, int v2, int v3) => __GlueProgramUniform4iEXT(program, location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4ivEXT(uint program, int location, int count, int* value) => __GlueProgramUniform4ivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4uiEXT(uint program, int location, uint v0, uint v1, uint v2, uint v3) => __GlueProgramUniform4uiEXT(program, location, v0, v1, v2, v3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4uivEXT(uint program, int location, int count, uint* value) => __GlueProgramUniform4uivEXT(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix2fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2x3fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix2x3fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2x4fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix2x4fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix3fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3x2fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix3x2fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3x4fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix3x4fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix4fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4x2fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix4x2fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4x3fvEXT(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix4x3fvEXT(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPushClientAttribDefaultEXT(uint mask) => __GluePushClientAttribDefaultEXT(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureBufferEXT(uint texture, uint target, uint internalformat, uint buffer) => __GlueTextureBufferEXT(texture, target, internalformat, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureImage1DEXT(uint texture, uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels) => __GlueTextureImage1DEXT(texture, target, level, internalformat, width, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureImage2DEXT(uint texture, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels) => __GlueTextureImage2DEXT(texture, target, level, internalformat, width, height, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureImage3DEXT(uint texture, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels) => __GlueTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterIivEXT(uint texture, uint target, uint pname, int* parameters) => __GlueTextureParameterIivEXT(texture, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterIuivEXT(uint texture, uint target, uint pname, uint* parameters) => __GlueTextureParameterIuivEXT(texture, target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterfEXT(uint texture, uint target, uint pname, float param) => __GlueTextureParameterfEXT(texture, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterfvEXT(uint texture, uint target, uint pname, float* param) => __GlueTextureParameterfvEXT(texture, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameteriEXT(uint texture, uint target, uint pname, int param) => __GlueTextureParameteriEXT(texture, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterivEXT(uint texture, uint target, uint pname, int* param) => __GlueTextureParameterivEXT(texture, target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureRenderbufferEXT(uint texture, uint target, uint renderbuffer) => __GlueTextureRenderbufferEXT(texture, target, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureSubImage1DEXT(uint texture, uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => __GlueTextureSubImage1DEXT(texture, target, level, xoffset, width, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureSubImage2DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => __GlueTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureSubImage3DEXT(uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => __GlueTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glUnmapNamedBufferEXT(uint buffer) => __GlueUnmapNamedBufferEXT(buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayColorOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset) => __GlueVertexArrayColorOffsetEXT(vaobj, buffer, size, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayEdgeFlagOffsetEXT(uint vaobj, uint buffer, int stride, int offset) => __GlueVertexArrayEdgeFlagOffsetEXT(vaobj, buffer, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayFogCoordOffsetEXT(uint vaobj, uint buffer, uint type, int stride, int offset) => __GlueVertexArrayFogCoordOffsetEXT(vaobj, buffer, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayIndexOffsetEXT(uint vaobj, uint buffer, uint type, int stride, int offset) => __GlueVertexArrayIndexOffsetEXT(vaobj, buffer, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayMultiTexCoordOffsetEXT(uint vaobj, uint buffer, uint texunit, int size, uint type, int stride, int offset) => __GlueVertexArrayMultiTexCoordOffsetEXT(vaobj, buffer, texunit, size, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayNormalOffsetEXT(uint vaobj, uint buffer, uint type, int stride, int offset) => __GlueVertexArrayNormalOffsetEXT(vaobj, buffer, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArraySecondaryColorOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset) => __GlueVertexArraySecondaryColorOffsetEXT(vaobj, buffer, size, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayTexCoordOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset) => __GlueVertexArrayTexCoordOffsetEXT(vaobj, buffer, size, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor) => __GlueVertexArrayVertexAttribDivisorEXT(vaobj, index, divisor);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, int stride, int offset) => __GlueVertexArrayVertexAttribIOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexAttribOffsetEXT(uint vaobj, uint buffer, uint index, int size, uint type, bool normalized, int stride, int offset) => __GlueVertexArrayVertexAttribOffsetEXT(vaobj, buffer, index, size, type, normalized, stride, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexOffsetEXT(uint vaobj, uint buffer, int size, uint type, int stride, int offset) => __GlueVertexArrayVertexOffsetEXT(vaobj, buffer, size, type, stride, offset);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_direct_state_access {get; private set;}

		public const int GL_TEXTURE_TARGET = 0x1006;
		public const int GL_QUERY_TARGET = 0x82EA;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindTextureUnit(uint unit, uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCheckNamedFramebufferStatus(uint framebuffer, uint target);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateBuffers(int n, uint* buffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateFramebuffers(int n, uint* framebuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateProgramPipelines(int n, uint* pipelines);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateQueries(uint target, int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateRenderbuffers(int n, uint* renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateSamplers(int n, uint* samplers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateTextures(uint target, int n, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateTransformFeedbacks(int n, uint* ids);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCreateVertexArrays(int n, uint* arrays);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableVertexArrayAttrib(uint vaobj, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableVertexArrayAttrib(uint vaobj, uint index);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFlushMappedNamedBufferRange(uint buffer, int offset, int length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenerateTextureMipmap(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferParameteri64v(uint buffer, uint pname, long* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferParameteriv(uint buffer, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferPointerv(uint buffer, uint pname, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureLevelParameterfv(uint texture, int level, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureLevelParameteriv(uint texture, int level, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterIiv(uint texture, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterIuiv(uint texture, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameterfv(uint texture, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTextureParameteriv(uint texture, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTransformFeedbackiv(uint xfb, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexArrayiv(uint vaobj, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapNamedBuffer(uint buffer, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate IntPtr  __glMapNamedBufferRange(uint buffer, int offset, int length, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferData(uint buffer, int size, IntPtr data, uint usage);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferStorage(uint buffer, int size, IntPtr data, uint flags);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedBufferSubData(uint buffer, int offset, int size, IntPtr data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferDrawBuffer(uint framebuffer, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferParameteri(uint framebuffer, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferReadBuffer(uint framebuffer, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureBuffer(uint texture, uint internalformat, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterIiv(uint texture, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterIuiv(uint texture, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterf(uint texture, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameterfv(uint texture, uint pname, float* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameteri(uint texture, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureParameteriv(uint texture, uint pname, int* param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage1D(uint texture, int levels, uint internalformat, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glUnmapNamedBuffer(uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayElementBuffer(uint vaobj, uint buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int* offsets, int* strides);

 		static __glBindTextureUnit __GlueBindTextureUnit;
		static __glBlitNamedFramebuffer __GlueBlitNamedFramebuffer;
		static __glCheckNamedFramebufferStatus __GlueCheckNamedFramebufferStatus;
		static __glClearNamedBufferData __GlueClearNamedBufferData;
		static __glClearNamedBufferSubData __GlueClearNamedBufferSubData;
		static __glClearNamedFramebufferfi __GlueClearNamedFramebufferfi;
		static __glClearNamedFramebufferfv __GlueClearNamedFramebufferfv;
		static __glClearNamedFramebufferiv __GlueClearNamedFramebufferiv;
		static __glClearNamedFramebufferuiv __GlueClearNamedFramebufferuiv;
		static __glCompressedTextureSubImage1D __GlueCompressedTextureSubImage1D;
		static __glCompressedTextureSubImage2D __GlueCompressedTextureSubImage2D;
		static __glCompressedTextureSubImage3D __GlueCompressedTextureSubImage3D;
		static __glCopyNamedBufferSubData __GlueCopyNamedBufferSubData;
		static __glCopyTextureSubImage1D __GlueCopyTextureSubImage1D;
		static __glCopyTextureSubImage2D __GlueCopyTextureSubImage2D;
		static __glCopyTextureSubImage3D __GlueCopyTextureSubImage3D;
		static __glCreateBuffers __GlueCreateBuffers;
		static __glCreateFramebuffers __GlueCreateFramebuffers;
		static __glCreateProgramPipelines __GlueCreateProgramPipelines;
		static __glCreateQueries __GlueCreateQueries;
		static __glCreateRenderbuffers __GlueCreateRenderbuffers;
		static __glCreateSamplers __GlueCreateSamplers;
		static __glCreateTextures __GlueCreateTextures;
		static __glCreateTransformFeedbacks __GlueCreateTransformFeedbacks;
		static __glCreateVertexArrays __GlueCreateVertexArrays;
		static __glDisableVertexArrayAttrib __GlueDisableVertexArrayAttrib;
		static __glEnableVertexArrayAttrib __GlueEnableVertexArrayAttrib;
		static __glFlushMappedNamedBufferRange __GlueFlushMappedNamedBufferRange;
		static __glGenerateTextureMipmap __GlueGenerateTextureMipmap;
		static __glGetCompressedTextureImage __GlueGetCompressedTextureImage;
		static __glGetNamedBufferParameteri64v __GlueGetNamedBufferParameteri64v;
		static __glGetNamedBufferParameteriv __GlueGetNamedBufferParameteriv;
		static __glGetNamedBufferPointerv __GlueGetNamedBufferPointerv;
		static __glGetNamedBufferSubData __GlueGetNamedBufferSubData;
		static __glGetNamedFramebufferAttachmentParameteriv __GlueGetNamedFramebufferAttachmentParameteriv;
		static __glGetNamedFramebufferParameteriv __GlueGetNamedFramebufferParameteriv;
		static __glGetNamedRenderbufferParameteriv __GlueGetNamedRenderbufferParameteriv;
		static __glGetQueryBufferObjecti64v __GlueGetQueryBufferObjecti64v;
		static __glGetQueryBufferObjectiv __GlueGetQueryBufferObjectiv;
		static __glGetQueryBufferObjectui64v __GlueGetQueryBufferObjectui64v;
		static __glGetQueryBufferObjectuiv __GlueGetQueryBufferObjectuiv;
		static __glGetTextureImage __GlueGetTextureImage;
		static __glGetTextureLevelParameterfv __GlueGetTextureLevelParameterfv;
		static __glGetTextureLevelParameteriv __GlueGetTextureLevelParameteriv;
		static __glGetTextureParameterIiv __GlueGetTextureParameterIiv;
		static __glGetTextureParameterIuiv __GlueGetTextureParameterIuiv;
		static __glGetTextureParameterfv __GlueGetTextureParameterfv;
		static __glGetTextureParameteriv __GlueGetTextureParameteriv;
		static __glGetTransformFeedbacki64_v __GlueGetTransformFeedbacki64_v;
		static __glGetTransformFeedbacki_v __GlueGetTransformFeedbacki_v;
		static __glGetTransformFeedbackiv __GlueGetTransformFeedbackiv;
		static __glGetVertexArrayIndexed64iv __GlueGetVertexArrayIndexed64iv;
		static __glGetVertexArrayIndexediv __GlueGetVertexArrayIndexediv;
		static __glGetVertexArrayiv __GlueGetVertexArrayiv;
		static __glInvalidateNamedFramebufferData __GlueInvalidateNamedFramebufferData;
		static __glInvalidateNamedFramebufferSubData __GlueInvalidateNamedFramebufferSubData;
		static __glMapNamedBuffer __GlueMapNamedBuffer;
		static __glMapNamedBufferRange __GlueMapNamedBufferRange;
		static __glNamedBufferData __GlueNamedBufferData;
		static __glNamedBufferStorage __GlueNamedBufferStorage;
		static __glNamedBufferSubData __GlueNamedBufferSubData;
		static __glNamedFramebufferDrawBuffer __GlueNamedFramebufferDrawBuffer;
		static __glNamedFramebufferDrawBuffers __GlueNamedFramebufferDrawBuffers;
		static __glNamedFramebufferParameteri __GlueNamedFramebufferParameteri;
		static __glNamedFramebufferReadBuffer __GlueNamedFramebufferReadBuffer;
		static __glNamedFramebufferRenderbuffer __GlueNamedFramebufferRenderbuffer;
		static __glNamedFramebufferTexture __GlueNamedFramebufferTexture;
		static __glNamedFramebufferTextureLayer __GlueNamedFramebufferTextureLayer;
		static __glNamedRenderbufferStorage __GlueNamedRenderbufferStorage;
		static __glNamedRenderbufferStorageMultisample __GlueNamedRenderbufferStorageMultisample;
		static __glTextureBuffer __GlueTextureBuffer;
		static __glTextureBufferRange __GlueTextureBufferRange;
		static __glTextureParameterIiv __GlueTextureParameterIiv;
		static __glTextureParameterIuiv __GlueTextureParameterIuiv;
		static __glTextureParameterf __GlueTextureParameterf;
		static __glTextureParameterfv __GlueTextureParameterfv;
		static __glTextureParameteri __GlueTextureParameteri;
		static __glTextureParameteriv __GlueTextureParameteriv;
		static __glTextureStorage1D __GlueTextureStorage1D;
		static __glTextureStorage2D __GlueTextureStorage2D;
		static __glTextureStorage2DMultisample __GlueTextureStorage2DMultisample;
		static __glTextureStorage3D __GlueTextureStorage3D;
		static __glTextureStorage3DMultisample __GlueTextureStorage3DMultisample;
		static __glTextureSubImage1D __GlueTextureSubImage1D;
		static __glTextureSubImage2D __GlueTextureSubImage2D;
		static __glTextureSubImage3D __GlueTextureSubImage3D;
		static __glTransformFeedbackBufferBase __GlueTransformFeedbackBufferBase;
		static __glTransformFeedbackBufferRange __GlueTransformFeedbackBufferRange;
		static __glUnmapNamedBuffer __GlueUnmapNamedBuffer;
		static __glVertexArrayAttribBinding __GlueVertexArrayAttribBinding;
		static __glVertexArrayAttribFormat __GlueVertexArrayAttribFormat;
		static __glVertexArrayAttribIFormat __GlueVertexArrayAttribIFormat;
		static __glVertexArrayAttribLFormat __GlueVertexArrayAttribLFormat;
		static __glVertexArrayBindingDivisor __GlueVertexArrayBindingDivisor;
		static __glVertexArrayElementBuffer __GlueVertexArrayElementBuffer;
		static __glVertexArrayVertexBuffer __GlueVertexArrayVertexBuffer;
		static __glVertexArrayVertexBuffers __GlueVertexArrayVertexBuffers;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindTextureUnit(uint unit, uint texture) => __GlueBindTextureUnit(unit, texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) => __GlueBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCheckNamedFramebufferStatus(uint framebuffer, uint target) => __GlueCheckNamedFramebufferStatus(framebuffer, target);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, IntPtr data) => __GlueClearNamedBufferData(buffer, internalformat, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedBufferSubData(uint buffer, uint internalformat, int offset, int size, uint format, uint type, IntPtr data) => __GlueClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) => __GlueClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value) => __GlueClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value) => __GlueClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value) => __GlueClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data) => __GlueCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data) => __GlueCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data) => __GlueCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size) => __GlueCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) => __GlueCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) => __GlueCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => __GlueCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateBuffers(int n, uint* buffers) => __GlueCreateBuffers(n, buffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateFramebuffers(int n, uint* framebuffers) => __GlueCreateFramebuffers(n, framebuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateProgramPipelines(int n, uint* pipelines) => __GlueCreateProgramPipelines(n, pipelines);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateQueries(uint target, int n, uint* ids) => __GlueCreateQueries(target, n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateRenderbuffers(int n, uint* renderbuffers) => __GlueCreateRenderbuffers(n, renderbuffers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateSamplers(int n, uint* samplers) => __GlueCreateSamplers(n, samplers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateTextures(uint target, int n, uint* textures) => __GlueCreateTextures(target, n, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateTransformFeedbacks(int n, uint* ids) => __GlueCreateTransformFeedbacks(n, ids);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCreateVertexArrays(int n, uint* arrays) => __GlueCreateVertexArrays(n, arrays);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableVertexArrayAttrib(uint vaobj, uint index) => __GlueDisableVertexArrayAttrib(vaobj, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableVertexArrayAttrib(uint vaobj, uint index) => __GlueEnableVertexArrayAttrib(vaobj, index);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFlushMappedNamedBufferRange(uint buffer, int offset, int length) => __GlueFlushMappedNamedBufferRange(buffer, offset, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenerateTextureMipmap(uint texture) => __GlueGenerateTextureMipmap(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels) => __GlueGetCompressedTextureImage(texture, level, bufSize, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferParameteri64v(uint buffer, uint pname, long* parameters) => __GlueGetNamedBufferParameteri64v(buffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferParameteriv(uint buffer, uint pname, int* parameters) => __GlueGetNamedBufferParameteriv(buffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferPointerv(uint buffer, uint pname, IntPtr* parameters) => __GlueGetNamedBufferPointerv(buffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data) => __GlueGetNamedBufferSubData(buffer, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* parameters) => __GlueGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param) => __GlueGetNamedFramebufferParameteriv(framebuffer, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* parameters) => __GlueGetNamedRenderbufferParameteriv(renderbuffer, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, int offset) => __GlueGetQueryBufferObjecti64v(id, buffer, pname, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, int offset) => __GlueGetQueryBufferObjectiv(id, buffer, pname, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, int offset) => __GlueGetQueryBufferObjectui64v(id, buffer, pname, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, int offset) => __GlueGetQueryBufferObjectuiv(id, buffer, pname, offset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels) => __GlueGetTextureImage(texture, level, format, type, bufSize, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float* parameters) => __GlueGetTextureLevelParameterfv(texture, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int* parameters) => __GlueGetTextureLevelParameteriv(texture, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterIiv(uint texture, uint pname, int* parameters) => __GlueGetTextureParameterIiv(texture, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterIuiv(uint texture, uint pname, uint* parameters) => __GlueGetTextureParameterIuiv(texture, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameterfv(uint texture, uint pname, float* parameters) => __GlueGetTextureParameterfv(texture, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTextureParameteriv(uint texture, uint pname, int* parameters) => __GlueGetTextureParameteriv(texture, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param) => __GlueGetTransformFeedbacki64_v(xfb, pname, index, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param) => __GlueGetTransformFeedbacki_v(xfb, pname, index, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTransformFeedbackiv(uint xfb, uint pname, int* param) => __GlueGetTransformFeedbackiv(xfb, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param) => __GlueGetVertexArrayIndexed64iv(vaobj, index, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param) => __GlueGetVertexArrayIndexediv(vaobj, index, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexArrayiv(uint vaobj, uint pname, int* param) => __GlueGetVertexArrayiv(vaobj, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments) => __GlueInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height) => __GlueInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapNamedBuffer(uint buffer, uint access) => __GlueMapNamedBuffer(buffer, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe IntPtr  glMapNamedBufferRange(uint buffer, int offset, int length, uint access) => __GlueMapNamedBufferRange(buffer, offset, length, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferData(uint buffer, int size, IntPtr data, uint usage) => __GlueNamedBufferData(buffer, size, data, usage);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferStorage(uint buffer, int size, IntPtr data, uint flags) => __GlueNamedBufferStorage(buffer, size, data, flags);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedBufferSubData(uint buffer, int offset, int size, IntPtr data) => __GlueNamedBufferSubData(buffer, offset, size, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferDrawBuffer(uint framebuffer, uint mode) => __GlueNamedFramebufferDrawBuffer(framebuffer, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs) => __GlueNamedFramebufferDrawBuffers(framebuffer, n, bufs);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param) => __GlueNamedFramebufferParameteri(framebuffer, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferReadBuffer(uint framebuffer, uint mode) => __GlueNamedFramebufferReadBuffer(framebuffer, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) => __GlueNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) => __GlueNamedFramebufferTexture(framebuffer, attachment, texture, level);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) => __GlueNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) => __GlueNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) => __GlueNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureBuffer(uint texture, uint internalformat, uint buffer) => __GlueTextureBuffer(texture, internalformat, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureBufferRange(uint texture, uint internalformat, uint buffer, int offset, int size) => __GlueTextureBufferRange(texture, internalformat, buffer, offset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterIiv(uint texture, uint pname, int* parameters) => __GlueTextureParameterIiv(texture, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterIuiv(uint texture, uint pname, uint* parameters) => __GlueTextureParameterIuiv(texture, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterf(uint texture, uint pname, float param) => __GlueTextureParameterf(texture, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameterfv(uint texture, uint pname, float* param) => __GlueTextureParameterfv(texture, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameteri(uint texture, uint pname, int param) => __GlueTextureParameteri(texture, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureParameteriv(uint texture, uint pname, int* param) => __GlueTextureParameteriv(texture, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage1D(uint texture, int levels, uint internalformat, int width) => __GlueTextureStorage1D(texture, levels, internalformat, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) => __GlueTextureStorage2D(texture, levels, internalformat, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) => __GlueTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) => __GlueTextureStorage3D(texture, levels, internalformat, width, height, depth);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) => __GlueTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => __GlueTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => __GlueTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels) => __GlueTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer) => __GlueTransformFeedbackBufferBase(xfb, index, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size) => __GlueTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glUnmapNamedBuffer(uint buffer) => __GlueUnmapNamedBuffer(buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) => __GlueVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset) => __GlueVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) => __GlueVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) => __GlueVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) => __GlueVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayElementBuffer(uint vaobj, uint buffer) => __GlueVertexArrayElementBuffer(vaobj, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride) => __GlueVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, int* offsets, int* strides) => __GlueVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);



	}
}


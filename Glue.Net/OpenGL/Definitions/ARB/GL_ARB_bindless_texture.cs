using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_bindless_texture {get; private set;}

		public const int GL_UNSIGNED_INT64_ARB = 0x140F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate ulong __glGetImageHandleARB(uint texture, int level, bool layered, int layer, uint format);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate ulong __glGetTextureHandleARB(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate ulong __glGetTextureSamplerHandleARB(uint texture, uint sampler);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVertexAttribLui64vARB(uint index, uint pname, ulong* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsImageHandleResidentARB(ulong handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsTextureHandleResidentARB(ulong handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMakeImageHandleNonResidentARB(ulong handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMakeImageHandleResidentARB(ulong handle, uint access);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMakeTextureHandleNonResidentARB(ulong handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMakeTextureHandleResidentARB(ulong handle);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformHandleui64ARB(uint program, int location, ulong value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformHandleui64vARB(uint program, int location, int count, ulong* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformHandleui64ARB(int location, ulong value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUniformHandleui64vARB(int location, int count, ulong* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL1ui64ARB(uint index, ulong x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribL1ui64vARB(uint index, ulong* v);

 		static __glGetImageHandleARB __GlueGetImageHandleARB;
		static __glGetTextureHandleARB __GlueGetTextureHandleARB;
		static __glGetTextureSamplerHandleARB __GlueGetTextureSamplerHandleARB;
		static __glGetVertexAttribLui64vARB __GlueGetVertexAttribLui64vARB;
		static __glIsImageHandleResidentARB __GlueIsImageHandleResidentARB;
		static __glIsTextureHandleResidentARB __GlueIsTextureHandleResidentARB;
		static __glMakeImageHandleNonResidentARB __GlueMakeImageHandleNonResidentARB;
		static __glMakeImageHandleResidentARB __GlueMakeImageHandleResidentARB;
		static __glMakeTextureHandleNonResidentARB __GlueMakeTextureHandleNonResidentARB;
		static __glMakeTextureHandleResidentARB __GlueMakeTextureHandleResidentARB;
		static __glProgramUniformHandleui64ARB __GlueProgramUniformHandleui64ARB;
		static __glProgramUniformHandleui64vARB __GlueProgramUniformHandleui64vARB;
		static __glUniformHandleui64ARB __GlueUniformHandleui64ARB;
		static __glUniformHandleui64vARB __GlueUniformHandleui64vARB;
		static __glVertexAttribL1ui64ARB __GlueVertexAttribL1ui64ARB;
		static __glVertexAttribL1ui64vARB __GlueVertexAttribL1ui64vARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe ulong glGetImageHandleARB(uint texture, int level, bool layered, int layer, uint format) => __GlueGetImageHandleARB(texture, level, layered, layer, format);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe ulong glGetTextureHandleARB(uint texture) => __GlueGetTextureHandleARB(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe ulong glGetTextureSamplerHandleARB(uint texture, uint sampler) => __GlueGetTextureSamplerHandleARB(texture, sampler);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVertexAttribLui64vARB(uint index, uint pname, ulong* parameters) => __GlueGetVertexAttribLui64vARB(index, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsImageHandleResidentARB(ulong handle) => __GlueIsImageHandleResidentARB(handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsTextureHandleResidentARB(ulong handle) => __GlueIsTextureHandleResidentARB(handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMakeImageHandleNonResidentARB(ulong handle) => __GlueMakeImageHandleNonResidentARB(handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMakeImageHandleResidentARB(ulong handle, uint access) => __GlueMakeImageHandleResidentARB(handle, access);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMakeTextureHandleNonResidentARB(ulong handle) => __GlueMakeTextureHandleNonResidentARB(handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMakeTextureHandleResidentARB(ulong handle) => __GlueMakeTextureHandleResidentARB(handle);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformHandleui64ARB(uint program, int location, ulong value) => __GlueProgramUniformHandleui64ARB(program, location, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformHandleui64vARB(uint program, int location, int count, ulong* values) => __GlueProgramUniformHandleui64vARB(program, location, count, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformHandleui64ARB(int location, ulong value) => __GlueUniformHandleui64ARB(location, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUniformHandleui64vARB(int location, int count, ulong* value) => __GlueUniformHandleui64vARB(location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL1ui64ARB(uint index, ulong x) => __GlueVertexAttribL1ui64ARB(index, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribL1ui64vARB(uint index, ulong* v) => __GlueVertexAttribL1ui64vARB(index, v);



	}
}


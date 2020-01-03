using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_sampler_objects {get; private set;}

		public const int GL_SAMPLER_BINDING = 0x8919;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindSampler(uint unit, uint sampler);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteSamplers(int count, uint* samplers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenSamplers(int count, uint* samplers);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSamplerParameterIiv(uint sampler, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSamplerParameterfv(uint sampler, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetSamplerParameteriv(uint sampler, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsSampler(uint sampler);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplerParameterIiv(uint sampler, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplerParameterIuiv(uint sampler, uint pname, uint* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplerParameterf(uint sampler, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplerParameterfv(uint sampler, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplerParameteri(uint sampler, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSamplerParameteriv(uint sampler, uint pname, int* parameters);

 		static __glBindSampler __GlueBindSampler;
		static __glDeleteSamplers __GlueDeleteSamplers;
		static __glGenSamplers __GlueGenSamplers;
		static __glGetSamplerParameterIiv __GlueGetSamplerParameterIiv;
		static __glGetSamplerParameterIuiv __GlueGetSamplerParameterIuiv;
		static __glGetSamplerParameterfv __GlueGetSamplerParameterfv;
		static __glGetSamplerParameteriv __GlueGetSamplerParameteriv;
		static __glIsSampler __GlueIsSampler;
		static __glSamplerParameterIiv __GlueSamplerParameterIiv;
		static __glSamplerParameterIuiv __GlueSamplerParameterIuiv;
		static __glSamplerParameterf __GlueSamplerParameterf;
		static __glSamplerParameterfv __GlueSamplerParameterfv;
		static __glSamplerParameteri __GlueSamplerParameteri;
		static __glSamplerParameteriv __GlueSamplerParameteriv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindSampler(uint unit, uint sampler) => __GlueBindSampler(unit, sampler);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteSamplers(int count, uint* samplers) => __GlueDeleteSamplers(count, samplers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenSamplers(int count, uint* samplers) => __GlueGenSamplers(count, samplers);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSamplerParameterIiv(uint sampler, uint pname, int* parameters) => __GlueGetSamplerParameterIiv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSamplerParameterIuiv(uint sampler, uint pname, uint* parameters) => __GlueGetSamplerParameterIuiv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSamplerParameterfv(uint sampler, uint pname, float* parameters) => __GlueGetSamplerParameterfv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetSamplerParameteriv(uint sampler, uint pname, int* parameters) => __GlueGetSamplerParameteriv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsSampler(uint sampler) => __GlueIsSampler(sampler);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplerParameterIiv(uint sampler, uint pname, int* parameters) => __GlueSamplerParameterIiv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplerParameterIuiv(uint sampler, uint pname, uint* parameters) => __GlueSamplerParameterIuiv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplerParameterf(uint sampler, uint pname, float param) => __GlueSamplerParameterf(sampler, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplerParameterfv(uint sampler, uint pname, float* parameters) => __GlueSamplerParameterfv(sampler, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplerParameteri(uint sampler, uint pname, int param) => __GlueSamplerParameteri(sampler, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSamplerParameteriv(uint sampler, uint pname, int* parameters) => __GlueSamplerParameteriv(sampler, pname, parameters);



	}
}


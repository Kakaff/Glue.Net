using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_separate_shader_objects {get; private set;}

		public const int GL_VERTEX_SHADER_BIT = 0x00000001;
		public const int GL_FRAGMENT_SHADER_BIT = 0x00000002;
		public const int GL_GEOMETRY_SHADER_BIT = 0x00000004;
		public const int GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
		public const int GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
		public const int GL_PROGRAM_SEPARABLE = 0x8258;
		public const int GL_ACTIVE_PROGRAM = 0x8259;
		public const int GL_PROGRAM_PIPELINE_BINDING = 0x825A;
		public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glActiveShaderProgram(uint pipeline, uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindProgramPipeline(uint pipeline);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glCreateShaderProgramv(uint type, int count, char** strings);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteProgramPipelines(int n, uint* pipelines);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenProgramPipelines(int n, uint* pipelines);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetProgramPipelineiv(uint pipeline, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsProgramPipeline(uint pipeline);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1d(uint program, int location, double x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1dv(uint program, int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1f(uint program, int location, float x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1fv(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1i(uint program, int location, int x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1iv(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1ui(uint program, int location, uint x);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform1uiv(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2d(uint program, int location, double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2dv(uint program, int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2f(uint program, int location, float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2fv(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2i(uint program, int location, int x, int y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2iv(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2ui(uint program, int location, uint x, uint y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform2uiv(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3d(uint program, int location, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3dv(uint program, int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3f(uint program, int location, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3fv(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3i(uint program, int location, int x, int y, int z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3iv(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3ui(uint program, int location, uint x, uint y, uint z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform3uiv(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4d(uint program, int location, double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4dv(uint program, int location, int count, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4f(uint program, int location, float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4fv(uint program, int location, int count, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4i(uint program, int location, int x, int y, int z, int w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4iv(uint program, int location, int count, int* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4ui(uint program, int location, uint x, uint y, uint z, uint w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniform4uiv(uint program, int location, int count, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glUseProgramStages(uint pipeline, uint stages, uint program);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glValidateProgramPipeline(uint pipeline);

 		static __glActiveShaderProgram __GlueActiveShaderProgram;
		static __glBindProgramPipeline __GlueBindProgramPipeline;
		static __glCreateShaderProgramv __GlueCreateShaderProgramv;
		static __glDeleteProgramPipelines __GlueDeleteProgramPipelines;
		static __glGenProgramPipelines __GlueGenProgramPipelines;
		static __glGetProgramPipelineInfoLog __GlueGetProgramPipelineInfoLog;
		static __glGetProgramPipelineiv __GlueGetProgramPipelineiv;
		static __glIsProgramPipeline __GlueIsProgramPipeline;
		static __glProgramUniform1d __GlueProgramUniform1d;
		static __glProgramUniform1dv __GlueProgramUniform1dv;
		static __glProgramUniform1f __GlueProgramUniform1f;
		static __glProgramUniform1fv __GlueProgramUniform1fv;
		static __glProgramUniform1i __GlueProgramUniform1i;
		static __glProgramUniform1iv __GlueProgramUniform1iv;
		static __glProgramUniform1ui __GlueProgramUniform1ui;
		static __glProgramUniform1uiv __GlueProgramUniform1uiv;
		static __glProgramUniform2d __GlueProgramUniform2d;
		static __glProgramUniform2dv __GlueProgramUniform2dv;
		static __glProgramUniform2f __GlueProgramUniform2f;
		static __glProgramUniform2fv __GlueProgramUniform2fv;
		static __glProgramUniform2i __GlueProgramUniform2i;
		static __glProgramUniform2iv __GlueProgramUniform2iv;
		static __glProgramUniform2ui __GlueProgramUniform2ui;
		static __glProgramUniform2uiv __GlueProgramUniform2uiv;
		static __glProgramUniform3d __GlueProgramUniform3d;
		static __glProgramUniform3dv __GlueProgramUniform3dv;
		static __glProgramUniform3f __GlueProgramUniform3f;
		static __glProgramUniform3fv __GlueProgramUniform3fv;
		static __glProgramUniform3i __GlueProgramUniform3i;
		static __glProgramUniform3iv __GlueProgramUniform3iv;
		static __glProgramUniform3ui __GlueProgramUniform3ui;
		static __glProgramUniform3uiv __GlueProgramUniform3uiv;
		static __glProgramUniform4d __GlueProgramUniform4d;
		static __glProgramUniform4dv __GlueProgramUniform4dv;
		static __glProgramUniform4f __GlueProgramUniform4f;
		static __glProgramUniform4fv __GlueProgramUniform4fv;
		static __glProgramUniform4i __GlueProgramUniform4i;
		static __glProgramUniform4iv __GlueProgramUniform4iv;
		static __glProgramUniform4ui __GlueProgramUniform4ui;
		static __glProgramUniform4uiv __GlueProgramUniform4uiv;
		static __glProgramUniformMatrix2dv __GlueProgramUniformMatrix2dv;
		static __glProgramUniformMatrix2fv __GlueProgramUniformMatrix2fv;
		static __glProgramUniformMatrix2x3dv __GlueProgramUniformMatrix2x3dv;
		static __glProgramUniformMatrix2x3fv __GlueProgramUniformMatrix2x3fv;
		static __glProgramUniformMatrix2x4dv __GlueProgramUniformMatrix2x4dv;
		static __glProgramUniformMatrix2x4fv __GlueProgramUniformMatrix2x4fv;
		static __glProgramUniformMatrix3dv __GlueProgramUniformMatrix3dv;
		static __glProgramUniformMatrix3fv __GlueProgramUniformMatrix3fv;
		static __glProgramUniformMatrix3x2dv __GlueProgramUniformMatrix3x2dv;
		static __glProgramUniformMatrix3x2fv __GlueProgramUniformMatrix3x2fv;
		static __glProgramUniformMatrix3x4dv __GlueProgramUniformMatrix3x4dv;
		static __glProgramUniformMatrix3x4fv __GlueProgramUniformMatrix3x4fv;
		static __glProgramUniformMatrix4dv __GlueProgramUniformMatrix4dv;
		static __glProgramUniformMatrix4fv __GlueProgramUniformMatrix4fv;
		static __glProgramUniformMatrix4x2dv __GlueProgramUniformMatrix4x2dv;
		static __glProgramUniformMatrix4x2fv __GlueProgramUniformMatrix4x2fv;
		static __glProgramUniformMatrix4x3dv __GlueProgramUniformMatrix4x3dv;
		static __glProgramUniformMatrix4x3fv __GlueProgramUniformMatrix4x3fv;
		static __glUseProgramStages __GlueUseProgramStages;
		static __glValidateProgramPipeline __GlueValidateProgramPipeline;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glActiveShaderProgram(uint pipeline, uint program) => __GlueActiveShaderProgram(pipeline, program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindProgramPipeline(uint pipeline) => __GlueBindProgramPipeline(pipeline);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glCreateShaderProgramv(uint type, int count, char** strings) => __GlueCreateShaderProgramv(type, count, strings);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteProgramPipelines(int n, uint* pipelines) => __GlueDeleteProgramPipelines(n, pipelines);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenProgramPipelines(int n, uint* pipelines) => __GlueGenProgramPipelines(n, pipelines);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog) => __GlueGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetProgramPipelineiv(uint pipeline, uint pname, int* parameters) => __GlueGetProgramPipelineiv(pipeline, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsProgramPipeline(uint pipeline) => __GlueIsProgramPipeline(pipeline);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1d(uint program, int location, double x) => __GlueProgramUniform1d(program, location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1dv(uint program, int location, int count, double* value) => __GlueProgramUniform1dv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1f(uint program, int location, float x) => __GlueProgramUniform1f(program, location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1fv(uint program, int location, int count, float* value) => __GlueProgramUniform1fv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1i(uint program, int location, int x) => __GlueProgramUniform1i(program, location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1iv(uint program, int location, int count, int* value) => __GlueProgramUniform1iv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1ui(uint program, int location, uint x) => __GlueProgramUniform1ui(program, location, x);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform1uiv(uint program, int location, int count, uint* value) => __GlueProgramUniform1uiv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2d(uint program, int location, double x, double y) => __GlueProgramUniform2d(program, location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2dv(uint program, int location, int count, double* value) => __GlueProgramUniform2dv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2f(uint program, int location, float x, float y) => __GlueProgramUniform2f(program, location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2fv(uint program, int location, int count, float* value) => __GlueProgramUniform2fv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2i(uint program, int location, int x, int y) => __GlueProgramUniform2i(program, location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2iv(uint program, int location, int count, int* value) => __GlueProgramUniform2iv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2ui(uint program, int location, uint x, uint y) => __GlueProgramUniform2ui(program, location, x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform2uiv(uint program, int location, int count, uint* value) => __GlueProgramUniform2uiv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3d(uint program, int location, double x, double y, double z) => __GlueProgramUniform3d(program, location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3dv(uint program, int location, int count, double* value) => __GlueProgramUniform3dv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3f(uint program, int location, float x, float y, float z) => __GlueProgramUniform3f(program, location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3fv(uint program, int location, int count, float* value) => __GlueProgramUniform3fv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3i(uint program, int location, int x, int y, int z) => __GlueProgramUniform3i(program, location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3iv(uint program, int location, int count, int* value) => __GlueProgramUniform3iv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3ui(uint program, int location, uint x, uint y, uint z) => __GlueProgramUniform3ui(program, location, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform3uiv(uint program, int location, int count, uint* value) => __GlueProgramUniform3uiv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4d(uint program, int location, double x, double y, double z, double w) => __GlueProgramUniform4d(program, location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4dv(uint program, int location, int count, double* value) => __GlueProgramUniform4dv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4f(uint program, int location, float x, float y, float z, float w) => __GlueProgramUniform4f(program, location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4fv(uint program, int location, int count, float* value) => __GlueProgramUniform4fv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4i(uint program, int location, int x, int y, int z, int w) => __GlueProgramUniform4i(program, location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4iv(uint program, int location, int count, int* value) => __GlueProgramUniform4iv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4ui(uint program, int location, uint x, uint y, uint z, uint w) => __GlueProgramUniform4ui(program, location, x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniform4uiv(uint program, int location, int count, uint* value) => __GlueProgramUniform4uiv(program, location, count, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix2dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix2fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix2x3dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix2x3fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix2x4dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix2x4fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix3dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix3fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix3x2dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix3x2fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix3x4dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix3x4fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix4dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix4fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix4x2dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix4x2fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value) => __GlueProgramUniformMatrix4x3dv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value) => __GlueProgramUniformMatrix4x3fv(program, location, count, transpose, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glUseProgramStages(uint pipeline, uint stages, uint program) => __GlueUseProgramStages(pipeline, stages, program);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glValidateProgramPipeline(uint pipeline) => __GlueValidateProgramPipeline(pipeline);



	}
}


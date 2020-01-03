using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL
{

    public static partial class GL_ARB
    {

        internal static void Init(glInitHint initHint)
        {
            switch (initHint)
            {
                case glInitHint.GL_ARB_ES2_compatibility:
                    {
                        __GlueClearDepthf = GLFunctionLoader.LoadGLFunction<__glClearDepthf>("glClearDepthf");
                        __GlueDepthRangef = GLFunctionLoader.LoadGLFunction<__glDepthRangef>("glDepthRangef");
                        __GlueGetShaderPrecisionFormat = GLFunctionLoader.LoadGLFunction<__glGetShaderPrecisionFormat>("glGetShaderPrecisionFormat");
                        __GlueReleaseShaderCompiler = GLFunctionLoader.LoadGLFunction<__glReleaseShaderCompiler>("glReleaseShaderCompiler");
                        __GlueShaderBinary = GLFunctionLoader.LoadGLFunction<__glShaderBinary>("glShaderBinary");


                        GL_ARB_ES2_compatibility = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_ES2_compatibility");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_ES3_1_compatibility:
                    {
                        __GlueMemoryBarrierByRegion = GLFunctionLoader.LoadGLFunction<__glMemoryBarrierByRegion>("glMemoryBarrierByRegion");


                        GL_ARB_ES3_1_compatibility = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_ES3_1_compatibility");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_ES3_2_compatibility:
                    {
                        __GluePrimitiveBoundingBoxARB = GLFunctionLoader.LoadGLFunction<__glPrimitiveBoundingBoxARB>("glPrimitiveBoundingBoxARB");


                        GL_ARB_ES3_2_compatibility = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_ES3_2_compatibility");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_ES3_compatibility:
                    {


                        GL_ARB_ES3_compatibility = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_ES3_compatibility");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_arrays_of_arrays:
                    {


                        GL_ARB_arrays_of_arrays = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_arrays_of_arrays");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_base_instance:
                    {
                        __GlueDrawArraysInstancedBaseInstance = GLFunctionLoader.LoadGLFunction<__glDrawArraysInstancedBaseInstance>("glDrawArraysInstancedBaseInstance");
                        __GlueDrawElementsInstancedBaseInstance = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedBaseInstance>("glDrawElementsInstancedBaseInstance");
                        __GlueDrawElementsInstancedBaseVertexBaseInstance = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedBaseVertexBaseInstance>("glDrawElementsInstancedBaseVertexBaseInstance");


                        GL_ARB_base_instance = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_base_instance");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_bindless_texture:
                    {
                        __GlueGetImageHandleARB = GLFunctionLoader.LoadGLFunction<__glGetImageHandleARB>("glGetImageHandleARB");
                        __GlueGetTextureHandleARB = GLFunctionLoader.LoadGLFunction<__glGetTextureHandleARB>("glGetTextureHandleARB");
                        __GlueGetTextureSamplerHandleARB = GLFunctionLoader.LoadGLFunction<__glGetTextureSamplerHandleARB>("glGetTextureSamplerHandleARB");
                        __GlueGetVertexAttribLui64vARB = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribLui64vARB>("glGetVertexAttribLui64vARB");
                        __GlueIsImageHandleResidentARB = GLFunctionLoader.LoadGLFunction<__glIsImageHandleResidentARB>("glIsImageHandleResidentARB");
                        __GlueIsTextureHandleResidentARB = GLFunctionLoader.LoadGLFunction<__glIsTextureHandleResidentARB>("glIsTextureHandleResidentARB");
                        __GlueMakeImageHandleNonResidentARB = GLFunctionLoader.LoadGLFunction<__glMakeImageHandleNonResidentARB>("glMakeImageHandleNonResidentARB");
                        __GlueMakeImageHandleResidentARB = GLFunctionLoader.LoadGLFunction<__glMakeImageHandleResidentARB>("glMakeImageHandleResidentARB");
                        __GlueMakeTextureHandleNonResidentARB = GLFunctionLoader.LoadGLFunction<__glMakeTextureHandleNonResidentARB>("glMakeTextureHandleNonResidentARB");
                        __GlueMakeTextureHandleResidentARB = GLFunctionLoader.LoadGLFunction<__glMakeTextureHandleResidentARB>("glMakeTextureHandleResidentARB");
                        __GlueProgramUniformHandleui64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniformHandleui64ARB>("glProgramUniformHandleui64ARB");
                        __GlueProgramUniformHandleui64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniformHandleui64vARB>("glProgramUniformHandleui64vARB");
                        __GlueUniformHandleui64ARB = GLFunctionLoader.LoadGLFunction<__glUniformHandleui64ARB>("glUniformHandleui64ARB");
                        __GlueUniformHandleui64vARB = GLFunctionLoader.LoadGLFunction<__glUniformHandleui64vARB>("glUniformHandleui64vARB");
                        __GlueVertexAttribL1ui64ARB = GLFunctionLoader.LoadGLFunction<__glVertexAttribL1ui64ARB>("glVertexAttribL1ui64ARB");
                        __GlueVertexAttribL1ui64vARB = GLFunctionLoader.LoadGLFunction<__glVertexAttribL1ui64vARB>("glVertexAttribL1ui64vARB");


                        GL_ARB_bindless_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_bindless_texture");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_blend_func_extended:
                    {
                        __GlueBindFragDataLocationIndexed = GLFunctionLoader.LoadGLFunction<__glBindFragDataLocationIndexed>("glBindFragDataLocationIndexed");
                        __GlueGetFragDataIndex = GLFunctionLoader.LoadGLFunction<__glGetFragDataIndex>("glGetFragDataIndex");


                        GL_ARB_blend_func_extended = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_blend_func_extended");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_buffer_storage:
                    {
                        __GlueBufferStorage = GLFunctionLoader.LoadGLFunction<__glBufferStorage>("glBufferStorage");


                        GL_ARB_buffer_storage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_buffer_storage");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_cl_event:
                    {
                        __GlueCreateSyncFromCLeventARB = GLFunctionLoader.LoadGLFunction<__glCreateSyncFromCLeventARB>("glCreateSyncFromCLeventARB");


                        GL_ARB_cl_event = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_cl_event");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_clear_buffer_object:
                    {
                        __GlueClearBufferData = GLFunctionLoader.LoadGLFunction<__glClearBufferData>("glClearBufferData");
                        __GlueClearBufferSubData = GLFunctionLoader.LoadGLFunction<__glClearBufferSubData>("glClearBufferSubData");
                        __GlueClearNamedBufferDataEXT = GLFunctionLoader.LoadGLFunction<__glClearNamedBufferDataEXT>("glClearNamedBufferDataEXT");
                        __GlueClearNamedBufferSubDataEXT = GLFunctionLoader.LoadGLFunction<__glClearNamedBufferSubDataEXT>("glClearNamedBufferSubDataEXT");


                        GL_ARB_clear_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_clear_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_clear_texture:
                    {
                        __GlueClearTexImage = GLFunctionLoader.LoadGLFunction<__glClearTexImage>("glClearTexImage");
                        __GlueClearTexSubImage = GLFunctionLoader.LoadGLFunction<__glClearTexSubImage>("glClearTexSubImage");


                        GL_ARB_clear_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_clear_texture");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_clip_control:
                    {
                        __GlueClipControl = GLFunctionLoader.LoadGLFunction<__glClipControl>("glClipControl");


                        GL_ARB_clip_control = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_clip_control");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_color_buffer_float:
                    {
                        __GlueClampColorARB = GLFunctionLoader.LoadGLFunction<__glClampColorARB>("glClampColorARB");


                        GL_ARB_color_buffer_float = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_color_buffer_float");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_compatibility:
                    {


                        GL_ARB_compatibility = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_compatibility");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_compressed_texture_pixel_storage:
                    {


                        GL_ARB_compressed_texture_pixel_storage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_compressed_texture_pixel_storage");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_compute_shader:
                    {
                        __GlueDispatchCompute = GLFunctionLoader.LoadGLFunction<__glDispatchCompute>("glDispatchCompute");
                        __GlueDispatchComputeIndirect = GLFunctionLoader.LoadGLFunction<__glDispatchComputeIndirect>("glDispatchComputeIndirect");


                        GL_ARB_compute_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_compute_shader");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_compute_variable_group_size:
                    {
                        __GlueDispatchComputeGroupSizeARB = GLFunctionLoader.LoadGLFunction<__glDispatchComputeGroupSizeARB>("glDispatchComputeGroupSizeARB");


                        GL_ARB_compute_variable_group_size = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_compute_variable_group_size");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_conditional_render_inverted:
                    {


                        GL_ARB_conditional_render_inverted = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_conditional_render_inverted");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_conservative_depth:
                    {


                        GL_ARB_conservative_depth = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_conservative_depth");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_copy_buffer:
                    {
                        __GlueCopyBufferSubData = GLFunctionLoader.LoadGLFunction<__glCopyBufferSubData>("glCopyBufferSubData");


                        GL_ARB_copy_buffer = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_copy_buffer");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_copy_image:
                    {
                        __GlueCopyImageSubData = GLFunctionLoader.LoadGLFunction<__glCopyImageSubData>("glCopyImageSubData");


                        GL_ARB_copy_image = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_copy_image");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_cull_distance:
                    {


                        GL_ARB_cull_distance = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_cull_distance");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_debug_output:
                    {
                        __GlueDebugMessageCallbackARB = GLFunctionLoader.LoadGLFunction<__glDebugMessageCallbackARB>("glDebugMessageCallbackARB");
                        __GlueDebugMessageControlARB = GLFunctionLoader.LoadGLFunction<__glDebugMessageControlARB>("glDebugMessageControlARB");
                        __GlueDebugMessageInsertARB = GLFunctionLoader.LoadGLFunction<__glDebugMessageInsertARB>("glDebugMessageInsertARB");
                        __GlueGetDebugMessageLogARB = GLFunctionLoader.LoadGLFunction<__glGetDebugMessageLogARB>("glGetDebugMessageLogARB");


                        GL_ARB_debug_output = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_debug_output");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_depth_buffer_float:
                    {


                        GL_ARB_depth_buffer_float = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_depth_buffer_float");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_depth_clamp:
                    {


                        GL_ARB_depth_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_depth_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_depth_texture:
                    {


                        GL_ARB_depth_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_depth_texture");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_derivative_control:
                    {


                        GL_ARB_derivative_control = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_derivative_control");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_direct_state_access:
                    {
                        __GlueBindTextureUnit = GLFunctionLoader.LoadGLFunction<__glBindTextureUnit>("glBindTextureUnit");
                        __GlueBlitNamedFramebuffer = GLFunctionLoader.LoadGLFunction<__glBlitNamedFramebuffer>("glBlitNamedFramebuffer");
                        __GlueCheckNamedFramebufferStatus = GLFunctionLoader.LoadGLFunction<__glCheckNamedFramebufferStatus>("glCheckNamedFramebufferStatus");
                        __GlueClearNamedBufferData = GLFunctionLoader.LoadGLFunction<__glClearNamedBufferData>("glClearNamedBufferData");
                        __GlueClearNamedBufferSubData = GLFunctionLoader.LoadGLFunction<__glClearNamedBufferSubData>("glClearNamedBufferSubData");
                        __GlueClearNamedFramebufferfi = GLFunctionLoader.LoadGLFunction<__glClearNamedFramebufferfi>("glClearNamedFramebufferfi");
                        __GlueClearNamedFramebufferfv = GLFunctionLoader.LoadGLFunction<__glClearNamedFramebufferfv>("glClearNamedFramebufferfv");
                        __GlueClearNamedFramebufferiv = GLFunctionLoader.LoadGLFunction<__glClearNamedFramebufferiv>("glClearNamedFramebufferiv");
                        __GlueClearNamedFramebufferuiv = GLFunctionLoader.LoadGLFunction<__glClearNamedFramebufferuiv>("glClearNamedFramebufferuiv");
                        __GlueCompressedTextureSubImage1D = GLFunctionLoader.LoadGLFunction<__glCompressedTextureSubImage1D>("glCompressedTextureSubImage1D");
                        __GlueCompressedTextureSubImage2D = GLFunctionLoader.LoadGLFunction<__glCompressedTextureSubImage2D>("glCompressedTextureSubImage2D");
                        __GlueCompressedTextureSubImage3D = GLFunctionLoader.LoadGLFunction<__glCompressedTextureSubImage3D>("glCompressedTextureSubImage3D");
                        __GlueCopyNamedBufferSubData = GLFunctionLoader.LoadGLFunction<__glCopyNamedBufferSubData>("glCopyNamedBufferSubData");
                        __GlueCopyTextureSubImage1D = GLFunctionLoader.LoadGLFunction<__glCopyTextureSubImage1D>("glCopyTextureSubImage1D");
                        __GlueCopyTextureSubImage2D = GLFunctionLoader.LoadGLFunction<__glCopyTextureSubImage2D>("glCopyTextureSubImage2D");
                        __GlueCopyTextureSubImage3D = GLFunctionLoader.LoadGLFunction<__glCopyTextureSubImage3D>("glCopyTextureSubImage3D");
                        __GlueCreateBuffers = GLFunctionLoader.LoadGLFunction<__glCreateBuffers>("glCreateBuffers");
                        __GlueCreateFramebuffers = GLFunctionLoader.LoadGLFunction<__glCreateFramebuffers>("glCreateFramebuffers");
                        __GlueCreateProgramPipelines = GLFunctionLoader.LoadGLFunction<__glCreateProgramPipelines>("glCreateProgramPipelines");
                        __GlueCreateQueries = GLFunctionLoader.LoadGLFunction<__glCreateQueries>("glCreateQueries");
                        __GlueCreateRenderbuffers = GLFunctionLoader.LoadGLFunction<__glCreateRenderbuffers>("glCreateRenderbuffers");
                        __GlueCreateSamplers = GLFunctionLoader.LoadGLFunction<__glCreateSamplers>("glCreateSamplers");
                        __GlueCreateTextures = GLFunctionLoader.LoadGLFunction<__glCreateTextures>("glCreateTextures");
                        __GlueCreateTransformFeedbacks = GLFunctionLoader.LoadGLFunction<__glCreateTransformFeedbacks>("glCreateTransformFeedbacks");
                        __GlueCreateVertexArrays = GLFunctionLoader.LoadGLFunction<__glCreateVertexArrays>("glCreateVertexArrays");
                        __GlueDisableVertexArrayAttrib = GLFunctionLoader.LoadGLFunction<__glDisableVertexArrayAttrib>("glDisableVertexArrayAttrib");
                        __GlueEnableVertexArrayAttrib = GLFunctionLoader.LoadGLFunction<__glEnableVertexArrayAttrib>("glEnableVertexArrayAttrib");
                        __GlueFlushMappedNamedBufferRange = GLFunctionLoader.LoadGLFunction<__glFlushMappedNamedBufferRange>("glFlushMappedNamedBufferRange");
                        __GlueGenerateTextureMipmap = GLFunctionLoader.LoadGLFunction<__glGenerateTextureMipmap>("glGenerateTextureMipmap");
                        __GlueGetCompressedTextureImage = GLFunctionLoader.LoadGLFunction<__glGetCompressedTextureImage>("glGetCompressedTextureImage");
                        __GlueGetNamedBufferParameteri64v = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferParameteri64v>("glGetNamedBufferParameteri64v");
                        __GlueGetNamedBufferParameteriv = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferParameteriv>("glGetNamedBufferParameteriv");
                        __GlueGetNamedBufferPointerv = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferPointerv>("glGetNamedBufferPointerv");
                        __GlueGetNamedBufferSubData = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferSubData>("glGetNamedBufferSubData");
                        __GlueGetNamedFramebufferAttachmentParameteriv = GLFunctionLoader.LoadGLFunction<__glGetNamedFramebufferAttachmentParameteriv>("glGetNamedFramebufferAttachmentParameteriv");
                        __GlueGetNamedFramebufferParameteriv = GLFunctionLoader.LoadGLFunction<__glGetNamedFramebufferParameteriv>("glGetNamedFramebufferParameteriv");
                        __GlueGetNamedRenderbufferParameteriv = GLFunctionLoader.LoadGLFunction<__glGetNamedRenderbufferParameteriv>("glGetNamedRenderbufferParameteriv");
                        __GlueGetQueryBufferObjecti64v = GLFunctionLoader.LoadGLFunction<__glGetQueryBufferObjecti64v>("glGetQueryBufferObjecti64v");
                        __GlueGetQueryBufferObjectiv = GLFunctionLoader.LoadGLFunction<__glGetQueryBufferObjectiv>("glGetQueryBufferObjectiv");
                        __GlueGetQueryBufferObjectui64v = GLFunctionLoader.LoadGLFunction<__glGetQueryBufferObjectui64v>("glGetQueryBufferObjectui64v");
                        __GlueGetQueryBufferObjectuiv = GLFunctionLoader.LoadGLFunction<__glGetQueryBufferObjectuiv>("glGetQueryBufferObjectuiv");
                        __GlueGetTextureImage = GLFunctionLoader.LoadGLFunction<__glGetTextureImage>("glGetTextureImage");
                        __GlueGetTextureLevelParameterfv = GLFunctionLoader.LoadGLFunction<__glGetTextureLevelParameterfv>("glGetTextureLevelParameterfv");
                        __GlueGetTextureLevelParameteriv = GLFunctionLoader.LoadGLFunction<__glGetTextureLevelParameteriv>("glGetTextureLevelParameteriv");
                        __GlueGetTextureParameterIiv = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterIiv>("glGetTextureParameterIiv");
                        __GlueGetTextureParameterIuiv = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterIuiv>("glGetTextureParameterIuiv");
                        __GlueGetTextureParameterfv = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterfv>("glGetTextureParameterfv");
                        __GlueGetTextureParameteriv = GLFunctionLoader.LoadGLFunction<__glGetTextureParameteriv>("glGetTextureParameteriv");
                        __GlueGetTransformFeedbacki64_v = GLFunctionLoader.LoadGLFunction<__glGetTransformFeedbacki64_v>("glGetTransformFeedbacki64_v");
                        __GlueGetTransformFeedbacki_v = GLFunctionLoader.LoadGLFunction<__glGetTransformFeedbacki_v>("glGetTransformFeedbacki_v");
                        __GlueGetTransformFeedbackiv = GLFunctionLoader.LoadGLFunction<__glGetTransformFeedbackiv>("glGetTransformFeedbackiv");
                        __GlueGetVertexArrayIndexed64iv = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayIndexed64iv>("glGetVertexArrayIndexed64iv");
                        __GlueGetVertexArrayIndexediv = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayIndexediv>("glGetVertexArrayIndexediv");
                        __GlueGetVertexArrayiv = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayiv>("glGetVertexArrayiv");
                        __GlueInvalidateNamedFramebufferData = GLFunctionLoader.LoadGLFunction<__glInvalidateNamedFramebufferData>("glInvalidateNamedFramebufferData");
                        __GlueInvalidateNamedFramebufferSubData = GLFunctionLoader.LoadGLFunction<__glInvalidateNamedFramebufferSubData>("glInvalidateNamedFramebufferSubData");
                        __GlueMapNamedBuffer = GLFunctionLoader.LoadGLFunction<__glMapNamedBuffer>("glMapNamedBuffer");
                        __GlueMapNamedBufferRange = GLFunctionLoader.LoadGLFunction<__glMapNamedBufferRange>("glMapNamedBufferRange");
                        __GlueNamedBufferData = GLFunctionLoader.LoadGLFunction<__glNamedBufferData>("glNamedBufferData");
                        __GlueNamedBufferStorage = GLFunctionLoader.LoadGLFunction<__glNamedBufferStorage>("glNamedBufferStorage");
                        __GlueNamedBufferSubData = GLFunctionLoader.LoadGLFunction<__glNamedBufferSubData>("glNamedBufferSubData");
                        __GlueNamedFramebufferDrawBuffer = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferDrawBuffer>("glNamedFramebufferDrawBuffer");
                        __GlueNamedFramebufferDrawBuffers = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferDrawBuffers>("glNamedFramebufferDrawBuffers");
                        __GlueNamedFramebufferParameteri = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferParameteri>("glNamedFramebufferParameteri");
                        __GlueNamedFramebufferReadBuffer = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferReadBuffer>("glNamedFramebufferReadBuffer");
                        __GlueNamedFramebufferRenderbuffer = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferRenderbuffer>("glNamedFramebufferRenderbuffer");
                        __GlueNamedFramebufferTexture = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTexture>("glNamedFramebufferTexture");
                        __GlueNamedFramebufferTextureLayer = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTextureLayer>("glNamedFramebufferTextureLayer");
                        __GlueNamedRenderbufferStorage = GLFunctionLoader.LoadGLFunction<__glNamedRenderbufferStorage>("glNamedRenderbufferStorage");
                        __GlueNamedRenderbufferStorageMultisample = GLFunctionLoader.LoadGLFunction<__glNamedRenderbufferStorageMultisample>("glNamedRenderbufferStorageMultisample");
                        __GlueTextureBuffer = GLFunctionLoader.LoadGLFunction<__glTextureBuffer>("glTextureBuffer");
                        __GlueTextureBufferRange = GLFunctionLoader.LoadGLFunction<__glTextureBufferRange>("glTextureBufferRange");
                        __GlueTextureParameterIiv = GLFunctionLoader.LoadGLFunction<__glTextureParameterIiv>("glTextureParameterIiv");
                        __GlueTextureParameterIuiv = GLFunctionLoader.LoadGLFunction<__glTextureParameterIuiv>("glTextureParameterIuiv");
                        __GlueTextureParameterf = GLFunctionLoader.LoadGLFunction<__glTextureParameterf>("glTextureParameterf");
                        __GlueTextureParameterfv = GLFunctionLoader.LoadGLFunction<__glTextureParameterfv>("glTextureParameterfv");
                        __GlueTextureParameteri = GLFunctionLoader.LoadGLFunction<__glTextureParameteri>("glTextureParameteri");
                        __GlueTextureParameteriv = GLFunctionLoader.LoadGLFunction<__glTextureParameteriv>("glTextureParameteriv");
                        __GlueTextureStorage1D = GLFunctionLoader.LoadGLFunction<__glTextureStorage1D>("glTextureStorage1D");
                        __GlueTextureStorage2D = GLFunctionLoader.LoadGLFunction<__glTextureStorage2D>("glTextureStorage2D");
                        __GlueTextureStorage2DMultisample = GLFunctionLoader.LoadGLFunction<__glTextureStorage2DMultisample>("glTextureStorage2DMultisample");
                        __GlueTextureStorage3D = GLFunctionLoader.LoadGLFunction<__glTextureStorage3D>("glTextureStorage3D");
                        __GlueTextureStorage3DMultisample = GLFunctionLoader.LoadGLFunction<__glTextureStorage3DMultisample>("glTextureStorage3DMultisample");
                        __GlueTextureSubImage1D = GLFunctionLoader.LoadGLFunction<__glTextureSubImage1D>("glTextureSubImage1D");
                        __GlueTextureSubImage2D = GLFunctionLoader.LoadGLFunction<__glTextureSubImage2D>("glTextureSubImage2D");
                        __GlueTextureSubImage3D = GLFunctionLoader.LoadGLFunction<__glTextureSubImage3D>("glTextureSubImage3D");
                        __GlueTransformFeedbackBufferBase = GLFunctionLoader.LoadGLFunction<__glTransformFeedbackBufferBase>("glTransformFeedbackBufferBase");
                        __GlueTransformFeedbackBufferRange = GLFunctionLoader.LoadGLFunction<__glTransformFeedbackBufferRange>("glTransformFeedbackBufferRange");
                        __GlueUnmapNamedBuffer = GLFunctionLoader.LoadGLFunction<__glUnmapNamedBuffer>("glUnmapNamedBuffer");
                        __GlueVertexArrayAttribBinding = GLFunctionLoader.LoadGLFunction<__glVertexArrayAttribBinding>("glVertexArrayAttribBinding");
                        __GlueVertexArrayAttribFormat = GLFunctionLoader.LoadGLFunction<__glVertexArrayAttribFormat>("glVertexArrayAttribFormat");
                        __GlueVertexArrayAttribIFormat = GLFunctionLoader.LoadGLFunction<__glVertexArrayAttribIFormat>("glVertexArrayAttribIFormat");
                        __GlueVertexArrayAttribLFormat = GLFunctionLoader.LoadGLFunction<__glVertexArrayAttribLFormat>("glVertexArrayAttribLFormat");
                        __GlueVertexArrayBindingDivisor = GLFunctionLoader.LoadGLFunction<__glVertexArrayBindingDivisor>("glVertexArrayBindingDivisor");
                        __GlueVertexArrayElementBuffer = GLFunctionLoader.LoadGLFunction<__glVertexArrayElementBuffer>("glVertexArrayElementBuffer");
                        __GlueVertexArrayVertexBuffer = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexBuffer>("glVertexArrayVertexBuffer");
                        __GlueVertexArrayVertexBuffers = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexBuffers>("glVertexArrayVertexBuffers");


                        GL_ARB_direct_state_access = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_direct_state_access");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_draw_buffers:
                    {
                        __GlueDrawBuffersARB = GLFunctionLoader.LoadGLFunction<__glDrawBuffersARB>("glDrawBuffersARB");


                        GL_ARB_draw_buffers = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_draw_buffers");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_draw_buffers_blend:
                    {
                        __GlueBlendEquationSeparateiARB = GLFunctionLoader.LoadGLFunction<__glBlendEquationSeparateiARB>("glBlendEquationSeparateiARB");
                        __GlueBlendEquationiARB = GLFunctionLoader.LoadGLFunction<__glBlendEquationiARB>("glBlendEquationiARB");
                        __GlueBlendFuncSeparateiARB = GLFunctionLoader.LoadGLFunction<__glBlendFuncSeparateiARB>("glBlendFuncSeparateiARB");
                        __GlueBlendFunciARB = GLFunctionLoader.LoadGLFunction<__glBlendFunciARB>("glBlendFunciARB");


                        GL_ARB_draw_buffers_blend = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_draw_buffers_blend");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_draw_elements_base_vertex:
                    {
                        __GlueDrawElementsBaseVertex = GLFunctionLoader.LoadGLFunction<__glDrawElementsBaseVertex>("glDrawElementsBaseVertex");
                        __GlueDrawElementsInstancedBaseVertex = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedBaseVertex>("glDrawElementsInstancedBaseVertex");
                        __GlueDrawRangeElementsBaseVertex = GLFunctionLoader.LoadGLFunction<__glDrawRangeElementsBaseVertex>("glDrawRangeElementsBaseVertex");
                        __GlueMultiDrawElementsBaseVertex = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsBaseVertex>("glMultiDrawElementsBaseVertex");


                        GL_ARB_draw_elements_base_vertex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_draw_elements_base_vertex");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_draw_indirect:
                    {
                        __GlueDrawArraysIndirect = GLFunctionLoader.LoadGLFunction<__glDrawArraysIndirect>("glDrawArraysIndirect");
                        __GlueDrawElementsIndirect = GLFunctionLoader.LoadGLFunction<__glDrawElementsIndirect>("glDrawElementsIndirect");


                        GL_ARB_draw_indirect = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_draw_indirect");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_draw_instanced:
                    {


                        GL_ARB_draw_instanced = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_draw_instanced");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_enhanced_layouts:
                    {


                        GL_ARB_enhanced_layouts = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_enhanced_layouts");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_explicit_attrib_location:
                    {


                        GL_ARB_explicit_attrib_location = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_explicit_attrib_location");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_explicit_uniform_location:
                    {


                        GL_ARB_explicit_uniform_location = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_explicit_uniform_location");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_fragment_coord_conventions:
                    {


                        GL_ARB_fragment_coord_conventions = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_fragment_coord_conventions");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_fragment_layer_viewport:
                    {


                        GL_ARB_fragment_layer_viewport = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_fragment_layer_viewport");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_fragment_program:
                    {


                        GL_ARB_fragment_program = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_fragment_program");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_fragment_program_shadow:
                    {


                        GL_ARB_fragment_program_shadow = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_fragment_program_shadow");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_fragment_shader:
                    {


                        GL_ARB_fragment_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_fragment_shader");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_fragment_shader_interlock:
                    {


                        GL_ARB_fragment_shader_interlock = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_fragment_shader_interlock");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_framebuffer_no_attachments:
                    {
                        __GlueFramebufferParameteri = GLFunctionLoader.LoadGLFunction<__glFramebufferParameteri>("glFramebufferParameteri");
                        __GlueGetFramebufferParameteriv = GLFunctionLoader.LoadGLFunction<__glGetFramebufferParameteriv>("glGetFramebufferParameteriv");
                        __GlueGetNamedFramebufferParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedFramebufferParameterivEXT>("glGetNamedFramebufferParameterivEXT");
                        __GlueNamedFramebufferParameteriEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferParameteriEXT>("glNamedFramebufferParameteriEXT");


                        GL_ARB_framebuffer_no_attachments = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_framebuffer_no_attachments");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_framebuffer_object:
                    {
                        __GlueBindFramebuffer = GLFunctionLoader.LoadGLFunction<__glBindFramebuffer>("glBindFramebuffer");
                        __GlueBindRenderbuffer = GLFunctionLoader.LoadGLFunction<__glBindRenderbuffer>("glBindRenderbuffer");
                        __GlueBlitFramebuffer = GLFunctionLoader.LoadGLFunction<__glBlitFramebuffer>("glBlitFramebuffer");
                        __GlueCheckFramebufferStatus = GLFunctionLoader.LoadGLFunction<__glCheckFramebufferStatus>("glCheckFramebufferStatus");
                        __GlueDeleteFramebuffers = GLFunctionLoader.LoadGLFunction<__glDeleteFramebuffers>("glDeleteFramebuffers");
                        __GlueDeleteRenderbuffers = GLFunctionLoader.LoadGLFunction<__glDeleteRenderbuffers>("glDeleteRenderbuffers");
                        __GlueFramebufferRenderbuffer = GLFunctionLoader.LoadGLFunction<__glFramebufferRenderbuffer>("glFramebufferRenderbuffer");
                        __GlueFramebufferTexture1D = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture1D>("glFramebufferTexture1D");
                        __GlueFramebufferTexture2D = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture2D>("glFramebufferTexture2D");
                        __GlueFramebufferTexture3D = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture3D>("glFramebufferTexture3D");
                        __GlueFramebufferTextureLayer = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureLayer>("glFramebufferTextureLayer");
                        __GlueGenFramebuffers = GLFunctionLoader.LoadGLFunction<__glGenFramebuffers>("glGenFramebuffers");
                        __GlueGenRenderbuffers = GLFunctionLoader.LoadGLFunction<__glGenRenderbuffers>("glGenRenderbuffers");
                        __GlueGenerateMipmap = GLFunctionLoader.LoadGLFunction<__glGenerateMipmap>("glGenerateMipmap");
                        __GlueGetFramebufferAttachmentParameteriv = GLFunctionLoader.LoadGLFunction<__glGetFramebufferAttachmentParameteriv>("glGetFramebufferAttachmentParameteriv");
                        __GlueGetRenderbufferParameteriv = GLFunctionLoader.LoadGLFunction<__glGetRenderbufferParameteriv>("glGetRenderbufferParameteriv");
                        __GlueIsFramebuffer = GLFunctionLoader.LoadGLFunction<__glIsFramebuffer>("glIsFramebuffer");
                        __GlueIsRenderbuffer = GLFunctionLoader.LoadGLFunction<__glIsRenderbuffer>("glIsRenderbuffer");
                        __GlueRenderbufferStorage = GLFunctionLoader.LoadGLFunction<__glRenderbufferStorage>("glRenderbufferStorage");
                        __GlueRenderbufferStorageMultisample = GLFunctionLoader.LoadGLFunction<__glRenderbufferStorageMultisample>("glRenderbufferStorageMultisample");


                        GL_ARB_framebuffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_framebuffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_framebuffer_sRGB:
                    {


                        GL_ARB_framebuffer_sRGB = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_framebuffer_sRGB");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_geometry_shader4:
                    {
                        __GlueFramebufferTextureARB = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureARB>("glFramebufferTextureARB");
                        __GlueFramebufferTextureFaceARB = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureFaceARB>("glFramebufferTextureFaceARB");
                        __GlueFramebufferTextureLayerARB = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureLayerARB>("glFramebufferTextureLayerARB");
                        __GlueProgramParameteriARB = GLFunctionLoader.LoadGLFunction<__glProgramParameteriARB>("glProgramParameteriARB");


                        GL_ARB_geometry_shader4 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_geometry_shader4");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_get_program_binary:
                    {
                        __GlueGetProgramBinary = GLFunctionLoader.LoadGLFunction<__glGetProgramBinary>("glGetProgramBinary");
                        __GlueProgramBinary = GLFunctionLoader.LoadGLFunction<__glProgramBinary>("glProgramBinary");
                        __GlueProgramParameteri = GLFunctionLoader.LoadGLFunction<__glProgramParameteri>("glProgramParameteri");


                        GL_ARB_get_program_binary = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_get_program_binary");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_get_texture_sub_image:
                    {
                        __GlueGetCompressedTextureSubImage = GLFunctionLoader.LoadGLFunction<__glGetCompressedTextureSubImage>("glGetCompressedTextureSubImage");
                        __GlueGetTextureSubImage = GLFunctionLoader.LoadGLFunction<__glGetTextureSubImage>("glGetTextureSubImage");


                        GL_ARB_get_texture_sub_image = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_get_texture_sub_image");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_gl_spirv:
                    {
                        __GlueSpecializeShaderARB = GLFunctionLoader.LoadGLFunction<__glSpecializeShaderARB>("glSpecializeShaderARB");


                        GL_ARB_gl_spirv = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_gl_spirv");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_gpu_shader5:
                    {


                        GL_ARB_gpu_shader5 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_gpu_shader5");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_gpu_shader_fp64:
                    {
                        __GlueGetUniformdv = GLFunctionLoader.LoadGLFunction<__glGetUniformdv>("glGetUniformdv");
                        __GlueUniform1d = GLFunctionLoader.LoadGLFunction<__glUniform1d>("glUniform1d");
                        __GlueUniform1dv = GLFunctionLoader.LoadGLFunction<__glUniform1dv>("glUniform1dv");
                        __GlueUniform2d = GLFunctionLoader.LoadGLFunction<__glUniform2d>("glUniform2d");
                        __GlueUniform2dv = GLFunctionLoader.LoadGLFunction<__glUniform2dv>("glUniform2dv");
                        __GlueUniform3d = GLFunctionLoader.LoadGLFunction<__glUniform3d>("glUniform3d");
                        __GlueUniform3dv = GLFunctionLoader.LoadGLFunction<__glUniform3dv>("glUniform3dv");
                        __GlueUniform4d = GLFunctionLoader.LoadGLFunction<__glUniform4d>("glUniform4d");
                        __GlueUniform4dv = GLFunctionLoader.LoadGLFunction<__glUniform4dv>("glUniform4dv");
                        __GlueUniformMatrix2dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2dv>("glUniformMatrix2dv");
                        __GlueUniformMatrix2x3dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2x3dv>("glUniformMatrix2x3dv");
                        __GlueUniformMatrix2x4dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2x4dv>("glUniformMatrix2x4dv");
                        __GlueUniformMatrix3dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3dv>("glUniformMatrix3dv");
                        __GlueUniformMatrix3x2dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3x2dv>("glUniformMatrix3x2dv");
                        __GlueUniformMatrix3x4dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3x4dv>("glUniformMatrix3x4dv");
                        __GlueUniformMatrix4dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4dv>("glUniformMatrix4dv");
                        __GlueUniformMatrix4x2dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4x2dv>("glUniformMatrix4x2dv");
                        __GlueUniformMatrix4x3dv = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4x3dv>("glUniformMatrix4x3dv");


                        GL_ARB_gpu_shader_fp64 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_gpu_shader_fp64");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_gpu_shader_int64:
                    {
                        __GlueGetUniformi64vARB = GLFunctionLoader.LoadGLFunction<__glGetUniformi64vARB>("glGetUniformi64vARB");
                        __GlueGetUniformui64vARB = GLFunctionLoader.LoadGLFunction<__glGetUniformui64vARB>("glGetUniformui64vARB");
                        __GlueGetnUniformi64vARB = GLFunctionLoader.LoadGLFunction<__glGetnUniformi64vARB>("glGetnUniformi64vARB");
                        __GlueGetnUniformui64vARB = GLFunctionLoader.LoadGLFunction<__glGetnUniformui64vARB>("glGetnUniformui64vARB");
                        __GlueProgramUniform1i64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform1i64ARB>("glProgramUniform1i64ARB");
                        __GlueProgramUniform1i64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform1i64vARB>("glProgramUniform1i64vARB");
                        __GlueProgramUniform1ui64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform1ui64ARB>("glProgramUniform1ui64ARB");
                        __GlueProgramUniform1ui64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform1ui64vARB>("glProgramUniform1ui64vARB");
                        __GlueProgramUniform2i64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform2i64ARB>("glProgramUniform2i64ARB");
                        __GlueProgramUniform2i64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform2i64vARB>("glProgramUniform2i64vARB");
                        __GlueProgramUniform2ui64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform2ui64ARB>("glProgramUniform2ui64ARB");
                        __GlueProgramUniform2ui64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform2ui64vARB>("glProgramUniform2ui64vARB");
                        __GlueProgramUniform3i64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform3i64ARB>("glProgramUniform3i64ARB");
                        __GlueProgramUniform3i64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform3i64vARB>("glProgramUniform3i64vARB");
                        __GlueProgramUniform3ui64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform3ui64ARB>("glProgramUniform3ui64ARB");
                        __GlueProgramUniform3ui64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform3ui64vARB>("glProgramUniform3ui64vARB");
                        __GlueProgramUniform4i64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform4i64ARB>("glProgramUniform4i64ARB");
                        __GlueProgramUniform4i64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform4i64vARB>("glProgramUniform4i64vARB");
                        __GlueProgramUniform4ui64ARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform4ui64ARB>("glProgramUniform4ui64ARB");
                        __GlueProgramUniform4ui64vARB = GLFunctionLoader.LoadGLFunction<__glProgramUniform4ui64vARB>("glProgramUniform4ui64vARB");
                        __GlueUniform1i64ARB = GLFunctionLoader.LoadGLFunction<__glUniform1i64ARB>("glUniform1i64ARB");
                        __GlueUniform1i64vARB = GLFunctionLoader.LoadGLFunction<__glUniform1i64vARB>("glUniform1i64vARB");
                        __GlueUniform1ui64ARB = GLFunctionLoader.LoadGLFunction<__glUniform1ui64ARB>("glUniform1ui64ARB");
                        __GlueUniform1ui64vARB = GLFunctionLoader.LoadGLFunction<__glUniform1ui64vARB>("glUniform1ui64vARB");
                        __GlueUniform2i64ARB = GLFunctionLoader.LoadGLFunction<__glUniform2i64ARB>("glUniform2i64ARB");
                        __GlueUniform2i64vARB = GLFunctionLoader.LoadGLFunction<__glUniform2i64vARB>("glUniform2i64vARB");
                        __GlueUniform2ui64ARB = GLFunctionLoader.LoadGLFunction<__glUniform2ui64ARB>("glUniform2ui64ARB");
                        __GlueUniform2ui64vARB = GLFunctionLoader.LoadGLFunction<__glUniform2ui64vARB>("glUniform2ui64vARB");
                        __GlueUniform3i64ARB = GLFunctionLoader.LoadGLFunction<__glUniform3i64ARB>("glUniform3i64ARB");
                        __GlueUniform3i64vARB = GLFunctionLoader.LoadGLFunction<__glUniform3i64vARB>("glUniform3i64vARB");
                        __GlueUniform3ui64ARB = GLFunctionLoader.LoadGLFunction<__glUniform3ui64ARB>("glUniform3ui64ARB");
                        __GlueUniform3ui64vARB = GLFunctionLoader.LoadGLFunction<__glUniform3ui64vARB>("glUniform3ui64vARB");
                        __GlueUniform4i64ARB = GLFunctionLoader.LoadGLFunction<__glUniform4i64ARB>("glUniform4i64ARB");
                        __GlueUniform4i64vARB = GLFunctionLoader.LoadGLFunction<__glUniform4i64vARB>("glUniform4i64vARB");
                        __GlueUniform4ui64ARB = GLFunctionLoader.LoadGLFunction<__glUniform4ui64ARB>("glUniform4ui64ARB");
                        __GlueUniform4ui64vARB = GLFunctionLoader.LoadGLFunction<__glUniform4ui64vARB>("glUniform4ui64vARB");


                        GL_ARB_gpu_shader_int64 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_gpu_shader_int64");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_half_float_pixel:
                    {


                        GL_ARB_half_float_pixel = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_half_float_pixel");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_half_float_vertex:
                    {


                        GL_ARB_half_float_vertex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_half_float_vertex");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_imaging:
                    {
                        __GlueColorSubTable = GLFunctionLoader.LoadGLFunction<__glColorSubTable>("glColorSubTable");
                        __GlueColorTable = GLFunctionLoader.LoadGLFunction<__glColorTable>("glColorTable");
                        __GlueColorTableParameterfv = GLFunctionLoader.LoadGLFunction<__glColorTableParameterfv>("glColorTableParameterfv");
                        __GlueColorTableParameteriv = GLFunctionLoader.LoadGLFunction<__glColorTableParameteriv>("glColorTableParameteriv");
                        __GlueConvolutionFilter1D = GLFunctionLoader.LoadGLFunction<__glConvolutionFilter1D>("glConvolutionFilter1D");
                        __GlueConvolutionFilter2D = GLFunctionLoader.LoadGLFunction<__glConvolutionFilter2D>("glConvolutionFilter2D");
                        __GlueConvolutionParameterf = GLFunctionLoader.LoadGLFunction<__glConvolutionParameterf>("glConvolutionParameterf");
                        __GlueConvolutionParameterfv = GLFunctionLoader.LoadGLFunction<__glConvolutionParameterfv>("glConvolutionParameterfv");
                        __GlueConvolutionParameteri = GLFunctionLoader.LoadGLFunction<__glConvolutionParameteri>("glConvolutionParameteri");
                        __GlueConvolutionParameteriv = GLFunctionLoader.LoadGLFunction<__glConvolutionParameteriv>("glConvolutionParameteriv");
                        __GlueCopyColorSubTable = GLFunctionLoader.LoadGLFunction<__glCopyColorSubTable>("glCopyColorSubTable");
                        __GlueCopyColorTable = GLFunctionLoader.LoadGLFunction<__glCopyColorTable>("glCopyColorTable");
                        __GlueCopyConvolutionFilter1D = GLFunctionLoader.LoadGLFunction<__glCopyConvolutionFilter1D>("glCopyConvolutionFilter1D");
                        __GlueCopyConvolutionFilter2D = GLFunctionLoader.LoadGLFunction<__glCopyConvolutionFilter2D>("glCopyConvolutionFilter2D");
                        __GlueGetColorTable = GLFunctionLoader.LoadGLFunction<__glGetColorTable>("glGetColorTable");
                        __GlueGetColorTableParameterfv = GLFunctionLoader.LoadGLFunction<__glGetColorTableParameterfv>("glGetColorTableParameterfv");
                        __GlueGetColorTableParameteriv = GLFunctionLoader.LoadGLFunction<__glGetColorTableParameteriv>("glGetColorTableParameteriv");
                        __GlueGetConvolutionFilter = GLFunctionLoader.LoadGLFunction<__glGetConvolutionFilter>("glGetConvolutionFilter");
                        __GlueGetConvolutionParameterfv = GLFunctionLoader.LoadGLFunction<__glGetConvolutionParameterfv>("glGetConvolutionParameterfv");
                        __GlueGetConvolutionParameteriv = GLFunctionLoader.LoadGLFunction<__glGetConvolutionParameteriv>("glGetConvolutionParameteriv");
                        __GlueGetHistogram = GLFunctionLoader.LoadGLFunction<__glGetHistogram>("glGetHistogram");
                        __GlueGetHistogramParameterfv = GLFunctionLoader.LoadGLFunction<__glGetHistogramParameterfv>("glGetHistogramParameterfv");
                        __GlueGetHistogramParameteriv = GLFunctionLoader.LoadGLFunction<__glGetHistogramParameteriv>("glGetHistogramParameteriv");
                        __GlueGetMinmax = GLFunctionLoader.LoadGLFunction<__glGetMinmax>("glGetMinmax");
                        __GlueGetMinmaxParameterfv = GLFunctionLoader.LoadGLFunction<__glGetMinmaxParameterfv>("glGetMinmaxParameterfv");
                        __GlueGetMinmaxParameteriv = GLFunctionLoader.LoadGLFunction<__glGetMinmaxParameteriv>("glGetMinmaxParameteriv");
                        __GlueGetSeparableFilter = GLFunctionLoader.LoadGLFunction<__glGetSeparableFilter>("glGetSeparableFilter");
                        __GlueHistogram = GLFunctionLoader.LoadGLFunction<__glHistogram>("glHistogram");
                        __GlueMinmax = GLFunctionLoader.LoadGLFunction<__glMinmax>("glMinmax");
                        __GlueResetHistogram = GLFunctionLoader.LoadGLFunction<__glResetHistogram>("glResetHistogram");
                        __GlueResetMinmax = GLFunctionLoader.LoadGLFunction<__glResetMinmax>("glResetMinmax");
                        __GlueSeparableFilter2D = GLFunctionLoader.LoadGLFunction<__glSeparableFilter2D>("glSeparableFilter2D");


                        GL_ARB_imaging = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_imaging");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_indirect_parameters:
                    {
                        __GlueMultiDrawArraysIndirectCountARB = GLFunctionLoader.LoadGLFunction<__glMultiDrawArraysIndirectCountARB>("glMultiDrawArraysIndirectCountARB");
                        __GlueMultiDrawElementsIndirectCountARB = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsIndirectCountARB>("glMultiDrawElementsIndirectCountARB");


                        GL_ARB_indirect_parameters = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_indirect_parameters");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_instanced_arrays:
                    {
                        __GlueDrawArraysInstancedARB = GLFunctionLoader.LoadGLFunction<__glDrawArraysInstancedARB>("glDrawArraysInstancedARB");
                        __GlueDrawElementsInstancedARB = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedARB>("glDrawElementsInstancedARB");
                        __GlueVertexAttribDivisorARB = GLFunctionLoader.LoadGLFunction<__glVertexAttribDivisorARB>("glVertexAttribDivisorARB");


                        GL_ARB_instanced_arrays = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_instanced_arrays");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_internalformat_query:
                    {
                        __GlueGetInternalformativ = GLFunctionLoader.LoadGLFunction<__glGetInternalformativ>("glGetInternalformativ");


                        GL_ARB_internalformat_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_internalformat_query");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_internalformat_query2:
                    {
                        __GlueGetInternalformati64v = GLFunctionLoader.LoadGLFunction<__glGetInternalformati64v>("glGetInternalformati64v");


                        GL_ARB_internalformat_query2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_internalformat_query2");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_invalidate_subdata:
                    {
                        __GlueInvalidateBufferData = GLFunctionLoader.LoadGLFunction<__glInvalidateBufferData>("glInvalidateBufferData");
                        __GlueInvalidateBufferSubData = GLFunctionLoader.LoadGLFunction<__glInvalidateBufferSubData>("glInvalidateBufferSubData");
                        __GlueInvalidateFramebuffer = GLFunctionLoader.LoadGLFunction<__glInvalidateFramebuffer>("glInvalidateFramebuffer");
                        __GlueInvalidateSubFramebuffer = GLFunctionLoader.LoadGLFunction<__glInvalidateSubFramebuffer>("glInvalidateSubFramebuffer");
                        __GlueInvalidateTexImage = GLFunctionLoader.LoadGLFunction<__glInvalidateTexImage>("glInvalidateTexImage");
                        __GlueInvalidateTexSubImage = GLFunctionLoader.LoadGLFunction<__glInvalidateTexSubImage>("glInvalidateTexSubImage");


                        GL_ARB_invalidate_subdata = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_invalidate_subdata");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_map_buffer_alignment:
                    {


                        GL_ARB_map_buffer_alignment = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_map_buffer_alignment");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_map_buffer_range:
                    {
                        __GlueFlushMappedBufferRange = GLFunctionLoader.LoadGLFunction<__glFlushMappedBufferRange>("glFlushMappedBufferRange");
                        __GlueMapBufferRange = GLFunctionLoader.LoadGLFunction<__glMapBufferRange>("glMapBufferRange");


                        GL_ARB_map_buffer_range = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_map_buffer_range");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_matrix_palette:
                    {
                        __GlueCurrentPaletteMatrixARB = GLFunctionLoader.LoadGLFunction<__glCurrentPaletteMatrixARB>("glCurrentPaletteMatrixARB");
                        __GlueMatrixIndexPointerARB = GLFunctionLoader.LoadGLFunction<__glMatrixIndexPointerARB>("glMatrixIndexPointerARB");
                        __GlueMatrixIndexubvARB = GLFunctionLoader.LoadGLFunction<__glMatrixIndexubvARB>("glMatrixIndexubvARB");
                        __GlueMatrixIndexuivARB = GLFunctionLoader.LoadGLFunction<__glMatrixIndexuivARB>("glMatrixIndexuivARB");
                        __GlueMatrixIndexusvARB = GLFunctionLoader.LoadGLFunction<__glMatrixIndexusvARB>("glMatrixIndexusvARB");


                        GL_ARB_matrix_palette = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_matrix_palette");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_multi_bind:
                    {
                        __GlueBindBuffersBase = GLFunctionLoader.LoadGLFunction<__glBindBuffersBase>("glBindBuffersBase");
                        __GlueBindBuffersRange = GLFunctionLoader.LoadGLFunction<__glBindBuffersRange>("glBindBuffersRange");
                        __GlueBindImageTextures = GLFunctionLoader.LoadGLFunction<__glBindImageTextures>("glBindImageTextures");
                        __GlueBindSamplers = GLFunctionLoader.LoadGLFunction<__glBindSamplers>("glBindSamplers");
                        __GlueBindTextures = GLFunctionLoader.LoadGLFunction<__glBindTextures>("glBindTextures");
                        __GlueBindVertexBuffers = GLFunctionLoader.LoadGLFunction<__glBindVertexBuffers>("glBindVertexBuffers");


                        GL_ARB_multi_bind = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_multi_bind");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_multi_draw_indirect:
                    {
                        __GlueMultiDrawArraysIndirect = GLFunctionLoader.LoadGLFunction<__glMultiDrawArraysIndirect>("glMultiDrawArraysIndirect");
                        __GlueMultiDrawElementsIndirect = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsIndirect>("glMultiDrawElementsIndirect");


                        GL_ARB_multi_draw_indirect = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_multi_draw_indirect");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_multisample:
                    {
                        __GlueSampleCoverageARB = GLFunctionLoader.LoadGLFunction<__glSampleCoverageARB>("glSampleCoverageARB");


                        GL_ARB_multisample = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_multisample");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_multitexture:
                    {
                        __GlueActiveTextureARB = GLFunctionLoader.LoadGLFunction<__glActiveTextureARB>("glActiveTextureARB");
                        __GlueClientActiveTextureARB = GLFunctionLoader.LoadGLFunction<__glClientActiveTextureARB>("glClientActiveTextureARB");
                        __GlueMultiTexCoord1dARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1dARB>("glMultiTexCoord1dARB");
                        __GlueMultiTexCoord1dvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1dvARB>("glMultiTexCoord1dvARB");
                        __GlueMultiTexCoord1fARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1fARB>("glMultiTexCoord1fARB");
                        __GlueMultiTexCoord1fvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1fvARB>("glMultiTexCoord1fvARB");
                        __GlueMultiTexCoord1iARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1iARB>("glMultiTexCoord1iARB");
                        __GlueMultiTexCoord1ivARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1ivARB>("glMultiTexCoord1ivARB");
                        __GlueMultiTexCoord1sARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1sARB>("glMultiTexCoord1sARB");
                        __GlueMultiTexCoord1svARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord1svARB>("glMultiTexCoord1svARB");
                        __GlueMultiTexCoord2dARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2dARB>("glMultiTexCoord2dARB");
                        __GlueMultiTexCoord2dvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2dvARB>("glMultiTexCoord2dvARB");
                        __GlueMultiTexCoord2fARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2fARB>("glMultiTexCoord2fARB");
                        __GlueMultiTexCoord2fvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2fvARB>("glMultiTexCoord2fvARB");
                        __GlueMultiTexCoord2iARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2iARB>("glMultiTexCoord2iARB");
                        __GlueMultiTexCoord2ivARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2ivARB>("glMultiTexCoord2ivARB");
                        __GlueMultiTexCoord2sARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2sARB>("glMultiTexCoord2sARB");
                        __GlueMultiTexCoord2svARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord2svARB>("glMultiTexCoord2svARB");
                        __GlueMultiTexCoord3dARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3dARB>("glMultiTexCoord3dARB");
                        __GlueMultiTexCoord3dvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3dvARB>("glMultiTexCoord3dvARB");
                        __GlueMultiTexCoord3fARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3fARB>("glMultiTexCoord3fARB");
                        __GlueMultiTexCoord3fvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3fvARB>("glMultiTexCoord3fvARB");
                        __GlueMultiTexCoord3iARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3iARB>("glMultiTexCoord3iARB");
                        __GlueMultiTexCoord3ivARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3ivARB>("glMultiTexCoord3ivARB");
                        __GlueMultiTexCoord3sARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3sARB>("glMultiTexCoord3sARB");
                        __GlueMultiTexCoord3svARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord3svARB>("glMultiTexCoord3svARB");
                        __GlueMultiTexCoord4dARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4dARB>("glMultiTexCoord4dARB");
                        __GlueMultiTexCoord4dvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4dvARB>("glMultiTexCoord4dvARB");
                        __GlueMultiTexCoord4fARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4fARB>("glMultiTexCoord4fARB");
                        __GlueMultiTexCoord4fvARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4fvARB>("glMultiTexCoord4fvARB");
                        __GlueMultiTexCoord4iARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4iARB>("glMultiTexCoord4iARB");
                        __GlueMultiTexCoord4ivARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4ivARB>("glMultiTexCoord4ivARB");
                        __GlueMultiTexCoord4sARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4sARB>("glMultiTexCoord4sARB");
                        __GlueMultiTexCoord4svARB = GLFunctionLoader.LoadGLFunction<__glMultiTexCoord4svARB>("glMultiTexCoord4svARB");


                        GL_ARB_multitexture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_multitexture");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_occlusion_query:
                    {
                        __GlueBeginQueryARB = GLFunctionLoader.LoadGLFunction<__glBeginQueryARB>("glBeginQueryARB");
                        __GlueDeleteQueriesARB = GLFunctionLoader.LoadGLFunction<__glDeleteQueriesARB>("glDeleteQueriesARB");
                        __GlueEndQueryARB = GLFunctionLoader.LoadGLFunction<__glEndQueryARB>("glEndQueryARB");
                        __GlueGenQueriesARB = GLFunctionLoader.LoadGLFunction<__glGenQueriesARB>("glGenQueriesARB");
                        __GlueGetQueryObjectivARB = GLFunctionLoader.LoadGLFunction<__glGetQueryObjectivARB>("glGetQueryObjectivARB");
                        __GlueGetQueryObjectuivARB = GLFunctionLoader.LoadGLFunction<__glGetQueryObjectuivARB>("glGetQueryObjectuivARB");
                        __GlueGetQueryivARB = GLFunctionLoader.LoadGLFunction<__glGetQueryivARB>("glGetQueryivARB");
                        __GlueIsQueryARB = GLFunctionLoader.LoadGLFunction<__glIsQueryARB>("glIsQueryARB");


                        GL_ARB_occlusion_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_occlusion_query");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_occlusion_query2:
                    {


                        GL_ARB_occlusion_query2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_occlusion_query2");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_parallel_shader_compile:
                    {
                        __GlueMaxShaderCompilerThreadsARB = GLFunctionLoader.LoadGLFunction<__glMaxShaderCompilerThreadsARB>("glMaxShaderCompilerThreadsARB");


                        GL_ARB_parallel_shader_compile = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_parallel_shader_compile");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_pipeline_statistics_query:
                    {


                        GL_ARB_pipeline_statistics_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_pipeline_statistics_query");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_pixel_buffer_object:
                    {


                        GL_ARB_pixel_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_pixel_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_point_parameters:
                    {
                        __GluePointParameterfARB = GLFunctionLoader.LoadGLFunction<__glPointParameterfARB>("glPointParameterfARB");
                        __GluePointParameterfvARB = GLFunctionLoader.LoadGLFunction<__glPointParameterfvARB>("glPointParameterfvARB");


                        GL_ARB_point_parameters = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_point_parameters");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_point_sprite:
                    {


                        GL_ARB_point_sprite = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_point_sprite");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_polygon_offset_clamp:
                    {
                        __GluePolygonOffsetClamp = GLFunctionLoader.LoadGLFunction<__glPolygonOffsetClamp>("glPolygonOffsetClamp");


                        GL_ARB_polygon_offset_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_polygon_offset_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_post_depth_coverage:
                    {


                        GL_ARB_post_depth_coverage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_post_depth_coverage");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_program_interface_query:
                    {
                        __GlueGetProgramInterfaceiv = GLFunctionLoader.LoadGLFunction<__glGetProgramInterfaceiv>("glGetProgramInterfaceiv");
                        __GlueGetProgramResourceIndex = GLFunctionLoader.LoadGLFunction<__glGetProgramResourceIndex>("glGetProgramResourceIndex");
                        __GlueGetProgramResourceLocation = GLFunctionLoader.LoadGLFunction<__glGetProgramResourceLocation>("glGetProgramResourceLocation");
                        __GlueGetProgramResourceLocationIndex = GLFunctionLoader.LoadGLFunction<__glGetProgramResourceLocationIndex>("glGetProgramResourceLocationIndex");
                        __GlueGetProgramResourceName = GLFunctionLoader.LoadGLFunction<__glGetProgramResourceName>("glGetProgramResourceName");
                        __GlueGetProgramResourceiv = GLFunctionLoader.LoadGLFunction<__glGetProgramResourceiv>("glGetProgramResourceiv");


                        GL_ARB_program_interface_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_program_interface_query");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_provoking_vertex:
                    {
                        __GlueProvokingVertex = GLFunctionLoader.LoadGLFunction<__glProvokingVertex>("glProvokingVertex");


                        GL_ARB_provoking_vertex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_provoking_vertex");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_query_buffer_object:
                    {


                        GL_ARB_query_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_query_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_robust_buffer_access_behavior:
                    {


                        GL_ARB_robust_buffer_access_behavior = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_robust_buffer_access_behavior");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_robustness:
                    {
                        __GlueGetGraphicsResetStatusARB = GLFunctionLoader.LoadGLFunction<__glGetGraphicsResetStatusARB>("glGetGraphicsResetStatusARB");
                        __GlueGetnColorTableARB = GLFunctionLoader.LoadGLFunction<__glGetnColorTableARB>("glGetnColorTableARB");
                        __GlueGetnCompressedTexImageARB = GLFunctionLoader.LoadGLFunction<__glGetnCompressedTexImageARB>("glGetnCompressedTexImageARB");
                        __GlueGetnConvolutionFilterARB = GLFunctionLoader.LoadGLFunction<__glGetnConvolutionFilterARB>("glGetnConvolutionFilterARB");
                        __GlueGetnHistogramARB = GLFunctionLoader.LoadGLFunction<__glGetnHistogramARB>("glGetnHistogramARB");
                        __GlueGetnMapdvARB = GLFunctionLoader.LoadGLFunction<__glGetnMapdvARB>("glGetnMapdvARB");
                        __GlueGetnMapfvARB = GLFunctionLoader.LoadGLFunction<__glGetnMapfvARB>("glGetnMapfvARB");
                        __GlueGetnMapivARB = GLFunctionLoader.LoadGLFunction<__glGetnMapivARB>("glGetnMapivARB");
                        __GlueGetnMinmaxARB = GLFunctionLoader.LoadGLFunction<__glGetnMinmaxARB>("glGetnMinmaxARB");
                        __GlueGetnPixelMapfvARB = GLFunctionLoader.LoadGLFunction<__glGetnPixelMapfvARB>("glGetnPixelMapfvARB");
                        __GlueGetnPixelMapuivARB = GLFunctionLoader.LoadGLFunction<__glGetnPixelMapuivARB>("glGetnPixelMapuivARB");
                        __GlueGetnPixelMapusvARB = GLFunctionLoader.LoadGLFunction<__glGetnPixelMapusvARB>("glGetnPixelMapusvARB");
                        __GlueGetnPolygonStippleARB = GLFunctionLoader.LoadGLFunction<__glGetnPolygonStippleARB>("glGetnPolygonStippleARB");
                        __GlueGetnSeparableFilterARB = GLFunctionLoader.LoadGLFunction<__glGetnSeparableFilterARB>("glGetnSeparableFilterARB");
                        __GlueGetnTexImageARB = GLFunctionLoader.LoadGLFunction<__glGetnTexImageARB>("glGetnTexImageARB");
                        __GlueGetnUniformdvARB = GLFunctionLoader.LoadGLFunction<__glGetnUniformdvARB>("glGetnUniformdvARB");
                        __GlueGetnUniformfvARB = GLFunctionLoader.LoadGLFunction<__glGetnUniformfvARB>("glGetnUniformfvARB");
                        __GlueGetnUniformivARB = GLFunctionLoader.LoadGLFunction<__glGetnUniformivARB>("glGetnUniformivARB");
                        __GlueGetnUniformuivARB = GLFunctionLoader.LoadGLFunction<__glGetnUniformuivARB>("glGetnUniformuivARB");
                        __GlueReadnPixelsARB = GLFunctionLoader.LoadGLFunction<__glReadnPixelsARB>("glReadnPixelsARB");


                        GL_ARB_robustness = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_robustness");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_robustness_application_isolation:
                    {


                        GL_ARB_robustness_application_isolation = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_robustness_application_isolation");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_robustness_share_group_isolation:
                    {


                        GL_ARB_robustness_share_group_isolation = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_robustness_share_group_isolation");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sample_locations:
                    {
                        __GlueFramebufferSampleLocationsfvARB = GLFunctionLoader.LoadGLFunction<__glFramebufferSampleLocationsfvARB>("glFramebufferSampleLocationsfvARB");
                        __GlueNamedFramebufferSampleLocationsfvARB = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferSampleLocationsfvARB>("glNamedFramebufferSampleLocationsfvARB");


                        GL_ARB_sample_locations = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sample_locations");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sample_shading:
                    {
                        __GlueMinSampleShadingARB = GLFunctionLoader.LoadGLFunction<__glMinSampleShadingARB>("glMinSampleShadingARB");


                        GL_ARB_sample_shading = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sample_shading");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sampler_objects:
                    {
                        __GlueBindSampler = GLFunctionLoader.LoadGLFunction<__glBindSampler>("glBindSampler");
                        __GlueDeleteSamplers = GLFunctionLoader.LoadGLFunction<__glDeleteSamplers>("glDeleteSamplers");
                        __GlueGenSamplers = GLFunctionLoader.LoadGLFunction<__glGenSamplers>("glGenSamplers");
                        __GlueGetSamplerParameterIiv = GLFunctionLoader.LoadGLFunction<__glGetSamplerParameterIiv>("glGetSamplerParameterIiv");
                        __GlueGetSamplerParameterIuiv = GLFunctionLoader.LoadGLFunction<__glGetSamplerParameterIuiv>("glGetSamplerParameterIuiv");
                        __GlueGetSamplerParameterfv = GLFunctionLoader.LoadGLFunction<__glGetSamplerParameterfv>("glGetSamplerParameterfv");
                        __GlueGetSamplerParameteriv = GLFunctionLoader.LoadGLFunction<__glGetSamplerParameteriv>("glGetSamplerParameteriv");
                        __GlueIsSampler = GLFunctionLoader.LoadGLFunction<__glIsSampler>("glIsSampler");
                        __GlueSamplerParameterIiv = GLFunctionLoader.LoadGLFunction<__glSamplerParameterIiv>("glSamplerParameterIiv");
                        __GlueSamplerParameterIuiv = GLFunctionLoader.LoadGLFunction<__glSamplerParameterIuiv>("glSamplerParameterIuiv");
                        __GlueSamplerParameterf = GLFunctionLoader.LoadGLFunction<__glSamplerParameterf>("glSamplerParameterf");
                        __GlueSamplerParameterfv = GLFunctionLoader.LoadGLFunction<__glSamplerParameterfv>("glSamplerParameterfv");
                        __GlueSamplerParameteri = GLFunctionLoader.LoadGLFunction<__glSamplerParameteri>("glSamplerParameteri");
                        __GlueSamplerParameteriv = GLFunctionLoader.LoadGLFunction<__glSamplerParameteriv>("glSamplerParameteriv");


                        GL_ARB_sampler_objects = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sampler_objects");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_seamless_cube_map:
                    {


                        GL_ARB_seamless_cube_map = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_seamless_cube_map");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_seamless_cubemap_per_texture:
                    {


                        GL_ARB_seamless_cubemap_per_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_seamless_cubemap_per_texture");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_separate_shader_objects:
                    {
                        __GlueActiveShaderProgram = GLFunctionLoader.LoadGLFunction<__glActiveShaderProgram>("glActiveShaderProgram");
                        __GlueBindProgramPipeline = GLFunctionLoader.LoadGLFunction<__glBindProgramPipeline>("glBindProgramPipeline");
                        __GlueCreateShaderProgramv = GLFunctionLoader.LoadGLFunction<__glCreateShaderProgramv>("glCreateShaderProgramv");
                        __GlueDeleteProgramPipelines = GLFunctionLoader.LoadGLFunction<__glDeleteProgramPipelines>("glDeleteProgramPipelines");
                        __GlueGenProgramPipelines = GLFunctionLoader.LoadGLFunction<__glGenProgramPipelines>("glGenProgramPipelines");
                        __GlueGetProgramPipelineInfoLog = GLFunctionLoader.LoadGLFunction<__glGetProgramPipelineInfoLog>("glGetProgramPipelineInfoLog");
                        __GlueGetProgramPipelineiv = GLFunctionLoader.LoadGLFunction<__glGetProgramPipelineiv>("glGetProgramPipelineiv");
                        __GlueIsProgramPipeline = GLFunctionLoader.LoadGLFunction<__glIsProgramPipeline>("glIsProgramPipeline");
                        __GlueProgramUniform1d = GLFunctionLoader.LoadGLFunction<__glProgramUniform1d>("glProgramUniform1d");
                        __GlueProgramUniform1dv = GLFunctionLoader.LoadGLFunction<__glProgramUniform1dv>("glProgramUniform1dv");
                        __GlueProgramUniform1f = GLFunctionLoader.LoadGLFunction<__glProgramUniform1f>("glProgramUniform1f");
                        __GlueProgramUniform1fv = GLFunctionLoader.LoadGLFunction<__glProgramUniform1fv>("glProgramUniform1fv");
                        __GlueProgramUniform1i = GLFunctionLoader.LoadGLFunction<__glProgramUniform1i>("glProgramUniform1i");
                        __GlueProgramUniform1iv = GLFunctionLoader.LoadGLFunction<__glProgramUniform1iv>("glProgramUniform1iv");
                        __GlueProgramUniform1ui = GLFunctionLoader.LoadGLFunction<__glProgramUniform1ui>("glProgramUniform1ui");
                        __GlueProgramUniform1uiv = GLFunctionLoader.LoadGLFunction<__glProgramUniform1uiv>("glProgramUniform1uiv");
                        __GlueProgramUniform2d = GLFunctionLoader.LoadGLFunction<__glProgramUniform2d>("glProgramUniform2d");
                        __GlueProgramUniform2dv = GLFunctionLoader.LoadGLFunction<__glProgramUniform2dv>("glProgramUniform2dv");
                        __GlueProgramUniform2f = GLFunctionLoader.LoadGLFunction<__glProgramUniform2f>("glProgramUniform2f");
                        __GlueProgramUniform2fv = GLFunctionLoader.LoadGLFunction<__glProgramUniform2fv>("glProgramUniform2fv");
                        __GlueProgramUniform2i = GLFunctionLoader.LoadGLFunction<__glProgramUniform2i>("glProgramUniform2i");
                        __GlueProgramUniform2iv = GLFunctionLoader.LoadGLFunction<__glProgramUniform2iv>("glProgramUniform2iv");
                        __GlueProgramUniform2ui = GLFunctionLoader.LoadGLFunction<__glProgramUniform2ui>("glProgramUniform2ui");
                        __GlueProgramUniform2uiv = GLFunctionLoader.LoadGLFunction<__glProgramUniform2uiv>("glProgramUniform2uiv");
                        __GlueProgramUniform3d = GLFunctionLoader.LoadGLFunction<__glProgramUniform3d>("glProgramUniform3d");
                        __GlueProgramUniform3dv = GLFunctionLoader.LoadGLFunction<__glProgramUniform3dv>("glProgramUniform3dv");
                        __GlueProgramUniform3f = GLFunctionLoader.LoadGLFunction<__glProgramUniform3f>("glProgramUniform3f");
                        __GlueProgramUniform3fv = GLFunctionLoader.LoadGLFunction<__glProgramUniform3fv>("glProgramUniform3fv");
                        __GlueProgramUniform3i = GLFunctionLoader.LoadGLFunction<__glProgramUniform3i>("glProgramUniform3i");
                        __GlueProgramUniform3iv = GLFunctionLoader.LoadGLFunction<__glProgramUniform3iv>("glProgramUniform3iv");
                        __GlueProgramUniform3ui = GLFunctionLoader.LoadGLFunction<__glProgramUniform3ui>("glProgramUniform3ui");
                        __GlueProgramUniform3uiv = GLFunctionLoader.LoadGLFunction<__glProgramUniform3uiv>("glProgramUniform3uiv");
                        __GlueProgramUniform4d = GLFunctionLoader.LoadGLFunction<__glProgramUniform4d>("glProgramUniform4d");
                        __GlueProgramUniform4dv = GLFunctionLoader.LoadGLFunction<__glProgramUniform4dv>("glProgramUniform4dv");
                        __GlueProgramUniform4f = GLFunctionLoader.LoadGLFunction<__glProgramUniform4f>("glProgramUniform4f");
                        __GlueProgramUniform4fv = GLFunctionLoader.LoadGLFunction<__glProgramUniform4fv>("glProgramUniform4fv");
                        __GlueProgramUniform4i = GLFunctionLoader.LoadGLFunction<__glProgramUniform4i>("glProgramUniform4i");
                        __GlueProgramUniform4iv = GLFunctionLoader.LoadGLFunction<__glProgramUniform4iv>("glProgramUniform4iv");
                        __GlueProgramUniform4ui = GLFunctionLoader.LoadGLFunction<__glProgramUniform4ui>("glProgramUniform4ui");
                        __GlueProgramUniform4uiv = GLFunctionLoader.LoadGLFunction<__glProgramUniform4uiv>("glProgramUniform4uiv");
                        __GlueProgramUniformMatrix2dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2dv>("glProgramUniformMatrix2dv");
                        __GlueProgramUniformMatrix2fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2fv>("glProgramUniformMatrix2fv");
                        __GlueProgramUniformMatrix2x3dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2x3dv>("glProgramUniformMatrix2x3dv");
                        __GlueProgramUniformMatrix2x3fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2x3fv>("glProgramUniformMatrix2x3fv");
                        __GlueProgramUniformMatrix2x4dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2x4dv>("glProgramUniformMatrix2x4dv");
                        __GlueProgramUniformMatrix2x4fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2x4fv>("glProgramUniformMatrix2x4fv");
                        __GlueProgramUniformMatrix3dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3dv>("glProgramUniformMatrix3dv");
                        __GlueProgramUniformMatrix3fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3fv>("glProgramUniformMatrix3fv");
                        __GlueProgramUniformMatrix3x2dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3x2dv>("glProgramUniformMatrix3x2dv");
                        __GlueProgramUniformMatrix3x2fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3x2fv>("glProgramUniformMatrix3x2fv");
                        __GlueProgramUniformMatrix3x4dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3x4dv>("glProgramUniformMatrix3x4dv");
                        __GlueProgramUniformMatrix3x4fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3x4fv>("glProgramUniformMatrix3x4fv");
                        __GlueProgramUniformMatrix4dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4dv>("glProgramUniformMatrix4dv");
                        __GlueProgramUniformMatrix4fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4fv>("glProgramUniformMatrix4fv");
                        __GlueProgramUniformMatrix4x2dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4x2dv>("glProgramUniformMatrix4x2dv");
                        __GlueProgramUniformMatrix4x2fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4x2fv>("glProgramUniformMatrix4x2fv");
                        __GlueProgramUniformMatrix4x3dv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4x3dv>("glProgramUniformMatrix4x3dv");
                        __GlueProgramUniformMatrix4x3fv = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4x3fv>("glProgramUniformMatrix4x3fv");
                        __GlueUseProgramStages = GLFunctionLoader.LoadGLFunction<__glUseProgramStages>("glUseProgramStages");
                        __GlueValidateProgramPipeline = GLFunctionLoader.LoadGLFunction<__glValidateProgramPipeline>("glValidateProgramPipeline");


                        GL_ARB_separate_shader_objects = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_separate_shader_objects");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_atomic_counter_ops:
                    {


                        GL_ARB_shader_atomic_counter_ops = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_atomic_counter_ops");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_atomic_counters:
                    {
                        __GlueGetActiveAtomicCounterBufferiv = GLFunctionLoader.LoadGLFunction<__glGetActiveAtomicCounterBufferiv>("glGetActiveAtomicCounterBufferiv");


                        GL_ARB_shader_atomic_counters = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_atomic_counters");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_ballot:
                    {


                        GL_ARB_shader_ballot = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_ballot");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_bit_encoding:
                    {


                        GL_ARB_shader_bit_encoding = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_bit_encoding");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_clock:
                    {


                        GL_ARB_shader_clock = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_clock");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_draw_parameters:
                    {


                        GL_ARB_shader_draw_parameters = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_draw_parameters");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_group_vote:
                    {


                        GL_ARB_shader_group_vote = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_group_vote");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_image_load_store:
                    {
                        __GlueBindImageTexture = GLFunctionLoader.LoadGLFunction<__glBindImageTexture>("glBindImageTexture");
                        __GlueMemoryBarrier = GLFunctionLoader.LoadGLFunction<__glMemoryBarrier>("glMemoryBarrier");


                        GL_ARB_shader_image_load_store = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_image_load_store");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_image_size:
                    {


                        GL_ARB_shader_image_size = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_image_size");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_objects:
                    {
                        __GlueAttachObjectARB = GLFunctionLoader.LoadGLFunction<__glAttachObjectARB>("glAttachObjectARB");
                        __GlueCompileShaderARB = GLFunctionLoader.LoadGLFunction<__glCompileShaderARB>("glCompileShaderARB");
                        __GlueCreateProgramObjectARB = GLFunctionLoader.LoadGLFunction<__glCreateProgramObjectARB>("glCreateProgramObjectARB");
                        __GlueCreateShaderObjectARB = GLFunctionLoader.LoadGLFunction<__glCreateShaderObjectARB>("glCreateShaderObjectARB");
                        __GlueDeleteObjectARB = GLFunctionLoader.LoadGLFunction<__glDeleteObjectARB>("glDeleteObjectARB");
                        __GlueDetachObjectARB = GLFunctionLoader.LoadGLFunction<__glDetachObjectARB>("glDetachObjectARB");
                        __GlueGetActiveUniformARB = GLFunctionLoader.LoadGLFunction<__glGetActiveUniformARB>("glGetActiveUniformARB");
                        __GlueGetAttachedObjectsARB = GLFunctionLoader.LoadGLFunction<__glGetAttachedObjectsARB>("glGetAttachedObjectsARB");
                        __GlueGetHandleARB = GLFunctionLoader.LoadGLFunction<__glGetHandleARB>("glGetHandleARB");
                        __GlueGetInfoLogARB = GLFunctionLoader.LoadGLFunction<__glGetInfoLogARB>("glGetInfoLogARB");
                        __GlueGetObjectParameterfvARB = GLFunctionLoader.LoadGLFunction<__glGetObjectParameterfvARB>("glGetObjectParameterfvARB");
                        __GlueGetObjectParameterivARB = GLFunctionLoader.LoadGLFunction<__glGetObjectParameterivARB>("glGetObjectParameterivARB");
                        __GlueGetShaderSourceARB = GLFunctionLoader.LoadGLFunction<__glGetShaderSourceARB>("glGetShaderSourceARB");
                        __GlueGetUniformLocationARB = GLFunctionLoader.LoadGLFunction<__glGetUniformLocationARB>("glGetUniformLocationARB");
                        __GlueGetUniformfvARB = GLFunctionLoader.LoadGLFunction<__glGetUniformfvARB>("glGetUniformfvARB");
                        __GlueGetUniformivARB = GLFunctionLoader.LoadGLFunction<__glGetUniformivARB>("glGetUniformivARB");
                        __GlueLinkProgramARB = GLFunctionLoader.LoadGLFunction<__glLinkProgramARB>("glLinkProgramARB");
                        __GlueShaderSourceARB = GLFunctionLoader.LoadGLFunction<__glShaderSourceARB>("glShaderSourceARB");
                        __GlueUniform1fARB = GLFunctionLoader.LoadGLFunction<__glUniform1fARB>("glUniform1fARB");
                        __GlueUniform1fvARB = GLFunctionLoader.LoadGLFunction<__glUniform1fvARB>("glUniform1fvARB");
                        __GlueUniform1iARB = GLFunctionLoader.LoadGLFunction<__glUniform1iARB>("glUniform1iARB");
                        __GlueUniform1ivARB = GLFunctionLoader.LoadGLFunction<__glUniform1ivARB>("glUniform1ivARB");
                        __GlueUniform2fARB = GLFunctionLoader.LoadGLFunction<__glUniform2fARB>("glUniform2fARB");
                        __GlueUniform2fvARB = GLFunctionLoader.LoadGLFunction<__glUniform2fvARB>("glUniform2fvARB");
                        __GlueUniform2iARB = GLFunctionLoader.LoadGLFunction<__glUniform2iARB>("glUniform2iARB");
                        __GlueUniform2ivARB = GLFunctionLoader.LoadGLFunction<__glUniform2ivARB>("glUniform2ivARB");
                        __GlueUniform3fARB = GLFunctionLoader.LoadGLFunction<__glUniform3fARB>("glUniform3fARB");
                        __GlueUniform3fvARB = GLFunctionLoader.LoadGLFunction<__glUniform3fvARB>("glUniform3fvARB");
                        __GlueUniform3iARB = GLFunctionLoader.LoadGLFunction<__glUniform3iARB>("glUniform3iARB");
                        __GlueUniform3ivARB = GLFunctionLoader.LoadGLFunction<__glUniform3ivARB>("glUniform3ivARB");
                        __GlueUniform4fARB = GLFunctionLoader.LoadGLFunction<__glUniform4fARB>("glUniform4fARB");
                        __GlueUniform4fvARB = GLFunctionLoader.LoadGLFunction<__glUniform4fvARB>("glUniform4fvARB");
                        __GlueUniform4iARB = GLFunctionLoader.LoadGLFunction<__glUniform4iARB>("glUniform4iARB");
                        __GlueUniform4ivARB = GLFunctionLoader.LoadGLFunction<__glUniform4ivARB>("glUniform4ivARB");
                        __GlueUniformMatrix2fvARB = GLFunctionLoader.LoadGLFunction<__glUniformMatrix2fvARB>("glUniformMatrix2fvARB");
                        __GlueUniformMatrix3fvARB = GLFunctionLoader.LoadGLFunction<__glUniformMatrix3fvARB>("glUniformMatrix3fvARB");
                        __GlueUniformMatrix4fvARB = GLFunctionLoader.LoadGLFunction<__glUniformMatrix4fvARB>("glUniformMatrix4fvARB");
                        __GlueUseProgramObjectARB = GLFunctionLoader.LoadGLFunction<__glUseProgramObjectARB>("glUseProgramObjectARB");
                        __GlueValidateProgramARB = GLFunctionLoader.LoadGLFunction<__glValidateProgramARB>("glValidateProgramARB");


                        GL_ARB_shader_objects = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_objects");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_precision:
                    {


                        GL_ARB_shader_precision = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_precision");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_stencil_export:
                    {


                        GL_ARB_shader_stencil_export = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_stencil_export");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_storage_buffer_object:
                    {
                        __GlueShaderStorageBlockBinding = GLFunctionLoader.LoadGLFunction<__glShaderStorageBlockBinding>("glShaderStorageBlockBinding");


                        GL_ARB_shader_storage_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_storage_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_subroutine:
                    {
                        __GlueGetActiveSubroutineName = GLFunctionLoader.LoadGLFunction<__glGetActiveSubroutineName>("glGetActiveSubroutineName");
                        __GlueGetActiveSubroutineUniformName = GLFunctionLoader.LoadGLFunction<__glGetActiveSubroutineUniformName>("glGetActiveSubroutineUniformName");
                        __GlueGetActiveSubroutineUniformiv = GLFunctionLoader.LoadGLFunction<__glGetActiveSubroutineUniformiv>("glGetActiveSubroutineUniformiv");
                        __GlueGetProgramStageiv = GLFunctionLoader.LoadGLFunction<__glGetProgramStageiv>("glGetProgramStageiv");
                        __GlueGetSubroutineIndex = GLFunctionLoader.LoadGLFunction<__glGetSubroutineIndex>("glGetSubroutineIndex");
                        __GlueGetSubroutineUniformLocation = GLFunctionLoader.LoadGLFunction<__glGetSubroutineUniformLocation>("glGetSubroutineUniformLocation");
                        __GlueGetUniformSubroutineuiv = GLFunctionLoader.LoadGLFunction<__glGetUniformSubroutineuiv>("glGetUniformSubroutineuiv");
                        __GlueUniformSubroutinesuiv = GLFunctionLoader.LoadGLFunction<__glUniformSubroutinesuiv>("glUniformSubroutinesuiv");


                        GL_ARB_shader_subroutine = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_subroutine");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_texture_image_samples:
                    {


                        GL_ARB_shader_texture_image_samples = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_texture_image_samples");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_texture_lod:
                    {


                        GL_ARB_shader_texture_lod = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_texture_lod");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shader_viewport_layer_array:
                    {


                        GL_ARB_shader_viewport_layer_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shader_viewport_layer_array");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shading_language_100:
                    {


                        GL_ARB_shading_language_100 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shading_language_100");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shading_language_420pack:
                    {


                        GL_ARB_shading_language_420pack = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shading_language_420pack");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shading_language_include:
                    {
                        __GlueCompileShaderIncludeARB = GLFunctionLoader.LoadGLFunction<__glCompileShaderIncludeARB>("glCompileShaderIncludeARB");
                        __GlueDeleteNamedStringARB = GLFunctionLoader.LoadGLFunction<__glDeleteNamedStringARB>("glDeleteNamedStringARB");
                        __GlueGetNamedStringARB = GLFunctionLoader.LoadGLFunction<__glGetNamedStringARB>("glGetNamedStringARB");
                        __GlueGetNamedStringivARB = GLFunctionLoader.LoadGLFunction<__glGetNamedStringivARB>("glGetNamedStringivARB");
                        __GlueIsNamedStringARB = GLFunctionLoader.LoadGLFunction<__glIsNamedStringARB>("glIsNamedStringARB");
                        __GlueNamedStringARB = GLFunctionLoader.LoadGLFunction<__glNamedStringARB>("glNamedStringARB");


                        GL_ARB_shading_language_include = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shading_language_include");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shading_language_packing:
                    {


                        GL_ARB_shading_language_packing = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shading_language_packing");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shadow:
                    {


                        GL_ARB_shadow = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shadow");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_shadow_ambient:
                    {


                        GL_ARB_shadow_ambient = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_shadow_ambient");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sparse_buffer:
                    {
                        __GlueBufferPageCommitmentARB = GLFunctionLoader.LoadGLFunction<__glBufferPageCommitmentARB>("glBufferPageCommitmentARB");


                        GL_ARB_sparse_buffer = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sparse_buffer");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sparse_texture:
                    {
                        __GlueTexPageCommitmentARB = GLFunctionLoader.LoadGLFunction<__glTexPageCommitmentARB>("glTexPageCommitmentARB");


                        GL_ARB_sparse_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sparse_texture");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sparse_texture2:
                    {


                        GL_ARB_sparse_texture2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sparse_texture2");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sparse_texture_clamp:
                    {


                        GL_ARB_sparse_texture_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sparse_texture_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_spirv_extensions:
                    {


                        GL_ARB_spirv_extensions = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_spirv_extensions");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_stencil_texturing:
                    {


                        GL_ARB_stencil_texturing = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_stencil_texturing");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_sync:
                    {
                        __GlueClientWaitSync = GLFunctionLoader.LoadGLFunction<__glClientWaitSync>("glClientWaitSync");
                        __GlueDeleteSync = GLFunctionLoader.LoadGLFunction<__glDeleteSync>("glDeleteSync");
                        __GlueFenceSync = GLFunctionLoader.LoadGLFunction<__glFenceSync>("glFenceSync");
                        __GlueGetInteger64v = GLFunctionLoader.LoadGLFunction<__glGetInteger64v>("glGetInteger64v");
                        __GlueGetSynciv = GLFunctionLoader.LoadGLFunction<__glGetSynciv>("glGetSynciv");
                        __GlueIsSync = GLFunctionLoader.LoadGLFunction<__glIsSync>("glIsSync");
                        __GlueWaitSync = GLFunctionLoader.LoadGLFunction<__glWaitSync>("glWaitSync");


                        GL_ARB_sync = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_sync");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_tessellation_shader:
                    {
                        __GluePatchParameterfv = GLFunctionLoader.LoadGLFunction<__glPatchParameterfv>("glPatchParameterfv");
                        __GluePatchParameteri = GLFunctionLoader.LoadGLFunction<__glPatchParameteri>("glPatchParameteri");


                        GL_ARB_tessellation_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_tessellation_shader");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_barrier:
                    {
                        __GlueTextureBarrier = GLFunctionLoader.LoadGLFunction<__glTextureBarrier>("glTextureBarrier");


                        GL_ARB_texture_barrier = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_barrier");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_border_clamp:
                    {


                        GL_ARB_texture_border_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_border_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_buffer_object:
                    {
                        __GlueTexBufferARB = GLFunctionLoader.LoadGLFunction<__glTexBufferARB>("glTexBufferARB");


                        GL_ARB_texture_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_buffer_object_rgb32:
                    {


                        GL_ARB_texture_buffer_object_rgb32 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_buffer_object_rgb32");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_buffer_range:
                    {
                        __GlueTexBufferRange = GLFunctionLoader.LoadGLFunction<__glTexBufferRange>("glTexBufferRange");
                        __GlueTextureBufferRangeEXT = GLFunctionLoader.LoadGLFunction<__glTextureBufferRangeEXT>("glTextureBufferRangeEXT");


                        GL_ARB_texture_buffer_range = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_buffer_range");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_compression:
                    {
                        __GlueCompressedTexImage1DARB = GLFunctionLoader.LoadGLFunction<__glCompressedTexImage1DARB>("glCompressedTexImage1DARB");
                        __GlueCompressedTexImage2DARB = GLFunctionLoader.LoadGLFunction<__glCompressedTexImage2DARB>("glCompressedTexImage2DARB");
                        __GlueCompressedTexImage3DARB = GLFunctionLoader.LoadGLFunction<__glCompressedTexImage3DARB>("glCompressedTexImage3DARB");
                        __GlueCompressedTexSubImage1DARB = GLFunctionLoader.LoadGLFunction<__glCompressedTexSubImage1DARB>("glCompressedTexSubImage1DARB");
                        __GlueCompressedTexSubImage2DARB = GLFunctionLoader.LoadGLFunction<__glCompressedTexSubImage2DARB>("glCompressedTexSubImage2DARB");
                        __GlueCompressedTexSubImage3DARB = GLFunctionLoader.LoadGLFunction<__glCompressedTexSubImage3DARB>("glCompressedTexSubImage3DARB");
                        __GlueGetCompressedTexImageARB = GLFunctionLoader.LoadGLFunction<__glGetCompressedTexImageARB>("glGetCompressedTexImageARB");


                        GL_ARB_texture_compression = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_compression");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_compression_bptc:
                    {


                        GL_ARB_texture_compression_bptc = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_compression_bptc");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_compression_rgtc:
                    {


                        GL_ARB_texture_compression_rgtc = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_compression_rgtc");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_cube_map:
                    {


                        GL_ARB_texture_cube_map = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_cube_map");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_cube_map_array:
                    {


                        GL_ARB_texture_cube_map_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_cube_map_array");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_env_add:
                    {


                        GL_ARB_texture_env_add = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_env_add");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_env_combine:
                    {


                        GL_ARB_texture_env_combine = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_env_combine");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_env_crossbar:
                    {


                        GL_ARB_texture_env_crossbar = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_env_crossbar");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_env_dot3:
                    {


                        GL_ARB_texture_env_dot3 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_env_dot3");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_filter_anisotropic:
                    {


                        GL_ARB_texture_filter_anisotropic = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_filter_anisotropic");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_filter_minmax:
                    {


                        GL_ARB_texture_filter_minmax = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_filter_minmax");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_float:
                    {


                        GL_ARB_texture_float = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_float");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_gather:
                    {


                        GL_ARB_texture_gather = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_gather");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_mirror_clamp_to_edge:
                    {


                        GL_ARB_texture_mirror_clamp_to_edge = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_mirror_clamp_to_edge");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_mirrored_repeat:
                    {


                        GL_ARB_texture_mirrored_repeat = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_mirrored_repeat");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_multisample:
                    {
                        __GlueGetMultisamplefv = GLFunctionLoader.LoadGLFunction<__glGetMultisamplefv>("glGetMultisamplefv");
                        __GlueSampleMaski = GLFunctionLoader.LoadGLFunction<__glSampleMaski>("glSampleMaski");
                        __GlueTexImage2DMultisample = GLFunctionLoader.LoadGLFunction<__glTexImage2DMultisample>("glTexImage2DMultisample");
                        __GlueTexImage3DMultisample = GLFunctionLoader.LoadGLFunction<__glTexImage3DMultisample>("glTexImage3DMultisample");


                        GL_ARB_texture_multisample = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_multisample");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_non_power_of_two:
                    {


                        GL_ARB_texture_non_power_of_two = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_non_power_of_two");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_query_levels:
                    {


                        GL_ARB_texture_query_levels = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_query_levels");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_query_lod:
                    {


                        GL_ARB_texture_query_lod = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_query_lod");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_rectangle:
                    {


                        GL_ARB_texture_rectangle = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_rectangle");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_rg:
                    {


                        GL_ARB_texture_rg = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_rg");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_rgb10_a2ui:
                    {


                        GL_ARB_texture_rgb10_a2ui = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_rgb10_a2ui");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_stencil8:
                    {


                        GL_ARB_texture_stencil8 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_stencil8");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_storage:
                    {
                        __GlueTexStorage1D = GLFunctionLoader.LoadGLFunction<__glTexStorage1D>("glTexStorage1D");
                        __GlueTexStorage2D = GLFunctionLoader.LoadGLFunction<__glTexStorage2D>("glTexStorage2D");
                        __GlueTexStorage3D = GLFunctionLoader.LoadGLFunction<__glTexStorage3D>("glTexStorage3D");


                        GL_ARB_texture_storage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_storage");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_storage_multisample:
                    {
                        __GlueTexStorage2DMultisample = GLFunctionLoader.LoadGLFunction<__glTexStorage2DMultisample>("glTexStorage2DMultisample");
                        __GlueTexStorage3DMultisample = GLFunctionLoader.LoadGLFunction<__glTexStorage3DMultisample>("glTexStorage3DMultisample");
                        __GlueTextureStorage2DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorage2DMultisampleEXT>("glTextureStorage2DMultisampleEXT");
                        __GlueTextureStorage3DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorage3DMultisampleEXT>("glTextureStorage3DMultisampleEXT");


                        GL_ARB_texture_storage_multisample = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_storage_multisample");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_swizzle:
                    {


                        GL_ARB_texture_swizzle = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_swizzle");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_texture_view:
                    {
                        __GlueTextureView = GLFunctionLoader.LoadGLFunction<__glTextureView>("glTextureView");


                        GL_ARB_texture_view = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_texture_view");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_timer_query:
                    {
                        __GlueGetQueryObjecti64v = GLFunctionLoader.LoadGLFunction<__glGetQueryObjecti64v>("glGetQueryObjecti64v");
                        __GlueGetQueryObjectui64v = GLFunctionLoader.LoadGLFunction<__glGetQueryObjectui64v>("glGetQueryObjectui64v");
                        __GlueQueryCounter = GLFunctionLoader.LoadGLFunction<__glQueryCounter>("glQueryCounter");


                        GL_ARB_timer_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_timer_query");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_transform_feedback2:
                    {
                        __GlueBindTransformFeedback = GLFunctionLoader.LoadGLFunction<__glBindTransformFeedback>("glBindTransformFeedback");
                        __GlueDeleteTransformFeedbacks = GLFunctionLoader.LoadGLFunction<__glDeleteTransformFeedbacks>("glDeleteTransformFeedbacks");
                        __GlueDrawTransformFeedback = GLFunctionLoader.LoadGLFunction<__glDrawTransformFeedback>("glDrawTransformFeedback");
                        __GlueGenTransformFeedbacks = GLFunctionLoader.LoadGLFunction<__glGenTransformFeedbacks>("glGenTransformFeedbacks");
                        __GlueIsTransformFeedback = GLFunctionLoader.LoadGLFunction<__glIsTransformFeedback>("glIsTransformFeedback");
                        __GluePauseTransformFeedback = GLFunctionLoader.LoadGLFunction<__glPauseTransformFeedback>("glPauseTransformFeedback");
                        __GlueResumeTransformFeedback = GLFunctionLoader.LoadGLFunction<__glResumeTransformFeedback>("glResumeTransformFeedback");


                        GL_ARB_transform_feedback2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_transform_feedback2");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_transform_feedback3:
                    {
                        __GlueBeginQueryIndexed = GLFunctionLoader.LoadGLFunction<__glBeginQueryIndexed>("glBeginQueryIndexed");
                        __GlueDrawTransformFeedbackStream = GLFunctionLoader.LoadGLFunction<__glDrawTransformFeedbackStream>("glDrawTransformFeedbackStream");
                        __GlueEndQueryIndexed = GLFunctionLoader.LoadGLFunction<__glEndQueryIndexed>("glEndQueryIndexed");
                        __GlueGetQueryIndexediv = GLFunctionLoader.LoadGLFunction<__glGetQueryIndexediv>("glGetQueryIndexediv");


                        GL_ARB_transform_feedback3 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_transform_feedback3");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_transform_feedback_instanced:
                    {
                        __GlueDrawTransformFeedbackInstanced = GLFunctionLoader.LoadGLFunction<__glDrawTransformFeedbackInstanced>("glDrawTransformFeedbackInstanced");
                        __GlueDrawTransformFeedbackStreamInstanced = GLFunctionLoader.LoadGLFunction<__glDrawTransformFeedbackStreamInstanced>("glDrawTransformFeedbackStreamInstanced");


                        GL_ARB_transform_feedback_instanced = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_transform_feedback_instanced");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_transform_feedback_overflow_query:
                    {


                        GL_ARB_transform_feedback_overflow_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_transform_feedback_overflow_query");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_transpose_matrix:
                    {
                        __GlueLoadTransposeMatrixdARB = GLFunctionLoader.LoadGLFunction<__glLoadTransposeMatrixdARB>("glLoadTransposeMatrixdARB");
                        __GlueLoadTransposeMatrixfARB = GLFunctionLoader.LoadGLFunction<__glLoadTransposeMatrixfARB>("glLoadTransposeMatrixfARB");
                        __GlueMultTransposeMatrixdARB = GLFunctionLoader.LoadGLFunction<__glMultTransposeMatrixdARB>("glMultTransposeMatrixdARB");
                        __GlueMultTransposeMatrixfARB = GLFunctionLoader.LoadGLFunction<__glMultTransposeMatrixfARB>("glMultTransposeMatrixfARB");


                        GL_ARB_transpose_matrix = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_transpose_matrix");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_uniform_buffer_object:
                    {
                        __GlueBindBufferBase = GLFunctionLoader.LoadGLFunction<__glBindBufferBase>("glBindBufferBase");
                        __GlueBindBufferRange = GLFunctionLoader.LoadGLFunction<__glBindBufferRange>("glBindBufferRange");
                        __GlueGetActiveUniformBlockName = GLFunctionLoader.LoadGLFunction<__glGetActiveUniformBlockName>("glGetActiveUniformBlockName");
                        __GlueGetActiveUniformBlockiv = GLFunctionLoader.LoadGLFunction<__glGetActiveUniformBlockiv>("glGetActiveUniformBlockiv");
                        __GlueGetActiveUniformName = GLFunctionLoader.LoadGLFunction<__glGetActiveUniformName>("glGetActiveUniformName");
                        __GlueGetActiveUniformsiv = GLFunctionLoader.LoadGLFunction<__glGetActiveUniformsiv>("glGetActiveUniformsiv");
                        __GlueGetIntegeri_v = GLFunctionLoader.LoadGLFunction<__glGetIntegeri_v>("glGetIntegeri_v");
                        __GlueGetUniformBlockIndex = GLFunctionLoader.LoadGLFunction<__glGetUniformBlockIndex>("glGetUniformBlockIndex");
                        __GlueGetUniformIndices = GLFunctionLoader.LoadGLFunction<__glGetUniformIndices>("glGetUniformIndices");
                        __GlueUniformBlockBinding = GLFunctionLoader.LoadGLFunction<__glUniformBlockBinding>("glUniformBlockBinding");


                        GL_ARB_uniform_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_uniform_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_array_bgra:
                    {


                        GL_ARB_vertex_array_bgra = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_array_bgra");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_array_object:
                    {
                        __GlueBindVertexArray = GLFunctionLoader.LoadGLFunction<__glBindVertexArray>("glBindVertexArray");
                        __GlueDeleteVertexArrays = GLFunctionLoader.LoadGLFunction<__glDeleteVertexArrays>("glDeleteVertexArrays");
                        __GlueGenVertexArrays = GLFunctionLoader.LoadGLFunction<__glGenVertexArrays>("glGenVertexArrays");
                        __GlueIsVertexArray = GLFunctionLoader.LoadGLFunction<__glIsVertexArray>("glIsVertexArray");


                        GL_ARB_vertex_array_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_array_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_attrib_64bit:
                    {
                        __GlueGetVertexAttribLdv = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribLdv>("glGetVertexAttribLdv");
                        __GlueVertexAttribL1d = GLFunctionLoader.LoadGLFunction<__glVertexAttribL1d>("glVertexAttribL1d");
                        __GlueVertexAttribL1dv = GLFunctionLoader.LoadGLFunction<__glVertexAttribL1dv>("glVertexAttribL1dv");
                        __GlueVertexAttribL2d = GLFunctionLoader.LoadGLFunction<__glVertexAttribL2d>("glVertexAttribL2d");
                        __GlueVertexAttribL2dv = GLFunctionLoader.LoadGLFunction<__glVertexAttribL2dv>("glVertexAttribL2dv");
                        __GlueVertexAttribL3d = GLFunctionLoader.LoadGLFunction<__glVertexAttribL3d>("glVertexAttribL3d");
                        __GlueVertexAttribL3dv = GLFunctionLoader.LoadGLFunction<__glVertexAttribL3dv>("glVertexAttribL3dv");
                        __GlueVertexAttribL4d = GLFunctionLoader.LoadGLFunction<__glVertexAttribL4d>("glVertexAttribL4d");
                        __GlueVertexAttribL4dv = GLFunctionLoader.LoadGLFunction<__glVertexAttribL4dv>("glVertexAttribL4dv");
                        __GlueVertexAttribLPointer = GLFunctionLoader.LoadGLFunction<__glVertexAttribLPointer>("glVertexAttribLPointer");


                        GL_ARB_vertex_attrib_64bit = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_attrib_64bit");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_attrib_binding:
                    {
                        __GlueBindVertexBuffer = GLFunctionLoader.LoadGLFunction<__glBindVertexBuffer>("glBindVertexBuffer");
                        __GlueVertexArrayBindVertexBufferEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayBindVertexBufferEXT>("glVertexArrayBindVertexBufferEXT");
                        __GlueVertexArrayVertexAttribBindingEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribBindingEXT>("glVertexArrayVertexAttribBindingEXT");
                        __GlueVertexArrayVertexAttribFormatEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribFormatEXT>("glVertexArrayVertexAttribFormatEXT");
                        __GlueVertexArrayVertexAttribIFormatEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribIFormatEXT>("glVertexArrayVertexAttribIFormatEXT");
                        __GlueVertexArrayVertexAttribLFormatEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribLFormatEXT>("glVertexArrayVertexAttribLFormatEXT");
                        __GlueVertexArrayVertexBindingDivisorEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexBindingDivisorEXT>("glVertexArrayVertexBindingDivisorEXT");
                        __GlueVertexAttribBinding = GLFunctionLoader.LoadGLFunction<__glVertexAttribBinding>("glVertexAttribBinding");
                        __GlueVertexAttribFormat = GLFunctionLoader.LoadGLFunction<__glVertexAttribFormat>("glVertexAttribFormat");
                        __GlueVertexAttribIFormat = GLFunctionLoader.LoadGLFunction<__glVertexAttribIFormat>("glVertexAttribIFormat");
                        __GlueVertexAttribLFormat = GLFunctionLoader.LoadGLFunction<__glVertexAttribLFormat>("glVertexAttribLFormat");
                        __GlueVertexBindingDivisor = GLFunctionLoader.LoadGLFunction<__glVertexBindingDivisor>("glVertexBindingDivisor");


                        GL_ARB_vertex_attrib_binding = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_attrib_binding");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_blend:
                    {
                        __GlueVertexBlendARB = GLFunctionLoader.LoadGLFunction<__glVertexBlendARB>("glVertexBlendARB");
                        __GlueWeightPointerARB = GLFunctionLoader.LoadGLFunction<__glWeightPointerARB>("glWeightPointerARB");
                        __GlueWeightbvARB = GLFunctionLoader.LoadGLFunction<__glWeightbvARB>("glWeightbvARB");
                        __GlueWeightdvARB = GLFunctionLoader.LoadGLFunction<__glWeightdvARB>("glWeightdvARB");
                        __GlueWeightfvARB = GLFunctionLoader.LoadGLFunction<__glWeightfvARB>("glWeightfvARB");
                        __GlueWeightivARB = GLFunctionLoader.LoadGLFunction<__glWeightivARB>("glWeightivARB");
                        __GlueWeightsvARB = GLFunctionLoader.LoadGLFunction<__glWeightsvARB>("glWeightsvARB");
                        __GlueWeightubvARB = GLFunctionLoader.LoadGLFunction<__glWeightubvARB>("glWeightubvARB");
                        __GlueWeightuivARB = GLFunctionLoader.LoadGLFunction<__glWeightuivARB>("glWeightuivARB");
                        __GlueWeightusvARB = GLFunctionLoader.LoadGLFunction<__glWeightusvARB>("glWeightusvARB");


                        GL_ARB_vertex_blend = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_blend");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_buffer_object:
                    {
                        __GlueBindBufferARB = GLFunctionLoader.LoadGLFunction<__glBindBufferARB>("glBindBufferARB");
                        __GlueBufferDataARB = GLFunctionLoader.LoadGLFunction<__glBufferDataARB>("glBufferDataARB");
                        __GlueBufferSubDataARB = GLFunctionLoader.LoadGLFunction<__glBufferSubDataARB>("glBufferSubDataARB");
                        __GlueDeleteBuffersARB = GLFunctionLoader.LoadGLFunction<__glDeleteBuffersARB>("glDeleteBuffersARB");
                        __GlueGenBuffersARB = GLFunctionLoader.LoadGLFunction<__glGenBuffersARB>("glGenBuffersARB");
                        __GlueGetBufferParameterivARB = GLFunctionLoader.LoadGLFunction<__glGetBufferParameterivARB>("glGetBufferParameterivARB");
                        __GlueGetBufferPointervARB = GLFunctionLoader.LoadGLFunction<__glGetBufferPointervARB>("glGetBufferPointervARB");
                        __GlueGetBufferSubDataARB = GLFunctionLoader.LoadGLFunction<__glGetBufferSubDataARB>("glGetBufferSubDataARB");
                        __GlueIsBufferARB = GLFunctionLoader.LoadGLFunction<__glIsBufferARB>("glIsBufferARB");
                        __GlueMapBufferARB = GLFunctionLoader.LoadGLFunction<__glMapBufferARB>("glMapBufferARB");
                        __GlueUnmapBufferARB = GLFunctionLoader.LoadGLFunction<__glUnmapBufferARB>("glUnmapBufferARB");


                        GL_ARB_vertex_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_program:
                    {
                        __GlueBindProgramARB = GLFunctionLoader.LoadGLFunction<__glBindProgramARB>("glBindProgramARB");
                        __GlueDeleteProgramsARB = GLFunctionLoader.LoadGLFunction<__glDeleteProgramsARB>("glDeleteProgramsARB");
                        __GlueDisableVertexAttribArrayARB = GLFunctionLoader.LoadGLFunction<__glDisableVertexAttribArrayARB>("glDisableVertexAttribArrayARB");
                        __GlueEnableVertexAttribArrayARB = GLFunctionLoader.LoadGLFunction<__glEnableVertexAttribArrayARB>("glEnableVertexAttribArrayARB");
                        __GlueGenProgramsARB = GLFunctionLoader.LoadGLFunction<__glGenProgramsARB>("glGenProgramsARB");
                        __GlueGetProgramEnvParameterdvARB = GLFunctionLoader.LoadGLFunction<__glGetProgramEnvParameterdvARB>("glGetProgramEnvParameterdvARB");
                        __GlueGetProgramEnvParameterfvARB = GLFunctionLoader.LoadGLFunction<__glGetProgramEnvParameterfvARB>("glGetProgramEnvParameterfvARB");
                        __GlueGetProgramLocalParameterdvARB = GLFunctionLoader.LoadGLFunction<__glGetProgramLocalParameterdvARB>("glGetProgramLocalParameterdvARB");
                        __GlueGetProgramLocalParameterfvARB = GLFunctionLoader.LoadGLFunction<__glGetProgramLocalParameterfvARB>("glGetProgramLocalParameterfvARB");
                        __GlueGetProgramStringARB = GLFunctionLoader.LoadGLFunction<__glGetProgramStringARB>("glGetProgramStringARB");
                        __GlueGetProgramivARB = GLFunctionLoader.LoadGLFunction<__glGetProgramivARB>("glGetProgramivARB");
                        __GlueGetVertexAttribPointervARB = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribPointervARB>("glGetVertexAttribPointervARB");
                        __GlueGetVertexAttribdvARB = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribdvARB>("glGetVertexAttribdvARB");
                        __GlueGetVertexAttribfvARB = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribfvARB>("glGetVertexAttribfvARB");
                        __GlueGetVertexAttribivARB = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribivARB>("glGetVertexAttribivARB");
                        __GlueIsProgramARB = GLFunctionLoader.LoadGLFunction<__glIsProgramARB>("glIsProgramARB");
                        __GlueProgramEnvParameter4dARB = GLFunctionLoader.LoadGLFunction<__glProgramEnvParameter4dARB>("glProgramEnvParameter4dARB");
                        __GlueProgramEnvParameter4dvARB = GLFunctionLoader.LoadGLFunction<__glProgramEnvParameter4dvARB>("glProgramEnvParameter4dvARB");
                        __GlueProgramEnvParameter4fARB = GLFunctionLoader.LoadGLFunction<__glProgramEnvParameter4fARB>("glProgramEnvParameter4fARB");
                        __GlueProgramEnvParameter4fvARB = GLFunctionLoader.LoadGLFunction<__glProgramEnvParameter4fvARB>("glProgramEnvParameter4fvARB");
                        __GlueProgramLocalParameter4dARB = GLFunctionLoader.LoadGLFunction<__glProgramLocalParameter4dARB>("glProgramLocalParameter4dARB");
                        __GlueProgramLocalParameter4dvARB = GLFunctionLoader.LoadGLFunction<__glProgramLocalParameter4dvARB>("glProgramLocalParameter4dvARB");
                        __GlueProgramLocalParameter4fARB = GLFunctionLoader.LoadGLFunction<__glProgramLocalParameter4fARB>("glProgramLocalParameter4fARB");
                        __GlueProgramLocalParameter4fvARB = GLFunctionLoader.LoadGLFunction<__glProgramLocalParameter4fvARB>("glProgramLocalParameter4fvARB");
                        __GlueProgramStringARB = GLFunctionLoader.LoadGLFunction<__glProgramStringARB>("glProgramStringARB");
                        __GlueVertexAttrib1dARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1dARB>("glVertexAttrib1dARB");
                        __GlueVertexAttrib1dvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1dvARB>("glVertexAttrib1dvARB");
                        __GlueVertexAttrib1fARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1fARB>("glVertexAttrib1fARB");
                        __GlueVertexAttrib1fvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1fvARB>("glVertexAttrib1fvARB");
                        __GlueVertexAttrib1sARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1sARB>("glVertexAttrib1sARB");
                        __GlueVertexAttrib1svARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib1svARB>("glVertexAttrib1svARB");
                        __GlueVertexAttrib2dARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2dARB>("glVertexAttrib2dARB");
                        __GlueVertexAttrib2dvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2dvARB>("glVertexAttrib2dvARB");
                        __GlueVertexAttrib2fARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2fARB>("glVertexAttrib2fARB");
                        __GlueVertexAttrib2fvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2fvARB>("glVertexAttrib2fvARB");
                        __GlueVertexAttrib2sARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2sARB>("glVertexAttrib2sARB");
                        __GlueVertexAttrib2svARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib2svARB>("glVertexAttrib2svARB");
                        __GlueVertexAttrib3dARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3dARB>("glVertexAttrib3dARB");
                        __GlueVertexAttrib3dvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3dvARB>("glVertexAttrib3dvARB");
                        __GlueVertexAttrib3fARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3fARB>("glVertexAttrib3fARB");
                        __GlueVertexAttrib3fvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3fvARB>("glVertexAttrib3fvARB");
                        __GlueVertexAttrib3sARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3sARB>("glVertexAttrib3sARB");
                        __GlueVertexAttrib3svARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib3svARB>("glVertexAttrib3svARB");
                        __GlueVertexAttrib4NbvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NbvARB>("glVertexAttrib4NbvARB");
                        __GlueVertexAttrib4NivARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NivARB>("glVertexAttrib4NivARB");
                        __GlueVertexAttrib4NsvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NsvARB>("glVertexAttrib4NsvARB");
                        __GlueVertexAttrib4NubARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NubARB>("glVertexAttrib4NubARB");
                        __GlueVertexAttrib4NubvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NubvARB>("glVertexAttrib4NubvARB");
                        __GlueVertexAttrib4NuivARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NuivARB>("glVertexAttrib4NuivARB");
                        __GlueVertexAttrib4NusvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4NusvARB>("glVertexAttrib4NusvARB");
                        __GlueVertexAttrib4bvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4bvARB>("glVertexAttrib4bvARB");
                        __GlueVertexAttrib4dARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4dARB>("glVertexAttrib4dARB");
                        __GlueVertexAttrib4dvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4dvARB>("glVertexAttrib4dvARB");
                        __GlueVertexAttrib4fARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4fARB>("glVertexAttrib4fARB");
                        __GlueVertexAttrib4fvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4fvARB>("glVertexAttrib4fvARB");
                        __GlueVertexAttrib4ivARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4ivARB>("glVertexAttrib4ivARB");
                        __GlueVertexAttrib4sARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4sARB>("glVertexAttrib4sARB");
                        __GlueVertexAttrib4svARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4svARB>("glVertexAttrib4svARB");
                        __GlueVertexAttrib4ubvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4ubvARB>("glVertexAttrib4ubvARB");
                        __GlueVertexAttrib4uivARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4uivARB>("glVertexAttrib4uivARB");
                        __GlueVertexAttrib4usvARB = GLFunctionLoader.LoadGLFunction<__glVertexAttrib4usvARB>("glVertexAttrib4usvARB");
                        __GlueVertexAttribPointerARB = GLFunctionLoader.LoadGLFunction<__glVertexAttribPointerARB>("glVertexAttribPointerARB");


                        GL_ARB_vertex_program = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_program");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_shader:
                    {
                        __GlueBindAttribLocationARB = GLFunctionLoader.LoadGLFunction<__glBindAttribLocationARB>("glBindAttribLocationARB");
                        __GlueGetActiveAttribARB = GLFunctionLoader.LoadGLFunction<__glGetActiveAttribARB>("glGetActiveAttribARB");
                        __GlueGetAttribLocationARB = GLFunctionLoader.LoadGLFunction<__glGetAttribLocationARB>("glGetAttribLocationARB");


                        GL_ARB_vertex_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_shader");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_type_10f_11f_11f_rev:
                    {


                        GL_ARB_vertex_type_10f_11f_11f_rev = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_type_10f_11f_11f_rev");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_vertex_type_2_10_10_10_rev:
                    {
                        __GlueColorP3ui = GLFunctionLoader.LoadGLFunction<__glColorP3ui>("glColorP3ui");
                        __GlueColorP3uiv = GLFunctionLoader.LoadGLFunction<__glColorP3uiv>("glColorP3uiv");
                        __GlueColorP4ui = GLFunctionLoader.LoadGLFunction<__glColorP4ui>("glColorP4ui");
                        __GlueColorP4uiv = GLFunctionLoader.LoadGLFunction<__glColorP4uiv>("glColorP4uiv");
                        __GlueMultiTexCoordP1ui = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP1ui>("glMultiTexCoordP1ui");
                        __GlueMultiTexCoordP1uiv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP1uiv>("glMultiTexCoordP1uiv");
                        __GlueMultiTexCoordP2ui = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP2ui>("glMultiTexCoordP2ui");
                        __GlueMultiTexCoordP2uiv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP2uiv>("glMultiTexCoordP2uiv");
                        __GlueMultiTexCoordP3ui = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP3ui>("glMultiTexCoordP3ui");
                        __GlueMultiTexCoordP3uiv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP3uiv>("glMultiTexCoordP3uiv");
                        __GlueMultiTexCoordP4ui = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP4ui>("glMultiTexCoordP4ui");
                        __GlueMultiTexCoordP4uiv = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordP4uiv>("glMultiTexCoordP4uiv");
                        __GlueNormalP3ui = GLFunctionLoader.LoadGLFunction<__glNormalP3ui>("glNormalP3ui");
                        __GlueNormalP3uiv = GLFunctionLoader.LoadGLFunction<__glNormalP3uiv>("glNormalP3uiv");
                        __GlueSecondaryColorP3ui = GLFunctionLoader.LoadGLFunction<__glSecondaryColorP3ui>("glSecondaryColorP3ui");
                        __GlueSecondaryColorP3uiv = GLFunctionLoader.LoadGLFunction<__glSecondaryColorP3uiv>("glSecondaryColorP3uiv");
                        __GlueTexCoordP1ui = GLFunctionLoader.LoadGLFunction<__glTexCoordP1ui>("glTexCoordP1ui");
                        __GlueTexCoordP1uiv = GLFunctionLoader.LoadGLFunction<__glTexCoordP1uiv>("glTexCoordP1uiv");
                        __GlueTexCoordP2ui = GLFunctionLoader.LoadGLFunction<__glTexCoordP2ui>("glTexCoordP2ui");
                        __GlueTexCoordP2uiv = GLFunctionLoader.LoadGLFunction<__glTexCoordP2uiv>("glTexCoordP2uiv");
                        __GlueTexCoordP3ui = GLFunctionLoader.LoadGLFunction<__glTexCoordP3ui>("glTexCoordP3ui");
                        __GlueTexCoordP3uiv = GLFunctionLoader.LoadGLFunction<__glTexCoordP3uiv>("glTexCoordP3uiv");
                        __GlueTexCoordP4ui = GLFunctionLoader.LoadGLFunction<__glTexCoordP4ui>("glTexCoordP4ui");
                        __GlueTexCoordP4uiv = GLFunctionLoader.LoadGLFunction<__glTexCoordP4uiv>("glTexCoordP4uiv");
                        __GlueVertexAttribP1ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribP1ui>("glVertexAttribP1ui");
                        __GlueVertexAttribP1uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribP1uiv>("glVertexAttribP1uiv");
                        __GlueVertexAttribP2ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribP2ui>("glVertexAttribP2ui");
                        __GlueVertexAttribP2uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribP2uiv>("glVertexAttribP2uiv");
                        __GlueVertexAttribP3ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribP3ui>("glVertexAttribP3ui");
                        __GlueVertexAttribP3uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribP3uiv>("glVertexAttribP3uiv");
                        __GlueVertexAttribP4ui = GLFunctionLoader.LoadGLFunction<__glVertexAttribP4ui>("glVertexAttribP4ui");
                        __GlueVertexAttribP4uiv = GLFunctionLoader.LoadGLFunction<__glVertexAttribP4uiv>("glVertexAttribP4uiv");
                        __GlueVertexP2ui = GLFunctionLoader.LoadGLFunction<__glVertexP2ui>("glVertexP2ui");
                        __GlueVertexP2uiv = GLFunctionLoader.LoadGLFunction<__glVertexP2uiv>("glVertexP2uiv");
                        __GlueVertexP3ui = GLFunctionLoader.LoadGLFunction<__glVertexP3ui>("glVertexP3ui");
                        __GlueVertexP3uiv = GLFunctionLoader.LoadGLFunction<__glVertexP3uiv>("glVertexP3uiv");
                        __GlueVertexP4ui = GLFunctionLoader.LoadGLFunction<__glVertexP4ui>("glVertexP4ui");
                        __GlueVertexP4uiv = GLFunctionLoader.LoadGLFunction<__glVertexP4uiv>("glVertexP4uiv");


                        GL_ARB_vertex_type_2_10_10_10_rev = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_vertex_type_2_10_10_10_rev");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_viewport_array:
                    {
                        __GlueDepthRangeArrayv = GLFunctionLoader.LoadGLFunction<__glDepthRangeArrayv>("glDepthRangeArrayv");
                        __GlueDepthRangeIndexed = GLFunctionLoader.LoadGLFunction<__glDepthRangeIndexed>("glDepthRangeIndexed");
                        __GlueGetDoublei_v = GLFunctionLoader.LoadGLFunction<__glGetDoublei_v>("glGetDoublei_v");
                        __GlueGetFloati_v = GLFunctionLoader.LoadGLFunction<__glGetFloati_v>("glGetFloati_v");
                        __GlueScissorArrayv = GLFunctionLoader.LoadGLFunction<__glScissorArrayv>("glScissorArrayv");
                        __GlueScissorIndexed = GLFunctionLoader.LoadGLFunction<__glScissorIndexed>("glScissorIndexed");
                        __GlueScissorIndexedv = GLFunctionLoader.LoadGLFunction<__glScissorIndexedv>("glScissorIndexedv");
                        __GlueViewportArrayv = GLFunctionLoader.LoadGLFunction<__glViewportArrayv>("glViewportArrayv");
                        __GlueViewportIndexedf = GLFunctionLoader.LoadGLFunction<__glViewportIndexedf>("glViewportIndexedf");
                        __GlueViewportIndexedfv = GLFunctionLoader.LoadGLFunction<__glViewportIndexedfv>("glViewportIndexedfv");


                        GL_ARB_viewport_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_viewport_array");
#endif
                        break;
                    }
                case glInitHint.GL_ARB_window_pos:
                    {
                        __GlueWindowPos2dARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2dARB>("glWindowPos2dARB");
                        __GlueWindowPos2dvARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2dvARB>("glWindowPos2dvARB");
                        __GlueWindowPos2fARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2fARB>("glWindowPos2fARB");
                        __GlueWindowPos2fvARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2fvARB>("glWindowPos2fvARB");
                        __GlueWindowPos2iARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2iARB>("glWindowPos2iARB");
                        __GlueWindowPos2ivARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2ivARB>("glWindowPos2ivARB");
                        __GlueWindowPos2sARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2sARB>("glWindowPos2sARB");
                        __GlueWindowPos2svARB = GLFunctionLoader.LoadGLFunction<__glWindowPos2svARB>("glWindowPos2svARB");
                        __GlueWindowPos3dARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3dARB>("glWindowPos3dARB");
                        __GlueWindowPos3dvARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3dvARB>("glWindowPos3dvARB");
                        __GlueWindowPos3fARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3fARB>("glWindowPos3fARB");
                        __GlueWindowPos3fvARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3fvARB>("glWindowPos3fvARB");
                        __GlueWindowPos3iARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3iARB>("glWindowPos3iARB");
                        __GlueWindowPos3ivARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3ivARB>("glWindowPos3ivARB");
                        __GlueWindowPos3sARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3sARB>("glWindowPos3sARB");
                        __GlueWindowPos3svARB = GLFunctionLoader.LoadGLFunction<__glWindowPos3svARB>("glWindowPos3svARB");


                        GL_ARB_window_pos = true;

#if DEBUG
	Console.WriteLine("Initialized GL_ARB_window_pos");
#endif
                        break;
                    }
            }

        }

    }
}

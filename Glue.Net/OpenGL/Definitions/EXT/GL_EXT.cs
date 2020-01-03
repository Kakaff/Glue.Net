using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL
{

    public static partial class GL_EXT
    {

        internal static void Init(glInitHint initHint)
        {
            switch (initHint)
            {
                case glInitHint.GL_EXT_422_pixels:
                    {


                        GL_EXT_422_pixels = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_422_pixels");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_Cg_shader:
                    {


                        GL_EXT_Cg_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_Cg_shader");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_EGL_image_array:
                    {


                        GL_EXT_EGL_image_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_EGL_image_array");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_YUV_target:
                    {


                        GL_EXT_YUV_target = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_YUV_target");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_abgr:
                    {


                        GL_EXT_abgr = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_abgr");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_base_instance:
                    {
                        __GlueDrawArraysInstancedBaseInstanceEXT = GLFunctionLoader.LoadGLFunction<__glDrawArraysInstancedBaseInstanceEXT>("glDrawArraysInstancedBaseInstanceEXT");
                        __GlueDrawElementsInstancedBaseInstanceEXT = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedBaseInstanceEXT>("glDrawElementsInstancedBaseInstanceEXT");
                        __GlueDrawElementsInstancedBaseVertexBaseInstanceEXT = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedBaseVertexBaseInstanceEXT>("glDrawElementsInstancedBaseVertexBaseInstanceEXT");


                        GL_EXT_base_instance = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_base_instance");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_bgra:
                    {


                        GL_EXT_bgra = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_bgra");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_bindable_uniform:
                    {
                        __GlueGetUniformBufferSizeEXT = GLFunctionLoader.LoadGLFunction<__glGetUniformBufferSizeEXT>("glGetUniformBufferSizeEXT");
                        __GlueGetUniformOffsetEXT = GLFunctionLoader.LoadGLFunction<__glGetUniformOffsetEXT>("glGetUniformOffsetEXT");
                        __GlueUniformBufferEXT = GLFunctionLoader.LoadGLFunction<__glUniformBufferEXT>("glUniformBufferEXT");


                        GL_EXT_bindable_uniform = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_bindable_uniform");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_color:
                    {
                        __GlueBlendColorEXT = GLFunctionLoader.LoadGLFunction<__glBlendColorEXT>("glBlendColorEXT");


                        GL_EXT_blend_color = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_color");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_equation_separate:
                    {
                        __GlueBlendEquationSeparateEXT = GLFunctionLoader.LoadGLFunction<__glBlendEquationSeparateEXT>("glBlendEquationSeparateEXT");


                        GL_EXT_blend_equation_separate = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_equation_separate");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_func_extended:
                    {
                        __GlueBindFragDataLocationIndexedEXT = GLFunctionLoader.LoadGLFunction<__glBindFragDataLocationIndexedEXT>("glBindFragDataLocationIndexedEXT");
                        __GlueGetFragDataIndexEXT = GLFunctionLoader.LoadGLFunction<__glGetFragDataIndexEXT>("glGetFragDataIndexEXT");
                        __GlueGetProgramResourceLocationIndexEXT = GLFunctionLoader.LoadGLFunction<__glGetProgramResourceLocationIndexEXT>("glGetProgramResourceLocationIndexEXT");


                        GL_EXT_blend_func_extended = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_func_extended");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_func_separate:
                    {
                        __GlueBlendFuncSeparateEXT = GLFunctionLoader.LoadGLFunction<__glBlendFuncSeparateEXT>("glBlendFuncSeparateEXT");


                        GL_EXT_blend_func_separate = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_func_separate");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_logic_op:
                    {


                        GL_EXT_blend_logic_op = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_logic_op");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_minmax:
                    {
                        __GlueBlendEquationEXT = GLFunctionLoader.LoadGLFunction<__glBlendEquationEXT>("glBlendEquationEXT");


                        GL_EXT_blend_minmax = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_minmax");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_blend_subtract:
                    {


                        GL_EXT_blend_subtract = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_blend_subtract");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_buffer_storage:
                    {
                        __GlueBufferStorageEXT = GLFunctionLoader.LoadGLFunction<__glBufferStorageEXT>("glBufferStorageEXT");
                        __GlueNamedBufferStorageEXT = GLFunctionLoader.LoadGLFunction<__glNamedBufferStorageEXT>("glNamedBufferStorageEXT");


                        GL_EXT_buffer_storage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_buffer_storage");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_clear_texture:
                    {
                        __GlueClearTexImageEXT = GLFunctionLoader.LoadGLFunction<__glClearTexImageEXT>("glClearTexImageEXT");
                        __GlueClearTexSubImageEXT = GLFunctionLoader.LoadGLFunction<__glClearTexSubImageEXT>("glClearTexSubImageEXT");


                        GL_EXT_clear_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_clear_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_clip_cull_distance:
                    {


                        GL_EXT_clip_cull_distance = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_clip_cull_distance");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_clip_volume_hint:
                    {


                        GL_EXT_clip_volume_hint = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_clip_volume_hint");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_cmyka:
                    {


                        GL_EXT_cmyka = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_cmyka");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_color_buffer_float:
                    {


                        GL_EXT_color_buffer_float = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_color_buffer_float");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_color_buffer_half_float:
                    {


                        GL_EXT_color_buffer_half_float = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_color_buffer_half_float");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_color_subtable:
                    {
                        __GlueColorSubTableEXT = GLFunctionLoader.LoadGLFunction<__glColorSubTableEXT>("glColorSubTableEXT");
                        __GlueCopyColorSubTableEXT = GLFunctionLoader.LoadGLFunction<__glCopyColorSubTableEXT>("glCopyColorSubTableEXT");


                        GL_EXT_color_subtable = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_color_subtable");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_compiled_vertex_array:
                    {
                        __GlueLockArraysEXT = GLFunctionLoader.LoadGLFunction<__glLockArraysEXT>("glLockArraysEXT");
                        __GlueUnlockArraysEXT = GLFunctionLoader.LoadGLFunction<__glUnlockArraysEXT>("glUnlockArraysEXT");


                        GL_EXT_compiled_vertex_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_compiled_vertex_array");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_compressed_ETC1_RGB8_sub_texture:
                    {


                        GL_EXT_compressed_ETC1_RGB8_sub_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_compressed_ETC1_RGB8_sub_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_conservative_depth:
                    {


                        GL_EXT_conservative_depth = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_conservative_depth");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_convolution:
                    {
                        __GlueConvolutionFilter1DEXT = GLFunctionLoader.LoadGLFunction<__glConvolutionFilter1DEXT>("glConvolutionFilter1DEXT");
                        __GlueConvolutionFilter2DEXT = GLFunctionLoader.LoadGLFunction<__glConvolutionFilter2DEXT>("glConvolutionFilter2DEXT");
                        __GlueConvolutionParameterfEXT = GLFunctionLoader.LoadGLFunction<__glConvolutionParameterfEXT>("glConvolutionParameterfEXT");
                        __GlueConvolutionParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glConvolutionParameterfvEXT>("glConvolutionParameterfvEXT");
                        __GlueConvolutionParameteriEXT = GLFunctionLoader.LoadGLFunction<__glConvolutionParameteriEXT>("glConvolutionParameteriEXT");
                        __GlueConvolutionParameterivEXT = GLFunctionLoader.LoadGLFunction<__glConvolutionParameterivEXT>("glConvolutionParameterivEXT");
                        __GlueCopyConvolutionFilter1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyConvolutionFilter1DEXT>("glCopyConvolutionFilter1DEXT");
                        __GlueCopyConvolutionFilter2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyConvolutionFilter2DEXT>("glCopyConvolutionFilter2DEXT");
                        __GlueGetConvolutionFilterEXT = GLFunctionLoader.LoadGLFunction<__glGetConvolutionFilterEXT>("glGetConvolutionFilterEXT");
                        __GlueGetConvolutionParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetConvolutionParameterfvEXT>("glGetConvolutionParameterfvEXT");
                        __GlueGetConvolutionParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetConvolutionParameterivEXT>("glGetConvolutionParameterivEXT");
                        __GlueGetSeparableFilterEXT = GLFunctionLoader.LoadGLFunction<__glGetSeparableFilterEXT>("glGetSeparableFilterEXT");
                        __GlueSeparableFilter2DEXT = GLFunctionLoader.LoadGLFunction<__glSeparableFilter2DEXT>("glSeparableFilter2DEXT");


                        GL_EXT_convolution = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_convolution");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_coordinate_frame:
                    {
                        __GlueBinormalPointerEXT = GLFunctionLoader.LoadGLFunction<__glBinormalPointerEXT>("glBinormalPointerEXT");
                        __GlueTangentPointerEXT = GLFunctionLoader.LoadGLFunction<__glTangentPointerEXT>("glTangentPointerEXT");


                        GL_EXT_coordinate_frame = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_coordinate_frame");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_copy_image:
                    {
                        __GlueCopyImageSubDataEXT = GLFunctionLoader.LoadGLFunction<__glCopyImageSubDataEXT>("glCopyImageSubDataEXT");


                        GL_EXT_copy_image = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_copy_image");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_copy_texture:
                    {
                        __GlueCopyTexImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTexImage1DEXT>("glCopyTexImage1DEXT");
                        __GlueCopyTexImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTexImage2DEXT>("glCopyTexImage2DEXT");
                        __GlueCopyTexSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTexSubImage1DEXT>("glCopyTexSubImage1DEXT");
                        __GlueCopyTexSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTexSubImage2DEXT>("glCopyTexSubImage2DEXT");
                        __GlueCopyTexSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTexSubImage3DEXT>("glCopyTexSubImage3DEXT");


                        GL_EXT_copy_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_copy_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_cull_vertex:
                    {
                        __GlueCullParameterdvEXT = GLFunctionLoader.LoadGLFunction<__glCullParameterdvEXT>("glCullParameterdvEXT");
                        __GlueCullParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glCullParameterfvEXT>("glCullParameterfvEXT");


                        GL_EXT_cull_vertex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_cull_vertex");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_debug_label:
                    {
                        __GlueGetObjectLabelEXT = GLFunctionLoader.LoadGLFunction<__glGetObjectLabelEXT>("glGetObjectLabelEXT");
                        __GlueLabelObjectEXT = GLFunctionLoader.LoadGLFunction<__glLabelObjectEXT>("glLabelObjectEXT");


                        GL_EXT_debug_label = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_debug_label");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_debug_marker:
                    {
                        __GlueInsertEventMarkerEXT = GLFunctionLoader.LoadGLFunction<__glInsertEventMarkerEXT>("glInsertEventMarkerEXT");
                        __GluePopGroupMarkerEXT = GLFunctionLoader.LoadGLFunction<__glPopGroupMarkerEXT>("glPopGroupMarkerEXT");
                        __GluePushGroupMarkerEXT = GLFunctionLoader.LoadGLFunction<__glPushGroupMarkerEXT>("glPushGroupMarkerEXT");


                        GL_EXT_debug_marker = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_debug_marker");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_depth_bounds_test:
                    {
                        __GlueDepthBoundsEXT = GLFunctionLoader.LoadGLFunction<__glDepthBoundsEXT>("glDepthBoundsEXT");


                        GL_EXT_depth_bounds_test = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_depth_bounds_test");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_direct_state_access:
                    {
                        __GlueBindMultiTextureEXT = GLFunctionLoader.LoadGLFunction<__glBindMultiTextureEXT>("glBindMultiTextureEXT");
                        __GlueCheckNamedFramebufferStatusEXT = GLFunctionLoader.LoadGLFunction<__glCheckNamedFramebufferStatusEXT>("glCheckNamedFramebufferStatusEXT");
                        __GlueClientAttribDefaultEXT = GLFunctionLoader.LoadGLFunction<__glClientAttribDefaultEXT>("glClientAttribDefaultEXT");
                        __GlueCompressedMultiTexImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedMultiTexImage1DEXT>("glCompressedMultiTexImage1DEXT");
                        __GlueCompressedMultiTexImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedMultiTexImage2DEXT>("glCompressedMultiTexImage2DEXT");
                        __GlueCompressedMultiTexImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedMultiTexImage3DEXT>("glCompressedMultiTexImage3DEXT");
                        __GlueCompressedMultiTexSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedMultiTexSubImage1DEXT>("glCompressedMultiTexSubImage1DEXT");
                        __GlueCompressedMultiTexSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedMultiTexSubImage2DEXT>("glCompressedMultiTexSubImage2DEXT");
                        __GlueCompressedMultiTexSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedMultiTexSubImage3DEXT>("glCompressedMultiTexSubImage3DEXT");
                        __GlueCompressedTextureImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedTextureImage1DEXT>("glCompressedTextureImage1DEXT");
                        __GlueCompressedTextureImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedTextureImage2DEXT>("glCompressedTextureImage2DEXT");
                        __GlueCompressedTextureImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedTextureImage3DEXT>("glCompressedTextureImage3DEXT");
                        __GlueCompressedTextureSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedTextureSubImage1DEXT>("glCompressedTextureSubImage1DEXT");
                        __GlueCompressedTextureSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedTextureSubImage2DEXT>("glCompressedTextureSubImage2DEXT");
                        __GlueCompressedTextureSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCompressedTextureSubImage3DEXT>("glCompressedTextureSubImage3DEXT");
                        __GlueCopyMultiTexImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyMultiTexImage1DEXT>("glCopyMultiTexImage1DEXT");
                        __GlueCopyMultiTexImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyMultiTexImage2DEXT>("glCopyMultiTexImage2DEXT");
                        __GlueCopyMultiTexSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyMultiTexSubImage1DEXT>("glCopyMultiTexSubImage1DEXT");
                        __GlueCopyMultiTexSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyMultiTexSubImage2DEXT>("glCopyMultiTexSubImage2DEXT");
                        __GlueCopyMultiTexSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCopyMultiTexSubImage3DEXT>("glCopyMultiTexSubImage3DEXT");
                        __GlueCopyTextureImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTextureImage1DEXT>("glCopyTextureImage1DEXT");
                        __GlueCopyTextureImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTextureImage2DEXT>("glCopyTextureImage2DEXT");
                        __GlueCopyTextureSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTextureSubImage1DEXT>("glCopyTextureSubImage1DEXT");
                        __GlueCopyTextureSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTextureSubImage2DEXT>("glCopyTextureSubImage2DEXT");
                        __GlueCopyTextureSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glCopyTextureSubImage3DEXT>("glCopyTextureSubImage3DEXT");
                        __GlueDisableClientStateIndexedEXT = GLFunctionLoader.LoadGLFunction<__glDisableClientStateIndexedEXT>("glDisableClientStateIndexedEXT");
                        __GlueDisableClientStateiEXT = GLFunctionLoader.LoadGLFunction<__glDisableClientStateiEXT>("glDisableClientStateiEXT");
                        __GlueDisableVertexArrayAttribEXT = GLFunctionLoader.LoadGLFunction<__glDisableVertexArrayAttribEXT>("glDisableVertexArrayAttribEXT");
                        __GlueDisableVertexArrayEXT = GLFunctionLoader.LoadGLFunction<__glDisableVertexArrayEXT>("glDisableVertexArrayEXT");
                        __GlueEnableClientStateIndexedEXT = GLFunctionLoader.LoadGLFunction<__glEnableClientStateIndexedEXT>("glEnableClientStateIndexedEXT");
                        __GlueEnableClientStateiEXT = GLFunctionLoader.LoadGLFunction<__glEnableClientStateiEXT>("glEnableClientStateiEXT");
                        __GlueEnableVertexArrayAttribEXT = GLFunctionLoader.LoadGLFunction<__glEnableVertexArrayAttribEXT>("glEnableVertexArrayAttribEXT");
                        __GlueEnableVertexArrayEXT = GLFunctionLoader.LoadGLFunction<__glEnableVertexArrayEXT>("glEnableVertexArrayEXT");
                        __GlueFlushMappedNamedBufferRangeEXT = GLFunctionLoader.LoadGLFunction<__glFlushMappedNamedBufferRangeEXT>("glFlushMappedNamedBufferRangeEXT");
                        __GlueFramebufferDrawBufferEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferDrawBufferEXT>("glFramebufferDrawBufferEXT");
                        __GlueFramebufferDrawBuffersEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferDrawBuffersEXT>("glFramebufferDrawBuffersEXT");
                        __GlueFramebufferReadBufferEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferReadBufferEXT>("glFramebufferReadBufferEXT");
                        __GlueGenerateMultiTexMipmapEXT = GLFunctionLoader.LoadGLFunction<__glGenerateMultiTexMipmapEXT>("glGenerateMultiTexMipmapEXT");
                        __GlueGenerateTextureMipmapEXT = GLFunctionLoader.LoadGLFunction<__glGenerateTextureMipmapEXT>("glGenerateTextureMipmapEXT");
                        __GlueGetCompressedMultiTexImageEXT = GLFunctionLoader.LoadGLFunction<__glGetCompressedMultiTexImageEXT>("glGetCompressedMultiTexImageEXT");
                        __GlueGetCompressedTextureImageEXT = GLFunctionLoader.LoadGLFunction<__glGetCompressedTextureImageEXT>("glGetCompressedTextureImageEXT");
                        __GlueGetDoubleIndexedvEXT = GLFunctionLoader.LoadGLFunction<__glGetDoubleIndexedvEXT>("glGetDoubleIndexedvEXT");
                        __GlueGetDoublei_vEXT = GLFunctionLoader.LoadGLFunction<__glGetDoublei_vEXT>("glGetDoublei_vEXT");
                        __GlueGetFloatIndexedvEXT = GLFunctionLoader.LoadGLFunction<__glGetFloatIndexedvEXT>("glGetFloatIndexedvEXT");
                        __GlueGetFloati_vEXT = GLFunctionLoader.LoadGLFunction<__glGetFloati_vEXT>("glGetFloati_vEXT");
                        __GlueGetFramebufferParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetFramebufferParameterivEXT>("glGetFramebufferParameterivEXT");
                        __GlueGetMultiTexEnvfvEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexEnvfvEXT>("glGetMultiTexEnvfvEXT");
                        __GlueGetMultiTexEnvivEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexEnvivEXT>("glGetMultiTexEnvivEXT");
                        __GlueGetMultiTexGendvEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexGendvEXT>("glGetMultiTexGendvEXT");
                        __GlueGetMultiTexGenfvEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexGenfvEXT>("glGetMultiTexGenfvEXT");
                        __GlueGetMultiTexGenivEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexGenivEXT>("glGetMultiTexGenivEXT");
                        __GlueGetMultiTexImageEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexImageEXT>("glGetMultiTexImageEXT");
                        __GlueGetMultiTexLevelParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexLevelParameterfvEXT>("glGetMultiTexLevelParameterfvEXT");
                        __GlueGetMultiTexLevelParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexLevelParameterivEXT>("glGetMultiTexLevelParameterivEXT");
                        __GlueGetMultiTexParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexParameterIivEXT>("glGetMultiTexParameterIivEXT");
                        __GlueGetMultiTexParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexParameterIuivEXT>("glGetMultiTexParameterIuivEXT");
                        __GlueGetMultiTexParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexParameterfvEXT>("glGetMultiTexParameterfvEXT");
                        __GlueGetMultiTexParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetMultiTexParameterivEXT>("glGetMultiTexParameterivEXT");
                        __GlueGetNamedBufferParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferParameterivEXT>("glGetNamedBufferParameterivEXT");
                        __GlueGetNamedBufferPointervEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferPointervEXT>("glGetNamedBufferPointervEXT");
                        __GlueGetNamedBufferSubDataEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedBufferSubDataEXT>("glGetNamedBufferSubDataEXT");
                        __GlueGetNamedFramebufferAttachmentParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedFramebufferAttachmentParameterivEXT>("glGetNamedFramebufferAttachmentParameterivEXT");
                        __GlueGetNamedProgramLocalParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedProgramLocalParameterIivEXT>("glGetNamedProgramLocalParameterIivEXT");
                        __GlueGetNamedProgramLocalParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedProgramLocalParameterIuivEXT>("glGetNamedProgramLocalParameterIuivEXT");
                        __GlueGetNamedProgramLocalParameterdvEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedProgramLocalParameterdvEXT>("glGetNamedProgramLocalParameterdvEXT");
                        __GlueGetNamedProgramLocalParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedProgramLocalParameterfvEXT>("glGetNamedProgramLocalParameterfvEXT");
                        __GlueGetNamedProgramStringEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedProgramStringEXT>("glGetNamedProgramStringEXT");
                        __GlueGetNamedProgramivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedProgramivEXT>("glGetNamedProgramivEXT");
                        __GlueGetNamedRenderbufferParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetNamedRenderbufferParameterivEXT>("glGetNamedRenderbufferParameterivEXT");
                        __GlueGetPointerIndexedvEXT = GLFunctionLoader.LoadGLFunction<__glGetPointerIndexedvEXT>("glGetPointerIndexedvEXT");
                        __GlueGetPointeri_vEXT = GLFunctionLoader.LoadGLFunction<__glGetPointeri_vEXT>("glGetPointeri_vEXT");
                        __GlueGetTextureImageEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureImageEXT>("glGetTextureImageEXT");
                        __GlueGetTextureLevelParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureLevelParameterfvEXT>("glGetTextureLevelParameterfvEXT");
                        __GlueGetTextureLevelParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureLevelParameterivEXT>("glGetTextureLevelParameterivEXT");
                        __GlueGetTextureParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterIivEXT>("glGetTextureParameterIivEXT");
                        __GlueGetTextureParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterIuivEXT>("glGetTextureParameterIuivEXT");
                        __GlueGetTextureParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterfvEXT>("glGetTextureParameterfvEXT");
                        __GlueGetTextureParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetTextureParameterivEXT>("glGetTextureParameterivEXT");
                        __GlueGetVertexArrayIntegeri_vEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayIntegeri_vEXT>("glGetVertexArrayIntegeri_vEXT");
                        __GlueGetVertexArrayIntegervEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayIntegervEXT>("glGetVertexArrayIntegervEXT");
                        __GlueGetVertexArrayPointeri_vEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayPointeri_vEXT>("glGetVertexArrayPointeri_vEXT");
                        __GlueGetVertexArrayPointervEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexArrayPointervEXT>("glGetVertexArrayPointervEXT");
                        __GlueMapNamedBufferEXT = GLFunctionLoader.LoadGLFunction<__glMapNamedBufferEXT>("glMapNamedBufferEXT");
                        __GlueMapNamedBufferRangeEXT = GLFunctionLoader.LoadGLFunction<__glMapNamedBufferRangeEXT>("glMapNamedBufferRangeEXT");
                        __GlueMatrixFrustumEXT = GLFunctionLoader.LoadGLFunction<__glMatrixFrustumEXT>("glMatrixFrustumEXT");
                        __GlueMatrixLoadIdentityEXT = GLFunctionLoader.LoadGLFunction<__glMatrixLoadIdentityEXT>("glMatrixLoadIdentityEXT");
                        __GlueMatrixLoadTransposedEXT = GLFunctionLoader.LoadGLFunction<__glMatrixLoadTransposedEXT>("glMatrixLoadTransposedEXT");
                        __GlueMatrixLoadTransposefEXT = GLFunctionLoader.LoadGLFunction<__glMatrixLoadTransposefEXT>("glMatrixLoadTransposefEXT");
                        __GlueMatrixLoaddEXT = GLFunctionLoader.LoadGLFunction<__glMatrixLoaddEXT>("glMatrixLoaddEXT");
                        __GlueMatrixLoadfEXT = GLFunctionLoader.LoadGLFunction<__glMatrixLoadfEXT>("glMatrixLoadfEXT");
                        __GlueMatrixMultTransposedEXT = GLFunctionLoader.LoadGLFunction<__glMatrixMultTransposedEXT>("glMatrixMultTransposedEXT");
                        __GlueMatrixMultTransposefEXT = GLFunctionLoader.LoadGLFunction<__glMatrixMultTransposefEXT>("glMatrixMultTransposefEXT");
                        __GlueMatrixMultdEXT = GLFunctionLoader.LoadGLFunction<__glMatrixMultdEXT>("glMatrixMultdEXT");
                        __GlueMatrixMultfEXT = GLFunctionLoader.LoadGLFunction<__glMatrixMultfEXT>("glMatrixMultfEXT");
                        __GlueMatrixOrthoEXT = GLFunctionLoader.LoadGLFunction<__glMatrixOrthoEXT>("glMatrixOrthoEXT");
                        __GlueMatrixPopEXT = GLFunctionLoader.LoadGLFunction<__glMatrixPopEXT>("glMatrixPopEXT");
                        __GlueMatrixPushEXT = GLFunctionLoader.LoadGLFunction<__glMatrixPushEXT>("glMatrixPushEXT");
                        __GlueMatrixRotatedEXT = GLFunctionLoader.LoadGLFunction<__glMatrixRotatedEXT>("glMatrixRotatedEXT");
                        __GlueMatrixRotatefEXT = GLFunctionLoader.LoadGLFunction<__glMatrixRotatefEXT>("glMatrixRotatefEXT");
                        __GlueMatrixScaledEXT = GLFunctionLoader.LoadGLFunction<__glMatrixScaledEXT>("glMatrixScaledEXT");
                        __GlueMatrixScalefEXT = GLFunctionLoader.LoadGLFunction<__glMatrixScalefEXT>("glMatrixScalefEXT");
                        __GlueMatrixTranslatedEXT = GLFunctionLoader.LoadGLFunction<__glMatrixTranslatedEXT>("glMatrixTranslatedEXT");
                        __GlueMatrixTranslatefEXT = GLFunctionLoader.LoadGLFunction<__glMatrixTranslatefEXT>("glMatrixTranslatefEXT");
                        __GlueMultiTexBufferEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexBufferEXT>("glMultiTexBufferEXT");
                        __GlueMultiTexCoordPointerEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexCoordPointerEXT>("glMultiTexCoordPointerEXT");
                        __GlueMultiTexEnvfEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexEnvfEXT>("glMultiTexEnvfEXT");
                        __GlueMultiTexEnvfvEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexEnvfvEXT>("glMultiTexEnvfvEXT");
                        __GlueMultiTexEnviEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexEnviEXT>("glMultiTexEnviEXT");
                        __GlueMultiTexEnvivEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexEnvivEXT>("glMultiTexEnvivEXT");
                        __GlueMultiTexGendEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexGendEXT>("glMultiTexGendEXT");
                        __GlueMultiTexGendvEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexGendvEXT>("glMultiTexGendvEXT");
                        __GlueMultiTexGenfEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexGenfEXT>("glMultiTexGenfEXT");
                        __GlueMultiTexGenfvEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexGenfvEXT>("glMultiTexGenfvEXT");
                        __GlueMultiTexGeniEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexGeniEXT>("glMultiTexGeniEXT");
                        __GlueMultiTexGenivEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexGenivEXT>("glMultiTexGenivEXT");
                        __GlueMultiTexImage1DEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexImage1DEXT>("glMultiTexImage1DEXT");
                        __GlueMultiTexImage2DEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexImage2DEXT>("glMultiTexImage2DEXT");
                        __GlueMultiTexImage3DEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexImage3DEXT>("glMultiTexImage3DEXT");
                        __GlueMultiTexParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexParameterIivEXT>("glMultiTexParameterIivEXT");
                        __GlueMultiTexParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexParameterIuivEXT>("glMultiTexParameterIuivEXT");
                        __GlueMultiTexParameterfEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexParameterfEXT>("glMultiTexParameterfEXT");
                        __GlueMultiTexParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexParameterfvEXT>("glMultiTexParameterfvEXT");
                        __GlueMultiTexParameteriEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexParameteriEXT>("glMultiTexParameteriEXT");
                        __GlueMultiTexParameterivEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexParameterivEXT>("glMultiTexParameterivEXT");
                        __GlueMultiTexRenderbufferEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexRenderbufferEXT>("glMultiTexRenderbufferEXT");
                        __GlueMultiTexSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexSubImage1DEXT>("glMultiTexSubImage1DEXT");
                        __GlueMultiTexSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexSubImage2DEXT>("glMultiTexSubImage2DEXT");
                        __GlueMultiTexSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glMultiTexSubImage3DEXT>("glMultiTexSubImage3DEXT");
                        __GlueNamedBufferDataEXT = GLFunctionLoader.LoadGLFunction<__glNamedBufferDataEXT>("glNamedBufferDataEXT");
                        __GlueNamedBufferSubDataEXT = GLFunctionLoader.LoadGLFunction<__glNamedBufferSubDataEXT>("glNamedBufferSubDataEXT");
                        __GlueNamedCopyBufferSubDataEXT = GLFunctionLoader.LoadGLFunction<__glNamedCopyBufferSubDataEXT>("glNamedCopyBufferSubDataEXT");
                        __GlueNamedFramebufferRenderbufferEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferRenderbufferEXT>("glNamedFramebufferRenderbufferEXT");
                        __GlueNamedFramebufferTexture1DEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTexture1DEXT>("glNamedFramebufferTexture1DEXT");
                        __GlueNamedFramebufferTexture2DEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTexture2DEXT>("glNamedFramebufferTexture2DEXT");
                        __GlueNamedFramebufferTexture3DEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTexture3DEXT>("glNamedFramebufferTexture3DEXT");
                        __GlueNamedFramebufferTextureEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTextureEXT>("glNamedFramebufferTextureEXT");
                        __GlueNamedFramebufferTextureFaceEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTextureFaceEXT>("glNamedFramebufferTextureFaceEXT");
                        __GlueNamedFramebufferTextureLayerEXT = GLFunctionLoader.LoadGLFunction<__glNamedFramebufferTextureLayerEXT>("glNamedFramebufferTextureLayerEXT");
                        __GlueNamedProgramLocalParameter4dEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameter4dEXT>("glNamedProgramLocalParameter4dEXT");
                        __GlueNamedProgramLocalParameter4dvEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameter4dvEXT>("glNamedProgramLocalParameter4dvEXT");
                        __GlueNamedProgramLocalParameter4fEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameter4fEXT>("glNamedProgramLocalParameter4fEXT");
                        __GlueNamedProgramLocalParameter4fvEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameter4fvEXT>("glNamedProgramLocalParameter4fvEXT");
                        __GlueNamedProgramLocalParameterI4iEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameterI4iEXT>("glNamedProgramLocalParameterI4iEXT");
                        __GlueNamedProgramLocalParameterI4ivEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameterI4ivEXT>("glNamedProgramLocalParameterI4ivEXT");
                        __GlueNamedProgramLocalParameterI4uiEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameterI4uiEXT>("glNamedProgramLocalParameterI4uiEXT");
                        __GlueNamedProgramLocalParameterI4uivEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameterI4uivEXT>("glNamedProgramLocalParameterI4uivEXT");
                        __GlueNamedProgramLocalParameters4fvEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParameters4fvEXT>("glNamedProgramLocalParameters4fvEXT");
                        __GlueNamedProgramLocalParametersI4ivEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParametersI4ivEXT>("glNamedProgramLocalParametersI4ivEXT");
                        __GlueNamedProgramLocalParametersI4uivEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramLocalParametersI4uivEXT>("glNamedProgramLocalParametersI4uivEXT");
                        __GlueNamedProgramStringEXT = GLFunctionLoader.LoadGLFunction<__glNamedProgramStringEXT>("glNamedProgramStringEXT");
                        __GlueNamedRenderbufferStorageEXT = GLFunctionLoader.LoadGLFunction<__glNamedRenderbufferStorageEXT>("glNamedRenderbufferStorageEXT");
                        __GlueNamedRenderbufferStorageMultisampleCoverageEXT = GLFunctionLoader.LoadGLFunction<__glNamedRenderbufferStorageMultisampleCoverageEXT>("glNamedRenderbufferStorageMultisampleCoverageEXT");
                        __GlueNamedRenderbufferStorageMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glNamedRenderbufferStorageMultisampleEXT>("glNamedRenderbufferStorageMultisampleEXT");
                        __GlueProgramUniform1fEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform1fEXT>("glProgramUniform1fEXT");
                        __GlueProgramUniform1fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform1fvEXT>("glProgramUniform1fvEXT");
                        __GlueProgramUniform1iEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform1iEXT>("glProgramUniform1iEXT");
                        __GlueProgramUniform1ivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform1ivEXT>("glProgramUniform1ivEXT");
                        __GlueProgramUniform1uiEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform1uiEXT>("glProgramUniform1uiEXT");
                        __GlueProgramUniform1uivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform1uivEXT>("glProgramUniform1uivEXT");
                        __GlueProgramUniform2fEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform2fEXT>("glProgramUniform2fEXT");
                        __GlueProgramUniform2fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform2fvEXT>("glProgramUniform2fvEXT");
                        __GlueProgramUniform2iEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform2iEXT>("glProgramUniform2iEXT");
                        __GlueProgramUniform2ivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform2ivEXT>("glProgramUniform2ivEXT");
                        __GlueProgramUniform2uiEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform2uiEXT>("glProgramUniform2uiEXT");
                        __GlueProgramUniform2uivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform2uivEXT>("glProgramUniform2uivEXT");
                        __GlueProgramUniform3fEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform3fEXT>("glProgramUniform3fEXT");
                        __GlueProgramUniform3fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform3fvEXT>("glProgramUniform3fvEXT");
                        __GlueProgramUniform3iEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform3iEXT>("glProgramUniform3iEXT");
                        __GlueProgramUniform3ivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform3ivEXT>("glProgramUniform3ivEXT");
                        __GlueProgramUniform3uiEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform3uiEXT>("glProgramUniform3uiEXT");
                        __GlueProgramUniform3uivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform3uivEXT>("glProgramUniform3uivEXT");
                        __GlueProgramUniform4fEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform4fEXT>("glProgramUniform4fEXT");
                        __GlueProgramUniform4fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform4fvEXT>("glProgramUniform4fvEXT");
                        __GlueProgramUniform4iEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform4iEXT>("glProgramUniform4iEXT");
                        __GlueProgramUniform4ivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform4ivEXT>("glProgramUniform4ivEXT");
                        __GlueProgramUniform4uiEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform4uiEXT>("glProgramUniform4uiEXT");
                        __GlueProgramUniform4uivEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniform4uivEXT>("glProgramUniform4uivEXT");
                        __GlueProgramUniformMatrix2fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2fvEXT>("glProgramUniformMatrix2fvEXT");
                        __GlueProgramUniformMatrix2x3fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2x3fvEXT>("glProgramUniformMatrix2x3fvEXT");
                        __GlueProgramUniformMatrix2x4fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix2x4fvEXT>("glProgramUniformMatrix2x4fvEXT");
                        __GlueProgramUniformMatrix3fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3fvEXT>("glProgramUniformMatrix3fvEXT");
                        __GlueProgramUniformMatrix3x2fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3x2fvEXT>("glProgramUniformMatrix3x2fvEXT");
                        __GlueProgramUniformMatrix3x4fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix3x4fvEXT>("glProgramUniformMatrix3x4fvEXT");
                        __GlueProgramUniformMatrix4fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4fvEXT>("glProgramUniformMatrix4fvEXT");
                        __GlueProgramUniformMatrix4x2fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4x2fvEXT>("glProgramUniformMatrix4x2fvEXT");
                        __GlueProgramUniformMatrix4x3fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramUniformMatrix4x3fvEXT>("glProgramUniformMatrix4x3fvEXT");
                        __GluePushClientAttribDefaultEXT = GLFunctionLoader.LoadGLFunction<__glPushClientAttribDefaultEXT>("glPushClientAttribDefaultEXT");
                        __GlueTextureBufferEXT = GLFunctionLoader.LoadGLFunction<__glTextureBufferEXT>("glTextureBufferEXT");
                        __GlueTextureImage1DEXT = GLFunctionLoader.LoadGLFunction<__glTextureImage1DEXT>("glTextureImage1DEXT");
                        __GlueTextureImage2DEXT = GLFunctionLoader.LoadGLFunction<__glTextureImage2DEXT>("glTextureImage2DEXT");
                        __GlueTextureImage3DEXT = GLFunctionLoader.LoadGLFunction<__glTextureImage3DEXT>("glTextureImage3DEXT");
                        __GlueTextureParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glTextureParameterIivEXT>("glTextureParameterIivEXT");
                        __GlueTextureParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glTextureParameterIuivEXT>("glTextureParameterIuivEXT");
                        __GlueTextureParameterfEXT = GLFunctionLoader.LoadGLFunction<__glTextureParameterfEXT>("glTextureParameterfEXT");
                        __GlueTextureParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glTextureParameterfvEXT>("glTextureParameterfvEXT");
                        __GlueTextureParameteriEXT = GLFunctionLoader.LoadGLFunction<__glTextureParameteriEXT>("glTextureParameteriEXT");
                        __GlueTextureParameterivEXT = GLFunctionLoader.LoadGLFunction<__glTextureParameterivEXT>("glTextureParameterivEXT");
                        __GlueTextureRenderbufferEXT = GLFunctionLoader.LoadGLFunction<__glTextureRenderbufferEXT>("glTextureRenderbufferEXT");
                        __GlueTextureSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glTextureSubImage1DEXT>("glTextureSubImage1DEXT");
                        __GlueTextureSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glTextureSubImage2DEXT>("glTextureSubImage2DEXT");
                        __GlueTextureSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glTextureSubImage3DEXT>("glTextureSubImage3DEXT");
                        __GlueUnmapNamedBufferEXT = GLFunctionLoader.LoadGLFunction<__glUnmapNamedBufferEXT>("glUnmapNamedBufferEXT");
                        __GlueVertexArrayColorOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayColorOffsetEXT>("glVertexArrayColorOffsetEXT");
                        __GlueVertexArrayEdgeFlagOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayEdgeFlagOffsetEXT>("glVertexArrayEdgeFlagOffsetEXT");
                        __GlueVertexArrayFogCoordOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayFogCoordOffsetEXT>("glVertexArrayFogCoordOffsetEXT");
                        __GlueVertexArrayIndexOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayIndexOffsetEXT>("glVertexArrayIndexOffsetEXT");
                        __GlueVertexArrayMultiTexCoordOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayMultiTexCoordOffsetEXT>("glVertexArrayMultiTexCoordOffsetEXT");
                        __GlueVertexArrayNormalOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayNormalOffsetEXT>("glVertexArrayNormalOffsetEXT");
                        __GlueVertexArraySecondaryColorOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArraySecondaryColorOffsetEXT>("glVertexArraySecondaryColorOffsetEXT");
                        __GlueVertexArrayTexCoordOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayTexCoordOffsetEXT>("glVertexArrayTexCoordOffsetEXT");
                        __GlueVertexArrayVertexAttribDivisorEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribDivisorEXT>("glVertexArrayVertexAttribDivisorEXT");
                        __GlueVertexArrayVertexAttribIOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribIOffsetEXT>("glVertexArrayVertexAttribIOffsetEXT");
                        __GlueVertexArrayVertexAttribOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribOffsetEXT>("glVertexArrayVertexAttribOffsetEXT");
                        __GlueVertexArrayVertexOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexOffsetEXT>("glVertexArrayVertexOffsetEXT");


                        GL_EXT_direct_state_access = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_direct_state_access");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_discard_framebuffer:
                    {
                        __GlueDiscardFramebufferEXT = GLFunctionLoader.LoadGLFunction<__glDiscardFramebufferEXT>("glDiscardFramebufferEXT");


                        GL_EXT_discard_framebuffer = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_discard_framebuffer");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_draw_buffers:
                    {
                        __GlueDrawBuffersEXT = GLFunctionLoader.LoadGLFunction<__glDrawBuffersEXT>("glDrawBuffersEXT");


                        GL_EXT_draw_buffers = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_draw_buffers");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_draw_buffers2:
                    {
                        __GlueColorMaskIndexedEXT = GLFunctionLoader.LoadGLFunction<__glColorMaskIndexedEXT>("glColorMaskIndexedEXT");
                        __GlueDisableIndexedEXT = GLFunctionLoader.LoadGLFunction<__glDisableIndexedEXT>("glDisableIndexedEXT");
                        __GlueEnableIndexedEXT = GLFunctionLoader.LoadGLFunction<__glEnableIndexedEXT>("glEnableIndexedEXT");
                        __GlueGetBooleanIndexedvEXT = GLFunctionLoader.LoadGLFunction<__glGetBooleanIndexedvEXT>("glGetBooleanIndexedvEXT");
                        __GlueGetIntegerIndexedvEXT = GLFunctionLoader.LoadGLFunction<__glGetIntegerIndexedvEXT>("glGetIntegerIndexedvEXT");
                        __GlueIsEnabledIndexedEXT = GLFunctionLoader.LoadGLFunction<__glIsEnabledIndexedEXT>("glIsEnabledIndexedEXT");


                        GL_EXT_draw_buffers2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_draw_buffers2");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_draw_buffers_indexed:
                    {
                        __GlueBlendEquationSeparateiEXT = GLFunctionLoader.LoadGLFunction<__glBlendEquationSeparateiEXT>("glBlendEquationSeparateiEXT");
                        __GlueBlendEquationiEXT = GLFunctionLoader.LoadGLFunction<__glBlendEquationiEXT>("glBlendEquationiEXT");
                        __GlueBlendFuncSeparateiEXT = GLFunctionLoader.LoadGLFunction<__glBlendFuncSeparateiEXT>("glBlendFuncSeparateiEXT");
                        __GlueBlendFunciEXT = GLFunctionLoader.LoadGLFunction<__glBlendFunciEXT>("glBlendFunciEXT");
                        __GlueColorMaskiEXT = GLFunctionLoader.LoadGLFunction<__glColorMaskiEXT>("glColorMaskiEXT");
                        __GlueDisableiEXT = GLFunctionLoader.LoadGLFunction<__glDisableiEXT>("glDisableiEXT");
                        __GlueEnableiEXT = GLFunctionLoader.LoadGLFunction<__glEnableiEXT>("glEnableiEXT");
                        __GlueIsEnablediEXT = GLFunctionLoader.LoadGLFunction<__glIsEnablediEXT>("glIsEnablediEXT");


                        GL_EXT_draw_buffers_indexed = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_draw_buffers_indexed");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_draw_elements_base_vertex:
                    {
                        __GlueDrawElementsBaseVertexEXT = GLFunctionLoader.LoadGLFunction<__glDrawElementsBaseVertexEXT>("glDrawElementsBaseVertexEXT");
                        __GlueDrawElementsInstancedBaseVertexEXT = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedBaseVertexEXT>("glDrawElementsInstancedBaseVertexEXT");
                        __GlueDrawRangeElementsBaseVertexEXT = GLFunctionLoader.LoadGLFunction<__glDrawRangeElementsBaseVertexEXT>("glDrawRangeElementsBaseVertexEXT");
                        __GlueMultiDrawElementsBaseVertexEXT = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsBaseVertexEXT>("glMultiDrawElementsBaseVertexEXT");


                        GL_EXT_draw_elements_base_vertex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_draw_elements_base_vertex");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_draw_instanced:
                    {
                        __GlueDrawArraysInstancedEXT = GLFunctionLoader.LoadGLFunction<__glDrawArraysInstancedEXT>("glDrawArraysInstancedEXT");
                        __GlueDrawElementsInstancedEXT = GLFunctionLoader.LoadGLFunction<__glDrawElementsInstancedEXT>("glDrawElementsInstancedEXT");


                        GL_EXT_draw_instanced = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_draw_instanced");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_draw_range_elements:
                    {
                        __GlueDrawRangeElementsEXT = GLFunctionLoader.LoadGLFunction<__glDrawRangeElementsEXT>("glDrawRangeElementsEXT");


                        GL_EXT_draw_range_elements = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_draw_range_elements");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_external_buffer:
                    {
                        __GlueBufferStorageExternalEXT = GLFunctionLoader.LoadGLFunction<__glBufferStorageExternalEXT>("glBufferStorageExternalEXT");
                        __GlueNamedBufferStorageExternalEXT = GLFunctionLoader.LoadGLFunction<__glNamedBufferStorageExternalEXT>("glNamedBufferStorageExternalEXT");


                        GL_EXT_external_buffer = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_external_buffer");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_float_blend:
                    {


                        GL_EXT_float_blend = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_float_blend");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_fog_coord:
                    {
                        __GlueFogCoordPointerEXT = GLFunctionLoader.LoadGLFunction<__glFogCoordPointerEXT>("glFogCoordPointerEXT");
                        __GlueFogCoorddEXT = GLFunctionLoader.LoadGLFunction<__glFogCoorddEXT>("glFogCoorddEXT");
                        __GlueFogCoorddvEXT = GLFunctionLoader.LoadGLFunction<__glFogCoorddvEXT>("glFogCoorddvEXT");
                        __GlueFogCoordfEXT = GLFunctionLoader.LoadGLFunction<__glFogCoordfEXT>("glFogCoordfEXT");
                        __GlueFogCoordfvEXT = GLFunctionLoader.LoadGLFunction<__glFogCoordfvEXT>("glFogCoordfvEXT");


                        GL_EXT_fog_coord = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_fog_coord");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_frag_depth:
                    {


                        GL_EXT_frag_depth = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_frag_depth");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_fragment_lighting:
                    {
                        __GlueFragmentColorMaterialEXT = GLFunctionLoader.LoadGLFunction<__glFragmentColorMaterialEXT>("glFragmentColorMaterialEXT");
                        __GlueFragmentLightModelfEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightModelfEXT>("glFragmentLightModelfEXT");
                        __GlueFragmentLightModelfvEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightModelfvEXT>("glFragmentLightModelfvEXT");
                        __GlueFragmentLightModeliEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightModeliEXT>("glFragmentLightModeliEXT");
                        __GlueFragmentLightModelivEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightModelivEXT>("glFragmentLightModelivEXT");
                        __GlueFragmentLightfEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightfEXT>("glFragmentLightfEXT");
                        __GlueFragmentLightfvEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightfvEXT>("glFragmentLightfvEXT");
                        __GlueFragmentLightiEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightiEXT>("glFragmentLightiEXT");
                        __GlueFragmentLightivEXT = GLFunctionLoader.LoadGLFunction<__glFragmentLightivEXT>("glFragmentLightivEXT");
                        __GlueFragmentMaterialfEXT = GLFunctionLoader.LoadGLFunction<__glFragmentMaterialfEXT>("glFragmentMaterialfEXT");
                        __GlueFragmentMaterialfvEXT = GLFunctionLoader.LoadGLFunction<__glFragmentMaterialfvEXT>("glFragmentMaterialfvEXT");
                        __GlueFragmentMaterialiEXT = GLFunctionLoader.LoadGLFunction<__glFragmentMaterialiEXT>("glFragmentMaterialiEXT");
                        __GlueFragmentMaterialivEXT = GLFunctionLoader.LoadGLFunction<__glFragmentMaterialivEXT>("glFragmentMaterialivEXT");
                        __GlueGetFragmentLightfvEXT = GLFunctionLoader.LoadGLFunction<__glGetFragmentLightfvEXT>("glGetFragmentLightfvEXT");
                        __GlueGetFragmentLightivEXT = GLFunctionLoader.LoadGLFunction<__glGetFragmentLightivEXT>("glGetFragmentLightivEXT");
                        __GlueGetFragmentMaterialfvEXT = GLFunctionLoader.LoadGLFunction<__glGetFragmentMaterialfvEXT>("glGetFragmentMaterialfvEXT");
                        __GlueGetFragmentMaterialivEXT = GLFunctionLoader.LoadGLFunction<__glGetFragmentMaterialivEXT>("glGetFragmentMaterialivEXT");
                        __GlueLightEnviEXT = GLFunctionLoader.LoadGLFunction<__glLightEnviEXT>("glLightEnviEXT");


                        GL_EXT_fragment_lighting = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_fragment_lighting");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_framebuffer_blit:
                    {
                        __GlueBlitFramebufferEXT = GLFunctionLoader.LoadGLFunction<__glBlitFramebufferEXT>("glBlitFramebufferEXT");


                        GL_EXT_framebuffer_blit = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_framebuffer_blit");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_framebuffer_multisample:
                    {
                        __GlueRenderbufferStorageMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glRenderbufferStorageMultisampleEXT>("glRenderbufferStorageMultisampleEXT");


                        GL_EXT_framebuffer_multisample = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_framebuffer_multisample");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_framebuffer_multisample_blit_scaled:
                    {


                        GL_EXT_framebuffer_multisample_blit_scaled = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_framebuffer_multisample_blit_scaled");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_framebuffer_object:
                    {
                        __GlueBindFramebufferEXT = GLFunctionLoader.LoadGLFunction<__glBindFramebufferEXT>("glBindFramebufferEXT");
                        __GlueBindRenderbufferEXT = GLFunctionLoader.LoadGLFunction<__glBindRenderbufferEXT>("glBindRenderbufferEXT");
                        __GlueCheckFramebufferStatusEXT = GLFunctionLoader.LoadGLFunction<__glCheckFramebufferStatusEXT>("glCheckFramebufferStatusEXT");
                        __GlueDeleteFramebuffersEXT = GLFunctionLoader.LoadGLFunction<__glDeleteFramebuffersEXT>("glDeleteFramebuffersEXT");
                        __GlueDeleteRenderbuffersEXT = GLFunctionLoader.LoadGLFunction<__glDeleteRenderbuffersEXT>("glDeleteRenderbuffersEXT");
                        __GlueFramebufferRenderbufferEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferRenderbufferEXT>("glFramebufferRenderbufferEXT");
                        __GlueFramebufferTexture1DEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture1DEXT>("glFramebufferTexture1DEXT");
                        __GlueFramebufferTexture2DEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture2DEXT>("glFramebufferTexture2DEXT");
                        __GlueFramebufferTexture3DEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture3DEXT>("glFramebufferTexture3DEXT");
                        __GlueGenFramebuffersEXT = GLFunctionLoader.LoadGLFunction<__glGenFramebuffersEXT>("glGenFramebuffersEXT");
                        __GlueGenRenderbuffersEXT = GLFunctionLoader.LoadGLFunction<__glGenRenderbuffersEXT>("glGenRenderbuffersEXT");
                        __GlueGenerateMipmapEXT = GLFunctionLoader.LoadGLFunction<__glGenerateMipmapEXT>("glGenerateMipmapEXT");
                        __GlueGetFramebufferAttachmentParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetFramebufferAttachmentParameterivEXT>("glGetFramebufferAttachmentParameterivEXT");
                        __GlueGetRenderbufferParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetRenderbufferParameterivEXT>("glGetRenderbufferParameterivEXT");
                        __GlueIsFramebufferEXT = GLFunctionLoader.LoadGLFunction<__glIsFramebufferEXT>("glIsFramebufferEXT");
                        __GlueIsRenderbufferEXT = GLFunctionLoader.LoadGLFunction<__glIsRenderbufferEXT>("glIsRenderbufferEXT");
                        __GlueRenderbufferStorageEXT = GLFunctionLoader.LoadGLFunction<__glRenderbufferStorageEXT>("glRenderbufferStorageEXT");


                        GL_EXT_framebuffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_framebuffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_framebuffer_sRGB:
                    {


                        GL_EXT_framebuffer_sRGB = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_framebuffer_sRGB");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_geometry_point_size:
                    {


                        GL_EXT_geometry_point_size = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_geometry_point_size");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_geometry_shader:
                    {


                        GL_EXT_geometry_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_geometry_shader");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_geometry_shader4:
                    {
                        __GlueFramebufferTextureEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureEXT>("glFramebufferTextureEXT");
                        __GlueFramebufferTextureFaceEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureFaceEXT>("glFramebufferTextureFaceEXT");
                        __GlueProgramParameteriEXT = GLFunctionLoader.LoadGLFunction<__glProgramParameteriEXT>("glProgramParameteriEXT");


                        GL_EXT_geometry_shader4 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_geometry_shader4");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_gpu_program_parameters:
                    {
                        __GlueProgramEnvParameters4fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramEnvParameters4fvEXT>("glProgramEnvParameters4fvEXT");
                        __GlueProgramLocalParameters4fvEXT = GLFunctionLoader.LoadGLFunction<__glProgramLocalParameters4fvEXT>("glProgramLocalParameters4fvEXT");


                        GL_EXT_gpu_program_parameters = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_gpu_program_parameters");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_gpu_shader4:
                    {
                        __GlueBindFragDataLocationEXT = GLFunctionLoader.LoadGLFunction<__glBindFragDataLocationEXT>("glBindFragDataLocationEXT");
                        __GlueGetFragDataLocationEXT = GLFunctionLoader.LoadGLFunction<__glGetFragDataLocationEXT>("glGetFragDataLocationEXT");
                        __GlueGetUniformuivEXT = GLFunctionLoader.LoadGLFunction<__glGetUniformuivEXT>("glGetUniformuivEXT");
                        __GlueGetVertexAttribIivEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribIivEXT>("glGetVertexAttribIivEXT");
                        __GlueGetVertexAttribIuivEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribIuivEXT>("glGetVertexAttribIuivEXT");
                        __GlueUniform1uiEXT = GLFunctionLoader.LoadGLFunction<__glUniform1uiEXT>("glUniform1uiEXT");
                        __GlueUniform1uivEXT = GLFunctionLoader.LoadGLFunction<__glUniform1uivEXT>("glUniform1uivEXT");
                        __GlueUniform2uiEXT = GLFunctionLoader.LoadGLFunction<__glUniform2uiEXT>("glUniform2uiEXT");
                        __GlueUniform2uivEXT = GLFunctionLoader.LoadGLFunction<__glUniform2uivEXT>("glUniform2uivEXT");
                        __GlueUniform3uiEXT = GLFunctionLoader.LoadGLFunction<__glUniform3uiEXT>("glUniform3uiEXT");
                        __GlueUniform3uivEXT = GLFunctionLoader.LoadGLFunction<__glUniform3uivEXT>("glUniform3uivEXT");
                        __GlueUniform4uiEXT = GLFunctionLoader.LoadGLFunction<__glUniform4uiEXT>("glUniform4uiEXT");
                        __GlueUniform4uivEXT = GLFunctionLoader.LoadGLFunction<__glUniform4uivEXT>("glUniform4uivEXT");
                        __GlueVertexAttribI1iEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1iEXT>("glVertexAttribI1iEXT");
                        __GlueVertexAttribI1ivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1ivEXT>("glVertexAttribI1ivEXT");
                        __GlueVertexAttribI1uiEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1uiEXT>("glVertexAttribI1uiEXT");
                        __GlueVertexAttribI1uivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI1uivEXT>("glVertexAttribI1uivEXT");
                        __GlueVertexAttribI2iEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2iEXT>("glVertexAttribI2iEXT");
                        __GlueVertexAttribI2ivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2ivEXT>("glVertexAttribI2ivEXT");
                        __GlueVertexAttribI2uiEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2uiEXT>("glVertexAttribI2uiEXT");
                        __GlueVertexAttribI2uivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI2uivEXT>("glVertexAttribI2uivEXT");
                        __GlueVertexAttribI3iEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3iEXT>("glVertexAttribI3iEXT");
                        __GlueVertexAttribI3ivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3ivEXT>("glVertexAttribI3ivEXT");
                        __GlueVertexAttribI3uiEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3uiEXT>("glVertexAttribI3uiEXT");
                        __GlueVertexAttribI3uivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI3uivEXT>("glVertexAttribI3uivEXT");
                        __GlueVertexAttribI4bvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4bvEXT>("glVertexAttribI4bvEXT");
                        __GlueVertexAttribI4iEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4iEXT>("glVertexAttribI4iEXT");
                        __GlueVertexAttribI4ivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4ivEXT>("glVertexAttribI4ivEXT");
                        __GlueVertexAttribI4svEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4svEXT>("glVertexAttribI4svEXT");
                        __GlueVertexAttribI4ubvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4ubvEXT>("glVertexAttribI4ubvEXT");
                        __GlueVertexAttribI4uiEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4uiEXT>("glVertexAttribI4uiEXT");
                        __GlueVertexAttribI4uivEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4uivEXT>("glVertexAttribI4uivEXT");
                        __GlueVertexAttribI4usvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribI4usvEXT>("glVertexAttribI4usvEXT");
                        __GlueVertexAttribIPointerEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribIPointerEXT>("glVertexAttribIPointerEXT");


                        GL_EXT_gpu_shader4 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_gpu_shader4");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_gpu_shader5:
                    {


                        GL_EXT_gpu_shader5 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_gpu_shader5");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_histogram:
                    {
                        __GlueGetHistogramEXT = GLFunctionLoader.LoadGLFunction<__glGetHistogramEXT>("glGetHistogramEXT");
                        __GlueGetHistogramParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetHistogramParameterfvEXT>("glGetHistogramParameterfvEXT");
                        __GlueGetHistogramParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetHistogramParameterivEXT>("glGetHistogramParameterivEXT");
                        __GlueGetMinmaxEXT = GLFunctionLoader.LoadGLFunction<__glGetMinmaxEXT>("glGetMinmaxEXT");
                        __GlueGetMinmaxParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetMinmaxParameterfvEXT>("glGetMinmaxParameterfvEXT");
                        __GlueGetMinmaxParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetMinmaxParameterivEXT>("glGetMinmaxParameterivEXT");
                        __GlueHistogramEXT = GLFunctionLoader.LoadGLFunction<__glHistogramEXT>("glHistogramEXT");
                        __GlueMinmaxEXT = GLFunctionLoader.LoadGLFunction<__glMinmaxEXT>("glMinmaxEXT");
                        __GlueResetHistogramEXT = GLFunctionLoader.LoadGLFunction<__glResetHistogramEXT>("glResetHistogramEXT");
                        __GlueResetMinmaxEXT = GLFunctionLoader.LoadGLFunction<__glResetMinmaxEXT>("glResetMinmaxEXT");


                        GL_EXT_histogram = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_histogram");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_index_array_formats:
                    {


                        GL_EXT_index_array_formats = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_index_array_formats");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_index_func:
                    {
                        __GlueIndexFuncEXT = GLFunctionLoader.LoadGLFunction<__glIndexFuncEXT>("glIndexFuncEXT");


                        GL_EXT_index_func = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_index_func");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_index_material:
                    {
                        __GlueIndexMaterialEXT = GLFunctionLoader.LoadGLFunction<__glIndexMaterialEXT>("glIndexMaterialEXT");


                        GL_EXT_index_material = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_index_material");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_index_texture:
                    {


                        GL_EXT_index_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_index_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_instanced_arrays:
                    {
                        __GlueVertexAttribDivisorEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribDivisorEXT>("glVertexAttribDivisorEXT");


                        GL_EXT_instanced_arrays = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_instanced_arrays");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_light_texture:
                    {
                        __GlueApplyTextureEXT = GLFunctionLoader.LoadGLFunction<__glApplyTextureEXT>("glApplyTextureEXT");
                        __GlueTextureLightEXT = GLFunctionLoader.LoadGLFunction<__glTextureLightEXT>("glTextureLightEXT");
                        __GlueTextureMaterialEXT = GLFunctionLoader.LoadGLFunction<__glTextureMaterialEXT>("glTextureMaterialEXT");


                        GL_EXT_light_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_light_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_map_buffer_range:
                    {
                        __GlueFlushMappedBufferRangeEXT = GLFunctionLoader.LoadGLFunction<__glFlushMappedBufferRangeEXT>("glFlushMappedBufferRangeEXT");
                        __GlueMapBufferRangeEXT = GLFunctionLoader.LoadGLFunction<__glMapBufferRangeEXT>("glMapBufferRangeEXT");


                        GL_EXT_map_buffer_range = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_map_buffer_range");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_memory_object:
                    {
                        __GlueBufferStorageMemEXT = GLFunctionLoader.LoadGLFunction<__glBufferStorageMemEXT>("glBufferStorageMemEXT");
                        __GlueCreateMemoryObjectsEXT = GLFunctionLoader.LoadGLFunction<__glCreateMemoryObjectsEXT>("glCreateMemoryObjectsEXT");
                        __GlueDeleteMemoryObjectsEXT = GLFunctionLoader.LoadGLFunction<__glDeleteMemoryObjectsEXT>("glDeleteMemoryObjectsEXT");
                        __GlueGetMemoryObjectParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetMemoryObjectParameterivEXT>("glGetMemoryObjectParameterivEXT");
                        __GlueGetUnsignedBytei_vEXT = GLFunctionLoader.LoadGLFunction<__glGetUnsignedBytei_vEXT>("glGetUnsignedBytei_vEXT");
                        __GlueGetUnsignedBytevEXT = GLFunctionLoader.LoadGLFunction<__glGetUnsignedBytevEXT>("glGetUnsignedBytevEXT");
                        __GlueIsMemoryObjectEXT = GLFunctionLoader.LoadGLFunction<__glIsMemoryObjectEXT>("glIsMemoryObjectEXT");
                        __GlueMemoryObjectParameterivEXT = GLFunctionLoader.LoadGLFunction<__glMemoryObjectParameterivEXT>("glMemoryObjectParameterivEXT");
                        __GlueNamedBufferStorageMemEXT = GLFunctionLoader.LoadGLFunction<__glNamedBufferStorageMemEXT>("glNamedBufferStorageMemEXT");
                        __GlueTexStorageMem1DEXT = GLFunctionLoader.LoadGLFunction<__glTexStorageMem1DEXT>("glTexStorageMem1DEXT");
                        __GlueTexStorageMem2DEXT = GLFunctionLoader.LoadGLFunction<__glTexStorageMem2DEXT>("glTexStorageMem2DEXT");
                        __GlueTexStorageMem2DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glTexStorageMem2DMultisampleEXT>("glTexStorageMem2DMultisampleEXT");
                        __GlueTexStorageMem3DEXT = GLFunctionLoader.LoadGLFunction<__glTexStorageMem3DEXT>("glTexStorageMem3DEXT");
                        __GlueTexStorageMem3DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glTexStorageMem3DMultisampleEXT>("glTexStorageMem3DMultisampleEXT");
                        __GlueTextureStorageMem1DEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorageMem1DEXT>("glTextureStorageMem1DEXT");
                        __GlueTextureStorageMem2DEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorageMem2DEXT>("glTextureStorageMem2DEXT");
                        __GlueTextureStorageMem2DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorageMem2DMultisampleEXT>("glTextureStorageMem2DMultisampleEXT");
                        __GlueTextureStorageMem3DEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorageMem3DEXT>("glTextureStorageMem3DEXT");
                        __GlueTextureStorageMem3DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorageMem3DMultisampleEXT>("glTextureStorageMem3DMultisampleEXT");


                        GL_EXT_memory_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_memory_object");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_memory_object_fd:
                    {
                        __GlueImportMemoryFdEXT = GLFunctionLoader.LoadGLFunction<__glImportMemoryFdEXT>("glImportMemoryFdEXT");


                        GL_EXT_memory_object_fd = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_memory_object_fd");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_memory_object_win32:
                    {
                        __GlueImportMemoryWin32HandleEXT = GLFunctionLoader.LoadGLFunction<__glImportMemoryWin32HandleEXT>("glImportMemoryWin32HandleEXT");
                        __GlueImportMemoryWin32NameEXT = GLFunctionLoader.LoadGLFunction<__glImportMemoryWin32NameEXT>("glImportMemoryWin32NameEXT");


                        GL_EXT_memory_object_win32 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_memory_object_win32");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_misc_attribute:
                    {


                        GL_EXT_misc_attribute = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_misc_attribute");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multi_draw_arrays:
                    {
                        __GlueMultiDrawArraysEXT = GLFunctionLoader.LoadGLFunction<__glMultiDrawArraysEXT>("glMultiDrawArraysEXT");
                        __GlueMultiDrawElementsEXT = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsEXT>("glMultiDrawElementsEXT");


                        GL_EXT_multi_draw_arrays = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multi_draw_arrays");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multi_draw_indirect:
                    {
                        __GlueMultiDrawArraysIndirectEXT = GLFunctionLoader.LoadGLFunction<__glMultiDrawArraysIndirectEXT>("glMultiDrawArraysIndirectEXT");
                        __GlueMultiDrawElementsIndirectEXT = GLFunctionLoader.LoadGLFunction<__glMultiDrawElementsIndirectEXT>("glMultiDrawElementsIndirectEXT");


                        GL_EXT_multi_draw_indirect = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multi_draw_indirect");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multiple_textures:
                    {


                        GL_EXT_multiple_textures = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multiple_textures");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multisample:
                    {
                        __GlueSampleMaskEXT = GLFunctionLoader.LoadGLFunction<__glSampleMaskEXT>("glSampleMaskEXT");
                        __GlueSamplePatternEXT = GLFunctionLoader.LoadGLFunction<__glSamplePatternEXT>("glSamplePatternEXT");


                        GL_EXT_multisample = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multisample");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multisample_compatibility:
                    {


                        GL_EXT_multisample_compatibility = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multisample_compatibility");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multisampled_render_to_texture:
                    {
                        __GlueFramebufferTexture2DMultisampleEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTexture2DMultisampleEXT>("glFramebufferTexture2DMultisampleEXT");


                        GL_EXT_multisampled_render_to_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multisampled_render_to_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multisampled_render_to_texture2:
                    {


                        GL_EXT_multisampled_render_to_texture2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multisampled_render_to_texture2");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_multiview_draw_buffers:
                    {
                        __GlueDrawBuffersIndexedEXT = GLFunctionLoader.LoadGLFunction<__glDrawBuffersIndexedEXT>("glDrawBuffersIndexedEXT");
                        __GlueGetIntegeri_vEXT = GLFunctionLoader.LoadGLFunction<__glGetIntegeri_vEXT>("glGetIntegeri_vEXT");
                        __GlueReadBufferIndexedEXT = GLFunctionLoader.LoadGLFunction<__glReadBufferIndexedEXT>("glReadBufferIndexedEXT");


                        GL_EXT_multiview_draw_buffers = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_multiview_draw_buffers");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_packed_depth_stencil:
                    {


                        GL_EXT_packed_depth_stencil = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_packed_depth_stencil");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_packed_float:
                    {


                        GL_EXT_packed_float = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_packed_float");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_packed_pixels:
                    {


                        GL_EXT_packed_pixels = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_packed_pixels");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_paletted_texture:
                    {
                        __GlueColorTableEXT = GLFunctionLoader.LoadGLFunction<__glColorTableEXT>("glColorTableEXT");
                        __GlueGetColorTableEXT = GLFunctionLoader.LoadGLFunction<__glGetColorTableEXT>("glGetColorTableEXT");
                        __GlueGetColorTableParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetColorTableParameterfvEXT>("glGetColorTableParameterfvEXT");
                        __GlueGetColorTableParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetColorTableParameterivEXT>("glGetColorTableParameterivEXT");


                        GL_EXT_paletted_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_paletted_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_pixel_buffer_object:
                    {


                        GL_EXT_pixel_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_pixel_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_pixel_transform:
                    {
                        __GlueGetPixelTransformParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glGetPixelTransformParameterfvEXT>("glGetPixelTransformParameterfvEXT");
                        __GlueGetPixelTransformParameterivEXT = GLFunctionLoader.LoadGLFunction<__glGetPixelTransformParameterivEXT>("glGetPixelTransformParameterivEXT");
                        __GluePixelTransformParameterfEXT = GLFunctionLoader.LoadGLFunction<__glPixelTransformParameterfEXT>("glPixelTransformParameterfEXT");
                        __GluePixelTransformParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glPixelTransformParameterfvEXT>("glPixelTransformParameterfvEXT");
                        __GluePixelTransformParameteriEXT = GLFunctionLoader.LoadGLFunction<__glPixelTransformParameteriEXT>("glPixelTransformParameteriEXT");
                        __GluePixelTransformParameterivEXT = GLFunctionLoader.LoadGLFunction<__glPixelTransformParameterivEXT>("glPixelTransformParameterivEXT");


                        GL_EXT_pixel_transform = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_pixel_transform");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_pixel_transform_color_table:
                    {


                        GL_EXT_pixel_transform_color_table = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_pixel_transform_color_table");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_point_parameters:
                    {
                        __GluePointParameterfEXT = GLFunctionLoader.LoadGLFunction<__glPointParameterfEXT>("glPointParameterfEXT");
                        __GluePointParameterfvEXT = GLFunctionLoader.LoadGLFunction<__glPointParameterfvEXT>("glPointParameterfvEXT");


                        GL_EXT_point_parameters = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_point_parameters");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_polygon_offset:
                    {
                        __GluePolygonOffsetEXT = GLFunctionLoader.LoadGLFunction<__glPolygonOffsetEXT>("glPolygonOffsetEXT");


                        GL_EXT_polygon_offset = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_polygon_offset");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_polygon_offset_clamp:
                    {
                        __GluePolygonOffsetClampEXT = GLFunctionLoader.LoadGLFunction<__glPolygonOffsetClampEXT>("glPolygonOffsetClampEXT");


                        GL_EXT_polygon_offset_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_polygon_offset_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_post_depth_coverage:
                    {


                        GL_EXT_post_depth_coverage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_post_depth_coverage");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_provoking_vertex:
                    {
                        __GlueProvokingVertexEXT = GLFunctionLoader.LoadGLFunction<__glProvokingVertexEXT>("glProvokingVertexEXT");


                        GL_EXT_provoking_vertex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_provoking_vertex");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_pvrtc_sRGB:
                    {


                        GL_EXT_pvrtc_sRGB = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_pvrtc_sRGB");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_raster_multisample:
                    {
                        __GlueCoverageModulationNV = GLFunctionLoader.LoadGLFunction<__glCoverageModulationNV>("glCoverageModulationNV");
                        __GlueCoverageModulationTableNV = GLFunctionLoader.LoadGLFunction<__glCoverageModulationTableNV>("glCoverageModulationTableNV");
                        __GlueGetCoverageModulationTableNV = GLFunctionLoader.LoadGLFunction<__glGetCoverageModulationTableNV>("glGetCoverageModulationTableNV");
                        __GlueRasterSamplesEXT = GLFunctionLoader.LoadGLFunction<__glRasterSamplesEXT>("glRasterSamplesEXT");


                        GL_EXT_raster_multisample = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_raster_multisample");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_read_format_bgra:
                    {


                        GL_EXT_read_format_bgra = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_read_format_bgra");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_render_snorm:
                    {


                        GL_EXT_render_snorm = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_render_snorm");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_rescale_normal:
                    {


                        GL_EXT_rescale_normal = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_rescale_normal");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_sRGB:
                    {


                        GL_EXT_sRGB = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_sRGB");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_sRGB_write_control:
                    {


                        GL_EXT_sRGB_write_control = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_sRGB_write_control");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_scene_marker:
                    {
                        __GlueBeginSceneEXT = GLFunctionLoader.LoadGLFunction<__glBeginSceneEXT>("glBeginSceneEXT");
                        __GlueEndSceneEXT = GLFunctionLoader.LoadGLFunction<__glEndSceneEXT>("glEndSceneEXT");


                        GL_EXT_scene_marker = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_scene_marker");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_secondary_color:
                    {
                        __GlueSecondaryColor3bEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3bEXT>("glSecondaryColor3bEXT");
                        __GlueSecondaryColor3bvEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3bvEXT>("glSecondaryColor3bvEXT");
                        __GlueSecondaryColor3dEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3dEXT>("glSecondaryColor3dEXT");
                        __GlueSecondaryColor3dvEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3dvEXT>("glSecondaryColor3dvEXT");
                        __GlueSecondaryColor3fEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3fEXT>("glSecondaryColor3fEXT");
                        __GlueSecondaryColor3fvEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3fvEXT>("glSecondaryColor3fvEXT");
                        __GlueSecondaryColor3iEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3iEXT>("glSecondaryColor3iEXT");
                        __GlueSecondaryColor3ivEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3ivEXT>("glSecondaryColor3ivEXT");
                        __GlueSecondaryColor3sEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3sEXT>("glSecondaryColor3sEXT");
                        __GlueSecondaryColor3svEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3svEXT>("glSecondaryColor3svEXT");
                        __GlueSecondaryColor3ubEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3ubEXT>("glSecondaryColor3ubEXT");
                        __GlueSecondaryColor3ubvEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3ubvEXT>("glSecondaryColor3ubvEXT");
                        __GlueSecondaryColor3uiEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3uiEXT>("glSecondaryColor3uiEXT");
                        __GlueSecondaryColor3uivEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3uivEXT>("glSecondaryColor3uivEXT");
                        __GlueSecondaryColor3usEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3usEXT>("glSecondaryColor3usEXT");
                        __GlueSecondaryColor3usvEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColor3usvEXT>("glSecondaryColor3usvEXT");
                        __GlueSecondaryColorPointerEXT = GLFunctionLoader.LoadGLFunction<__glSecondaryColorPointerEXT>("glSecondaryColorPointerEXT");


                        GL_EXT_secondary_color = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_secondary_color");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_semaphore:
                    {
                        __GlueDeleteSemaphoresEXT = GLFunctionLoader.LoadGLFunction<__glDeleteSemaphoresEXT>("glDeleteSemaphoresEXT");
                        __GlueGenSemaphoresEXT = GLFunctionLoader.LoadGLFunction<__glGenSemaphoresEXT>("glGenSemaphoresEXT");
                        __GlueGetSemaphoreParameterui64vEXT = GLFunctionLoader.LoadGLFunction<__glGetSemaphoreParameterui64vEXT>("glGetSemaphoreParameterui64vEXT");
                        __GlueIsSemaphoreEXT = GLFunctionLoader.LoadGLFunction<__glIsSemaphoreEXT>("glIsSemaphoreEXT");
                        __GlueSemaphoreParameterui64vEXT = GLFunctionLoader.LoadGLFunction<__glSemaphoreParameterui64vEXT>("glSemaphoreParameterui64vEXT");
                        __GlueSignalSemaphoreEXT = GLFunctionLoader.LoadGLFunction<__glSignalSemaphoreEXT>("glSignalSemaphoreEXT");
                        __GlueWaitSemaphoreEXT = GLFunctionLoader.LoadGLFunction<__glWaitSemaphoreEXT>("glWaitSemaphoreEXT");


                        GL_EXT_semaphore = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_semaphore");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_semaphore_fd:
                    {
                        __GlueImportSemaphoreFdEXT = GLFunctionLoader.LoadGLFunction<__glImportSemaphoreFdEXT>("glImportSemaphoreFdEXT");


                        GL_EXT_semaphore_fd = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_semaphore_fd");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_semaphore_win32:
                    {
                        __GlueImportSemaphoreWin32HandleEXT = GLFunctionLoader.LoadGLFunction<__glImportSemaphoreWin32HandleEXT>("glImportSemaphoreWin32HandleEXT");
                        __GlueImportSemaphoreWin32NameEXT = GLFunctionLoader.LoadGLFunction<__glImportSemaphoreWin32NameEXT>("glImportSemaphoreWin32NameEXT");


                        GL_EXT_semaphore_win32 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_semaphore_win32");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_separate_shader_objects:
                    {
                        __GlueActiveProgramEXT = GLFunctionLoader.LoadGLFunction<__glActiveProgramEXT>("glActiveProgramEXT");
                        __GlueCreateShaderProgramEXT = GLFunctionLoader.LoadGLFunction<__glCreateShaderProgramEXT>("glCreateShaderProgramEXT");
                        __GlueUseShaderProgramEXT = GLFunctionLoader.LoadGLFunction<__glUseShaderProgramEXT>("glUseShaderProgramEXT");


                        GL_EXT_separate_shader_objects = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_separate_shader_objects");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_separate_specular_color:
                    {


                        GL_EXT_separate_specular_color = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_separate_specular_color");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_framebuffer_fetch:
                    {


                        GL_EXT_shader_framebuffer_fetch = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_framebuffer_fetch");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_group_vote:
                    {


                        GL_EXT_shader_group_vote = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_group_vote");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_image_load_formatted:
                    {


                        GL_EXT_shader_image_load_formatted = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_image_load_formatted");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_image_load_store:
                    {
                        __GlueBindImageTextureEXT = GLFunctionLoader.LoadGLFunction<__glBindImageTextureEXT>("glBindImageTextureEXT");
                        __GlueMemoryBarrierEXT = GLFunctionLoader.LoadGLFunction<__glMemoryBarrierEXT>("glMemoryBarrierEXT");


                        GL_EXT_shader_image_load_store = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_image_load_store");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_implicit_conversions:
                    {


                        GL_EXT_shader_implicit_conversions = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_implicit_conversions");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_integer_mix:
                    {


                        GL_EXT_shader_integer_mix = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_integer_mix");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_io_blocks:
                    {


                        GL_EXT_shader_io_blocks = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_io_blocks");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_non_constant_global_initializers:
                    {


                        GL_EXT_shader_non_constant_global_initializers = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_non_constant_global_initializers");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_pixel_local_storage:
                    {


                        GL_EXT_shader_pixel_local_storage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_pixel_local_storage");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_pixel_local_storage2:
                    {
                        __GlueClearPixelLocalStorageuiEXT = GLFunctionLoader.LoadGLFunction<__glClearPixelLocalStorageuiEXT>("glClearPixelLocalStorageuiEXT");
                        __GlueFramebufferPixelLocalStorageSizeEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferPixelLocalStorageSizeEXT>("glFramebufferPixelLocalStorageSizeEXT");
                        __GlueGetFramebufferPixelLocalStorageSizeEXT = GLFunctionLoader.LoadGLFunction<__glGetFramebufferPixelLocalStorageSizeEXT>("glGetFramebufferPixelLocalStorageSizeEXT");


                        GL_EXT_shader_pixel_local_storage2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_pixel_local_storage2");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shader_texture_lod:
                    {


                        GL_EXT_shader_texture_lod = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shader_texture_lod");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shadow_funcs:
                    {


                        GL_EXT_shadow_funcs = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shadow_funcs");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shadow_samplers:
                    {


                        GL_EXT_shadow_samplers = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shadow_samplers");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_shared_texture_palette:
                    {


                        GL_EXT_shared_texture_palette = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_shared_texture_palette");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_sparse_texture:
                    {
                        __GlueTexPageCommitmentEXT = GLFunctionLoader.LoadGLFunction<__glTexPageCommitmentEXT>("glTexPageCommitmentEXT");
                        __GlueTexturePageCommitmentEXT = GLFunctionLoader.LoadGLFunction<__glTexturePageCommitmentEXT>("glTexturePageCommitmentEXT");


                        GL_EXT_sparse_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_sparse_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_sparse_texture2:
                    {


                        GL_EXT_sparse_texture2 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_sparse_texture2");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_stencil_clear_tag:
                    {


                        GL_EXT_stencil_clear_tag = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_stencil_clear_tag");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_stencil_two_side:
                    {
                        __GlueActiveStencilFaceEXT = GLFunctionLoader.LoadGLFunction<__glActiveStencilFaceEXT>("glActiveStencilFaceEXT");


                        GL_EXT_stencil_two_side = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_stencil_two_side");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_stencil_wrap:
                    {


                        GL_EXT_stencil_wrap = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_stencil_wrap");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_subtexture:
                    {
                        __GlueTexSubImage1DEXT = GLFunctionLoader.LoadGLFunction<__glTexSubImage1DEXT>("glTexSubImage1DEXT");
                        __GlueTexSubImage2DEXT = GLFunctionLoader.LoadGLFunction<__glTexSubImage2DEXT>("glTexSubImage2DEXT");
                        __GlueTexSubImage3DEXT = GLFunctionLoader.LoadGLFunction<__glTexSubImage3DEXT>("glTexSubImage3DEXT");


                        GL_EXT_subtexture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_subtexture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture:
                    {


                        GL_EXT_texture = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture3D:
                    {
                        __GlueTexImage3DEXT = GLFunctionLoader.LoadGLFunction<__glTexImage3DEXT>("glTexImage3DEXT");


                        GL_EXT_texture3D = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture3D");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_array:
                    {
                        __GlueFramebufferTextureLayerEXT = GLFunctionLoader.LoadGLFunction<__glFramebufferTextureLayerEXT>("glFramebufferTextureLayerEXT");


                        GL_EXT_texture_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_array");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_buffer_object:
                    {
                        __GlueTexBufferEXT = GLFunctionLoader.LoadGLFunction<__glTexBufferEXT>("glTexBufferEXT");


                        GL_EXT_texture_buffer_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_buffer_object");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_astc_decode_mode:
                    {


                        GL_EXT_texture_compression_astc_decode_mode = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_astc_decode_mode");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_astc_decode_mode_rgb9e5:
                    {


                        GL_EXT_texture_compression_astc_decode_mode_rgb9e5 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_astc_decode_mode_rgb9e5");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_bptc:
                    {


                        GL_EXT_texture_compression_bptc = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_bptc");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_dxt1:
                    {


                        GL_EXT_texture_compression_dxt1 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_dxt1");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_latc:
                    {


                        GL_EXT_texture_compression_latc = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_latc");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_rgtc:
                    {


                        GL_EXT_texture_compression_rgtc = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_rgtc");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_compression_s3tc:
                    {


                        GL_EXT_texture_compression_s3tc = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_compression_s3tc");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_cube_map:
                    {


                        GL_EXT_texture_cube_map = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_cube_map");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_cube_map_array:
                    {


                        GL_EXT_texture_cube_map_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_cube_map_array");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_edge_clamp:
                    {


                        GL_EXT_texture_edge_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_edge_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_env:
                    {


                        GL_EXT_texture_env = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_env");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_env_add:
                    {


                        GL_EXT_texture_env_add = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_env_add");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_env_combine:
                    {


                        GL_EXT_texture_env_combine = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_env_combine");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_env_dot3:
                    {


                        GL_EXT_texture_env_dot3 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_env_dot3");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_filter_anisotropic:
                    {


                        GL_EXT_texture_filter_anisotropic = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_filter_anisotropic");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_filter_minmax:
                    {


                        GL_EXT_texture_filter_minmax = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_filter_minmax");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_format_BGRA8888:
                    {


                        GL_EXT_texture_format_BGRA8888 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_format_BGRA8888");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_integer:
                    {
                        __GlueClearColorIiEXT = GLFunctionLoader.LoadGLFunction<__glClearColorIiEXT>("glClearColorIiEXT");
                        __GlueClearColorIuiEXT = GLFunctionLoader.LoadGLFunction<__glClearColorIuiEXT>("glClearColorIuiEXT");
                        __GlueGetTexParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glGetTexParameterIivEXT>("glGetTexParameterIivEXT");
                        __GlueGetTexParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glGetTexParameterIuivEXT>("glGetTexParameterIuivEXT");
                        __GlueTexParameterIivEXT = GLFunctionLoader.LoadGLFunction<__glTexParameterIivEXT>("glTexParameterIivEXT");
                        __GlueTexParameterIuivEXT = GLFunctionLoader.LoadGLFunction<__glTexParameterIuivEXT>("glTexParameterIuivEXT");


                        GL_EXT_texture_integer = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_integer");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_lod_bias:
                    {


                        GL_EXT_texture_lod_bias = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_lod_bias");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_mirror_clamp:
                    {


                        GL_EXT_texture_mirror_clamp = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_mirror_clamp");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_norm16:
                    {


                        GL_EXT_texture_norm16 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_norm16");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_object:
                    {
                        __GlueAreTexturesResidentEXT = GLFunctionLoader.LoadGLFunction<__glAreTexturesResidentEXT>("glAreTexturesResidentEXT");
                        __GlueBindTextureEXT = GLFunctionLoader.LoadGLFunction<__glBindTextureEXT>("glBindTextureEXT");
                        __GlueDeleteTexturesEXT = GLFunctionLoader.LoadGLFunction<__glDeleteTexturesEXT>("glDeleteTexturesEXT");
                        __GlueGenTexturesEXT = GLFunctionLoader.LoadGLFunction<__glGenTexturesEXT>("glGenTexturesEXT");
                        __GlueIsTextureEXT = GLFunctionLoader.LoadGLFunction<__glIsTextureEXT>("glIsTextureEXT");
                        __GluePrioritizeTexturesEXT = GLFunctionLoader.LoadGLFunction<__glPrioritizeTexturesEXT>("glPrioritizeTexturesEXT");


                        GL_EXT_texture_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_object");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_perturb_normal:
                    {
                        __GlueTextureNormalEXT = GLFunctionLoader.LoadGLFunction<__glTextureNormalEXT>("glTextureNormalEXT");


                        GL_EXT_texture_perturb_normal = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_perturb_normal");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_rectangle:
                    {


                        GL_EXT_texture_rectangle = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_rectangle");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_rg:
                    {


                        GL_EXT_texture_rg = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_rg");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_sRGB:
                    {


                        GL_EXT_texture_sRGB = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_sRGB");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_sRGB_R8:
                    {


                        GL_EXT_texture_sRGB_R8 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_sRGB_R8");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_sRGB_RG8:
                    {


                        GL_EXT_texture_sRGB_RG8 = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_sRGB_RG8");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_sRGB_decode:
                    {


                        GL_EXT_texture_sRGB_decode = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_sRGB_decode");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_shared_exponent:
                    {


                        GL_EXT_texture_shared_exponent = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_shared_exponent");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_snorm:
                    {


                        GL_EXT_texture_snorm = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_snorm");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_storage:
                    {
                        __GlueTexStorage1DEXT = GLFunctionLoader.LoadGLFunction<__glTexStorage1DEXT>("glTexStorage1DEXT");
                        __GlueTexStorage2DEXT = GLFunctionLoader.LoadGLFunction<__glTexStorage2DEXT>("glTexStorage2DEXT");
                        __GlueTexStorage3DEXT = GLFunctionLoader.LoadGLFunction<__glTexStorage3DEXT>("glTexStorage3DEXT");
                        __GlueTextureStorage1DEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorage1DEXT>("glTextureStorage1DEXT");
                        __GlueTextureStorage2DEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorage2DEXT>("glTextureStorage2DEXT");
                        __GlueTextureStorage3DEXT = GLFunctionLoader.LoadGLFunction<__glTextureStorage3DEXT>("glTextureStorage3DEXT");


                        GL_EXT_texture_storage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_storage");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_swizzle:
                    {


                        GL_EXT_texture_swizzle = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_swizzle");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_type_2_10_10_10_REV:
                    {


                        GL_EXT_texture_type_2_10_10_10_REV = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_type_2_10_10_10_REV");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_texture_view:
                    {
                        __GlueTextureViewEXT = GLFunctionLoader.LoadGLFunction<__glTextureViewEXT>("glTextureViewEXT");


                        GL_EXT_texture_view = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_texture_view");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_timer_query:
                    {
                        __GlueGetQueryObjecti64vEXT = GLFunctionLoader.LoadGLFunction<__glGetQueryObjecti64vEXT>("glGetQueryObjecti64vEXT");
                        __GlueGetQueryObjectui64vEXT = GLFunctionLoader.LoadGLFunction<__glGetQueryObjectui64vEXT>("glGetQueryObjectui64vEXT");


                        GL_EXT_timer_query = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_timer_query");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_transform_feedback:
                    {
                        __GlueBeginTransformFeedbackEXT = GLFunctionLoader.LoadGLFunction<__glBeginTransformFeedbackEXT>("glBeginTransformFeedbackEXT");
                        __GlueBindBufferBaseEXT = GLFunctionLoader.LoadGLFunction<__glBindBufferBaseEXT>("glBindBufferBaseEXT");
                        __GlueBindBufferOffsetEXT = GLFunctionLoader.LoadGLFunction<__glBindBufferOffsetEXT>("glBindBufferOffsetEXT");
                        __GlueBindBufferRangeEXT = GLFunctionLoader.LoadGLFunction<__glBindBufferRangeEXT>("glBindBufferRangeEXT");
                        __GlueEndTransformFeedbackEXT = GLFunctionLoader.LoadGLFunction<__glEndTransformFeedbackEXT>("glEndTransformFeedbackEXT");
                        __GlueGetTransformFeedbackVaryingEXT = GLFunctionLoader.LoadGLFunction<__glGetTransformFeedbackVaryingEXT>("glGetTransformFeedbackVaryingEXT");
                        __GlueTransformFeedbackVaryingsEXT = GLFunctionLoader.LoadGLFunction<__glTransformFeedbackVaryingsEXT>("glTransformFeedbackVaryingsEXT");


                        GL_EXT_transform_feedback = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_transform_feedback");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_unpack_subimage:
                    {


                        GL_EXT_unpack_subimage = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_unpack_subimage");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_vertex_array:
                    {
                        __GlueArrayElementEXT = GLFunctionLoader.LoadGLFunction<__glArrayElementEXT>("glArrayElementEXT");
                        __GlueColorPointerEXT = GLFunctionLoader.LoadGLFunction<__glColorPointerEXT>("glColorPointerEXT");
                        __GlueDrawArraysEXT = GLFunctionLoader.LoadGLFunction<__glDrawArraysEXT>("glDrawArraysEXT");
                        __GlueEdgeFlagPointerEXT = GLFunctionLoader.LoadGLFunction<__glEdgeFlagPointerEXT>("glEdgeFlagPointerEXT");
                        __GlueIndexPointerEXT = GLFunctionLoader.LoadGLFunction<__glIndexPointerEXT>("glIndexPointerEXT");
                        __GlueNormalPointerEXT = GLFunctionLoader.LoadGLFunction<__glNormalPointerEXT>("glNormalPointerEXT");
                        __GlueTexCoordPointerEXT = GLFunctionLoader.LoadGLFunction<__glTexCoordPointerEXT>("glTexCoordPointerEXT");
                        __GlueVertexPointerEXT = GLFunctionLoader.LoadGLFunction<__glVertexPointerEXT>("glVertexPointerEXT");


                        GL_EXT_vertex_array = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_vertex_array");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_vertex_array_bgra:
                    {


                        GL_EXT_vertex_array_bgra = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_vertex_array_bgra");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_vertex_array_setXXX:
                    {
                        __GlueBindArraySetEXT = GLFunctionLoader.LoadGLFunction<__glBindArraySetEXT>("glBindArraySetEXT");
                        __GlueCreateArraySetExt = GLFunctionLoader.LoadGLFunction<__glCreateArraySetExt>("glCreateArraySetExt");
                        __GlueDeleteArraySetsEXT = GLFunctionLoader.LoadGLFunction<__glDeleteArraySetsEXT>("glDeleteArraySetsEXT");


                        GL_EXT_vertex_array_setXXX = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_vertex_array_setXXX");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_vertex_attrib_64bit:
                    {
                        __GlueGetVertexAttribLdvEXT = GLFunctionLoader.LoadGLFunction<__glGetVertexAttribLdvEXT>("glGetVertexAttribLdvEXT");
                        __GlueVertexArrayVertexAttribLOffsetEXT = GLFunctionLoader.LoadGLFunction<__glVertexArrayVertexAttribLOffsetEXT>("glVertexArrayVertexAttribLOffsetEXT");
                        __GlueVertexAttribL1dEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL1dEXT>("glVertexAttribL1dEXT");
                        __GlueVertexAttribL1dvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL1dvEXT>("glVertexAttribL1dvEXT");
                        __GlueVertexAttribL2dEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL2dEXT>("glVertexAttribL2dEXT");
                        __GlueVertexAttribL2dvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL2dvEXT>("glVertexAttribL2dvEXT");
                        __GlueVertexAttribL3dEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL3dEXT>("glVertexAttribL3dEXT");
                        __GlueVertexAttribL3dvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL3dvEXT>("glVertexAttribL3dvEXT");
                        __GlueVertexAttribL4dEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL4dEXT>("glVertexAttribL4dEXT");
                        __GlueVertexAttribL4dvEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribL4dvEXT>("glVertexAttribL4dvEXT");
                        __GlueVertexAttribLPointerEXT = GLFunctionLoader.LoadGLFunction<__glVertexAttribLPointerEXT>("glVertexAttribLPointerEXT");


                        GL_EXT_vertex_attrib_64bit = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_vertex_attrib_64bit");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_vertex_shader:
                    {
                        __GlueBeginVertexShaderEXT = GLFunctionLoader.LoadGLFunction<__glBeginVertexShaderEXT>("glBeginVertexShaderEXT");
                        __GlueBindLightParameterEXT = GLFunctionLoader.LoadGLFunction<__glBindLightParameterEXT>("glBindLightParameterEXT");
                        __GlueBindMaterialParameterEXT = GLFunctionLoader.LoadGLFunction<__glBindMaterialParameterEXT>("glBindMaterialParameterEXT");
                        __GlueBindParameterEXT = GLFunctionLoader.LoadGLFunction<__glBindParameterEXT>("glBindParameterEXT");
                        __GlueBindTexGenParameterEXT = GLFunctionLoader.LoadGLFunction<__glBindTexGenParameterEXT>("glBindTexGenParameterEXT");
                        __GlueBindTextureUnitParameterEXT = GLFunctionLoader.LoadGLFunction<__glBindTextureUnitParameterEXT>("glBindTextureUnitParameterEXT");
                        __GlueBindVertexShaderEXT = GLFunctionLoader.LoadGLFunction<__glBindVertexShaderEXT>("glBindVertexShaderEXT");
                        __GlueDeleteVertexShaderEXT = GLFunctionLoader.LoadGLFunction<__glDeleteVertexShaderEXT>("glDeleteVertexShaderEXT");
                        __GlueDisableVariantClientStateEXT = GLFunctionLoader.LoadGLFunction<__glDisableVariantClientStateEXT>("glDisableVariantClientStateEXT");
                        __GlueEnableVariantClientStateEXT = GLFunctionLoader.LoadGLFunction<__glEnableVariantClientStateEXT>("glEnableVariantClientStateEXT");
                        __GlueEndVertexShaderEXT = GLFunctionLoader.LoadGLFunction<__glEndVertexShaderEXT>("glEndVertexShaderEXT");
                        __GlueExtractComponentEXT = GLFunctionLoader.LoadGLFunction<__glExtractComponentEXT>("glExtractComponentEXT");
                        __GlueGenSymbolsEXT = GLFunctionLoader.LoadGLFunction<__glGenSymbolsEXT>("glGenSymbolsEXT");
                        __GlueGenVertexShadersEXT = GLFunctionLoader.LoadGLFunction<__glGenVertexShadersEXT>("glGenVertexShadersEXT");
                        __GlueGetInvariantBooleanvEXT = GLFunctionLoader.LoadGLFunction<__glGetInvariantBooleanvEXT>("glGetInvariantBooleanvEXT");
                        __GlueGetInvariantFloatvEXT = GLFunctionLoader.LoadGLFunction<__glGetInvariantFloatvEXT>("glGetInvariantFloatvEXT");
                        __GlueGetInvariantIntegervEXT = GLFunctionLoader.LoadGLFunction<__glGetInvariantIntegervEXT>("glGetInvariantIntegervEXT");
                        __GlueGetLocalConstantBooleanvEXT = GLFunctionLoader.LoadGLFunction<__glGetLocalConstantBooleanvEXT>("glGetLocalConstantBooleanvEXT");
                        __GlueGetLocalConstantFloatvEXT = GLFunctionLoader.LoadGLFunction<__glGetLocalConstantFloatvEXT>("glGetLocalConstantFloatvEXT");
                        __GlueGetLocalConstantIntegervEXT = GLFunctionLoader.LoadGLFunction<__glGetLocalConstantIntegervEXT>("glGetLocalConstantIntegervEXT");
                        __GlueGetVariantBooleanvEXT = GLFunctionLoader.LoadGLFunction<__glGetVariantBooleanvEXT>("glGetVariantBooleanvEXT");
                        __GlueGetVariantFloatvEXT = GLFunctionLoader.LoadGLFunction<__glGetVariantFloatvEXT>("glGetVariantFloatvEXT");
                        __GlueGetVariantIntegervEXT = GLFunctionLoader.LoadGLFunction<__glGetVariantIntegervEXT>("glGetVariantIntegervEXT");
                        __GlueGetVariantPointervEXT = GLFunctionLoader.LoadGLFunction<__glGetVariantPointervEXT>("glGetVariantPointervEXT");
                        __GlueInsertComponentEXT = GLFunctionLoader.LoadGLFunction<__glInsertComponentEXT>("glInsertComponentEXT");
                        __GlueIsVariantEnabledEXT = GLFunctionLoader.LoadGLFunction<__glIsVariantEnabledEXT>("glIsVariantEnabledEXT");
                        __GlueSetInvariantEXT = GLFunctionLoader.LoadGLFunction<__glSetInvariantEXT>("glSetInvariantEXT");
                        __GlueSetLocalConstantEXT = GLFunctionLoader.LoadGLFunction<__glSetLocalConstantEXT>("glSetLocalConstantEXT");
                        __GlueShaderOp1EXT = GLFunctionLoader.LoadGLFunction<__glShaderOp1EXT>("glShaderOp1EXT");
                        __GlueShaderOp2EXT = GLFunctionLoader.LoadGLFunction<__glShaderOp2EXT>("glShaderOp2EXT");
                        __GlueShaderOp3EXT = GLFunctionLoader.LoadGLFunction<__glShaderOp3EXT>("glShaderOp3EXT");
                        __GlueSwizzleEXT = GLFunctionLoader.LoadGLFunction<__glSwizzleEXT>("glSwizzleEXT");
                        __GlueVariantPointerEXT = GLFunctionLoader.LoadGLFunction<__glVariantPointerEXT>("glVariantPointerEXT");
                        __GlueVariantbvEXT = GLFunctionLoader.LoadGLFunction<__glVariantbvEXT>("glVariantbvEXT");
                        __GlueVariantdvEXT = GLFunctionLoader.LoadGLFunction<__glVariantdvEXT>("glVariantdvEXT");
                        __GlueVariantfvEXT = GLFunctionLoader.LoadGLFunction<__glVariantfvEXT>("glVariantfvEXT");
                        __GlueVariantivEXT = GLFunctionLoader.LoadGLFunction<__glVariantivEXT>("glVariantivEXT");
                        __GlueVariantsvEXT = GLFunctionLoader.LoadGLFunction<__glVariantsvEXT>("glVariantsvEXT");
                        __GlueVariantubvEXT = GLFunctionLoader.LoadGLFunction<__glVariantubvEXT>("glVariantubvEXT");
                        __GlueVariantuivEXT = GLFunctionLoader.LoadGLFunction<__glVariantuivEXT>("glVariantuivEXT");
                        __GlueVariantusvEXT = GLFunctionLoader.LoadGLFunction<__glVariantusvEXT>("glVariantusvEXT");
                        __GlueWriteMaskEXT = GLFunctionLoader.LoadGLFunction<__glWriteMaskEXT>("glWriteMaskEXT");


                        GL_EXT_vertex_shader = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_vertex_shader");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_vertex_weighting:
                    {
                        __GlueVertexWeightPointerEXT = GLFunctionLoader.LoadGLFunction<__glVertexWeightPointerEXT>("glVertexWeightPointerEXT");
                        __GlueVertexWeightfEXT = GLFunctionLoader.LoadGLFunction<__glVertexWeightfEXT>("glVertexWeightfEXT");
                        __GlueVertexWeightfvEXT = GLFunctionLoader.LoadGLFunction<__glVertexWeightfvEXT>("glVertexWeightfvEXT");


                        GL_EXT_vertex_weighting = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_vertex_weighting");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_win32_keyed_mutex:
                    {
                        __GlueAcquireKeyedMutexWin32EXT = GLFunctionLoader.LoadGLFunction<__glAcquireKeyedMutexWin32EXT>("glAcquireKeyedMutexWin32EXT");
                        __GlueReleaseKeyedMutexWin32EXT = GLFunctionLoader.LoadGLFunction<__glReleaseKeyedMutexWin32EXT>("glReleaseKeyedMutexWin32EXT");


                        GL_EXT_win32_keyed_mutex = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_win32_keyed_mutex");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_window_rectangles:
                    {
                        __GlueWindowRectanglesEXT = GLFunctionLoader.LoadGLFunction<__glWindowRectanglesEXT>("glWindowRectanglesEXT");


                        GL_EXT_window_rectangles = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_window_rectangles");
#endif
                        break;
                    }
                case glInitHint.GL_EXT_x11_sync_object:
                    {
                        __GlueImportSyncEXT = GLFunctionLoader.LoadGLFunction<__glImportSyncEXT>("glImportSyncEXT");


                        GL_EXT_x11_sync_object = true;

#if DEBUG
	Console.WriteLine("Initialized GL_EXT_x11_sync_object");
#endif
                        break;
                    }
            }

        }

    }
}

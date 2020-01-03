using System;
using System.Runtime.InteropServices;
using System.Security;
using GlueNet.GLFW;
using System.Collections.Generic;
using static GlueNet.OpenGL.GL;

namespace GlueNet.OpenGL
{
    internal static partial class GLExtensionLoader
    {
        enum GlVersion
        {
            GL_1_1 = (1 * 1000 ) + (1 * 100),
            GL_1_2 = (1 * 1000 ) + (2 * 100),
            GL_1_2_1 = (1 * 1000) + (21 * 10),
            GL_1_3 = (1 * 1000) + (3 * 100),
            GL_1_4 = (1 * 1000) + (4 * 100),
            GL_1_5 = (1 * 1000) + (5 * 100),
                           
            GL_2_0 = (2 * 1000) + (0 * 100),
            GL_2_1 = (2 * 1000) + (1 * 100),
                                       
            GL_3_0 = (3 * 1000) + (0 * 100),
            GL_3_1 = (3 * 1000) + (1 * 100),
            GL_3_2 = (3 * 1000) + (2 * 100),
            GL_3_3 = (3 * 1000) + (3 * 100),

            GL_4_0 = (4 * 1000) + (0 * 100),
            GL_4_1 = (4 * 1000) + (1 * 100),
            GL_4_2 = (4 * 1000) + (2 * 100),
            GL_4_3 = (4 * 1000) + (3 * 100),
            GL_4_4 = (4 * 1000) + (4 * 100),
            GL_4_5 = (4 * 1000) + (5 * 100),
            GL_4_6 = (4 * 1000) + (6 * 100),

        }

        internal static void Init(in GLFW_Window window)
        {
            //_getIntegerv = GLFunctionLoader.LoadGLFunction<__getIntegerv>("glGetIntegerv");
            _glGetStringi = GLFunctionLoader.LoadGLFunction<__glGetStringi>("glGetStringi");
            //_getString = GLFunctionLoader.LoadGLFunction<__getString>("glGetString");
            unsafe
            {
                List<glInitHint> initHints = new List<glInitHint>();
                
                int numberOfExtensions = 0;
                glGetIntegerv(GL_NUM_EXTENSIONS,&numberOfExtensions);

                int ContextVersion = (window.GetAttrib(Glfw.CONTEXT_VERSION_MAJOR) * 1000) + (window.GetAttrib(Glfw.CONTEXT_VERSION_MINOR) * 100);
                //Add init hints for all the GLVersions that are supported.
                int[] glVValArr = Enum.GetValues(typeof(GlVersion)) as int[];

                for (int i = 0; i < glVValArr.Length; i++)
                    if (glVValArr[i] <= ContextVersion)
                        initHints.Add(GLVersionToInitHint((GlVersion)glVValArr[i]));

                //Add init hints for all the supported extensions.
                for (int i = 0; i < numberOfExtensions; i++)
                {
                    string s = glGetStringi(GL_EXTENSIONS, i);
                    try
                    {
                        initHints.Add(GlExtensionNameToInitHint(s));
                    } catch
                    {
                        continue;
                    }
                }
                

                foreach (glInitHint glih in initHints)
                    InitGlDefinition(glih);

            }
        }

        static void InitGlDefinition(glInitHint initHint)
        {
            switch (initHint)
            {
                case glInitHint.GL_VERSION_1_1: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_1_2: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_1_2_1: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_1_3: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_1_4: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_1_5: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_2_0: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_2_1: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_3_0: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_3_1: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_3_2: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_3_3: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_0: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_1: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_2: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_3: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_4: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_5: GL.Init(initHint); break;
                case glInitHint.GL_VERSION_4_6: GL.Init(initHint); break;

                    /*
                case glInitHint.GL_3DFX_multisample: GL_3DFX.Init(initHint); break;
                case glInitHint.GL_3DFX_tbuffer: GL_3DFX.Init(initHint); break;
                case glInitHint.GL_3DFX_texture_compression_FXT1: GL_3DFX.Init(initHint); break;
                case glInitHint.GL_AMD_blend_minmax_factor: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_compressed_3DC_texture: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_compressed_ATC_texture: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_conservative_depth: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_debug_output: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_depth_clamp_separate: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_draw_buffers_blend: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_framebuffer_sample_positions: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_gcn_shader: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_gpu_shader_half_float: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_gpu_shader_int16: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_gpu_shader_int64: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_interleaved_elements: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_multi_draw_indirect: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_name_gen_delete: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_occlusion_query_event: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_performance_monitor: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_pinned_memory: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_program_binary_Z400: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_query_buffer_object: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_sample_positions: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_seamless_cubemap_per_texture: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_shader_atomic_counter_ops: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_shader_ballot: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_shader_explicit_vertex_parameter: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_shader_stencil_export: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_shader_stencil_value_export: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_shader_trinary_minmax: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_sparse_texture: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_stencil_operation_extended: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_texture_gather_bias_lod: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_texture_texture4: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_transform_feedback3_lines_triangles: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_transform_feedback4: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_vertex_shader_layer: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_vertex_shader_tessellator: GL_AMD.Init(initHint); break;
                case glInitHint.GL_AMD_vertex_shader_viewport_index: GL_AMD.Init(initHint); break;
                case glInitHint.GL_ANDROID_extension_pack_es31a: GL_ANDROID.Init(initHint); break;
                case glInitHint.GL_ANGLE_depth_texture: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_framebuffer_blit: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_framebuffer_multisample: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_instanced_arrays: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_pack_reverse_row_order: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_program_binary: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_texture_compression_dxt1: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_texture_compression_dxt3: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_texture_compression_dxt5: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_texture_usage: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_timer_query: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_ANGLE_translated_shader_source: GL_ANGLE.Init(initHint); break;
                case glInitHint.GL_APPLE_aux_depth_stencil: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_client_storage: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_clip_distance: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_color_buffer_packed_float: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_copy_texture_levels: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_element_array: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_fence: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_float_pixels: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_flush_buffer_range: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_framebuffer_multisample: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_object_purgeable: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_pixel_buffer: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_rgb_422: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_row_bytes: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_specular_vector: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_sync: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_texture_2D_limited_npot: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_texture_format_BGRA8888: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_texture_max_level: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_texture_packed_float: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_texture_range: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_transform_hint: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_vertex_array_object: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_vertex_array_range: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_vertex_program_evaluators: GL_APPLE.Init(initHint); break;
                case glInitHint.GL_APPLE_ycbcr_422: GL_APPLE.Init(initHint); break;

                    */
                case glInitHint.GL_ARB_ES2_compatibility: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_ES3_1_compatibility: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_ES3_2_compatibility: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_ES3_compatibility: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_arrays_of_arrays: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_base_instance: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_bindless_texture: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_blend_func_extended: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_buffer_storage: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_cl_event: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_clear_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_clear_texture: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_clip_control: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_color_buffer_float: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_compatibility: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_compressed_texture_pixel_storage: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_compute_shader: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_compute_variable_group_size: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_conditional_render_inverted: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_conservative_depth: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_copy_buffer: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_copy_image: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_cull_distance: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_debug_output: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_depth_buffer_float: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_depth_clamp: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_depth_texture: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_derivative_control: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_direct_state_access: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_draw_buffers: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_draw_buffers_blend: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_draw_elements_base_vertex: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_draw_indirect: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_draw_instanced: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_enhanced_layouts: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_explicit_attrib_location: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_explicit_uniform_location: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_fragment_coord_conventions: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_fragment_layer_viewport: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_fragment_program: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_fragment_program_shadow: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_fragment_shader: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_fragment_shader_interlock: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_framebuffer_no_attachments: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_framebuffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_framebuffer_sRGB: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_geometry_shader4: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_get_program_binary: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_get_texture_sub_image: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_gl_spirv: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_gpu_shader5: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_gpu_shader_fp64: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_gpu_shader_int64: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_half_float_pixel: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_half_float_vertex: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_imaging: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_indirect_parameters: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_instanced_arrays: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_internalformat_query: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_internalformat_query2: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_invalidate_subdata: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_map_buffer_alignment: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_map_buffer_range: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_matrix_palette: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_multi_bind: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_multi_draw_indirect: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_multisample: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_multitexture: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_occlusion_query: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_occlusion_query2: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_parallel_shader_compile: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_pipeline_statistics_query: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_pixel_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_point_parameters: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_point_sprite: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_polygon_offset_clamp: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_post_depth_coverage: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_program_interface_query: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_provoking_vertex: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_query_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_robust_buffer_access_behavior: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_robustness: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_robustness_application_isolation: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_robustness_share_group_isolation: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sample_locations: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sample_shading: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sampler_objects: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_seamless_cube_map: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_seamless_cubemap_per_texture: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_separate_shader_objects: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_atomic_counter_ops: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_atomic_counters: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_ballot: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_bit_encoding: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_clock: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_draw_parameters: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_group_vote: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_image_load_store: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_image_size: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_objects: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_precision: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_stencil_export: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_storage_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_subroutine: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_texture_image_samples: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_texture_lod: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shader_viewport_layer_array: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shading_language_100: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shading_language_420pack: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shading_language_include: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shading_language_packing: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shadow: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_shadow_ambient: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sparse_buffer: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sparse_texture: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sparse_texture2: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sparse_texture_clamp: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_spirv_extensions: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_stencil_texturing: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_sync: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_tessellation_shader: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_barrier: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_border_clamp: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_buffer_object_rgb32: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_buffer_range: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_compression: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_compression_bptc: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_compression_rgtc: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_cube_map: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_cube_map_array: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_env_add: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_env_combine: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_env_crossbar: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_env_dot3: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_filter_anisotropic: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_filter_minmax: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_float: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_gather: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_mirror_clamp_to_edge: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_mirrored_repeat: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_multisample: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_non_power_of_two: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_query_levels: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_query_lod: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_rectangle: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_rg: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_rgb10_a2ui: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_stencil8: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_storage: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_storage_multisample: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_swizzle: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_texture_view: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_timer_query: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_transform_feedback2: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_transform_feedback3: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_transform_feedback_instanced: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_transform_feedback_overflow_query: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_transpose_matrix: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_uniform_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_array_bgra: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_array_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_attrib_64bit: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_attrib_binding: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_blend: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_buffer_object: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_program: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_shader: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_type_10f_11f_11f_rev: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_vertex_type_2_10_10_10_rev: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_viewport_array: GL_ARB.Init(initHint); break;
                case glInitHint.GL_ARB_window_pos: GL_ARB.Init(initHint); break;

                    /*
                case glInitHint.GL_ARM_mali_program_binary: GL_ARM.Init(initHint); break;
                case glInitHint.GL_ARM_mali_shader_binary: GL_ARM.Init(initHint); break;
                case glInitHint.GL_ARM_rgba8: GL_ARM.Init(initHint); break;
                case glInitHint.GL_ARM_shader_framebuffer_fetch: GL_ARM.Init(initHint); break;
                case glInitHint.GL_ARM_shader_framebuffer_fetch_depth_stencil: GL_ARM.Init(initHint); break;
                case glInitHint.GL_ATIX_point_sprites: GL_ATIX.Init(initHint); break;
                case glInitHint.GL_ATIX_texture_env_combine3: GL_ATIX.Init(initHint); break;
                case glInitHint.GL_ATIX_texture_env_route: GL_ATIX.Init(initHint); break;
                case glInitHint.GL_ATIX_vertex_shader_output_point_size: GL_ATIX.Init(initHint); break;
                case glInitHint.GL_ATI_draw_buffers: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_element_array: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_envmap_bumpmap: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_fragment_shader: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_map_object_buffer: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_meminfo: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_pn_triangles: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_separate_stencil: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_shader_texture_lod: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_text_fragment_shader: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_texture_compression_3dc: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_texture_env_combine3: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_texture_float: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_texture_mirror_once: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_vertex_array_object: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_vertex_attrib_array_object: GL_ATI.Init(initHint); break;
                case glInitHint.GL_ATI_vertex_streams: GL_ATI.Init(initHint); break;
                case glInitHint.GL_EGL_KHR_context_flush_control: GL_EGL.Init(initHint); break;
                case glInitHint.GL_EGL_NV_robustness_video_memory_purge: GL_EGL.Init(initHint); break;
                    */

                case glInitHint.GL_EXT_422_pixels: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_Cg_shader: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_EGL_image_array: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_YUV_target: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_abgr: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_base_instance: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_bgra: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_bindable_uniform: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_color: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_equation_separate: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_func_extended: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_func_separate: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_logic_op: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_minmax: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_blend_subtract: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_buffer_storage: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_clear_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_clip_cull_distance: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_clip_volume_hint: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_cmyka: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_color_buffer_float: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_color_buffer_half_float: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_color_subtable: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_compiled_vertex_array: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_compressed_ETC1_RGB8_sub_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_conservative_depth: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_convolution: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_coordinate_frame: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_copy_image: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_copy_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_cull_vertex: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_debug_label: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_debug_marker: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_depth_bounds_test: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_direct_state_access: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_discard_framebuffer: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_draw_buffers: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_draw_buffers2: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_draw_buffers_indexed: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_draw_elements_base_vertex: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_draw_instanced: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_draw_range_elements: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_external_buffer: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_float_blend: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_fog_coord: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_frag_depth: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_fragment_lighting: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_framebuffer_blit: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_framebuffer_multisample: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_framebuffer_multisample_blit_scaled: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_framebuffer_object: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_framebuffer_sRGB: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_geometry_point_size: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_geometry_shader: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_geometry_shader4: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_gpu_program_parameters: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_gpu_shader4: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_gpu_shader5: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_histogram: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_index_array_formats: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_index_func: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_index_material: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_index_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_instanced_arrays: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_light_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_map_buffer_range: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_memory_object: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_memory_object_fd: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_memory_object_win32: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_misc_attribute: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multi_draw_arrays: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multi_draw_indirect: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multiple_textures: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multisample: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multisample_compatibility: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multisampled_render_to_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multisampled_render_to_texture2: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_multiview_draw_buffers: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_packed_depth_stencil: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_packed_float: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_packed_pixels: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_paletted_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_pixel_buffer_object: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_pixel_transform: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_pixel_transform_color_table: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_point_parameters: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_polygon_offset: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_polygon_offset_clamp: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_post_depth_coverage: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_provoking_vertex: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_pvrtc_sRGB: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_raster_multisample: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_read_format_bgra: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_render_snorm: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_rescale_normal: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_sRGB: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_sRGB_write_control: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_scene_marker: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_secondary_color: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_semaphore: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_semaphore_fd: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_semaphore_win32: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_separate_shader_objects: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_separate_specular_color: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_framebuffer_fetch: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_group_vote: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_image_load_formatted: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_image_load_store: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_implicit_conversions: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_integer_mix: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_io_blocks: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_non_constant_global_initializers: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_pixel_local_storage: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_pixel_local_storage2: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shader_texture_lod: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shadow_funcs: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shadow_samplers: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_shared_texture_palette: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_sparse_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_sparse_texture2: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_stencil_clear_tag: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_stencil_two_side: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_stencil_wrap: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_subtexture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture3D: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_array: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_buffer_object: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_astc_decode_mode: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_astc_decode_mode_rgb9e5: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_bptc: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_dxt1: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_latc: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_rgtc: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_compression_s3tc: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_cube_map: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_cube_map_array: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_edge_clamp: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_env: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_env_add: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_env_combine: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_env_dot3: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_filter_anisotropic: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_filter_minmax: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_format_BGRA8888: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_integer: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_lod_bias: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_mirror_clamp: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_norm16: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_object: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_perturb_normal: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_rectangle: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_rg: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_sRGB: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_sRGB_R8: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_sRGB_RG8: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_sRGB_decode: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_shared_exponent: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_snorm: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_storage: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_swizzle: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_type_2_10_10_10_REV: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_texture_view: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_timer_query: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_transform_feedback: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_unpack_subimage: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_vertex_array: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_vertex_array_bgra: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_vertex_array_setXXX: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_vertex_attrib_64bit: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_vertex_shader: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_vertex_weighting: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_win32_keyed_mutex: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_window_rectangles: GL_EXT.Init(initHint); break;
                case glInitHint.GL_EXT_x11_sync_object: GL_EXT.Init(initHint); break;

                    /*
                case glInitHint.GL_GREMEDY_frame_terminator: GL_GREMEDY.Init(initHint); break;
                case glInitHint.GL_GREMEDY_string_marker: GL_GREMEDY.Init(initHint); break;
                case glInitHint.GL_HP_convolution_border_modes: GL_HP.Init(initHint); break;
                case glInitHint.GL_HP_image_transform: GL_HP.Init(initHint); break;
                case glInitHint.GL_HP_occlusion_test: GL_HP.Init(initHint); break;
                case glInitHint.GL_HP_texture_lighting: GL_HP.Init(initHint); break;
                case glInitHint.GL_IBM_cull_vertex: GL_IBM.Init(initHint); break;
                case glInitHint.GL_IBM_multimode_draw_arrays: GL_IBM.Init(initHint); break;
                case glInitHint.GL_IBM_rasterpos_clip: GL_IBM.Init(initHint); break;
                case glInitHint.GL_IBM_static_data: GL_IBM.Init(initHint); break;
                case glInitHint.GL_IBM_texture_mirrored_repeat: GL_IBM.Init(initHint); break;
                case glInitHint.GL_IBM_vertex_array_lists: GL_IBM.Init(initHint); break;
                case glInitHint.GL_INGR_color_clamp: GL_INGR.Init(initHint); break;
                case glInitHint.GL_INGR_interlace_read: GL_INGR.Init(initHint); break;
                case glInitHint.GL_INTEL_conservative_rasterization: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_INTEL_fragment_shader_ordering: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_INTEL_framebuffer_CMAA: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_INTEL_map_texture: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_INTEL_parallel_arrays: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_INTEL_performance_query: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_INTEL_texture_scissor: GL_INTEL.Init(initHint); break;
                case glInitHint.GL_KHR_blend_equation_advanced: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_blend_equation_advanced_coherent: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_context_flush_control: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_debug: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_no_error: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_parallel_shader_compile: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_robust_buffer_access_behavior: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_robustness: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_texture_compression_astc_hdr: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_texture_compression_astc_ldr: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KHR_texture_compression_astc_sliced_3d: GL_KHR.Init(initHint); break;
                case glInitHint.GL_KTX_buffer_region: GL_KTX.Init(initHint); break;
                case glInitHint.GL_MESAX_texture_stack: GL_MESAX.Init(initHint); break;
                case glInitHint.GL_MESA_pack_invert: GL_MESA.Init(initHint); break;
                case glInitHint.GL_MESA_resize_buffers: GL_MESA.Init(initHint); break;
                case glInitHint.GL_MESA_shader_integer_functions: GL_MESA.Init(initHint); break;
                case glInitHint.GL_MESA_window_pos: GL_MESA.Init(initHint); break;
                case glInitHint.GL_MESA_ycbcr_texture: GL_MESA.Init(initHint); break;
                case glInitHint.GL_NVX_blend_equation_advanced_multi_draw_buffers: GL_NVX.Init(initHint); break;
                case glInitHint.GL_NVX_conditional_render: GL_NVX.Init(initHint); break;
                case glInitHint.GL_NVX_gpu_memory_info: GL_NVX.Init(initHint); break;
                case glInitHint.GL_NVX_linked_gpu_multicast: GL_NVX.Init(initHint); break;
                case glInitHint.GL_NV_3dvision_settings: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_EGL_stream_consumer_external: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_alpha_to_coverage_dither_control: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_bgr: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_bindless_multi_draw_indirect: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_bindless_multi_draw_indirect_count: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_bindless_texture: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_blend_equation_advanced: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_blend_equation_advanced_coherent: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_blend_minmax_factor: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_blend_square: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_clip_space_w_scaling: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_command_list: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_compute_program5: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_conditional_render: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_conservative_raster: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_conservative_raster_dilate: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_conservative_raster_pre_snap_triangles: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_copy_buffer: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_copy_depth_to_color: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_copy_image: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_deep_texture3D: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_depth_buffer_float: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_depth_clamp: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_depth_range_unclamped: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_draw_buffers: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_draw_instanced: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_draw_texture: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_draw_vulkan_image: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_evaluators: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_explicit_attrib_location: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_explicit_multisample: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fbo_color_attachments: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fence: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fill_rectangle: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_float_buffer: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fog_distance: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fragment_coverage_to_color: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fragment_program: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fragment_program2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fragment_program4: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fragment_program_option: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_fragment_shader_interlock: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_framebuffer_blit: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_framebuffer_mixed_samples: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_framebuffer_multisample: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_framebuffer_multisample_coverage: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_generate_mipmap_sRGB: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_geometry_program4: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_geometry_shader4: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_geometry_shader_passthrough: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_gpu_multicast: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_gpu_program4: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_gpu_program5: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_gpu_program5_mem_extended: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_gpu_program_fp64: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_gpu_shader5: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_half_float: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_image_formats: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_instanced_arrays: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_internalformat_sample_query: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_light_max_exponent: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_multisample_coverage: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_multisample_filter_hint: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_non_square_matrices: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_occlusion_query: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_pack_subimage: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_packed_depth_stencil: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_packed_float: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_packed_float_linear: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_parameter_buffer_object: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_parameter_buffer_object2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_path_rendering: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_path_rendering_shared_edge: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_pixel_buffer_object: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_pixel_data_range: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_platform_binary: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_point_sprite: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_polygon_mode: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_present_video: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_primitive_restart: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_read_depth: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_read_depth_stencil: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_read_stencil: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_register_combiners: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_register_combiners2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_robustness_video_memory_purge: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_sRGB_formats: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_sample_locations: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_sample_mask_override_coverage: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_atomic_counters: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_atomic_float: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_atomic_float64: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_atomic_fp16_vector: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_atomic_int64: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_buffer_load: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_noperspective_interpolation: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_storage_buffer_object: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_thread_group: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shader_thread_shuffle: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shadow_samplers_array: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_shadow_samplers_cube: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_stereo_view_rendering: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_tessellation_program5: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texgen_emboss: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texgen_reflection: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_array: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_barrier: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_border_clamp: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_compression_latc: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_compression_s3tc: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_compression_s3tc_update: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_compression_vtc: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_env_combine4: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_expand_normal: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_multisample: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_npot_2D_mipmap: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_rectangle: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_rectangle_compressed: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_shader: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_shader2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_texture_shader3: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_transform_feedback: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_transform_feedback2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_uniform_buffer_unified_memory: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vdpau_interop: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_array_range: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_array_range2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_attrib_integer_64bit: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_buffer_unified_memory: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_program: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_program1_1: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_program2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_program2_option: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_program3: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_vertex_program4: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_video_capture: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_viewport_array: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_viewport_array2: GL_NV.Init(initHint); break;
                case glInitHint.GL_NV_viewport_swizzle: GL_NV.Init(initHint); break;
                case glInitHint.GL_OES_byte_coordinates: GL_OES.Init(initHint); break;
                case glInitHint.GL_OML_interlace: GL_OML.Init(initHint); break;
                case glInitHint.GL_OML_resample: GL_OML.Init(initHint); break;
                case glInitHint.GL_OML_subsample: GL_OML.Init(initHint); break;
                case glInitHint.GL_OVR_multiview: GL_OVR.Init(initHint); break;
                case glInitHint.GL_OVR_multiview2: GL_OVR.Init(initHint); break;
                case glInitHint.GL_OVR_multiview_multisampled_render_to_texture: GL_OVR.Init(initHint); break;
                case glInitHint.GL_PGI_misc_hints: GL_PGI.Init(initHint); break;
                case glInitHint.GL_PGI_vertex_hints: GL_PGI.Init(initHint); break;
                case glInitHint.GL_QCOM_alpha_test: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_binning_control: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_driver_control: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_extended_get: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_extended_get2: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_framebuffer_foveated: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_perfmon_global_mode: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_shader_framebuffer_fetch_noncoherent: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_tiled_rendering: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_QCOM_writeonly_rendering: GL_QCOM.Init(initHint); break;
                case glInitHint.GL_REGAL_ES1_0_compatibility: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REGAL_ES1_1_compatibility: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REGAL_enable: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REGAL_error_string: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REGAL_extension_query: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REGAL_log: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REGAL_proc_address: GL_REGAL.Init(initHint); break;
                case glInitHint.GL_REND_screen_coordinates: GL_REND.Init(initHint); break;
                case glInitHint.GL_S3_s3tc: GL_S3.Init(initHint); break;
                case glInitHint.GL_SGIS_clip_band_hint: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_color_range: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_detail_texture: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_fog_function: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_generate_mipmap: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_line_texgen: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_multisample: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_multitexture: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_pixel_texture: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_point_line_texgen: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_shared_multisample: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_sharpen_texture: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_texture4D: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_texture_border_clamp: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_texture_edge_clamp: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_texture_filter4: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_texture_lod: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIS_texture_select: GL_SGIS.Init(initHint); break;
                case glInitHint.GL_SGIX_async: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_async_histogram: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_async_pixel: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_bali_g_instruments: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_bali_r_instruments: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_bali_timer_instruments: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_blend_alpha_minmax: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_blend_cadd: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_blend_cmultiply: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_calligraphic_fragment: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_clipmap: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_color_matrix_accuracy: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_color_table_index_mode: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_complex_polar: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_convolution_accuracy: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_cube_map: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_cylinder_texgen: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_datapipe: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_decimation: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_depth_pass_instrument: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_depth_texture: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_dvc: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_flush_raster: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_blend: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_factor_to_alpha: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_layers: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_offset: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_patchy: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_scale: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fog_texture: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fragment_lighting_space: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fragment_specular_lighting: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_fragments_instrument: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_framezoom: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_icc_texture: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_igloo_interface: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_image_compression: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_impact_pixel_texture: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_instrument_error: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_interlace: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_ir_instrument1: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_line_quality_hint: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_list_priority: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_mpeg1: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_mpeg2: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_nonlinear_lighting_pervertex: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_nurbs_eval: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_occlusion_instrument: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_packed_6bytes: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_pixel_texture: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_pixel_texture_bits: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_pixel_texture_lod: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_pixel_tiles: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_polynomial_ffd: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_quad_mesh: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_reference_plane: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_resample: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_scalebias_hint: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_shadow: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_shadow_ambient: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_slim: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_spotlight_cutoff: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_sprite: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_subdiv_patch: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_subsample: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_tag_sample_buffer: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_add_env: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_coordinate_clamp: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_lod_bias: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_mipmap_anisotropic: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_multi_buffer: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_phase: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_range: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_scale_bias: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_texture_supersample: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_vector_ops: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_vertex_array_object: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_vertex_preclip: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_vertex_preclip_hint: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_ycrcb: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_ycrcb_subsample: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGIX_ycrcba: GL_SGIX.Init(initHint); break;
                case glInitHint.GL_SGI_color_matrix: GL_SGI.Init(initHint); break;
                case glInitHint.GL_SGI_color_table: GL_SGI.Init(initHint); break;
                case glInitHint.GL_SGI_complex: GL_SGI.Init(initHint); break;
                case glInitHint.GL_SGI_complex_type: GL_SGI.Init(initHint); break;
                case glInitHint.GL_SGI_fft: GL_SGI.Init(initHint); break;
                case glInitHint.GL_SGI_texture_color_table: GL_SGI.Init(initHint); break;
                case glInitHint.GL_SUNX_constant_data: GL_SUNX.Init(initHint); break;
                case glInitHint.GL_SUN_convolution_border_modes: GL_SUN.Init(initHint); break;
                case glInitHint.GL_SUN_global_alpha: GL_SUN.Init(initHint); break;
                case glInitHint.GL_SUN_mesh_array: GL_SUN.Init(initHint); break;
                case glInitHint.GL_SUN_read_video_pixels: GL_SUN.Init(initHint); break;
                case glInitHint.GL_SUN_slice_accum: GL_SUN.Init(initHint); break;
                case glInitHint.GL_SUN_triangle_list: GL_SUN.Init(initHint); break;
                case glInitHint.GL_SUN_vertex: GL_SUN.Init(initHint); break;
                case glInitHint.GL_WIN_phong_shading: GL_WIN.Init(initHint); break;
                case glInitHint.GL_WIN_scene_markerXXX: GL_WIN.Init(initHint); break;
                case glInitHint.GL_WIN_specular_fog: GL_WIN.Init(initHint); break;
                case glInitHint.GL_WIN_swap_hint: GL_WIN.Init(initHint); break;

    */
            }
        }

        static glInitHint GLVersionToInitHint(GlVersion glv)
        {
            switch (glv)
            {
                case GlVersion.GL_1_1: return glInitHint.GL_VERSION_1_1;
                case GlVersion.GL_1_2: return glInitHint.GL_VERSION_1_2;
                case GlVersion.GL_1_2_1: return glInitHint.GL_VERSION_1_2_1;
                case GlVersion.GL_1_3: return glInitHint.GL_VERSION_1_3;
                case GlVersion.GL_1_4: return glInitHint.GL_VERSION_1_4;
                case GlVersion.GL_1_5: return glInitHint.GL_VERSION_1_5;

                case GlVersion.GL_2_0: return glInitHint.GL_VERSION_2_0;
                case GlVersion.GL_2_1: return glInitHint.GL_VERSION_2_1;

                case GlVersion.GL_3_0: return glInitHint.GL_VERSION_3_0;
                case GlVersion.GL_3_1: return glInitHint.GL_VERSION_3_1;
                case GlVersion.GL_3_2: return glInitHint.GL_VERSION_3_2;
                case GlVersion.GL_3_3: return glInitHint.GL_VERSION_3_3;

                case GlVersion.GL_4_0: return glInitHint.GL_VERSION_4_0;
                case GlVersion.GL_4_1: return glInitHint.GL_VERSION_4_1;
                case GlVersion.GL_4_2: return glInitHint.GL_VERSION_4_2;
                case GlVersion.GL_4_3: return glInitHint.GL_VERSION_4_3;
                case GlVersion.GL_4_4: return glInitHint.GL_VERSION_4_4;
                case GlVersion.GL_4_5: return glInitHint.GL_VERSION_4_5;
                case GlVersion.GL_4_6: return glInitHint.GL_VERSION_4_6;

                default: throw new ArgumentNullException();
            }
        }

        

        [DllImport("opengl32.dll" ,CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        internal static unsafe extern void glGetIntegerv(int pname, int* parameters);

        [SuppressUnmanagedCodeSecurity]
        internal static unsafe string glGetStringi(int pname, int index)
        {
            byte* str = _glGetStringi(pname, index);
            return Marshal.PtrToStringAnsi((IntPtr)str);
        }

        static __glGetStringi _glGetStringi;
        [SuppressUnmanagedCodeSecurity]
        unsafe delegate byte* __glGetStringi(int pname, int index);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.OpenGL
{
    internal enum glInitHint
    {
        GL_VERSION_1_1 = 0,
        GL_VERSION_1_2 = 1,
        GL_VERSION_1_2_1 = 2,
        GL_VERSION_1_3 = 3,
        GL_VERSION_1_4 = 4,
        GL_VERSION_1_5 = 5,
        GL_VERSION_2_0 = 6,
        GL_VERSION_2_1 = 7,
        GL_VERSION_3_0 = 8,
        GL_VERSION_3_1 = 9,
        GL_VERSION_3_2 = 10,
        GL_VERSION_3_3 = 11,
        GL_VERSION_4_0 = 12,
        GL_VERSION_4_1 = 13,
        GL_VERSION_4_2 = 14,
        GL_VERSION_4_3 = 15,
        GL_VERSION_4_4 = 16,
        GL_VERSION_4_5 = 17,
        GL_VERSION_4_6 = 18,
        GL_3DFX_multisample = 19,
        GL_3DFX_tbuffer = 20,
        GL_3DFX_texture_compression_FXT1 = 21,
        GL_AMD_blend_minmax_factor = 22,
        GL_AMD_compressed_3DC_texture = 23,
        GL_AMD_compressed_ATC_texture = 24,
        GL_AMD_conservative_depth = 25,
        GL_AMD_debug_output = 26,
        GL_AMD_depth_clamp_separate = 27,
        GL_AMD_draw_buffers_blend = 28,
        GL_AMD_framebuffer_sample_positions = 29,
        GL_AMD_gcn_shader = 30,
        GL_AMD_gpu_shader_half_float = 31,
        GL_AMD_gpu_shader_int16 = 32,
        GL_AMD_gpu_shader_int64 = 33,
        GL_AMD_interleaved_elements = 34,
        GL_AMD_multi_draw_indirect = 35,
        GL_AMD_name_gen_delete = 36,
        GL_AMD_occlusion_query_event = 37,
        GL_AMD_performance_monitor = 38,
        GL_AMD_pinned_memory = 39,
        GL_AMD_program_binary_Z400 = 40,
        GL_AMD_query_buffer_object = 41,
        GL_AMD_sample_positions = 42,
        GL_AMD_seamless_cubemap_per_texture = 43,
        GL_AMD_shader_atomic_counter_ops = 44,
        GL_AMD_shader_ballot = 45,
        GL_AMD_shader_explicit_vertex_parameter = 46,
        GL_AMD_shader_stencil_export = 47,
        GL_AMD_shader_stencil_value_export = 48,
        GL_AMD_shader_trinary_minmax = 49,
        GL_AMD_sparse_texture = 50,
        GL_AMD_stencil_operation_extended = 51,
        GL_AMD_texture_gather_bias_lod = 52,
        GL_AMD_texture_texture4 = 53,
        GL_AMD_transform_feedback3_lines_triangles = 54,
        GL_AMD_transform_feedback4 = 55,
        GL_AMD_vertex_shader_layer = 56,
        GL_AMD_vertex_shader_tessellator = 57,
        GL_AMD_vertex_shader_viewport_index = 58,
        GL_ANDROID_extension_pack_es31a = 59,
        GL_ANGLE_depth_texture = 60,
        GL_ANGLE_framebuffer_blit = 61,
        GL_ANGLE_framebuffer_multisample = 62,
        GL_ANGLE_instanced_arrays = 63,
        GL_ANGLE_pack_reverse_row_order = 64,
        GL_ANGLE_program_binary = 65,
        GL_ANGLE_texture_compression_dxt1 = 66,
        GL_ANGLE_texture_compression_dxt3 = 67,
        GL_ANGLE_texture_compression_dxt5 = 68,
        GL_ANGLE_texture_usage = 69,
        GL_ANGLE_timer_query = 70,
        GL_ANGLE_translated_shader_source = 71,
        GL_APPLE_aux_depth_stencil = 72,
        GL_APPLE_client_storage = 73,
        GL_APPLE_clip_distance = 74,
        GL_APPLE_color_buffer_packed_float = 75,
        GL_APPLE_copy_texture_levels = 76,
        GL_APPLE_element_array = 77,
        GL_APPLE_fence = 78,
        GL_APPLE_float_pixels = 79,
        GL_APPLE_flush_buffer_range = 80,
        GL_APPLE_framebuffer_multisample = 81,
        GL_APPLE_object_purgeable = 82,
        GL_APPLE_pixel_buffer = 83,
        GL_APPLE_rgb_422 = 84,
        GL_APPLE_row_bytes = 85,
        GL_APPLE_specular_vector = 86,
        GL_APPLE_sync = 87,
        GL_APPLE_texture_2D_limited_npot = 88,
        GL_APPLE_texture_format_BGRA8888 = 89,
        GL_APPLE_texture_max_level = 90,
        GL_APPLE_texture_packed_float = 91,
        GL_APPLE_texture_range = 92,
        GL_APPLE_transform_hint = 93,
        GL_APPLE_vertex_array_object = 94,
        GL_APPLE_vertex_array_range = 95,
        GL_APPLE_vertex_program_evaluators = 96,
        GL_APPLE_ycbcr_422 = 97,
        GL_ARB_ES2_compatibility = 98,
        GL_ARB_ES3_1_compatibility = 99,
        GL_ARB_ES3_2_compatibility = 100,
        GL_ARB_ES3_compatibility = 101,
        GL_ARB_arrays_of_arrays = 102,
        GL_ARB_base_instance = 103,
        GL_ARB_bindless_texture = 104,
        GL_ARB_blend_func_extended = 105,
        GL_ARB_buffer_storage = 106,
        GL_ARB_cl_event = 107,
        GL_ARB_clear_buffer_object = 108,
        GL_ARB_clear_texture = 109,
        GL_ARB_clip_control = 110,
        GL_ARB_color_buffer_float = 111,
        GL_ARB_compatibility = 112,
        GL_ARB_compressed_texture_pixel_storage = 113,
        GL_ARB_compute_shader = 114,
        GL_ARB_compute_variable_group_size = 115,
        GL_ARB_conditional_render_inverted = 116,
        GL_ARB_conservative_depth = 117,
        GL_ARB_copy_buffer = 118,
        GL_ARB_copy_image = 119,
        GL_ARB_cull_distance = 120,
        GL_ARB_debug_output = 121,
        GL_ARB_depth_buffer_float = 122,
        GL_ARB_depth_clamp = 123,
        GL_ARB_depth_texture = 124,
        GL_ARB_derivative_control = 125,
        GL_ARB_direct_state_access = 126,
        GL_ARB_draw_buffers = 127,
        GL_ARB_draw_buffers_blend = 128,
        GL_ARB_draw_elements_base_vertex = 129,
        GL_ARB_draw_indirect = 130,
        GL_ARB_draw_instanced = 131,
        GL_ARB_enhanced_layouts = 132,
        GL_ARB_explicit_attrib_location = 133,
        GL_ARB_explicit_uniform_location = 134,
        GL_ARB_fragment_coord_conventions = 135,
        GL_ARB_fragment_layer_viewport = 136,
        GL_ARB_fragment_program = 137,
        GL_ARB_fragment_program_shadow = 138,
        GL_ARB_fragment_shader = 139,
        GL_ARB_fragment_shader_interlock = 140,
        GL_ARB_framebuffer_no_attachments = 141,
        GL_ARB_framebuffer_object = 142,
        GL_ARB_framebuffer_sRGB = 143,
        GL_ARB_geometry_shader4 = 144,
        GL_ARB_get_program_binary = 145,
        GL_ARB_get_texture_sub_image = 146,
        GL_ARB_gl_spirv = 147,
        GL_ARB_gpu_shader5 = 148,
        GL_ARB_gpu_shader_fp64 = 149,
        GL_ARB_gpu_shader_int64 = 150,
        GL_ARB_half_float_pixel = 151,
        GL_ARB_half_float_vertex = 152,
        GL_ARB_imaging = 153,
        GL_ARB_indirect_parameters = 154,
        GL_ARB_instanced_arrays = 155,
        GL_ARB_internalformat_query = 156,
        GL_ARB_internalformat_query2 = 157,
        GL_ARB_invalidate_subdata = 158,
        GL_ARB_map_buffer_alignment = 159,
        GL_ARB_map_buffer_range = 160,
        GL_ARB_matrix_palette = 161,
        GL_ARB_multi_bind = 162,
        GL_ARB_multi_draw_indirect = 163,
        GL_ARB_multisample = 164,
        GL_ARB_multitexture = 165,
        GL_ARB_occlusion_query = 166,
        GL_ARB_occlusion_query2 = 167,
        GL_ARB_parallel_shader_compile = 168,
        GL_ARB_pipeline_statistics_query = 169,
        GL_ARB_pixel_buffer_object = 170,
        GL_ARB_point_parameters = 171,
        GL_ARB_point_sprite = 172,
        GL_ARB_polygon_offset_clamp = 173,
        GL_ARB_post_depth_coverage = 174,
        GL_ARB_program_interface_query = 175,
        GL_ARB_provoking_vertex = 176,
        GL_ARB_query_buffer_object = 177,
        GL_ARB_robust_buffer_access_behavior = 178,
        GL_ARB_robustness = 179,
        GL_ARB_robustness_application_isolation = 180,
        GL_ARB_robustness_share_group_isolation = 181,
        GL_ARB_sample_locations = 182,
        GL_ARB_sample_shading = 183,
        GL_ARB_sampler_objects = 184,
        GL_ARB_seamless_cube_map = 185,
        GL_ARB_seamless_cubemap_per_texture = 186,
        GL_ARB_separate_shader_objects = 187,
        GL_ARB_shader_atomic_counter_ops = 188,
        GL_ARB_shader_atomic_counters = 189,
        GL_ARB_shader_ballot = 190,
        GL_ARB_shader_bit_encoding = 191,
        GL_ARB_shader_clock = 192,
        GL_ARB_shader_draw_parameters = 193,
        GL_ARB_shader_group_vote = 194,
        GL_ARB_shader_image_load_store = 195,
        GL_ARB_shader_image_size = 196,
        GL_ARB_shader_objects = 197,
        GL_ARB_shader_precision = 198,
        GL_ARB_shader_stencil_export = 199,
        GL_ARB_shader_storage_buffer_object = 200,
        GL_ARB_shader_subroutine = 201,
        GL_ARB_shader_texture_image_samples = 202,
        GL_ARB_shader_texture_lod = 203,
        GL_ARB_shader_viewport_layer_array = 204,
        GL_ARB_shading_language_100 = 205,
        GL_ARB_shading_language_420pack = 206,
        GL_ARB_shading_language_include = 207,
        GL_ARB_shading_language_packing = 208,
        GL_ARB_shadow = 209,
        GL_ARB_shadow_ambient = 210,
        GL_ARB_sparse_buffer = 211,
        GL_ARB_sparse_texture = 212,
        GL_ARB_sparse_texture2 = 213,
        GL_ARB_sparse_texture_clamp = 214,
        GL_ARB_spirv_extensions = 215,
        GL_ARB_stencil_texturing = 216,
        GL_ARB_sync = 217,
        GL_ARB_tessellation_shader = 218,
        GL_ARB_texture_barrier = 219,
        GL_ARB_texture_border_clamp = 220,
        GL_ARB_texture_buffer_object = 221,
        GL_ARB_texture_buffer_object_rgb32 = 222,
        GL_ARB_texture_buffer_range = 223,
        GL_ARB_texture_compression = 224,
        GL_ARB_texture_compression_bptc = 225,
        GL_ARB_texture_compression_rgtc = 226,
        GL_ARB_texture_cube_map = 227,
        GL_ARB_texture_cube_map_array = 228,
        GL_ARB_texture_env_add = 229,
        GL_ARB_texture_env_combine = 230,
        GL_ARB_texture_env_crossbar = 231,
        GL_ARB_texture_env_dot3 = 232,
        GL_ARB_texture_filter_anisotropic = 233,
        GL_ARB_texture_filter_minmax = 234,
        GL_ARB_texture_float = 235,
        GL_ARB_texture_gather = 236,
        GL_ARB_texture_mirror_clamp_to_edge = 237,
        GL_ARB_texture_mirrored_repeat = 238,
        GL_ARB_texture_multisample = 239,
        GL_ARB_texture_non_power_of_two = 240,
        GL_ARB_texture_query_levels = 241,
        GL_ARB_texture_query_lod = 242,
        GL_ARB_texture_rectangle = 243,
        GL_ARB_texture_rg = 244,
        GL_ARB_texture_rgb10_a2ui = 245,
        GL_ARB_texture_stencil8 = 246,
        GL_ARB_texture_storage = 247,
        GL_ARB_texture_storage_multisample = 248,
        GL_ARB_texture_swizzle = 249,
        GL_ARB_texture_view = 250,
        GL_ARB_timer_query = 251,
        GL_ARB_transform_feedback2 = 252,
        GL_ARB_transform_feedback3 = 253,
        GL_ARB_transform_feedback_instanced = 254,
        GL_ARB_transform_feedback_overflow_query = 255,
        GL_ARB_transpose_matrix = 256,
        GL_ARB_uniform_buffer_object = 257,
        GL_ARB_vertex_array_bgra = 258,
        GL_ARB_vertex_array_object = 259,
        GL_ARB_vertex_attrib_64bit = 260,
        GL_ARB_vertex_attrib_binding = 261,
        GL_ARB_vertex_blend = 262,
        GL_ARB_vertex_buffer_object = 263,
        GL_ARB_vertex_program = 264,
        GL_ARB_vertex_shader = 265,
        GL_ARB_vertex_type_10f_11f_11f_rev = 266,
        GL_ARB_vertex_type_2_10_10_10_rev = 267,
        GL_ARB_viewport_array = 268,
        GL_ARB_window_pos = 269,
        GL_ARM_mali_program_binary = 270,
        GL_ARM_mali_shader_binary = 271,
        GL_ARM_rgba8 = 272,
        GL_ARM_shader_framebuffer_fetch = 273,
        GL_ARM_shader_framebuffer_fetch_depth_stencil = 274,
        GL_ATIX_point_sprites = 275,
        GL_ATIX_texture_env_combine3 = 276,
        GL_ATIX_texture_env_route = 277,
        GL_ATIX_vertex_shader_output_point_size = 278,
        GL_ATI_draw_buffers = 279,
        GL_ATI_element_array = 280,
        GL_ATI_envmap_bumpmap = 281,
        GL_ATI_fragment_shader = 282,
        GL_ATI_map_object_buffer = 283,
        GL_ATI_meminfo = 284,
        GL_ATI_pn_triangles = 285,
        GL_ATI_separate_stencil = 286,
        GL_ATI_shader_texture_lod = 287,
        GL_ATI_text_fragment_shader = 288,
        GL_ATI_texture_compression_3dc = 289,
        GL_ATI_texture_env_combine3 = 290,
        GL_ATI_texture_float = 291,
        GL_ATI_texture_mirror_once = 292,
        GL_ATI_vertex_array_object = 293,
        GL_ATI_vertex_attrib_array_object = 294,
        GL_ATI_vertex_streams = 295,
        GL_EGL_KHR_context_flush_control = 296,
        GL_EGL_NV_robustness_video_memory_purge = 297,
        GL_EXT_422_pixels = 298,
        GL_EXT_Cg_shader = 299,
        GL_EXT_EGL_image_array = 300,
        GL_EXT_YUV_target = 301,
        GL_EXT_abgr = 302,
        GL_EXT_base_instance = 303,
        GL_EXT_bgra = 304,
        GL_EXT_bindable_uniform = 305,
        GL_EXT_blend_color = 306,
        GL_EXT_blend_equation_separate = 307,
        GL_EXT_blend_func_extended = 308,
        GL_EXT_blend_func_separate = 309,
        GL_EXT_blend_logic_op = 310,
        GL_EXT_blend_minmax = 311,
        GL_EXT_blend_subtract = 312,
        GL_EXT_buffer_storage = 313,
        GL_EXT_clear_texture = 314,
        GL_EXT_clip_cull_distance = 315,
        GL_EXT_clip_volume_hint = 316,
        GL_EXT_cmyka = 317,
        GL_EXT_color_buffer_float = 318,
        GL_EXT_color_buffer_half_float = 319,
        GL_EXT_color_subtable = 320,
        GL_EXT_compiled_vertex_array = 321,
        GL_EXT_compressed_ETC1_RGB8_sub_texture = 322,
        GL_EXT_conservative_depth = 323,
        GL_EXT_convolution = 324,
        GL_EXT_coordinate_frame = 325,
        GL_EXT_copy_image = 326,
        GL_EXT_copy_texture = 327,
        GL_EXT_cull_vertex = 328,
        GL_EXT_debug_label = 329,
        GL_EXT_debug_marker = 330,
        GL_EXT_depth_bounds_test = 331,
        GL_EXT_direct_state_access = 332,
        GL_EXT_discard_framebuffer = 333,
        GL_EXT_draw_buffers = 334,
        GL_EXT_draw_buffers2 = 335,
        GL_EXT_draw_buffers_indexed = 336,
        GL_EXT_draw_elements_base_vertex = 337,
        GL_EXT_draw_instanced = 338,
        GL_EXT_draw_range_elements = 339,
        GL_EXT_external_buffer = 340,
        GL_EXT_float_blend = 341,
        GL_EXT_fog_coord = 342,
        GL_EXT_frag_depth = 343,
        GL_EXT_fragment_lighting = 344,
        GL_EXT_framebuffer_blit = 345,
        GL_EXT_framebuffer_multisample = 346,
        GL_EXT_framebuffer_multisample_blit_scaled = 347,
        GL_EXT_framebuffer_object = 348,
        GL_EXT_framebuffer_sRGB = 349,
        GL_EXT_geometry_point_size = 350,
        GL_EXT_geometry_shader = 351,
        GL_EXT_geometry_shader4 = 352,
        GL_EXT_gpu_program_parameters = 353,
        GL_EXT_gpu_shader4 = 354,
        GL_EXT_gpu_shader5 = 355,
        GL_EXT_histogram = 356,
        GL_EXT_index_array_formats = 357,
        GL_EXT_index_func = 358,
        GL_EXT_index_material = 359,
        GL_EXT_index_texture = 360,
        GL_EXT_instanced_arrays = 361,
        GL_EXT_light_texture = 362,
        GL_EXT_map_buffer_range = 363,
        GL_EXT_memory_object = 364,
        GL_EXT_memory_object_fd = 365,
        GL_EXT_memory_object_win32 = 366,
        GL_EXT_misc_attribute = 367,
        GL_EXT_multi_draw_arrays = 368,
        GL_EXT_multi_draw_indirect = 369,
        GL_EXT_multiple_textures = 370,
        GL_EXT_multisample = 371,
        GL_EXT_multisample_compatibility = 372,
        GL_EXT_multisampled_render_to_texture = 373,
        GL_EXT_multisampled_render_to_texture2 = 374,
        GL_EXT_multiview_draw_buffers = 375,
        GL_EXT_packed_depth_stencil = 376,
        GL_EXT_packed_float = 377,
        GL_EXT_packed_pixels = 378,
        GL_EXT_paletted_texture = 379,
        GL_EXT_pixel_buffer_object = 380,
        GL_EXT_pixel_transform = 381,
        GL_EXT_pixel_transform_color_table = 382,
        GL_EXT_point_parameters = 383,
        GL_EXT_polygon_offset = 384,
        GL_EXT_polygon_offset_clamp = 385,
        GL_EXT_post_depth_coverage = 386,
        GL_EXT_provoking_vertex = 387,
        GL_EXT_pvrtc_sRGB = 388,
        GL_EXT_raster_multisample = 389,
        GL_EXT_read_format_bgra = 390,
        GL_EXT_render_snorm = 391,
        GL_EXT_rescale_normal = 392,
        GL_EXT_sRGB = 393,
        GL_EXT_sRGB_write_control = 394,
        GL_EXT_scene_marker = 395,
        GL_EXT_secondary_color = 396,
        GL_EXT_semaphore = 397,
        GL_EXT_semaphore_fd = 398,
        GL_EXT_semaphore_win32 = 399,
        GL_EXT_separate_shader_objects = 400,
        GL_EXT_separate_specular_color = 401,
        GL_EXT_shader_framebuffer_fetch = 402,
        GL_EXT_shader_group_vote = 403,
        GL_EXT_shader_image_load_formatted = 404,
        GL_EXT_shader_image_load_store = 405,
        GL_EXT_shader_implicit_conversions = 406,
        GL_EXT_shader_integer_mix = 407,
        GL_EXT_shader_io_blocks = 408,
        GL_EXT_shader_non_constant_global_initializers = 409,
        GL_EXT_shader_pixel_local_storage = 410,
        GL_EXT_shader_pixel_local_storage2 = 411,
        GL_EXT_shader_texture_lod = 412,
        GL_EXT_shadow_funcs = 413,
        GL_EXT_shadow_samplers = 414,
        GL_EXT_shared_texture_palette = 415,
        GL_EXT_sparse_texture = 416,
        GL_EXT_sparse_texture2 = 417,
        GL_EXT_stencil_clear_tag = 418,
        GL_EXT_stencil_two_side = 419,
        GL_EXT_stencil_wrap = 420,
        GL_EXT_subtexture = 421,
        GL_EXT_texture = 422,
        GL_EXT_texture3D = 423,
        GL_EXT_texture_array = 424,
        GL_EXT_texture_buffer_object = 425,
        GL_EXT_texture_compression_astc_decode_mode = 426,
        GL_EXT_texture_compression_astc_decode_mode_rgb9e5 = 427,
        GL_EXT_texture_compression_bptc = 428,
        GL_EXT_texture_compression_dxt1 = 429,
        GL_EXT_texture_compression_latc = 430,
        GL_EXT_texture_compression_rgtc = 431,
        GL_EXT_texture_compression_s3tc = 432,
        GL_EXT_texture_cube_map = 433,
        GL_EXT_texture_cube_map_array = 434,
        GL_EXT_texture_edge_clamp = 435,
        GL_EXT_texture_env = 436,
        GL_EXT_texture_env_add = 437,
        GL_EXT_texture_env_combine = 438,
        GL_EXT_texture_env_dot3 = 439,
        GL_EXT_texture_filter_anisotropic = 440,
        GL_EXT_texture_filter_minmax = 441,
        GL_EXT_texture_format_BGRA8888 = 442,
        GL_EXT_texture_integer = 443,
        GL_EXT_texture_lod_bias = 444,
        GL_EXT_texture_mirror_clamp = 445,
        GL_EXT_texture_norm16 = 446,
        GL_EXT_texture_object = 447,
        GL_EXT_texture_perturb_normal = 448,
        GL_EXT_texture_rectangle = 449,
        GL_EXT_texture_rg = 450,
        GL_EXT_texture_sRGB = 451,
        GL_EXT_texture_sRGB_R8 = 452,
        GL_EXT_texture_sRGB_RG8 = 453,
        GL_EXT_texture_sRGB_decode = 454,
        GL_EXT_texture_shared_exponent = 455,
        GL_EXT_texture_snorm = 456,
        GL_EXT_texture_storage = 457,
        GL_EXT_texture_swizzle = 458,
        GL_EXT_texture_type_2_10_10_10_REV = 459,
        GL_EXT_texture_view = 460,
        GL_EXT_timer_query = 461,
        GL_EXT_transform_feedback = 462,
        GL_EXT_unpack_subimage = 463,
        GL_EXT_vertex_array = 464,
        GL_EXT_vertex_array_bgra = 465,
        GL_EXT_vertex_array_setXXX = 466,
        GL_EXT_vertex_attrib_64bit = 467,
        GL_EXT_vertex_shader = 468,
        GL_EXT_vertex_weighting = 469,
        GL_EXT_win32_keyed_mutex = 470,
        GL_EXT_window_rectangles = 471,
        GL_EXT_x11_sync_object = 472,
        GL_GREMEDY_frame_terminator = 473,
        GL_GREMEDY_string_marker = 474,
        GL_HP_convolution_border_modes = 475,
        GL_HP_image_transform = 476,
        GL_HP_occlusion_test = 477,
        GL_HP_texture_lighting = 478,
        GL_IBM_cull_vertex = 479,
        GL_IBM_multimode_draw_arrays = 480,
        GL_IBM_rasterpos_clip = 481,
        GL_IBM_static_data = 482,
        GL_IBM_texture_mirrored_repeat = 483,
        GL_IBM_vertex_array_lists = 484,
        GL_INGR_color_clamp = 485,
        GL_INGR_interlace_read = 486,
        GL_INTEL_conservative_rasterization = 487,
        GL_INTEL_fragment_shader_ordering = 488,
        GL_INTEL_framebuffer_CMAA = 489,
        GL_INTEL_map_texture = 490,
        GL_INTEL_parallel_arrays = 491,
        GL_INTEL_performance_query = 492,
        GL_INTEL_texture_scissor = 493,
        GL_KHR_blend_equation_advanced = 494,
        GL_KHR_blend_equation_advanced_coherent = 495,
        GL_KHR_context_flush_control = 496,
        GL_KHR_debug = 497,
        GL_KHR_no_error = 498,
        GL_KHR_parallel_shader_compile = 499,
        GL_KHR_robust_buffer_access_behavior = 500,
        GL_KHR_robustness = 501,
        GL_KHR_texture_compression_astc_hdr = 502,
        GL_KHR_texture_compression_astc_ldr = 503,
        GL_KHR_texture_compression_astc_sliced_3d = 504,
        GL_KTX_buffer_region = 505,
        GL_MESAX_texture_stack = 506,
        GL_MESA_pack_invert = 507,
        GL_MESA_resize_buffers = 508,
        GL_MESA_shader_integer_functions = 509,
        GL_MESA_window_pos = 510,
        GL_MESA_ycbcr_texture = 511,
        GL_NVX_blend_equation_advanced_multi_draw_buffers = 512,
        GL_NVX_conditional_render = 513,
        GL_NVX_gpu_memory_info = 514,
        GL_NVX_linked_gpu_multicast = 515,
        GL_NV_3dvision_settings = 516,
        GL_NV_EGL_stream_consumer_external = 517,
        GL_NV_alpha_to_coverage_dither_control = 518,
        GL_NV_bgr = 519,
        GL_NV_bindless_multi_draw_indirect = 520,
        GL_NV_bindless_multi_draw_indirect_count = 521,
        GL_NV_bindless_texture = 522,
        GL_NV_blend_equation_advanced = 523,
        GL_NV_blend_equation_advanced_coherent = 524,
        GL_NV_blend_minmax_factor = 525,
        GL_NV_blend_square = 526,
        GL_NV_clip_space_w_scaling = 527,
        GL_NV_command_list = 528,
        GL_NV_compute_program5 = 529,
        GL_NV_conditional_render = 530,
        GL_NV_conservative_raster = 531,
        GL_NV_conservative_raster_dilate = 532,
        GL_NV_conservative_raster_pre_snap_triangles = 533,
        GL_NV_copy_buffer = 534,
        GL_NV_copy_depth_to_color = 535,
        GL_NV_copy_image = 536,
        GL_NV_deep_texture3D = 537,
        GL_NV_depth_buffer_float = 538,
        GL_NV_depth_clamp = 539,
        GL_NV_depth_range_unclamped = 540,
        GL_NV_draw_buffers = 541,
        GL_NV_draw_instanced = 542,
        GL_NV_draw_texture = 543,
        GL_NV_draw_vulkan_image = 544,
        GL_NV_evaluators = 545,
        GL_NV_explicit_attrib_location = 546,
        GL_NV_explicit_multisample = 547,
        GL_NV_fbo_color_attachments = 548,
        GL_NV_fence = 549,
        GL_NV_fill_rectangle = 550,
        GL_NV_float_buffer = 551,
        GL_NV_fog_distance = 552,
        GL_NV_fragment_coverage_to_color = 553,
        GL_NV_fragment_program = 554,
        GL_NV_fragment_program2 = 555,
        GL_NV_fragment_program4 = 556,
        GL_NV_fragment_program_option = 557,
        GL_NV_fragment_shader_interlock = 558,
        GL_NV_framebuffer_blit = 559,
        GL_NV_framebuffer_mixed_samples = 560,
        GL_NV_framebuffer_multisample = 561,
        GL_NV_framebuffer_multisample_coverage = 562,
        GL_NV_generate_mipmap_sRGB = 563,
        GL_NV_geometry_program4 = 564,
        GL_NV_geometry_shader4 = 565,
        GL_NV_geometry_shader_passthrough = 566,
        GL_NV_gpu_multicast = 567,
        GL_NV_gpu_program4 = 568,
        GL_NV_gpu_program5 = 569,
        GL_NV_gpu_program5_mem_extended = 570,
        GL_NV_gpu_program_fp64 = 571,
        GL_NV_gpu_shader5 = 572,
        GL_NV_half_float = 573,
        GL_NV_image_formats = 574,
        GL_NV_instanced_arrays = 575,
        GL_NV_internalformat_sample_query = 576,
        GL_NV_light_max_exponent = 577,
        GL_NV_multisample_coverage = 578,
        GL_NV_multisample_filter_hint = 579,
        GL_NV_non_square_matrices = 580,
        GL_NV_occlusion_query = 581,
        GL_NV_pack_subimage = 582,
        GL_NV_packed_depth_stencil = 583,
        GL_NV_packed_float = 584,
        GL_NV_packed_float_linear = 585,
        GL_NV_parameter_buffer_object = 586,
        GL_NV_parameter_buffer_object2 = 587,
        GL_NV_path_rendering = 588,
        GL_NV_path_rendering_shared_edge = 589,
        GL_NV_pixel_buffer_object = 590,
        GL_NV_pixel_data_range = 591,
        GL_NV_platform_binary = 592,
        GL_NV_point_sprite = 593,
        GL_NV_polygon_mode = 594,
        GL_NV_present_video = 595,
        GL_NV_primitive_restart = 596,
        GL_NV_read_depth = 597,
        GL_NV_read_depth_stencil = 598,
        GL_NV_read_stencil = 599,
        GL_NV_register_combiners = 600,
        GL_NV_register_combiners2 = 601,
        GL_NV_robustness_video_memory_purge = 602,
        GL_NV_sRGB_formats = 603,
        GL_NV_sample_locations = 604,
        GL_NV_sample_mask_override_coverage = 605,
        GL_NV_shader_atomic_counters = 606,
        GL_NV_shader_atomic_float = 607,
        GL_NV_shader_atomic_float64 = 608,
        GL_NV_shader_atomic_fp16_vector = 609,
        GL_NV_shader_atomic_int64 = 610,
        GL_NV_shader_buffer_load = 611,
        GL_NV_shader_noperspective_interpolation = 612,
        GL_NV_shader_storage_buffer_object = 613,
        GL_NV_shader_thread_group = 614,
        GL_NV_shader_thread_shuffle = 615,
        GL_NV_shadow_samplers_array = 616,
        GL_NV_shadow_samplers_cube = 617,
        GL_NV_stereo_view_rendering = 618,
        GL_NV_tessellation_program5 = 619,
        GL_NV_texgen_emboss = 620,
        GL_NV_texgen_reflection = 621,
        GL_NV_texture_array = 622,
        GL_NV_texture_barrier = 623,
        GL_NV_texture_border_clamp = 624,
        GL_NV_texture_compression_latc = 625,
        GL_NV_texture_compression_s3tc = 626,
        GL_NV_texture_compression_s3tc_update = 627,
        GL_NV_texture_compression_vtc = 628,
        GL_NV_texture_env_combine4 = 629,
        GL_NV_texture_expand_normal = 630,
        GL_NV_texture_multisample = 631,
        GL_NV_texture_npot_2D_mipmap = 632,
        GL_NV_texture_rectangle = 633,
        GL_NV_texture_rectangle_compressed = 634,
        GL_NV_texture_shader = 635,
        GL_NV_texture_shader2 = 636,
        GL_NV_texture_shader3 = 637,
        GL_NV_transform_feedback = 638,
        GL_NV_transform_feedback2 = 639,
        GL_NV_uniform_buffer_unified_memory = 640,
        GL_NV_vdpau_interop = 641,
        GL_NV_vertex_array_range = 642,
        GL_NV_vertex_array_range2 = 643,
        GL_NV_vertex_attrib_integer_64bit = 644,
        GL_NV_vertex_buffer_unified_memory = 645,
        GL_NV_vertex_program = 646,
        GL_NV_vertex_program1_1 = 647,
        GL_NV_vertex_program2 = 648,
        GL_NV_vertex_program2_option = 649,
        GL_NV_vertex_program3 = 650,
        GL_NV_vertex_program4 = 651,
        GL_NV_video_capture = 652,
        GL_NV_viewport_array = 653,
        GL_NV_viewport_array2 = 654,
        GL_NV_viewport_swizzle = 655,
        GL_OES_byte_coordinates = 656,
        GL_OML_interlace = 657,
        GL_OML_resample = 658,
        GL_OML_subsample = 659,
        GL_OVR_multiview = 660,
        GL_OVR_multiview2 = 661,
        GL_OVR_multiview_multisampled_render_to_texture = 662,
        GL_PGI_misc_hints = 663,
        GL_PGI_vertex_hints = 664,
        GL_QCOM_alpha_test = 665,
        GL_QCOM_binning_control = 666,
        GL_QCOM_driver_control = 667,
        GL_QCOM_extended_get = 668,
        GL_QCOM_extended_get2 = 669,
        GL_QCOM_framebuffer_foveated = 670,
        GL_QCOM_perfmon_global_mode = 671,
        GL_QCOM_shader_framebuffer_fetch_noncoherent = 672,
        GL_QCOM_tiled_rendering = 673,
        GL_QCOM_writeonly_rendering = 674,
        GL_REGAL_ES1_0_compatibility = 675,
        GL_REGAL_ES1_1_compatibility = 676,
        GL_REGAL_enable = 677,
        GL_REGAL_error_string = 678,
        GL_REGAL_extension_query = 679,
        GL_REGAL_log = 680,
        GL_REGAL_proc_address = 681,
        GL_REND_screen_coordinates = 682,
        GL_S3_s3tc = 683,
        GL_SGIS_clip_band_hint = 684,
        GL_SGIS_color_range = 685,
        GL_SGIS_detail_texture = 686,
        GL_SGIS_fog_function = 687,
        GL_SGIS_generate_mipmap = 688,
        GL_SGIS_line_texgen = 689,
        GL_SGIS_multisample = 690,
        GL_SGIS_multitexture = 691,
        GL_SGIS_pixel_texture = 692,
        GL_SGIS_point_line_texgen = 693,
        GL_SGIS_shared_multisample = 694,
        GL_SGIS_sharpen_texture = 695,
        GL_SGIS_texture4D = 696,
        GL_SGIS_texture_border_clamp = 697,
        GL_SGIS_texture_edge_clamp = 698,
        GL_SGIS_texture_filter4 = 699,
        GL_SGIS_texture_lod = 700,
        GL_SGIS_texture_select = 701,
        GL_SGIX_async = 702,
        GL_SGIX_async_histogram = 703,
        GL_SGIX_async_pixel = 704,
        GL_SGIX_bali_g_instruments = 705,
        GL_SGIX_bali_r_instruments = 706,
        GL_SGIX_bali_timer_instruments = 707,
        GL_SGIX_blend_alpha_minmax = 708,
        GL_SGIX_blend_cadd = 709,
        GL_SGIX_blend_cmultiply = 710,
        GL_SGIX_calligraphic_fragment = 711,
        GL_SGIX_clipmap = 712,
        GL_SGIX_color_matrix_accuracy = 713,
        GL_SGIX_color_table_index_mode = 714,
        GL_SGIX_complex_polar = 715,
        GL_SGIX_convolution_accuracy = 716,
        GL_SGIX_cube_map = 717,
        GL_SGIX_cylinder_texgen = 718,
        GL_SGIX_datapipe = 719,
        GL_SGIX_decimation = 720,
        GL_SGIX_depth_pass_instrument = 721,
        GL_SGIX_depth_texture = 722,
        GL_SGIX_dvc = 723,
        GL_SGIX_flush_raster = 724,
        GL_SGIX_fog_blend = 725,
        GL_SGIX_fog_factor_to_alpha = 726,
        GL_SGIX_fog_layers = 727,
        GL_SGIX_fog_offset = 728,
        GL_SGIX_fog_patchy = 729,
        GL_SGIX_fog_scale = 730,
        GL_SGIX_fog_texture = 731,
        GL_SGIX_fragment_lighting_space = 732,
        GL_SGIX_fragment_specular_lighting = 733,
        GL_SGIX_fragments_instrument = 734,
        GL_SGIX_framezoom = 735,
        GL_SGIX_icc_texture = 736,
        GL_SGIX_igloo_interface = 737,
        GL_SGIX_image_compression = 738,
        GL_SGIX_impact_pixel_texture = 739,
        GL_SGIX_instrument_error = 740,
        GL_SGIX_interlace = 741,
        GL_SGIX_ir_instrument1 = 742,
        GL_SGIX_line_quality_hint = 743,
        GL_SGIX_list_priority = 744,
        GL_SGIX_mpeg1 = 745,
        GL_SGIX_mpeg2 = 746,
        GL_SGIX_nonlinear_lighting_pervertex = 747,
        GL_SGIX_nurbs_eval = 748,
        GL_SGIX_occlusion_instrument = 749,
        GL_SGIX_packed_6bytes = 750,
        GL_SGIX_pixel_texture = 751,
        GL_SGIX_pixel_texture_bits = 752,
        GL_SGIX_pixel_texture_lod = 753,
        GL_SGIX_pixel_tiles = 754,
        GL_SGIX_polynomial_ffd = 755,
        GL_SGIX_quad_mesh = 756,
        GL_SGIX_reference_plane = 757,
        GL_SGIX_resample = 758,
        GL_SGIX_scalebias_hint = 759,
        GL_SGIX_shadow = 760,
        GL_SGIX_shadow_ambient = 761,
        GL_SGIX_slim = 762,
        GL_SGIX_spotlight_cutoff = 763,
        GL_SGIX_sprite = 764,
        GL_SGIX_subdiv_patch = 765,
        GL_SGIX_subsample = 766,
        GL_SGIX_tag_sample_buffer = 767,
        GL_SGIX_texture_add_env = 768,
        GL_SGIX_texture_coordinate_clamp = 769,
        GL_SGIX_texture_lod_bias = 770,
        GL_SGIX_texture_mipmap_anisotropic = 771,
        GL_SGIX_texture_multi_buffer = 772,
        GL_SGIX_texture_phase = 773,
        GL_SGIX_texture_range = 774,
        GL_SGIX_texture_scale_bias = 775,
        GL_SGIX_texture_supersample = 776,
        GL_SGIX_vector_ops = 777,
        GL_SGIX_vertex_array_object = 778,
        GL_SGIX_vertex_preclip = 779,
        GL_SGIX_vertex_preclip_hint = 780,
        GL_SGIX_ycrcb = 781,
        GL_SGIX_ycrcb_subsample = 782,
        GL_SGIX_ycrcba = 783,
        GL_SGI_color_matrix = 784,
        GL_SGI_color_table = 785,
        GL_SGI_complex = 786,
        GL_SGI_complex_type = 787,
        GL_SGI_fft = 788,
        GL_SGI_texture_color_table = 789,
        GL_SUNX_constant_data = 790,
        GL_SUN_convolution_border_modes = 791,
        GL_SUN_global_alpha = 792,
        GL_SUN_mesh_array = 793,
        GL_SUN_read_video_pixels = 794,
        GL_SUN_slice_accum = 795,
        GL_SUN_triangle_list = 796,
        GL_SUN_vertex = 797,
        GL_WIN_phong_shading = 798,
        GL_WIN_scene_markerXXX = 799,
        GL_WIN_specular_fog = 800,
        GL_WIN_swap_hint = 801,
    }
}

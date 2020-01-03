using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_vertex_shader {get; private set;}

		public const int GL_VERTEX_SHADER_EXT = 0x8780;
		public const int GL_VERTEX_SHADER_BINDING_EXT = 0x8781;
		public const int GL_OP_INDEX_EXT = 0x8782;
		public const int GL_OP_NEGATE_EXT = 0x8783;
		public const int GL_OP_DOT3_EXT = 0x8784;
		public const int GL_OP_DOT4_EXT = 0x8785;
		public const int GL_OP_MUL_EXT = 0x8786;
		public const int GL_OP_ADD_EXT = 0x8787;
		public const int GL_OP_MADD_EXT = 0x8788;
		public const int GL_OP_FRAC_EXT = 0x8789;
		public const int GL_OP_MAX_EXT = 0x878A;
		public const int GL_OP_MIN_EXT = 0x878B;
		public const int GL_OP_SET_GE_EXT = 0x878C;
		public const int GL_OP_SET_LT_EXT = 0x878D;
		public const int GL_OP_CLAMP_EXT = 0x878E;
		public const int GL_OP_FLOOR_EXT = 0x878F;
		public const int GL_OP_ROUND_EXT = 0x8790;
		public const int GL_OP_EXP_BASE_2_EXT = 0x8791;
		public const int GL_OP_LOG_BASE_2_EXT = 0x8792;
		public const int GL_OP_POWER_EXT = 0x8793;
		public const int GL_OP_RECIP_EXT = 0x8794;
		public const int GL_OP_RECIP_SQRT_EXT = 0x8795;
		public const int GL_OP_SUB_EXT = 0x8796;
		public const int GL_OP_CROSS_PRODUCT_EXT = 0x8797;
		public const int GL_OP_MULTIPLY_MATRIX_EXT = 0x8798;
		public const int GL_OP_MOV_EXT = 0x8799;
		public const int GL_OUTPUT_VERTEX_EXT = 0x879A;
		public const int GL_OUTPUT_COLOR0_EXT = 0x879B;
		public const int GL_OUTPUT_COLOR1_EXT = 0x879C;
		public const int GL_OUTPUT_TEXTURE_COORD0_EXT = 0x879D;
		public const int GL_OUTPUT_TEXTURE_COORD1_EXT = 0x879E;
		public const int GL_OUTPUT_TEXTURE_COORD2_EXT = 0x879F;
		public const int GL_OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;
		public const int GL_OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;
		public const int GL_OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;
		public const int GL_OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;
		public const int GL_OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;
		public const int GL_OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;
		public const int GL_OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;
		public const int GL_OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;
		public const int GL_OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;
		public const int GL_OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;
		public const int GL_OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;
		public const int GL_OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;
		public const int GL_OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;
		public const int GL_OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;
		public const int GL_OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;
		public const int GL_OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;
		public const int GL_OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;
		public const int GL_OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;
		public const int GL_OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;
		public const int GL_OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;
		public const int GL_OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;
		public const int GL_OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;
		public const int GL_OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;
		public const int GL_OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;
		public const int GL_OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;
		public const int GL_OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;
		public const int GL_OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;
		public const int GL_OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;
		public const int GL_OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;
		public const int GL_OUTPUT_FOG_EXT = 0x87BD;
		public const int GL_SCALAR_EXT = 0x87BE;
		public const int GL_VECTOR_EXT = 0x87BF;
		public const int GL_MATRIX_EXT = 0x87C0;
		public const int GL_VARIANT_EXT = 0x87C1;
		public const int GL_INVARIANT_EXT = 0x87C2;
		public const int GL_LOCAL_CONSTANT_EXT = 0x87C3;
		public const int GL_LOCAL_EXT = 0x87C4;
		public const int GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
		public const int GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
		public const int GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
		public const int GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
		public const int GL_MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;
		public const int GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
		public const int GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
		public const int GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CC;
		public const int GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CD;
		public const int GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
		public const int GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
		public const int GL_VERTEX_SHADER_VARIANTS_EXT = 0x87D0;
		public const int GL_VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;
		public const int GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
		public const int GL_VERTEX_SHADER_LOCALS_EXT = 0x87D3;
		public const int GL_VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;
		public const int GL_X_EXT = 0x87D5;
		public const int GL_Y_EXT = 0x87D6;
		public const int GL_Z_EXT = 0x87D7;
		public const int GL_W_EXT = 0x87D8;
		public const int GL_NEGATIVE_X_EXT = 0x87D9;
		public const int GL_NEGATIVE_Y_EXT = 0x87DA;
		public const int GL_NEGATIVE_Z_EXT = 0x87DB;
		public const int GL_NEGATIVE_W_EXT = 0x87DC;
		public const int GL_ZERO_EXT = 0x87DD;
		public const int GL_ONE_EXT = 0x87DE;
		public const int GL_NEGATIVE_ONE_EXT = 0x87DF;
		public const int GL_NORMALIZED_RANGE_EXT = 0x87E0;
		public const int GL_FULL_RANGE_EXT = 0x87E1;
		public const int GL_CURRENT_VERTEX_EXT = 0x87E2;
		public const int GL_MVP_MATRIX_EXT = 0x87E3;
		public const int GL_VARIANT_VALUE_EXT = 0x87E4;
		public const int GL_VARIANT_DATATYPE_EXT = 0x87E5;
		public const int GL_VARIANT_ARRAY_STRIDE_EXT = 0x87E6;
		public const int GL_VARIANT_ARRAY_TYPE_EXT = 0x87E7;
		public const int GL_VARIANT_ARRAY_EXT = 0x87E8;
		public const int GL_VARIANT_ARRAY_POINTER_EXT = 0x87E9;
		public const int GL_INVARIANT_VALUE_EXT = 0x87EA;
		public const int GL_INVARIANT_DATATYPE_EXT = 0x87EB;
		public const int GL_LOCAL_CONSTANT_VALUE_EXT = 0x87EC;
		public const int GL_LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBeginVertexShaderEXT( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glBindLightParameterEXT(uint light, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glBindMaterialParameterEXT(uint face, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glBindParameterEXT(uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glBindTexGenParameterEXT(uint unit, uint coord, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glBindTextureUnitParameterEXT(uint unit, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindVertexShaderEXT(uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteVertexShaderEXT(uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableVariantClientStateEXT(uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableVariantClientStateEXT(uint id);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndVertexShaderEXT( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glExtractComponentEXT(uint res, uint src, uint num);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGenSymbolsEXT(uint dataType, uint storageType, uint range, uint components);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGenVertexShadersEXT(uint range);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInvariantBooleanvEXT(uint id, uint value, bool* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInvariantFloatvEXT(uint id, uint value, float* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetInvariantIntegervEXT(uint id, uint value, int* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetLocalConstantBooleanvEXT(uint id, uint value, bool* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetLocalConstantFloatvEXT(uint id, uint value, float* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetLocalConstantIntegervEXT(uint id, uint value, int* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVariantBooleanvEXT(uint id, uint value, bool* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVariantFloatvEXT(uint id, uint value, float* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVariantIntegervEXT(uint id, uint value, int* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetVariantPointervEXT(uint id, uint value, IntPtr* data);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInsertComponentEXT(uint res, uint src, uint num);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsVariantEnabledEXT(uint id, uint cap);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSetInvariantEXT(uint id, uint type, IntPtr addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSetLocalConstantEXT(uint id, uint type, IntPtr addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderOp1EXT(uint op, uint res, uint arg1);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderOp2EXT(uint op, uint res, uint arg1, uint arg2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShaderOp3EXT(uint op, uint res, uint arg1, uint arg2, uint arg3);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSwizzleEXT(uint res, uint in_, uint outX, uint outY, uint outZ, uint outW);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantPointerEXT(uint id, uint type, uint stride, IntPtr addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantbvEXT(uint id, sbyte* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantdvEXT(uint id, double* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantfvEXT(uint id, float* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantivEXT(uint id, int* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantsvEXT(uint id, short* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantubvEXT(uint id, byte* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantuivEXT(uint id, uint* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVariantusvEXT(uint id, ushort* addr);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glWriteMaskEXT(uint res, uint in_, uint outX, uint outY, uint outZ, uint outW);

 		static __glBeginVertexShaderEXT __GlueBeginVertexShaderEXT;
		static __glBindLightParameterEXT __GlueBindLightParameterEXT;
		static __glBindMaterialParameterEXT __GlueBindMaterialParameterEXT;
		static __glBindParameterEXT __GlueBindParameterEXT;
		static __glBindTexGenParameterEXT __GlueBindTexGenParameterEXT;
		static __glBindTextureUnitParameterEXT __GlueBindTextureUnitParameterEXT;
		static __glBindVertexShaderEXT __GlueBindVertexShaderEXT;
		static __glDeleteVertexShaderEXT __GlueDeleteVertexShaderEXT;
		static __glDisableVariantClientStateEXT __GlueDisableVariantClientStateEXT;
		static __glEnableVariantClientStateEXT __GlueEnableVariantClientStateEXT;
		static __glEndVertexShaderEXT __GlueEndVertexShaderEXT;
		static __glExtractComponentEXT __GlueExtractComponentEXT;
		static __glGenSymbolsEXT __GlueGenSymbolsEXT;
		static __glGenVertexShadersEXT __GlueGenVertexShadersEXT;
		static __glGetInvariantBooleanvEXT __GlueGetInvariantBooleanvEXT;
		static __glGetInvariantFloatvEXT __GlueGetInvariantFloatvEXT;
		static __glGetInvariantIntegervEXT __GlueGetInvariantIntegervEXT;
		static __glGetLocalConstantBooleanvEXT __GlueGetLocalConstantBooleanvEXT;
		static __glGetLocalConstantFloatvEXT __GlueGetLocalConstantFloatvEXT;
		static __glGetLocalConstantIntegervEXT __GlueGetLocalConstantIntegervEXT;
		static __glGetVariantBooleanvEXT __GlueGetVariantBooleanvEXT;
		static __glGetVariantFloatvEXT __GlueGetVariantFloatvEXT;
		static __glGetVariantIntegervEXT __GlueGetVariantIntegervEXT;
		static __glGetVariantPointervEXT __GlueGetVariantPointervEXT;
		static __glInsertComponentEXT __GlueInsertComponentEXT;
		static __glIsVariantEnabledEXT __GlueIsVariantEnabledEXT;
		static __glSetInvariantEXT __GlueSetInvariantEXT;
		static __glSetLocalConstantEXT __GlueSetLocalConstantEXT;
		static __glShaderOp1EXT __GlueShaderOp1EXT;
		static __glShaderOp2EXT __GlueShaderOp2EXT;
		static __glShaderOp3EXT __GlueShaderOp3EXT;
		static __glSwizzleEXT __GlueSwizzleEXT;
		static __glVariantPointerEXT __GlueVariantPointerEXT;
		static __glVariantbvEXT __GlueVariantbvEXT;
		static __glVariantdvEXT __GlueVariantdvEXT;
		static __glVariantfvEXT __GlueVariantfvEXT;
		static __glVariantivEXT __GlueVariantivEXT;
		static __glVariantsvEXT __GlueVariantsvEXT;
		static __glVariantubvEXT __GlueVariantubvEXT;
		static __glVariantuivEXT __GlueVariantuivEXT;
		static __glVariantusvEXT __GlueVariantusvEXT;
		static __glWriteMaskEXT __GlueWriteMaskEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBeginVertexShaderEXT( ) => __GlueBeginVertexShaderEXT();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glBindLightParameterEXT(uint light, uint value) => __GlueBindLightParameterEXT(light, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glBindMaterialParameterEXT(uint face, uint value) => __GlueBindMaterialParameterEXT(face, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glBindParameterEXT(uint value) => __GlueBindParameterEXT(value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glBindTexGenParameterEXT(uint unit, uint coord, uint value) => __GlueBindTexGenParameterEXT(unit, coord, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glBindTextureUnitParameterEXT(uint unit, uint value) => __GlueBindTextureUnitParameterEXT(unit, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindVertexShaderEXT(uint id) => __GlueBindVertexShaderEXT(id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteVertexShaderEXT(uint id) => __GlueDeleteVertexShaderEXT(id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableVariantClientStateEXT(uint id) => __GlueDisableVariantClientStateEXT(id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableVariantClientStateEXT(uint id) => __GlueEnableVariantClientStateEXT(id);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndVertexShaderEXT( ) => __GlueEndVertexShaderEXT();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glExtractComponentEXT(uint res, uint src, uint num) => __GlueExtractComponentEXT(res, src, num);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGenSymbolsEXT(uint dataType, uint storageType, uint range, uint components) => __GlueGenSymbolsEXT(dataType, storageType, range, components);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGenVertexShadersEXT(uint range) => __GlueGenVertexShadersEXT(range);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInvariantBooleanvEXT(uint id, uint value, bool* data) => __GlueGetInvariantBooleanvEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInvariantFloatvEXT(uint id, uint value, float* data) => __GlueGetInvariantFloatvEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetInvariantIntegervEXT(uint id, uint value, int* data) => __GlueGetInvariantIntegervEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetLocalConstantBooleanvEXT(uint id, uint value, bool* data) => __GlueGetLocalConstantBooleanvEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetLocalConstantFloatvEXT(uint id, uint value, float* data) => __GlueGetLocalConstantFloatvEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetLocalConstantIntegervEXT(uint id, uint value, int* data) => __GlueGetLocalConstantIntegervEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVariantBooleanvEXT(uint id, uint value, bool* data) => __GlueGetVariantBooleanvEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVariantFloatvEXT(uint id, uint value, float* data) => __GlueGetVariantFloatvEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVariantIntegervEXT(uint id, uint value, int* data) => __GlueGetVariantIntegervEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetVariantPointervEXT(uint id, uint value, IntPtr* data) => __GlueGetVariantPointervEXT(id, value, data);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInsertComponentEXT(uint res, uint src, uint num) => __GlueInsertComponentEXT(res, src, num);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsVariantEnabledEXT(uint id, uint cap) => __GlueIsVariantEnabledEXT(id, cap);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSetInvariantEXT(uint id, uint type, IntPtr addr) => __GlueSetInvariantEXT(id, type, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSetLocalConstantEXT(uint id, uint type, IntPtr addr) => __GlueSetLocalConstantEXT(id, type, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderOp1EXT(uint op, uint res, uint arg1) => __GlueShaderOp1EXT(op, res, arg1);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderOp2EXT(uint op, uint res, uint arg1, uint arg2) => __GlueShaderOp2EXT(op, res, arg1, arg2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShaderOp3EXT(uint op, uint res, uint arg1, uint arg2, uint arg3) => __GlueShaderOp3EXT(op, res, arg1, arg2, arg3);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSwizzleEXT(uint res, uint in_, uint outX, uint outY, uint outZ, uint outW) => __GlueSwizzleEXT(res, in_, outX, outY, outZ, outW);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantPointerEXT(uint id, uint type, uint stride, IntPtr addr) => __GlueVariantPointerEXT(id, type, stride, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantbvEXT(uint id, sbyte* addr) => __GlueVariantbvEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantdvEXT(uint id, double* addr) => __GlueVariantdvEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantfvEXT(uint id, float* addr) => __GlueVariantfvEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantivEXT(uint id, int* addr) => __GlueVariantivEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantsvEXT(uint id, short* addr) => __GlueVariantsvEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantubvEXT(uint id, byte* addr) => __GlueVariantubvEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantuivEXT(uint id, uint* addr) => __GlueVariantuivEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVariantusvEXT(uint id, ushort* addr) => __GlueVariantusvEXT(id, addr);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glWriteMaskEXT(uint res, uint in_, uint outX, uint outY, uint outZ, uint outW) => __GlueWriteMaskEXT(res, in_, outX, outY, outZ, outW);



	}
}


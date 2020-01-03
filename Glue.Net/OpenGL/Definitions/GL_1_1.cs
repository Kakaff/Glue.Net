using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_1_1 {get; private set;}

		public const int GL_ZERO = 0;
		public const int GL_FALSE = 0;
		public const int GL_LOGIC_OP = 0x0BF1;
		public const int GL_NONE = 0;
		public const int GL_TEXTURE_COMPONENTS = 0x1003;
		public const int GL_NO_ERROR = 0;
		public const int GL_POINTS = 0x0000;
		public const int GL_CURRENT_BIT = 0x00000001;
		public const int GL_TRUE = 1;
		public const int GL_ONE = 1;
		public const int GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
		public const int GL_LINES = 0x0001;
		public const int GL_LINE_LOOP = 0x0002;
		public const int GL_POINT_BIT = 0x00000002;
		public const int GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
		public const int GL_LINE_STRIP = 0x0003;
		public const int GL_LINE_BIT = 0x00000004;
		public const int GL_TRIANGLES = 0x0004;
		public const int GL_TRIANGLE_STRIP = 0x0005;
		public const int GL_TRIANGLE_FAN = 0x0006;
		public const int GL_QUADS = 0x0007;
		public const int GL_QUAD_STRIP = 0x0008;
		public const int GL_POLYGON_BIT = 0x00000008;
		public const int GL_POLYGON = 0x0009;
		public const int GL_POLYGON_STIPPLE_BIT = 0x00000010;
		public const int GL_PIXEL_MODE_BIT = 0x00000020;
		public const int GL_LIGHTING_BIT = 0x00000040;
		public const int GL_FOG_BIT = 0x00000080;
		public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
		public const int GL_ACCUM = 0x0100;
		public const int GL_LOAD = 0x0101;
		public const int GL_RETURN = 0x0102;
		public const int GL_MULT = 0x0103;
		public const int GL_ADD = 0x0104;
		public const int GL_NEVER = 0x0200;
		public const int GL_ACCUM_BUFFER_BIT = 0x00000200;
		public const int GL_LESS = 0x0201;
		public const int GL_EQUAL = 0x0202;
		public const int GL_LEQUAL = 0x0203;
		public const int GL_GREATER = 0x0204;
		public const int GL_NOTEQUAL = 0x0205;
		public const int GL_GEQUAL = 0x0206;
		public const int GL_ALWAYS = 0x0207;
		public const int GL_SRC_COLOR = 0x0300;
		public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
		public const int GL_SRC_ALPHA = 0x0302;
		public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
		public const int GL_DST_ALPHA = 0x0304;
		public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;
		public const int GL_DST_COLOR = 0x0306;
		public const int GL_ONE_MINUS_DST_COLOR = 0x0307;
		public const int GL_SRC_ALPHA_SATURATE = 0x0308;
		public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
		public const int GL_FRONT_LEFT = 0x0400;
		public const int GL_FRONT_RIGHT = 0x0401;
		public const int GL_BACK_LEFT = 0x0402;
		public const int GL_BACK_RIGHT = 0x0403;
		public const int GL_FRONT = 0x0404;
		public const int GL_BACK = 0x0405;
		public const int GL_LEFT = 0x0406;
		public const int GL_RIGHT = 0x0407;
		public const int GL_FRONT_AND_BACK = 0x0408;
		public const int GL_AUX0 = 0x0409;
		public const int GL_AUX1 = 0x040A;
		public const int GL_AUX2 = 0x040B;
		public const int GL_AUX3 = 0x040C;
		public const int GL_INVALID_ENUM = 0x0500;
		public const int GL_INVALID_VALUE = 0x0501;
		public const int GL_INVALID_OPERATION = 0x0502;
		public const int GL_STACK_OVERFLOW = 0x0503;
		public const int GL_STACK_UNDERFLOW = 0x0504;
		public const int GL_OUT_OF_MEMORY = 0x0505;
		public const int GL_2D = 0x0600;
		public const int GL_3D = 0x0601;
		public const int GL_3D_COLOR = 0x0602;
		public const int GL_3D_COLOR_TEXTURE = 0x0603;
		public const int GL_4D_COLOR_TEXTURE = 0x0604;
		public const int GL_PASS_THROUGH_TOKEN = 0x0700;
		public const int GL_POINT_TOKEN = 0x0701;
		public const int GL_LINE_TOKEN = 0x0702;
		public const int GL_POLYGON_TOKEN = 0x0703;
		public const int GL_BITMAP_TOKEN = 0x0704;
		public const int GL_DRAW_PIXEL_TOKEN = 0x0705;
		public const int GL_COPY_PIXEL_TOKEN = 0x0706;
		public const int GL_LINE_RESET_TOKEN = 0x0707;
		public const int GL_EXP = 0x0800;
		public const int GL_VIEWPORT_BIT = 0x00000800;
		public const int GL_EXP2 = 0x0801;
		public const int GL_CW = 0x0900;
		public const int GL_CCW = 0x0901;
		public const int GL_COEFF = 0x0A00;
		public const int GL_ORDER = 0x0A01;
		public const int GL_DOMAIN = 0x0A02;
		public const int GL_CURRENT_COLOR = 0x0B00;
		public const int GL_CURRENT_INDEX = 0x0B01;
		public const int GL_CURRENT_NORMAL = 0x0B02;
		public const int GL_CURRENT_TEXTURE_COORDS = 0x0B03;
		public const int GL_CURRENT_RASTER_COLOR = 0x0B04;
		public const int GL_CURRENT_RASTER_INDEX = 0x0B05;
		public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
		public const int GL_CURRENT_RASTER_POSITION = 0x0B07;
		public const int GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
		public const int GL_CURRENT_RASTER_DISTANCE = 0x0B09;
		public const int GL_POINT_SMOOTH = 0x0B10;
		public const int GL_POINT_SIZE = 0x0B11;
		public const int GL_POINT_SIZE_RANGE = 0x0B12;
		public const int GL_POINT_SIZE_GRANULARITY = 0x0B13;
		public const int GL_LINE_SMOOTH = 0x0B20;
		public const int GL_LINE_WIDTH = 0x0B21;
		public const int GL_LINE_WIDTH_RANGE = 0x0B22;
		public const int GL_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const int GL_LINE_STIPPLE = 0x0B24;
		public const int GL_LINE_STIPPLE_PATTERN = 0x0B25;
		public const int GL_LINE_STIPPLE_REPEAT = 0x0B26;
		public const int GL_LIST_MODE = 0x0B30;
		public const int GL_MAX_LIST_NESTING = 0x0B31;
		public const int GL_LIST_BASE = 0x0B32;
		public const int GL_LIST_INDEX = 0x0B33;
		public const int GL_POLYGON_MODE = 0x0B40;
		public const int GL_POLYGON_SMOOTH = 0x0B41;
		public const int GL_POLYGON_STIPPLE = 0x0B42;
		public const int GL_EDGE_FLAG = 0x0B43;
		public const int GL_CULL_FACE = 0x0B44;
		public const int GL_CULL_FACE_MODE = 0x0B45;
		public const int GL_FRONT_FACE = 0x0B46;
		public const int GL_LIGHTING = 0x0B50;
		public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
		public const int GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
		public const int GL_LIGHT_MODEL_AMBIENT = 0x0B53;
		public const int GL_SHADE_MODEL = 0x0B54;
		public const int GL_COLOR_MATERIAL_FACE = 0x0B55;
		public const int GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
		public const int GL_COLOR_MATERIAL = 0x0B57;
		public const int GL_FOG = 0x0B60;
		public const int GL_FOG_INDEX = 0x0B61;
		public const int GL_FOG_DENSITY = 0x0B62;
		public const int GL_FOG_START = 0x0B63;
		public const int GL_FOG_END = 0x0B64;
		public const int GL_FOG_MODE = 0x0B65;
		public const int GL_FOG_COLOR = 0x0B66;
		public const int GL_DEPTH_RANGE = 0x0B70;
		public const int GL_DEPTH_TEST = 0x0B71;
		public const int GL_DEPTH_WRITEMASK = 0x0B72;
		public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;
		public const int GL_DEPTH_FUNC = 0x0B74;
		public const int GL_ACCUM_CLEAR_VALUE = 0x0B80;
		public const int GL_STENCIL_TEST = 0x0B90;
		public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;
		public const int GL_STENCIL_FUNC = 0x0B92;
		public const int GL_STENCIL_VALUE_MASK = 0x0B93;
		public const int GL_STENCIL_FAIL = 0x0B94;
		public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
		public const int GL_STENCIL_REF = 0x0B97;
		public const int GL_STENCIL_WRITEMASK = 0x0B98;
		public const int GL_MATRIX_MODE = 0x0BA0;
		public const int GL_NORMALIZE = 0x0BA1;
		public const int GL_VIEWPORT = 0x0BA2;
		public const int GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
		public const int GL_PROJECTION_STACK_DEPTH = 0x0BA4;
		public const int GL_TEXTURE_STACK_DEPTH = 0x0BA5;
		public const int GL_MODELVIEW_MATRIX = 0x0BA6;
		public const int GL_PROJECTION_MATRIX = 0x0BA7;
		public const int GL_TEXTURE_MATRIX = 0x0BA8;
		public const int GL_ATTRIB_STACK_DEPTH = 0x0BB0;
		public const int GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
		public const int GL_ALPHA_TEST = 0x0BC0;
		public const int GL_ALPHA_TEST_FUNC = 0x0BC1;
		public const int GL_ALPHA_TEST_REF = 0x0BC2;
		public const int GL_DITHER = 0x0BD0;
		public const int GL_BLEND_DST = 0x0BE0;
		public const int GL_BLEND_SRC = 0x0BE1;
		public const int GL_BLEND = 0x0BE2;
		public const int GL_LOGIC_OP_MODE = 0x0BF0;
		public const int GL_INDEX_LOGIC_OP = 0x0BF1;
		public const int GL_COLOR_LOGIC_OP = 0x0BF2;
		public const int GL_AUX_BUFFERS = 0x0C00;
		public const int GL_DRAW_BUFFER = 0x0C01;
		public const int GL_READ_BUFFER = 0x0C02;
		public const int GL_SCISSOR_BOX = 0x0C10;
		public const int GL_SCISSOR_TEST = 0x0C11;
		public const int GL_INDEX_CLEAR_VALUE = 0x0C20;
		public const int GL_INDEX_WRITEMASK = 0x0C21;
		public const int GL_COLOR_CLEAR_VALUE = 0x0C22;
		public const int GL_COLOR_WRITEMASK = 0x0C23;
		public const int GL_INDEX_MODE = 0x0C30;
		public const int GL_RGBA_MODE = 0x0C31;
		public const int GL_DOUBLEBUFFER = 0x0C32;
		public const int GL_STEREO = 0x0C33;
		public const int GL_RENDER_MODE = 0x0C40;
		public const int GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
		public const int GL_POINT_SMOOTH_HINT = 0x0C51;
		public const int GL_LINE_SMOOTH_HINT = 0x0C52;
		public const int GL_POLYGON_SMOOTH_HINT = 0x0C53;
		public const int GL_FOG_HINT = 0x0C54;
		public const int GL_TEXTURE_GEN_S = 0x0C60;
		public const int GL_TEXTURE_GEN_T = 0x0C61;
		public const int GL_TEXTURE_GEN_R = 0x0C62;
		public const int GL_TEXTURE_GEN_Q = 0x0C63;
		public const int GL_PIXEL_MAP_I_TO_I = 0x0C70;
		public const int GL_PIXEL_MAP_S_TO_S = 0x0C71;
		public const int GL_PIXEL_MAP_I_TO_R = 0x0C72;
		public const int GL_PIXEL_MAP_I_TO_G = 0x0C73;
		public const int GL_PIXEL_MAP_I_TO_B = 0x0C74;
		public const int GL_PIXEL_MAP_I_TO_A = 0x0C75;
		public const int GL_PIXEL_MAP_R_TO_R = 0x0C76;
		public const int GL_PIXEL_MAP_G_TO_G = 0x0C77;
		public const int GL_PIXEL_MAP_B_TO_B = 0x0C78;
		public const int GL_PIXEL_MAP_A_TO_A = 0x0C79;
		public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
		public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
		public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
		public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
		public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
		public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
		public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
		public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
		public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
		public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
		public const int GL_UNPACK_SWAP_BYTES = 0x0CF0;
		public const int GL_UNPACK_LSB_FIRST = 0x0CF1;
		public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;
		public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;
		public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;
		public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
		public const int GL_PACK_SWAP_BYTES = 0x0D00;
		public const int GL_PACK_LSB_FIRST = 0x0D01;
		public const int GL_PACK_ROW_LENGTH = 0x0D02;
		public const int GL_PACK_SKIP_ROWS = 0x0D03;
		public const int GL_PACK_SKIP_PIXELS = 0x0D04;
		public const int GL_PACK_ALIGNMENT = 0x0D05;
		public const int GL_MAP_COLOR = 0x0D10;
		public const int GL_MAP_STENCIL = 0x0D11;
		public const int GL_INDEX_SHIFT = 0x0D12;
		public const int GL_INDEX_OFFSET = 0x0D13;
		public const int GL_RED_SCALE = 0x0D14;
		public const int GL_RED_BIAS = 0x0D15;
		public const int GL_ZOOM_X = 0x0D16;
		public const int GL_ZOOM_Y = 0x0D17;
		public const int GL_GREEN_SCALE = 0x0D18;
		public const int GL_GREEN_BIAS = 0x0D19;
		public const int GL_BLUE_SCALE = 0x0D1A;
		public const int GL_BLUE_BIAS = 0x0D1B;
		public const int GL_ALPHA_SCALE = 0x0D1C;
		public const int GL_ALPHA_BIAS = 0x0D1D;
		public const int GL_DEPTH_SCALE = 0x0D1E;
		public const int GL_DEPTH_BIAS = 0x0D1F;
		public const int GL_MAX_EVAL_ORDER = 0x0D30;
		public const int GL_MAX_LIGHTS = 0x0D31;
		public const int GL_MAX_CLIP_PLANES = 0x0D32;
		public const int GL_MAX_TEXTURE_SIZE = 0x0D33;
		public const int GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
		public const int GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
		public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
		public const int GL_MAX_NAME_STACK_DEPTH = 0x0D37;
		public const int GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
		public const int GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;
		public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;
		public const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
		public const int GL_SUBPIXEL_BITS = 0x0D50;
		public const int GL_INDEX_BITS = 0x0D51;
		public const int GL_RED_BITS = 0x0D52;
		public const int GL_GREEN_BITS = 0x0D53;
		public const int GL_BLUE_BITS = 0x0D54;
		public const int GL_ALPHA_BITS = 0x0D55;
		public const int GL_DEPTH_BITS = 0x0D56;
		public const int GL_STENCIL_BITS = 0x0D57;
		public const int GL_ACCUM_RED_BITS = 0x0D58;
		public const int GL_ACCUM_GREEN_BITS = 0x0D59;
		public const int GL_ACCUM_BLUE_BITS = 0x0D5A;
		public const int GL_ACCUM_ALPHA_BITS = 0x0D5B;
		public const int GL_NAME_STACK_DEPTH = 0x0D70;
		public const int GL_AUTO_NORMAL = 0x0D80;
		public const int GL_MAP1_COLOR_4 = 0x0D90;
		public const int GL_MAP1_INDEX = 0x0D91;
		public const int GL_MAP1_NORMAL = 0x0D92;
		public const int GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
		public const int GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
		public const int GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
		public const int GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
		public const int GL_MAP1_VERTEX_3 = 0x0D97;
		public const int GL_MAP1_VERTEX_4 = 0x0D98;
		public const int GL_MAP2_COLOR_4 = 0x0DB0;
		public const int GL_MAP2_INDEX = 0x0DB1;
		public const int GL_MAP2_NORMAL = 0x0DB2;
		public const int GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
		public const int GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
		public const int GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
		public const int GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
		public const int GL_MAP2_VERTEX_3 = 0x0DB7;
		public const int GL_MAP2_VERTEX_4 = 0x0DB8;
		public const int GL_MAP1_GRID_DOMAIN = 0x0DD0;
		public const int GL_MAP1_GRID_SEGMENTS = 0x0DD1;
		public const int GL_MAP2_GRID_DOMAIN = 0x0DD2;
		public const int GL_MAP2_GRID_SEGMENTS = 0x0DD3;
		public const int GL_TEXTURE_1D = 0x0DE0;
		public const int GL_TEXTURE_2D = 0x0DE1;
		public const int GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
		public const int GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
		public const int GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
		public const int GL_SELECTION_BUFFER_POINTER = 0x0DF3;
		public const int GL_SELECTION_BUFFER_SIZE = 0x0DF4;
		public const int GL_TEXTURE_WIDTH = 0x1000;
		public const int GL_TRANSFORM_BIT = 0x00001000;
		public const int GL_TEXTURE_HEIGHT = 0x1001;
		public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
		public const int GL_TEXTURE_BORDER_COLOR = 0x1004;
		public const int GL_TEXTURE_BORDER = 0x1005;
		public const int GL_DONT_CARE = 0x1100;
		public const int GL_FASTEST = 0x1101;
		public const int GL_NICEST = 0x1102;
		public const int GL_AMBIENT = 0x1200;
		public const int GL_DIFFUSE = 0x1201;
		public const int GL_SPECULAR = 0x1202;
		public const int GL_POSITION = 0x1203;
		public const int GL_SPOT_DIRECTION = 0x1204;
		public const int GL_SPOT_EXPONENT = 0x1205;
		public const int GL_SPOT_CUTOFF = 0x1206;
		public const int GL_CONSTANT_ATTENUATION = 0x1207;
		public const int GL_LINEAR_ATTENUATION = 0x1208;
		public const int GL_QUADRATIC_ATTENUATION = 0x1209;
		public const int GL_COMPILE = 0x1300;
		public const int GL_COMPILE_AND_EXECUTE = 0x1301;
		public const int GL_BYTE = 0x1400;
		public const int GL_UNSIGNED_BYTE = 0x1401;
		public const int GL_SHORT = 0x1402;
		public const int GL_UNSIGNED_SHORT = 0x1403;
		public const int GL_INT = 0x1404;
		public const int GL_UNSIGNED_INT = 0x1405;
		public const int GL_FLOAT = 0x1406;
		public const int GL_2_BYTES = 0x1407;
		public const int GL_3_BYTES = 0x1408;
		public const int GL_4_BYTES = 0x1409;
		public const int GL_DOUBLE = 0x140A;
		public const int GL_CLEAR = 0x1500;
		public const int GL_AND = 0x1501;
		public const int GL_AND_REVERSE = 0x1502;
		public const int GL_COPY = 0x1503;
		public const int GL_AND_INVERTED = 0x1504;
		public const int GL_NOOP = 0x1505;
		public const int GL_XOR = 0x1506;
		public const int GL_OR = 0x1507;
		public const int GL_NOR = 0x1508;
		public const int GL_EQUIV = 0x1509;
		public const int GL_INVERT = 0x150A;
		public const int GL_OR_REVERSE = 0x150B;
		public const int GL_COPY_INVERTED = 0x150C;
		public const int GL_OR_INVERTED = 0x150D;
		public const int GL_NAND = 0x150E;
		public const int GL_SET = 0x150F;
		public const int GL_EMISSION = 0x1600;
		public const int GL_SHININESS = 0x1601;
		public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;
		public const int GL_COLOR_INDEXES = 0x1603;
		public const int GL_MODELVIEW = 0x1700;
		public const int GL_PROJECTION = 0x1701;
		public const int GL_TEXTURE = 0x1702;
		public const int GL_COLOR = 0x1800;
		public const int GL_DEPTH = 0x1801;
		public const int GL_STENCIL = 0x1802;
		public const int GL_COLOR_INDEX = 0x1900;
		public const int GL_STENCIL_INDEX = 0x1901;
		public const int GL_DEPTH_COMPONENT = 0x1902;
		public const int GL_RED = 0x1903;
		public const int GL_GREEN = 0x1904;
		public const int GL_BLUE = 0x1905;
		public const int GL_ALPHA = 0x1906;
		public const int GL_RGB = 0x1907;
		public const int GL_RGBA = 0x1908;
		public const int GL_LUMINANCE = 0x1909;
		public const int GL_LUMINANCE_ALPHA = 0x190A;
		public const int GL_BITMAP = 0x1A00;
		public const int GL_POINT = 0x1B00;
		public const int GL_LINE = 0x1B01;
		public const int GL_FILL = 0x1B02;
		public const int GL_RENDER = 0x1C00;
		public const int GL_FEEDBACK = 0x1C01;
		public const int GL_SELECT = 0x1C02;
		public const int GL_FLAT = 0x1D00;
		public const int GL_SMOOTH = 0x1D01;
		public const int GL_KEEP = 0x1E00;
		public const int GL_REPLACE = 0x1E01;
		public const int GL_INCR = 0x1E02;
		public const int GL_DECR = 0x1E03;
		public const int GL_VENDOR = 0x1F00;
		public const int GL_RENDERER = 0x1F01;
		public const int GL_VERSION = 0x1F02;
		public const int GL_EXTENSIONS = 0x1F03;
		public const int GL_S = 0x2000;
		public const int GL_ENABLE_BIT = 0x00002000;
		public const int GL_T = 0x2001;
		public const int GL_R = 0x2002;
		public const int GL_Q = 0x2003;
		public const int GL_MODULATE = 0x2100;
		public const int GL_DECAL = 0x2101;
		public const int GL_TEXTURE_ENV_MODE = 0x2200;
		public const int GL_TEXTURE_ENV_COLOR = 0x2201;
		public const int GL_TEXTURE_ENV = 0x2300;
		public const int GL_EYE_LINEAR = 0x2400;
		public const int GL_OBJECT_LINEAR = 0x2401;
		public const int GL_SPHERE_MAP = 0x2402;
		public const int GL_TEXTURE_GEN_MODE = 0x2500;
		public const int GL_OBJECT_PLANE = 0x2501;
		public const int GL_EYE_PLANE = 0x2502;
		public const int GL_NEAREST = 0x2600;
		public const int GL_LINEAR = 0x2601;
		public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
		public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
		public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
		public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
		public const int GL_TEXTURE_MAG_FILTER = 0x2800;
		public const int GL_TEXTURE_MIN_FILTER = 0x2801;
		public const int GL_TEXTURE_WRAP_S = 0x2802;
		public const int GL_TEXTURE_WRAP_T = 0x2803;
		public const int GL_CLAMP = 0x2900;
		public const int GL_REPEAT = 0x2901;
		public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
		public const int GL_POLYGON_OFFSET_POINT = 0x2A01;
		public const int GL_POLYGON_OFFSET_LINE = 0x2A02;
		public const int GL_R3_G3_B2 = 0x2A10;
		public const int GL_V2F = 0x2A20;
		public const int GL_V3F = 0x2A21;
		public const int GL_C4UB_V2F = 0x2A22;
		public const int GL_C4UB_V3F = 0x2A23;
		public const int GL_C3F_V3F = 0x2A24;
		public const int GL_N3F_V3F = 0x2A25;
		public const int GL_C4F_N3F_V3F = 0x2A26;
		public const int GL_T2F_V3F = 0x2A27;
		public const int GL_T4F_V4F = 0x2A28;
		public const int GL_T2F_C4UB_V3F = 0x2A29;
		public const int GL_T2F_C3F_V3F = 0x2A2A;
		public const int GL_T2F_N3F_V3F = 0x2A2B;
		public const int GL_T2F_C4F_N3F_V3F = 0x2A2C;
		public const int GL_T4F_C4F_N3F_V4F = 0x2A2D;
		public const int GL_CLIP_PLANE0 = 0x3000;
		public const int GL_CLIP_PLANE1 = 0x3001;
		public const int GL_CLIP_PLANE2 = 0x3002;
		public const int GL_CLIP_PLANE3 = 0x3003;
		public const int GL_CLIP_PLANE4 = 0x3004;
		public const int GL_CLIP_PLANE5 = 0x3005;
		public const int GL_LIGHT0 = 0x4000;
		public const int GL_COLOR_BUFFER_BIT = 0x00004000;
		public const int GL_LIGHT1 = 0x4001;
		public const int GL_LIGHT2 = 0x4002;
		public const int GL_LIGHT3 = 0x4003;
		public const int GL_LIGHT4 = 0x4004;
		public const int GL_LIGHT5 = 0x4005;
		public const int GL_LIGHT6 = 0x4006;
		public const int GL_LIGHT7 = 0x4007;
		public const int GL_HINT_BIT = 0x00008000;
		public const int GL_POLYGON_OFFSET_FILL = 0x8037;
		public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
		public const int GL_ALPHA4 = 0x803B;
		public const int GL_ALPHA8 = 0x803C;
		public const int GL_ALPHA12 = 0x803D;
		public const int GL_ALPHA16 = 0x803E;
		public const int GL_LUMINANCE4 = 0x803F;
		public const int GL_LUMINANCE8 = 0x8040;
		public const int GL_LUMINANCE12 = 0x8041;
		public const int GL_LUMINANCE16 = 0x8042;
		public const int GL_LUMINANCE4_ALPHA4 = 0x8043;
		public const int GL_LUMINANCE6_ALPHA2 = 0x8044;
		public const int GL_LUMINANCE8_ALPHA8 = 0x8045;
		public const int GL_LUMINANCE12_ALPHA4 = 0x8046;
		public const int GL_LUMINANCE12_ALPHA12 = 0x8047;
		public const int GL_LUMINANCE16_ALPHA16 = 0x8048;
		public const int GL_INTENSITY = 0x8049;
		public const int GL_INTENSITY4 = 0x804A;
		public const int GL_INTENSITY8 = 0x804B;
		public const int GL_INTENSITY12 = 0x804C;
		public const int GL_INTENSITY16 = 0x804D;
		public const int GL_RGB4 = 0x804F;
		public const int GL_RGB5 = 0x8050;
		public const int GL_RGB8 = 0x8051;
		public const int GL_RGB10 = 0x8052;
		public const int GL_RGB12 = 0x8053;
		public const int GL_RGB16 = 0x8054;
		public const int GL_RGBA2 = 0x8055;
		public const int GL_RGBA4 = 0x8056;
		public const int GL_RGB5_A1 = 0x8057;
		public const int GL_RGBA8 = 0x8058;
		public const int GL_RGB10_A2 = 0x8059;
		public const int GL_RGBA12 = 0x805A;
		public const int GL_RGBA16 = 0x805B;
		public const int GL_TEXTURE_RED_SIZE = 0x805C;
		public const int GL_TEXTURE_GREEN_SIZE = 0x805D;
		public const int GL_TEXTURE_BLUE_SIZE = 0x805E;
		public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;
		public const int GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
		public const int GL_TEXTURE_INTENSITY_SIZE = 0x8061;
		public const int GL_PROXY_TEXTURE_1D = 0x8063;
		public const int GL_PROXY_TEXTURE_2D = 0x8064;
		public const int GL_TEXTURE_PRIORITY = 0x8066;
		public const int GL_TEXTURE_RESIDENT = 0x8067;
		public const int GL_TEXTURE_BINDING_1D = 0x8068;
		public const int GL_TEXTURE_BINDING_2D = 0x8069;
		public const int GL_VERTEX_ARRAY = 0x8074;
		public const int GL_NORMAL_ARRAY = 0x8075;
		public const int GL_COLOR_ARRAY = 0x8076;
		public const int GL_INDEX_ARRAY = 0x8077;
		public const int GL_TEXTURE_COORD_ARRAY = 0x8078;
		public const int GL_EDGE_FLAG_ARRAY = 0x8079;
		public const int GL_VERTEX_ARRAY_SIZE = 0x807A;
		public const int GL_VERTEX_ARRAY_TYPE = 0x807B;
		public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;
		public const int GL_NORMAL_ARRAY_TYPE = 0x807E;
		public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;
		public const int GL_COLOR_ARRAY_SIZE = 0x8081;
		public const int GL_COLOR_ARRAY_TYPE = 0x8082;
		public const int GL_COLOR_ARRAY_STRIDE = 0x8083;
		public const int GL_INDEX_ARRAY_TYPE = 0x8085;
		public const int GL_INDEX_ARRAY_STRIDE = 0x8086;
		public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
		public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
		public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
		public const int GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
		public const int GL_VERTEX_ARRAY_POINTER = 0x808E;
		public const int GL_NORMAL_ARRAY_POINTER = 0x808F;
		public const int GL_COLOR_ARRAY_POINTER = 0x8090;
		public const int GL_INDEX_ARRAY_POINTER = 0x8091;
		public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
		public const int GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
		public const int GL_COLOR_INDEX1_EXT = 0x80E2;
		public const int GL_COLOR_INDEX2_EXT = 0x80E3;
		public const int GL_COLOR_INDEX4_EXT = 0x80E4;
		public const int GL_COLOR_INDEX8_EXT = 0x80E5;
		public const int GL_COLOR_INDEX12_EXT = 0x80E6;
		public const int GL_COLOR_INDEX16_EXT = 0x80E7;
		public const int GL_EVAL_BIT = 0x00010000;
		public const int GL_LIST_BIT = 0x00020000;
		public const int GL_TEXTURE_BIT = 0x00040000;
		public const int GL_SCISSOR_BIT = 0x00080000;
		public const int GL_ALL_ATTRIB_BITS = 0x000fffff;
		public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xffffffff;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glAccum(uint op, float value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glAlphaFunc(uint func, float reference);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glAreTexturesResident(int n, uint* textures, bool* residences);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glArrayElement(int i);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBegin(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBindTexture(uint target, uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glBlendFunc(uint sfactor, uint dfactor);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCallList(uint list);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCallLists(int n, uint type, IntPtr lists);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClear(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearAccum(float red, float green, float blue, float alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearColor(float red, float green, float blue, float alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearDepth(double depth);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearIndex(float c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClearStencil(int s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glClipPlane(uint plane, double* equation);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3b(sbyte red, sbyte green, sbyte blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3bv(sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3d(double red, double green, double blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3f(float red, float green, float blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3i(int red, int green, int blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3s(short red, short green, short blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3ub(byte red, byte green, byte blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3ubv(byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3ui(uint red, uint green, uint blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3uiv(uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3us(ushort red, ushort green, ushort blue);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor3usv(ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4bv(sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4d(double red, double green, double blue, double alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4f(float red, float green, float blue, float alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4i(int red, int green, int blue, int alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4s(short red, short green, short blue, short alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4ub(byte red, byte green, byte blue, byte alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4ubv(byte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4ui(uint red, uint green, uint blue, uint alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4uiv(uint* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColor4usv(ushort* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorMask(bool red, bool green, bool blue, bool alpha);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorMaterial(uint face, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorPointer(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyPixels(int x, int y, int width, int height, uint type);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCullFace(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteLists(uint list, int range);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteTextures(int n, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthFunc(uint func);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthMask(bool flag);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDepthRange(double zNear, double zFar);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisable(uint cap);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDisableClientState(uint array);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawArrays(uint mode, int first, int count);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawBuffer(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawElements(uint mode, int count, uint type, IntPtr indices);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDrawPixels(int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEdgeFlag(bool flag);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEdgeFlagPointer(int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEdgeFlagv(bool* flag);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnable(uint cap);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnableClientState(uint array);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEnd( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEndList( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord1d(double u);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord1dv(double* u);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord1f(float u);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord1fv(float* u);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord2d(double u, double v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord2dv(double* u);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord2f(float u, float v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalCoord2fv(float* u);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalMesh1(uint mode, int i1, int i2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalPoint1(int i);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glEvalPoint2(int i, int j);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFeedbackBuffer(int size, uint type, float* buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFinish( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFlush( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogf(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogfv(uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogi(uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFogiv(uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFrontFace(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGenLists(int range);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGenTextures(int n, uint* textures);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetBooleanv(uint pname, bool* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetClipPlane(uint plane, double* equation);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetDoublev(uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetError( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFloatv(uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetIntegerv(uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetLightfv(uint light, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetLightiv(uint light, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMapdv(uint target, uint query, double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMapfv(uint target, uint query, float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMapiv(uint target, uint query, int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMaterialfv(uint face, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetMaterialiv(uint face, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPixelMapfv(uint map, float* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPixelMapuiv(uint map, uint* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPixelMapusv(uint map, ushort* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPointerv(uint pname, IntPtr* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetPolygonStipple(byte* mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate  byte * __glGetString(uint name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexEnvfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexEnviv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexGendv(uint coord, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexGenfv(uint coord, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexGeniv(uint coord, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexLevelParameterfv(uint target, int level, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexLevelParameteriv(uint target, int level, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetTexParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glHint(uint target, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexMask(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexPointer(uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexd(double c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexdv(double* c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexf(float c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexfv(float* c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexi(int c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexiv(int* c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexs(short c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexsv(short* c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexub(byte c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glIndexubv(byte* c);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInitNames( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glInterleavedArrays(uint format, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsEnabled(uint cap);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsList(uint list);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsTexture(uint texture);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightModelf(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightModelfv(uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightModeli(uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightModeliv(uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightf(uint light, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightfv(uint light, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLighti(uint light, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightiv(uint light, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLineStipple(int factor, ushort pattern);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLineWidth(float width);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glListBase(uint base_);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadIdentity( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadMatrixd(double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadMatrixf(float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLoadName(uint name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLogicOp(uint opcode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMap1d(uint target, double u1, double u2, int stride, int order, double* points);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMap1f(uint target, float u1, float u2, int stride, int order, float* points);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMapGrid1d(int un, double u1, double u2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMapGrid1f(int un, float u1, float u2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMaterialf(uint face, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMaterialfv(uint face, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMateriali(uint face, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMaterialiv(uint face, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMatrixMode(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultMatrixd(double* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultMatrixf(float* m);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNewList(uint list, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3b(sbyte nx, sbyte ny, sbyte nz);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3bv(sbyte* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3d(double nx, double ny, double nz);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3f(float nx, float ny, float nz);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3i(int nx, int ny, int nz);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3s(short nx, short ny, short nz);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormal3sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormalPointer(uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPassThrough(float token);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelMapfv(uint map, int mapsize, float* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelMapuiv(uint map, int mapsize, uint* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelMapusv(uint map, int mapsize, ushort* values);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelStoref(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelStorei(uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelTransferf(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelTransferi(uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPixelZoom(float xfactor, float yfactor);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPointSize(float size);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPolygonMode(uint face, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPolygonOffset(float factor, float units);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPolygonStipple(byte* mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPopAttrib( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPopClientAttrib( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPopMatrix( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPopName( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPrioritizeTextures(int n, uint* textures, float* priorities);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPushAttrib(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPushClientAttrib(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPushMatrix( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glPushName(uint name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2d(double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2f(float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2i(int x, int y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2s(short x, short y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos2sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3d(double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3f(float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3i(int x, int y, int z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3s(short x, short y, short z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos3sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4d(double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4f(float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4i(int x, int y, int z, int w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4s(short x, short y, short z, short w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRasterPos4sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glReadBuffer(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRectd(double x1, double y1, double x2, double y2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRectdv(double* v1, double* v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRectf(float x1, float y1, float x2, float y2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRectfv(float* v1, float* v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRecti(int x1, int y1, int x2, int y2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRectiv(int* v1, int* v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRects(short x1, short y1, short x2, short y2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRectsv(short* v1, short* v2);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate int __glRenderMode(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRotated(double angle, double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glRotatef(float angle, float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glScaled(double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glScalef(float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glScissor(int x, int y, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSelectBuffer(int size, uint* buffer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glShadeModel(uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glStencilFunc(uint func, int reference, uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glStencilMask(uint mask);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glStencilOp(uint fail, uint zfail, uint zpass);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1d(double s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1f(float s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1i(int s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1s(short s);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord1sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2d(double s, double t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2f(float s, float t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2i(int s, int t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2s(short s, short t);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord2sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3d(double s, double t, double r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3f(float s, float t, float r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3i(int s, int t, int r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3s(short s, short t, short r);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord3sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4d(double s, double t, double r, double q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4f(float s, float t, float r, float q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4i(int s, int t, int r, int q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4s(short s, short t, short r, short q);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoord4sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordPointer(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexEnvf(uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexEnvfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexEnvi(uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexEnviv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexGend(uint coord, uint pname, double param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexGendv(uint coord, uint pname, double* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexGenf(uint coord, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexGenfv(uint coord, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexGeni(uint coord, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexGeniv(uint coord, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameterf(uint target, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameterfv(uint target, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameteri(uint target, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexParameteriv(uint target, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTranslated(double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTranslatef(float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2d(double x, double y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2f(float x, float y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2i(int x, int y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2s(short x, short y);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex2sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3d(double x, double y, double z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3f(float x, float y, float z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3i(int x, int y, int z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3s(short x, short y, short z);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex3sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4d(double x, double y, double z, double w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4dv(double* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4f(float x, float y, float z, float w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4fv(float* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4i(int x, int y, int z, int w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4iv(int* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4s(short x, short y, short z, short w);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertex4sv(short* v);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexPointer(int size, uint type, int stride, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glViewport(int x, int y, int width, int height);

 		static __glAccum __GlueAccum;
		static __glAlphaFunc __GlueAlphaFunc;
		static __glAreTexturesResident __GlueAreTexturesResident;
		static __glArrayElement __GlueArrayElement;
		static __glBegin __GlueBegin;
		static __glBindTexture __GlueBindTexture;
		static __glBitmap __GlueBitmap;
		static __glBlendFunc __GlueBlendFunc;
		static __glCallList __GlueCallList;
		static __glCallLists __GlueCallLists;
		static __glClear __GlueClear;
		static __glClearAccum __GlueClearAccum;
		static __glClearColor __GlueClearColor;
		static __glClearDepth __GlueClearDepth;
		static __glClearIndex __GlueClearIndex;
		static __glClearStencil __GlueClearStencil;
		static __glClipPlane __GlueClipPlane;
		static __glColor3b __GlueColor3b;
		static __glColor3bv __GlueColor3bv;
		static __glColor3d __GlueColor3d;
		static __glColor3dv __GlueColor3dv;
		static __glColor3f __GlueColor3f;
		static __glColor3fv __GlueColor3fv;
		static __glColor3i __GlueColor3i;
		static __glColor3iv __GlueColor3iv;
		static __glColor3s __GlueColor3s;
		static __glColor3sv __GlueColor3sv;
		static __glColor3ub __GlueColor3ub;
		static __glColor3ubv __GlueColor3ubv;
		static __glColor3ui __GlueColor3ui;
		static __glColor3uiv __GlueColor3uiv;
		static __glColor3us __GlueColor3us;
		static __glColor3usv __GlueColor3usv;
		static __glColor4b __GlueColor4b;
		static __glColor4bv __GlueColor4bv;
		static __glColor4d __GlueColor4d;
		static __glColor4dv __GlueColor4dv;
		static __glColor4f __GlueColor4f;
		static __glColor4fv __GlueColor4fv;
		static __glColor4i __GlueColor4i;
		static __glColor4iv __GlueColor4iv;
		static __glColor4s __GlueColor4s;
		static __glColor4sv __GlueColor4sv;
		static __glColor4ub __GlueColor4ub;
		static __glColor4ubv __GlueColor4ubv;
		static __glColor4ui __GlueColor4ui;
		static __glColor4uiv __GlueColor4uiv;
		static __glColor4us __GlueColor4us;
		static __glColor4usv __GlueColor4usv;
		static __glColorMask __GlueColorMask;
		static __glColorMaterial __GlueColorMaterial;
		static __glColorPointer __GlueColorPointer;
		static __glCopyPixels __GlueCopyPixels;
		static __glCopyTexImage1D __GlueCopyTexImage1D;
		static __glCopyTexImage2D __GlueCopyTexImage2D;
		static __glCopyTexSubImage1D __GlueCopyTexSubImage1D;
		static __glCopyTexSubImage2D __GlueCopyTexSubImage2D;
		static __glCullFace __GlueCullFace;
		static __glDeleteLists __GlueDeleteLists;
		static __glDeleteTextures __GlueDeleteTextures;
		static __glDepthFunc __GlueDepthFunc;
		static __glDepthMask __GlueDepthMask;
		static __glDepthRange __GlueDepthRange;
		static __glDisable __GlueDisable;
		static __glDisableClientState __GlueDisableClientState;
		static __glDrawArrays __GlueDrawArrays;
		static __glDrawBuffer __GlueDrawBuffer;
		static __glDrawElements __GlueDrawElements;
		static __glDrawPixels __GlueDrawPixels;
		static __glEdgeFlag __GlueEdgeFlag;
		static __glEdgeFlagPointer __GlueEdgeFlagPointer;
		static __glEdgeFlagv __GlueEdgeFlagv;
		static __glEnable __GlueEnable;
		static __glEnableClientState __GlueEnableClientState;
		static __glEnd __GlueEnd;
		static __glEndList __GlueEndList;
		static __glEvalCoord1d __GlueEvalCoord1d;
		static __glEvalCoord1dv __GlueEvalCoord1dv;
		static __glEvalCoord1f __GlueEvalCoord1f;
		static __glEvalCoord1fv __GlueEvalCoord1fv;
		static __glEvalCoord2d __GlueEvalCoord2d;
		static __glEvalCoord2dv __GlueEvalCoord2dv;
		static __glEvalCoord2f __GlueEvalCoord2f;
		static __glEvalCoord2fv __GlueEvalCoord2fv;
		static __glEvalMesh1 __GlueEvalMesh1;
		static __glEvalMesh2 __GlueEvalMesh2;
		static __glEvalPoint1 __GlueEvalPoint1;
		static __glEvalPoint2 __GlueEvalPoint2;
		static __glFeedbackBuffer __GlueFeedbackBuffer;
		static __glFinish __GlueFinish;
		static __glFlush __GlueFlush;
		static __glFogf __GlueFogf;
		static __glFogfv __GlueFogfv;
		static __glFogi __GlueFogi;
		static __glFogiv __GlueFogiv;
		static __glFrontFace __GlueFrontFace;
		static __glFrustum __GlueFrustum;
		static __glGenLists __GlueGenLists;
		static __glGenTextures __GlueGenTextures;
		static __glGetBooleanv __GlueGetBooleanv;
		static __glGetClipPlane __GlueGetClipPlane;
		static __glGetDoublev __GlueGetDoublev;
		static __glGetError __GlueGetError;
		static __glGetFloatv __GlueGetFloatv;
		static __glGetIntegerv __GlueGetIntegerv;
		static __glGetLightfv __GlueGetLightfv;
		static __glGetLightiv __GlueGetLightiv;
		static __glGetMapdv __GlueGetMapdv;
		static __glGetMapfv __GlueGetMapfv;
		static __glGetMapiv __GlueGetMapiv;
		static __glGetMaterialfv __GlueGetMaterialfv;
		static __glGetMaterialiv __GlueGetMaterialiv;
		static __glGetPixelMapfv __GlueGetPixelMapfv;
		static __glGetPixelMapuiv __GlueGetPixelMapuiv;
		static __glGetPixelMapusv __GlueGetPixelMapusv;
		static __glGetPointerv __GlueGetPointerv;
		static __glGetPolygonStipple __GlueGetPolygonStipple;
		static __glGetString __GlueGetString;
		static __glGetTexEnvfv __GlueGetTexEnvfv;
		static __glGetTexEnviv __GlueGetTexEnviv;
		static __glGetTexGendv __GlueGetTexGendv;
		static __glGetTexGenfv __GlueGetTexGenfv;
		static __glGetTexGeniv __GlueGetTexGeniv;
		static __glGetTexImage __GlueGetTexImage;
		static __glGetTexLevelParameterfv __GlueGetTexLevelParameterfv;
		static __glGetTexLevelParameteriv __GlueGetTexLevelParameteriv;
		static __glGetTexParameterfv __GlueGetTexParameterfv;
		static __glGetTexParameteriv __GlueGetTexParameteriv;
		static __glHint __GlueHint;
		static __glIndexMask __GlueIndexMask;
		static __glIndexPointer __GlueIndexPointer;
		static __glIndexd __GlueIndexd;
		static __glIndexdv __GlueIndexdv;
		static __glIndexf __GlueIndexf;
		static __glIndexfv __GlueIndexfv;
		static __glIndexi __GlueIndexi;
		static __glIndexiv __GlueIndexiv;
		static __glIndexs __GlueIndexs;
		static __glIndexsv __GlueIndexsv;
		static __glIndexub __GlueIndexub;
		static __glIndexubv __GlueIndexubv;
		static __glInitNames __GlueInitNames;
		static __glInterleavedArrays __GlueInterleavedArrays;
		static __glIsEnabled __GlueIsEnabled;
		static __glIsList __GlueIsList;
		static __glIsTexture __GlueIsTexture;
		static __glLightModelf __GlueLightModelf;
		static __glLightModelfv __GlueLightModelfv;
		static __glLightModeli __GlueLightModeli;
		static __glLightModeliv __GlueLightModeliv;
		static __glLightf __GlueLightf;
		static __glLightfv __GlueLightfv;
		static __glLighti __GlueLighti;
		static __glLightiv __GlueLightiv;
		static __glLineStipple __GlueLineStipple;
		static __glLineWidth __GlueLineWidth;
		static __glListBase __GlueListBase;
		static __glLoadIdentity __GlueLoadIdentity;
		static __glLoadMatrixd __GlueLoadMatrixd;
		static __glLoadMatrixf __GlueLoadMatrixf;
		static __glLoadName __GlueLoadName;
		static __glLogicOp __GlueLogicOp;
		static __glMap1d __GlueMap1d;
		static __glMap1f __GlueMap1f;
		static __glMap2d __GlueMap2d;
		static __glMap2f __GlueMap2f;
		static __glMapGrid1d __GlueMapGrid1d;
		static __glMapGrid1f __GlueMapGrid1f;
		static __glMapGrid2d __GlueMapGrid2d;
		static __glMapGrid2f __GlueMapGrid2f;
		static __glMaterialf __GlueMaterialf;
		static __glMaterialfv __GlueMaterialfv;
		static __glMateriali __GlueMateriali;
		static __glMaterialiv __GlueMaterialiv;
		static __glMatrixMode __GlueMatrixMode;
		static __glMultMatrixd __GlueMultMatrixd;
		static __glMultMatrixf __GlueMultMatrixf;
		static __glNewList __GlueNewList;
		static __glNormal3b __GlueNormal3b;
		static __glNormal3bv __GlueNormal3bv;
		static __glNormal3d __GlueNormal3d;
		static __glNormal3dv __GlueNormal3dv;
		static __glNormal3f __GlueNormal3f;
		static __glNormal3fv __GlueNormal3fv;
		static __glNormal3i __GlueNormal3i;
		static __glNormal3iv __GlueNormal3iv;
		static __glNormal3s __GlueNormal3s;
		static __glNormal3sv __GlueNormal3sv;
		static __glNormalPointer __GlueNormalPointer;
		static __glOrtho __GlueOrtho;
		static __glPassThrough __GluePassThrough;
		static __glPixelMapfv __GluePixelMapfv;
		static __glPixelMapuiv __GluePixelMapuiv;
		static __glPixelMapusv __GluePixelMapusv;
		static __glPixelStoref __GluePixelStoref;
		static __glPixelStorei __GluePixelStorei;
		static __glPixelTransferf __GluePixelTransferf;
		static __glPixelTransferi __GluePixelTransferi;
		static __glPixelZoom __GluePixelZoom;
		static __glPointSize __GluePointSize;
		static __glPolygonMode __GluePolygonMode;
		static __glPolygonOffset __GluePolygonOffset;
		static __glPolygonStipple __GluePolygonStipple;
		static __glPopAttrib __GluePopAttrib;
		static __glPopClientAttrib __GluePopClientAttrib;
		static __glPopMatrix __GluePopMatrix;
		static __glPopName __GluePopName;
		static __glPrioritizeTextures __GluePrioritizeTextures;
		static __glPushAttrib __GluePushAttrib;
		static __glPushClientAttrib __GluePushClientAttrib;
		static __glPushMatrix __GluePushMatrix;
		static __glPushName __GluePushName;
		static __glRasterPos2d __GlueRasterPos2d;
		static __glRasterPos2dv __GlueRasterPos2dv;
		static __glRasterPos2f __GlueRasterPos2f;
		static __glRasterPos2fv __GlueRasterPos2fv;
		static __glRasterPos2i __GlueRasterPos2i;
		static __glRasterPos2iv __GlueRasterPos2iv;
		static __glRasterPos2s __GlueRasterPos2s;
		static __glRasterPos2sv __GlueRasterPos2sv;
		static __glRasterPos3d __GlueRasterPos3d;
		static __glRasterPos3dv __GlueRasterPos3dv;
		static __glRasterPos3f __GlueRasterPos3f;
		static __glRasterPos3fv __GlueRasterPos3fv;
		static __glRasterPos3i __GlueRasterPos3i;
		static __glRasterPos3iv __GlueRasterPos3iv;
		static __glRasterPos3s __GlueRasterPos3s;
		static __glRasterPos3sv __GlueRasterPos3sv;
		static __glRasterPos4d __GlueRasterPos4d;
		static __glRasterPos4dv __GlueRasterPos4dv;
		static __glRasterPos4f __GlueRasterPos4f;
		static __glRasterPos4fv __GlueRasterPos4fv;
		static __glRasterPos4i __GlueRasterPos4i;
		static __glRasterPos4iv __GlueRasterPos4iv;
		static __glRasterPos4s __GlueRasterPos4s;
		static __glRasterPos4sv __GlueRasterPos4sv;
		static __glReadBuffer __GlueReadBuffer;
		static __glReadPixels __GlueReadPixels;
		static __glRectd __GlueRectd;
		static __glRectdv __GlueRectdv;
		static __glRectf __GlueRectf;
		static __glRectfv __GlueRectfv;
		static __glRecti __GlueRecti;
		static __glRectiv __GlueRectiv;
		static __glRects __GlueRects;
		static __glRectsv __GlueRectsv;
		static __glRenderMode __GlueRenderMode;
		static __glRotated __GlueRotated;
		static __glRotatef __GlueRotatef;
		static __glScaled __GlueScaled;
		static __glScalef __GlueScalef;
		static __glScissor __GlueScissor;
		static __glSelectBuffer __GlueSelectBuffer;
		static __glShadeModel __GlueShadeModel;
		static __glStencilFunc __GlueStencilFunc;
		static __glStencilMask __GlueStencilMask;
		static __glStencilOp __GlueStencilOp;
		static __glTexCoord1d __GlueTexCoord1d;
		static __glTexCoord1dv __GlueTexCoord1dv;
		static __glTexCoord1f __GlueTexCoord1f;
		static __glTexCoord1fv __GlueTexCoord1fv;
		static __glTexCoord1i __GlueTexCoord1i;
		static __glTexCoord1iv __GlueTexCoord1iv;
		static __glTexCoord1s __GlueTexCoord1s;
		static __glTexCoord1sv __GlueTexCoord1sv;
		static __glTexCoord2d __GlueTexCoord2d;
		static __glTexCoord2dv __GlueTexCoord2dv;
		static __glTexCoord2f __GlueTexCoord2f;
		static __glTexCoord2fv __GlueTexCoord2fv;
		static __glTexCoord2i __GlueTexCoord2i;
		static __glTexCoord2iv __GlueTexCoord2iv;
		static __glTexCoord2s __GlueTexCoord2s;
		static __glTexCoord2sv __GlueTexCoord2sv;
		static __glTexCoord3d __GlueTexCoord3d;
		static __glTexCoord3dv __GlueTexCoord3dv;
		static __glTexCoord3f __GlueTexCoord3f;
		static __glTexCoord3fv __GlueTexCoord3fv;
		static __glTexCoord3i __GlueTexCoord3i;
		static __glTexCoord3iv __GlueTexCoord3iv;
		static __glTexCoord3s __GlueTexCoord3s;
		static __glTexCoord3sv __GlueTexCoord3sv;
		static __glTexCoord4d __GlueTexCoord4d;
		static __glTexCoord4dv __GlueTexCoord4dv;
		static __glTexCoord4f __GlueTexCoord4f;
		static __glTexCoord4fv __GlueTexCoord4fv;
		static __glTexCoord4i __GlueTexCoord4i;
		static __glTexCoord4iv __GlueTexCoord4iv;
		static __glTexCoord4s __GlueTexCoord4s;
		static __glTexCoord4sv __GlueTexCoord4sv;
		static __glTexCoordPointer __GlueTexCoordPointer;
		static __glTexEnvf __GlueTexEnvf;
		static __glTexEnvfv __GlueTexEnvfv;
		static __glTexEnvi __GlueTexEnvi;
		static __glTexEnviv __GlueTexEnviv;
		static __glTexGend __GlueTexGend;
		static __glTexGendv __GlueTexGendv;
		static __glTexGenf __GlueTexGenf;
		static __glTexGenfv __GlueTexGenfv;
		static __glTexGeni __GlueTexGeni;
		static __glTexGeniv __GlueTexGeniv;
		static __glTexImage1D __GlueTexImage1D;
		static __glTexImage2D __GlueTexImage2D;
		static __glTexParameterf __GlueTexParameterf;
		static __glTexParameterfv __GlueTexParameterfv;
		static __glTexParameteri __GlueTexParameteri;
		static __glTexParameteriv __GlueTexParameteriv;
		static __glTexSubImage1D __GlueTexSubImage1D;
		static __glTexSubImage2D __GlueTexSubImage2D;
		static __glTranslated __GlueTranslated;
		static __glTranslatef __GlueTranslatef;
		static __glVertex2d __GlueVertex2d;
		static __glVertex2dv __GlueVertex2dv;
		static __glVertex2f __GlueVertex2f;
		static __glVertex2fv __GlueVertex2fv;
		static __glVertex2i __GlueVertex2i;
		static __glVertex2iv __GlueVertex2iv;
		static __glVertex2s __GlueVertex2s;
		static __glVertex2sv __GlueVertex2sv;
		static __glVertex3d __GlueVertex3d;
		static __glVertex3dv __GlueVertex3dv;
		static __glVertex3f __GlueVertex3f;
		static __glVertex3fv __GlueVertex3fv;
		static __glVertex3i __GlueVertex3i;
		static __glVertex3iv __GlueVertex3iv;
		static __glVertex3s __GlueVertex3s;
		static __glVertex3sv __GlueVertex3sv;
		static __glVertex4d __GlueVertex4d;
		static __glVertex4dv __GlueVertex4dv;
		static __glVertex4f __GlueVertex4f;
		static __glVertex4fv __GlueVertex4fv;
		static __glVertex4i __GlueVertex4i;
		static __glVertex4iv __GlueVertex4iv;
		static __glVertex4s __GlueVertex4s;
		static __glVertex4sv __GlueVertex4sv;
		static __glVertexPointer __GlueVertexPointer;
		static __glViewport __GlueViewport;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glAccum(uint op, float value) => __GlueAccum(op, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glAlphaFunc(uint func, float reference) => __GlueAlphaFunc(func, reference);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glAreTexturesResident(int n, uint* textures, bool* residences) => __GlueAreTexturesResident(n, textures, residences);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glArrayElement(int i) => __GlueArrayElement(i);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBegin(uint mode) => __GlueBegin(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBindTexture(uint target, uint texture) => __GlueBindTexture(target, texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) => __GlueBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glBlendFunc(uint sfactor, uint dfactor) => __GlueBlendFunc(sfactor, dfactor);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCallList(uint list) => __GlueCallList(list);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCallLists(int n, uint type, IntPtr lists) => __GlueCallLists(n, type, lists);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClear(uint mask) => __GlueClear(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearAccum(float red, float green, float blue, float alpha) => __GlueClearAccum(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearColor(float red, float green, float blue, float alpha) => __GlueClearColor(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearDepth(double depth) => __GlueClearDepth(depth);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearIndex(float c) => __GlueClearIndex(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClearStencil(int s) => __GlueClearStencil(s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glClipPlane(uint plane, double* equation) => __GlueClipPlane(plane, equation);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3b(sbyte red, sbyte green, sbyte blue) => __GlueColor3b(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3bv(sbyte* v) => __GlueColor3bv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3d(double red, double green, double blue) => __GlueColor3d(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3dv(double* v) => __GlueColor3dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3f(float red, float green, float blue) => __GlueColor3f(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3fv(float* v) => __GlueColor3fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3i(int red, int green, int blue) => __GlueColor3i(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3iv(int* v) => __GlueColor3iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3s(short red, short green, short blue) => __GlueColor3s(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3sv(short* v) => __GlueColor3sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3ub(byte red, byte green, byte blue) => __GlueColor3ub(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3ubv(byte* v) => __GlueColor3ubv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3ui(uint red, uint green, uint blue) => __GlueColor3ui(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3uiv(uint* v) => __GlueColor3uiv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3us(ushort red, ushort green, ushort blue) => __GlueColor3us(red, green, blue);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor3usv(ushort* v) => __GlueColor3usv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) => __GlueColor4b(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4bv(sbyte* v) => __GlueColor4bv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4d(double red, double green, double blue, double alpha) => __GlueColor4d(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4dv(double* v) => __GlueColor4dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4f(float red, float green, float blue, float alpha) => __GlueColor4f(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4fv(float* v) => __GlueColor4fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4i(int red, int green, int blue, int alpha) => __GlueColor4i(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4iv(int* v) => __GlueColor4iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4s(short red, short green, short blue, short alpha) => __GlueColor4s(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4sv(short* v) => __GlueColor4sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4ub(byte red, byte green, byte blue, byte alpha) => __GlueColor4ub(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4ubv(byte* v) => __GlueColor4ubv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4ui(uint red, uint green, uint blue, uint alpha) => __GlueColor4ui(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4uiv(uint* v) => __GlueColor4uiv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4us(ushort red, ushort green, ushort blue, ushort alpha) => __GlueColor4us(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColor4usv(ushort* v) => __GlueColor4usv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorMask(bool red, bool green, bool blue, bool alpha) => __GlueColorMask(red, green, blue, alpha);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorMaterial(uint face, uint mode) => __GlueColorMaterial(face, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorPointer(int size, uint type, int stride, IntPtr pointer) => __GlueColorPointer(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyPixels(int x, int y, int width, int height, uint type) => __GlueCopyPixels(x, y, width, height, type);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border) => __GlueCopyTexImage1D(target, level, internalFormat, x, y, width, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border) => __GlueCopyTexImage2D(target, level, internalFormat, x, y, width, height, border);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) => __GlueCopyTexSubImage1D(target, level, xoffset, x, y, width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => __GlueCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCullFace(uint mode) => __GlueCullFace(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteLists(uint list, int range) => __GlueDeleteLists(list, range);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteTextures(int n, uint* textures) => __GlueDeleteTextures(n, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthFunc(uint func) => __GlueDepthFunc(func);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthMask(bool flag) => __GlueDepthMask(flag);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDepthRange(double zNear, double zFar) => __GlueDepthRange(zNear, zFar);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisable(uint cap) => __GlueDisable(cap);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDisableClientState(uint array) => __GlueDisableClientState(array);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawArrays(uint mode, int first, int count) => __GlueDrawArrays(mode, first, count);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawBuffer(uint mode) => __GlueDrawBuffer(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawElements(uint mode, int count, uint type, IntPtr indices) => __GlueDrawElements(mode, count, type, indices);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDrawPixels(int width, int height, uint format, uint type, IntPtr pixels) => __GlueDrawPixels(width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEdgeFlag(bool flag) => __GlueEdgeFlag(flag);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEdgeFlagPointer(int stride, IntPtr pointer) => __GlueEdgeFlagPointer(stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEdgeFlagv(bool* flag) => __GlueEdgeFlagv(flag);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnable(uint cap) => __GlueEnable(cap);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnableClientState(uint array) => __GlueEnableClientState(array);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEnd( ) => __GlueEnd();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEndList( ) => __GlueEndList();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord1d(double u) => __GlueEvalCoord1d(u);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord1dv(double* u) => __GlueEvalCoord1dv(u);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord1f(float u) => __GlueEvalCoord1f(u);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord1fv(float* u) => __GlueEvalCoord1fv(u);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord2d(double u, double v) => __GlueEvalCoord2d(u, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord2dv(double* u) => __GlueEvalCoord2dv(u);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord2f(float u, float v) => __GlueEvalCoord2f(u, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalCoord2fv(float* u) => __GlueEvalCoord2fv(u);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalMesh1(uint mode, int i1, int i2) => __GlueEvalMesh1(mode, i1, i2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2) => __GlueEvalMesh2(mode, i1, i2, j1, j2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalPoint1(int i) => __GlueEvalPoint1(i);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glEvalPoint2(int i, int j) => __GlueEvalPoint2(i, j);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFeedbackBuffer(int size, uint type, float* buffer) => __GlueFeedbackBuffer(size, type, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFinish( ) => __GlueFinish();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFlush( ) => __GlueFlush();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogf(uint pname, float param) => __GlueFogf(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogfv(uint pname, float* parameters) => __GlueFogfv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogi(uint pname, int param) => __GlueFogi(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFogiv(uint pname, int* parameters) => __GlueFogiv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFrontFace(uint mode) => __GlueFrontFace(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) => __GlueFrustum(left, right, bottom, top, zNear, zFar);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGenLists(int range) => __GlueGenLists(range);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGenTextures(int n, uint* textures) => __GlueGenTextures(n, textures);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetBooleanv(uint pname, bool* parameters) => __GlueGetBooleanv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetClipPlane(uint plane, double* equation) => __GlueGetClipPlane(plane, equation);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetDoublev(uint pname, double* parameters) => __GlueGetDoublev(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetError( ) => __GlueGetError();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFloatv(uint pname, float* parameters) => __GlueGetFloatv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetIntegerv(uint pname, int* parameters) => __GlueGetIntegerv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetLightfv(uint light, uint pname, float* parameters) => __GlueGetLightfv(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetLightiv(uint light, uint pname, int* parameters) => __GlueGetLightiv(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMapdv(uint target, uint query, double* v) => __GlueGetMapdv(target, query, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMapfv(uint target, uint query, float* v) => __GlueGetMapfv(target, query, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMapiv(uint target, uint query, int* v) => __GlueGetMapiv(target, query, v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMaterialfv(uint face, uint pname, float* parameters) => __GlueGetMaterialfv(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetMaterialiv(uint face, uint pname, int* parameters) => __GlueGetMaterialiv(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPixelMapfv(uint map, float* values) => __GlueGetPixelMapfv(map, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPixelMapuiv(uint map, uint* values) => __GlueGetPixelMapuiv(map, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPixelMapusv(uint map, ushort* values) => __GlueGetPixelMapusv(map, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPointerv(uint pname, IntPtr* parameters) => __GlueGetPointerv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetPolygonStipple(byte* mask) => __GlueGetPolygonStipple(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe  byte * glGetString(uint name) => __GlueGetString(name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexEnvfv(uint target, uint pname, float* parameters) => __GlueGetTexEnvfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexEnviv(uint target, uint pname, int* parameters) => __GlueGetTexEnviv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexGendv(uint coord, uint pname, double* parameters) => __GlueGetTexGendv(coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexGenfv(uint coord, uint pname, float* parameters) => __GlueGetTexGenfv(coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexGeniv(uint coord, uint pname, int* parameters) => __GlueGetTexGeniv(coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexImage(uint target, int level, uint format, uint type, IntPtr pixels) => __GlueGetTexImage(target, level, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexLevelParameterfv(uint target, int level, uint pname, float* parameters) => __GlueGetTexLevelParameterfv(target, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexLevelParameteriv(uint target, int level, uint pname, int* parameters) => __GlueGetTexLevelParameteriv(target, level, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexParameterfv(uint target, uint pname, float* parameters) => __GlueGetTexParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetTexParameteriv(uint target, uint pname, int* parameters) => __GlueGetTexParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glHint(uint target, uint mode) => __GlueHint(target, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexMask(uint mask) => __GlueIndexMask(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexPointer(uint type, int stride, IntPtr pointer) => __GlueIndexPointer(type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexd(double c) => __GlueIndexd(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexdv(double* c) => __GlueIndexdv(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexf(float c) => __GlueIndexf(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexfv(float* c) => __GlueIndexfv(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexi(int c) => __GlueIndexi(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexiv(int* c) => __GlueIndexiv(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexs(short c) => __GlueIndexs(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexsv(short* c) => __GlueIndexsv(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexub(byte c) => __GlueIndexub(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glIndexubv(byte* c) => __GlueIndexubv(c);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInitNames( ) => __GlueInitNames();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glInterleavedArrays(uint format, int stride, IntPtr pointer) => __GlueInterleavedArrays(format, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsEnabled(uint cap) => __GlueIsEnabled(cap);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsList(uint list) => __GlueIsList(list);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsTexture(uint texture) => __GlueIsTexture(texture);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightModelf(uint pname, float param) => __GlueLightModelf(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightModelfv(uint pname, float* parameters) => __GlueLightModelfv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightModeli(uint pname, int param) => __GlueLightModeli(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightModeliv(uint pname, int* parameters) => __GlueLightModeliv(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightf(uint light, uint pname, float param) => __GlueLightf(light, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightfv(uint light, uint pname, float* parameters) => __GlueLightfv(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLighti(uint light, uint pname, int param) => __GlueLighti(light, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightiv(uint light, uint pname, int* parameters) => __GlueLightiv(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLineStipple(int factor, ushort pattern) => __GlueLineStipple(factor, pattern);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLineWidth(float width) => __GlueLineWidth(width);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glListBase(uint base_) => __GlueListBase(base_);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadIdentity( ) => __GlueLoadIdentity();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadMatrixd(double* m) => __GlueLoadMatrixd(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadMatrixf(float* m) => __GlueLoadMatrixf(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLoadName(uint name) => __GlueLoadName(name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLogicOp(uint opcode) => __GlueLogicOp(opcode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMap1d(uint target, double u1, double u2, int stride, int order, double* points) => __GlueMap1d(target, u1, u2, stride, order, points);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMap1f(uint target, float u1, float u2, int stride, int order, float* points) => __GlueMap1f(target, u1, u2, stride, order, points);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) => __GlueMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) => __GlueMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMapGrid1d(int un, double u1, double u2) => __GlueMapGrid1d(un, u1, u2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMapGrid1f(int un, float u1, float u2) => __GlueMapGrid1f(un, u1, u2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) => __GlueMapGrid2d(un, u1, u2, vn, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) => __GlueMapGrid2f(un, u1, u2, vn, v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMaterialf(uint face, uint pname, float param) => __GlueMaterialf(face, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMaterialfv(uint face, uint pname, float* parameters) => __GlueMaterialfv(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMateriali(uint face, uint pname, int param) => __GlueMateriali(face, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMaterialiv(uint face, uint pname, int* parameters) => __GlueMaterialiv(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMatrixMode(uint mode) => __GlueMatrixMode(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultMatrixd(double* m) => __GlueMultMatrixd(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultMatrixf(float* m) => __GlueMultMatrixf(m);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNewList(uint list, uint mode) => __GlueNewList(list, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3b(sbyte nx, sbyte ny, sbyte nz) => __GlueNormal3b(nx, ny, nz);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3bv(sbyte* v) => __GlueNormal3bv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3d(double nx, double ny, double nz) => __GlueNormal3d(nx, ny, nz);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3dv(double* v) => __GlueNormal3dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3f(float nx, float ny, float nz) => __GlueNormal3f(nx, ny, nz);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3fv(float* v) => __GlueNormal3fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3i(int nx, int ny, int nz) => __GlueNormal3i(nx, ny, nz);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3iv(int* v) => __GlueNormal3iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3s(short nx, short ny, short nz) => __GlueNormal3s(nx, ny, nz);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormal3sv(short* v) => __GlueNormal3sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormalPointer(uint type, int stride, IntPtr pointer) => __GlueNormalPointer(type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) => __GlueOrtho(left, right, bottom, top, zNear, zFar);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPassThrough(float token) => __GluePassThrough(token);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelMapfv(uint map, int mapsize, float* values) => __GluePixelMapfv(map, mapsize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelMapuiv(uint map, int mapsize, uint* values) => __GluePixelMapuiv(map, mapsize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelMapusv(uint map, int mapsize, ushort* values) => __GluePixelMapusv(map, mapsize, values);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelStoref(uint pname, float param) => __GluePixelStoref(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelStorei(uint pname, int param) => __GluePixelStorei(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelTransferf(uint pname, float param) => __GluePixelTransferf(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelTransferi(uint pname, int param) => __GluePixelTransferi(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPixelZoom(float xfactor, float yfactor) => __GluePixelZoom(xfactor, yfactor);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPointSize(float size) => __GluePointSize(size);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPolygonMode(uint face, uint mode) => __GluePolygonMode(face, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPolygonOffset(float factor, float units) => __GluePolygonOffset(factor, units);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPolygonStipple(byte* mask) => __GluePolygonStipple(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPopAttrib( ) => __GluePopAttrib();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPopClientAttrib( ) => __GluePopClientAttrib();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPopMatrix( ) => __GluePopMatrix();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPopName( ) => __GluePopName();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPrioritizeTextures(int n, uint* textures, float* priorities) => __GluePrioritizeTextures(n, textures, priorities);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPushAttrib(uint mask) => __GluePushAttrib(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPushClientAttrib(uint mask) => __GluePushClientAttrib(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPushMatrix( ) => __GluePushMatrix();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glPushName(uint name) => __GluePushName(name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2d(double x, double y) => __GlueRasterPos2d(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2dv(double* v) => __GlueRasterPos2dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2f(float x, float y) => __GlueRasterPos2f(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2fv(float* v) => __GlueRasterPos2fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2i(int x, int y) => __GlueRasterPos2i(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2iv(int* v) => __GlueRasterPos2iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2s(short x, short y) => __GlueRasterPos2s(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos2sv(short* v) => __GlueRasterPos2sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3d(double x, double y, double z) => __GlueRasterPos3d(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3dv(double* v) => __GlueRasterPos3dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3f(float x, float y, float z) => __GlueRasterPos3f(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3fv(float* v) => __GlueRasterPos3fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3i(int x, int y, int z) => __GlueRasterPos3i(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3iv(int* v) => __GlueRasterPos3iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3s(short x, short y, short z) => __GlueRasterPos3s(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos3sv(short* v) => __GlueRasterPos3sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4d(double x, double y, double z, double w) => __GlueRasterPos4d(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4dv(double* v) => __GlueRasterPos4dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4f(float x, float y, float z, float w) => __GlueRasterPos4f(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4fv(float* v) => __GlueRasterPos4fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4i(int x, int y, int z, int w) => __GlueRasterPos4i(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4iv(int* v) => __GlueRasterPos4iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4s(short x, short y, short z, short w) => __GlueRasterPos4s(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRasterPos4sv(short* v) => __GlueRasterPos4sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glReadBuffer(uint mode) => __GlueReadBuffer(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels) => __GlueReadPixels(x, y, width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRectd(double x1, double y1, double x2, double y2) => __GlueRectd(x1, y1, x2, y2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRectdv(double* v1, double* v2) => __GlueRectdv(v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRectf(float x1, float y1, float x2, float y2) => __GlueRectf(x1, y1, x2, y2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRectfv(float* v1, float* v2) => __GlueRectfv(v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRecti(int x1, int y1, int x2, int y2) => __GlueRecti(x1, y1, x2, y2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRectiv(int* v1, int* v2) => __GlueRectiv(v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRects(short x1, short y1, short x2, short y2) => __GlueRects(x1, y1, x2, y2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRectsv(short* v1, short* v2) => __GlueRectsv(v1, v2);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe int glRenderMode(uint mode) => __GlueRenderMode(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRotated(double angle, double x, double y, double z) => __GlueRotated(angle, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glRotatef(float angle, float x, float y, float z) => __GlueRotatef(angle, x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glScaled(double x, double y, double z) => __GlueScaled(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glScalef(float x, float y, float z) => __GlueScalef(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glScissor(int x, int y, int width, int height) => __GlueScissor(x, y, width, height);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSelectBuffer(int size, uint* buffer) => __GlueSelectBuffer(size, buffer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glShadeModel(uint mode) => __GlueShadeModel(mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glStencilFunc(uint func, int reference, uint mask) => __GlueStencilFunc(func, reference, mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glStencilMask(uint mask) => __GlueStencilMask(mask);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glStencilOp(uint fail, uint zfail, uint zpass) => __GlueStencilOp(fail, zfail, zpass);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1d(double s) => __GlueTexCoord1d(s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1dv(double* v) => __GlueTexCoord1dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1f(float s) => __GlueTexCoord1f(s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1fv(float* v) => __GlueTexCoord1fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1i(int s) => __GlueTexCoord1i(s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1iv(int* v) => __GlueTexCoord1iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1s(short s) => __GlueTexCoord1s(s);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord1sv(short* v) => __GlueTexCoord1sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2d(double s, double t) => __GlueTexCoord2d(s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2dv(double* v) => __GlueTexCoord2dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2f(float s, float t) => __GlueTexCoord2f(s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2fv(float* v) => __GlueTexCoord2fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2i(int s, int t) => __GlueTexCoord2i(s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2iv(int* v) => __GlueTexCoord2iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2s(short s, short t) => __GlueTexCoord2s(s, t);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord2sv(short* v) => __GlueTexCoord2sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3d(double s, double t, double r) => __GlueTexCoord3d(s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3dv(double* v) => __GlueTexCoord3dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3f(float s, float t, float r) => __GlueTexCoord3f(s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3fv(float* v) => __GlueTexCoord3fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3i(int s, int t, int r) => __GlueTexCoord3i(s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3iv(int* v) => __GlueTexCoord3iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3s(short s, short t, short r) => __GlueTexCoord3s(s, t, r);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord3sv(short* v) => __GlueTexCoord3sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4d(double s, double t, double r, double q) => __GlueTexCoord4d(s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4dv(double* v) => __GlueTexCoord4dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4f(float s, float t, float r, float q) => __GlueTexCoord4f(s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4fv(float* v) => __GlueTexCoord4fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4i(int s, int t, int r, int q) => __GlueTexCoord4i(s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4iv(int* v) => __GlueTexCoord4iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4s(short s, short t, short r, short q) => __GlueTexCoord4s(s, t, r, q);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoord4sv(short* v) => __GlueTexCoord4sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordPointer(int size, uint type, int stride, IntPtr pointer) => __GlueTexCoordPointer(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexEnvf(uint target, uint pname, float param) => __GlueTexEnvf(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexEnvfv(uint target, uint pname, float* parameters) => __GlueTexEnvfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexEnvi(uint target, uint pname, int param) => __GlueTexEnvi(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexEnviv(uint target, uint pname, int* parameters) => __GlueTexEnviv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexGend(uint coord, uint pname, double param) => __GlueTexGend(coord, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexGendv(uint coord, uint pname, double* parameters) => __GlueTexGendv(coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexGenf(uint coord, uint pname, float param) => __GlueTexGenf(coord, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexGenfv(uint coord, uint pname, float* parameters) => __GlueTexGenfv(coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexGeni(uint coord, uint pname, int param) => __GlueTexGeni(coord, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexGeniv(uint coord, uint pname, int* parameters) => __GlueTexGeniv(coord, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels) => __GlueTexImage1D(target, level, internalformat, width, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels) => __GlueTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameterf(uint target, uint pname, float param) => __GlueTexParameterf(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameterfv(uint target, uint pname, float* parameters) => __GlueTexParameterfv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameteri(uint target, uint pname, int param) => __GlueTexParameteri(target, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexParameteriv(uint target, uint pname, int* parameters) => __GlueTexParameteriv(target, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) => __GlueTexSubImage1D(target, level, xoffset, width, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) => __GlueTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTranslated(double x, double y, double z) => __GlueTranslated(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTranslatef(float x, float y, float z) => __GlueTranslatef(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2d(double x, double y) => __GlueVertex2d(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2dv(double* v) => __GlueVertex2dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2f(float x, float y) => __GlueVertex2f(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2fv(float* v) => __GlueVertex2fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2i(int x, int y) => __GlueVertex2i(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2iv(int* v) => __GlueVertex2iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2s(short x, short y) => __GlueVertex2s(x, y);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex2sv(short* v) => __GlueVertex2sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3d(double x, double y, double z) => __GlueVertex3d(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3dv(double* v) => __GlueVertex3dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3f(float x, float y, float z) => __GlueVertex3f(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3fv(float* v) => __GlueVertex3fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3i(int x, int y, int z) => __GlueVertex3i(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3iv(int* v) => __GlueVertex3iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3s(short x, short y, short z) => __GlueVertex3s(x, y, z);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex3sv(short* v) => __GlueVertex3sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4d(double x, double y, double z, double w) => __GlueVertex4d(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4dv(double* v) => __GlueVertex4dv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4f(float x, float y, float z, float w) => __GlueVertex4f(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4fv(float* v) => __GlueVertex4fv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4i(int x, int y, int z, int w) => __GlueVertex4i(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4iv(int* v) => __GlueVertex4iv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4s(short x, short y, short z, short w) => __GlueVertex4s(x, y, z, w);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertex4sv(short* v) => __GlueVertex4sv(v);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexPointer(int size, uint type, int stride, IntPtr pointer) => __GlueVertexPointer(size, type, stride, pointer);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glViewport(int x, int y, int width, int height) => __GlueViewport(x, y, width, height);

	}
}


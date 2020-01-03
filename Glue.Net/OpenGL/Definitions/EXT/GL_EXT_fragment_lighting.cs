using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_EXT {

    public static bool GL_EXT_fragment_lighting {get; private set;}

		public const int GL_FRAGMENT_LIGHTING_EXT = 0x8400;
		public const int GL_FRAGMENT_COLOR_MATERIAL_EXT = 0x8401;
		public const int GL_FRAGMENT_COLOR_MATERIAL_FACE_EXT = 0x8402;
		public const int GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_EXT = 0x8403;
		public const int GL_MAX_FRAGMENT_LIGHTS_EXT = 0x8404;
		public const int GL_MAX_ACTIVE_LIGHTS_EXT = 0x8405;
		public const int GL_CURRENT_RASTER_NORMAL_EXT = 0x8406;
		public const int GL_LIGHT_ENV_MODE_EXT = 0x8407;
		public const int GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_EXT = 0x8408;
		public const int GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_EXT = 0x8409;
		public const int GL_FRAGMENT_LIGHT_MODEL_AMBIENT_EXT = 0x840A;
		public const int GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_EXT = 0x840B;
		public const int GL_FRAGMENT_LIGHT0_EXT = 0x840C;
		public const int GL_FRAGMENT_LIGHT7_EXT = 0x8413;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentColorMaterialEXT(uint face, uint mode);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightModelfEXT(uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightModelfvEXT(uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightModeliEXT(uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightModelivEXT(uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightfEXT(uint light, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightfvEXT(uint light, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightiEXT(uint light, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentLightivEXT(uint light, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentMaterialfEXT(uint face, uint pname, float param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentMaterialfvEXT(uint face, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentMaterialiEXT(uint face, uint pname, int param);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glFragmentMaterialivEXT(uint face, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFragmentLightfvEXT(uint light, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFragmentLightivEXT(uint light, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFragmentMaterialfvEXT(uint face, uint pname, float* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetFragmentMaterialivEXT(uint face, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glLightEnviEXT(uint pname, int param);

 		static __glFragmentColorMaterialEXT __GlueFragmentColorMaterialEXT;
		static __glFragmentLightModelfEXT __GlueFragmentLightModelfEXT;
		static __glFragmentLightModelfvEXT __GlueFragmentLightModelfvEXT;
		static __glFragmentLightModeliEXT __GlueFragmentLightModeliEXT;
		static __glFragmentLightModelivEXT __GlueFragmentLightModelivEXT;
		static __glFragmentLightfEXT __GlueFragmentLightfEXT;
		static __glFragmentLightfvEXT __GlueFragmentLightfvEXT;
		static __glFragmentLightiEXT __GlueFragmentLightiEXT;
		static __glFragmentLightivEXT __GlueFragmentLightivEXT;
		static __glFragmentMaterialfEXT __GlueFragmentMaterialfEXT;
		static __glFragmentMaterialfvEXT __GlueFragmentMaterialfvEXT;
		static __glFragmentMaterialiEXT __GlueFragmentMaterialiEXT;
		static __glFragmentMaterialivEXT __GlueFragmentMaterialivEXT;
		static __glGetFragmentLightfvEXT __GlueGetFragmentLightfvEXT;
		static __glGetFragmentLightivEXT __GlueGetFragmentLightivEXT;
		static __glGetFragmentMaterialfvEXT __GlueGetFragmentMaterialfvEXT;
		static __glGetFragmentMaterialivEXT __GlueGetFragmentMaterialivEXT;
		static __glLightEnviEXT __GlueLightEnviEXT;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentColorMaterialEXT(uint face, uint mode) => __GlueFragmentColorMaterialEXT(face, mode);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightModelfEXT(uint pname, float param) => __GlueFragmentLightModelfEXT(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightModelfvEXT(uint pname, float* parameters) => __GlueFragmentLightModelfvEXT(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightModeliEXT(uint pname, int param) => __GlueFragmentLightModeliEXT(pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightModelivEXT(uint pname, int* parameters) => __GlueFragmentLightModelivEXT(pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightfEXT(uint light, uint pname, float param) => __GlueFragmentLightfEXT(light, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightfvEXT(uint light, uint pname, float* parameters) => __GlueFragmentLightfvEXT(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightiEXT(uint light, uint pname, int param) => __GlueFragmentLightiEXT(light, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentLightivEXT(uint light, uint pname, int* parameters) => __GlueFragmentLightivEXT(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentMaterialfEXT(uint face, uint pname, float param) => __GlueFragmentMaterialfEXT(face, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentMaterialfvEXT(uint face, uint pname, float* parameters) => __GlueFragmentMaterialfvEXT(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentMaterialiEXT(uint face, uint pname, int param) => __GlueFragmentMaterialiEXT(face, pname, param);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glFragmentMaterialivEXT(uint face, uint pname, int* parameters) => __GlueFragmentMaterialivEXT(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFragmentLightfvEXT(uint light, uint pname, float* parameters) => __GlueGetFragmentLightfvEXT(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFragmentLightivEXT(uint light, uint pname, int* parameters) => __GlueGetFragmentLightivEXT(light, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFragmentMaterialfvEXT(uint face, uint pname, float* parameters) => __GlueGetFragmentMaterialfvEXT(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetFragmentMaterialivEXT(uint face, uint pname, int* parameters) => __GlueGetFragmentMaterialivEXT(face, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glLightEnviEXT(uint pname, int param) => __GlueLightEnviEXT(pname, param);



	}
}


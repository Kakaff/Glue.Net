using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_vertex_type_2_10_10_10_rev {get; private set;}

		public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const int GL_INT_2_10_10_10_REV = 0x8D9F;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorP3ui(uint type, uint color);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorP3uiv(uint type, uint* color);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorP4ui(uint type, uint color);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glColorP4uiv(uint type, uint* color);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP1ui(uint texture, uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP1uiv(uint texture, uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP2ui(uint texture, uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP2uiv(uint texture, uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP3ui(uint texture, uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP3uiv(uint texture, uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP4ui(uint texture, uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glMultiTexCoordP4uiv(uint texture, uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormalP3ui(uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNormalP3uiv(uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColorP3ui(uint type, uint color);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glSecondaryColorP3uiv(uint type, uint* color);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP1ui(uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP1uiv(uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP2ui(uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP2uiv(uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP3ui(uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP3uiv(uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP4ui(uint type, uint coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glTexCoordP4uiv(uint type, uint* coords);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP1ui(uint index, uint type, bool normalized, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP2ui(uint index, uint type, bool normalized, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP3ui(uint index, uint type, bool normalized, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP4ui(uint index, uint type, bool normalized, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexP2ui(uint type, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexP2uiv(uint type, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexP3ui(uint type, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexP3uiv(uint type, uint* value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexP4ui(uint type, uint value);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glVertexP4uiv(uint type, uint* value);

 		static __glColorP3ui __GlueColorP3ui;
		static __glColorP3uiv __GlueColorP3uiv;
		static __glColorP4ui __GlueColorP4ui;
		static __glColorP4uiv __GlueColorP4uiv;
		static __glMultiTexCoordP1ui __GlueMultiTexCoordP1ui;
		static __glMultiTexCoordP1uiv __GlueMultiTexCoordP1uiv;
		static __glMultiTexCoordP2ui __GlueMultiTexCoordP2ui;
		static __glMultiTexCoordP2uiv __GlueMultiTexCoordP2uiv;
		static __glMultiTexCoordP3ui __GlueMultiTexCoordP3ui;
		static __glMultiTexCoordP3uiv __GlueMultiTexCoordP3uiv;
		static __glMultiTexCoordP4ui __GlueMultiTexCoordP4ui;
		static __glMultiTexCoordP4uiv __GlueMultiTexCoordP4uiv;
		static __glNormalP3ui __GlueNormalP3ui;
		static __glNormalP3uiv __GlueNormalP3uiv;
		static __glSecondaryColorP3ui __GlueSecondaryColorP3ui;
		static __glSecondaryColorP3uiv __GlueSecondaryColorP3uiv;
		static __glTexCoordP1ui __GlueTexCoordP1ui;
		static __glTexCoordP1uiv __GlueTexCoordP1uiv;
		static __glTexCoordP2ui __GlueTexCoordP2ui;
		static __glTexCoordP2uiv __GlueTexCoordP2uiv;
		static __glTexCoordP3ui __GlueTexCoordP3ui;
		static __glTexCoordP3uiv __GlueTexCoordP3uiv;
		static __glTexCoordP4ui __GlueTexCoordP4ui;
		static __glTexCoordP4uiv __GlueTexCoordP4uiv;
		static __glVertexAttribP1ui __GlueVertexAttribP1ui;
		static __glVertexAttribP1uiv __GlueVertexAttribP1uiv;
		static __glVertexAttribP2ui __GlueVertexAttribP2ui;
		static __glVertexAttribP2uiv __GlueVertexAttribP2uiv;
		static __glVertexAttribP3ui __GlueVertexAttribP3ui;
		static __glVertexAttribP3uiv __GlueVertexAttribP3uiv;
		static __glVertexAttribP4ui __GlueVertexAttribP4ui;
		static __glVertexAttribP4uiv __GlueVertexAttribP4uiv;
		static __glVertexP2ui __GlueVertexP2ui;
		static __glVertexP2uiv __GlueVertexP2uiv;
		static __glVertexP3ui __GlueVertexP3ui;
		static __glVertexP3uiv __GlueVertexP3uiv;
		static __glVertexP4ui __GlueVertexP4ui;
		static __glVertexP4uiv __GlueVertexP4uiv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorP3ui(uint type, uint color) => __GlueColorP3ui(type, color);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorP3uiv(uint type, uint* color) => __GlueColorP3uiv(type, color);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorP4ui(uint type, uint color) => __GlueColorP4ui(type, color);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glColorP4uiv(uint type, uint* color) => __GlueColorP4uiv(type, color);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP1ui(uint texture, uint type, uint coords) => __GlueMultiTexCoordP1ui(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP1uiv(uint texture, uint type, uint* coords) => __GlueMultiTexCoordP1uiv(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP2ui(uint texture, uint type, uint coords) => __GlueMultiTexCoordP2ui(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP2uiv(uint texture, uint type, uint* coords) => __GlueMultiTexCoordP2uiv(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP3ui(uint texture, uint type, uint coords) => __GlueMultiTexCoordP3ui(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP3uiv(uint texture, uint type, uint* coords) => __GlueMultiTexCoordP3uiv(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP4ui(uint texture, uint type, uint coords) => __GlueMultiTexCoordP4ui(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glMultiTexCoordP4uiv(uint texture, uint type, uint* coords) => __GlueMultiTexCoordP4uiv(texture, type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormalP3ui(uint type, uint coords) => __GlueNormalP3ui(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNormalP3uiv(uint type, uint* coords) => __GlueNormalP3uiv(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColorP3ui(uint type, uint color) => __GlueSecondaryColorP3ui(type, color);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glSecondaryColorP3uiv(uint type, uint* color) => __GlueSecondaryColorP3uiv(type, color);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP1ui(uint type, uint coords) => __GlueTexCoordP1ui(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP1uiv(uint type, uint* coords) => __GlueTexCoordP1uiv(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP2ui(uint type, uint coords) => __GlueTexCoordP2ui(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP2uiv(uint type, uint* coords) => __GlueTexCoordP2uiv(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP3ui(uint type, uint coords) => __GlueTexCoordP3ui(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP3uiv(uint type, uint* coords) => __GlueTexCoordP3uiv(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP4ui(uint type, uint coords) => __GlueTexCoordP4ui(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glTexCoordP4uiv(uint type, uint* coords) => __GlueTexCoordP4uiv(type, coords);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value) => __GlueVertexAttribP1ui(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value) => __GlueVertexAttribP1uiv(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value) => __GlueVertexAttribP2ui(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value) => __GlueVertexAttribP2uiv(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value) => __GlueVertexAttribP3ui(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value) => __GlueVertexAttribP3uiv(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value) => __GlueVertexAttribP4ui(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value) => __GlueVertexAttribP4uiv(index, type, normalized, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexP2ui(uint type, uint value) => __GlueVertexP2ui(type, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexP2uiv(uint type, uint* value) => __GlueVertexP2uiv(type, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexP3ui(uint type, uint value) => __GlueVertexP3ui(type, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexP3uiv(uint type, uint* value) => __GlueVertexP3uiv(type, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexP4ui(uint type, uint value) => __GlueVertexP4ui(type, value);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glVertexP4uiv(uint type, uint* value) => __GlueVertexP4uiv(type, value);



	}
}


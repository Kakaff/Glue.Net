using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL {

    public static bool GL_4_5 {get; private set;}

		public const int GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetGraphicsResetStatus( );
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnTexImage(uint tex, int level, uint format, uint type, int bufSize, IntPtr pixels);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetnUniformdv(uint program, int location, int bufSize, double* parameters);

 		static __glGetGraphicsResetStatus __GlueGetGraphicsResetStatus;
		static __glGetnCompressedTexImage __GlueGetnCompressedTexImage;
		static __glGetnTexImage __GlueGetnTexImage;
		static __glGetnUniformdv __GlueGetnUniformdv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetGraphicsResetStatus( ) => __GlueGetGraphicsResetStatus();
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnCompressedTexImage(uint target, int lod, int bufSize, IntPtr pixels) => __GlueGetnCompressedTexImage(target, lod, bufSize, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnTexImage(uint tex, int level, uint format, uint type, int bufSize, IntPtr pixels) => __GlueGetnTexImage(tex, level, format, type, bufSize, pixels);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetnUniformdv(uint program, int location, int bufSize, double* parameters) => __GlueGetnUniformdv(program, location, bufSize, parameters);



	}
}


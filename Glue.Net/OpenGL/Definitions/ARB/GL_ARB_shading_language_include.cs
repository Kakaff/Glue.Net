using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_shading_language_include {get; private set;}

		public const int GL_SHADER_INCLUDE_ARB = 0x8DAE;
		public const int GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;
		public const int GL_NAMED_STRING_TYPE_ARB = 0x8DEA;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glCompileShaderIncludeARB(uint shader, int count, char** path, int* length);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDeleteNamedStringARB(int namelen, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedStringARB(int namelen, char* name, int bufSize, int* stringlen, char* str);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetNamedStringivARB(int namelen, char* name, uint pname, int* parameters);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate bool __glIsNamedStringARB(int namelen, char* name);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glNamedStringARB(uint type, int namelen, char* name, int stringlen, char* str);

 		static __glCompileShaderIncludeARB __GlueCompileShaderIncludeARB;
		static __glDeleteNamedStringARB __GlueDeleteNamedStringARB;
		static __glGetNamedStringARB __GlueGetNamedStringARB;
		static __glGetNamedStringivARB __GlueGetNamedStringivARB;
		static __glIsNamedStringARB __GlueIsNamedStringARB;
		static __glNamedStringARB __GlueNamedStringARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glCompileShaderIncludeARB(uint shader, int count, char** path, int* length) => __GlueCompileShaderIncludeARB(shader, count, path, length);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDeleteNamedStringARB(int namelen, char* name) => __GlueDeleteNamedStringARB(namelen, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedStringARB(int namelen, char* name, int bufSize, int* stringlen, char* str) => __GlueGetNamedStringARB(namelen, name, bufSize, stringlen, str);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetNamedStringivARB(int namelen, char* name, uint pname, int* parameters) => __GlueGetNamedStringivARB(namelen, name, pname, parameters);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe bool glIsNamedStringARB(int namelen, char* name) => __GlueIsNamedStringARB(namelen, name);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glNamedStringARB(uint type, int namelen, char* name, int stringlen, char* str) => __GlueNamedStringARB(type, namelen, name, stringlen, str);



	}
}


using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_debug_output {get; private set;}

		public const int GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;
		public const int GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;
		public const int GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;
		public const int GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;
		public const int GL_DEBUG_SOURCE_API_ARB = 0x8246;
		public const int GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;
		public const int GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;
		public const int GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;
		public const int GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A;
		public const int GL_DEBUG_SOURCE_OTHER_ARB = 0x824B;
		public const int GL_DEBUG_TYPE_ERROR_ARB = 0x824C;
		public const int GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;
		public const int GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;
		public const int GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F;
		public const int GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;
		public const int GL_DEBUG_TYPE_OTHER_ARB = 0x8251;
		public const int GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;
		public const int GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;
		public const int GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145;
		public const int GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146;
		public const int GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;
		public const int GL_DEBUG_SEVERITY_LOW_ARB = 0x9148;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDebugMessageCallbackARB(IntPtr callback, IntPtr userParam);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, bool enabled);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glDebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, char* buf);
		[SuppressUnmanagedCodeSecurity]
		unsafe delegate uint __glGetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);

 		static __glDebugMessageCallbackARB __GlueDebugMessageCallbackARB;
		static __glDebugMessageControlARB __GlueDebugMessageControlARB;
		static __glDebugMessageInsertARB __GlueDebugMessageInsertARB;
		static __glGetDebugMessageLogARB __GlueGetDebugMessageLogARB;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDebugMessageCallbackARB(IntPtr callback, IntPtr userParam) => __GlueDebugMessageCallbackARB(callback, userParam);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, bool enabled) => __GlueDebugMessageControlARB(source, type, severity, count, ids, enabled);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glDebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, char* buf) => __GlueDebugMessageInsertARB(source, type, id, severity, length, buf);
		[SuppressUnmanagedCodeSecurity]
		public static unsafe uint glGetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) => __GlueGetDebugMessageLogARB(count, bufSize, sources, types, ids, severities, lengths, messageLog);



	}
}


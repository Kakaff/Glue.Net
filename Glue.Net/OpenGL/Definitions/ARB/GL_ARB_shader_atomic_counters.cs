using System;
using System.Security;
using System.Runtime.InteropServices;

namespace GlueNet.OpenGL {

	public static partial class GL_ARB {

    public static bool GL_ARB_shader_atomic_counters {get; private set;}

		public const int GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
		public const int GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
		public const int GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
		public const int GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
		public const int GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
		public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
		public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
		public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
		public const int GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
		public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
		public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
		public const int GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
		public const int GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
		public const int GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
		public const int GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
		public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
		public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
		public const int GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
		public const int GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
		public const int GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
		public const int GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
		public const int GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
		public const int GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
		public const int GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
		public const int GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

 		[SuppressUnmanagedCodeSecurity]
		unsafe delegate void __glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters);

 		static __glGetActiveAtomicCounterBufferiv __GlueGetActiveAtomicCounterBufferiv;

 		[SuppressUnmanagedCodeSecurity]
		public static unsafe void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* parameters) => __GlueGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, parameters);



	}
}


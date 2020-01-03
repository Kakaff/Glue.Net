using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet
{
    public static partial class Glue
    {

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "InitGlfw"
            )]
        internal static extern bool __InitGlfw();

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "InitGlew"
            )]
        internal static extern bool __InitGlew();

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "TerminateGlfw"
            )]
        internal static extern void __TerminateGlfw();
    }
}

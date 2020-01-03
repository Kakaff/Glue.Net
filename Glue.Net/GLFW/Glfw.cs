using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        public static bool IsInitialized { get; private set; }

        public static bool Init() => Glue.InitGlfw();
        internal static bool __Init()
        {
            bool b = Glue.__InitGlfw();
            GLFWMonitor.Init();
            IsInitialized = true;
            return b;
        }
    }
}

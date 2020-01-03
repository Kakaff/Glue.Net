using GlueNet.GLFW;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace GlueNet.OpenGL
{
    internal static partial class Gl
    {
        internal static void Init(GLFW_Window window) {
            GLExtensionLoader.Init(window);
        }
    }
}

using GlueNet.GLFW;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace GlueNet.OpenGL
{
    public static class GLFunctionLoader
    {
        /* These aren't used for anything, but might be in the future so i'm just going to comment them out.
        [DllImport("opengl32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true),SuppressUnmanagedCodeSecurity]
        internal static extern IntPtr wglGetProcAddress(string functionName);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true), SuppressUnmanagedCodeSecurity]
        internal static extern IntPtr GetProcAddress(string procname);
        */
        internal static T LoadGLFunction<T>(string name) where T : Delegate
        {
            IntPtr ptr = Glfw.GetProcAddress(name);
            if (ptr == IntPtr.Zero)
            {
                //Log a warning, because we check if the version/definition that defines the function is supported before we get here. So the GPU bloody well should support it.
                Console.WriteLine($"GLFunctionLoader Error: {name} not found");
                return null;
            }
            return Marshal.GetDelegateForFunctionPointer<T>(ptr);
        }
    }
}

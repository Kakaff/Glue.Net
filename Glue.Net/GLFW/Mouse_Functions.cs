using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        /// <summary>
        /// Returns whether raw mouse motion is supported.
        /// </summary>
        /// <returns></returns>
        public static bool RawMouseMotionSupported() => __RawMouseMotionSupported() == TRUE;
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwRawMouseMotionSupported"
            )]
        internal static extern int __RawMouseMotionSupported();

        /// <summary>
        /// Returns the last reported state of a mouse button for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="button"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMouseButton"
            )]
        public static extern int GetMouseButton(IntPtr window, int button);

        /// <summary>
        /// Retrieves the position of the cursor relative to the content area of the window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetCursorPos"
            )]
        public static extern void GetCursorPos(IntPtr window, out double xpos, out double ypos);

        /// <summary>
        /// Sets the position of the cursor, relative to the content area of the window. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetCursorPos"
            )]
        public static extern void SetCursorPos(IntPtr window, double xpos, double ypos);

        /// <summary>
        /// Creates a custom cursor.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="xhot"></param>
        /// <param name="yhot"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwCreateCursor"
            )]
        public static extern IntPtr CreateCursor(IntPtr image, int xhot, int yhot);

        /// <summary>
        /// Creates a cursor with a standard shape. 
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwCreateStandardCursor"
            )]
        public static extern IntPtr CreateStandardCursor(int shape);

        /// <summary>
        /// Destroys a cursor. 
        /// </summary>
        /// <param name="cursor"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwDestroyCursor"
            )]
        public static extern void DestroyCursor(IntPtr cursor);

        /// <summary>
        /// Sets the mouse button callback. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetMouseButtonCallback"
            )]
        public static extern mousebuttonfun SetMouseButtonCallback(IntPtr window, mousebuttonfun cbfun);

        /// <summary>
        /// Sets the cursor position callback. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetCursorPosCallback"
            )]
        public static extern cursorposfun SetCursorPosCallback(IntPtr window, cursorposfun cbfun);

        /// <summary>
        /// Sets the cursor enter/exit callback. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetCursorEnterCallback"
            )]
        public static extern cursorenterfun SetCursorEnterCallback(IntPtr window, cursorenterfun cbfun);
    }
}

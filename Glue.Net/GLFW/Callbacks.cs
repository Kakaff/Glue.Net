using System;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        internal delegate void __errorfun(int i, string c); //The function signature for error callbacks.
        internal delegate void __windowposfun(IntPtr window, int i, int j); //The function signature for window position callbacks.
        internal delegate void __windowsizefun(IntPtr window, int i, int j); //The function signature for window resize callbacks.
        internal delegate void __windowclosefun(IntPtr window); //The function signature for window close callbacks.
        internal delegate void __windowrefreshfun(IntPtr window); //The function signature for window content refresh callbacks. 
        internal delegate void __windowfocusfun(IntPtr window, int i); //The function signature for window focus/defocus callbacks. 
        internal delegate void __windowiconifyfun(IntPtr window, int i); //The function signature for window iconify/restore callbacks. 
        internal delegate void __windowmaximizefun(IntPtr window, int i); //The function signature for window maximize/restore callbacks. 
        internal delegate void __framebuffersizefun(IntPtr window, int i, int j); //The function signature for framebuffer resize callbacks.
        internal delegate void __windowcontentscalefun(IntPtr window, float f, float g); //The function signature for window content scale callbacks. 
        internal delegate void __mousebuttonfun(IntPtr window, int i, int j, int k); //The function signature for mouse button callbacks.
        internal delegate void __cursorposfun(IntPtr window, double d, double e); //The function signature for cursor position callbacks.
        internal delegate void __cursorenterfun(IntPtr window, int i); //The function signature for cursor enter/leave callbacks. 
        internal delegate void __scrollfun(IntPtr window, double d, double e); //The function signature for scroll callbacks. 
        internal delegate void __keyfun(IntPtr window, int i, int j, int k, int l); //The function signature for keyboard key callbacks.
        internal delegate void __charfun(IntPtr window, uint i); //The function signature for Unicode character callbacks.
        internal delegate void __charmodsfun(IntPtr window, uint i, int j); //The function signature for Unicode character with modifiers callbacks.
        internal delegate void __dropfun(IntPtr window, int i, string[] c); //The function signature for file drop callbacks.
        internal delegate void __monitorfun(IntPtr window, int i); //The function signature for monitor configuration callbacks.
        internal delegate void __joystickfun(int i, int j); //The function signature for joystick configuration callbacks.

        public delegate void errorfun(glfwError errorcode, string c); //The function signature for error callbacks.
        public delegate void windowposfun(GLFW_Window window, int i, int j); //The function signature for window position callbacks.
        public delegate void windowsizefun(GLFW_Window window, int i, int j); //The function signature for window resize callbacks.
        public delegate void windowclosefun(GLFW_Window window); //The function signature for window close callbacks.
        public delegate void windowrefreshfun(GLFW_Window window); //The function signature for window content refresh callbacks. 
        public delegate void windowfocusfun(GLFW_Window window, glfwBool value); //The function signature for window focus/defocus callbacks. 
        public delegate void windowiconifyfun(GLFW_Window window, int i); //The function signature for window iconify/restore callbacks. 
        public delegate void windowmaximizefun(GLFW_Window window, int i); //The function signature for window maximize/restore callbacks. 
        public delegate void framebuffersizefun(GLFW_Window window, int i, int j); //The function signature for framebuffer resize callbacks.
        public delegate void windowcontentscalefun(GLFW_Window window, float f, float g); //The function signature for window content scale callbacks. 
        public delegate void mousebuttonfun(GLFW_Window window, int i, int j, int k); //The function signature for mouse button callbacks.
        public delegate void cursorposfun(GLFW_Window window, double d, double e); //The function signature for cursor position callbacks.
        public delegate void cursorenterfun(GLFW_Window window, int i); //The function signature for cursor enter/leave callbacks. 
        public delegate void scrollfun(GLFW_Window window, double d, double e); //The function signature for scroll callbacks. 
        public delegate void keyfun(GLFW_Window window, int i, int j, int k, int l); //The function signature for keyboard key callbacks.
        public delegate void charmodsfun(GLFW_Window window, uint i, int j); //The function signature for Unicode character with modifiers callbacks.
        public delegate void dropfun(GLFW_Window window, int i, string[] c); //The function signature for file drop callbacks.
        public delegate void monitorfun(GLFW_Window window, int i); //The function signature for monitor configuration callbacks.
        public delegate void joystickfun(int i, int j); //The function signature for joystick configuration callbacks.
    }
}

using System;
using System.Runtime.InteropServices;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        /// <summary>
        /// Resets all window hints to their default values.
        /// </summary>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwDefaultWindowHints"
            )]
        public static extern void DefaultWindowHints();

        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// </summary>
        /// <param name="hint"></param>
        /// <param name="value"></param>
        public static void WindowHint(glfwWindowHint hint, int value) => WindowHint((int)hint, value);
        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// </summary>
        /// <param name="hint"></param>
        /// <param name="value"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwWindowHint"
            )]
        public static extern void WindowHint(int hint, int value);


        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// </summary>
        /// <param name="hint"></param>
        /// <param name="value"></param>
        public static void WindowHintString(glfwWindowHint hint, string value) => WindowHintString((int)hint, value);
        /// <summary>
        /// Sets the specified window hint to the desired value.
        /// </summary>
        /// <param name="hint"></param>
        /// <param name="value"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwWindowHintString"
            )]
        public static extern void WindowHintString(int hint, string value);


        /// <summary>
        /// Creates a window and its associated context.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="title"></param>
        /// <param name="monitor"></param>
        /// <param name="share"></param>
        /// <returns></returns>
        public static GLFW_Window CreateWindow(int width, int height, string title, GLFWMonitor monitor, GLFW_Window share) =>
            new GLFW_Window(width, height, title, monitor, share);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwCreateWindow"
            )]
        internal static extern IntPtr __CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);


        /// <summary>
        /// Destroys the specified window and its context.
        /// </summary>
        /// <param name="window"></param>
        public static void DestroyWindow(GLFW_Window window) => window.Destroy();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwDestroyWindow"
            )]
        internal static extern void __DestroyWindow(IntPtr window);


        /// <summary>
        /// Checks the close flag of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public static bool WindowShouldClose(GLFW_Window window) => window.ShouldClose();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwWindowShouldClose"
            )]
        internal static extern int __WindowShouldClose(IntPtr window);


        /// <summary>
        /// Sets the close flag of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="value"></param>
        public static void SetWindowShouldClose(GLFW_Window window, bool value) =>
            __SetWindowShouldClose(window.Handle, value ? TRUE : FALSE);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowShouldClose"
            )]
        internal static extern void __SetWindowShouldClose(IntPtr window, int value);


        /// <summary>
        /// Sets the title of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="title"></param>
        public static void SetWindowTitle(GLFW_Window window, string title) =>
            window.SetTitle(title);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowTitle"
            )]
        internal static extern void __SetWindowTitle(IntPtr window, string title);


        /// <summary>
        /// Sets the icon for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="count"></param>
        /// <param name="images"></param>
        public static void SetWindowIcon(GLFW_Window window, GLFWImage[] images) =>
            window.SetIcon(images);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowIcon"
            )]
        internal static extern void __SetWindowIcon(IntPtr window, int count, IntPtr images);


        /// <summary>
        /// Retrieves the position of the content area of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        public static void GetWindowPos(GLFW_Window window, out int xpos, out int ypos)
        {
            xpos = window.Position.x;
            ypos = window.Position.y;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowPos"
            )]
        internal static extern void __GetWindowPos(IntPtr window, out int xpos, out int ypos);


        /// <summary>
        /// Sets the position of the content area of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        public static void SetWindowPos(GLFW_Window window, int xpos, int ypos) =>
            window.SetPosition(xpos, ypos);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowPos"
            )]
        internal static extern void __SetWindowPos(IntPtr window, int xpos, int ypos);


        /// <summary>
        /// Retrieves the size of the content area of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void GetWindowSize(GLFW_Window window, out int width, out int height)
        {
            width = window.Size.Width;
            height = window.Size.Height;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowSize"
            )]
        internal static extern void __GetWindowSize(IntPtr window, out int width, out int height);


        /// <summary>
        /// Sets the size limits of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="minwidth"></param>
        /// <param name="minheight"></param>
        /// <param name="maxwidth"></param>
        /// <param name="maxheight"></param>
        public static void SetWindowSizeLimits(GLFW_Window window, int minwidth, int minheight, int maxwidth, int maxheight) =>
            window.SetSizeLimits(minwidth, minheight, maxwidth, maxheight);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowSizeLimits"
            )]
        internal static extern void __SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);


        /// <summary>
        /// Sets the aspect ratio of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="numer"></param>
        /// <param name="denom"></param>
        public static void SetWindowAspectRatio(GLFW_Window window, int numer, int denom) =>
            window.SetAspectRatio(numer, denom);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowAspectRatio"
            )]
        internal static extern void __SetWindowAspectRatio(IntPtr window, int numer, int denom);


        /// <summary>
        /// Sets the size of the content area of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void SetWindowSize(GLFW_Window window, int width, int height) =>
            window.SetSize(width, height);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowSize"
            )]

        internal static extern void __SetWindowSize(IntPtr window, int width, int height);


        /// <summary>
        /// Retrieves the size of the framebuffer of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void GetFramebufferSize(GLFW_Window window, out int width, out int height)
        {
            width = window.FramebufferSize.Width;
            height = window.FramebufferSize.Height;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetFramebufferSize"
            )]
        internal static extern void __GetFramebufferSize(IntPtr window, out int width, out int height);


        /// <summary>
        /// Retrieves the size of the frame of the window. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        public static void GetWindowFrameSize(GLFW_Window window, out int left, out int top, out int right, out int bottom)
        {
            left = window.FrameSize.left;
            top = window.FrameSize.top;
            right = window.FrameSize.right;
            bottom = window.FrameSize.bottom;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowFrameSize"
            )]
        internal static extern void __GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);


        /// <summary>
        /// Retrieves the content scale for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="xscale"></param>
        /// <param name="yscale"></param>
        public static void GetWindowContentScale(GLFW_Window window, out float xscale, out float yscale)
        {
            xscale = window.ContentScale.x;
            yscale = window.ContentScale.y;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowContentScale"
            )]
        internal static extern void __GetWindowContentScale(IntPtr window, out float xscale, out float yscale);


        /// <summary>
        /// Returns the opacity of the whole window. 
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public static float GetWindowOpacity(GLFW_Window window) => window.Opacity;

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowOpacity"
            )]
        internal static extern float __GetWindowOpacity(IntPtr window);


        /// <summary>
        /// Sets the opacity of the whole window. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="opacity"></param>
        public static void SetWindowOpacity(GLFW_Window window, float opacity) =>
            window.SetOpacity(opacity);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowOpacity"
            )]
        internal static extern void __SetWindowOpacity(IntPtr window, float opacity);


        /// <summary>
        /// Iconifies the specified window.
        /// </summary>
        /// <param name="window"></param>
        public static void IconifyWindow(GLFW_Window window) => window.Iconify();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwIconifyWindow"
            )]
        internal static extern void __IconifyWindow(IntPtr window);


        /// <summary>
        /// Restores the specified window.
        /// </summary>
        /// <param name="window"></param>
        public static void RestoreWindow(GLFW_Window window) => window.Restore();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwRestoreWindow"
            )]
        internal static extern void __RestoreWindow(IntPtr window);


        /// <summary>
        /// Maximizes the specified window.
        /// </summary>
        /// <param name="window"></param>
        public static void MaximizeWindow(GLFW_Window window) => window.Maximize();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwMaximizeWindow"
            )]
        internal static extern void __MaximizeWindow(IntPtr window);


        /// <summary>
        /// Makes the specified window visible. 
        /// </summary>
        /// <param name="window"></param>
        public static void ShowWindow(GLFW_Window window) => window.Show();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwShowWindow"
            )]
        internal static extern void __ShowWindow(IntPtr window);


        /// <summary>
        /// Hides the specified window.
        /// </summary>
        /// <param name="window"></param>
        public static void HideWindow(GLFW_Window window) => window.Hide();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwHideWindow"
            )]
        internal static extern void __HideWindow(IntPtr window);

        /// <summary>
        /// Brings the specified window to front and sets input focus.
        /// </summary>
        /// <param name="window"></param>
        public static void FocusWindow(GLFW_Window window) => window.Focus();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwFocusWindow"
            )]
        internal static extern void __FocusWindow(IntPtr window);


        /// <summary>
        /// Requests user attention to the specified window. 
        /// </summary>
        /// <param name="window"></param>
        public static void RequestWindowAttention(GLFW_Window window) => window.RequestAttention();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwRequestWindowAttention"
            )]
        internal static extern void __RequestWindowAttention(IntPtr window);


        /// <summary>
        /// Returns the monitor that the window uses for full screen mode.
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public static GLFWMonitor GetWindowMonitor(GLFW_Window window) => window.Monitor;

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowMonitor"
            )]
        internal static extern IntPtr GetWindowMonitor(IntPtr window);


        /// <summary>
        /// Sets the mode, monitor, video mode and placement of a window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="monitor"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="refreshRate"></param>
        public static void SetWindowMonitor(GLFW_Window window, GLFWMonitor monitor, int xpos, int ypos, int width, int height, int refreshRate) =>
            window.SetMonitor(monitor, xpos, ypos, width, height, refreshRate);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowMonitor"
            )]
        internal static extern void __SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);


        /// <summary>
        /// Returns an attribute of the specified window. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="attrib"></param>
        /// <returns></returns>
        public static int GetWindowAttrib(GLFW_Window window, int attrib) => window.GetAttrib(attrib);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetWindowAttrib"
            )]
        internal static extern int __GetWindowAttrib(IntPtr window, int attrib);


        /// <summary>
        /// Sets an attribute of the specified window. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="attrib"></param>
        /// <param name="value"></param>
        public static void SetWindowAttrib(GLFW_Window window, int attrib, int value) =>
            window.SetAttrib(attrib, value);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowAttrib"
            )]
        internal static extern void __SetWindowAttrib(IntPtr window, int attrib, int value);


        /// <summary>
        /// Sets the user pointer of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="pointer"></param>
        public static void SetWindowUserPointer(GLFW_Window window, object obj) => 
            window.SetUserPointer(obj);


        /// <summary>
        /// Returns the user pointer of the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public static object GetWindowUserPointer(GLFW_Window window) =>
            window.UserPointer;



        /// <summary>
        /// Sets the position callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowPosCallback"
            )]
        internal static extern __windowposfun __SetWindowPosCallback(IntPtr window, __windowposfun cbfun);


        /// <summary>
        /// Sets the size callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowSizeCallback"
            )]
        internal static extern __windowsizefun __SetWindowSizeCallback(IntPtr window, __windowsizefun cbfun);


        /// <summary>
        /// Sets the close callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowCloseCallback"
            )]
        internal static extern __windowclosefun __SetWindowCloseCallback(IntPtr window, __windowclosefun cbfun);


        /// <summary>
        /// Sets the refresh callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowRefreshCallback"
            )]
        internal static extern __windowrefreshfun __SetWindowRefreshCallback(IntPtr window, __windowrefreshfun cbfun);

        /// <summary>
        /// Sets the focus callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowFocusCallback"
            )]
        internal static extern __windowfocusfun __SetWindowFocusCallback(IntPtr window, __windowfocusfun cbfun);


        /// <summary>
        /// Sets the iconify callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowIconifyCallback"
            )]
        internal static extern __windowiconifyfun __SetWindowIconifyCallback(IntPtr window, __windowiconifyfun cbfun);


        /// <summary>
        /// Sets the maximize callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowMaximizeCallback"
            )]
        internal static extern __windowmaximizefun __SetWindowMaximizeCallback(IntPtr window, __windowmaximizefun cbfun);


        /// <summary>
        /// Sets the framebuffer resize callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetFramebufferSizeCallback"
            )]
        internal static extern __framebuffersizefun __SetFramebufferSizeCallback(IntPtr window, __framebuffersizefun cbfun);


        /// <summary>
        /// Sets the window content scale callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetWindowContentScaleCallback"
            )]
        internal static extern __windowcontentscalefun __SetWindowContentScaleCallback(IntPtr window, __windowcontentscalefun cbfun);

        /// <summary>
        /// Adds a position callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowposfun AddWindowPosCallback(GLFW_Window window, windowposfun cbfun)
        {
            window.OnWindowPosChanged += cbfun;
            return cbfun;
        }
        /// <summary>
        /// Removes a position callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveWindowPosCallback(GLFW_Window window, windowposfun cbfun) =>
            window.OnWindowPosChanged -= cbfun;

        /// <summary>
        /// Adds a size callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowsizefun AddWindowSizeCallback(GLFW_Window window, windowsizefun cbfun)
        {
            window.OnWindowSizeChanged += cbfun;
            return cbfun;
        }

        /// <summary>
        /// Removes a size callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveWindowSizeCallback(GLFW_Window window, windowsizefun cbfun) =>
            window.OnWindowSizeChanged -= cbfun;

        /// <summary>
        /// Adds a close callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowclosefun AddWindowCloseCallback(GLFW_Window window, windowclosefun cbfun)
        {
            window.OnWindowClose += cbfun;
            return cbfun;
        }
        /// <summary>
        /// Removes a close callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveWindowCloseCallback(GLFW_Window window, windowclosefun cbfun) =>
            window.OnWindowClose -= cbfun;

        /// <summary>
        /// Sets the refresh callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowrefreshfun AddWindowRefreshCallback(GLFW_Window window, windowrefreshfun cbfun)
        {
            window.OnWindowRefresh += cbfun;
            return cbfun;
        }

        public static void RemoveWindowRefreshCallback(GLFW_Window window, windowrefreshfun cbfun) =>
            window.OnWindowRefresh -= cbfun;

        /// <summary>
        /// Adds a focus callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowfocusfun AddWindowFocusCallback(GLFW_Window window, windowfocusfun cbfun)
        {
            window.OnWindowFocusChanged += cbfun;
            return cbfun;
        }
        /// <summary>
        /// Removes a focus callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        public static void RemoveWindowFocusCallback(GLFW_Window window, windowfocusfun cbfun) =>
            window.OnWindowFocusChanged -= cbfun;



        /// <summary>
        /// Adds a iconify callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowiconifyfun AddWindowIconifyCallback(GLFW_Window window, windowiconifyfun cbfun)
        {
            window.OnWindowIconify += cbfun;
            return cbfun;
        }

        /// <summary>
        /// Removes a iconify callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveWindowIconifyCallback(GLFW_Window window, windowiconifyfun cbfun) =>
            window.OnWindowIconify -= cbfun;

        /// <summary>
        /// Adds a maximize callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowmaximizefun AddWindowMaximizeCallback(GLFW_Window window, windowmaximizefun cbfun)
        {
            window.OnWindowMaximize += cbfun;
            return cbfun;
        }

        /// <summary>
        /// Adds a maximize callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveWindowMaximizeCallback(GLFW_Window window, windowmaximizefun cbfun) =>
            window.OnWindowMaximize -= cbfun;

        /// <summary>
        /// Adds a framebuffer resize callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static framebuffersizefun AddFramebufferSizeCallback(GLFW_Window window, framebuffersizefun cbfun)
        {
            window.OnFramebufferSizeChanged += cbfun;
            return cbfun;
        }

        /// <summary>
        /// Removes a framebuffer resize callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveFramebufferSizeCallback(GLFW_Window window, framebuffersizefun cbfun) =>
            window.OnFramebufferSizeChanged -= cbfun;


        /// <summary>
        /// Adds a window content scale callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static windowcontentscalefun AddWindowContentScaleCallback(GLFW_Window window, windowcontentscalefun cbfun)
        {
            window.OnWindowContentScaleChanged += cbfun;
            return cbfun;
        }

        /// <summary>
        /// Removes a window content scale callback for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveWindowContentScaleCallback(GLFW_Window window, windowcontentscalefun cbfun) =>
            window.OnWindowContentScaleChanged -= cbfun;


        /// <summary>
        /// Makes the context of the specified window current for the calling thread.
        /// </summary>
        /// <param name="window"></param>
        public static void MakeContextCurrent(GLFW_Window window) => window.MakeContextCurrent();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwMakeContextCurrent"
            )]
        internal static extern void __MakeContextCurrent(IntPtr window);

        /// <summary>
        /// Returns the window whose context is current on the calling thread.
        /// </summary>
        /// <returns></returns>
        public static GLFW_Window GetCurrentContext() => GLFW_Window.GetWindowFromPtr(__GetCurrentContext());

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetCurrentContext"
            )]
        internal static extern IntPtr __GetCurrentContext();

        /// <summary>
        /// Swaps the front and back buffers of the specified window.
        /// </summary>
        /// <param name="window"></param>
        public static void SwapBuffers(GLFW_Window window) => window.SwapBuffers();

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSwapBuffers"
            )]
        internal static extern void __SwapBuffers(IntPtr window);

    }
}

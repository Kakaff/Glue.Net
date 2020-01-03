using System;
using System.Collections.Generic;
using System.Text;
using GlueNet;

namespace GlueNet.GLFW
{
    public sealed class GLFW_Window
    {
        static Dictionary<IntPtr, GLFW_Window> windowDict = new Dictionary<IntPtr, GLFW_Window>();

        internal IntPtr Handle { get; private set; }
        public string Title { get; private set; }
        public string Input { get; private set; }
        public (int Width, int Height) Size { get; private set; }
        public (int x, int y) Position { get; private set; }
        public (int MinWidth, int MinHeight, int MaxWidth, int MaxHeight) SizeLimits { get; private set; }
        public (int numer,int denom) AspectRatio { get; private set; }
        public (int left,int top, int right, int bottom) FrameSize { get; private set; }
        public (float x, float y) ContentScale { get; private set; }
        public (int Width, int Height) FramebufferSize { get; private set; }
        public float Opacity { get; private set; }
        public GLFWImage[] Icon { get; private set; }
        public bool IsIconified { get; private set; }
        public bool IsHidden { get; private set; }
        public bool IsFocused { get; private set; }
        public bool IsMaximized { get; private set; }
        public bool IsFullscreen { get; private set; }
        public GLFWMonitor Monitor { get; private set; }
        public object UserPointer { get; private set; }
        public Keyboard Keyboard { get; private set; }

        public event Glfw.windowfocusfun OnWindowFocusChanged
        {
            add => _onFocusChanged += value;
            remove => _onFocusChanged -= value;
        }

        public event Glfw.windowposfun OnWindowPosChanged
        {
            add => _onPosChanged += value;
            remove => _onPosChanged -= value;
        }

        public event Glfw.windowsizefun OnWindowSizeChanged
        {
            add => _onSizeChanged += value;
            remove => _onSizeChanged -= value;
        }

        public event Glfw.windowclosefun OnWindowClose
        {
            add => _onClose += value;
            remove => _onClose -= value;
        }

        public event Glfw.windowrefreshfun OnWindowRefresh
        {
            add => _onRefresh += value;
            remove => _onRefresh -= value;
        }

        public event Glfw.windowiconifyfun OnWindowIconify
        {
            add => _onIconify += value;
            remove => _onIconify -= value;
        }

        public event Glfw.windowmaximizefun OnWindowMaximize
        {
            add => _onMaximize += value;
            remove => _onMaximize -= value;
        }

        public event Glfw.framebuffersizefun OnFramebufferSizeChanged
        {
            add => _onFramebufferSizeChanged += value;
            remove => _onFramebufferSizeChanged -= value;
        }

        public event Glfw.windowcontentscalefun OnWindowContentScaleChanged
        {
            add => _onContentScaleChanged += value;
            remove => _onContentScaleChanged -= value;
        }

        event Glfw.windowfocusfun _onFocusChanged;
        event Glfw.windowposfun _onPosChanged;
        event Glfw.windowsizefun _onSizeChanged;
        event Glfw.windowclosefun _onClose;
        event Glfw.windowrefreshfun _onRefresh;
        event Glfw.windowiconifyfun _onIconify;
        event Glfw.windowmaximizefun _onMaximize;
        event Glfw.framebuffersizefun _onFramebufferSizeChanged;
        event Glfw.windowcontentscalefun _onContentScaleChanged;


        Glfw.__windowposfun __nativePosFunCBDelegate;
        Glfw.__windowsizefun __nativeSizeFunCBDelegate;
        Glfw.__windowclosefun __nativeCloseFunCBDelegate;
        Glfw.__windowrefreshfun __nativeRefreshFunCBDelegate;
        Glfw.__windowfocusfun __nativeFocusFunCBDelegate;
        Glfw.__windowiconifyfun __nativeIconifyFunCBDelegate;
        Glfw.__windowmaximizefun __nativeMaximizeFunCBDelegate;
        Glfw.__framebuffersizefun __nativeFBSizeFunCBDelegate;
        Glfw.__windowcontentscalefun __nativeContScaleFunCBDelegate;
        Glfw.__charfun __nativeCharInputCBDelegate;
        Glfw.__keyfun __nativeKeyCBDelegate;

        IntPtr iconHandle;

        bool isDestroyed;

        public GLFW_Window(int width, int height, string title, GLFWMonitor monitor, GLFW_Window share)
        {
            Title = title;
            Size = (width, height);
            Handle = Glfw.__CreateWindow(
                width, 
                height, 
                title, 
                monitor == null ? IntPtr.Zero : monitor.Handle, 
                share == null ? IntPtr.Zero : share.Handle
                );

            Monitor = monitor;
            AspectRatio = ((int)glfwAttrib.DONT_CARE, (int)glfwAttrib.DONT_CARE);
            SizeLimits = (0, 0, (int)glfwAttrib.DONT_CARE, (int)glfwAttrib.DONT_CARE);

            Glfw.__GetWindowPos(Handle, out int posx, out int posy);
            Position = (posx, posy);
            Glfw.__GetFramebufferSize(Handle, out int fbWidth, out int fbHeight);
            FramebufferSize = (fbWidth, fbHeight);
            Glfw.__GetWindowFrameSize(Handle, out int l, out int t, out int r, out int b);
            FrameSize = (l, t, r, b);
            Glfw.__GetWindowContentScale(Handle, out float xscale, out float yscale);
            ContentScale = (xscale, yscale);

            __nativeCloseFunCBDelegate = __NativeCloseCallback;
            __nativeFocusFunCBDelegate = __NativeFocusChangedCallback;
            __nativePosFunCBDelegate = __NativePosChangedCallback;
            __nativeSizeFunCBDelegate = __NativeSizeChangedCallback;
            __nativeRefreshFunCBDelegate = __NativeRefreshCallback;
            __nativeIconifyFunCBDelegate = __NativeIconifyCallback;
            __nativeMaximizeFunCBDelegate = __NativeMaximizeCallback;
            __nativeFBSizeFunCBDelegate = __NativeFramebufferSizeCallback;
            __nativeContScaleFunCBDelegate = __NativeContentScaleCallback;
            __nativeCharInputCBDelegate = __NativeCharInputCallback;
            __nativeKeyCBDelegate = __NativeKeyCallback; 

            Glfw.__SetWindowFocusCallback(Handle, __nativeFocusFunCBDelegate);
            Glfw.__SetWindowPosCallback(Handle, __nativePosFunCBDelegate);
            Glfw.__SetWindowSizeCallback(Handle, __nativeSizeFunCBDelegate);
            Glfw.__SetWindowCloseCallback(Handle, __nativeCloseFunCBDelegate);
            Glfw.__SetWindowRefreshCallback(Handle, __nativeRefreshFunCBDelegate);
            Glfw.__SetWindowIconifyCallback(Handle, __nativeIconifyFunCBDelegate);
            Glfw.__SetWindowMaximizeCallback(Handle, __nativeMaximizeFunCBDelegate);
            Glfw.__SetFramebufferSizeCallback(Handle, __nativeFBSizeFunCBDelegate);
            Glfw.__SetWindowContentScaleCallback(Handle, __nativeContScaleFunCBDelegate);
            Glfw.__SetCharCallback(Handle, __nativeCharInputCBDelegate);
            Glfw.__SetKeyCallback(Handle, __nativeKeyCBDelegate);
            windowDict.Add(Handle, this);
            Keyboard = new Keyboard();
            Keyboard.__Init();

            Input = "";
        }

        ~GLFW_Window()
        {
            Destroy();
        }

        public void Destroy() {
            if (!isDestroyed)
            {
                Glfw.__SetWindowFocusCallback(Handle, null);
                Glfw.__SetWindowPosCallback(Handle, null);
                Glfw.__SetWindowSizeCallback(Handle, null);
                Glfw.__SetWindowCloseCallback(Handle, null);
                Glfw.__SetWindowRefreshCallback(Handle, null);
                Glfw.__SetWindowIconifyCallback(Handle, null);
                Glfw.__SetWindowMaximizeCallback(Handle, null);
                Glfw.__SetFramebufferSizeCallback(Handle, null);
                Glfw.__SetWindowContentScaleCallback(Handle, null);
                Glfw.__SetCharCallback(Handle, null);
                Glfw.__SetKeyCallback(Handle, null);
                Glfw.__DestroyWindow(Handle);
                if (windowDict.ContainsKey(Handle))
                    windowDict.Remove(Handle);
                isDestroyed = true;
            }
        }

        public bool ShouldClose() => Glfw.__WindowShouldClose(Handle) == Glfw.TRUE;

        public void SwapBuffers() => Glfw.__SwapBuffers(Handle);

        public void SetIcon(GLFWImage[] icon)
        {

            if (Icon != null)
                Glfw_HelperFunctions.__DeleteWindowIconArr(iconHandle);

            if (icon != null)
            {
                IntPtr[] iconPtrArr = new IntPtr[icon.Length];
                for (int i = 0; i < icon.Length; i++)
                    iconPtrArr[i] = icon[i].Handle;

                iconHandle = Glfw_HelperFunctions.__CreateIconArray(iconPtrArr, icon.Length);
                Glfw.__SetWindowIcon(Handle, icon.Length, iconHandle);
                Glfw_HelperFunctions.__DeleteWindowIconArr(iconHandle);
            }
            else
            {
                iconHandle = IntPtr.Zero;
                Glfw.__SetWindowIcon(Handle, 0, IntPtr.Zero);
            }
            
            Icon = icon;
        }

        public void SetTitle(string title)
        {
            Glfw.__SetWindowTitle(Handle,title);
            Title = title;
        }

        public void SetPosition(int xpos, int ypos) => Glfw.__SetWindowPos(Handle, xpos, ypos);

        public void SetSizeLimits(int minwidth, int minheight, int maxwidth, int maxheight)
        {
            Glfw.__SetWindowSizeLimits(Handle,minwidth, minheight, maxwidth, maxheight);
            SizeLimits = (minwidth, minheight, maxwidth, maxheight);
        }

        public void SetAspectRatio(int numer, int denom)
        {
            Glfw.__SetWindowAspectRatio(Handle, numer, denom);
            AspectRatio = (numer, denom);
        }

        public void SetSize(int width, int height) => Glfw.__SetWindowSize(Handle, width, height);
        public void SetOpacity(float opacity)
        {
            Glfw.__SetWindowOpacity(Handle, opacity);
            Opacity = opacity;
        }

        public void Iconify() => Glfw.__IconifyWindow(Handle);
        public void Restore() => Glfw.__RestoreWindow(Handle);
        public void Maximize() => Glfw.__MaximizeWindow(Handle);
        public void Show() => Glfw.__ShowWindow(Handle);
        public void Hide() => Glfw.__HideWindow(Handle);
        public void Focus() => Glfw.__FocusWindow(Handle);
        public object SetUserPointer(object o) => UserPointer = o;
        public void RequestAttention() => Glfw.__RequestWindowAttention(Handle);

        public void SetMonitor(GLFWMonitor monitor, int xpos, int ypos, int width, int height, int refreshRate)
        {
            Glfw.__SetWindowMonitor(Handle,monitor.Handle, xpos, ypos, width, height, refreshRate);
            Monitor = monitor;
        }

        public int GetAttrib(int attrib) => Glfw.__GetWindowAttrib(Handle, attrib);
        public void SetAttrib(int attrib, int value) => Glfw.__SetWindowAttrib(Handle, attrib, value);

        public void MakeContextCurrent() =>
            Glfw.__MakeContextCurrent(Handle);

        void __NativeFocusChangedCallback(IntPtr handle, int i)
        {
            IsFocused = i == Glfw.TRUE;
            _onFocusChanged?.Invoke(this, i == 0 ? glfwBool.FALSE : glfwBool.TRUE);
        }

        void __NativePosChangedCallback(IntPtr handle, int i, int j)
        {
            Position = (i, j);
            _onPosChanged?.Invoke(this, i, j);
        }

        void __NativeSizeChangedCallback (IntPtr hadle, int i, int j) {
            Size = (i, j);
            _onSizeChanged?.Invoke(this, i, j);
        }
        void __NativeCloseCallback(IntPtr hadle) {
            _onClose?.Invoke(this);
            Destroy();
        }
        void __NativeRefreshCallback(IntPtr hadle) =>
            _onRefresh?.Invoke(this);
        
        void __NativeIconifyCallback(IntPtr hadle, int i) {
            IsIconified = i == Glfw.TRUE;
            _onIconify?.Invoke(this, i);
        }
        void __NativeMaximizeCallback(IntPtr hadle, int i) {
            IsMaximized = i == Glfw.TRUE;
            _onMaximize?.Invoke(this, i);
        }
        void __NativeFramebufferSizeCallback(IntPtr hadle, int i, int j) {
            FramebufferSize = (i, j);
            _onFramebufferSizeChanged?.Invoke(this, i, j);
        }
        void __NativeContentScaleCallback(IntPtr hadle, float x, float y) {
            ContentScale = (x, y);
            _onContentScaleChanged?.Invoke(this, x, y);
        }

        void __NativeCharInputCallback(IntPtr handle,uint c)
        {
            Input += (char)c;
        }

        void __NativeKeyCallback(IntPtr handle,int key,int scancode, int action,int mods)
        {
            switch (key)
            {
                case Glfw.KEY_BACKSPACE:
                    {
                        if (Input.Length > 0 && (action == Glfw.GLFW_PRESS || action == Glfw.GLFW_REPEAT))
                                Input = Input.Substring(0, Input.Length - 1);
                        break;
                    }
                case Glfw.KEY_ENTER:
                    {
                        if (action == Glfw.GLFW_PRESS || action == Glfw.GLFW_REPEAT)
                            Input += '\n';
                        break;
                    }
            }
            
        }


        internal static GLFW_Window GetWindowFromPtr(IntPtr handle)
        {
            if (windowDict.TryGetValue(handle, out GLFW_Window window))
                return window;
            else
                throw new NullReferenceException();
        }

        internal static void __UpdateKeyboards()
        {
            foreach (KeyValuePair<IntPtr, GLFW_Window> kvp in windowDict)
                kvp.Value.Keyboard.__UpdateKeyStates(kvp.Value);
        }
    }
}

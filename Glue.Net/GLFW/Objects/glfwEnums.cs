namespace GlueNet.GLFW
{
    public enum glfwBool : int
    {
        TRUE = 1,
        FALSE = 0,
    }

    public enum glfwJoystick : int
    {
        HAT_CENTERED = 0,
        HAT_UP = 1,
        HAT_RIGHT = 2,
        HAT_DOWN = 4,
        HAT_LEFT = 8,
        HAT_RIGHT_UP = (HAT_RIGHT | HAT_UP),
        HAT_RIGHT_DOWN = (HAT_RIGHT | HAT_DOWN),
        HAT_LEFT_UP = (HAT_LEFT | HAT_UP),
        HAT_LEFT_DOWN = (HAT_LEFT | HAT_DOWN),

        _1 = 0,
        _2 = 1,
        _3 = 2,
        _4 = 3,
        _5 = 4,
        _6 = 5,
        _7 = 6,
        _8 = 7,
        _9 = 8,
        _10 = 9,
        _11 = 10,
        _12 = 11,
        _13 = 12,
        _14 = 13,
        _15 = 14,
        _16 = 15,
        _LAST = _16
    }

    public enum glfwKeyModifier : int
    {
        /// <summary>
        /// If this bit is set one or more Shift keys were held down.
        /// </summary>
        SHIFT = 0x0001,
        /// <summary>
        /// If this bit is set one or more Control keys were held down.
        /// </summary>
        CONTROL = 0x0002,
        /// <summary>
        /// If this bit is set one or more Alt keys were held down.
        /// </summary>
        ALT = 0x0004,
        /// <summary>
        /// If this bit is set one or more Super keys were held down.
        /// </summary>
        SUPER = 0x0008,
        /// <summary>
        /// If this bit is set the Caps Lock key is enabled.
        /// </summary>
        CAPS_LOCK = 0x0010,
        /// <summary>
        /// If this bit is set the Num Lock key is enabled
        /// </summary>
        NUM_LOCK = 0x0020,
    }

    public enum glfwMouseButton : int
    {
        _1 = 0,
        _2 = 1,
        _3 = 2,
        _4 = 3,
        _5 = 4,
        _6 = 5,
        _7 = 6,
        _8 = 7,
        LAST = _8,
        LEFT = _1,
        RIGHT = _2,
        MIDDLE = _3,
    }

    public enum glfwGamepad : int
    {
        BUTTON_A = 0,
        BUTTON_B = 1,
        BUTTON_X = 2,
        BUTTON_Y = 3,
        BUTTON_LEFT_BUMPER = 4,
        BUTTON_RIGHT_BUMPER = 5,
        BUTTON_BACK = 6,
        BUTTON_START = 7,
        BUTTON_GUIDE = 8,
        BUTTON_LEFT_THUMB = 9,
        BUTTON_RIGHT_THUMB = 10,
        BUTTON_DPAD_UP = 11,
        BUTTON_DPAD_RIGHT = 12,
        BUTTON_DPAD_DOWN = 13,
        BUTTON_DPAD_LEFT = 14,
        BUTTON_LAST = BUTTON_DPAD_LEFT,
        BUTTON_CROSS = BUTTON_A,
        BUTTON_CIRCLE = BUTTON_B,
        BUTTON_SQUARE = BUTTON_X,
        BUTTON_TRIANGLE = BUTTON_Y,

        AXIS_LEFT_X = 0,
        AXIS_LEFT_Y = 1,
        AXIS_RIGHT_X = 2,
        AXIS_RIGHT_Y = 3,
        AXIS_LEFT_TRIGGER = 4,
        AXIS_RIGHT_TRIGGER = 5,
        AXIS_LAST = AXIS_RIGHT_TRIGGER,
    }

    public enum glfwError : int
    {
        /// <summary>
        /// No error has occurred.
        /// </summary>
        NO_ERROR = 0,
        /// <summary>
        /// GLFW has not been initialized.
        /// </summary>
        NOT_INITIALIZED = 0x00010001,
        /// <summary>
        /// No context is current for this thread.
        /// </summary>
        NO_CURRENT_CONTEXT = 0x00010002,
        /// <summary>
        /// One of the arguments to the function was an invalid enum value.
        /// </summary>
        INVALID_ENUM = 0x00010003,
        /// <summary>
        /// One of the arguments to the function was an invalid value.
        /// </summary>
        INVALID_VALUE = 0x00010004,
        /// <summary>
        /// A memory allocation failed.
        /// </summary>
        OUT_OF_MEMORY = 0x00010005,
        /// <summary>
        /// GLFW could not find support for the requested API on the system.
        /// </summary>
        API_UNAVAILABLE = 0x00010006,
        /// <summary>
        /// The requested OpenGL or OpenGL ES version is not available.
        /// </summary>
        VERSION_UNAVAILABLE = 0x00010007,
        /// <summary>
        /// A platform-specific error occurred that does not match any of the more specific categories.
        /// </summary>
        PLATFORM_ERROR = 0x00010008,
        /// <summary>
        /// The requested format is not supported or available.
        /// </summary>
        FORMAT_UNAVAILABLE = 0x00010009,
        /// <summary>
        /// The specified window does not have an OpenGL or OpenGL ES context.
        /// </summary>
        NO_WINDOW_CONTEXT = 0x0001000A 
    }

    public enum glfwWindowHint : int
    {
        FOCUSED = 0x00020001, //Input focus window hint and attribute.
        ICONIFIED = 0x00020002, //Window iconification window attribute.
        RESIZABLE = 0x00020003, //Window resize-ability window hint and attribute.
        VISIBLE = 0x00020004, //Window visibility window hint and attribute.
        DECORATED = 0x00020005, //Window decoration window hint and attribute.
        AUTO_ICONIFY = 0x00020006, //Window auto-iconification window hint and attribute.
        FLOATING = 0x00020007, //Window decoration window hint and attribute.
        MAXIMIZED = 0x00020008, //Window maximization window hint and attribute.
        CENTER_CURSOR = 0x00020009, //Cursor centering window hint.
        TRANSPARENT_FRAMEBUFFER = 0x0002000A, //Window framebuffer transparency hint and attribute.
        HOVERED = 0x0002000B, //Mouse cursor hover window attribute.
        FOCUS_ON_SHOW = 0x0002000C, //Input focus on calling show window hint and attribute.
    }
    /// <summary>
    /// Windows specific window hints
    /// </summary>
    public enum glfwWindowsWindowHint : int
    {
        SCALE_TO_MONITOR = 0x0002200C, //Window content area scaling window window hint.
    }

    /// <summary>
    /// macOS specific window hints.
    /// </summary>
    public enum glfwmacOSWindowHint : int
    {
        COCOA_RETINA_FRAMEBUFFER = 0x00023001, //macOS specific window hint. 
        COCOA_FRAME_NAME = 0x00023002, //macOS specific window hint. 
        COCOA_GRAPHICS_SWITCHING = 0x00023003 //macOS specific window hint. 
    }

    /// <summary>
    /// X11 specific window hints
    /// </summary>
    public enum glfwX11WindowHint : int
    {
        CLASS_NAME = 0x00024001, //X11 specific window hint.
        INSTANCE_NAME = 0x00024002, //X11 specific window hint. 
    }

    public enum glfwFramebufferHint : int
    {
        RED_BITS = 0x00021001, //Framebuffer bit depth hint.
        GREEN_BITS = 0x00021002, //Framebuffer bit depth hint.
        BLUE_BITS = 0x00021003, //Framebuffer bit depth hint.
        ALPHA_BITS = 0x00021004, //Framebuffer bit depth hint.
        DEPTH_BITS = 0x00021005, //Framebuffer bit depth hint.
        STENCIL_BITS = 0x00021006, //Framebuffer bit depth hint.
        ACCUM_RED_BITS = 0x00021007, //Framebuffer bit depth hint. 
        ACCUM_GREEN_BITS = 0x00021008, //Framebuffer bit depth hint. 
        ACCUM_BLUE_BITS = 0x00021009, //Framebuffer bit depth hint. 
        ACCUM_ALPHA_BITS = 0x0002100A, //Framebuffer bit depth hint. 
        AUX_BUFFERS = 0x0002100B, //Framebuffer auxiliary buffer hint. 
        STEREO = 0x0002100C, //OpenGL stereoscopic rendering hint. 
        SAMPLES = 0x0002100D, //Framebuffer MSAA samples hint. 
        SRGB_CAPABLE = 0x0002100E, //Framebuffer sRGB hint.
        REFRESH_RATE = 0x0002100F, //Monitor refresh rate hint.
        DOUBLEBUFFER = 0x00021010, //Framebuffer double buffering hint.
    }

    public enum glfwAttrib : int
    {
        CLIENT_API = 0x00022001, //Context client API hint and attribute.
        CONTEXT_REVISION = 0x00022004, //Context client API revision number hint and attribute. 
        CONTEXT_ROBUSTNESS = 0x00022005, //Context robustness hint and attribute.
        OPENGL_FORWARD_COMPAT = 0x00022006, //OpenGL forward-compatibility hint and attribute. 
        OPENGL_DEBUG_CONTEXT = 0x00022007, //OpenGL debug context hint and attribute. 
        OPENGL_PROFILE = 0x00022008, //OpenGL profile hint and attribute.
        CONTEXT_RELEASE_BEHAVIOR = 0x00022009, //Context flush-on-release hint and attribute. 
        CONTEXT_NO_ERROR = 0x0002200A, //Context error suppression hint and attribute. 
        CONTEXT_CREATION_API = 0x0002200B, //Context creation API hint and attribute.

        NO_ROBUSTNESS = 0,
        NO_RESET_NOTIFICATION = 0x00031001,
        LOSE_CONTEXT_ON_RESET = 0x00031002,

        CURSOR = 0x00033001,
        STICKY_KEYS = 0x00033002,
        STICKY_MOUSE_BUTTONS = 0x00033003,
        LOCK_KEY_MODS = 0x00033004,
        RAW_MOUSE_MOTION = 0x00033005,
        DONT_CARE = -1,
    }

    public enum glfwContextVersion : int
    {
        MAJOR = 0x00022002, //Context client API major version hint and attribute.
        MINOR = 0x00022003, //Context client API minor version hint and attribute.
    }

    public enum glfwOpenGLAPI : int
    {
        NO_API = 0,
        OPENGL_API = 0x00030001,
        OPENGL_ES_API = 0x00030002,
    }

    public enum glfwOpenGLProfile : int
    {
        ANY_PROFILE = 0,
        OPENGL_CORE_PROFILE = 0x00032001,
        OPENGL_COMPAT_PROFILE = 0x00032002
    }

    public enum glfwCursorMode : int
    {
        CURSOR_NORMAL = 0x00034001,
        CURSOR_HIDDEN = 0x00034002,
        CURSOR_DISABLED = 0x00034003
    }

    public enum glfwReleaseBehavior : int
    {
        ANY_RELEASE_BEHAVIOR = 0,
        RELEASE_BEHAVIOR_FLUSH = 0x00035001,
        RELEASE_BEHAVIOR_NONE = 0x00035002
    }

    public enum glfwContextAPI : int
    {
        NATIVE_CONTEXT_API = 0x00036001,
        EGL_CONTEXT_API = 0x00036002,
        OSMESA_CONTEXT_API = 0x00036003
    }

    public enum glfwCursorShape : int
    {
        ARROW_CURSOR = 0x00036001, //The regular arrow cursor shape.
        IBEAM_CURSOR = 0x00036002, //The text input I-beam cursor shape.
        CROSSHAIR_CURSOR = 0x00036003, //The crosshair shape.
        HAND_CURSOR = 0x00036004, //The hand shape.
        HRESIZE_CURSOR = 0x00036005, //The horizontal resize arrow shape.
        VRESIZE_CURSOR = 0x00036006 //The vertical resize arrow shape.
    }

    public enum glfwConnectionState : int
    {
        CONNECTED = 0x00040001,
        DISCONNECTED = 0x00040002
    }

    public enum glfwInitHint : int
    {
        JOYSTICK_HAT_BUTTONS = 0x00050001, //Joystick hat buttons init hint.
        COCOA_CHDIR_RESOURCES = 0x00051001, //macOS specific init hint. 
        COCOA_MENUBAR = 0x00051002 //macOS specific init hint. 
    }

    public enum glfwVersion : int {
        MAJOR = 3, //The major version number of the GLFW library.
        MINOR = 3, //The minor version number of the GLFW library.
        REVISION = 0 //The revision number of the GLFW library.
    }

    public enum glfwInputState : int
    {
        RELEASE = 0, //The key or mouse button was released.
        PRESS = 1, //The key or mouse button was pressed.
        REPEAT = 2 //The key was held down until it repeated.
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        /// <summary>
        /// Sets the specified init hint to the desired value.
        /// </summary>
        /// <param name="hint"></param>
        /// <param name="value"></param>
        public static void InitHint(glfwInitHint hint, int value) => InitHint((int)hint, value);

        /// <summary>
        /// Sets the specified init hint to the desired value.
        /// </summary>
        /// <param name="hint"></param>
        /// <param name="value"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwInitHint"
            )]
        public static extern void InitHint(int hint, int value);
        
        /// <summary>
        /// Retrieves the version of the GLFW library.
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
        /// <param name="rev"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetVersion"
            )]
        public static extern void GetVersion(out int major, out int minor, out int rev);


        /// <summary>
        /// Returns a string describing the compile-time configuration.
        /// </summary>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetVersionString"
            )]
        public static extern string GetVersionString();


        /// <summary>
        /// Returns and clears the last error for the calling thread.
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public static unsafe glfwError GetError(out string description)
        {
            int res = __GetError(out IntPtr str);
            description = Marshal.PtrToStringAnsi(str);
            return (glfwError)res;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetError"
            )]
        internal static extern int __GetError(out IntPtr ptr);

        /// <summary>
        /// Sets the error callback.
        /// </summary>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetErrorCallback"
            )]
        internal static extern __errorfun SetErrorCallback(__errorfun cbfun);
        
        /// <summary>
        /// Processes all pending events.
        /// </summary>
        public static void PollEvents()
        {
            __PollEvents();
            GLFW_Window.__UpdateKeyboards();
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwPollEvents" 
            )]
        internal static extern void __PollEvents();

        /// <summary>
        /// Waits until events are queued and processes them.
        /// </summary>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwWaitEvents" 
            )]
        public static extern void WaitEvents();

        /// <summary>
        /// Waits with timeout until events are queued and processes them.
        /// </summary>
        /// <param name="timeout"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwWaitEventsTimeout" 
            )]
        public static extern void WaitEventsTimeout(double timeout);

        /// <summary>
        /// Posts an empty event to the event queue.
        /// </summary>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwPostEmptyEvent" 
            )]
        public static extern void PostEmptyEvent();

        /// <summary>
        /// Returns the value of an input option for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetInputMode" 
            )]
        public static extern int GetInputMode(IntPtr window, int mode);

        /// <summary>
        /// Sets an input option for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="mode"></param>
        /// <param name="value"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetInputMode" 
            )]
        public static extern void SetInputMode(IntPtr window, int mode, int value);

        
        /// <summary>
        /// Sets the cursor for the window. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cursor"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetCursor" 
            )]
        public static extern void SetCursor(IntPtr window, IntPtr cursor);

        /// <summary>
        /// Sets the key callback.   
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetKeyCallback" 
            )]
        internal static extern keyfun __SetKeyCallback(IntPtr window, __keyfun cbfun);

        /// <summary>
        /// Sets the Ansi character callback. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetCharCallback" 
            )]
        internal static extern __charfun __SetCharCallback(IntPtr window, __charfun cbfun);

        /// <summary>
        /// Sets the Ansi character with modifiers callback. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetCharModsCallback" 
            )]
        public static extern charmodsfun SetCharModsCallback(IntPtr window, charmodsfun cbfun);

        
        /// <summary>
        /// Sets the scroll callback.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetScrollCallback" 
            )]
        public static extern scrollfun SetScrollCallback(IntPtr window, scrollfun cbfun);

        /// <summary>
        /// Sets the file drop callback. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetDropCallback" 
            )]
        public static extern dropfun SetDropCallback(IntPtr window, dropfun cbfun);

         /// <summary>
        /// Sets the clipboard to the specified string. 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="s"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetClipboardString" 
            )]
        public static extern void SetClipboardString(IntPtr window, string s);

        /// <summary>
        /// Returns the contents of the clipboard as a string. 
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetClipboardString" 
            )]
        public static extern string GetClipboardString(IntPtr window);

        /// <summary>
        /// Returns the value of the GLFW timer.
        /// </summary>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetTime" 
            )]
        public static extern double GetTime();

        /// <summary>
        /// Sets the GLFW timer.
        /// </summary>
        /// <param name="time"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetTime" 
            )]
        public static extern void SetTime(double time);

        /// <summary>
        /// Returns the current value of the raw timer.
        /// </summary>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetTimerValue" 
            )]
        public static extern ulong GetTimerValue();

        /// <summary>
        /// Returns the frequency, in Hz, of the raw timer. 
        /// </summary>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetTimerFrequency" 
            )]
        public static extern ulong GetTimerFrequency();

        /// <summary>
        /// Sets the swap interval for the current context.
        /// </summary>
        /// <param name="interval"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSwapInterval" 
            )]
        public static extern void SwapInterval(int interval);

        /// <summary>
        /// Returns whether the specified extension is available.
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwExtensionSupported" 
            )]
        public static extern int ExtensionSupported(string extension);

        /// <summary>
        /// Returns the address of the specified function for the current context.
        /// </summary>
        /// <param name="procname"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetProcAddress" 
            )]
        public static extern IntPtr GetProcAddress(string procname);

        /// <summary>
        /// Returns whether the Vulkan loader and an ICD have been found.
        /// </summary>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwVulkanSupported" 
            )]
        public static extern int VulkanSupported();

        /// <summary>
        /// Returns the Vulkan instance extensions required by GLFW.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetRequiredInstanceExtensions" 
            )]
        public static extern string[] GetRequiredInstanceExtensions(out uint count);



        /*
public static extern vkproc glfwGetInstanceProcAddress (VkInstance instance, string procname);
    Returns the address of the specified Vulkan instance function.


public static extern int glfwGetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint32_t queuefamily);

 Returns whether the specified queue family can present images.

public static extern VkResult glfwCreateWindowSurface(VkInstance instance, IntPtr window, const VkAllocationCallbacks* allocator, VkSurfaceKHR *surface);
Creates a Vulkan surface for the specified window.
}
*/
    }
}


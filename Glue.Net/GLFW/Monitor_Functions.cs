using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {

        /// <summary>
        /// Returns the currently connected monitors.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static GLFWMonitor[] GetMonitors() => GLFWMonitor.GetMonitors();
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMonitors"
            )]
        internal static unsafe extern IntPtr* __GetMonitors(int* count);


        /// <summary>
        /// Returns the primary monitor.
        /// </summary>
        /// <returns></returns>
        public static GLFWMonitor GetPrimaryMonitor => GLFWMonitor.PrimaryMonitor;


        /// <summary>
        /// Returns the position of the monitor's viewport on the virtual screen.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        public static void GetMonitorPos(GLFWMonitor monitor, out int xPos, out int yPos)
        {
            xPos = monitor.Position.x;
            yPos = monitor.Position.y;
        }
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMonitorPos"
            )]
        internal static extern void __GetMonitorPos(IntPtr monitor, out int xPos, out int yPos);


        /// <summary>
        /// Retrives the work area of the monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void GetMonitorWorkarea(GLFWMonitor monitor, out int xpos, out int ypos, out int width, out int height)
        {
            xpos = monitor.WorkArea.x;
            ypos = monitor.WorkArea.y;
            width = monitor.WorkArea.Width;
            height = monitor.WorkArea.Height;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMonitorWorkarea"
            )]
        internal static extern void __GetMonitorWorkarea(IntPtr monitor, out int xpos, out int ypos, out int width, out int height);


        /// <summary>
        /// Returns the physical size of the monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="widthMM"></param>
        /// <param name="heightMM"></param>
        public static void GetMonitorPhysicalSize(GLFWMonitor monitor, out int widthMM, out int heightMM)
        {
            widthMM = monitor.PhysicalSize.Width;
            heightMM = monitor.PhysicalSize.Height;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMonitorPhysicalSize"
            )]
        internal static extern void __GetMonitorPhysicalSize(IntPtr ptr, out int widthMM, out int heightMM);


        /// <summary>
        /// Retrieves the content scale for the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="xscale"></param>
        /// <param name="yscale"></param>
        public static void GetMonitorContentScale(GLFWMonitor monitor, out float xscale, out float yscale)
        {
            xscale = monitor.ContentScale.x;
            yscale = monitor.ContentScale.y;
        }

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMonitorContentScale"
            )]
        internal static extern void __GetMonitorContentScale(IntPtr monitor, out float xscale, out float yscale);


        /// <summary>
        /// Returns the name of the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <returns></returns>
        public static string GetMonitorName(GLFWMonitor monitor) =>
            monitor.Name;

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetMonitorName"
            )]
        internal static extern string __GetMonitorName(IntPtr monitor);


        /// <summary>
        /// Sets the user pointer of the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="pointer"></param>
        public static void SetMonitorUserPointer(GLFWMonitor monitor, object pointer) => monitor.SetUserPointer(pointer);

        /// <summary>
        /// Returns the user pointer of the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <returns></returns>
        public static object GetMonitorUserPointer(GLFWMonitor monitor) => monitor.UserPointer;


        /// <summary>
        /// Adds a monitor configuration callback. 
        /// </summary>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static monitorfun AddMonitorCallback(monitorfun cbfun)
        {
            GLFWMonitor.OnMonitorConfiguration += cbfun;
            return cbfun;
        }

        /// <summary>
        /// Removes a monitor configuration callback. 
        /// </summary>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        public static void RemoveMonitorCallback(monitorfun cbfun) =>
            GLFWMonitor.OnMonitorConfiguration -= cbfun;


        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetMonitorCallback"
            )]
        internal static extern __monitorfun __SetMonitorCallback(__monitorfun cbfun);

        /// <summary>
        /// Returns the available video modes for the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static GLFWVideoMode[] GetVideoModes(GLFWMonitor monitor) =>
            monitor.SupportedVideoModes;

        /// <summary>
        /// Returns the current mode of the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <returns></returns>
        public static GLFWVideoMode GetVideoMode(GLFWMonitor monitor) =>
            monitor.VideoMode;
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetVideoMode"
            )]
        internal static extern IntPtr __GetVideoMode(IntPtr monitor);


        /// <summary>
        /// Generates a gamma ramp and sets it for the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="gamma"></param>
        public static GLFWgammaramp SetGamma(GLFWMonitor monitor, float gamma) =>
            monitor.SetGamma(gamma);
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetGamma"
            )]
        internal static extern void __SetGamma(IntPtr monitor, float gamma);


        /// <summary>
        /// Returns the current gamma ramp for the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <returns></returns>
        public static GLFWgammaramp GetGammaRamp(GLFWMonitor monitor) =>
            monitor.GammaRamp;
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetGammaRamp"
            )]
        internal static extern IntPtr __GetGammaRamp(IntPtr monitor);

        /// <summary>
        /// Sets the current gamma ramp for the specified monitor.
        /// </summary>
        /// <param name="monitor"></param>
        /// <param name="ramp"></param>
        public static void SetGammaRamp(GLFWMonitor monitor, GLFWgammaramp ramp) =>
            monitor.SetGammaRamp(ramp);
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetGammaRamp"
            )]
        internal static extern void __SetGammaRamp(IntPtr monitor, IntPtr ramp);
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public sealed class GLFWMonitor
    {
        static List<GLFWMonitor> monitors = new List<GLFWMonitor>();

        public static GLFWMonitor PrimaryMonitor { get; private set; }

        internal IntPtr Handle { get; private set; }
        internal bool IsConnected { get; private set; }
        public bool IsPrimary { get; private set; }
        public (int Width, int Height) PhysicalSize { get; private set; }
        public (float x, float y) ContentScale { get; private set; }
        public (int x, int y) Position { get; private set; }
        public (int x, int y, int Width, int Height) WorkArea { get; private set; }
        public string Name { get; private set; }
        public GLFWgammaramp GammaRamp { get; private set; }
        public GLFWVideoMode VideoMode { get; private set; }
        public GLFWVideoMode[] SupportedVideoModes { get; private set; }

        public object UserPointer { get; private set; }


        public static event Glfw.monitorfun OnMonitorConfiguration
        {
            add => onMonConfig += value;
            remove => onMonConfig -= value;
        }

        static event Glfw.monitorfun onMonConfig;

        internal GLFWMonitor(IntPtr handle, bool isPrimary)
        {
            Handle = handle;
            IsConnected = true;
        }

        public static GLFWMonitor[] GetMonitors() => monitors.ToArray();
        
        public static GLFWMonitor GetMonitor(int index) => monitors[index];

        internal unsafe static bool Init()
        {
            int count = 0;
            IntPtr* ptr = Glfw.__GetMonitors(&count);
            
            for (int i = 0; i < count; i++)
            {
                
                GLFWMonitor mon = new GLFWMonitor(ptr[i], i == 0);

                Glfw.__GetMonitorPhysicalSize(mon.Handle, out int width, out int height);
                Glfw.__GetMonitorContentScale(mon.Handle, out float xscale, out float yscale);
                Glfw.__GetMonitorWorkarea(mon.Handle, out int xwa, out int ywa, out int wwa, out int hwa);
                Glfw.__GetMonitorPos(mon.Handle, out int xp, out int yp);

                mon.GammaRamp = new GLFWgammaramp(Glfw_HelperFunctions.__CreateGammaRamp(Glfw.__GetGammaRamp(mon.Handle)));
                
                mon.PhysicalSize = (width, height);
                mon.ContentScale = (xscale, yscale);
                mon.WorkArea = (xwa, ywa, wwa, hwa);
                mon.Position = (xp, yp);
                mon.IsConnected = true;
                mon.SupportedVideoModes = GLFWVideoMode.__LoadVideoModes(mon, out GLFWVideoMode active);
                mon.VideoMode = active;
                mon.Name = Glfw.__GetMonitorName(mon.Handle);
                monitors.Add(mon);
            }

            PrimaryMonitor = monitors[0];

            Glfw.__SetMonitorCallback(__NativeMonitorConfigCallback);
            return true;
        }

        public GLFWgammaramp SetGamma(float gamma)
        {
            Glfw.__SetGamma(Handle, gamma);
            GammaRamp = new GLFWgammaramp(Glfw_HelperFunctions.__CreateGammaRamp(Glfw.__GetGammaRamp(Handle)));
            return GammaRamp;
        }
        public void SetGammaRamp(GLFWgammaramp ramp)
        {
            Glfw.__SetGammaRamp(Handle,ramp.Handle);
            GammaRamp = ramp;
        }

        public void SetUserPointer(object ptr)
        {
            UserPointer = ptr;
        }
        static void __NativeMonitorConfigCallback(IntPtr window, int i) =>
            onMonConfig?.Invoke(GLFW_Window.GetWindowFromPtr(window), i);
    }
}
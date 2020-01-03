using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        /// <summary>
        /// Returns whether the specified joystick is present.
        /// </summary>
        /// <param name="jid"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwJoystickPresent"
            )]
        public static extern int JoystickPresent(int jid);

        /// <summary>
        /// Returns the values of all axes of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetJoystickAxes"
            )]
        public static extern float[] GetJoystickAxes(int jid, out int count);

        /// <summary>
        /// Returns the state of all buttons of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetJoystickButtons"
            )]
        public static extern byte[] GetJoystickButtons(int jid, out int count);

        /// <summary>
        /// Returns the state of all hats of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetJoystickHats"
            )]
        public static extern byte[] GetJoystickHats(int jid, out int count);

        /// <summary>
        /// Returns the name of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetJoystickName"
            )]
        public static extern string GetJoystickName(int jid);

        /// <summary>
        /// Returns the SDL comaptible GUID of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetJoystickGUID"
            )]
        public static extern string GetJoystickGUID(int jid);

        /// <summary>
        /// Sets the user pointer of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <param name="pointer"></param>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetJoystickUserPointer"
            )]
        public static extern void SetJoystickUserPointer(int jid, IntPtr pointer);

        /// <summary>
        /// Returns the user pointer of the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetJoystickUserPointer"
            )]
        public static extern IntPtr GetJoystickUserPointer(int jid);

        /// <summary>
        /// Returns whether the specified joystick has a gamepad mapping. 
        /// </summary>
        /// <param name="jid"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwJoystickIsGamepad"
            )]
        public static extern int JoystickIsGamepad(int jid);

        /// <summary>
        /// Sets the joystick configuration callback. 
        /// </summary>
        /// <param name="cbfun"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwSetJoystickCallback"
            )]
        public static extern joystickfun SetJoystickCallback(joystickfun cbfun);

        /// <summary>
        /// Adds the specified SDL_GameControllerDB gamepad mappings.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwUpdateGamepadMappings"
            )]
        public static extern int UpdateGamepadMappings(string s);

        /// <summary>
        /// Returns the human-readable gamepad name for the specified joystick.
        /// </summary>
        /// <param name="jid"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetGamepadName"
            )]
        public static extern string GetGamepadName(int jid);

        /// <summary>
        /// Retrieves the state of the specified joystick remapped as a gamepad.
        /// </summary>
        /// <param name="jid"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetGamepadState"
            )]
        public static extern int GetGamepadState(int jid, IntPtr state);
    }
}

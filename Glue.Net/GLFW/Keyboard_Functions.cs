using System;
using System.Collections.Generic;
using System.Runtime.InteropServices; 
using System.Text;

namespace GlueNet.GLFW
{
    public static partial class Glfw
    {
        /// <summary>
        /// Returns the layout-specific name of the specified printable key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="scancode"></param>
        /// <returns></returns>
        public static string GetKeyName(KeyCode key = KeyCode.UNKNOWN, int scancode = 0)
        {
            return Marshal.PtrToStringUni(__GetKeyName((int)key, scancode));
        }

        [DllImport("Glue.Net-Native.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode,
            EntryPoint = "glfwGetKeyName"
            )]
        internal static unsafe extern IntPtr __GetKeyName(int key, int scancode);

        /// <summary>
        /// Returns the platform-specific scancode of the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetKeyScancode(KeyCode key) => __GetKeyScancode((int)key);

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetKeyScancode"
            )]
        internal static extern int __GetKeyScancode(int key);

        /// <summary>
        /// Returns the last reported state of a keyboard key for the specified window.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static KeyState GetKey(GLFW_Window window, KeyCode key) => window.Keyboard.GetKey(key).State;

        [DllImport("glfw3.dll",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi,
            EntryPoint = "glfwGetKey"
            )]
        internal static extern int __GetKey(IntPtr window, int key);
    }
}

using System;
using System.Threading;
using GlueNet.GLFW;
using GlueNet.OpenGL;

namespace GlueNet
{
    public static partial class Glue
    {
        public static bool IsInitialized { get; private set; }
        public static bool IsAlive { get; private set; }
        public static event  Glfw.errorfun OnGlfwError
        {
            add => __onGlfwError += value;
            remove => __onGlfwError -= value;
        }

        static event Glfw.errorfun __onGlfwError;

        /// <summary>
        /// Initializes Glfw and then Glue. Creates a Windowed window and sets it as the current context.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool Init(int width, int height, string title, out GLFW_Window window)
        {
            InitGlfw();
            window = new GLFW_Window(width, height, title, null, null);
            window.MakeContextCurrent();
            Gl.Init(window);
            IsAlive = true;
            IsInitialized = true;
            return true;
        }

        public static void Terminate()
        {
            IsAlive = false;
            __TerminateGlfw();
            Thread.Sleep(1500); //Give Glfw some time to terminate.
        }

        /// <summary>
        /// Initializes the Glfw library
        /// </summary>
        /// <returns>True if Glfw is successfully initialized or if Glfw is already initialized</returns>
        public static bool InitGlfw()
        {
            if (!Glfw.IsInitialized)
            {
                if (Glfw.__Init())
                {
                    Glfw.SetErrorCallback(__NativeGlfwErrorCallback);
                    return true;
                }
                else
                    throw new Exception("Error initializing GLFW");
            }
            return true;
        }

        public static bool InitGL(GLFW_Window window)
        {
            Gl.Init(window);
            IsAlive = true;
            IsInitialized = true;
            return true;
            
        }

        static void __NativeGlfwErrorCallback(int err, string errmsg)
        {
            __onGlfwError?.Invoke((glfwError)err, errmsg);
        }

        static void __NativeGlErrorCallback()
        {
            throw new NotImplementedException();
        }
    }
}

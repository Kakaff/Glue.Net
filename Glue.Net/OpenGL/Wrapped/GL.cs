using GlueNet.Math;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.OpenGL
{
    /*  Wrappers around GL functions so the user doesn't have to fiddle with pointers too much.
        Is updated as i use functions.
    */
    public static partial class GL
    {

        public unsafe static uint[] glGenTextures(in int n)
        {
            uint[] buff = new uint[n];
            fixed (uint* ptr = &buff[0])
                glGenTextures(n, ptr);

            return buff;
        }

        public unsafe static uint[] glGenBuffers(in int n)
        {
            uint[] buff = new uint[n];
            fixed (uint* ptr = &buff[0])
                glGenBuffers(n, ptr);

            return buff;
        }

        public static bool glGetError(out uint err)
        {
            err = GL.glGetError();
            return err == GL.GL_NO_ERROR;
        }

        public static unsafe void glShaderSource(in uint shader, in string src)
        {
            byte[] shadSrc = Encoding.UTF8.GetBytes(src);
            int l = shadSrc.Length;

            char** strArr = (char**)Marshal.AllocHGlobal(8);
            fixed (byte* ptr = &shadSrc[0])
            {
                strArr[0] = (char*)ptr;
                GL.glShaderSource(shader, 1, strArr, &l);
            }

            Marshal.FreeHGlobal((IntPtr)strArr);
        }

        public static unsafe string glGetShaderInfoLog(in uint shader, in int bufferSize)
        {
            byte[] infoLog = new byte[bufferSize];
            fixed (byte* logPtr = &infoLog[0])
                GL.glGetShaderInfoLog(shader, bufferSize, (int*)IntPtr.Zero, (char*)logPtr);

            return Encoding.UTF8.GetString(infoLog);
        }

        public static unsafe string glGetProgramInfoLog(in uint program, in int bufferSize)
        {
            byte[] infoLog = new byte[bufferSize];
            fixed (byte* logPtr = &infoLog[0])
                GL.glGetProgramInfoLog(program, bufferSize, (int*)IntPtr.Zero, (char*)logPtr);

            return Encoding.UTF8.GetString(infoLog);
        }

        public static unsafe int glGetUniformLocation(in uint program, in string name)
        {
            int res = 0;

            byte[] strArr = Encoding.UTF8.GetBytes(name);
            fixed (byte* strPtr = &strArr[0])
                res = glGetUniformLocation(program, (char*)strPtr);

            return res;
        }

        public static unsafe void glUniformMatrix4fv(in int location,in bool transpose, params Matrix4x4[] matricies)
        {
            fixed (Matrix4x4* dataPtr = &matricies[0])
                glUniformMatrix4fv(location, matricies.Length, transpose, (float*)dataPtr);
        }

        public static unsafe void glDeleteBuffers(params uint[] buffers)
        {
            fixed (uint* ptr = &buffers[0])
                glDeleteBuffers(buffers.Length, ptr);
        }

        public static unsafe void glDeleteTextures(params uint[] textures)
        {
            fixed (uint* ptr = &textures[0])
                glDeleteTextures(textures.Length, ptr);
        }
    }
}

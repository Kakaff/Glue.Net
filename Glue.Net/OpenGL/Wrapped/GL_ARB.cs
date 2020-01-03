using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.OpenGL
{
    /*  Wrappers around GL_ARB functions so the user doesn't have to fiddle with pointers too much.
        Is updated as i use functions.
    */

    public static partial class GL_ARB
    {
        public unsafe static uint[] glGenVertexArrays(int n)
        {
            uint[] buff = new uint[n];
            fixed (uint* ptr = &buff[0])
                glGenVertexArrays(n, ptr);

            return buff;
        }
    }
}

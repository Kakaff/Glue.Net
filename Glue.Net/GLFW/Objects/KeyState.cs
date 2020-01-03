using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.GLFW
{
    public enum KeyState
    {
        Up = 0b0001,
        Released = 0b0010,
        Pressed = 0b0100,
        Down = 0b1000,
    }
}

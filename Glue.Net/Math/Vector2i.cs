using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.Math
{
    [StructLayout(LayoutKind.Sequential,Pack = 4,Size = 8)]
    public struct Vector2i
    {
        public int x, y;


        public Vector2i(int i)
        {
            x = i;
            y = i;
        }

        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public override string ToString()
        {
            return $"Vec2i({x}, {y})";
        }

        public static Vector2i operator +(in Vector2i v, in int i) => new Vector2i(v.x + i, v.y + i);
        public static Vector2i operator +(in Vector2i v1, in Vector2i v2) => new Vector2i(v1.x + v2.x, v1.y + v2.y);
        public static Vector2i operator -(in Vector2i v1, in Vector2i v2) => new Vector2i(v1.x - v2.x, v1.y - v2.y);
        public static Vector2i operator /(in Vector2i v, int i) => new Vector2i(v.x / i, v.y / i);
        public static Vector2i operator /(in Vector2i v, float f) => new Vector2i((int)(v.x / f), (int)(v.y / f));

        public static Vector2i operator *(in Vector2i v, float f) => new Vector2i((int)(v.x * f), (int)(v.y * f));
    }
}

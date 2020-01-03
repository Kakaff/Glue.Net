using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GlueNet.Math
{
    [StructLayout(LayoutKind.Sequential,Pack = 4, Size = 8)]
    public struct Vector2
    {
        public float x, y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(in Vector2 v1, in Vector2 v2) => new Vector2(v1.x + v2.x, v1.y + v2.y);
        public static Vector2 operator +(in Vector2 v1, in Vector2i v2) => new Vector2(v1.x + v2.x, v1.y + v2.y);
        public static Vector2 operator +(in Vector2 v, in int i) => new Vector2(v.x + i, v.y + i);
            
        public static Vector2 operator * (in Vector2 v1, in Vector2 v2) => new Vector2(v1.x * v2.x, v1.y * v2.y);

        public static Vector2 operator /(in Vector2 v1, in Vector2 v2) => new Vector2(v1.x / v2.x, v1.y / v2.y);
        public override string ToString()
        {
            return $"Vec2({x}, {y})";
        }
    }
}

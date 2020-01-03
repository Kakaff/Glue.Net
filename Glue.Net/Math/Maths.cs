using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.Math
{
    public static class Maths
    {
        public const double DegreesToRadians = 0.0174532925d;
        public const double RadiansToDegrees = 57.2957795d;


        public static float WrapToRange(float min, float max, float v)
        {
            float range = max - min;
            float offset = v - min;

            return (float)(offset - (System.Math.Floor((double)offset / (double)range) * range)) + min;
        }


        public static bool InRange(int value, int min, int max) => !(value < min || value > max);
    }
}

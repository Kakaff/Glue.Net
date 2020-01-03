using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.Math
{
    public readonly struct Box2D
    {
        public readonly Vector2 LB, RT;

        public Box2D(in Vector2 v1, in Vector2 v2)
        {
            LB = v1;
            RT = v2;
        }


        public Vector2[] ToUvCoordinates()
        {
            return new Vector2[] { new Vector2(LB.x, RT.y), LB, new Vector2(RT.x, LB.y), RT };
        }
        public override string ToString()
        {
            return $"Box2D({LB}, {RT})";
        }
    }
}

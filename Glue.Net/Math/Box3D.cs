using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.Math
{
    public readonly struct Box3D
    {
        public readonly Vector3 LBF, RTB;

        public Box3D(in Vector3 v1, in Vector3 v2)
        {
            LBF = v1;
            RTB = v2;
        }

        public override string ToString()
        {
            return $"Box3D({LBF}, {RTB})";
        }
    }
}

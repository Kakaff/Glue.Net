using System;
using System.Collections.Generic;
using System.Text;

namespace GlueNet.Math
{
    public struct Quaternion
    {
        public float x, y, z, w;

        public Quaternion(in float x, in float y, in float z, in float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Quaternion(in float f)
        {
            x = f;
            y = f;
            z = f;
            w = f;
        }

        public static Quaternion CreateFromAxisAngle(in Vector3 axis, in float angle)
        {
            Quaternion res = new Quaternion();
            double s = System.Math.Sin(angle * 0.5d);
            res.x = (float)(axis.x * s);
            res.z = (float)(axis.z * s);
            res.y = (float)(axis.y * s);

            res.w = (float)System.Math.Cos(angle * 0.5d);

            return res;
        }

        public static Quaternion Normalized(in Quaternion q) {
            float l = 1.0f / (float)System.Math.Sqrt(q.x * q.x + q.y * q.y + q.z * q.z + q.w * q.w);
            return new Quaternion(q.x * l, q.y * l, q.z * l, q.w * l);
        }

        public static Quaternion Inverse(Quaternion q)
        {
            Quaternion r;

            float ls = q.x * q.x + q.y * q.y + q.z * q.z + q.w * q.w;
            float invNorm = 1.0f / ls;

            r.x = -q.x * invNorm;
            r.y = -q.y * invNorm;
            r.z = -q.z * invNorm;
            r.w = q.w * invNorm;

            return r;
        }

        public static Quaternion Conjugate(in Quaternion q) =>
            new Quaternion(-q.x, -q.y, -q.z, q.w);

        public static Quaternion Identity => new Quaternion() { w = 1 };

        public static Quaternion operator * (in Quaternion q1, in Quaternion q2) =>
            new Quaternion(q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y,
                           q1.w * q2.y - q1.x * q2.z + q1.y * q2.w + q1.z * q2.x,
                           q1.w * q2.z + q1.x * q2.y - q1.y * q2.x + q1.z * q2.w,
                           q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z);
    }
}

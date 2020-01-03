using System.Runtime.InteropServices;

namespace GlueNet.Math
{
    [StructLayout(LayoutKind.Sequential,Pack = 4,Size = 16)]
    public struct Vector3
    {
        public float x, y, z;

        public static Vector3 Forward => new Vector3(0, 0, 1);
        public static Vector3 Up => new Vector3(0, 1, 0);
        public static Vector3 Right => new Vector3(1, 0, 0);
        public static Vector3 Zero => new Vector3();
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3(float f)
        {
            x = f;
            y = f;
            z = f;
        }

        public static Vector3 Normalized(in Vector3 v) => v * (1.0f / Length(v));

        public static float Length(in Vector3 v) => (float)System.Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
        public static Vector3 operator -(in Vector3 v) => new Vector3(-v.x, -v.y, -v.z);

        public static Vector3 operator +(in Vector3 v, in float f) => new Vector3(v.x + f, v.y + f, v.z + f);
        public static Vector3 operator -(in Vector3 v, in float f) => new Vector3(v.x - f, v.y - f, v.z - f);
        public static Vector3 operator *(in Vector3 v, in float f) => new Vector3(v.x * f, v.y * f, v.z * f);
        public static Vector3 operator /(in Vector3 v, in float f)
        {
            float tmp = 1.0f / f;
            return new Vector3(v.x * tmp, v.y * tmp, v.z * tmp);
        }

        public static Vector3 operator +(in Vector3 v1, in Vector3 v2) => new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        public static Vector3 operator -(in Vector3 v1, in Vector3 v2) => new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        public static Vector3 operator *(in Vector3 v1, in Vector3 v2) => new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        public static bool operator ==(in Vector3 v1, in Vector3 v2) =>
            v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
        public static bool operator !=(in Vector3 v1, in Vector3 v2) => !(v1 == v2);
        public static Vector3 operator *(in Vector3 v, in Quaternion q)
        {
            Quaternion nQ = Quaternion.Normalized(in q);
            Quaternion rQ = Quaternion.Conjugate(nQ) * new Quaternion(v.x, v.y, v.z, 0) * nQ;

            return new Vector3(rQ.x, rQ.y, rQ.z);
        }
        public static Vector3 operator *(in Vector3 v, in Matrix4x4 m) =>
             new Vector3(v.x * m.m00 + v.y * m.m10 + v.z * m.m20 + m.m30,
                         v.x * m.m01 + v.y * m.m11 + v.z * m.m21 + m.m31,
                         v.x * m.m02 + v.y * m.m12 + v.z * m.m22 + m.m32);

        public float[] ToArray() => new float[] { x, y, z };

        public override string ToString() => $"Vec3({x}, {y}, {z})";
    }
}

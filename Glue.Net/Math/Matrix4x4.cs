using System.Runtime.InteropServices;

namespace GlueNet.Math
{
    [StructLayout(LayoutKind.Sequential,Pack = 4,Size = 64)]
    public struct Matrix4x4
    {
        public float m00, m01, m02, m03,
                     m10, m11, m12, m13,
                     m20, m21, m22, m23,
                     m30, m31, m32, m33;

        
        public static Matrix4x4 Identity => new Matrix4x4 { m00 = 1, m11 = 1, m22 = 1, m33 = 1};

        public static Matrix4x4 CreateTranslationMatrix(in Vector3 translation)
        {
            Matrix4x4 res = Identity;
            res.m30 = translation.x;
            res.m31 = translation.y;
            res.m32 = translation.z;
            return res;
        }

        public static Matrix4x4 CreateScaleMatrix(in Vector3 scale)
        {
            Matrix4x4 res = new Matrix4x4();

            res.m00 = scale.x;
            res.m11 = scale.y;
            res.m22 = scale.z;
            res.m33 = 1f;

            return res;
        }

        public static Matrix4x4 CreateRotationMatrix(in Quaternion q)
        {
            Matrix4x4 res = new Matrix4x4();
            
            float sqw = q.w * q.w;
            float sqx = q.x * q.x;
            float sqy = q.y * q.y;
            float sqz = q.z * q.z;

            /* Thank you Eucladianspace - If only i had learnt this in school :(
             * https://www.euclideanspace.com/maths/geometry/rotations/conversions/quaternionToMatrix/index.htm
             */

            float invs = 1 / (sqx + sqy + sqz + sqw);
            res.m00 = (sqx - sqy - sqz + sqw) * invs; 
            res.m11 = (-sqx + sqy - sqz + sqw) * invs;
            res.m22 = (-sqx - sqy + sqz + sqw) * invs;

            float tmp1 = q.x * q.y;
            float tmp2 = q.z * q.w;
            res.m10 = 2.0f * (tmp1 + tmp2) * invs;
            res.m01 = 2.0f * (tmp1 - tmp2) * invs;

            tmp1 = q.x * q.z;
            tmp2 = q.y * q.w;
            res.m20 = 2.0f * (tmp1 - tmp2) * invs;
            res.m02 = 2.0f * (tmp1 + tmp2) * invs;
            tmp1 = q.y * q.z;
            tmp2 = q.x * q.w;
            res.m21 = 2.0f * (tmp1 + tmp2) * invs;
            res.m12 = 2.0f * (tmp1 - tmp2) * invs;

            res.m33 = 1;
            return res;
        }

        public static Matrix4x4 CreateOrthographicProjection(float left, float right, float bottom, float top, float near, float far)
        {
            //Thank you https://www.mathematik.uni-marburg.de/~thormae/lectures/graphics1/graphics_6_2_eng_web.html#1
            Matrix4x4 res = new Matrix4x4();
            res.m00 = 2f / (right - left);
            res.m11 = 2f / (top - bottom);
            res.m22 = -2f / (far - near);

            res.m03 = -((right + left) / (right - left));
            res.m13 = -((top + bottom) / (top - bottom));
            res.m23 = -((far + near) / (far - near));

            res.m33 = 1;
            return res;
        }
        public static Matrix4x4 CreatePerspectiveProjection(float fov,float aspect, float zNear,float zFar)
        {
            Matrix4x4 res = new Matrix4x4();

            float zRange = zFar - zNear;
            float tanHalfFov = (float)System.Math.Tan(fov * 0.5f);
            res.m00 = 1.0f / (tanHalfFov * aspect);
            res.m11 = 1.0f / tanHalfFov;

            res.m22 = (-zNear - zFar) / zRange;
            res.m23 = 2.0f * zFar * zNear / zRange;
            res.m32 = 1.0f;

            return res;


        }

        public static Matrix4x4 operator * (in Matrix4x4 m1, in Matrix4x4 m2)
        {
            Matrix4x4 res = new Matrix4x4();
            
            unsafe
            {
                float* rPtr = &res.m00;
                fixed (float* fPtr1 = &m1.m00)
                fixed (float* fPtr2 = &m2.m00)
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                            rPtr[i + j * 4] = fPtr1[0 + j * 4] * fPtr2[i + 0 * 4] +
                                              fPtr1[1 + j * 4] * fPtr2[i + 1 * 4] +
                                              fPtr1[2 + j * 4] * fPtr2[i + 2 * 4] +
                                              fPtr1[3 + j * 4] * fPtr2[i + 3 * 4];
                            
            }

            return res;
        }

        public override string ToString()
        {
            return $"{m00} {m01} {m02} {m03} \n" +
                   $"{m10} {m11} {m12} {m13} \n" +
                   $"{m20} {m21} {m22} {m23} \n" +
                   $"{m30} {m31} {m32} {m33}";
        }
    }
}

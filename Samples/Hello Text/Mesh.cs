using GlueNet;
using GlueNet.Math;
using GlueNet.OpenGL;
using System;
using System.Runtime.InteropServices;
using static GlueNet.OpenGL.GL;
using static GlueNet.OpenGL.GL_ARB;

namespace Hello_SDF_Text
{
    class Mesh
    {

        uint vbo;
        VertexArrayObject vao;

        public Mesh()
        {
            uint[] buffs = glGenBuffers(1);
            vbo = buffs[0];
            vao = new VertexArrayObject();

            vao.Bind();

            glBindBuffer(GL_ARRAY_BUFFER, vbo);
            vao.SetAttrib(0, 2, GL.GL_FLOAT, false, 2 * sizeof(float) + 2 * sizeof(float), IntPtr.Zero);
            vao.SetAttrib(1, 2, GL.GL_FLOAT, false, 2 * sizeof(float) + 2 * sizeof(float), new IntPtr(2 * sizeof(float)));
            vao.EnableAttrib(0);
            vao.EnableAttrib(1);

            vao.Unbind();
        }

        ~Mesh()
        {
            if (Glue.IsAlive)
                GL.glDeleteBuffers(vbo);
        }


        public unsafe void SetMeshData(float[] vertData)
        {
            GL.glBindBuffer(GL.GL_ARRAY_BUFFER, vbo);
            fixed (float* dPtr = &vertData[0])
            {
                glBufferData(GL_ARRAY_BUFFER, vertData.Length * sizeof(float), (IntPtr)dPtr, GL_STATIC_DRAW);
            }
        }
        public void Draw()
        {
            if (!vao.IsBound)
                vao.Bind();

            glDrawArrays(GL_QUADS, 0, 4);
            
        }

        public static Mesh CreateScreenQuad(in Vector2i size)
        {
            Mesh m = new Mesh();

            float[] data = new float[16];

            data[0] = 0; data[1] = 0;               data[2] = 0f; data[3] = 0f;
            data[4] = size.x; data[5] = 0;          data[6] = 1f; data[7] = 0f;
            data[8] = size.x; data[9] = -size.y;    data[10] = 1f; data[11] = 1f;
            data[12] = 0; data[13] = -size.y;       data[14] = 0f; data[15] = 1f;

            m.SetMeshData(data);
            return m;
        }
    }
}

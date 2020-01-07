using GlueNet.Math;
using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SDF_Text
{
    public sealed class TextMesh
    {
        uint vbo;
        VertexArrayObject vao;
        int ind;
        int buffSize;

        public TextMesh() {
            vbo = GL.glGenBuffers(1)[0];
            vao = new VertexArrayObject();
            vao.Bind();
            GL.glBindBuffer(GL.GL_ARRAY_BUFFER, vbo);

            vao.SetAttrib(0, 2, GL.GL_FLOAT, false, 2 * sizeof(float) + 2 * sizeof(float), IntPtr.Zero);
            vao.SetAttrib(1, 2, GL.GL_FLOAT, false, 2 * sizeof(float) + 2 * sizeof(float), new IntPtr(2 * sizeof(float)));
            vao.EnableAttrib(0);
            vao.EnableAttrib(1);

            vao.Unbind();
        }

        public void SetText(CharacterString cs, float lineSpacing = 1.1f, int maxLineLength = int.MaxValue)
        {
            float[] dat = cs.GetVertexData(new Vector2i(0, 0), 0, lineSpacing, maxLineLength);
            SetData(dat);
        }
        public void SetText(TextFont tf , string s, float lineSpacing = 1.1f, int maxLineLength = int.MaxValue)
        {
            if (s != null && s.Length > 0)
                SetText(new CharacterString(tf,s), lineSpacing, maxLineLength);
            else
                ind = 0;
        }

        public void Draw(int length = 0)
        {
            if (ind > 0)
            {
                if (!vao.IsBound)
                    vao.Bind();
                GL.glDrawArrays(GL.GL_QUADS, 0, length > ind ? ind : length > 0 ? length : ind);
            }
        }

        internal unsafe void SetData(in float[] dat)
        {
            ind = dat.Length / 4;
            if (ind > 0)
            {
                GL.glBindBuffer(GL.GL_ARRAY_BUFFER, vbo);
                fixed (float* dPtr = &dat[0])
                {
                    if (buffSize < dat.Length * sizeof(float))
                    {
                        buffSize = (dat.Length + (4 * 4)) * sizeof(float);
                        GL.glBufferData(GL.GL_ARRAY_BUFFER, buffSize, IntPtr.Zero, GL.GL_DYNAMIC_DRAW);
                    }
                    GL.glBufferSubData(GL.GL_ARRAY_BUFFER, 0, dat.Length * sizeof(float), (IntPtr)dPtr);
                }

                if (!GL.glGetError(out uint err))
                {
                    Console.WriteLine($"Error when updating textmesh, error {err}");
                }
            }
        }
    }
}

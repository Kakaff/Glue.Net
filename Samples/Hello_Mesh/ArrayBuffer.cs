using GlueNet;
using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Mesh
{
    public enum BufferTarget : uint
    {
        VertexBuffer = GL.GL_ARRAY_BUFFER,
        ElementBuffer = GL.GL_ELEMENT_ARRAY_BUFFER,
    }

    public class ArrayBuffer
    {
        public BufferTarget Target { get; }
        public uint Handle { get; }
        bool isDestroyed;

        public ArrayBuffer(BufferTarget target)
        {
            Target = target;
            Handle = GL.glGenBuffers(1)[0];
        }

        ~ArrayBuffer()
        {
            Destroy();
        }

        public void Destroy()
        {
            if (Glue.IsAlive && !isDestroyed)
            {
                GL.glDeleteBuffers(Handle);
                isDestroyed = true;
            }
        }

        public void Bind()
        {
            GL.glBindBuffer((uint)Target, Handle);
        }

        public void UnBind()
        {
            GL.glBindBuffer((uint)Target,0);
        }
    }
}

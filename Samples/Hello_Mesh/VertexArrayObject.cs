using GlueNet;
using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Mesh
{
    public sealed class VertexArrayObject
    {
        static VertexArrayObject boundVAO;

        public bool IsBound { get; private set; }

        public uint Handle { get; private set; }

        public VertexArrayObject()
        {
            Handle = GL_ARB.glGenVertexArrays(1)[0];
        }

        ~VertexArrayObject()
        {

            unsafe
            {
                if (Glue.IsAlive)
                {
                    uint h = Handle;
                    GL_ARB.glDeleteVertexArrays(1, &h);
                }
            }
        }

        public void SetAttrib(uint index, int size, uint type, bool normalized, int stride, IntPtr ptr)
        {
            GL.glVertexAttribPointer(index, size, type, normalized, stride, ptr);
            if (!GL.glGetError(out uint err))
                Console.WriteLine($"ERROR Setting Vertex Attribute {err}");
        }

        public void EnableAttrib(uint index)
        {
            GL_ARB.glEnableVertexArrayAttrib(Handle, index);
            if (!GL.glGetError(out uint err))
                Console.WriteLine($"ERROR Enabling Vertex Attribute {err}");
        }
        public void DisableAttrib(uint index)
        {
            GL_ARB.glDisableVertexArrayAttrib(Handle, index);
            if (!GL.glGetError(out uint err))
                Console.WriteLine($"ERROR Disabling Vertex Attribute {err}");
        }

        public void Bind()
        {
            if (!IsBound)
            {
                GL_ARB.glBindVertexArray(Handle);
                if (!GL.glGetError(out uint err))
                    Console.WriteLine($"ERROR Binding vertex array {err}");
                IsBound = true;
                if (boundVAO != null)
                    boundVAO.IsBound = false;
                boundVAO = this;
            }
        }

        public void Unbind()
        {
            if (IsBound)
            {
                GL_ARB.glBindVertexArray(0);
                if (!GL.glGetError(out uint err))
                    Console.WriteLine($"ERROR Unbinding vertex array {err}");
                boundVAO = null;
                IsBound = false;
            }
        }
    }
}

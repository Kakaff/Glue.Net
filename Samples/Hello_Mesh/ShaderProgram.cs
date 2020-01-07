using GlueNet;
using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Mesh
{
    public class ShaderProgram
    {
        static ShaderProgram activeShadProg;

        Shader[] shaders;

        public uint Handle { get; private set; }
        public bool IsBound { get; private set; }
        public bool IsLinked { get; private set; }

        public ShaderProgram(params Shader[] shaders)
        {
            this.shaders = shaders;
            Handle = GL.glCreateProgram();
        }

        ~ShaderProgram()
        {
            if (Glue.IsAlive)
                GL.glDeleteProgram(Handle);
        }

        public unsafe bool Link()
        {
            if (!IsLinked)
            {
                foreach (Shader s in shaders)
                {
                    if (!s.IsCompiled)
                        s.Compile();

                    GL.glAttachShader(Handle, s.Handle);
                }
                
                GL.glLinkProgram(Handle);

                int linkRes = 0;
                GL.glGetProgramiv(Handle, GL.GL_LINK_STATUS, &linkRes);

                if (linkRes == GL.GL_FALSE)
                    throw new Exception($"Error linking ShaderProgram \n" +
                        $"InfoLog: \n" +
                        $"{GL.glGetProgramInfoLog(Handle,1024)}");
                
                IsLinked = true;
                shaders = null;
            }

            return true;
        }

        public void UseProgram()
        {
            if (!IsBound)
            {
                GL.glUseProgram(Handle);
                if (!GL.glGetError(out uint err))
                    Console.WriteLine($"ERROR Using ShaderProgram {err}");

                if (activeShadProg != null)
                    activeShadProg.IsBound = false;

                activeShadProg = this;
                IsBound = true;
            }
        }

        public int GetUniformLocation(string name)
        {
            int res = GL.glGetUniformLocation(Handle, name);

            if (res == -1)
                throw new Exception($"Uniform {name} does not exist for ShaderProgram {Handle}");

            return res;
        }
    }
}

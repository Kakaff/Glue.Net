﻿using GlueNet;
using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Mesh
{
    public class Shader : IDisposable
    {
        public enum ShaderStage : uint
        {
            Vertex = GL.GL_VERTEX_SHADER,
            Fragment = GL.GL_FRAGMENT_SHADER
        }

        string src;

        public bool IsCompiled {get; private set;}
        public ShaderStage Stage { get; private set; }
        public uint Handle { get; private set; }
        bool isDisposed;

        public Shader(ShaderStage shadstage, params string[] src)
        {
            this.src = string.Join("\n", src);
            Stage = shadstage;
            Handle = GL.glCreateShader((uint)shadstage);
        }

        ~Shader()
        {
            if (!isDisposed)
                Dispose();
        }

        public unsafe bool Compile()
        {
            if (!IsCompiled)
            {
                GL.glShaderSource(Handle, src);
                GL.glCompileShader(Handle);

                int compileRes = 0;
                GL.glGetShaderiv(Handle, GL.GL_COMPILE_STATUS, &compileRes);

                if (compileRes == GL.GL_FALSE)
                    throw new Exception($"Error when compiling shader with source: \n" +
                        $"{src} \n" +
                        $"InfoLog: \n" +
                        $"{GL.glGetShaderInfoLog(Handle,1024)}");

                IsCompiled = true;
            }
            return true;
        }

        public void Dispose()
        {
            if (isDisposed)
            {
                src = null;
                if (Glue.IsAlive)
                    GL.glDeleteShader(Handle);
                isDisposed = true;
            }
        }
    }
}

using GlueNet.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SDF_Text
{
    public sealed class Texture2D
    {
        public uint Handle => handle;
        uint handle;

        public Texture2D()
        {
            handle = GL.glGenTextures(1)[0];
        }

        public unsafe void SetTextureData(int level,int internalFormat, int width, int height,int border,uint format, uint type, byte[] pixelData)
        {
            fixed (byte* ptr = &pixelData[0])
                GL.glTexImage2D(GL.GL_TEXTURE_2D, level, internalFormat, width, height, border, format, type,(IntPtr)ptr);

            GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_S, GL.GL_CLAMP_TO_EDGE);
            GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_T, GL.GL_CLAMP_TO_EDGE);

            GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, GL.GL_LINEAR);
            GL.glTexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, GL.GL_LINEAR);
        }

        public void Bind(int textureUnit)
        {
            GL.glActiveTexture((uint)(GL.GL_TEXTURE0 + textureUnit));
            GL.glBindTexture(GL.GL_TEXTURE_2D, handle);
        }

        ~Texture2D()
        {
            if (GlueNet.Glue.IsAlive)
                GL.glDeleteTextures(handle);
        }
    }
}

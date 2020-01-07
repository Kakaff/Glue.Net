using GlueNet;
using GlueNet.Math;
using GlueNet.OpenGL;
using System;
using System.Runtime.InteropServices;
using static GlueNet.OpenGL.GL;

namespace Hello_Mesh
{
    class Mesh
    {
        ArrayBuffer ebo, vbo;
        int indicies;
        VertexArrayObject vao;

        public Mesh()
        {
            
            ebo = new ArrayBuffer(BufferTarget.ElementBuffer);
            vbo = new ArrayBuffer(BufferTarget.VertexBuffer);

            vao = new VertexArrayObject();

            vao.Bind();
            vbo.Bind();
            vao.SetAttrib(0, 3, GL.GL_FLOAT, false, 3 * sizeof(float), IntPtr.Zero);
            vao.EnableAttrib(0);
            ebo.Bind();
            vao.Unbind();
        }

        ~Mesh()
        {
            if (Glue.IsAlive)
            {
                ebo.Destroy();
                vbo.Destroy();
            }
        }

        public unsafe void SetMeshData(Vector3[] vertices, ushort[] indicies)
        {
            uint err = 0;
            //Allocate some unmanaged memory for the vertex data.
            float* vertData = (float*)Marshal.AllocHGlobal(vertices.Length * 3 * sizeof(float));

            //Copy over the vertices to the unmanaged memory
            for (int i = 0; i < vertices.Length; i++)
            {
                vertData[i * 3] = vertices[i].x;
                vertData[i * 3 + 1] = vertices[i].y;
                vertData[i * 3 + 2] = vertices[i].z;
            }

            //Bind the vertex buffer
            vbo.Bind();
            //Upload the vertex data to the vertex buffer.
            glBufferData(GL_ARRAY_BUFFER, vertices.Length * 3 * sizeof(float), (IntPtr)vertData, GL_STATIC_DRAW);
            //Free the unmanaged memory.
            Marshal.FreeHGlobal((IntPtr)vertData);

            if (!glGetError(out err))
                Console.WriteLine($"ERROR Uploading VertexData {err}");

            //Bind the element buffer
            ebo.Bind();
            fixed (ushort* ptr = &indicies[0])
                glBufferData(GL_ELEMENT_ARRAY_BUFFER, indicies.Length * 2, (IntPtr)ptr, GL_STATIC_DRAW);

            if (!glGetError(out err))
                Console.WriteLine($"ERROR Uploading IndicieData {err}");

            this.indicies = indicies.Length;
        }

        public void Draw()
        {
            //Bind the Vertex Array Object
            vao.Bind();
            //Draw the mesh.
            GL.glDrawElements(GL.GL_TRIANGLES, indicies, GL.GL_UNSIGNED_SHORT, IntPtr.Zero);
            
        }

        /// <summary>
        /// Creates a indexed Triangle mesh scaled to the desired scale.
        /// </summary>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static Mesh CreateTriangle(in Vector3 scale)
        {
            Mesh m = new Mesh();
            Vector3[] verts = new Vector3[] { new Vector3(-0.5f, -0.5f, 0f) * scale, new Vector3(0f, 0.5f, 0f) * scale, new Vector3(0.5f, -0.5f, 0f) * scale };
            ushort[] ind = new ushort[] { 0, 1, 2 };

            m.SetMeshData(verts, ind);

            return m;
        }

        /// <summary>
        /// Creates a Indexed Cube mesh scaled to the desired scale.
        /// </summary>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static Mesh CreateCube(in Vector3 scale)
        {
            Mesh m = new Mesh();

            //Vertex positions for the cube. (the 8 corners of the cube)
            Vector3 nXnYnZ = new Vector3(-0.5f) * scale;
            Vector3 nXpYnZ = new Vector3(-0.5f, 0.5f, -0.5f) * scale;
            Vector3 pXpYnZ = new Vector3(0.5f, 0.5f, -0.5f) * scale;
            Vector3 pXnYnZ = new Vector3(0.5f, -0.5f, -0.5f) * scale;

            Vector3 nXnYpZ = new Vector3(-0.5f,-0.5f,0.5f) * scale;
            Vector3 nXpYpZ = new Vector3(-0.5f, 0.5f, 0.5f) * scale;
            Vector3 pXpYpZ = new Vector3(0.5f) * scale;
            Vector3 pXnYpZ = new Vector3(0.5f, -0.5f, 0.5f) * scale;

            Vector3[] v = new Vector3[] { nXnYnZ, nXpYnZ, pXpYnZ, pXnYnZ,
                                          pXnYpZ,pXpYpZ,nXpYpZ,nXnYpZ,
                                          pXnYnZ,pXpYnZ,pXpYpZ,pXnYpZ,
                                          nXnYpZ,nXpYpZ,nXpYnZ,nXnYnZ,
                                          nXpYnZ,nXpYpZ,pXpYpZ,pXpYnZ,
                                          nXnYpZ,nXnYnZ,pXnYnZ,pXnYpZ};

            //Element/Indicie data (Which vertices to use for each triangle)
            ushort[] i = new ushort[] { 0, 1, 2, 2, 3, 0 ,
                                        4,5,6,6,7,4,
                                        8,9,10,10,11,8,
                                        12,13,14,14,15,12,
                                        16,17,18,18,19,16,
                                        20,21,22,22,23,20
                                        };

            m.SetMeshData(v, i); //Upload the data to the mesh.

            return m;
        }
    }
}

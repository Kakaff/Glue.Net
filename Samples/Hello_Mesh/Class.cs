using GlueNet;
using GlueNet.OpenGL;
using GlueNet.GLFW;
using System.Threading;
using GlueNet.Math;
using System;

namespace Hello_Triangle
{
    class Class
    {
        public static void Main(string[] args)
        {
            Glue.Init(1280, 720, "Hello Triangle", out GLFW_Window window);
            
            window.SetAttrib(Glfw.RESIZABLE, Glfw.FALSE);
            
            Mesh m = Mesh.CreateCube(new Vector3(1));

            


            Shader vertShader = new Shader(Shader.ShaderStage.Vertex,
                                "#version 330 core",
                                "layout (location = 0) in vec3 vertPos;",
                                "uniform mat4 transform;",
                                "uniform mat4 projection;",
                                "",
                                "void main()",
                                "{",
                                "gl_Position = projection * (vec4(vertPos,1.0) * transform);",
                                "}");

            Shader fragmentShader = new Shader(Shader.ShaderStage.Fragment,
                                    "#version 330 core",
                                    "out vec4 fragColor;",
                                    "",
                                    "void main()",
                                    "{",
                                    "fragColor = vec4(1);",
                                    "}");

            vertShader.Compile();
            fragmentShader.Compile();

            ShaderProgram sp = new ShaderProgram(vertShader,fragmentShader);

            sp.Link();

            sp.UseProgram();
            int transLoc = sp.GetUniformLocation("transform");
            int projLoc = sp.GetUniformLocation("projection");
            
            GL.glEnable(GL.GL_CULL_FACE);
            GL.glFrontFace(GL.GL_CW);
            GL.glCullFace(GL.GL_BACK);
            
            Glfw.SwapInterval(1);
            float t = 0;
            GL.glUniformMatrix4fv(projLoc, true, Matrix4x4.CreatePerspectiveProjection((float)(95d * Maths.DegreesToRadians), (float)(1280d / 720d), 0.001f, 1000f));

            while (!window.ShouldClose())
            {
                Glfw.PollEvents();
                window.SwapBuffers();
                GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
                GL.glUniformMatrix4fv(transLoc, true,
                    Matrix4x4.CreateScaleMatrix(new Vector3(1,1,1)) *
                    Matrix4x4.CreateRotationMatrix(
                        Quaternion.CreateFromAxisAngle(Vector3.Up, (float)(Maths.WrapToRange(-180f, 180f, 360f * t) * Maths.DegreesToRadians))
                        ) *
                    Matrix4x4.CreateTranslationMatrix(new Vector3(0,0,5))
                    );
                
                m.Draw();
                Thread.Sleep(13);
                t += 0.013f;
                t %= 1f;
            }

            Glue.Terminate();
        }
    }
}

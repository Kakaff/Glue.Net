using GlueNet;
using GlueNet.OpenGL;
using GlueNet.GLFW;
using System.Threading;
using GlueNet.Math;
using System;

namespace Hello_Mesh
{

    /* Showcases how to intialize Glfw/OpenGL with Glue. 
     * And how to get a spinning 3D cube rendering on screen.
     * Requires glfw3.dll and Glue.Net-Native.dll
     */

    class Program
    {
        public static void Main(string[] args)
        {
            //Initialize the Glfw library
            Glue.InitGlfw();
            //Set the number of samples per pixel to 4
            Glfw.WindowHint(Glfw.SAMPLES, 4);
            //Create a new window
            GLFW_Window window = new GLFW_Window(1280, 720, "Hello Mesh", null, null);
            //Set the window as the current context
            window.MakeContextCurrent();
            //Load the available OpenGL functions for the window context.
            Glue.InitGL(window);
            
            //Disables resizing of the window.
            window.SetAttrib(Glfw.RESIZABLE, Glfw.FALSE);

            //Create a (1,1,1) cube mesh.
            Mesh m = Mesh.CreateCube(new Vector3(1));

            //Create a simple vertex shader
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

            //Then create a simple fragment shader.
            Shader fragmentShader = new Shader(Shader.ShaderStage.Fragment,
                                    "#version 330 core",
                                    "out vec4 fragColor;",
                                    "",
                                    "void main()",
                                    "{",
                                    "fragColor = vec4(1);",
                                    "}");

            //Compile the shaders.
            vertShader.Compile();
            fragmentShader.Compile();

            //Create a shaderprogram that uses the shaders.
            ShaderProgram sp = new ShaderProgram(vertShader,fragmentShader);

            //Link the program.
            sp.Link();

            //"Bind" the shaderprogram
            sp.UseProgram();

            //Get the uniform locations for the transformation and projection matricies.
            int transLoc = sp.GetUniformLocation("transform");
            int projLoc = sp.GetUniformLocation("projection");
            
            //Enable face culling
            GL.glEnable(GL.GL_CULL_FACE);
            //Specify the winding order for the front face.
            GL.glFrontFace(GL.GL_CW);
            //Set the back face to be culled.
            GL.glCullFace(GL.GL_BACK);

            //Enable Depth test
            GL.glEnable(GL.GL_DEPTH_TEST);
            //Set the depth func to GL_LESS
            GL.glDepthFunc(GL.GL_LESS);
            
            //Enable V-Sync.
            Glfw.SwapInterval(1);
            float t = 0;
            //Set the projection matrix uniform to the provided Perspective projection.
            GL.glUniformMatrix4fv(projLoc, true, Matrix4x4.CreatePerspectiveProjection((float)(95d * Maths.DegreesToRadians), (float)(1280d / 720d), 0.001f, 1000f));


            while (!window.ShouldClose())
            {
                Glfw.PollEvents();
                window.SwapBuffers();

                GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT); //Clear the color and depth buffers.
                GL.glUniformMatrix4fv(transLoc, true,
                    Matrix4x4.CreateScaleMatrix(new Vector3(1,1,1)) *
                    Matrix4x4.CreateRotationMatrix(
                        Quaternion.CreateFromAxisAngle(Vector3.Forward, (float)(Maths.WrapToRange(-180f, 180f, 360f * t) * Maths.DegreesToRadians)) //The rotation of our cube.
                        ) *
                    Matrix4x4.CreateTranslationMatrix(new Vector3(0,0,5))
                    ); //Set the Transform uniform matrix.
                
                m.Draw();
                Thread.Sleep(13); // ~75fps. But due to how Thread.Sleep works we will more likely see 50-60fps.
                t += 0.013f;
                t %= 1f;
            }

            Glue.Terminate(); //Terminate Glue, which in turn terminates GLFW.
        }
    }
}

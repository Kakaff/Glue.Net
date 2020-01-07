using GlueNet;
using GlueNet.Freetype;
using GlueNet.GLFW;
using GlueNet.Math;
using GlueNet.OpenGL;
using System.IO;
using System.Reflection;
using System.Threading;

/* 
 * A program demonstrating getting text input and rendering text with Glue.Net using Glfw, OpenGL and Freetype 
 * The Characters and Rendering is done in pixel coordinates.
 */ 

namespace Hello_SDF_Text
{
    public static class Program
    {
        static Texture2D tex;
        static GLFW_Window window;

        public static void Main(string[] args)
        {
            //Init the Freetype library
            FreeType.Init(out FT_Library lib,out _);
            //Create a new FT_Face from a .ttf font file.
            FT_Face face = FT_Face.Create(lib, $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Fonts\Roboto-Regular.ttf", 0);
            string s = "";

            //Make an array of the chars we want to use.
            for (int i = 0; i < 256; i++)
                s += (char)i;

            //Create a new Textfont that we can use to render text with. Desired size is (auto, 48px)
            TextFont tf = new TextFont_Bitmap(face,  new Vector2i(0,48), s.ToCharArray());

            //Initialize Glue, Glfw, Create a window/context set it as current and load the available OpenGL functions.
            Glue.Init(1280, 720, "Hello Text", out window);

            //Create a new TextMesh.
            TextMesh m = new TextMesh();

            //Use the TextFont to create a texture atlas of the chars in the TextFont.
            tex = tf.CreateTexture2D();


            Shader vertShader = new Shader(Shader.ShaderStage.Vertex,
                                "#version 330 core",
                                "layout (location = 0) in vec2 vertPos;",
                                "layout (location = 1) in vec2 uv;",
                                "uniform mat4 projMatr;",
                                "uniform mat4 transMatr;",
                                "out vec2 texCoord;",
                                "void main()",
                                "{",
                                "gl_Position = projMatr * (vec4(vertPos,0,1.0) * transMatr);",
                                "texCoord = uv;",
                                "}");

            Shader fragmentShader = new Shader(Shader.ShaderStage.Fragment,
                                    "#version 330 core",
                                    "in vec2 texCoord;",
                                    "out vec4 fragColor;",
                                    "uniform sampler2D fontBmp;",
                                    "void main()",
                                    "{",
                                    "fragColor = vec4(1,1,1,texture(fontBmp,texCoord).r);",
                                    "}");

            vertShader.Compile();
            fragmentShader.Compile();

            ShaderProgram sp = new ShaderProgram(vertShader, fragmentShader);

            sp.Link();

            sp.UseProgram();

            GL.glEnable(GL.GL_CULL_FACE);
            GL.glEnable(GL.GL_BLEND);
            GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);
            GL.glFrontFace(GL.GL_CW);
            GL.glCullFace(GL.GL_BACK);

            Glfw.SwapInterval(1);

            int fontBmpLoc = sp.GetUniformLocation("fontBmp");
            int projLoc = sp.GetUniformLocation("projMatr");
            int transLoc = sp.GetUniformLocation("transMatr");

            
            tex.Bind(0);
            GL.glUniform1i(fontBmpLoc, 0);

            Matrix4x4 ortho = Matrix4x4.CreateOrthographicProjection(0.0f, 1280f, 0.0f, 720f, -100f, 100f);
            Matrix4x4 transText = Matrix4x4.CreateTranslationMatrix(new Vector3(0f, 720f,0f));
            Matrix4x4 transBitmap = Matrix4x4.CreateTranslationMatrix(new Vector3(640f, 720f, 0f));

            GL.glUniformMatrix4fv(projLoc, true, ortho);
            GL.glUniformMatrix4fv(transLoc, true, transText);
            CharacterString cs = new CharacterString(tf, "");

            Mesh quad = Mesh.CreateScreenQuad(new Vector2i(640, 720));

            while (!window.ShouldClose())
            {
                GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
                GL.glUniformMatrix4fv(transLoc, true, transText);
                m.Draw();
                GL.glUniformMatrix4fv(transLoc, true, transBitmap);
                quad.Draw();
                Thread.Sleep(16);
                cs.ReplaceCharacters(window.Input);
                m.SetText(cs, maxLineLength: 640);

                window.SwapBuffers();
                Glfw.PollEvents();
            }

            Glue.Terminate();
        }
    }
}

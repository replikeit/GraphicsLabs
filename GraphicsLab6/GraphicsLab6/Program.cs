using System;
using System.Threading;
using Tao.FreeGlut;
using OpenGL;

namespace OpenGLTutorial5
{
    class Program
    {
        private static int width = 1280, height = 720;
        private static ShaderProgram program;
        private static VBO<Vector3> cube;
        private static VBO<Vector3> cubeColor;
        private static VBO<uint> cubeQuads;
        private static System.Diagnostics.Stopwatch watch;
        private static float angle;
        private static int posNegOneTranslation = 1, posNegOneScale = 1;
        private static float currentScale = 1, currentTranslation = 0;

        static void Main(string[] args)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Glut.glutInitWindowSize(width, height);
            Glut.glutCreateWindow("Graphics Lab6");

            Glut.glutIdleFunc(OnRenderFrame);
            Glut.glutDisplayFunc(OnDisplay);
            Glut.glutCloseFunc(OnClose);

            Gl.Enable(EnableCap.DepthTest);

            program = new ShaderProgram(VertexShader, FragmentShader);

            program.Use();
            program["projection_matrix"].SetValue(Matrix4.CreatePerspectiveFieldOfView(0.45f, (float)width / height, 0.1f, 1000f));
            program["view_matrix"].SetValue(Matrix4.LookAt(new Vector3(0, 0, 10), Vector3.Zero, new Vector3(0, 1, 0)));


            cube = new VBO<Vector3>(new Vector3[] {
                new Vector3(1, 1, -0.5f), new Vector3(-1, 1, -0.5f), new Vector3(-1, 1, 0.5f), new Vector3(1, 1, 0.5f),

                new Vector3(-0.5f, 1, 0.5f), new Vector3(-1, 1, 0.5f), new Vector3(-1, -1, 0.5f), new Vector3(-0.5f, -1, 0.5f),
                new Vector3(-0.5f, 1, 0.5f), new Vector3(0.5f, 1, 0.5f),  new Vector3(0.5f, 0.7f, 0.5f), new Vector3(-0.5f, 0.7f, 0.5f),
                new Vector3(0.5f, 1, 0.5f), new Vector3(1, 1, 0.5f), new Vector3(1, -1, 0.5f), new Vector3(0.5f, -1, 0.5f),
                new Vector3(-0.5f, 1, -0.5f), new Vector3(-1, 1, -0.5f), new Vector3(-1, -1, -0.5f), new Vector3(-0.5f, -1, -0.5f),
                new Vector3(-0.5f, 1, -0.5f), new Vector3(0.5f, 1, -0.5f),  new Vector3(0.5f, 0.7f, -0.5f), new Vector3(-0.5f, 0.7f, -0.5f),
                new Vector3(0.5f, 1, -0.5f), new Vector3(1, 1, -0.5f), new Vector3(1, -1, -0.5f), new Vector3(0.5f, -1, -0.5f),

                new Vector3(-1, 1, -0.5f), new Vector3(-1, 1, 0.5f), new Vector3(-1, -1, 0.5f), new Vector3(-1, -1, -0.5f),
                new Vector3(-0.5f, 1, 0.5f), new Vector3(-0.5f, 1, -0.5f), new Vector3(-0.5f, -1, -0.5f), new Vector3(-0.5f, -1, 0.5f),

                new Vector3(1, 1, -0.5f), new Vector3(1, 1, 0.5f), new Vector3(1, -1, 0.5f), new Vector3(1, -1, -0.5f),

                new Vector3(0.5f, 1, 0.5f), new Vector3(0.5f, 1, -0.5f), new Vector3(0.5f, -1, -0.5f), new Vector3(0.5f, -1, 0.5f),

                new Vector3(-0.5f, 0.7f, 0.5f), new Vector3(-0.5f, 0.7f, -0.5f), new Vector3(0.5f, 0.7f, -0.5f), new Vector3(0.5f, 0.7f, 0.5f),

                new Vector3(1, -1, 0.5f), new Vector3(0.5f, -1, 0.5f), new Vector3(0.5f, -1, -0.5f), new Vector3(1, -1, -0.5f),

                new Vector3(-1, -1, 0.5f), new Vector3(-0.5f, -1, 0.5f), new Vector3(-0.5f, -1, -0.5f), new Vector3(-1, -1, -0.5f),
                });
            cubeColor = new VBO<Vector3>(new Vector3[] {
                new Vector3(0.5f, 1, 1), new Vector3(0, 1, 0), new Vector3(0.5f, 1, 1), new Vector3(0.5f, 1, 0), 
                new Vector3(1, 0.5f, 1), new Vector3(1, 0.5f, 0), new Vector3(1, 0.5f, 0), new Vector3(1, 0.5f, 0),
                new Vector3(1, 0.5f, 0.5f), new Vector3(1, 0, 0), new Vector3(1, 0, 0), new Vector3(1, 0, 1), 
                new Vector3(1, 1, 0), new Vector3(1, 1, 0), new Vector3(1, 1, 0), new Vector3(1, 1, 0),
                new Vector3(0, 0.5f, 1), new Vector3(0, 0, 1), new Vector3(0, 0.5f, 1), new Vector3(0, 0.5f, 1),
                new Vector3(1, 0, 1), new Vector3(1, 0, 1), new Vector3(0, 0.5f, 1), new Vector3(1, 0, 0),
                new Vector3(0, 1, 1), new Vector3(0, 1, 1), new Vector3(1, 1, 0), new Vector3(1, 1, 1),
                new Vector3(1, 0.5f, 1), new Vector3(1, 0.5f, 1), new Vector3(0, 0.5f, 0), new Vector3(0.3f, 0.3f, 0),
                new Vector3(0, 1, 0), new Vector3(0, 1, 0), new Vector3(0, 1, 0), new Vector3(0.5f, 1, 0),
                new Vector3(0.3f, 1, 0.3f), new Vector3(0, 1, 1), new Vector3(1, 1, 1), new Vector3(0, 1, 1),
                new Vector3(1, 0.5f, 0.3f), new Vector3(1, 0.5f, 0.3f), new Vector3(1, 0.5f, 0), new Vector3(1, 0.5f, 0),
                new Vector3(0, 0.5f, 0.3f), new Vector3(0, 0.5f, 0.3f), new Vector3(0, 0.5f, 0), new Vector3(0, 0.5f, 0),
                new Vector3(0, 1, 0.5f), new Vector3(0, 1, 0.5f), new Vector3(0, 1, 0), new Vector3(0, 1, 0),
                new Vector3(0, 0.5f, 0), new Vector3(0.3f, 0.5f, 0), new Vector3(1, 0.3f, 0), new Vector3(0.3f, 0.5f, 0.3f),

            });
            cubeQuads = new VBO<uint>(new uint[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 ,28,
                29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56

            }, BufferTarget.ElementArrayBuffer);

            watch = System.Diagnostics.Stopwatch.StartNew();

            Glut.glutMainLoop();
        }

        private static void OnClose()
        {
            cube.Dispose();
            cubeColor.Dispose();
            cubeQuads.Dispose();
            program.DisposeChildren = true;
            program.Dispose();
        }

        private static void OnDisplay()
        {

        }

        private static void OnRenderFrame()
        {
            watch.Stop();
            float deltaTime = (float)watch.ElapsedTicks / System.Diagnostics.Stopwatch.Frequency;
            watch.Restart();

            angle += deltaTime;

            Gl.Viewport(0, 0, width, height);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Gl.UseProgram(program);
            
            program["model_matrix"].SetValue(Matrix4.CreateScaling(new Vector3(currentScale, currentScale, currentScale)) * Matrix4.CreateRotationY(angle / 2) * Matrix4.CreateRotationX(angle) * Matrix4.CreateTranslation(new Vector3( currentTranslation, 0, 0)));

            Gl.BindBufferToShaderAttribute(cube, program, "vertexPosition");
            Gl.BindBufferToShaderAttribute(cubeColor, program, "vertexColor");
            Gl.BindBuffer(cubeQuads);
            


            Gl.DrawElements(BeginMode.Quads, cubeQuads.Count, DrawElementsType.UnsignedInt, IntPtr.Zero);
            Glut.glutSwapBuffers();

            if (currentScale >= 1.5 || currentScale <= 0.5)
                posNegOneScale *= -1;

            if (currentScale >= 1.5 || currentScale <= -1.5)
                posNegOneTranslation *= -1;

            currentScale += 0.0002f * posNegOneScale;
            currentTranslation += 0.0004f * posNegOneTranslation;
            Console.WriteLine("===========Matrix===========");
            Console.WriteLine((Matrix4.CreateScaling(new Vector3(currentScale, currentScale, currentScale)) * Matrix4.CreateRotationY(angle / 2) * Matrix4.CreateRotationX(angle) * Matrix4.CreateTranslation(new Vector3(currentTranslation, 0, 0))).ToString());
            Console.WriteLine("======================");
        }

        public static string VertexShader = @"
            #version 130

            in vec3 vertexPosition;
            in vec3 vertexColor;

            out vec3 color;

            uniform mat4 projection_matrix;
            uniform mat4 view_matrix;
            uniform mat4 model_matrix;

            void main(void)
            {
                color = vertexColor;
                gl_Position = projection_matrix * view_matrix * model_matrix * vec4(vertexPosition, 1);
            }
            ";

        public static string FragmentShader = @"
            #version 130

            in vec3 color;

            out vec4 fragment;

            void main(void)
            {
                fragment = vec4(color, 1);
            }
            ";
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Platform.Windows;

namespace CharacterStudio
{
    public partial class Form1 : Form
    {
        bool Loaded = false;

        private Shader shader;

        public Form1()
        {
            InitializeComponent();
        }

        private void SceneView_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.BlueViolet);
            GL.Enable(EnableCap.DepthTest);
        }

        private void SceneView_Resize(object sender, EventArgs e)
        {
            if (!Loaded)
                return;

            GL.Viewport(0, 0, SceneView.Width, SceneView.Height);

            SceneView.Invalidate();
        }

        private void SceneView_Paint(object sender, PaintEventArgs e)
        {
            if (!Loaded)
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SceneView.SwapBuffers();
        }
    }
}

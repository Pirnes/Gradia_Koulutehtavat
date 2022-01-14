using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Picture
{
    public partial class Form1 : Form
    {
        Point piste = new Point();
        Bitmap hessu = new Bitmap(Properties.Resources.Hessu);

        public Form1()
        {
            InitializeComponent();
            hessu.MakeTransparent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(-hessu.Width / 2, -hessu.Height / 2);
            e.Graphics.DrawImage(hessu, piste);
            DoubleBuffered = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            piste = e.Location;
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                piste = e.Location;
            Invalidate();
        }
    }
}

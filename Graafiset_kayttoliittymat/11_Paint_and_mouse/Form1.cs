using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Paint_and_mouse
{

    public partial class Form1 : Form
    {
        Point piste;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            //piirretään pää
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);
            //piirretään selkä
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, piste.X + 21, piste.Y + 131);
            //piirretään kädet
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60, piste.X + 70, piste.Y + 60);
            //piirretään jalat
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X - 30, piste.Y + 181);
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X + 70, piste.Y + 181);

            //DrawCordinates kutsu
            DrawCordinates(Graf);
        }

        private void DrawCordinates(Graphics Graf)
        {
            Graf.DrawString("(" + piste.X + "," + piste.Y + ")", new Font("Arial", 14, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Black), 450, 380);
        }

        //private void ButtonPiirraUudelleen_Click(object sender, EventArgs e)
        //{
        //    piste.X = int.Parse(TextBoxXkoordinaatti.Text.ToString());
        //    piste.Y = int.Parse(TextBoxYkoordinaatti.Text.ToString());
        //    Invalidate();
        //}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
       
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                piste.X--;
            }

            else if (e.KeyData == Keys.D)
            {
                piste.X++;
            }

            else if (e.KeyData == Keys.W)
            {
                piste.Y--;
            }

            else if (e.KeyData == Keys.S)
            {
                piste.Y++;
            }
        }
    }
}

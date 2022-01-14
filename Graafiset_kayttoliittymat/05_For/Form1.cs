using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _05_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void ButtonClick(object sender, EventArgs e)
        {
            float kierrokset;
            Button nappi = sender as Button;
            buttonStart.Tag = 1;

            kierrokset = float.Parse(textBoxNumerot.Text);

            
            for (int i =0; i < kierrokset +1 ; i++)
            {
                textBoxLaskuri.Text = i.ToString();
                Thread.Sleep(100);
                textBoxLaskuri.Refresh();
            }
        }

    }
}

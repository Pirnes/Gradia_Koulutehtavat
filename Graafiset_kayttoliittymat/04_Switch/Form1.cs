using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)

        {
            Button Nappi = sender as Button;
            buttonValinta1.Tag = 1;
            buttonValinta2.Tag = 2;
            buttonValinta3.Tag = 3;
            buttonValinta4.Tag = 4;
            buttonDefault.Tag = 5;
            string a = "Huom";

            switch (Nappi.Tag)
            {
                case 1:
                    MessageBox.Show(buttonValinta1.Text, a);
                    break;
                case 2:
                    MessageBox.Show(buttonValinta2.Text, a);
                    break;
                case 3:
                    MessageBox.Show(buttonValinta3.Text, a);
                    break;
                case 4:
                    MessageBox.Show(buttonValinta4.Text, a);
                    break;
                case 5:
                    MessageBox.Show(buttonDefault.Text, a);
                    break;
            }
        }
    }
}
 
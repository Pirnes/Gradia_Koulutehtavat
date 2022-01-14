using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_While
{
    public partial class Pääformi : Form
    {
        public Pääformi()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            bool onnistui = false;

            while (!onnistui)
            {

                if (MessageBox.Show("Valitse YES jatkaaksesi tai NO lopettaksesi silmukan", "Huom!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    onnistui = true;
                }
            }
        }
    }
}

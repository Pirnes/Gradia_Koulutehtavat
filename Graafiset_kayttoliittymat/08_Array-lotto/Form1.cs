using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Array_lotto
{
    public partial class Form1 : Form
    {
        int[] Lottonumerot = new int[9];
        int tarkistus = 0;
        Random Arvonta = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonArvonta_Click(object sender, EventArgs e)
        {
            Lottonumerot = Enumerable.Range(1, 40).OrderBy(x => Arvonta.Next()).Take(9).ToArray();

            Array.Sort(Lottonumerot);
            //string separator = ", ";
            string ekatseitseman = Lottonumerot[0].ToString()+ ", " + Lottonumerot[1].ToString()+ ", " + Lottonumerot[2].ToString() + ", " + Lottonumerot[3].ToString() + ", " + Lottonumerot[4].ToString() + ", " + Lottonumerot[5].ToString()+ ", " + Lottonumerot[6].ToString();
            string lisanumerot = Lottonumerot[7] + ", " + Lottonumerot[8];
            TextBoxLottoNumerot.Text = ekatseitseman;
            TextBoxLisanumerot.Text = lisanumerot;
            //TextBoxLottoNumerot.Text = string.Join(separator, Lottonumerot);


        }

        private void ButtonTarkista_Click(object sender, EventArgs e)
        {
            tarkistus = 0;
            if (TextBoxOma1.Text == Lottonumerot[0].ToString())
                tarkistus++;
            if (TextBoxOma2.Text == Lottonumerot[1].ToString())
                tarkistus++;
            if (TextBoxOma3.Text == Lottonumerot[2].ToString())
                tarkistus++;
            if (TextBoxOma4.Text == Lottonumerot[3].ToString())
                tarkistus++;
            if (TextBoxOma5.Text == Lottonumerot[4].ToString())
                tarkistus++;
            if (TextBoxOma6.Text == Lottonumerot[5].ToString())
                tarkistus++;
            if (TextBoxOma7.Text == Lottonumerot[6].ToString())
                tarkistus++;

            TextBoxOsumat.Text = tarkistus.ToString();
        }
    }
}

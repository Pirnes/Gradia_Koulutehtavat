using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Lasse Pirnes");
        }

        private void UusiTietueButton_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "0";
            textBoxElokuvanNimi.Text = "[Syötä elokuvan nimi]";
            textBoxJulkaisuvuosi.Text = DateTime.Now.Year.ToString();
            textBoxKesto.Text = "0";
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxElokuvanNimi_Enter_1(object sender, EventArgs e)
        {
            if (textBoxElokuvanNimi.Text.Equals("[Syötä elokuvan nimi]"))
            {
                textBoxElokuvanNimi.Text = String.Empty;
            }
        }

        private void textBoxJulkaisuvuosi_Enter_1(object sender, EventArgs e)
        {
            if (textBoxJulkaisuvuosi.Text.Equals(DateTime.Now.Year.ToString()))
            textBoxJulkaisuvuosi.Text = String.Empty;
        }

        private void textBoxKesto_Enter_1(object sender, EventArgs e)
        {
            if (textBoxKesto.Text.Equals("0"))
            {
                textBoxKesto.Text = String.Empty;
            }
        }


        private void textBoxElokuvanNimi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxElokuvanNimi.Text))
            {
                textBoxElokuvanNimi.Text = "[Syötä elokuvan nimi]";
            }
        }

        private void textBoxJulkaisuvuosi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxJulkaisuvuosi.Text))
            {
                textBoxJulkaisuvuosi.Text = DateTime.Now.Year.ToString();
            }
        }

        private void textBoxKesto_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxKesto.Text))
            {
                textBoxKesto.Text = "0";
            }
        }

        private void TallennaButton_Click(object sender, EventArgs e)
        {
            string virheilmoitus = "";

            if (String.IsNullOrWhiteSpace(textBoxElokuvanNimi.Text) || textBoxElokuvanNimi.Text.Equals("[Syötä elokuvan nimi]"))
            {
                virheilmoitus += "Et ole syöttänyt mitään Nimi- kenttään!\n";
            }

            if (String.IsNullOrWhiteSpace(textBoxJulkaisuvuosi.Text))
            {
                virheilmoitus += "Et ole syöttänyt mitään Julkaisuvuosi- kenttän!\n";
            }

            if (!int.TryParse(textBoxJulkaisuvuosi.Text,out _) && !String.IsNullOrWhiteSpace(textBoxJulkaisuvuosi.Text))
            {
                virheilmoitus += "Julkaisuvuosi täytyy syöttää numeroita käyttäen!\n";
            }

            if (String.IsNullOrWhiteSpace(textBoxKesto.Text) || textBoxKesto.Text.Equals("0"))
            {
                virheilmoitus += "Et ole syöttänyt mitään Kesto - Kenttään!\n";
            }

            if (!int.TryParse(textBoxKesto.Text, out _) && !String.IsNullOrWhiteSpace(textBoxKesto.Text))
            {
                virheilmoitus += "Elokuvan kesto täytyy syöttää numeroita käyttäen";
            }

            if (virheilmoitus.Length > 0)
            {
                MessageBox.Show(virheilmoitus, "Virhe, täytä alla luetellut kentät!");
            }
        }
    }
}

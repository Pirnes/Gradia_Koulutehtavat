using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Array
{
    public partial class Form1 : Form
    {
        public int[] taulukko = new int[0];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLuoTaulukko_Click(object sender, EventArgs e)
        {
            try
            {
                int koko = int.Parse(TextBoxTaulukonKoko.Text);
                if (koko < 1)
                {
                    MessageBox.Show("Taulukon koko täytyy olla vähintään 1!");
                }
                taulukko = new int[koko];
            }

            catch (FormatException)
            {
                MessageBox.Show("Syötä kentät numeroina!");
            }
        }

        private void ButtonTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(TextBoxTallennettavaNumero.Text);
                taulukko[int.Parse(TextBoxTallennuspaikanIndexi.Text)] = numero;
            }

            catch (FormatException)
            {
                MessageBox.Show("Syötä kentät numeroina!");
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indexi on taulukon ulkopuolella");
            }
        }

        private void ButtonHae_Click(object sender, EventArgs e)
        {
            try
            {
                int indexi = int.Parse(TextBoxHakuIndexi.Text);
                TextBoxHaunTulos.Text = taulukko[indexi].ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Syötä kentät numeroina!");
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indexi on taulukon ulkopuolella");
            }
        }
    }
}

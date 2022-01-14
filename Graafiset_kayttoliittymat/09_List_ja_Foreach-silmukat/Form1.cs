using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_List_ja_Foreach_silmukat
{
    public partial class Form1 : Form
    {
        List<string> lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLuoLista_Click(object sender, EventArgs e)
        {
            lista = new List<string>();
        }

        private void ButtonLisaaListaan_Click(object sender, EventArgs e)
        {
            lista.Add(TextBoxLisaaListaan.Text.ToString());
            TextBoxLisaaListaan.Text = "";
        }

        private void ButtonHaeListanSisalto_Click(object sender, EventArgs e)
        {
            ComboBoxLista.Items.Clear();
            foreach (string a in lista)
            {
                ComboBoxLista.Items.Add(a);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Dictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> hakemisto;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDictionary_Click(object sender, EventArgs e)
        {
            hakemisto = new Dictionary<string, string>();
        }

        private void ButtonLisaaElementti_Click(object sender, EventArgs e)
        {
            hakemisto.Add(TextBoxKeyLisaa.Text.ToString(), TextBoxValueLisaa.Text.ToString());
        }

        private void ButtonHaeElementti_Click(object sender, EventArgs e)
        {
            TextBoxValueHae.Text = hakemisto[TextBoxKeyHae.Text.ToString()];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        KaupanLogiikka registerHandler;
        List<AutonMerkki> merkit;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            InitializeComponent();
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            registerHandler = new KaupanLogiikka();
            merkit = new List<AutonMerkki>(registerHandler.getAllAutoMakers());

            for (int i = 0; i < merkit.Count; i++)
            {
                MerkkiComboBox.Items.Add(merkit[i].Merkki);
            }
        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registerHandler.TestDatabaseConnection())
            {
                MessageBox.Show("Yhteys toimii!");
            }

            else
            {
                MessageBox.Show("Yhteys ei toimi!");
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

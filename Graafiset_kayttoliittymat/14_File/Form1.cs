using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _14_File
{

public partial class Form1 : Form
    {
        private String EditorFileName = "Untitled";

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";
            richTextBox1.Clear();
            SetFormTitleText();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //luodaan standardi avausdialogiobjekti ja alustetaan se
            OpenFileDialog avaatiedosto = new OpenFileDialog();
            avaatiedosto.Title = "Open";
            avaatiedosto.ShowReadOnly = true;
            avaatiedosto.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            //avataan windowsin standardi avausdialogi
            if (avaatiedosto.ShowDialog() == DialogResult.OK)
            {
                //talletetaan tiedoston nimi ja polku lukemista varten 
                EditorFileName = avaatiedosto.FileName;
                
                //luetaan tiedoston sisältö tuodaan se näytölle
                ReadFile();
                SetFormTitleText();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditorFileName == "Untitled")
            {
                SaveAsToolStripMenuItem_Click(sender, e);
            }

            else
            {
                SaveFile();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //luodaan standardi talletusdialogiobjekti ja alustetaan se
            SaveFileDialog tallennetaannimella = new SaveFileDialog();
            tallennetaannimella.Filter = "Text documents (*.txt)|*.txt|All files|*.*";
            
            //avataan windowsin standardi talletusdialogi
            if (tallennetaannimella.ShowDialog() == DialogResult.OK)
            {
                //talletetaan tiedoston nimi ja polku tallennusta varten
                EditorFileName = tallennetaannimella.FileName;
                SaveFile();
                SetFormTitleText();
            }
        }

        //Tiedoston nimi Formiin
        private void SetFormTitleText()
        {
            FileInfo fileinfo = new FileInfo(EditorFileName);
            Text = fileinfo.Name + "- Editor";
        }

        private void ReadFile()
        {
            try
            {
                //luodaan StreamReader objekti ja luetaan tiedosto
                using (StreamReader reader = new StreamReader(EditorFileName))
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " open file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFile()
        {
            try
            {
                //luodaan StreamWriter objekti ja kirjoitetaan teksti tiedostoon
                using (StreamWriter writer = new StreamWriter(EditorFileName))
                {
                    //kirjoitus
                    writer.Write(richTextBox1.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, " Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

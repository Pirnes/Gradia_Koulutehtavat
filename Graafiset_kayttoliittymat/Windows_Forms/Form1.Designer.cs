
namespace Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxElokuvanTiedot = new System.Windows.Forms.GroupBox();
            this.Seuraavabutton = new System.Windows.Forms.Button();
            this.Edellinenbutton = new System.Windows.Forms.Button();
            this.textBoxKesto = new System.Windows.Forms.TextBox();
            this.textBoxJulkaisuvuosi = new System.Windows.Forms.TextBox();
            this.textBoxElokuvanNimi = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.KestoTextLabel = new System.Windows.Forms.Label();
            this.JulkaisuvuosiTextLabel = new System.Windows.Forms.Label();
            this.ElokuvanNimiTextLabel = new System.Windows.Forms.Label();
            this.IDtextlabel = new System.Windows.Forms.Label();
            this.groupBoxToiminnallisuus = new System.Windows.Forms.GroupBox();
            this.PoistaButton = new System.Windows.Forms.Button();
            this.TallennaButton = new System.Windows.Forms.Button();
            this.UusiTietueButton = new System.Windows.Forms.Button();
            this.groupBoxArvio = new System.Windows.Forms.GroupBox();
            this.Arvosanalabel = new System.Windows.Forms.Label();
            this.Desimaalipilkkulabel = new System.Windows.Forms.Label();
            this.numericUpDownDesimaalit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKymmenet = new System.Windows.Forms.NumericUpDown();
            this.textBoxArvio = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxElokuvanTiedot.SuspendLayout();
            this.groupBoxToiminnallisuus.SuspendLayout();
            this.groupBoxArvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesimaalit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKymmenet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // groupBoxElokuvanTiedot
            // 
            this.groupBoxElokuvanTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxElokuvanTiedot.Controls.Add(this.Seuraavabutton);
            this.groupBoxElokuvanTiedot.Controls.Add(this.Edellinenbutton);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxKesto);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxJulkaisuvuosi);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxElokuvanNimi);
            this.groupBoxElokuvanTiedot.Controls.Add(this.textBoxID);
            this.groupBoxElokuvanTiedot.Controls.Add(this.KestoTextLabel);
            this.groupBoxElokuvanTiedot.Controls.Add(this.JulkaisuvuosiTextLabel);
            this.groupBoxElokuvanTiedot.Controls.Add(this.ElokuvanNimiTextLabel);
            this.groupBoxElokuvanTiedot.Controls.Add(this.IDtextlabel);
            this.groupBoxElokuvanTiedot.Location = new System.Drawing.Point(13, 28);
            this.groupBoxElokuvanTiedot.Name = "groupBoxElokuvanTiedot";
            this.groupBoxElokuvanTiedot.Size = new System.Drawing.Size(378, 225);
            this.groupBoxElokuvanTiedot.TabIndex = 1;
            this.groupBoxElokuvanTiedot.TabStop = false;
            this.groupBoxElokuvanTiedot.Text = "Elokuvan tiedot";
            // 
            // Seuraavabutton
            // 
            this.Seuraavabutton.Location = new System.Drawing.Point(182, 160);
            this.Seuraavabutton.Name = "Seuraavabutton";
            this.Seuraavabutton.Size = new System.Drawing.Size(97, 46);
            this.Seuraavabutton.TabIndex = 9;
            this.Seuraavabutton.Text = "Seuraava";
            this.Seuraavabutton.UseVisualStyleBackColor = true;
            // 
            // Edellinenbutton
            // 
            this.Edellinenbutton.Location = new System.Drawing.Point(79, 160);
            this.Edellinenbutton.Name = "Edellinenbutton";
            this.Edellinenbutton.Size = new System.Drawing.Size(97, 46);
            this.Edellinenbutton.TabIndex = 8;
            this.Edellinenbutton.Text = "Edellinen";
            this.Edellinenbutton.UseVisualStyleBackColor = true;
            // 
            // textBoxKesto
            // 
            this.textBoxKesto.Location = new System.Drawing.Point(103, 128);
            this.textBoxKesto.Name = "textBoxKesto";
            this.textBoxKesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxKesto.TabIndex = 7;
            this.textBoxKesto.Enter += new System.EventHandler(this.textBoxKesto_Enter_1);
            this.textBoxKesto.Leave += new System.EventHandler(this.textBoxKesto_Leave);
            // 
            // textBoxJulkaisuvuosi
            // 
            this.textBoxJulkaisuvuosi.Location = new System.Drawing.Point(103, 92);
            this.textBoxJulkaisuvuosi.Name = "textBoxJulkaisuvuosi";
            this.textBoxJulkaisuvuosi.Size = new System.Drawing.Size(100, 20);
            this.textBoxJulkaisuvuosi.TabIndex = 6;
            this.textBoxJulkaisuvuosi.Enter += new System.EventHandler(this.textBoxJulkaisuvuosi_Enter_1);
            this.textBoxJulkaisuvuosi.Leave += new System.EventHandler(this.textBoxJulkaisuvuosi_Leave);
            // 
            // textBoxElokuvanNimi
            // 
            this.textBoxElokuvanNimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxElokuvanNimi.Location = new System.Drawing.Point(103, 53);
            this.textBoxElokuvanNimi.Name = "textBoxElokuvanNimi";
            this.textBoxElokuvanNimi.Size = new System.Drawing.Size(162, 20);
            this.textBoxElokuvanNimi.TabIndex = 5;
            this.textBoxElokuvanNimi.Enter += new System.EventHandler(this.textBoxElokuvanNimi_Enter_1);
            this.textBoxElokuvanNimi.Leave += new System.EventHandler(this.textBoxElokuvanNimi_Leave);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(103, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // KestoTextLabel
            // 
            this.KestoTextLabel.AutoSize = true;
            this.KestoTextLabel.Location = new System.Drawing.Point(6, 135);
            this.KestoTextLabel.Name = "KestoTextLabel";
            this.KestoTextLabel.Size = new System.Drawing.Size(62, 13);
            this.KestoTextLabel.TabIndex = 3;
            this.KestoTextLabel.Text = "Kesto (min):";
            // 
            // JulkaisuvuosiTextLabel
            // 
            this.JulkaisuvuosiTextLabel.AutoSize = true;
            this.JulkaisuvuosiTextLabel.Location = new System.Drawing.Point(7, 99);
            this.JulkaisuvuosiTextLabel.Name = "JulkaisuvuosiTextLabel";
            this.JulkaisuvuosiTextLabel.Size = new System.Drawing.Size(76, 13);
            this.JulkaisuvuosiTextLabel.TabIndex = 2;
            this.JulkaisuvuosiTextLabel.Text = "Julkaisuvuosi: ";
            // 
            // ElokuvanNimiTextLabel
            // 
            this.ElokuvanNimiTextLabel.AutoSize = true;
            this.ElokuvanNimiTextLabel.Location = new System.Drawing.Point(6, 60);
            this.ElokuvanNimiTextLabel.Name = "ElokuvanNimiTextLabel";
            this.ElokuvanNimiTextLabel.Size = new System.Drawing.Size(76, 13);
            this.ElokuvanNimiTextLabel.TabIndex = 1;
            this.ElokuvanNimiTextLabel.Text = "Elokuvan nimi:";
            // 
            // IDtextlabel
            // 
            this.IDtextlabel.AutoSize = true;
            this.IDtextlabel.Location = new System.Drawing.Point(7, 27);
            this.IDtextlabel.Name = "IDtextlabel";
            this.IDtextlabel.Size = new System.Drawing.Size(21, 13);
            this.IDtextlabel.TabIndex = 0;
            this.IDtextlabel.Text = "ID:";
            // 
            // groupBoxToiminnallisuus
            // 
            this.groupBoxToiminnallisuus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxToiminnallisuus.Controls.Add(this.PoistaButton);
            this.groupBoxToiminnallisuus.Controls.Add(this.TallennaButton);
            this.groupBoxToiminnallisuus.Controls.Add(this.UusiTietueButton);
            this.groupBoxToiminnallisuus.Location = new System.Drawing.Point(397, 28);
            this.groupBoxToiminnallisuus.Name = "groupBoxToiminnallisuus";
            this.groupBoxToiminnallisuus.Size = new System.Drawing.Size(341, 227);
            this.groupBoxToiminnallisuus.TabIndex = 2;
            this.groupBoxToiminnallisuus.TabStop = false;
            this.groupBoxToiminnallisuus.Text = "Toiminnallisuus";
            // 
            // PoistaButton
            // 
            this.PoistaButton.BackColor = System.Drawing.Color.Red;
            this.PoistaButton.ForeColor = System.Drawing.SystemColors.Window;
            this.PoistaButton.Location = new System.Drawing.Point(84, 160);
            this.PoistaButton.Name = "PoistaButton";
            this.PoistaButton.Size = new System.Drawing.Size(169, 46);
            this.PoistaButton.TabIndex = 0;
            this.PoistaButton.Text = "Poista";
            this.PoistaButton.UseVisualStyleBackColor = false;
            // 
            // TallennaButton
            // 
            this.TallennaButton.BackColor = System.Drawing.Color.Lime;
            this.TallennaButton.Location = new System.Drawing.Point(84, 92);
            this.TallennaButton.Name = "TallennaButton";
            this.TallennaButton.Size = new System.Drawing.Size(169, 46);
            this.TallennaButton.TabIndex = 0;
            this.TallennaButton.Text = "Tallenna";
            this.TallennaButton.UseVisualStyleBackColor = false;
            this.TallennaButton.Click += new System.EventHandler(this.TallennaButton_Click);
            // 
            // UusiTietueButton
            // 
            this.UusiTietueButton.Location = new System.Drawing.Point(84, 27);
            this.UusiTietueButton.Name = "UusiTietueButton";
            this.UusiTietueButton.Size = new System.Drawing.Size(169, 46);
            this.UusiTietueButton.TabIndex = 0;
            this.UusiTietueButton.Text = "Uusi tietue";
            this.UusiTietueButton.UseVisualStyleBackColor = true;
            this.UusiTietueButton.Click += new System.EventHandler(this.UusiTietueButton_Click);
            // 
            // groupBoxArvio
            // 
            this.groupBoxArvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArvio.Controls.Add(this.Arvosanalabel);
            this.groupBoxArvio.Controls.Add(this.Desimaalipilkkulabel);
            this.groupBoxArvio.Controls.Add(this.numericUpDownDesimaalit);
            this.groupBoxArvio.Controls.Add(this.numericUpDownKymmenet);
            this.groupBoxArvio.Controls.Add(this.textBoxArvio);
            this.groupBoxArvio.Location = new System.Drawing.Point(13, 260);
            this.groupBoxArvio.Name = "groupBoxArvio";
            this.groupBoxArvio.Size = new System.Drawing.Size(378, 190);
            this.groupBoxArvio.TabIndex = 3;
            this.groupBoxArvio.TabStop = false;
            this.groupBoxArvio.Text = "Arvio";
            // 
            // Arvosanalabel
            // 
            this.Arvosanalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arvosanalabel.AutoSize = true;
            this.Arvosanalabel.Location = new System.Drawing.Point(18, 166);
            this.Arvosanalabel.Name = "Arvosanalabel";
            this.Arvosanalabel.Size = new System.Drawing.Size(55, 13);
            this.Arvosanalabel.TabIndex = 4;
            this.Arvosanalabel.Text = "Arvosana:";
            // 
            // Desimaalipilkkulabel
            // 
            this.Desimaalipilkkulabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Desimaalipilkkulabel.AutoSize = true;
            this.Desimaalipilkkulabel.Location = new System.Drawing.Point(121, 171);
            this.Desimaalipilkkulabel.Name = "Desimaalipilkkulabel";
            this.Desimaalipilkkulabel.Size = new System.Drawing.Size(10, 13);
            this.Desimaalipilkkulabel.TabIndex = 3;
            this.Desimaalipilkkulabel.Text = ".";
            // 
            // numericUpDownDesimaalit
            // 
            this.numericUpDownDesimaalit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownDesimaalit.Location = new System.Drawing.Point(137, 164);
            this.numericUpDownDesimaalit.Name = "numericUpDownDesimaalit";
            this.numericUpDownDesimaalit.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownDesimaalit.TabIndex = 2;
            // 
            // numericUpDownKymmenet
            // 
            this.numericUpDownKymmenet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownKymmenet.Location = new System.Drawing.Point(79, 164);
            this.numericUpDownKymmenet.Name = "numericUpDownKymmenet";
            this.numericUpDownKymmenet.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownKymmenet.TabIndex = 1;
            // 
            // textBoxArvio
            // 
            this.textBoxArvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArvio.Location = new System.Drawing.Point(6, 19);
            this.textBoxArvio.Multiline = true;
            this.textBoxArvio.Name = "textBoxArvio";
            this.textBoxArvio.Size = new System.Drawing.Size(366, 130);
            this.textBoxArvio.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 463);
            this.Controls.Add(this.groupBoxArvio);
            this.Controls.Add(this.groupBoxToiminnallisuus);
            this.Controls.Add(this.groupBoxElokuvanTiedot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elokuvasovellus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxElokuvanTiedot.ResumeLayout(false);
            this.groupBoxElokuvanTiedot.PerformLayout();
            this.groupBoxToiminnallisuus.ResumeLayout(false);
            this.groupBoxArvio.ResumeLayout(false);
            this.groupBoxArvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDesimaalit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKymmenet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxElokuvanTiedot;
        private System.Windows.Forms.TextBox textBoxKesto;
        private System.Windows.Forms.TextBox textBoxJulkaisuvuosi;
        private System.Windows.Forms.TextBox textBoxElokuvanNimi;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label KestoTextLabel;
        private System.Windows.Forms.Label JulkaisuvuosiTextLabel;
        private System.Windows.Forms.Label ElokuvanNimiTextLabel;
        private System.Windows.Forms.Label IDtextlabel;
        private System.Windows.Forms.GroupBox groupBoxToiminnallisuus;
        private System.Windows.Forms.Button PoistaButton;
        private System.Windows.Forms.Button TallennaButton;
        private System.Windows.Forms.Button UusiTietueButton;
        private System.Windows.Forms.GroupBox groupBoxArvio;
        private System.Windows.Forms.TextBox textBoxArvio;
        private System.Windows.Forms.Button Seuraavabutton;
        private System.Windows.Forms.Button Edellinenbutton;
        private System.Windows.Forms.Label Arvosanalabel;
        private System.Windows.Forms.Label Desimaalipilkkulabel;
        private System.Windows.Forms.NumericUpDown numericUpDownDesimaalit;
        private System.Windows.Forms.NumericUpDown numericUpDownKymmenet;
    }
}


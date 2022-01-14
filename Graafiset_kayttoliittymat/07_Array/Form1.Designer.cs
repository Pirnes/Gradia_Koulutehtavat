
namespace _07_Array
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
            this.LabelTaulukonLuonti = new System.Windows.Forms.Label();
            this.LabelTaulukonKoko = new System.Windows.Forms.Label();
            this.TextBoxTaulukonKoko = new System.Windows.Forms.TextBox();
            this.ButtonLuoTaulukko = new System.Windows.Forms.Button();
            this.LabelTallennus = new System.Windows.Forms.Label();
            this.LabelTalletettavaNumero = new System.Windows.Forms.Label();
            this.LabelTallennuspaikanIndexi = new System.Windows.Forms.Label();
            this.TextBoxTallennettavaNumero = new System.Windows.Forms.TextBox();
            this.TextBoxTallennuspaikanIndexi = new System.Windows.Forms.TextBox();
            this.ButtonTallenna = new System.Windows.Forms.Button();
            this.LabelHaku = new System.Windows.Forms.Label();
            this.LabelHakuTalletusIndexi = new System.Windows.Forms.Label();
            this.TextBoxHakuIndexi = new System.Windows.Forms.TextBox();
            this.ButtonHae = new System.Windows.Forms.Button();
            this.TextBoxHaunTulos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelTaulukonLuonti
            // 
            this.LabelTaulukonLuonti.AutoSize = true;
            this.LabelTaulukonLuonti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTaulukonLuonti.Location = new System.Drawing.Point(113, 9);
            this.LabelTaulukonLuonti.Name = "LabelTaulukonLuonti";
            this.LabelTaulukonLuonti.Size = new System.Drawing.Size(109, 13);
            this.LabelTaulukonLuonti.TabIndex = 0;
            this.LabelTaulukonLuonti.Text = "TAULUKON LUONTI";
            // 
            // LabelTaulukonKoko
            // 
            this.LabelTaulukonKoko.AutoSize = true;
            this.LabelTaulukonKoko.Location = new System.Drawing.Point(12, 37);
            this.LabelTaulukonKoko.Name = "LabelTaulukonKoko";
            this.LabelTaulukonKoko.Size = new System.Drawing.Size(82, 13);
            this.LabelTaulukonKoko.TabIndex = 1;
            this.LabelTaulukonKoko.Text = "Taulukon koko:";
            // 
            // TextBoxTaulukonKoko
            // 
            this.TextBoxTaulukonKoko.Location = new System.Drawing.Point(139, 33);
            this.TextBoxTaulukonKoko.Name = "TextBoxTaulukonKoko";
            this.TextBoxTaulukonKoko.Size = new System.Drawing.Size(55, 20);
            this.TextBoxTaulukonKoko.TabIndex = 2;
            // 
            // ButtonLuoTaulukko
            // 
            this.ButtonLuoTaulukko.Location = new System.Drawing.Point(218, 31);
            this.ButtonLuoTaulukko.Name = "ButtonLuoTaulukko";
            this.ButtonLuoTaulukko.Size = new System.Drawing.Size(87, 23);
            this.ButtonLuoTaulukko.TabIndex = 3;
            this.ButtonLuoTaulukko.Text = "Luo taulukko";
            this.ButtonLuoTaulukko.UseVisualStyleBackColor = true;
            this.ButtonLuoTaulukko.Click += new System.EventHandler(this.ButtonLuoTaulukko_Click);
            // 
            // LabelTallennus
            // 
            this.LabelTallennus.AutoSize = true;
            this.LabelTallennus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTallennus.Location = new System.Drawing.Point(136, 78);
            this.LabelTallennus.Name = "LabelTallennus";
            this.LabelTallennus.Size = new System.Drawing.Size(71, 13);
            this.LabelTallennus.TabIndex = 4;
            this.LabelTallennus.Text = "TALLENNUS";
            // 
            // LabelTalletettavaNumero
            // 
            this.LabelTalletettavaNumero.AutoSize = true;
            this.LabelTalletettavaNumero.Location = new System.Drawing.Point(12, 115);
            this.LabelTalletettavaNumero.Name = "LabelTalletettavaNumero";
            this.LabelTalletettavaNumero.Size = new System.Drawing.Size(113, 13);
            this.LabelTalletettavaNumero.TabIndex = 5;
            this.LabelTalletettavaNumero.Text = "Tallennettava numero:";
            // 
            // LabelTallennuspaikanIndexi
            // 
            this.LabelTallennuspaikanIndexi.AutoSize = true;
            this.LabelTallennuspaikanIndexi.Location = new System.Drawing.Point(12, 148);
            this.LabelTallennuspaikanIndexi.Name = "LabelTallennuspaikanIndexi";
            this.LabelTallennuspaikanIndexi.Size = new System.Drawing.Size(118, 13);
            this.LabelTallennuspaikanIndexi.TabIndex = 6;
            this.LabelTallennuspaikanIndexi.Text = "Tallennuspaikan indexi:";
            // 
            // TextBoxTallennettavaNumero
            // 
            this.TextBoxTallennettavaNumero.Location = new System.Drawing.Point(139, 112);
            this.TextBoxTallennettavaNumero.Name = "TextBoxTallennettavaNumero";
            this.TextBoxTallennettavaNumero.Size = new System.Drawing.Size(55, 20);
            this.TextBoxTallennettavaNumero.TabIndex = 7;
            // 
            // TextBoxTallennuspaikanIndexi
            // 
            this.TextBoxTallennuspaikanIndexi.Location = new System.Drawing.Point(139, 145);
            this.TextBoxTallennuspaikanIndexi.Name = "TextBoxTallennuspaikanIndexi";
            this.TextBoxTallennuspaikanIndexi.Size = new System.Drawing.Size(55, 20);
            this.TextBoxTallennuspaikanIndexi.TabIndex = 8;
            // 
            // ButtonTallenna
            // 
            this.ButtonTallenna.Location = new System.Drawing.Point(218, 143);
            this.ButtonTallenna.Name = "ButtonTallenna";
            this.ButtonTallenna.Size = new System.Drawing.Size(75, 23);
            this.ButtonTallenna.TabIndex = 9;
            this.ButtonTallenna.Text = "Tallenna";
            this.ButtonTallenna.UseVisualStyleBackColor = true;
            this.ButtonTallenna.Click += new System.EventHandler(this.ButtonTallenna_Click);
            // 
            // LabelHaku
            // 
            this.LabelHaku.AutoSize = true;
            this.LabelHaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHaku.Location = new System.Drawing.Point(149, 185);
            this.LabelHaku.Name = "LabelHaku";
            this.LabelHaku.Size = new System.Drawing.Size(37, 13);
            this.LabelHaku.TabIndex = 10;
            this.LabelHaku.Text = "HAKU";
            // 
            // LabelHakuTalletusIndexi
            // 
            this.LabelHakuTalletusIndexi.AutoSize = true;
            this.LabelHakuTalletusIndexi.Location = new System.Drawing.Point(12, 217);
            this.LabelHakuTalletusIndexi.Name = "LabelHakuTalletusIndexi";
            this.LabelHakuTalletusIndexi.Size = new System.Drawing.Size(118, 13);
            this.LabelHakuTalletusIndexi.TabIndex = 11;
            this.LabelHakuTalletusIndexi.Text = "Tallennuspaikan indexi:";
            // 
            // TextBoxHakuIndexi
            // 
            this.TextBoxHakuIndexi.Location = new System.Drawing.Point(139, 214);
            this.TextBoxHakuIndexi.Name = "TextBoxHakuIndexi";
            this.TextBoxHakuIndexi.Size = new System.Drawing.Size(55, 20);
            this.TextBoxHakuIndexi.TabIndex = 12;
            // 
            // ButtonHae
            // 
            this.ButtonHae.Location = new System.Drawing.Point(218, 212);
            this.ButtonHae.Name = "ButtonHae";
            this.ButtonHae.Size = new System.Drawing.Size(75, 23);
            this.ButtonHae.TabIndex = 13;
            this.ButtonHae.Text = "Hae";
            this.ButtonHae.UseVisualStyleBackColor = true;
            this.ButtonHae.Click += new System.EventHandler(this.ButtonHae_Click);
            // 
            // TextBoxHaunTulos
            // 
            this.TextBoxHaunTulos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextBoxHaunTulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHaunTulos.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxHaunTulos.Location = new System.Drawing.Point(139, 240);
            this.TextBoxHaunTulos.Multiline = true;
            this.TextBoxHaunTulos.Name = "TextBoxHaunTulos";
            this.TextBoxHaunTulos.Size = new System.Drawing.Size(55, 34);
            this.TextBoxHaunTulos.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 308);
            this.Controls.Add(this.TextBoxHaunTulos);
            this.Controls.Add(this.ButtonHae);
            this.Controls.Add(this.TextBoxHakuIndexi);
            this.Controls.Add(this.LabelHakuTalletusIndexi);
            this.Controls.Add(this.LabelHaku);
            this.Controls.Add(this.ButtonTallenna);
            this.Controls.Add(this.TextBoxTallennuspaikanIndexi);
            this.Controls.Add(this.TextBoxTallennettavaNumero);
            this.Controls.Add(this.LabelTallennuspaikanIndexi);
            this.Controls.Add(this.LabelTalletettavaNumero);
            this.Controls.Add(this.LabelTallennus);
            this.Controls.Add(this.ButtonLuoTaulukko);
            this.Controls.Add(this.TextBoxTaulukonKoko);
            this.Controls.Add(this.LabelTaulukonKoko);
            this.Controls.Add(this.LabelTaulukonLuonti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTaulukonLuonti;
        private System.Windows.Forms.Label LabelTaulukonKoko;
        private System.Windows.Forms.TextBox TextBoxTaulukonKoko;
        private System.Windows.Forms.Button ButtonLuoTaulukko;
        private System.Windows.Forms.Label LabelTallennus;
        private System.Windows.Forms.Label LabelTalletettavaNumero;
        private System.Windows.Forms.Label LabelTallennuspaikanIndexi;
        private System.Windows.Forms.TextBox TextBoxTallennettavaNumero;
        private System.Windows.Forms.TextBox TextBoxTallennuspaikanIndexi;
        private System.Windows.Forms.Button ButtonTallenna;
        private System.Windows.Forms.Label LabelHaku;
        private System.Windows.Forms.Label LabelHakuTalletusIndexi;
        private System.Windows.Forms.TextBox TextBoxHakuIndexi;
        private System.Windows.Forms.Button ButtonHae;
        private System.Windows.Forms.TextBox TextBoxHaunTulos;
    }
}


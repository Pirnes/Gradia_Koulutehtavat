
namespace _09_List_ja_Foreach_silmukat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonLuoLista = new System.Windows.Forms.Button();
            this.ButtonLisaaListaan = new System.Windows.Forms.Button();
            this.ButtonHaeListanSisalto = new System.Windows.Forms.Button();
            this.TextBoxLisaaListaan = new System.Windows.Forms.TextBox();
            this.ComboBoxLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUODAAN string- TYYPPINEN LISTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISÄTÄÄN LISTAAN MERKKIJONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HAETAAN LISTAN SISÄLTÖ";
            // 
            // ButtonLuoLista
            // 
            this.ButtonLuoLista.Location = new System.Drawing.Point(114, 51);
            this.ButtonLuoLista.Name = "ButtonLuoLista";
            this.ButtonLuoLista.Size = new System.Drawing.Size(75, 23);
            this.ButtonLuoLista.TabIndex = 3;
            this.ButtonLuoLista.Text = "Luo lista";
            this.ButtonLuoLista.UseVisualStyleBackColor = true;
            this.ButtonLuoLista.Click += new System.EventHandler(this.ButtonLuoLista_Click);
            // 
            // ButtonLisaaListaan
            // 
            this.ButtonLisaaListaan.Location = new System.Drawing.Point(297, 123);
            this.ButtonLisaaListaan.Name = "ButtonLisaaListaan";
            this.ButtonLisaaListaan.Size = new System.Drawing.Size(75, 23);
            this.ButtonLisaaListaan.TabIndex = 4;
            this.ButtonLisaaListaan.Text = "Lisää listaan";
            this.ButtonLisaaListaan.UseVisualStyleBackColor = true;
            this.ButtonLisaaListaan.Click += new System.EventHandler(this.ButtonLisaaListaan_Click);
            // 
            // ButtonHaeListanSisalto
            // 
            this.ButtonHaeListanSisalto.Location = new System.Drawing.Point(297, 186);
            this.ButtonHaeListanSisalto.Name = "ButtonHaeListanSisalto";
            this.ButtonHaeListanSisalto.Size = new System.Drawing.Size(75, 23);
            this.ButtonHaeListanSisalto.TabIndex = 5;
            this.ButtonHaeListanSisalto.Text = "Hae lista";
            this.ButtonHaeListanSisalto.UseVisualStyleBackColor = true;
            this.ButtonHaeListanSisalto.Click += new System.EventHandler(this.ButtonHaeListanSisalto_Click);
            // 
            // TextBoxLisaaListaan
            // 
            this.TextBoxLisaaListaan.Location = new System.Drawing.Point(12, 123);
            this.TextBoxLisaaListaan.Name = "TextBoxLisaaListaan";
            this.TextBoxLisaaListaan.Size = new System.Drawing.Size(223, 20);
            this.TextBoxLisaaListaan.TabIndex = 6;
            // 
            // ComboBoxLista
            // 
            this.ComboBoxLista.FormattingEnabled = true;
            this.ComboBoxLista.Location = new System.Drawing.Point(12, 188);
            this.ComboBoxLista.Name = "ComboBoxLista";
            this.ComboBoxLista.Size = new System.Drawing.Size(223, 21);
            this.ComboBoxLista.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 385);
            this.Controls.Add(this.ComboBoxLista);
            this.Controls.Add(this.TextBoxLisaaListaan);
            this.Controls.Add(this.ButtonHaeListanSisalto);
            this.Controls.Add(this.ButtonLisaaListaan);
            this.Controls.Add(this.ButtonLuoLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonLuoLista;
        private System.Windows.Forms.Button ButtonLisaaListaan;
        private System.Windows.Forms.Button ButtonHaeListanSisalto;
        private System.Windows.Forms.TextBox TextBoxLisaaListaan;
        private System.Windows.Forms.ComboBox ComboBoxLista;
    }
}


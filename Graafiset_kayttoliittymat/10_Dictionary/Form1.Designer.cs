
namespace _10_Dictionary
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
            this.ButtonDictionary = new System.Windows.Forms.Button();
            this.ButtonLisaaElementti = new System.Windows.Forms.Button();
            this.ButtonHaeElementti = new System.Windows.Forms.Button();
            this.TextBoxKeyLisaa = new System.Windows.Forms.TextBox();
            this.TextBoxValueLisaa = new System.Windows.Forms.TextBox();
            this.TextBoxKeyHae = new System.Windows.Forms.TextBox();
            this.TextBoxValueHae = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUODAAN dictionary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISÄTÄÄN ELEMENTTEJÄ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HAETAAN ELEMENTTEJÄ";
            // 
            // ButtonDictionary
            // 
            this.ButtonDictionary.Location = new System.Drawing.Point(175, 49);
            this.ButtonDictionary.Name = "ButtonDictionary";
            this.ButtonDictionary.Size = new System.Drawing.Size(101, 23);
            this.ButtonDictionary.TabIndex = 3;
            this.ButtonDictionary.Text = "Luo dictionary";
            this.ButtonDictionary.UseVisualStyleBackColor = true;
            this.ButtonDictionary.Click += new System.EventHandler(this.ButtonDictionary_Click);
            // 
            // ButtonLisaaElementti
            // 
            this.ButtonLisaaElementti.Location = new System.Drawing.Point(301, 173);
            this.ButtonLisaaElementti.Name = "ButtonLisaaElementti";
            this.ButtonLisaaElementti.Size = new System.Drawing.Size(92, 23);
            this.ButtonLisaaElementti.TabIndex = 4;
            this.ButtonLisaaElementti.Text = "Lisää elementti";
            this.ButtonLisaaElementti.UseVisualStyleBackColor = true;
            this.ButtonLisaaElementti.Click += new System.EventHandler(this.ButtonLisaaElementti_Click);
            // 
            // ButtonHaeElementti
            // 
            this.ButtonHaeElementti.Location = new System.Drawing.Point(301, 265);
            this.ButtonHaeElementti.Name = "ButtonHaeElementti";
            this.ButtonHaeElementti.Size = new System.Drawing.Size(92, 23);
            this.ButtonHaeElementti.TabIndex = 5;
            this.ButtonHaeElementti.Text = "Hae elementti";
            this.ButtonHaeElementti.UseVisualStyleBackColor = true;
            this.ButtonHaeElementti.Click += new System.EventHandler(this.ButtonHaeElementti_Click);
            // 
            // TextBoxKeyLisaa
            // 
            this.TextBoxKeyLisaa.Location = new System.Drawing.Point(175, 132);
            this.TextBoxKeyLisaa.Name = "TextBoxKeyLisaa";
            this.TextBoxKeyLisaa.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKeyLisaa.TabIndex = 6;
            // 
            // TextBoxValueLisaa
            // 
            this.TextBoxValueLisaa.Location = new System.Drawing.Point(175, 176);
            this.TextBoxValueLisaa.Name = "TextBoxValueLisaa";
            this.TextBoxValueLisaa.Size = new System.Drawing.Size(100, 20);
            this.TextBoxValueLisaa.TabIndex = 7;
            // 
            // TextBoxKeyHae
            // 
            this.TextBoxKeyHae.Location = new System.Drawing.Point(175, 267);
            this.TextBoxKeyHae.Name = "TextBoxKeyHae";
            this.TextBoxKeyHae.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKeyHae.TabIndex = 8;
            // 
            // TextBoxValueHae
            // 
            this.TextBoxValueHae.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextBoxValueHae.Location = new System.Drawing.Point(175, 307);
            this.TextBoxValueHae.Multiline = true;
            this.TextBoxValueHae.Name = "TextBoxValueHae";
            this.TextBoxValueHae.ReadOnly = true;
            this.TextBoxValueHae.Size = new System.Drawing.Size(100, 30);
            this.TextBoxValueHae.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 378);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxValueHae);
            this.Controls.Add(this.TextBoxKeyHae);
            this.Controls.Add(this.TextBoxValueLisaa);
            this.Controls.Add(this.TextBoxKeyLisaa);
            this.Controls.Add(this.ButtonHaeElementti);
            this.Controls.Add(this.ButtonLisaaElementti);
            this.Controls.Add(this.ButtonDictionary);
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
        private System.Windows.Forms.Button ButtonDictionary;
        private System.Windows.Forms.Button ButtonLisaaElementti;
        private System.Windows.Forms.Button ButtonHaeElementti;
        private System.Windows.Forms.TextBox TextBoxKeyLisaa;
        private System.Windows.Forms.TextBox TextBoxValueLisaa;
        private System.Windows.Forms.TextBox TextBoxKeyHae;
        private System.Windows.Forms.TextBox TextBoxValueHae;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


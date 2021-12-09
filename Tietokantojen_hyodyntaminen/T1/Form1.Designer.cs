
namespace T1
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
            this.LisaaTiedotButton = new System.Windows.Forms.Button();
            this.NimiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpiskelijaryhmanIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpiskelijaIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HaeTiedotButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.HaeOpiskelijaryhmaButton = new System.Windows.Forms.Button();
            this.PoistaNimiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LisaaTiedotButton
            // 
            this.LisaaTiedotButton.Location = new System.Drawing.Point(192, 78);
            this.LisaaTiedotButton.Name = "LisaaTiedotButton";
            this.LisaaTiedotButton.Size = new System.Drawing.Size(75, 23);
            this.LisaaTiedotButton.TabIndex = 0;
            this.LisaaTiedotButton.Text = "Lisää tiedot";
            this.LisaaTiedotButton.UseVisualStyleBackColor = true;
            this.LisaaTiedotButton.Click += new System.EventHandler(this.LisaaTiedotButton_Click);
            // 
            // NimiTextBox
            // 
            this.NimiTextBox.Location = new System.Drawing.Point(126, 50);
            this.NimiTextBox.Name = "NimiTextBox";
            this.NimiTextBox.Size = new System.Drawing.Size(214, 20);
            this.NimiTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opiskelijan nimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opiskelijaryhmän Id:";
            // 
            // OpiskelijaryhmanIdTextBox
            // 
            this.OpiskelijaryhmanIdTextBox.Location = new System.Drawing.Point(126, 80);
            this.OpiskelijaryhmanIdTextBox.Name = "OpiskelijaryhmanIdTextBox";
            this.OpiskelijaryhmanIdTextBox.Size = new System.Drawing.Size(40, 20);
            this.OpiskelijaryhmanIdTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opiskelijan Id";
            // 
            // OpiskelijaIdTextBox
            // 
            this.OpiskelijaIdTextBox.Location = new System.Drawing.Point(126, 22);
            this.OpiskelijaIdTextBox.Name = "OpiskelijaIdTextBox";
            this.OpiskelijaIdTextBox.Size = new System.Drawing.Size(40, 20);
            this.OpiskelijaIdTextBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 146);
            this.dataGridView1.TabIndex = 8;
            // 
            // HaeTiedotButton
            // 
            this.HaeTiedotButton.Location = new System.Drawing.Point(401, 117);
            this.HaeTiedotButton.Name = "HaeTiedotButton";
            this.HaeTiedotButton.Size = new System.Drawing.Size(125, 47);
            this.HaeTiedotButton.TabIndex = 9;
            this.HaeTiedotButton.Text = "Hae opiskelijoiden nimet\'";
            this.HaeTiedotButton.UseVisualStyleBackColor = true;
            this.HaeTiedotButton.Click += new System.EventHandler(this.HaeTiedotButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(383, 154);
            this.dataGridView2.TabIndex = 10;
            // 
            // HaeOpiskelijaryhmaButton
            // 
            this.HaeOpiskelijaryhmaButton.Location = new System.Drawing.Point(402, 298);
            this.HaeOpiskelijaryhmaButton.Name = "HaeOpiskelijaryhmaButton";
            this.HaeOpiskelijaryhmaButton.Size = new System.Drawing.Size(123, 50);
            this.HaeOpiskelijaryhmaButton.TabIndex = 11;
            this.HaeOpiskelijaryhmaButton.Text = "Hae Opiskelijaryhmät";
            this.HaeOpiskelijaryhmaButton.UseVisualStyleBackColor = true;
            this.HaeOpiskelijaryhmaButton.Click += new System.EventHandler(this.HaeOpiskelijaryhmaButton_Click);
            // 
            // PoistaNimiButton
            // 
            this.PoistaNimiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PoistaNimiButton.Location = new System.Drawing.Point(401, 170);
            this.PoistaNimiButton.Name = "PoistaNimiButton";
            this.PoistaNimiButton.Size = new System.Drawing.Size(124, 39);
            this.PoistaNimiButton.TabIndex = 12;
            this.PoistaNimiButton.Text = "Poista tietue";
            this.PoistaNimiButton.UseVisualStyleBackColor = false;
            this.PoistaNimiButton.Click += new System.EventHandler(this.PoistaNimiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 467);
            this.Controls.Add(this.PoistaNimiButton);
            this.Controls.Add(this.HaeOpiskelijaryhmaButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.HaeTiedotButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OpiskelijaIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpiskelijaryhmanIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NimiTextBox);
            this.Controls.Add(this.LisaaTiedotButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LisaaTiedotButton;
        private System.Windows.Forms.TextBox NimiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OpiskelijaryhmanIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OpiskelijaIdTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button HaeTiedotButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button HaeOpiskelijaryhmaButton;
        private System.Windows.Forms.Button PoistaNimiButton;
    }
}


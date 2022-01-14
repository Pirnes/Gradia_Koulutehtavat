
namespace _04_Switch
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonValinta1 = new System.Windows.Forms.Button();
            this.buttonValinta2 = new System.Windows.Forms.Button();
            this.buttonValinta3 = new System.Windows.Forms.Button();
            this.buttonValinta4 = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // buttonValinta1
            // 
            this.buttonValinta1.Location = new System.Drawing.Point(12, 27);
            this.buttonValinta1.Name = "buttonValinta1";
            this.buttonValinta1.Size = new System.Drawing.Size(75, 23);
            this.buttonValinta1.TabIndex = 1;
            this.buttonValinta1.Text = "Valinta 1";
            this.buttonValinta1.UseVisualStyleBackColor = true;
            this.buttonValinta1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonValinta2
            // 
            this.buttonValinta2.Location = new System.Drawing.Point(12, 56);
            this.buttonValinta2.Name = "buttonValinta2";
            this.buttonValinta2.Size = new System.Drawing.Size(75, 23);
            this.buttonValinta2.TabIndex = 1;
            this.buttonValinta2.Text = "Valinta 2";
            this.buttonValinta2.UseVisualStyleBackColor = true;
            this.buttonValinta2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonValinta3
            // 
            this.buttonValinta3.Location = new System.Drawing.Point(12, 85);
            this.buttonValinta3.Name = "buttonValinta3";
            this.buttonValinta3.Size = new System.Drawing.Size(75, 23);
            this.buttonValinta3.TabIndex = 1;
            this.buttonValinta3.Text = "Valinta 3";
            this.buttonValinta3.UseVisualStyleBackColor = true;
            this.buttonValinta3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonValinta4
            // 
            this.buttonValinta4.Location = new System.Drawing.Point(12, 114);
            this.buttonValinta4.Name = "buttonValinta4";
            this.buttonValinta4.Size = new System.Drawing.Size(75, 23);
            this.buttonValinta4.TabIndex = 1;
            this.buttonValinta4.Text = "Valinta 4";
            this.buttonValinta4.UseVisualStyleBackColor = true;
            this.buttonValinta4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(12, 143);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 1;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 217);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonValinta4);
            this.Controls.Add(this.buttonValinta3);
            this.Controls.Add(this.buttonValinta2);
            this.Controls.Add(this.buttonValinta1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pääformi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button buttonValinta1;
        private System.Windows.Forms.Button buttonValinta2;
        private System.Windows.Forms.Button buttonValinta3;
        private System.Windows.Forms.Button buttonValinta4;
        private System.Windows.Forms.Button buttonDefault;
    }
}


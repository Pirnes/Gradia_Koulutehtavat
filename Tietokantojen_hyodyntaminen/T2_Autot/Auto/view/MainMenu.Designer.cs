namespace Autokauppa.view
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MittarilukemaTextBox = new System.Windows.Forms.TextBox();
            this.MoottorinTilavuusTextBox = new System.Windows.Forms.TextBox();
            this.HintaTextBox = new System.Windows.Forms.TextBox();
            this.MerkkiComboBox = new System.Windows.Forms.ComboBox();
            this.autonMerkkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseHallintaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MalliComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UusiTietueButton = new System.Windows.Forms.Button();
            this.PoistaTietueButton = new System.Windows.Forms.Button();
            this.EdellinenButton = new System.Windows.Forms.Button();
            this.SeuraavaButton = new System.Windows.Forms.Button();
            this.autonMalliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autonMerkkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHallintaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autonMalliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.testaaTietokantayhteyttäToolStripMenuItem_Click);
            // 
            // MittarilukemaTextBox
            // 
            this.MittarilukemaTextBox.Location = new System.Drawing.Point(12, 109);
            this.MittarilukemaTextBox.Name = "MittarilukemaTextBox";
            this.MittarilukemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.MittarilukemaTextBox.TabIndex = 1;
            // 
            // MoottorinTilavuusTextBox
            // 
            this.MoottorinTilavuusTextBox.Location = new System.Drawing.Point(12, 136);
            this.MoottorinTilavuusTextBox.Name = "MoottorinTilavuusTextBox";
            this.MoottorinTilavuusTextBox.Size = new System.Drawing.Size(100, 20);
            this.MoottorinTilavuusTextBox.TabIndex = 2;
            // 
            // HintaTextBox
            // 
            this.HintaTextBox.Location = new System.Drawing.Point(12, 163);
            this.HintaTextBox.Name = "HintaTextBox";
            this.HintaTextBox.Size = new System.Drawing.Size(100, 20);
            this.HintaTextBox.TabIndex = 3;
            // 
            // MerkkiComboBox
            // 
            this.MerkkiComboBox.FormattingEnabled = true;
            this.MerkkiComboBox.Location = new System.Drawing.Point(12, 27);
            this.MerkkiComboBox.Name = "MerkkiComboBox";
            this.MerkkiComboBox.Size = new System.Drawing.Size(200, 21);
            this.MerkkiComboBox.TabIndex = 4;
            // 
            // autonMerkkiBindingSource
            // 
            this.autonMerkkiBindingSource.DataSource = typeof(Autokauppa.model.AutonMerkki);
            // 
            // mainMenuBindingSource1
            // 
            this.mainMenuBindingSource1.DataSource = typeof(Autokauppa.view.MainMenu);
            // 
            // databaseHallintaBindingSource
            // 
            this.databaseHallintaBindingSource.DataSource = typeof(Autokauppa.model.DatabaseHallinta);
            // 
            // mainMenuBindingSource
            // 
            this.mainMenuBindingSource.DataSource = typeof(Autokauppa.view.MainMenu);
            // 
            // MalliComboBox
            // 
            this.MalliComboBox.FormattingEnabled = true;
            this.MalliComboBox.Location = new System.Drawing.Point(12, 54);
            this.MalliComboBox.Name = "MalliComboBox";
            this.MalliComboBox.Size = new System.Drawing.Size(200, 21);
            this.MalliComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // UusiTietueButton
            // 
            this.UusiTietueButton.BackColor = System.Drawing.Color.Lime;
            this.UusiTietueButton.Location = new System.Drawing.Point(218, 18);
            this.UusiTietueButton.Name = "UusiTietueButton";
            this.UusiTietueButton.Size = new System.Drawing.Size(167, 49);
            this.UusiTietueButton.TabIndex = 7;
            this.UusiTietueButton.Text = "Uusi tietue";
            this.UusiTietueButton.UseVisualStyleBackColor = false;
            // 
            // PoistaTietueButton
            // 
            this.PoistaTietueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PoistaTietueButton.Location = new System.Drawing.Point(218, 71);
            this.PoistaTietueButton.Name = "PoistaTietueButton";
            this.PoistaTietueButton.Size = new System.Drawing.Size(167, 49);
            this.PoistaTietueButton.TabIndex = 8;
            this.PoistaTietueButton.Text = "Poista tietue";
            this.PoistaTietueButton.UseVisualStyleBackColor = false;
            // 
            // EdellinenButton
            // 
            this.EdellinenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EdellinenButton.Location = new System.Drawing.Point(218, 127);
            this.EdellinenButton.Name = "EdellinenButton";
            this.EdellinenButton.Size = new System.Drawing.Size(75, 23);
            this.EdellinenButton.TabIndex = 9;
            this.EdellinenButton.Text = "<< Edellinen";
            this.EdellinenButton.UseVisualStyleBackColor = false;
            // 
            // SeuraavaButton
            // 
            this.SeuraavaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SeuraavaButton.Location = new System.Drawing.Point(299, 127);
            this.SeuraavaButton.Name = "SeuraavaButton";
            this.SeuraavaButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SeuraavaButton.Size = new System.Drawing.Size(86, 23);
            this.SeuraavaButton.TabIndex = 10;
            this.SeuraavaButton.Text = "Seuraava >>";
            this.SeuraavaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeuraavaButton.UseVisualStyleBackColor = false;
            // 
            // autonMalliBindingSource
            // 
            this.autonMalliBindingSource.DataSource = typeof(Autokauppa.model.AutonMalli);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 357);
            this.Controls.Add(this.SeuraavaButton);
            this.Controls.Add(this.EdellinenButton);
            this.Controls.Add(this.PoistaTietueButton);
            this.Controls.Add(this.UusiTietueButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MalliComboBox);
            this.Controls.Add(this.MerkkiComboBox);
            this.Controls.Add(this.HintaTextBox);
            this.Controls.Add(this.MoottorinTilavuusTextBox);
            this.Controls.Add(this.MittarilukemaTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autonMerkkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseHallintaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autonMalliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.TextBox MittarilukemaTextBox;
        private System.Windows.Forms.TextBox MoottorinTilavuusTextBox;
        private System.Windows.Forms.TextBox HintaTextBox;
        private System.Windows.Forms.ComboBox MerkkiComboBox;
        private System.Windows.Forms.ComboBox MalliComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button UusiTietueButton;
        private System.Windows.Forms.Button PoistaTietueButton;
        private System.Windows.Forms.Button EdellinenButton;
        private System.Windows.Forms.Button SeuraavaButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource mainMenuBindingSource;
        private System.Windows.Forms.BindingSource databaseHallintaBindingSource;
        private System.Windows.Forms.BindingSource autonMerkkiBindingSource;
        private System.Windows.Forms.BindingSource mainMenuBindingSource1;
        private System.Windows.Forms.BindingSource autonMalliBindingSource;
    }
}
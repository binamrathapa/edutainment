namespace Edutainment
{
    partial class StartGame
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOptionSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(179, 80);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(148, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageGameToolStripMenuItem
            // 
            this.manageGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePlayerToolStripMenuItem,
            this.manageModuleToolStripMenuItem,
            this.manageStoryToolStripMenuItem,
            this.manageOptionSetToolStripMenuItem});
            this.manageGameToolStripMenuItem.Name = "manageGameToolStripMenuItem";
            this.manageGameToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.manageGameToolStripMenuItem.Text = "Manage Game";
            // 
            // managePlayerToolStripMenuItem
            // 
            this.managePlayerToolStripMenuItem.Name = "managePlayerToolStripMenuItem";
            this.managePlayerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.managePlayerToolStripMenuItem.Text = "Manage Player";
            this.managePlayerToolStripMenuItem.Click += new System.EventHandler(this.managePlayerToolStripMenuItem_Click);
            // 
            // manageModuleToolStripMenuItem
            // 
            this.manageModuleToolStripMenuItem.Name = "manageModuleToolStripMenuItem";
            this.manageModuleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageModuleToolStripMenuItem.Text = "Manage Module";
            this.manageModuleToolStripMenuItem.Click += new System.EventHandler(this.manageModuleToolStripMenuItem_Click);
            // 
            // manageStoryToolStripMenuItem
            // 
            this.manageStoryToolStripMenuItem.Name = "manageStoryToolStripMenuItem";
            this.manageStoryToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageStoryToolStripMenuItem.Text = "Manage Story";
            this.manageStoryToolStripMenuItem.Click += new System.EventHandler(this.manageStoryToolStripMenuItem_Click);
            // 
            // manageOptionSetToolStripMenuItem
            // 
            this.manageOptionSetToolStripMenuItem.Name = "manageOptionSetToolStripMenuItem";
            this.manageOptionSetToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageOptionSetToolStripMenuItem.Text = "Manage Option Set";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(428, 310);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartGame";
            this.Text = "Start Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOptionSetToolStripMenuItem;
    }
}


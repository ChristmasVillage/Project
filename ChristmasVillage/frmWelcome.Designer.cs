﻿namespace ChristmasVillage
{
    partial class frmWelcome
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
            this.connexionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionMenuItem,
            this.deconnectMenuItem,
            this.quitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionMenuItem
            // 
            this.connexionMenuItem.Name = "connexionMenuItem";
            this.connexionMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connexionMenuItem.Text = "Connect";
            this.connexionMenuItem.Click += new System.EventHandler(this.connexionMenuItem_Click);
            // 
            // deconnectMenuItem
            // 
            this.deconnectMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deconnectMenuItem.Name = "deconnectMenuItem";
            this.deconnectMenuItem.Size = new System.Drawing.Size(62, 20);
            this.deconnectMenuItem.Text = "Log Out";
            this.deconnectMenuItem.Click += new System.EventHandler(this.deconnectMenuItem_Click);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWelcome";
            this.Text = "Christmas Village ";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem connexionMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deconnectMenuItem;
        public System.Windows.Forms.ToolStripMenuItem quitMenuItem;

    }
}


namespace Otel_Otomasyonu
{
    partial class Anasayfa
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
            this.misafirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misafirGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misafirToolStripMenuItem,
            this.odaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // misafirToolStripMenuItem
            // 
            this.misafirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misafirGirişiToolStripMenuItem});
            this.misafirToolStripMenuItem.Name = "misafirToolStripMenuItem";
            this.misafirToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.misafirToolStripMenuItem.Text = "Misafir";
            // 
            // misafirGirişiToolStripMenuItem
            // 
            this.misafirGirişiToolStripMenuItem.Name = "misafirGirişiToolStripMenuItem";
            this.misafirGirişiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.misafirGirişiToolStripMenuItem.Text = "Misafir Girişi";
            this.misafirGirişiToolStripMenuItem.Click += new System.EventHandler(this.misafirGirişiToolStripMenuItem_Click);
            // 
            // odaToolStripMenuItem
            // 
            this.odaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odalarToolStripMenuItem});
            this.odaToolStripMenuItem.Name = "odaToolStripMenuItem";
            this.odaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.odaToolStripMenuItem.Text = "Oda";
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odalarToolStripMenuItem.Text = "Odalar";
            this.odalarToolStripMenuItem.Click += new System.EventHandler(this.odalarToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Otomasyonu-EMRE KARA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem misafirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misafirGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
    }
}
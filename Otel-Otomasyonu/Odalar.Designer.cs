namespace Otel_Otomasyonu
{
    partial class Odalar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BosOdalar = new System.Windows.Forms.ListView();
            this.DoluOdalar = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DoluOdalar);
            this.groupBox1.Controls.Add(this.BosOdalar);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odalar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BosOdalar
            // 
            this.BosOdalar.Location = new System.Drawing.Point(7, 30);
            this.BosOdalar.Name = "BosOdalar";
            this.BosOdalar.Size = new System.Drawing.Size(378, 360);
            this.BosOdalar.TabIndex = 0;
            this.BosOdalar.UseCompatibleStateImageBehavior = false;
            // 
            // DoluOdalar
            // 
            this.DoluOdalar.Location = new System.Drawing.Point(425, 30);
            this.DoluOdalar.Name = "DoluOdalar";
            this.DoluOdalar.Size = new System.Drawing.Size(378, 360);
            this.DoluOdalar.TabIndex = 1;
            this.DoluOdalar.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Boş Odalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dolu Odalar";
            // 
            // Odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "Odalar";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.Odalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DoluOdalar;
        private System.Windows.Forms.ListView BosOdalar;
    }
}
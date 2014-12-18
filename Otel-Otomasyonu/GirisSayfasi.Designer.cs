namespace Otel_Otomasyonu
{
    partial class GirisSayfasi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Temizle = new System.Windows.Forms.Button();
            this.Giris = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Personel Yönetici Girişi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 53);
            this.label3.TabIndex = 14;
            // 
            // Sifre
            // 
            this.Sifre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sifre.Location = new System.Drawing.Point(116, 108);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(201, 20);
            this.Sifre.TabIndex = 1;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.KullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KullaniciAdi.Location = new System.Drawing.Point(116, 65);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(201, 20);
            this.KullaniciAdi.TabIndex = 0;
            this.KullaniciAdi.TextChanged += new System.EventHandler(this.KullaniciAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Temizle
            // 
            this.Temizle.Location = new System.Drawing.Point(116, 140);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(92, 23);
            this.Temizle.TabIndex = 3;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            this.Giris.Location = new System.Drawing.Point(225, 140);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(92, 23);
            this.Giris.TabIndex = 2;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 172);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.Giris);
            this.Name = "GirisSayfasi";
            this.Text = "Turizm Otel Giriş";
            this.Load += new System.EventHandler(this.GirisSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox KullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Giris;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
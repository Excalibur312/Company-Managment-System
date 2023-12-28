namespace loginScreen
{
    partial class MailGönder
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
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtİçerik = new System.Windows.Forms.TextBox();
            this.txtAlıcı = new System.Windows.Forms.TextBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblBaşlık = new System.Windows.Forms.Label();
            this.lblAlıcı = new System.Windows.Forms.Label();
            this.lblİçerik = new System.Windows.Forms.Label();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnGönder = new loginScreen.CustomBtn();
            this.btnGeri = new loginScreen.CustomBtn();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(113, 36);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 22);
            this.txtBaslik.TabIndex = 0;
            // 
            // txtİçerik
            // 
            this.txtİçerik.Location = new System.Drawing.Point(113, 178);
            this.txtİçerik.Multiline = true;
            this.txtİçerik.Name = "txtİçerik";
            this.txtİçerik.Size = new System.Drawing.Size(634, 160);
            this.txtİçerik.TabIndex = 1;
            // 
            // txtAlıcı
            // 
            this.txtAlıcı.Location = new System.Drawing.Point(113, 78);
            this.txtAlıcı.Name = "txtAlıcı";
            this.txtAlıcı.Size = new System.Drawing.Size(100, 22);
            this.txtAlıcı.TabIndex = 2;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(113, 123);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartman.TabIndex = 3;
            // 
            // lblBaşlık
            // 
            this.lblBaşlık.AutoSize = true;
            this.lblBaşlık.Location = new System.Drawing.Point(12, 36);
            this.lblBaşlık.Name = "lblBaşlık";
            this.lblBaşlık.Size = new System.Drawing.Size(44, 16);
            this.lblBaşlık.TabIndex = 6;
            this.lblBaşlık.Text = "Başlık";
            // 
            // lblAlıcı
            // 
            this.lblAlıcı.AutoSize = true;
            this.lblAlıcı.Location = new System.Drawing.Point(13, 78);
            this.lblAlıcı.Name = "lblAlıcı";
            this.lblAlıcı.Size = new System.Drawing.Size(32, 16);
            this.lblAlıcı.TabIndex = 7;
            this.lblAlıcı.Text = "Alıcı";
            // 
            // lblİçerik
            // 
            this.lblİçerik.AutoSize = true;
            this.lblİçerik.Location = new System.Drawing.Point(17, 178);
            this.lblİçerik.Name = "lblİçerik";
            this.lblİçerik.Size = new System.Drawing.Size(39, 16);
            this.lblİçerik.TabIndex = 8;
            this.lblİçerik.Text = "İçerik";
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(543, 30);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(56, 16);
            this.lblKullanıcı.TabIndex = 9;
            this.lblKullanıcı.Text = "Kullanıcı";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(13, 123);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(74, 16);
            this.lblDepartman.TabIndex = 10;
            this.lblDepartman.Text = "Departman";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(621, 30);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 22);
            this.txtKullanici.TabIndex = 11;
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGönder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGönder.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnGönder.BorderRadius = 40;
            this.btnGönder.BorderSize = 0;
            this.btnGönder.FlatAppearance.BorderSize = 0;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGönder.ForeColor = System.Drawing.Color.White;
            this.btnGönder.Location = new System.Drawing.Point(274, 355);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(229, 65);
            this.btnGönder.TabIndex = 13;
            this.btnGönder.Text = "Maili Gönder";
            this.btnGönder.TextdColor = System.Drawing.Color.White;
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeri.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnGeri.BorderRadius = 34;
            this.btnGeri.BorderSize = 0;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(652, 393);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 34);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextdColor = System.Drawing.Color.White;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // MailGönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.lblİçerik);
            this.Controls.Add(this.lblAlıcı);
            this.Controls.Add(this.lblBaşlık);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.txtAlıcı);
            this.Controls.Add(this.txtİçerik);
            this.Controls.Add(this.txtBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailGönder";
            this.Text = "MailGönder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtİçerik;
        private System.Windows.Forms.TextBox txtAlıcı;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblBaşlık;
        private System.Windows.Forms.Label lblAlıcı;
        private System.Windows.Forms.Label lblİçerik;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.TextBox txtKullanici;
        private CustomBtn btnGönder;
        private CustomBtn btnGeri;
    }
}
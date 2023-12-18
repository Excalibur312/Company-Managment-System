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
            this.btnGönder = new System.Windows.Forms.Button();
            this.lblBaşlık = new System.Windows.Forms.Label();
            this.lblAlıcı = new System.Windows.Forms.Label();
            this.lblİçerik = new System.Windows.Forms.Label();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(113, 65);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(100, 22);
            this.txtBaslik.TabIndex = 0;
            // 
            // txtİçerik
            // 
            this.txtİçerik.Location = new System.Drawing.Point(113, 198);
            this.txtİçerik.Multiline = true;
            this.txtİçerik.Name = "txtİçerik";
            this.txtİçerik.Size = new System.Drawing.Size(634, 160);
            this.txtİçerik.TabIndex = 1;
            // 
            // txtAlıcı
            // 
            this.txtAlıcı.Location = new System.Drawing.Point(113, 109);
            this.txtAlıcı.Name = "txtAlıcı";
            this.txtAlıcı.Size = new System.Drawing.Size(100, 22);
            this.txtAlıcı.TabIndex = 2;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(113, 157);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartman.TabIndex = 3;
            // 
            // btnGönder
            // 
            this.btnGönder.Location = new System.Drawing.Point(287, 364);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(75, 23);
            this.btnGönder.TabIndex = 5;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // lblBaşlık
            // 
            this.lblBaşlık.AutoSize = true;
            this.lblBaşlık.Location = new System.Drawing.Point(13, 68);
            this.lblBaşlık.Name = "lblBaşlık";
            this.lblBaşlık.Size = new System.Drawing.Size(44, 16);
            this.lblBaşlık.TabIndex = 6;
            this.lblBaşlık.Text = "Başlık";
            // 
            // lblAlıcı
            // 
            this.lblAlıcı.AutoSize = true;
            this.lblAlıcı.Location = new System.Drawing.Point(13, 112);
            this.lblAlıcı.Name = "lblAlıcı";
            this.lblAlıcı.Size = new System.Drawing.Size(32, 16);
            this.lblAlıcı.TabIndex = 7;
            this.lblAlıcı.Text = "Alıcı";
            // 
            // lblİçerik
            // 
            this.lblİçerik.AutoSize = true;
            this.lblİçerik.Location = new System.Drawing.Point(13, 204);
            this.lblİçerik.Name = "lblİçerik";
            this.lblİçerik.Size = new System.Drawing.Size(39, 16);
            this.lblİçerik.TabIndex = 8;
            this.lblİçerik.Text = "İçerik";
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(541, 65);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(56, 16);
            this.lblKullanıcı.TabIndex = 9;
            this.lblKullanıcı.Text = "Kullanıcı";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(12, 165);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(74, 16);
            this.lblDepartman.TabIndex = 10;
            this.lblDepartman.Text = "Departman";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(634, 65);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 22);
            this.txtKullanici.TabIndex = 11;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(659, 397);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // MailGönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.lblİçerik);
            this.Controls.Add(this.lblAlıcı);
            this.Controls.Add(this.lblBaşlık);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.txtAlıcı);
            this.Controls.Add(this.txtİçerik);
            this.Controls.Add(this.txtBaslik);
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
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.Label lblBaşlık;
        private System.Windows.Forms.Label lblAlıcı;
        private System.Windows.Forms.Label lblİçerik;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Button btnGeri;
    }
}
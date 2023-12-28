namespace loginScreen
{
    partial class İş_Listesi
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
            this.listBYapılacaklar = new System.Windows.Forms.ListBox();
            this.listBDevam = new System.Windows.Forms.ListBox();
            this.listBBiten = new System.Windows.Forms.ListBox();
            this.lblYapılacakİşler = new System.Windows.Forms.Label();
            this.lblDEİşler = new System.Windows.Forms.Label();
            this.lblBitenİşler = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtboxIş = new System.Windows.Forms.TextBox();
            this.btnBitir = new loginScreen.CustomBtn();
            this.btnBaşlat = new loginScreen.CustomBtn();
            this.btnEkle = new loginScreen.CustomBtn();
            this.cmbSelectedDepartment = new System.Windows.Forms.ComboBox();
            this.btnGeri = new loginScreen.CustomBtn();
            this.btnZRaporu = new loginScreen.CustomBtn();
            this.SuspendLayout();
            // 
            // listBYapılacaklar
            // 
            this.listBYapılacaklar.FormattingEnabled = true;
            this.listBYapılacaklar.HorizontalScrollbar = true;
            this.listBYapılacaklar.ItemHeight = 16;
            this.listBYapılacaklar.Location = new System.Drawing.Point(16, 118);
            this.listBYapılacaklar.Name = "listBYapılacaklar";
            this.listBYapılacaklar.Size = new System.Drawing.Size(218, 84);
            this.listBYapılacaklar.TabIndex = 0;
            // 
            // listBDevam
            // 
            this.listBDevam.FormattingEnabled = true;
            this.listBDevam.ItemHeight = 16;
            this.listBDevam.Location = new System.Drawing.Point(300, 118);
            this.listBDevam.Name = "listBDevam";
            this.listBDevam.Size = new System.Drawing.Size(207, 84);
            this.listBDevam.TabIndex = 1;
            // 
            // listBBiten
            // 
            this.listBBiten.FormattingEnabled = true;
            this.listBBiten.ItemHeight = 16;
            this.listBBiten.Location = new System.Drawing.Point(537, 118);
            this.listBBiten.Name = "listBBiten";
            this.listBBiten.Size = new System.Drawing.Size(238, 84);
            this.listBBiten.TabIndex = 2;
            // 
            // lblYapılacakİşler
            // 
            this.lblYapılacakİşler.AutoSize = true;
            this.lblYapılacakİşler.Location = new System.Drawing.Point(115, 79);
            this.lblYapılacakİşler.Name = "lblYapılacakİşler";
            this.lblYapılacakİşler.Size = new System.Drawing.Size(96, 16);
            this.lblYapılacakİşler.TabIndex = 3;
            this.lblYapılacakİşler.Text = "Yapılacak İşler";
            // 
            // lblDEİşler
            // 
            this.lblDEİşler.AutoSize = true;
            this.lblDEİşler.Location = new System.Drawing.Point(366, 79);
            this.lblDEİşler.Name = "lblDEİşler";
            this.lblDEİşler.Size = new System.Drawing.Size(114, 16);
            this.lblDEİşler.TabIndex = 4;
            this.lblDEİşler.Text = "Devam Eden İşler";
            // 
            // lblBitenİşler
            // 
            this.lblBitenİşler.AutoSize = true;
            this.lblBitenİşler.Location = new System.Drawing.Point(596, 79);
            this.lblBitenİşler.Name = "lblBitenİşler";
            this.lblBitenİşler.Size = new System.Drawing.Size(65, 16);
            this.lblBitenİşler.TabIndex = 5;
            this.lblBitenİşler.Text = "Biten İşler";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(90, 32);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartment.TabIndex = 9;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(534, 3);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(59, 16);
            this.lblKullanıcı.TabIndex = 10;
            this.lblKullanıcı.Text = "Kullanıcı:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(599, 3);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 22);
            this.txtKullanici.TabIndex = 11;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(13, 35);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 16);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.Text = "Departman:";
            // 
            // txtboxIş
            // 
            this.txtboxIş.Location = new System.Drawing.Point(16, 285);
            this.txtboxIş.Multiline = true;
            this.txtboxIş.Name = "txtboxIş";
            this.txtboxIş.Size = new System.Drawing.Size(146, 82);
            this.txtboxIş.TabIndex = 17;
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnBitir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnBitir.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnBitir.BorderRadius = 40;
            this.btnBitir.BorderSize = 0;
            this.btnBitir.FlatAppearance.BorderSize = 0;
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitir.ForeColor = System.Drawing.Color.White;
            this.btnBitir.Location = new System.Drawing.Point(463, 208);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(150, 40);
            this.btnBitir.TabIndex = 16;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.TextdColor = System.Drawing.Color.White;
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnBaşlat
            // 
            this.btnBaşlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnBaşlat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnBaşlat.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnBaşlat.BorderRadius = 40;
            this.btnBaşlat.BorderSize = 0;
            this.btnBaşlat.FlatAppearance.BorderSize = 0;
            this.btnBaşlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaşlat.ForeColor = System.Drawing.Color.White;
            this.btnBaşlat.Location = new System.Drawing.Point(202, 208);
            this.btnBaşlat.Name = "btnBaşlat";
            this.btnBaşlat.Size = new System.Drawing.Size(150, 40);
            this.btnBaşlat.TabIndex = 15;
            this.btnBaşlat.Text = "Başlat";
            this.btnBaşlat.TextdColor = System.Drawing.Color.White;
            this.btnBaşlat.UseVisualStyleBackColor = false;
            this.btnBaşlat.Click += new System.EventHandler(this.btnBaşlat_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnEkle.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnEkle.BorderRadius = 40;
            this.btnEkle.BorderSize = 0;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(12, 384);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(150, 40);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextdColor = System.Drawing.Color.White;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbSelectedDepartment
            // 
            this.cmbSelectedDepartment.FormattingEnabled = true;
            this.cmbSelectedDepartment.Location = new System.Drawing.Point(16, 255);
            this.cmbSelectedDepartment.Name = "cmbSelectedDepartment";
            this.cmbSelectedDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbSelectedDepartment.TabIndex = 18;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeri.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnGeri.BorderRadius = 30;
            this.btnGeri.BorderSize = 0;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(688, 394);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 30);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextdColor = System.Drawing.Color.White;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnZRaporu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnZRaporu.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnZRaporu.BorderRadius = 40;
            this.btnZRaporu.BorderSize = 0;
            this.btnZRaporu.FlatAppearance.BorderSize = 0;
            this.btnZRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZRaporu.ForeColor = System.Drawing.Color.White;
            this.btnZRaporu.Location = new System.Drawing.Point(168, 384);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(150, 40);
            this.btnZRaporu.TabIndex = 20;
            this.btnZRaporu.Text = "Z Raporu";
            this.btnZRaporu.TextdColor = System.Drawing.Color.White;
            this.btnZRaporu.UseVisualStyleBackColor = false;
            this.btnZRaporu.Click += new System.EventHandler(this.btnZRaporu_Click);
            // 
            // İş_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cmbSelectedDepartment);
            this.Controls.Add(this.txtboxIş);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBaşlat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblBitenİşler);
            this.Controls.Add(this.lblDEİşler);
            this.Controls.Add(this.lblYapılacakİşler);
            this.Controls.Add(this.listBBiten);
            this.Controls.Add(this.listBDevam);
            this.Controls.Add(this.listBYapılacaklar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "İş_Listesi";
            this.Text = "İş_Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBYapılacaklar;
        private System.Windows.Forms.ListBox listBDevam;
        private System.Windows.Forms.ListBox listBBiten;
        private System.Windows.Forms.Label lblYapılacakİşler;
        private System.Windows.Forms.Label lblDEİşler;
        private System.Windows.Forms.Label lblBitenİşler;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblDepartment;
        private CustomBtn btnEkle;
        private CustomBtn btnBaşlat;
        private CustomBtn btnBitir;
        private System.Windows.Forms.TextBox txtboxIş;
        private System.Windows.Forms.ComboBox cmbSelectedDepartment;
        private CustomBtn btnGeri;
        private CustomBtn btnZRaporu;
    }
}
namespace CompanyManagmentSystem
{
    partial class ikincilekran
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
            this.btnIseAlim = new System.Windows.Forms.Button();
            this.btnMailOku = new System.Windows.Forms.Button();
            this.btnMailYaz = new System.Windows.Forms.Button();
            this.btnMailDcm = new System.Windows.Forms.Button();
            this.btnBilgilendirme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYönetim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIseAlim
            // 
            this.btnIseAlim.Location = new System.Drawing.Point(12, 56);
            this.btnIseAlim.Name = "btnIseAlim";
            this.btnIseAlim.Size = new System.Drawing.Size(75, 23);
            this.btnIseAlim.TabIndex = 0;
            this.btnIseAlim.Text = "İşe Alım";
            this.btnIseAlim.UseVisualStyleBackColor = true;
            this.btnIseAlim.Click += new System.EventHandler(this.btnIseAlim_Click);
            // 
            // btnMailOku
            // 
            this.btnMailOku.Location = new System.Drawing.Point(13, 185);
            this.btnMailOku.Name = "btnMailOku";
            this.btnMailOku.Size = new System.Drawing.Size(127, 25);
            this.btnMailOku.TabIndex = 1;
            this.btnMailOku.Text = "Mailleri Göster";
            this.btnMailOku.UseVisualStyleBackColor = true;
            this.btnMailOku.Click += new System.EventHandler(this.btnMailOku_Click);
            // 
            // btnMailYaz
            // 
            this.btnMailYaz.Location = new System.Drawing.Point(13, 134);
            this.btnMailYaz.Name = "btnMailYaz";
            this.btnMailYaz.Size = new System.Drawing.Size(127, 24);
            this.btnMailYaz.TabIndex = 2;
            this.btnMailYaz.Text = "Mail Gönder";
            this.btnMailYaz.UseVisualStyleBackColor = true;
            this.btnMailYaz.Click += new System.EventHandler(this.btnMailYaz_Click);
            // 
            // btnMailDcm
            // 
            this.btnMailDcm.Location = new System.Drawing.Point(13, 239);
            this.btnMailDcm.Name = "btnMailDcm";
            this.btnMailDcm.Size = new System.Drawing.Size(127, 24);
            this.btnMailDcm.TabIndex = 3;
            this.btnMailDcm.Text = "Mailleri Pdfleştir";
            this.btnMailDcm.UseVisualStyleBackColor = true;
            this.btnMailDcm.Click += new System.EventHandler(this.btnMailDcm_Click);
            // 
            // btnBilgilendirme
            // 
            this.btnBilgilendirme.Location = new System.Drawing.Point(12, 301);
            this.btnBilgilendirme.Name = "btnBilgilendirme";
            this.btnBilgilendirme.Size = new System.Drawing.Size(127, 23);
            this.btnBilgilendirme.TabIndex = 4;
            this.btnBilgilendirme.Text = "Bilgilendirme";
            this.btnBilgilendirme.UseVisualStyleBackColor = true;
            this.btnBilgilendirme.Click += new System.EventHandler(this.btnBilgilendirme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(12, 344);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 31);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYönetim
            // 
            this.btnYönetim.Location = new System.Drawing.Point(14, 94);
            this.btnYönetim.Name = "btnYönetim";
            this.btnYönetim.Size = new System.Drawing.Size(126, 23);
            this.btnYönetim.TabIndex = 6;
            this.btnYönetim.Text = "Eleman Yönetimi";
            this.btnYönetim.UseVisualStyleBackColor = true;
            this.btnYönetim.Click += new System.EventHandler(this.btnYönetim_Click);
            // 
            // ikincilekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYönetim);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBilgilendirme);
            this.Controls.Add(this.btnMailDcm);
            this.Controls.Add(this.btnMailYaz);
            this.Controls.Add(this.btnMailOku);
            this.Controls.Add(this.btnIseAlim);
            this.Name = "ikincilekran";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnIseAlim;
        private System.Windows.Forms.Button btnMailOku;
        private System.Windows.Forms.Button btnMailYaz;
        private System.Windows.Forms.Button btnMailDcm;
        private System.Windows.Forms.Button btnBilgilendirme;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYönetim;
    }
}


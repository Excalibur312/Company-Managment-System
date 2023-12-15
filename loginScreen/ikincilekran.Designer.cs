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
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIseAlim
            // 
            this.btnIseAlim.Location = new System.Drawing.Point(12, 30);
            this.btnIseAlim.Name = "btnIseAlim";
            this.btnIseAlim.Size = new System.Drawing.Size(75, 23);
            this.btnIseAlim.TabIndex = 0;
            this.btnIseAlim.Text = "İşe Alım";
            this.btnIseAlim.UseVisualStyleBackColor = true;
            this.btnIseAlim.Click += new System.EventHandler(this.btnIseAlim_Click);
            // 
            // btnMailOku
            // 
            this.btnMailOku.Location = new System.Drawing.Point(12, 75);
            this.btnMailOku.Name = "btnMailOku";
            this.btnMailOku.Size = new System.Drawing.Size(127, 25);
            this.btnMailOku.TabIndex = 1;
            this.btnMailOku.Text = "Mailleri Göster";
            this.btnMailOku.UseVisualStyleBackColor = true;
            // 
            // btnMailYaz
            // 
            this.btnMailYaz.Location = new System.Drawing.Point(12, 119);
            this.btnMailYaz.Name = "btnMailYaz";
            this.btnMailYaz.Size = new System.Drawing.Size(127, 24);
            this.btnMailYaz.TabIndex = 2;
            this.btnMailYaz.Text = "Mail Gönder";
            this.btnMailYaz.UseVisualStyleBackColor = true;
            // 
            // btnMailDcm
            // 
            this.btnMailDcm.Location = new System.Drawing.Point(12, 171);
            this.btnMailDcm.Name = "btnMailDcm";
            this.btnMailDcm.Size = new System.Drawing.Size(127, 24);
            this.btnMailDcm.TabIndex = 3;
            this.btnMailDcm.Text = "Mailleri Pdfleştir";
            this.btnMailDcm.UseVisualStyleBackColor = true;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(12, 219);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(75, 23);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(12, 270);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 31);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ikincilekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAyarlar);
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
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;
    }
}


namespace loginScreen
{
    partial class Bilgilendirme
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
            this.lblhaberleşme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblİnternetSitesi = new System.Windows.Forms.LinkLabel();
            this.btnGeri = new loginScreen.CustomBtn();
            this.SuspendLayout();
            // 
            // lblhaberleşme
            // 
            this.lblhaberleşme.AutoSize = true;
            this.lblhaberleşme.BackColor = System.Drawing.Color.Transparent;
            this.lblhaberleşme.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhaberleşme.Location = new System.Drawing.Point(198, 9);
            this.lblhaberleşme.Name = "lblhaberleşme";
            this.lblhaberleşme.Size = new System.Drawing.Size(283, 91);
            this.lblhaberleşme.TabIndex = 1;
            this.lblhaberleşme.Text = "Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(208, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tel:        0266 717 0117";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(208, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faks:     0 266 717 00 30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(208, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-Posta:    kurumsaliletisim@bandirma.edu.tr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(208, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "KEP:        bandirmaonyedieylul@hs01.kep.tr";
            // 
            // lblİnternetSitesi
            // 
            this.lblİnternetSitesi.AutoSize = true;
            this.lblİnternetSitesi.BackColor = System.Drawing.Color.Transparent;
            this.lblİnternetSitesi.Location = new System.Drawing.Point(211, 282);
            this.lblİnternetSitesi.Name = "lblİnternetSitesi";
            this.lblİnternetSitesi.Size = new System.Drawing.Size(85, 16);
            this.lblİnternetSitesi.TabIndex = 6;
            this.lblİnternetSitesi.TabStop = true;
            this.lblİnternetSitesi.Text = "Ulaşım Sitesi";
            this.lblİnternetSitesi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblİnternetSitesi_LinkClicked);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeri.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnGeri.BorderRadius = 40;
            this.btnGeri.BorderSize = 0;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(601, 345);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(150, 40);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextdColor = System.Drawing.Color.White;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Bilgilendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 456);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblİnternetSitesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhaberleşme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bilgilendirme";
            this.Text = "Bilgilendirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblhaberleşme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblİnternetSitesi;
        private CustomBtn btnGeri;
    }
}
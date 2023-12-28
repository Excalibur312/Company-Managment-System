namespace loginScreen
{
    partial class gizliSoru
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
            this.lblGizliSoruC = new System.Windows.Forms.Label();
            this.BtnGizliBlrl = new loginScreen.CustomBtn();
            this.BtnGeriG = new loginScreen.CustomBtn();
            this.txtCevapBelirle = new System.Windows.Forms.TextBox();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGizliSoruC
            // 
            this.lblGizliSoruC.AutoSize = true;
            this.lblGizliSoruC.BackColor = System.Drawing.Color.Transparent;
            this.lblGizliSoruC.Location = new System.Drawing.Point(308, 141);
            this.lblGizliSoruC.Name = "lblGizliSoruC";
            this.lblGizliSoruC.Size = new System.Drawing.Size(164, 16);
            this.lblGizliSoruC.TabIndex = 0;
            this.lblGizliSoruC.Text = "Gizli Cevabınızı Belirleyiniz";
            // 
            // BtnGizliBlrl
            // 
            this.BtnGizliBlrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.BtnGizliBlrl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.BtnGizliBlrl.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.BtnGizliBlrl.BorderRadius = 20;
            this.BtnGizliBlrl.BorderSize = 0;
            this.BtnGizliBlrl.FlatAppearance.BorderSize = 0;
            this.BtnGizliBlrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGizliBlrl.ForeColor = System.Drawing.Color.White;
            this.BtnGizliBlrl.Location = new System.Drawing.Point(327, 241);
            this.BtnGizliBlrl.Name = "BtnGizliBlrl";
            this.BtnGizliBlrl.Size = new System.Drawing.Size(119, 29);
            this.BtnGizliBlrl.TabIndex = 1;
            this.BtnGizliBlrl.Text = "Belirle";
            this.BtnGizliBlrl.TextdColor = System.Drawing.Color.White;
            this.BtnGizliBlrl.UseVisualStyleBackColor = false;
            this.BtnGizliBlrl.Click += new System.EventHandler(this.BtnGizliBlrl_Click);
            // 
            // BtnGeriG
            // 
            this.BtnGeriG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.BtnGeriG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.BtnGeriG.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.BtnGeriG.BorderRadius = 30;
            this.BtnGeriG.BorderSize = 0;
            this.BtnGeriG.FlatAppearance.BorderSize = 0;
            this.BtnGeriG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeriG.ForeColor = System.Drawing.Color.White;
            this.BtnGeriG.Location = new System.Drawing.Point(643, 406);
            this.BtnGeriG.Name = "BtnGeriG";
            this.BtnGeriG.Size = new System.Drawing.Size(128, 32);
            this.BtnGeriG.TabIndex = 2;
            this.BtnGeriG.Text = "Geri";
            this.BtnGeriG.TextdColor = System.Drawing.Color.White;
            this.BtnGeriG.UseVisualStyleBackColor = false;
            this.BtnGeriG.Click += new System.EventHandler(this.BtnGeriG_Click);
            // 
            // txtCevapBelirle
            // 
            this.txtCevapBelirle.Location = new System.Drawing.Point(311, 182);
            this.txtCevapBelirle.Name = "txtCevapBelirle";
            this.txtCevapBelirle.Size = new System.Drawing.Size(157, 22);
            this.txtCevapBelirle.TabIndex = 3;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Location = new System.Drawing.Point(38, 29);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(56, 16);
            this.lblKullanici.TabIndex = 4;
            this.lblKullanici.Text = "Kullanıcı";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(100, 23);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(100, 22);
            this.txtKullanici.TabIndex = 5;
            // 
            // gizliSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.txtCevapBelirle);
            this.Controls.Add(this.BtnGeriG);
            this.Controls.Add(this.BtnGizliBlrl);
            this.Controls.Add(this.lblGizliSoruC);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gizliSoru";
            this.Text = "gizliSoru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGizliSoruC;
        private CustomBtn BtnGizliBlrl;
        private CustomBtn BtnGeriG;
        private System.Windows.Forms.TextBox txtCevapBelirle;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtKullanici;
    }
}
namespace CompanyManagmentSystem
{
    partial class forgetpassword
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.btnSifreyiDegistir = new loginScreen.CustomBtn();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Location = new System.Drawing.Point(72, 25);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(64, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Kullanıcı Adı";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblYeniSifre.Location = new System.Drawing.Point(72, 94);
            this.lblYeniSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(52, 13);
            this.lblYeniSifre.TabIndex = 3;
            this.lblYeniSifre.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(75, 121);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(144, 20);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // btnSifreyiDegistir
            // 
            this.btnSifreyiDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnSifreyiDegistir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnSifreyiDegistir.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnSifreyiDegistir.BorderRadius = 31;
            this.btnSifreyiDegistir.BorderSize = 0;
            this.btnSifreyiDegistir.FlatAppearance.BorderSize = 0;
            this.btnSifreyiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreyiDegistir.ForeColor = System.Drawing.Color.White;
            this.btnSifreyiDegistir.Location = new System.Drawing.Point(71, 170);
            this.btnSifreyiDegistir.Name = "btnSifreyiDegistir";
            this.btnSifreyiDegistir.Size = new System.Drawing.Size(150, 31);
            this.btnSifreyiDegistir.TabIndex = 5;
            this.btnSifreyiDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreyiDegistir.TextdColor = System.Drawing.Color.White;
            this.btnSifreyiDegistir.UseVisualStyleBackColor = false;
            this.btnSifreyiDegistir.Click += new System.EventHandler(this.btnSifreyiDegistir_Click);
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(319, 231);
            this.Controls.Add(this.btnSifreyiDegistir);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "forgetpassword";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private loginScreen.CustomBtn btnSifreyiDegistir;
    }
}
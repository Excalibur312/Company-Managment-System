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
            this.btnSifreyiDegistir = new System.Windows.Forms.Button();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Location = new System.Drawing.Point(73, 26);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(64, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Kullanıcı Adı";
            // 
            // btnSifreyiDegistir
            // 
            this.btnSifreyiDegistir.Location = new System.Drawing.Point(265, 238);
            this.btnSifreyiDegistir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSifreyiDegistir.Name = "btnSifreyiDegistir";
            this.btnSifreyiDegistir.Size = new System.Drawing.Size(56, 19);
            this.btnSifreyiDegistir.TabIndex = 2;
            this.btnSifreyiDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreyiDegistir.UseVisualStyleBackColor = true;
            this.btnSifreyiDegistir.Click += new System.EventHandler(this.btnSifreyiDegistir_Click_1);
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblYeniSifre.Location = new System.Drawing.Point(75, 106);
            this.lblYeniSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(52, 13);
            this.lblYeniSifre.TabIndex = 3;
            this.lblYeniSifre.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(77, 132);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(76, 20);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 284);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.btnSifreyiDegistir);
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
        private System.Windows.Forms.Button btnSifreyiDegistir;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
    }
}
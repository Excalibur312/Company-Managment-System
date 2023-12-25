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
            this.textBox1.Location = new System.Drawing.Point(100, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(97, 32);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(79, 16);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Kullanıcı Adı";
            // 
            // btnSifreyiDegistir
            // 
            this.btnSifreyiDegistir.Location = new System.Drawing.Point(353, 293);
            this.btnSifreyiDegistir.Name = "btnSifreyiDegistir";
            this.btnSifreyiDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnSifreyiDegistir.TabIndex = 2;
            this.btnSifreyiDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreyiDegistir.UseVisualStyleBackColor = true;
            this.btnSifreyiDegistir.Click += new System.EventHandler(this.btnSifreyiDegistir_Click_1);
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(100, 130);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(64, 16);
            this.lblYeniSifre.TabIndex = 3;
            this.lblYeniSifre.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(103, 162);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 22);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.btnSifreyiDegistir);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.textBox1);
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
namespace loginScreen
{
    partial class MailleriDökümante
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GönderilenMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alıcı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Başlık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mailpdfbtn = new loginScreen.CustomBtn();
            this.btnGeriMail = new loginScreen.CustomBtn();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departmanı Seç";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(199, 253);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartment.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GönderilenMail,
            this.username,
            this.Alıcı,
            this.Departman,
            this.Başlık});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 144);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // GönderilenMail
            // 
            this.GönderilenMail.Text = "Gönderilen Mail";
            this.GönderilenMail.Width = 109;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 100;
            // 
            // Alıcı
            // 
            this.Alıcı.Text = "Alıcı";
            this.Alıcı.Width = 105;
            // 
            // Departman
            // 
            this.Departman.Text = "Departman";
            this.Departman.Width = 114;
            // 
            // Başlık
            // 
            this.Başlık.Text = "Başlık";
            this.Başlık.Width = 111;
            // 
            // mailpdfbtn
            // 
            this.mailpdfbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.mailpdfbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.mailpdfbtn.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.mailpdfbtn.BorderRadius = 37;
            this.mailpdfbtn.BorderSize = 0;
            this.mailpdfbtn.FlatAppearance.BorderSize = 0;
            this.mailpdfbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailpdfbtn.ForeColor = System.Drawing.Color.White;
            this.mailpdfbtn.Location = new System.Drawing.Point(199, 322);
            this.mailpdfbtn.Name = "mailpdfbtn";
            this.mailpdfbtn.Size = new System.Drawing.Size(121, 37);
            this.mailpdfbtn.TabIndex = 6;
            this.mailpdfbtn.Text = "İndir";
            this.mailpdfbtn.TextdColor = System.Drawing.Color.White;
            this.mailpdfbtn.UseVisualStyleBackColor = false;
            this.mailpdfbtn.Click += new System.EventHandler(this.mailpdfbtn_Click);
            // 
            // btnGeriMail
            // 
            this.btnGeriMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeriMail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnGeriMail.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnGeriMail.BorderRadius = 29;
            this.btnGeriMail.BorderSize = 0;
            this.btnGeriMail.FlatAppearance.BorderSize = 0;
            this.btnGeriMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriMail.ForeColor = System.Drawing.Color.White;
            this.btnGeriMail.Location = new System.Drawing.Point(543, 379);
            this.btnGeriMail.Name = "btnGeriMail";
            this.btnGeriMail.Size = new System.Drawing.Size(134, 34);
            this.btnGeriMail.TabIndex = 7;
            this.btnGeriMail.Text = "Geri";
            this.btnGeriMail.TextdColor = System.Drawing.Color.White;
            this.btnGeriMail.UseVisualStyleBackColor = false;
            this.btnGeriMail.Click += new System.EventHandler(this.btnGeriMail_Click);
            // 
            // MailleriDökümante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeriMail);
            this.Controls.Add(this.mailpdfbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailleriDökümante";
            this.Text = "MailleriDökümante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader GönderilenMail;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader Alıcı;
        private System.Windows.Forms.ColumnHeader Departman;
        private System.Windows.Forms.ColumnHeader Başlık;
        private CustomBtn mailpdfbtn;
        private CustomBtn btnGeriMail;
    }
}
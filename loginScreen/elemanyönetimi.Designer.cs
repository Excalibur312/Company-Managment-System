namespace loginScreen
{
    partial class ElemanYönetimi
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
            this.listElemanlar = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Authority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorityLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblYetkinlik = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbAuthority = new System.Windows.Forms.ComboBox();
            this.cmbauthoritylevel = new System.Windows.Forms.ComboBox();
            this.cmbDepartmanlevel = new System.Windows.Forms.ComboBox();
            this.customBtn3 = new loginScreen.CustomBtn();
            this.customBtn2 = new loginScreen.CustomBtn();
            this.customBtn1 = new loginScreen.CustomBtn();
            this.btnS = new loginScreen.CustomBtn();
            this.btnG = new loginScreen.CustomBtn();
            this.SuspendLayout();
            // 
            // listElemanlar
            // 
            this.listElemanlar.BackColor = System.Drawing.Color.White;
            this.listElemanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.name,
            this.surname,
            this.password,
            this.Department,
            this.Authority,
            this.AuthorityLevel});
            this.listElemanlar.HideSelection = false;
            this.listElemanlar.Location = new System.Drawing.Point(12, 35);
            this.listElemanlar.Name = "listElemanlar";
            this.listElemanlar.Size = new System.Drawing.Size(776, 199);
            this.listElemanlar.TabIndex = 0;
            this.listElemanlar.UseCompatibleStateImageBehavior = false;
            this.listElemanlar.View = System.Windows.Forms.View.Details;
            // 
            // username
            // 
            this.username.Text = "Kullanıcı Adı";
            this.username.Width = 103;
            // 
            // name
            // 
            this.name.Text = "İsim";
            // 
            // surname
            // 
            this.surname.Text = "Soyisim";
            this.surname.Width = 110;
            // 
            // password
            // 
            this.password.Text = "Şifre";
            this.password.Width = 73;
            // 
            // Department
            // 
            this.Department.Text = "Departman";
            this.Department.Width = 127;
            // 
            // Authority
            // 
            this.Authority.Text = "Yetkinlik";
            this.Authority.Width = 131;
            // 
            // AuthorityLevel
            // 
            this.AuthorityLevel.Text = "Yetkinlik Seviyesi";
            this.AuthorityLevel.Width = 159;
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(34, 261);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(79, 16);
            this.lblKullanıcıAdı.TabIndex = 1;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.BackColor = System.Drawing.Color.Transparent;
            this.lblİsim.Location = new System.Drawing.Point(152, 261);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(31, 16);
            this.lblİsim.TabIndex = 2;
            this.lblİsim.Text = "İsim";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyisim.Location = new System.Drawing.Point(258, 261);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(55, 16);
            this.lblSoyisim.TabIndex = 3;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.BackColor = System.Drawing.Color.Transparent;
            this.lblŞifre.Location = new System.Drawing.Point(347, 261);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(34, 16);
            this.lblŞifre.TabIndex = 4;
            this.lblŞifre.Text = "Şifre";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartman.Location = new System.Drawing.Point(451, 261);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(74, 16);
            this.lblDepartman.TabIndex = 5;
            this.lblDepartman.Text = "Departman";
            // 
            // lblYetkinlik
            // 
            this.lblYetkinlik.AutoSize = true;
            this.lblYetkinlik.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkinlik.Location = new System.Drawing.Point(580, 261);
            this.lblYetkinlik.Name = "lblYetkinlik";
            this.lblYetkinlik.Size = new System.Drawing.Size(57, 16);
            this.lblYetkinlik.TabIndex = 6;
            this.lblYetkinlik.Text = "Yetkinlik";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(28, 289);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsername.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(350, 289);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(84, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(239, 289);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(86, 22);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(146, 289);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(70, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(454, 286);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(97, 24);
            this.cmbDepartment.TabIndex = 12;
            // 
            // cmbAuthority
            // 
            this.cmbAuthority.FormattingEnabled = true;
            this.cmbAuthority.Location = new System.Drawing.Point(583, 287);
            this.cmbAuthority.Name = "cmbAuthority";
            this.cmbAuthority.Size = new System.Drawing.Size(121, 24);
            this.cmbAuthority.TabIndex = 13;
            // 
            // cmbauthoritylevel
            // 
            this.cmbauthoritylevel.FormattingEnabled = true;
            this.cmbauthoritylevel.Location = new System.Drawing.Point(583, 328);
            this.cmbauthoritylevel.Name = "cmbauthoritylevel";
            this.cmbauthoritylevel.Size = new System.Drawing.Size(121, 24);
            this.cmbauthoritylevel.TabIndex = 14;
            this.cmbauthoritylevel.Visible = false;
            // 
            // cmbDepartmanlevel
            // 
            this.cmbDepartmanlevel.Enabled = false;
            this.cmbDepartmanlevel.FormattingEnabled = true;
            this.cmbDepartmanlevel.Location = new System.Drawing.Point(454, 328);
            this.cmbDepartmanlevel.Name = "cmbDepartmanlevel";
            this.cmbDepartmanlevel.Size = new System.Drawing.Size(97, 24);
            this.cmbDepartmanlevel.TabIndex = 25;
            this.cmbDepartmanlevel.Visible = false;
            // 
            // customBtn3
            // 
            this.customBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.customBtn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.customBtn3.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.customBtn3.BorderRadius = 40;
            this.customBtn3.BorderSize = 0;
            this.customBtn3.FlatAppearance.BorderSize = 0;
            this.customBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn3.ForeColor = System.Drawing.Color.White;
            this.customBtn3.Location = new System.Drawing.Point(416, 403);
            this.customBtn3.Name = "customBtn3";
            this.customBtn3.Size = new System.Drawing.Size(150, 40);
            this.customBtn3.TabIndex = 24;
            this.customBtn3.Text = "Bilgileri Dosyalaştır";
            this.customBtn3.TextdColor = System.Drawing.Color.White;
            this.customBtn3.UseVisualStyleBackColor = false;
            this.customBtn3.Click += new System.EventHandler(this.customBtn3_Click);
            // 
            // customBtn2
            // 
            this.customBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.customBtn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.customBtn2.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.customBtn2.BorderRadius = 40;
            this.customBtn2.BorderSize = 0;
            this.customBtn2.FlatAppearance.BorderSize = 0;
            this.customBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn2.ForeColor = System.Drawing.Color.White;
            this.customBtn2.Location = new System.Drawing.Point(583, 403);
            this.customBtn2.Name = "customBtn2";
            this.customBtn2.Size = new System.Drawing.Size(150, 40);
            this.customBtn2.TabIndex = 23;
            this.customBtn2.Text = "Geri";
            this.customBtn2.TextdColor = System.Drawing.Color.White;
            this.customBtn2.UseVisualStyleBackColor = false;
            this.customBtn2.Click += new System.EventHandler(this.customBtn2_Click);
            // 
            // customBtn1
            // 
            this.customBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.customBtn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.customBtn1.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.customBtn1.BorderRadius = 40;
            this.customBtn1.BorderSize = 0;
            this.customBtn1.FlatAppearance.BorderSize = 0;
            this.customBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBtn1.ForeColor = System.Drawing.Color.White;
            this.customBtn1.Location = new System.Drawing.Point(132, 328);
            this.customBtn1.Name = "customBtn1";
            this.customBtn1.Size = new System.Drawing.Size(150, 40);
            this.customBtn1.TabIndex = 22;
            this.customBtn1.Text = "Kullanıcıyı Getir";
            this.customBtn1.TextdColor = System.Drawing.Color.White;
            this.customBtn1.UseVisualStyleBackColor = false;
            this.customBtn1.Click += new System.EventHandler(this.customBtn1_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnS.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnS.BorderRadius = 40;
            this.btnS.BorderSize = 0;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Location = new System.Drawing.Point(231, 403);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(150, 40);
            this.btnS.TabIndex = 21;
            this.btnS.Text = "Sil";
            this.btnS.TextdColor = System.Drawing.Color.White;
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.btnG.BorderCoIor = System.Drawing.Color.PaleVioletRed;
            this.btnG.BorderRadius = 40;
            this.btnG.BorderSize = 0;
            this.btnG.FlatAppearance.BorderSize = 0;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.ForeColor = System.Drawing.Color.White;
            this.btnG.Location = new System.Drawing.Point(51, 404);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(150, 40);
            this.btnG.TabIndex = 20;
            this.btnG.Text = "Güncelle";
            this.btnG.TextdColor = System.Drawing.Color.White;
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // ElemanYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 488);
            this.Controls.Add(this.cmbDepartmanlevel);
            this.Controls.Add(this.customBtn3);
            this.Controls.Add(this.customBtn2);
            this.Controls.Add(this.customBtn1);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.cmbauthoritylevel);
            this.Controls.Add(this.cmbAuthority);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblYetkinlik);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblİsim);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.listElemanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ElemanYönetimi";
            this.Text = "ElemanYönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listElemanlar;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Authority;
        private System.Windows.Forms.ColumnHeader AuthorityLevel;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblYetkinlik;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.ComboBox cmbauthoritylevel;
        private CustomBtn btnG;
        private CustomBtn btnS;
        private CustomBtn customBtn1;
        private CustomBtn customBtn2;
        private CustomBtn customBtn3;
        private System.Windows.Forms.ComboBox cmbDepartmanlevel;
    }
}
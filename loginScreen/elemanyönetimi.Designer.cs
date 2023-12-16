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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbAuthority = new System.Windows.Forms.ComboBox();
            this.cmbauthoritylevel = new System.Windows.Forms.ComboBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTabloIndir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listElemanlar
            // 
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
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(34, 261);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(79, 16);
            this.lblKullanıcıAdı.TabIndex = 1;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(152, 261);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(31, 16);
            this.lblİsim.TabIndex = 2;
            this.lblİsim.Text = "İsim";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(258, 261);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(55, 16);
            this.lblSoyisim.TabIndex = 3;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Location = new System.Drawing.Point(347, 261);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(34, 16);
            this.lblŞifre.TabIndex = 4;
            this.lblŞifre.Text = "Şifre";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(451, 261);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(74, 16);
            this.lblDepartman.TabIndex = 5;
            this.lblDepartman.Text = "Departman";
            // 
            // lblYetkinlik
            // 
            this.lblYetkinlik.AutoSize = true;
            this.lblYetkinlik.Location = new System.Drawing.Point(580, 261);
            this.lblYetkinlik.Name = "lblYetkinlik";
            this.lblYetkinlik.Size = new System.Drawing.Size(57, 16);
            this.lblYetkinlik.TabIndex = 6;
            this.lblYetkinlik.Text = "Yetkinlik";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 289);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 289);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(70, 22);
            this.textBox5.TabIndex = 11;
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
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(37, 403);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(146, 25);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(146, 374);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(149, 23);
            this.btnGetir.TabIndex = 16;
            this.btnGetir.Text = "Kullanıcıyı Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(229, 404);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(605, 403);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(99, 23);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTabloIndir
            // 
            this.btnTabloIndir.Location = new System.Drawing.Point(400, 403);
            this.btnTabloIndir.Name = "btnTabloIndir";
            this.btnTabloIndir.Size = new System.Drawing.Size(151, 23);
            this.btnTabloIndir.TabIndex = 19;
            this.btnTabloIndir.Text = "Bilgileri Dosyalaştır";
            this.btnTabloIndir.UseVisualStyleBackColor = true;
            // 
            // ElemanYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabloIndir);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.cmbauthoritylevel);
            this.Controls.Add(this.cmbAuthority);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblYetkinlik);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblİsim);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.listElemanlar);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.ComboBox cmbauthoritylevel;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTabloIndir;
    }
}
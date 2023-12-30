namespace loginScreen
{
    partial class MailleriOku
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
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAlıcı = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.User_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kişi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Konu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alan Kişi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(40, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departman";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(75, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "İçerik";
            // 
            // cmbAlıcı
            // 
            this.cmbAlıcı.FormattingEnabled = true;
            this.cmbAlıcı.Location = new System.Drawing.Point(120, 87);
            this.cmbAlıcı.Name = "cmbAlıcı";
            this.cmbAlıcı.Size = new System.Drawing.Size(159, 24);
            this.cmbAlıcı.TabIndex = 16;
            this.cmbAlıcı.SelectedIndexChanged += new System.EventHandler(this.cmbAlıcı_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User_Name,
            this.Kişi,
            this.Departman,
            this.Konu,
            this.Mail});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(120, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 314);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // User_Name
            // 
            this.User_Name.Text = "Kişi Adı";
            this.User_Name.Width = 87;
            // 
            // Kişi
            // 
            this.Kişi.Text = "Gönderen Kişi";
            this.Kişi.Width = 104;
            // 
            // Departman
            // 
            this.Departman.Text = "Departman";
            this.Departman.Width = 93;
            // 
            // Konu
            // 
            this.Konu.Text = "Başlık";
            this.Konu.Width = 99;
            // 
            // Mail
            // 
            this.Mail.DisplayIndex = 0;
            this.Mail.Text = "Mail";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(120, 57);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(159, 24);
            this.cmbDepartment.TabIndex = 18;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.lUserName.ForeColor = System.Drawing.Color.White;
            this.lUserName.Location = new System.Drawing.Point(597, 20);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(56, 16);
            this.lUserName.TabIndex = 19;
            this.lUserName.Text = "Kullanıcı";
            // 
            // MailleriOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::loginScreen.Properties.Resources.mini_sceen_Çalışma_Yüzeyi_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbAlıcı);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailleriOku";
            this.Text = "MailleriOku";
            this.Load += new System.EventHandler(this.MailleriOku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAlıcı;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Kişi;
        private System.Windows.Forms.ColumnHeader User_Name;
        private System.Windows.Forms.ColumnHeader Departman;
        private System.Windows.Forms.ColumnHeader Konu;
    }
}
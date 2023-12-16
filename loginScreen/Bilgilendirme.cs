// loginScreen/Bilgilendirme.cs dosyası

using CompanyManagmentSystem;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class Bilgilendirme : Form
    {
     
        public Bilgilendirme()
        { 
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
     
            this.Close();
        }

        private void lblİnternetSitesi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string websiteUrl = "https://www.bandirma.edu.tr/tr/www/Iletisim";

            Process.Start(websiteUrl);
        }
    }
}

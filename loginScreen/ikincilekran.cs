using loginScreen;
using System;
using System.Windows.Forms;

namespace CompanyManagmentSystem
{
    public partial class ikincilekran : Form
    {
        public string connectionString = "Data Source=192.168.18.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;"; public string username;
        public int authority;

        public ikincilekran(string username, int authority)
        {
            InitializeComponent();
            this.username = username;
            this.authority = authority;
            UpdateButtonBasedOnAuthority();
        }

        public void UpdateButtonBasedOnAuthority()
        {
            MessageBox.Show(authority.ToString());

            switch (authority)
            {
                case 1:
                    // manager
                    btnIseAlim.Visible = true;
                    btnIseAlim.Enabled = true;
                    btnYönetim.Visible = true;
                    btnYönetim.Enabled = true;
                    btnMailDcm.Visible = true;
                    btnMailDcm.Enabled = true;
                    break;
                case 2:
                    // employee
                    btnIseAlim.Visible = false;
                    btnMailDcm.Visible = false;
                    btnYönetim.Visible=false;
                    btnYönetim.Enabled=false;
                    btnIseAlim.Enabled = false;
                    btnMailDcm.Enabled = false;
                    break;
                case 3:
                    // stajyer
                    btnIseAlim.Visible = false;
                    btnIseAlim.Enabled = false;
                    btnYönetim.Visible = false;
                    btnYönetim.Enabled = false;
                    btnMailDcm.Enabled= false;
                    btnMailDcm.Visible= false;
                    break;
                default:
                    btnIseAlim.Visible = true;
                    btnIseAlim.Enabled = true;
                    btnMailDcm .Visible = true;
                    btnMailDcm .Enabled = true;
                    break;
            }
        }

        private void btnIseAlim_Click(object sender, EventArgs e)
        {
            IseAlim IseAlimSec = new IseAlim();
            IseAlimSec.Show();
        }

       

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 loginSceenForm = new Form1();
            loginSceenForm.Show();
            this.Hide();
        }

        private void btnYönetim_Click(object sender, EventArgs e)
        {
            ElemanYönetimi elemanYönetimiForm = new ElemanYönetimi();
            elemanYönetimiForm.Show();
        }

        private void btnBilgilendirme_Click(object sender, EventArgs e)
        {
            Bilgilendirme bilgilendirmeForm = new Bilgilendirme();
            bilgilendirmeForm.Show();
            
        }

        private void btnMailYaz_Click(object sender, EventArgs e)
        {
            MailGönder mailGönderForm = new MailGönder();
            mailGönderForm.Show();
        }

        private void btnMailOku_Click(object sender, EventArgs e)
        {
            MailleriOku mailleriokuForm = new MailleriOku();
            mailleriokuForm.Show();
        }

        private void btnMailDcm_Click(object sender, EventArgs e)
        {
            MailleriDökümante maillerDökümanteForm = new MailleriDökümante();
            maillerDökümanteForm.Show();
        }
    }
   
}

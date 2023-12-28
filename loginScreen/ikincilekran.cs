using loginScreen;
using System;
using System.Windows.Forms;

namespace CompanyManagmentSystem
{
    public partial class ikincilekran : Form
    {
        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;"; 
        public string username;
        private readonly int authority;
        private readonly int department;

        public ikincilekran(string username, int authority, int department)
        {
            InitializeComponent();
            this.username = username;
            this.authority = authority;
            this.department = department;
            UpdateButtonBasedOnAuthority();
            
        }

        public void UpdateButtonBasedOnAuthority()
        {
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
                    btnYönetim.Visible = true;
                    btnYönetim.Enabled = true;
                    break;
            }
        }
     
        private void btnIseAlim_Click(object sender, EventArgs e)
        {
            IseAlim IseAlimSec = new IseAlim();
            IseAlimSec.Show();
        }

        private void btnYönetim_Click(object sender, EventArgs e)
        {
            ElemanYönetimi elemanYönetimiForm = new ElemanYönetimi();
            elemanYönetimiForm.Show();
        }

        private void btnİşListesi_Click(object sender, EventArgs e)
        {
            İş_Listesi iş_Listesiform = new İş_Listesi(username, authority, department);
            iş_Listesiform.Show();
        }

        private void btnMailYaz_Click(object sender, EventArgs e)
        {
            MailGönder mailGönderForm = new MailGönder(username);
            mailGönderForm.Show();
        }

 
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 loginSceenForm = new Form1();
            loginSceenForm.Show();
            this.Hide();
        }

        private void btnMailDcm_Click(object sender, EventArgs e)
        {
            MailleriDökümante maillerDökümanteForm = new MailleriDökümante();
            maillerDökümanteForm.Show();

        }

        private void btnBilgilendirme_Click(object sender, EventArgs e)
        {
            Bilgilendirme bilgilendirmeform = new Bilgilendirme();
            bilgilendirmeform.Show();
        }

        private void btnMailOku_Click(object sender, EventArgs e)
        {
            MailleriOku mailokuform = new MailleriOku(username, authority,department);
            mailokuform.Show();
        }
    }
   
}

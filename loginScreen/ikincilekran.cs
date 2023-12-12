using System;
using System.Windows.Forms;

namespace CompanyManagmentSystem
{
    public partial class ikincilekran : Form
    {
        public string connectionString = "Data Source=JETAIME;Initial Catalog=CompanyManagment;Integrated Security=True";
        public string username;
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
                    btnMailDcm.Visible = true;
                    btnMailDcm.Enabled = true;
                    break;
                case 2:
                    // employee
                    btnIseAlim.Visible = false;
                    btnMailDcm.Visible = false;
                    btnIseAlim.Enabled = false;
                    btnMailDcm.Enabled = false;
                    break;
                case 3:
                    // stajyer
                    btnIseAlim.Visible = false;
                    btnIseAlim.Enabled = false;
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

    }
}

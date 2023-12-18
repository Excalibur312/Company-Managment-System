using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class MailGönder : Form
    {
        private readonly string username;
        public string connectionString = "Data Source=192.168.18.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public MailGönder(string username)
        {
            this.username = username;
            InitializeComponent();
            txtKullanici.ReadOnly = true;
            txtKullanici.Enabled = false;
            txtKullanici.Text = $"{username}";

            cmbDepartman.Items.Add("Computer Engineering");  
            cmbDepartman.Items.Add("Software Engineering");
            cmbDepartman.Items.Add("Robotics Engineering");
            cmbDepartman.SelectedIndex = -1;
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            string alici = txtAlıcı.Text;
            string baslik = txtBaslik.Text;
            string icerik = txtİçerik.Text;
            string gonderen = txtKullanici.Text;
            string departman = cmbDepartman.SelectedItem?.ToString();

            MailGönderici(alici, baslik, icerik, gonderen, departman);
            MessageBox.Show("Başarıyla Göndeerildi");
            txtAlıcı.Clear();
            txtBaslik.Clear();
            txtİçerik.Clear();
            cmbDepartman.SelectedIndex = -1;
        }

        public void MailGönderici(string alici, string baslik, string icerik, string gonderen, string departman)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Mail (AlınanMail, GönderilenMail, username, Alıcı, Departman, Başlık) " +
                               "VALUES (@AlınanMail, @GonderilenMail, @username, @Alici, @Departman, @Baslik)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AlınanMail", icerik); // Buraya uygun bir veri ekleyin
                    command.Parameters.AddWithValue("@GonderilenMail", icerik);   // Buraya uygun bir veri ekleyin
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Alici", alici);
                    command.Parameters.AddWithValue("@Departman", departman);
                    command.Parameters.AddWithValue("@Baslik", baslik);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

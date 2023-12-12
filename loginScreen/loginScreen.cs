using loginScreen;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CompanyManagmentSystem
{
    public partial class Form1 : Form
    {
        public SqlConnection connection;
        public SqlCommand command;
        public string connectionString = "Data Source=JETAIME;Initial Catalog=CompanyManagment;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public void login_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (ValidateUser(username, password))
            {
                int authority = GetUserAuthority(username);
                MessageBox.Show("Giriş başarılı!");
                ikincilekran ikinciEkranForm = new ikincilekran(username, authority);
                ikinciEkranForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        public bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL sorgusu: Veritabanındaki kullanıcı adı ve şifre kontrolü
                string query = "SELECT COUNT(*) FROM TableDeneme1 WHERE name = @name AND password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0; // Eğer bir eşleşme varsa true, yoksa false döner.
                }
            }
        }

      
        public int GetUserAuthority(string username)
        {
            string query = "SELECT authoritylevel FROM TableDeneme1 WHERE name = @name";

            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.Clear(); // Önceki parametreleri temizle
                command.Parameters.AddWithValue("@name", username);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    // authority sütunu bir sayı olmalı, doğrudan int'e dönüştürülebilir
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public void forgetpassword_Click(object sender, EventArgs e)
        {
            //ikincilekran ikinciEkranForm = new ikincilekran(username, authority);
            forgetpassword forgetpasswordForm = new forgetpassword();
            forgetpasswordForm.Show();
        }
    }
}

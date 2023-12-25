using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CompanyManagmentSystem
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
        private readonly string userFilePath = "C:\\Users\\Emre KAYA\\Desktop\\Company-Managment-System-main\\loginScreen\\Hatırlayıcı\\username.txt";

        public Form1()
        {
            InitializeComponent();
            string storedUsername = ReadUsernameFromFile();

            if (!string.IsNullOrEmpty(storedUsername))
            {
                txtusername.Text = storedUsername;
                // Şifreyi hatırlamamak için şifre alanını temizleme gerekmez
                checkHatırla.Checked = true;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            bool rememberMe = checkHatırla.Checked; // CheckBox durumunu kontrol et

            if (rememberMe)
            {
                SaveUsernameToFile(username);
            }
            else
            {
                // "Beni Hatırla" seçili değilse dosyayı sil
                DeleteUsernameFile();
            }

            if (ValidateUser(username, password))
            {
                int authority = GetUserAuthority(username);
                int department = GetUserDepartment(username);
                MessageBox.Show("Giriş başarılı!");
                ikincilekran ikinciEkranForm = new ikincilekran(username, authority, department);
                ikinciEkranForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

   
        private void SaveUsernameToFile(string username)
        {
            try
            {
                File.WriteAllText(userFilePath, username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private string ReadUsernameFromFile()
        {
            try
            {
                if (File.Exists(userFilePath))
                {
                    return File.ReadAllText(userFilePath);
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return null;
            }
        }

        private void DeleteUsernameFile()
        {
            try
            {
                if (File.Exists(userFilePath))
                {
                    File.Delete(userFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM UserTable WHERE username = @username AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private int GetUserDepartment(string username)
        {
            string query = "SELECT departmentlevel FROM UserTable WHERE username = @username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        object sonuc = command.ExecuteScalar();

                        return sonuc != null && sonuc != DBNull.Value ? Convert.ToInt32(sonuc) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return 0;
            }
        }

        private int GetUserAuthority(string username)
        {
            string query = "SELECT authoritylevel FROM UserTable WHERE username = @username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        object result = command.ExecuteScalar();

                        return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return 0;
            }
        }

        private void forgetpassword_Click(object sender, EventArgs e)
        {
            forgetpassword forgetpasswordForm = new forgetpassword();
            forgetpasswordForm.Show();
        }
    }
}

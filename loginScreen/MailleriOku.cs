using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace loginScreen
{
    public partial class MailleriOku : Form
    {
        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public string username;
        private readonly int authority;
        private readonly int department;
        public int numberD = 0;

        public MailleriOku(string username, int authority, int department)
        {
            InitializeComponent();
            this.username = username;
            this.authority = authority;
            this.department = department;

            this.Load += MailleriOku_Load;


            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            cmbAlıcı.SelectedIndexChanged += cmbAlıcı_SelectedIndexChanged;



        }

        public void DepartmentsByUsername(string username)
        {
            // SQL sorgusu: Belirli kullanıcı adına göre department sütununu al
            string query = "SELECT department FROM UserTable WHERE username = @username";

            // SQL bağlantısı ve komut oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleme
                    command.Parameters.AddWithValue("@username", username);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string department = reader["department"].ToString();

                            // Department değerlerini karşılaştır
                            if (department == "Computer")
                            {
                                numberD = 1;
                            }
                            else if (department == "Software")
                            {
                                numberD = 2;
                            }
                            else if (department == "Robotic")
                            {
                                numberD = 3;
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı belirtilen departmanlardan birinde çalışmıyor.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        // ComboBox ve ListView nesnelerini temizleyen metot
        private void ResetControls()
        {
            // ComboBox'ı temizleme
            cmbDepartment.Items.Clear();
            cmbAlıcı.Items.Clear();

            // ListView'i temizleme
            listView1.Items.Clear();
        }

        public void AddOnlyUser()
        {
            cmbDepartment.Items.Add(this.department);
            cmbAlıcı.Items.Add(this.username);
        }

        public void LabelUserName()
        {
            lUserName.Text = "Kullanıcı: " + this.username;
        }


        public void AddDepartments()
        {
            // SQL sorgusu
            cmbDepartment.Items.Add("Computer");
            cmbDepartment.Items.Add("Software");
            cmbDepartment.Items.Add("Robotic");
        }

        public void AddDepartmentComputer()
        {

            // SQL sorgusu - department = 'computer' olan verileri seçiyoruz
            string query = "SELECT username FROM UserTable WHERE department = 'Computer'"; // Tablo ve sütun adlarını değiştirmelisiniz

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // ComboBox'a verileri ekleme
                        cmbAlıcı.Items.Add(reader["username"].ToString()); // Sütun adını değiştirmelisiniz
                    }

                    connection.Close();
                }
            }
        }

        public void AddDepartmentSoftware()
        {
            string query = "SELECT username FROM UserTable WHERE department = 'Software'"; // Tablo ve sütun adlarını değiştirmelisiniz

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // ComboBox'a verileri ekleme
                        cmbAlıcı.Items.Add(reader["username"].ToString()); // Sütun adını değiştirmelisiniz
                    }

                    connection.Close();
                }
            }
        }

        public void AddDepartmentRobotic()
        {
            string query = "SELECT username FROM UserTable WHERE department = 'Robotic'"; // Tablo ve sütun adlarını değiştirmelisiniz

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // ComboBox'a verileri ekleme
                        cmbAlıcı.Items.Add(reader["username"].ToString()); // Sütun adını değiştirmelisiniz
                    }

                    connection.Close();
                }
            }
        }

        private void MailleriOku_Load(object sender, EventArgs e)
        {
            LabelUserName();
            DepartmentsByUsername(username);
            ResetControls();

            switch (authority)
            {
                case 1:
                    // manager
                    AddDepartments();

                    MessageBox.Show("You are Manager");
                    break;

                case 2:

                    if (this.department == 1) 
                    {
                        if(numberD == 1)
                        {
                            // ComboBox'a varsayılan metni ekleyin
                            cmbDepartment.Items.Add("Computer");

                            // Varsayılan metni seçilemez yapmak için
                            cmbDepartment.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez

                            AddDepartmentComputer();
                            MessageBox.Show("You are Manager but access is restricted");
                        }
                        else if (numberD == 2)
                        {
                            // ComboBox'a varsayılan metni ekleyin
                            cmbDepartment.Items.Add("Software");

                            // Varsayılan metni seçilemez yapmak için
                            cmbDepartment.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez

                            AddDepartmentSoftware();
                            MessageBox.Show("You are Manager but access is restricted");
                        }
                        else
                        {
                            // ComboBox'a varsayılan metni ekleyin
                            cmbDepartment.Items.Add("Robotic");

                            // Varsayılan metni seçilemez yapmak için
                            cmbDepartment.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez

                            AddDepartmentRobotic();
                            MessageBox.Show("You are Manager but access is restricted");
                        }
                    }
                    else
                    {
                        AddOnlyUser();

                        // ComboBox'a varsayılan metni ekleyin
                        cmbDepartment.Items.Add(this.department);

                        // Varsayılan metni seçilemez yapmak için
                        cmbDepartment.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                        cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez

                        // ComboBox'a varsayılan metni ekleyin
                        cmbAlıcı.Items.Add(this.username);

                        // Varsayılan metni seçilemez yapmak için
                        cmbAlıcı.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                        cmbAlıcı.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez

                        MessageBox.Show("Your level is very low (inside)");
                    }
                    break;

                case 3:

                    AddOnlyUser();

                    // ComboBox'a varsayılan metni ekleyin
                    cmbDepartment.Items.Add(this.department);

                    // Varsayılan metni seçilemez yapmak için
                    cmbDepartment.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                    cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez
                                                                          // ComboBox'a varsayılan metni ekleyin
                    cmbAlıcı.Items.Add(this.username);

                    // Varsayılan metni seçilemez yapmak için
                    cmbAlıcı.SelectedIndex = 0; // Varsayılan metni seçili hale getirir
                    cmbAlıcı.DropDownStyle = ComboBoxStyle.DropDownList; // Kullanıcı tarafından değiştirilemez

                    MessageBox.Show("Your level is very low");

                    break;

                default:

                    AddDepartmentComputer();
                    AddDepartmentRobotic();
                    AddDepartmentSoftware();

                    MessageBox.Show("Switch-Case Default");

                    break;
            }

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = cmbDepartment.SelectedItem.ToString();

            // İkinci ComboBox'taki öğeleri temizleyelim
            cmbAlıcı.Items.Clear();

            // Seçilen departmana göre pozisyonları ekleyelim
            if (selectedDepartment == "Computer")
            {
                AddDepartmentComputer();
            }
            else if (selectedDepartment == "Software")
            {
                AddDepartmentSoftware();
            }
            else if (selectedDepartment == "Robotic")
            {
                AddDepartmentRobotic();
            }
            // Diğer departmanlar için gerekli durumlar buraya eklenebilir
        }

        private void cmbAlıcı_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUsername = cmbAlıcı.SelectedItem.ToString();

            string query = "SELECT Username, Alici, Departman, Baslik, GönderilenMail FROM Mail WHERE Username = @Username"; // Tablo ve sütun adlarınıza göre değiştirin

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(query, connection);

                // Parametre ekleyin
                cmd.Parameters.AddWithValue("@Username", selectedUsername);

                // Veritabanı bağlantısını açın
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // ListView temizle
                    listView1.Items.Clear();

                    // Veri okunduğu sürece işlem yapın
                    while (reader.Read())
                    {
                        // Okunan verileri alın
                        
                        string userName = reader["Username"].ToString();
                        string alıcı = reader["Alici"].ToString();
                        string departman = reader["Departman"].ToString();
                        string baslık = reader["Baslik"].ToString();
                        string message = reader["GönderilenMail"].ToString();

                        // ListView'e ekleme yapın
                        ListViewItem item = new ListViewItem(new[] { userName, alıcı, departman, baslık, message });
                        listView1.Items.Add(item);
                    }
                }

                connection.Close();
            }
        }
    }
}

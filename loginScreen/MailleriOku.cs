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
                            if (department == "computer")
                            {
                                numberD = 1;
                            }
                            else if (department == "software")
                            {
                                numberD = 2;
                            }
                            else if (department == "robotic")
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

        public void AddDepartments()
        {
            // SQL sorgusu
            string query = "SELECT department FROM UserTable"; // Tablo ve sütun adlarını değiştirmelisiniz

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // ComboBox'a verileri ekleme
                        cmbDepartment.Items.Add(reader["depatrment"].ToString()); // Sütun adını değiştirmelisiniz
                    }

                    connection.Close();
                }
            }
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

        public void ChangeComboBox() 
        { 

        }

        private void MailleriOku_Load(object sender, EventArgs e)
        {
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
                            AddDepartmentComputer();
                            MessageBox.Show("You are Manager but access is restricted");
                        }
                        else if (numberD == 2)
                        {
                            AddDepartmentSoftware();
                            MessageBox.Show("You are Manager but access is restricted");
                        }
                        else
                        {
                            AddDepartmentRobotic();
                            MessageBox.Show("You are Manager but access is restricted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your level is very low (inside)");
                    }
                    break;

                case 3:

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
            string selectedItem = cmbAlıcı.SelectedItem.ToString();

            // ListView'i temizleme
            listViewEmployees.Items.Clear();

            // Seçili departmana göre ListView'i güncelleme
            foreach (ListViewItem item in listViewEmployees.Items)
            {
                if (item.SubItems[2].Text == selectedItem)
                {
                    listViewEmployees.Items.Add((ListViewItem)item.Clone());
                }
            }
        }
    }
}


/*
 
private void FetchEmailsAndMessages(string username)
{
    try
    {
        using (SqlConnection sqlConnection = new SqlConnection("Your_Connection_String"))
        {
            sqlConnection.Open();
            string query = "SELECT Email, Message FROM YourTableName WHERE Username = @Username";
            
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Username", username);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Email"].ToString());
                item.SubItems.Add(dr["Message"].ToString());
                listView1.Items.Add(item);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

/////
///////
///

private void YourButton_Click(object sender, EventArgs e)
{
    string username = "desired_username"; // İlgili kullanıcı adını burada belirtin

    // Belirtilen kullanıcı adına göre e-posta ve mesajları getir
    FetchEmailsAndMessages(username);
}

*/




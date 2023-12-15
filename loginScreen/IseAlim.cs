using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginScreen
{
    public partial class IseAlim : Form
    {

        public SqlConnection connection;
        public SqlCommand command;
        private List<string> comboBoxAuthorityItems = new List<string> { "Manager", "Employee", "Intern"};

        private List<string> comboBoxDepartmentsItems = new List<string> { "Computer Engineering", "Robotics Engineering", "Software Engineering" };

        private Dictionary<string, List<string>> comboBoxAuthorityLevelItems = new Dictionary<string, List<string>>()
        {
            { "Manager", new List<string> { "1"} },
            { "Employee", new List<string> { "2"} },
            { "Intern", new List<string> { "3" } }

        };

        public string connectionString = "Data Source=172.16.23.125;Initial Catalog=CompanyManagment;User ID=Fevzi;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
        public IseAlim()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            comboBoxAuthority.DataSource= comboBoxAuthorityItems;
            comboBoxDepartment.DataSource= comboBoxDepartmentsItems;


        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO UserTable (name, surname, username, password, department, authority, authoritylevel) VALUES (@name, @surname, @username, @password, @department, @authority, @authoritylevel)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    command.Parameters.AddWithValue("@department", comboBoxDepartment.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@authority", comboBoxAuthority.SelectedItem.ToString());

                    command.Parameters.AddWithValue("@authoritylevel", comboBoxAuthorityLevel.SelectedItem.ToString());

                    int rowsAffected = command.ExecuteNonQuery();

                    textBoxName.Text = " ";
                    textBoxSurname.Text = " ";
                    textBoxUsername.Text = " ";
                    textBoxPassword.Text = " ";


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Veritabanına kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("Kaydetme işlemi başarısız oldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void comboBoxAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                // İlk ComboBox'taki öğe değiştikçe, ikinci ComboBox'ı güncelle
                string selectedOption = comboBoxAuthority.SelectedItem.ToString();

                // İkinci ComboBox'ı seçilen öğeye göre doldur
                if (comboBoxAuthorityLevelItems.ContainsKey(selectedOption))
                {
                comboBoxAuthorityLevel.DataSource = comboBoxAuthorityLevelItems[selectedOption];
                }
        
        }
    }
}
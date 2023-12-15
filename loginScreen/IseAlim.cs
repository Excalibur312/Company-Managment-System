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
        public string connectionString = "Data Source=172.16.23.125;Initial Catalog=CompanyManagment;User ID=Fevzi;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
        public IseAlim()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;

            object[] departments = new object[] { "Computer Engineer", "Robotic Engineer", "Software Engineer" };
            comboBoxDepartment.Items.AddRange(departments);

            object[] authorities = new object[] { "Manager", "Intern", "Employee" };
            comboBoxAuthority.Items.AddRange(authorities);

            object[] authoritiesLevels = new object[] { "0", "1", "2" };
            comboBoxAuthorityLevel.Items.AddRange(authoritiesLevels);

        }

        private void button1_Click(object sender, EventArgs e)
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
                    comboBoxDepartment.SelectedIndex = -1;
                    comboBoxAuthority.SelectedIndex = -1;
                    comboBoxAuthorityLevel.SelectedIndex = -1;
                    

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
    }
}

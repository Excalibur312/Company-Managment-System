using CompanyManagmentSystem;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class IseAlim : Form
    {
        public SqlConnection connection;
        public SqlCommand command;
        public List<string> comboBoxAuthorityItems = new List<string> { "Manager", "Employee", "Intern" };
        public List<string> comboBoxDepartmentsItems = new List<string> { "Computer Engineering", "Robotics Engineering", "Software Engineering" };
        public List<string> comboBoxAuthoirtItems = new List<string> { "1", "2", "3" };

        public string connectionString = "Data Source=192.168.18.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public IseAlim()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;

            comboBoxAuthority.DataSource = comboBoxAuthorityItems;
            comboBoxDepartment.DataSource = comboBoxDepartmentsItems;

            // Do not set DataSource for comboBoxAuthorityLevel
            comboBoxAuthorityLevel.Items.AddRange(comboBoxAuthoirtItems.ToArray());

            // Add event handler for authority selection change
            comboBoxAuthority.SelectedIndexChanged += comboBoxAuthority_SelectedIndexChanged;
        }

        private void comboBoxAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxAuthority.SelectedItem;

            comboBoxAuthorityLevel.Items.Clear();

            switch (selectedItem)
            {
                case "Manager":
                    comboBoxAuthorityLevel.Items.AddRange(new object[] { "1" });
                    break;
                case "Employee":
                    comboBoxAuthorityLevel.Items.AddRange(new object[] { "2" });
                    break;
                case "Intern":
                    comboBoxAuthorityLevel.Items.AddRange(new object[] { "3" });
                    break;
                default:
                    break;
            }

            if (comboBoxAuthorityLevel.Items.Count > 0)
                comboBoxAuthorityLevel.SelectedIndex = 0;
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

                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";

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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

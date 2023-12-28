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
        public List<string> comboBoxDepartmentsItems = new List<string> { "Computer", "Robotics", "Software" };
        public List<string> comboBoxAuthoirtItems = new List<string> { "1", "2", "3" };
        public List<string> comboBoxDepartmentsLevelItems = new List<string> { "1", "2", "3" };

        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

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
            comboBoxDepartmentLevel.Items.AddRange(comboBoxDepartmentsLevelItems.ToArray());

            // Add event handler for authority selection change
            comboBoxAuthority.SelectedIndexChanged += comboBoxAuthority_SelectedIndexChanged;
            comboBoxDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxDepartment.SelectedItem;

            comboBoxDepartmentLevel.Items.Clear();

            switch (selectedItem)
            {
                case "Computer":
                    comboBoxDepartmentLevel.Items.AddRange(new object[] { "1" });
                    break;
                case "Software":
                    comboBoxDepartmentLevel.Items.AddRange(new object[] { "2" });
                    break;
                case "Robotics":
                    comboBoxDepartmentLevel.Items.AddRange(new object[] { "3" });
                    break;
                default:
                    break;
            }

            if (comboBoxDepartmentLevel.Items.Count > 0)
                comboBoxDepartmentLevel.SelectedIndex = 0;
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

     

     

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO UserTable (name, surname, username, password, department, authority, authoritylevel,departmentlevel) VALUES (@name, @surname, @username, @password, @department, @authority, @authoritylevel,@departmentlevel)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    command.Parameters.AddWithValue("@department", comboBoxDepartment.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@authority", comboBoxAuthority.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@authoritylevel", comboBoxAuthorityLevel.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@departmentlevel", comboBoxDepartmentLevel.SelectedItem.ToString());
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

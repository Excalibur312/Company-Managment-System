using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class ElemanYönetimi : Form
    {
        public string connectionString = "Data Source=192.168.18.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
      
        public ElemanYönetimi()
        {
            InitializeComponent();
            Listeleme();
        }
        public void Listeleme()
        {
            string query = "SELECT * FROM UserTable";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                listElemanlar.Items.Clear();
                                while (reader.Read())
                                {
                                    ListViewItem item = new ListViewItem(reader["username"].ToString());
                                    item.SubItems.Add(reader["name"].ToString());
                                    item.SubItems.Add(reader["surname"].ToString());
                                    item.SubItems.Add(reader["password"].ToString());
                                    item.SubItems.Add(reader["department"].ToString());
                                    item.SubItems.Add(reader["authority"].ToString());
                                    item.SubItems.Add(reader["authoritylevel"].ToString());

                                    listElemanlar.Items.Add(item);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veri bulunamadı.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

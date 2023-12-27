using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace loginScreen
{
    public partial class ElemanYönetimi : Form
    {
        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        private SqlConnection connection;
        private SqlCommand command;
        public ElemanYönetimi()
        {
            InitializeComponent();
            Listeleme();

            customBtn1.Click += customBtn1_Click;
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

        private void Güncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbDepartment.Text) ||
                string.IsNullOrWhiteSpace(cmbAuthority.Text) ||
                string.IsNullOrWhiteSpace(cmbauthoritylevel.Text))

                {
                    // TextBox boş ise buraya girecek kod
                    // Örneğin, bir hata mesajı gösterilebilir
                    MessageBox.Show("Can not leave any box blank.");
                    return;

                }

                else
                {

                    SqlCommand command = new SqlCommand("UPDATE UserTable SET name=@name, surname=@surname, username=@username, password=@password, department=@department, authority=@authority, authoritylevel=@authoritylevel WHERE username=" + listElemanlar.SelectedItems[0].Text, connection);
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    command.Parameters.AddWithValue("@department", cmbDepartment.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@authority", cmbAuthority.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@authoritylevel", cmbauthoritylevel.SelectedItem.ToString());

                    int rowsAffected = command.ExecuteNonQuery();

                    try
                    {

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        Listeleme();
                    }
                    catch (SqlException ex)
                    {

                        connection.Close();
                        MessageBox.Show(ex.Message);
                    }

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Veritabanına Güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                    }
                }
            }

        }

        private void customBtn1_Click(object sender, EventArgs e)
        {
            // ListView'da bir sütun seçili mi kontrol et
            if (listElemanlar.SelectedItems.Count > 0)
            {
                // Seçilen sütunun verilerini al
                ListViewItem selectedItem = listElemanlar.SelectedItems[0];

                // Verileri TextBox ve ComboBox'lara yerleştir
                textBoxUsername.Text = selectedItem.SubItems[0].Text;
                textBoxName.Text = selectedItem.SubItems[1].Text;
                textBoxSurname.Text = selectedItem.SubItems[2].Text;
                textBoxPassword.Text = selectedItem.SubItems[3].Text;


                // ComboBox'a seçili departmanı yerleştir
                string depart1 = selectedItem.SubItems[4].Text;
                string depart2 = selectedItem.SubItems[5].Text;
                string depart3 = selectedItem.SubItems[6].Text;

                cmbDepartment.SelectedItem = depart1;
                cmbAuthority.SelectedItem = depart2;
                cmbauthoritylevel.SelectedItem = depart3;
            }
            else
            {
                // Eğer ListView'da bir sütun seçilmediyse kullanıcıya bilgi ver
                MessageBox.Show("Lütfen bir sütun seçin.");
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                foreach (ListViewItem item in listElemanlar.Items)
                {
                    if (item.Selected)
                    {
                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM UserTable WHERE username = " + item.Text, connection);
                        try
                        {

                            connection.Open();
                            sqlCommand.ExecuteNonQuery();
                            connection.Close();
                            Listeleme();
                        }
                        catch (SqlException ex)
                        {

                            connection.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
        }

        private void customBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}

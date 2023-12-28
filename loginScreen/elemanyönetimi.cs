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
        public string connectionString = "Data Source=25.61.180.90;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        private SqlConnection connection;
        private SqlCommand command;
        public ElemanYönetimi()
        {
            InitializeComponent();
            Listeleme();

            customBtn1.Click += customBtn1_Click;

            cmbDepartment.Items.Add("");
            cmbDepartment.Items.Add("Computer");
            cmbDepartment.Items.Add("Software");
            cmbDepartment.Items.Add("Robotic");

            cmbAuthority.Items.Add("");
            cmbAuthority.Items.Add("Manager");
            cmbAuthority.Items.Add("Intern");
            cmbAuthority.Items.Add("Employee");

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
            string selectQuery = "SELECT * FROM UserTable WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", textBoxUsername.Text);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            // Kullanıcı bulunduysa, sütun değerlerini al
                            string name = reader["name"].ToString(); // Örnek olarak "name" sütunu alınıyor
                            string surname = reader["surname"].ToString(); // Örnek olarak "surname" sütunu alınıyor
                            string username = reader["username"].ToString();
                            string password = reader["password"].ToString();
                            string department = reader["department"].ToString();
                            string authority = reader["authority"].ToString();

                            reader.Close();


                            // Yeni değerlerle güncelleme sorgusu oluştur
                            string updateQuery = "UPDATE UserTable SET name = @newName, surname = @newSurname, username = @newUsername, password = @newPassword, department = @newDepartment, authority = @newAuthority WHERE username = @username";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@username", username);

                                updateCommand.Parameters.AddWithValue("@newName", textBoxName.Text); // Yeni isim değeri
                                updateCommand.Parameters.AddWithValue("@newSurname", textBoxSurname.Text); // Yeni soyisim değeri
                                updateCommand.Parameters.AddWithValue("@newUsername", textBoxUsername.Text);
                                updateCommand.Parameters.AddWithValue("@newPassword", textBoxPassword.Text);
                                updateCommand.Parameters.AddWithValue("@newDepartment", cmbDepartment.Text);
                                updateCommand.Parameters.AddWithValue("@newAuthority", cmbAuthority.Text);


                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Veritabanı başarıyla güncellendi.");
                                }
                                else
                                {
                                    MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            Listeleme();
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



            string selectQuery = "SELECT * FROM UserTable WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {

                    if (listElemanlar.SelectedItems.Count > 0)
                    {
                        string selectedUsername = listElemanlar.SelectedItems[0].SubItems[0].Text; // Seçilen öğenin 0'ıncı alt öğesinin metnini al

                        selectCommand.Parameters.AddWithValue("@username", selectedUsername);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = selectCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                // Kullanıcı bulunduysa, sütun değerlerini al
                                string name = reader["name"].ToString(); // Örnek olarak "name" sütunu alınıyor
                                string surname = reader["surname"].ToString(); // Örnek olarak "surname" sütunu alınıyor
                                string username = reader["username"].ToString();
                                string password = reader["password"].ToString();
                                string department = reader["department"].ToString();
                                string authority = reader["authority"].ToString();

                                reader.Close();

                                // Yeni değerlerle güncelleme sorgusu oluştur
                                string deleteQuery = "DELETE FROM UserTable WHERE username = @username";

                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@username", username);

                                    try
                                    {
                                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Veritabanından kullanıcı başarıyla silindi.");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Silinecek kullanıcı bulunamadı veya silme işlemi başarısız oldu.");
                                        }
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    finally
                                    {
                                        connection.Close();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bulunamadı.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    connection.Close();
                    Listeleme();
                }
            }
        }

        private void customBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}

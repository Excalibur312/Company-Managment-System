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

namespace loginScreen
{
    public partial class gizliSoru : Form

    {
        private readonly string username;
        public string connectionString = "Data Source=25.61.180.90;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public gizliSoru(string username)
        {
            InitializeComponent();
            this.username = username;
            txtKullanici.ReadOnly = true;   
            txtKullanici.Text = username;
        }
     
        private void BtnGizliBlrl_Click(object sender, EventArgs e)
        {
            string gizliCevap = txtCevapBelirle.Text;

            // Kullanıcıyı GizliSoru tablosunda kontrol et
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string findUserQuery = "SELECT COUNT(*) FROM GizliSoru WHERE username = @username";
                    using (SqlCommand findUserCommand = new SqlCommand(findUserQuery, connection))
                    {
                        findUserCommand.Parameters.AddWithValue("@username", username);

                        int userCount = (int)findUserCommand.ExecuteScalar();
                        if (userCount > 0)
                        {
                            // Kullanıcı bulundu, cevabı güncelle
                            string updateQuery = "UPDATE GizliSoru SET cevap = @cevap WHERE username = @username";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@cevap", gizliCevap);
                                updateCommand.Parameters.AddWithValue("@username", username);

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Gizli cevap başarıyla güncellendi!");
                                }
                                else
                                {
                                    MessageBox.Show("Gizli cevap güncellenirken bir hata oluştu.");
                                }
                            }
                        }
                        else
                        {
                            // Kullanıcı bulunamadı, yeni kayıt ekle
                            string insertQuery = "INSERT INTO GizliSoru (username, cevap) VALUES (@username, @cevap)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@username", username);
                                insertCommand.Parameters.AddWithValue("@cevap", gizliCevap);

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Yeni kullanıcı ve gizli cevap başarıyla eklendi!");
                                }
                                else
                                {
                                    MessageBox.Show("Yeni kullanıcı ve gizli cevap eklenirken bir hata oluştu.");
                                }
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

        private void BtnGeriG_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


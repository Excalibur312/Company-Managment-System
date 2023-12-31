﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyManagmentSystem
{
    public partial class forgetpassword : Form
    {
        private SqlConnection connection;
        public string connectionString = "Data Source=25.61.180.90;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public forgetpassword()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private bool ResetPassword(string username, string newPassword, string gizliCevap)
        {
            try
            {
                connection.Open();

                // Veritabanında şifreyi güncelle
                string query = "UPDATE UserTable SET password = @password WHERE username = @username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@password", newPassword);
                command.Parameters.AddWithValue("@username", username);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Kullanıcı bulunamadı!");
                    return false;
                }

                // Gizli soru ve cevap kontrolü
                string secretQuery = "SELECT COUNT(*) FROM UserTable WHERE username = @username AND gizlisoru = @gizlisoru";
                SqlCommand secretCommand = new SqlCommand(secretQuery, connection);
                secretCommand.Parameters.AddWithValue("@username", username);
                secretCommand.Parameters.AddWithValue("@gizlisoru", gizliCevap);

                int secretMatchCount = (int)secretCommand.ExecuteScalar();
                if (secretMatchCount == 0)
                {
                    MessageBox.Show("Gizli soru doğrulanamadı!");
                    return false;
                }

                return rowsAffected > 0; // Şifre güncellendi mi kontrolü
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }



        private void btnSifreyiDegistir_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            string newPassword = txtYeniSifre.Text;
            string gizliCevap = txtGizliSoru.Text;  

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve yeni bir şifre girin!");
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Lütfen kullanıcı adını girin!");
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Lütfen yeni bir şifre girin!");
                return;
            }

            if (ResetPassword(username, newPassword, gizliCevap))
            {
                MessageBox.Show("Şifre başarıyla yenilendi!");
            }
            else
            {
                MessageBox.Show("Şifre yenilenirken bir hata oluştu.");
            }
        }

        private void btnGeriF_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

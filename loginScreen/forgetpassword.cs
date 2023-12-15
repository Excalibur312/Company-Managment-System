﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CompanyManagmentSystem
{
    public partial class forgetpassword : Form
    {
        private SqlConnection connection;
        public string connectionString = "Data Source=172.16.23.125;Initial Catalog=CompanyManagment;User ID=Hale;Password=123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        public forgetpassword()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void btnSifreyiDegistir_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string newPassword = txtYeniSifre.Text;

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

            if (ResetPassword(username, newPassword))
            {
                MessageBox.Show("Şifre başarıyla yenilendi!");
            }
            else
            {
                MessageBox.Show("Şifre yenilenirken bir hata oluştu.");
            }
        }

        private bool ResetPassword(string username, string newPassword)
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


    }
}


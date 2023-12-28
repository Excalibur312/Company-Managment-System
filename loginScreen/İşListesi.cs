using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class İş_Listesi : Form
    {
        private readonly string username;
        private readonly int authority;
        private readonly int department;
        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public İş_Listesi(string username, int authority, int department)
        {
            InitializeComponent();
            txtKullanici.ReadOnly = true;
            txtKullanici.Enabled = false;
            txtKullanici.Text = $"{username}";

            cmbDepartment.Items.Add("Computer");
            cmbDepartment.Items.Add("Software");
            cmbDepartment.Items.Add("Robotics");

            cmbSelectedDepartment.Items.Add("Computer");
            cmbSelectedDepartment.Items.Add("Software");
            cmbSelectedDepartment.Items.Add("Robotics");

            this.authority = authority;
            this.department = department;

            UpdateButtonBasedOnAuthority();
            UpdateButtonBasedOnDepartment();
        }

        public void UpdateButtonBasedOnDepartment()
        {
            switch (department)
            {
                case 1:
                    cmbDepartment.SelectedIndex = 0;
                    break;
                case 2:
                    cmbDepartment.SelectedIndex = 1;
                    break;
                case 3:
                    cmbDepartment.SelectedIndex = 2;
                    break;
                default:
                    cmbDepartment.SelectedIndex = 0;
                    break;
            }
        }

        private void FillListBoxes()
        {
            string selectedDepartment = cmbDepartment.SelectedItem as string;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT Yapılacakİşler, Yapılıyorİşler, Bitenİşler FROM İşler WHERE Department = @Department";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Department", selectedDepartment);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listBYapılacaklar.Items.Clear();
                            listBDevam.Items.Clear();
                            listBBiten.Items.Clear();

                            while (reader.Read())
                            {
                                listBYapılacaklar.Items.Add(reader["Yapılacakİşler"].ToString());
                                listBDevam.Items.Add(reader["Yapılıyorİşler"].ToString());
                                listBBiten.Items.Add(reader["Bitenİşler"].ToString());
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedItem != null)
            {
                string selectedDepartment = cmbDepartment.SelectedItem.ToString();
                listBYapılacaklar.Items.Clear();
                listBDevam.Items.Clear();
                listBBiten.Items.Clear();
                FillListBoxes();
            }
        }

        public void UpdateButtonBasedOnAuthority()
        {
            switch (authority)
            {
                case 1:
                    cmbDepartment.Enabled = true;
                    cmbSelectedDepartment.Enabled = true;
                    cmbSelectedDepartment.Visible = true;
                    txtboxIş.Enabled = true;
                    txtboxIş.Visible = true;
                    btnEkle.Enabled = true;
                    btnEkle.Visible = true;
                    btnZRaporu.Enabled = true;
                    btnZRaporu.Visible = true;
                    break;
                case 2:
                    cmbDepartment.Enabled = false;
                    cmbSelectedDepartment.Enabled = false;
                    cmbSelectedDepartment.Visible = false;
                    txtboxIş.Visible = false;
                    txtboxIş.Enabled = false;
                    btnEkle.Visible = false;
                    btnEkle.Enabled = false;
                    btnZRaporu .Visible = false;
                    btnZRaporu.Enabled = false;
                    break;
                case 3:
                    cmbDepartment.Enabled = false;
                    cmbSelectedDepartment.Enabled = false;
                    cmbSelectedDepartment.Visible = false;
                    txtboxIş.Visible = false;
                    txtboxIş.Enabled = false;
                    btnEkle.Visible = false;
                    btnEkle.Enabled = false;
                    btnZRaporu.Visible = false;
                    btnZRaporu.Enabled = false;
                    break;
                default:
                    cmbDepartment.Enabled = false;
                    cmbSelectedDepartment.Enabled = false;
                    cmbSelectedDepartment.Visible = false;
                    txtboxIş.Enabled = false;
                    txtboxIş.Visible = false;
                    btnEkle.Visible = false;
                    btnEkle.Enabled = false;
                    btnZRaporu.Visible = false;
                    btnZRaporu.Enabled = false;
                    break;
            }
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            string iş = txtboxIş.Text;
            string departman = cmbSelectedDepartment.SelectedItem?.ToString();

            MailGönderici(iş, departman);
            MessageBox.Show("Başarıyla İş Eklendi");

            txtboxIş.Clear();
            cmbSelectedDepartment.SelectedIndex = 0;
        }

        public void MailGönderici(string iş, string departman)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO İşler (Yapılacakİşler, Department) VALUES (@Yapılacakİşler, @Department)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Yapılacakİşler", iş);
                        command.Parameters.AddWithValue("@Department", departman);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = listBYapılacaklar.SelectedItems.Cast<string>().ToList();

            foreach (string selectedItem in selectedItems)
            {
                MoveItemToAnotherList(selectedItem, "Yapılacakİşler", "Yapılıyorİşler");
                SaveToDatabaseBaslat();
            }
            FillListBoxes();
        }

        private void SaveToDatabaseBaslat()
        {
            string username = txtKullanici.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ÇalışmaSayısı (username, yapilaniş) VALUES (@Username, @YapilanIs)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@YapilanIs", "devam");

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Veri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void SaveToDatabaseBitir()
        {
            string username = txtKullanici.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ÇalışmaSayısı (username, yapilaniş) VALUES (@Username, @YapilanIs)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@YapilanIs", "bitti");

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Veri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = listBDevam.SelectedItems.Cast<string>().ToList();

            foreach (string selectedItem in selectedItems)
            {
                MoveItemToAnotherList(selectedItem, "Yapılıyorİşler", "Bitenİşler");
                SaveToDatabaseBitir();
            }

        }

        private void MoveItemToAnotherList(string item, string sourceListName, string destinationListName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // İlk olarak, öğeyi kaynaktan hedefe taşı
                    string moveItemQuery = $"UPDATE İşler SET {destinationListName} = ISNULL({destinationListName}, '') + @Item WHERE {sourceListName} = @Item";

                    using (SqlCommand moveItemCommand = new SqlCommand(moveItemQuery, connection))
                    {
                        moveItemCommand.Parameters.AddWithValue("@Item", item);
                        moveItemCommand.ExecuteNonQuery();
                    }

                    // Ardından, öğeyi kaynaktan sil
                    string deleteItemQuery = $"UPDATE İşler SET {sourceListName} = REPLACE({sourceListName}, @Item, '') WHERE {sourceListName} = @Item";

                    using (SqlCommand deleteItemCommand = new SqlCommand(deleteItemQuery, connection))
                    {
                        deleteItemCommand.Parameters.AddWithValue("@Item", item);
                        deleteItemCommand.ExecuteNonQuery();
                    }
                }

                // ListBox'ları güncelle
                FillListBoxes();
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
        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            SaveMailPDF();
        }

        private void SaveMailPDF()
        {
                try
                {
                    // Kullanıcıya kaydetme konumu için iletişim kutusu göster

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "PDF Dosyası|*.pdf";
                    saveFileDialog1.Title = "PDF Olarak Kaydet";
                    saveFileDialog1.ShowDialog();

                    if (saveFileDialog1.FileName != "")
                    {
                        string pdfFileName = saveFileDialog1.FileName;
                        Document pdfDoc = new Document(PageSize.A4);

                        // Başka bir font dosyası kullanarak özel bir font oluşturun
                        BaseFont baseFont = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        Font font = new Font(baseFont);

                        PdfWriter.GetInstance(pdfDoc, new FileStream(pdfFileName, FileMode.Create));
                        pdfDoc.Open();

                        PdfPTable pdfTable = new PdfPTable(2);
                        pdfTable.WidthPercentage = 100;

                        pdfTable.AddCell(new PdfPCell(new Phrase("Kullanıcı Adı", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("Yapılan İş", font)));
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "SELECT username, yapilaniş FROM ÇalışmaSayısı";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["username"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["yapilaniş"].ToString(), font)));
                                   
                                    }
                                }
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();

                        MessageBox.Show($"PDF oluşturuldu ve kaydedildi: {pdfFileName}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }


using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace loginScreen
{
    public partial class MailleriDökümante : Form
    {

        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        public MailleriDökümante()
        {
            InitializeComponent();
            ListMails();
            cmbDepartment.Items.AddRange(new string[] { "Computer", "Software", "Robotic" });
        }


        private void ListMails()
        {
            string query = "SELECT * FROM Mail";

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
                                listView1.Items.Clear();
                                while (reader.Read())
                                {
                                    ListViewItem item = new ListViewItem(reader["GönderilenMail"].ToString());
                                    item.SubItems.Add(reader["Username"].ToString());
                                    item.SubItems.Add(reader["Alıcı"].ToString());
                                    item.SubItems.Add(reader["departman"].ToString());
                                    item.SubItems.Add(reader["Başlık"].ToString());

                                    listView1.Items.Add(item);
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }




       

        private void SaveMailPDF(string selectedDepartment)
        {
            string query = "SELECT GönderilenMail, Username, Alıcı, Departman, Başlık FROM Mail WHERE Departman = @Department";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Department", selectedDepartment);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                                saveFileDialog.Title = "Mail PDF Oluştur";
                                saveFileDialog.FileName = $"{selectedDepartment}_Mails.pdf";
                                saveFileDialog.ShowDialog();

                                if (saveFileDialog.FileName != "")
                                {
                                    Document doc = new Document();
                                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                                    doc.Open();

                                    // Font'u Türkçe karakterlerin düzgün gösterilmesi için ayarla
                                    BaseFont bf = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                                    Font font = new Font(bf, 12);

                                    PdfPTable table = new PdfPTable(5); // Toplam sütun sayısını belirt
                                    table.WidthPercentage = 100;

                                    // Tablo başlıklarını ekleyelim
                                    string[] headers = { "Gönderilen Mail", "Username", "Alıcı", "Departman", "Başlık" };
                                    foreach (var header in headers)
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(header, font));
                                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                        table.AddCell(cell);
                                    }

                                    // Verileri tabloya ekleyelim
                                    while (reader.Read())
                                    {
                                        table.AddCell(new Phrase(reader["GönderilenMail"].ToString(), font));
                                        table.AddCell(new Phrase(reader["Username"].ToString(), font));
                                        table.AddCell(new Phrase(reader["Alıcı"].ToString(), font));
                                        table.AddCell(new Phrase(reader["Departman"].ToString(), font));
                                        table.AddCell(new Phrase(reader["Başlık"].ToString(), font));

                                        // Eksik sütunlar için boş hücreler ekle
                                        for (int i = 0; i < 5 - reader.FieldCount; i++)
                                        {
                                            table.AddCell(new Phrase("", font));
                                        }
                                    }

                                    doc.Add(table);
                                    doc.Close();
                                    MessageBox.Show($"PDF oluşturuldu: {saveFileDialog.FileName}");
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void mailpdfbtn_Click(object sender, EventArgs e)
        {
            string selectedDepartment = cmbDepartment.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedDepartment))
            {
                SaveMailPDF(selectedDepartment);
            }
            else
            {
                MessageBox.Show("Departman Seç.");
            }
        }

        private void btnGeriMail_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


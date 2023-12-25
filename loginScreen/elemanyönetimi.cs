using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace loginScreen
{
    public partial class ElemanYönetimi : Form
    {
        public string connectionString = "Data Source=172.16.90.190;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";

        private SqlConnection connection;
        private SqlCommand command;
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

        private void Güncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbDepartment.Text) ||
                string.IsNullOrWhiteSpace(cmbAuthority.Text))

                {
                    // TextBox boş ise buraya girecek kod
                    // Örneğin, bir hata mesajı gösterilebilir
                    MessageBox.Show("Can not leave any box blank.");
                    return;

                }

                else
                {

                    SqlCommand command = new SqlCommand("UPDATE UserTable SET name=@name, surname=@surname, username=@username, password=@password, department=@department, authority=@authority WHERE username=" + listElemanlar.SelectedItems[0].Text, connection);
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    command.Parameters.AddWithValue("@department", cmbDepartment.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@authority", cmbAuthority.SelectedItem.ToString());

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (listElemanlar.SelectedItems.Count > 0)
                {
                    string id = listElemanlar.SelectedItems[0].Text;

                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM UserTable WHEN username";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@username", id);

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            textBoxUsername.Text = dr["username"].ToString();
                            textBoxName.Text = dr["name"].ToString();
                            textBoxSurname.Text = dr["surname"].ToString();
                            textBoxPassword.Text = dr["Password"].ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                    connection.Close();
                }
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

        private void customBtn3_Click(object sender, EventArgs e)
        {
            {
                PdfDokumente();
            }
        }
            public void PdfDokumente()
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

                        PdfPTable pdfTable = new PdfPTable(7);
                        pdfTable.WidthPercentage = 100;

                        pdfTable.AddCell(new PdfPCell(new Phrase("Kullanıcı Adı", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("İsim", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("Soyisim", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("Şifre", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("Departman", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("Yetkinlik", font)));
                        pdfTable.AddCell(new PdfPCell(new Phrase("Yetkinlik Seviyesi", font)));

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "SELECT username, name, surname, password, department, authority, authoritylevel FROM UserTable";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["username"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["name"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["surname"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["password"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["department"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["authority"].ToString(), font)));
                                        pdfTable.AddCell(new PdfPCell(new Phrase(reader["authoritylevel"].ToString(), font)));
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

 

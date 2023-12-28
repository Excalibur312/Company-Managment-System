using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Collections.Generic;

namespace loginScreen
{
    public partial class ElemanYönetimi : Form
    {
        public string connectionString = "Data Source=192.168.56.1;Initial Catalog=CompanyManagment;User ID=ortak;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";
        public List<string> comboBoxAuthorityItems = new List<string> { "Manager", "Employee", "Intern" };
        public List<string> comboBoxDepartmentsItems = new List<string> { "Computer", "Robotics", "Software" };
        public List<string> comboBoxAuthoirtItems = new List<string> { "1", "2", "3" };
        public List<string> comboBoxDepartmentsLevelItems = new List<string> { "1", "2", "3" };
        public ElemanYönetimi()
        {
            InitializeComponent();
            Listeleme();
            cmbAuthority.DataSource = comboBoxAuthorityItems;
            cmbDepartment.DataSource = comboBoxDepartmentsItems;
          

            // Do not set DataSource for comboBoxAuthorityLevel
            cmbauthoritylevel.Items.AddRange(comboBoxAuthoirtItems.ToArray());
            cmbDepartmanlevel.Items.AddRange(comboBoxDepartmentsLevelItems.ToArray());

            // Add event handler for authority selection change
            cmbAuthority.SelectedIndexChanged += comboBoxAuthority_SelectedIndexChanged;
            cmbDepartment.SelectedIndexChanged += comboBoxDepartment_SelectedIndexChanged;
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbDepartment.SelectedItem;

            cmbDepartmanlevel.Items.Clear();

            switch (selectedItem)
            {
                case "Computer":
                    cmbDepartmanlevel.Items.AddRange(new object[] { "1" });
                    break;
                case "Software":
                    cmbDepartmanlevel.Items.AddRange(new object[] { "2" });
                    break;
                case "Robotics":
                    cmbDepartmanlevel.Items.AddRange(new object[] { "3" });
                    break;
                default:
                    break;
            }

            if (cmbDepartmanlevel.Items.Count > 0)
                cmbDepartmanlevel.SelectedIndex = 0;
        }

        private void comboBoxAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbAuthority.SelectedItem;

            cmbauthoritylevel.Items.Clear();

            switch (selectedItem)
            {
                case "Manager":
                    cmbauthoritylevel.Items.AddRange(new object[] { "1" });
                    break;
                case "Employee":
                    cmbauthoritylevel.Items.AddRange(new object[] { "2" });
                    break;
                case "Intern":
                    cmbauthoritylevel.Items.AddRange(new object[] { "3" });
                    break;
                default:
                    break;
            }

            if (cmbauthoritylevel.Items.Count > 0)
                cmbauthoritylevel.SelectedIndex = 0;
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
                                    item.SubItems.Add(reader["gizlisoru"].ToString());

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
                if (listElemanlar.SelectedItems.Count > 0)
                {
                    string selectedUsername = listElemanlar.SelectedItems[0].Text;

                    if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                        string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                        string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                        string.IsNullOrWhiteSpace(cmbDepartment.Text) ||
                        string.IsNullOrWhiteSpace(cmbAuthority.Text) ||
                        string.IsNullOrWhiteSpace(txtGizliSoru.Text))
                        

                    {
                        MessageBox.Show("Lütfen tüm alanları doldurun.");
                        return;
                    }

                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE UserTable SET name=@name, surname=@surname, username=@username, password=@password, department=@department,departmentlevel=@departmentlevel, authority=@authority, authoritylevel=@authoritylevel, gizlisoru=@gizlisoru WHERE username=@selectedUsername", connection);
                        command.Parameters.AddWithValue("@name", textBoxName.Text);
                        command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                        command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                        command.Parameters.AddWithValue("@department", cmbDepartment.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@departmentlevel", cmbDepartmanlevel.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@authority", cmbAuthority.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@authoritylevel", cmbauthoritylevel.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@gizlisoru", txtGizliSoru.Text);
                        command.Parameters.AddWithValue("@selectedUsername", selectedUsername);
                       

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veritabanına Güncellendi.");
                            Listeleme();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek elemanı seçin.");
                }
            }
        }

        private void customBtn1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (listElemanlar.SelectedItems.Count > 0)
                {
                    string selectedUsername = listElemanlar.SelectedItems[0].Text;

                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM UserTable WHERE username=@username";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@username", selectedUsername);

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            textBoxUsername.Text = dr["username"].ToString();
                            textBoxName.Text = dr["name"].ToString();
                            textBoxSurname.Text = dr["surname"].ToString();
                            textBoxPassword.Text = dr["password"].ToString();
                            txtGizliSoru.Text = dr["gizlisoru"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen eleman seçin.");
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
                        string selectedUsername = item.Text;
                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM UserTable WHERE username=@username", connection);
                        sqlCommand.Parameters.AddWithValue("@username", selectedUsername);
                        try
                        {
                            connection.Open();
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Veritabanından silindi.");
                                Listeleme();
                            }
                            else
                            {
                                MessageBox.Show("Silme işlemi başarısız oldu.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
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
            PdfDokumente();
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

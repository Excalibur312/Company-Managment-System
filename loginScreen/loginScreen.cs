using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CompanyManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            ikincilekran ikinciEkranForm = new ikincilekran();
            ikinciEkranForm.Show();

            // Şu anki formu gizleyebilirsiniz, isteğe bağlı
            this.Hide();
            MessageBox.Show("Merhaba");
        }
    }
}

using System;
using System.Windows.Forms;

namespace Tp3_kpl_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Ambil teks dari TextBox
            string nama = textBoxInput.Text;

            // Jika tidak kosong, tampilkan di label
            if (!string.IsNullOrEmpty(nama))
            {
                labelOutput.Text = $"Halo {nama}";
            }
            else
            {
                labelOutput.Text = "Silakan masukkan nama!";
            }
        }
    }
}

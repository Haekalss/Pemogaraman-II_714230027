using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);

        }
        private void Form_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); // Bersihkan item sebelumnya jika ada
            comboBox1.Items.Add("Laki-laki");
            comboBox1.Items.Add("Perempuan");

            comboBox1.Text = "--Pilih Jenis Kelamin--";
        }

        private void JenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void TanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nama = label1.Text;
            string jenisKelamin = comboBox1.SelectedItem?.ToString() ?? "";
            DateTime tanggalLahir = dateTimePicker1.Value;

            // Mengambil pilihan kelas
            List<string> pilihanKelas = new List<string>();
            if (checkBox1.Checked) pilihanKelas.Add("Sepak Bola");
            if (checkBox2.Checked) pilihanKelas.Add("Renang");
            if (checkBox3.Checked) pilihanKelas.Add("Tenis");
            if (checkBox4.Checked) pilihanKelas.Add("Yoga");
            if (checkBox5.Checked) pilihanKelas.Add("Basket");
            if (checkBox6.Checked) pilihanKelas.Add("Bulu Tangkis");
            if (checkBox7.Checked) pilihanKelas.Add("Voli");
            if (checkBox8.Checked) pilihanKelas.Add("Panahan");

            // Mengambil pilihan jadwal
            string pilihanJadwal = "";
            if (radioButton1.Checked) pilihanJadwal = "Senin s/d Rabu, 14.00 - 16.00";
            else if (radioButton2.Checked) pilihanJadwal = "Selasa s/d Kamis, 14.00 - 16.00";
            else if (radioButton3.Checked) pilihanJadwal = "Sabtu s/d Minggu, 09.00 - 11.00";
            else if (radioButton4.Checked) pilihanJadwal = "Minggu, 13.00 - 20.00";

            // Validasi pilihan kelas dan jadwal
            if (pilihanKelas.Count == 0)
            {
                MessageBox.Show("Harus memilih salah satu dari kelas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(pilihanJadwal))
            {
                MessageBox.Show("Harus memilih salah satu jadwal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menampilkan hasil input
            string hasil = $"Nama: {nama}\nJenis Kelamin: {jenisKelamin}\nTanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                           $"Pilihan Kelas: {string.Join(", ", pilihanKelas)}\nPilihan Jadwal: {pilihanJadwal}";

            MessageBox.Show(hasil, "Hasil Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(300,189);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; 
            this.MinimizeBox = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekEnd.Checked)
            {
                checkBoxKuliah.Enabled = false;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true;checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = true;checkBoxLiburan.Checked = false;
            }
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama Harus Diisi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan Harus Diisi");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas Harus Diisi");
            }

            string errorMsg = errorMessage.ToString();

            if(string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                "Lengkap",
                "Info Massehh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                Size = new Size(300, 409);
            }
            else
            {
                MessageBox.Show(
                errorMsg.Trim(),
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void radioButtonWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekDay.Checked)
            {
                checkBoxKuliah.Enabled = true;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true;checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false;checkBoxLiburan.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string hari = null;
            string kegiatan = null;

            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    hari = radioButton.Text;
                    break;
                }
            }


            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (!string.IsNullOrEmpty(kegiatan))
                    {
                        kegiatan += ", ";
                    }
                    kegiatan += checkBox.Text;
                }
            }*/

            //Menggunakan LINQ (Leanguage Integrated Query)

            string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;
            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));
              

            MessageBox.Show(
                "Nama: " + textBoxNama.Text + "\n" +
                "Angkatan: " + comboBoxAngkatan.Text + "\n" +
                "Kelas: " + textBoxKelas.Text + "\n" +
                "=================\n" + 
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan + "\n" ,
                "informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            /* textBoxNama.Text = "";
             comboBoxAngkatan.Text = "";
             textBoxKelas.Text = "";

             comboBoxAngkatan.SelectedIndex = -1;

             radioButtonWeekDay.Checked = false;
             radioButtonWeekEnd.Checked = false;

             checkBoxKuliah.Checked = false;
             checkBoxTidur.Checked = false;
             checkBoxLiburan.Checked = false;*/

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
            }

            Size = new Size(300, 189);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; 
            this.MinimizeBox = false;

            MessageBox.Show(
                "Berhasil Reset",
                "Info Massehh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714230027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_iod.Checked == true)
            {
                os = "IOS";
            }

            if (cbYa.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }

            MessageBox.Show(
                "Merk HP: " + textMerkHp.Text +
                "\nSistem Operasi : " + os +
                "\nStatus Perbaikan : " + status,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void rb_iod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

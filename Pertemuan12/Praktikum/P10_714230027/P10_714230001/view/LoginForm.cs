﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P10_714230001.controller;
using P10_714230027.view;

namespace P10_714230001.view
{
    public partial class LoginForm : Form
    {
        CekLogin login = new CekLogin();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" ||  tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                
                bool status = login.cek_login(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    ParentForm pfrom = new ParentForm();
                    this.Hide();
                    pfrom.Show();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }

            }
        }
    }
}

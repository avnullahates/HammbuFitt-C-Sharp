﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class UygulamaTanitim : Form
    {
        public UygulamaTanitim()
        {
            InitializeComponent();
        }

        private void UygulamaTanitim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTanitimGeriDon_Click(object sender, EventArgs e)
        {
            Login giris = new Login();
            this.Hide();
            giris.Show();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Homepage : Form
    {
        LogIn logIn;
        Register reg;
        public Homepage(LogIn _login)
        {
            InitializeComponent();
            logIn = _login;

            reg = new Register();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            logIn.thisShow();
        }

        private void btnEmpMan_Click(object sender, EventArgs e)
        {
            lblDashboard.Hide();
            reg.TopLevel = false;
            pnlMain.Controls.Add(reg);
            reg.Dock = DockStyle.Fill;
            reg.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave?","Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                logIn.Close();
            }
        }
    }
}

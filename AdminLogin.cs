﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Record_System_Using_Blockchain
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegistration ar = new AdminRegistration();
            ar.ShowDialog();
        }
    }
}

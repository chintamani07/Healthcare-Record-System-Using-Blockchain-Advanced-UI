using System;
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
    public partial class MedicalLogin : Form
    {
        public MedicalLogin()
        {
            InitializeComponent();
        }

        private void medicalSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MedicalRegistration mr = new MedicalRegistration();
            mr.ShowDialog();
        }

        private void MedicalSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MedicalRegistration mr = new MedicalRegistration();
            mr.ShowDialog();
        }
    }
}

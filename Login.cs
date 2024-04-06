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
    public partial class Login : Form
    {
        internal static string hospitalid;
        internal static string hospitalname;

        public Login()
        {
            InitializeComponent();
        }

        private void HospitalSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HospitalRegistration hr = new HospitalRegistration();
            hr.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

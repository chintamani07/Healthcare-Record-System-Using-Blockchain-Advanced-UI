using System;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace Healthcare_Record_System_Using_Blockchain
{
    public partial class HospitalRegistration : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=M:\Project IK\Indrayani\HospitalManagementSystem\HospitalManagementSystem\HospitalManagementSystemDB.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\HospitalManagementSystemDB.mdf;Integrated Security=True");

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        Image img;
        private object msg;

        public HospitalRegistration()
        {
            InitializeComponent();
        }

        public object Id { get; private set; }

        private void HospitalRegistration_Load(object sender, EventArgs e)
        {
            datadisplay();
            Maxid();
        }

      
        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                captureImg.Image = Image.FromFile(openFileDialog1.FileName);
                img = captureImg.Image;
            }
            cameraImg.Image = img;
          
            con.Close();
        }

        public void Maxid()
        {
            try
            {
                con.Close();
                con.Open();
                DataSet ds2 = new DataSet();
                ds2.Tables.Clear();
                SqlDataAdapter da1 = new SqlDataAdapter("select max(id) from Hospital", con);
                da1.Fill(ds2);

                string a1 = ds2.Tables[0].Rows[0][0].ToString();
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    if (a1.Trim() != "")
                    {
                        txt_id.Text = (int.Parse(ds2.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                    }
                    else
                    {
                        txt_id.Text = "1";
                    }
                }
                else
                {
                    txt_id.Text = "1";
                }
            }
            catch { txt_id.Text = "1"; }
            finally
            {
                con.Close();
            }
        }
        public static string hospital_id = "";

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                DialogResult result = MessageBox.Show("Please Enter Character Value Only!!", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void txt_emailid_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txt_emailid.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
                txt_emailid.Focus();
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only Numbers");
            }
        }

        private void txt_contact_Leave(object sender, EventArgs e)
        {
            if (txt_contact.Text.Length != 10)
            {
                MessageBox.Show("Please Enter the Correct 10 Digit number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                videoCapture.Stop();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Please Register Icon First!!", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }

            errorProvider1.Clear();
            if (txt_registrationNo.Text == "")
            {
                errorProvider1.SetError(txt_registrationNo, "Please Enter Hospital Registratiom Number");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (txt_name.Text == "")
            {
                errorProvider1.SetError(txt_name, "Please Enter Hospital Name");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_state.Text == "")
            {
                errorProvider1.SetError(txt_state, "Please Select State");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_city.Text == "")
            {
                errorProvider1.SetError(txt_city, "Please Select City");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_emailid.Text == "")
            {
                errorProvider1.SetError(txt_emailid, "Please enter Email ID");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                con.Close();
                con.Open();

                SqlCommand cmd_mail = new SqlCommand("select * from  DoctorTable where emailId='" + txt_emailid.Text.Trim() + "' ", con);
                SqlDataReader dr_mail = cmd_mail.ExecuteReader();
                if (dr_mail.HasRows)
                {
                    dr_mail.Close();
                    DialogResult result1 = MessageBox.Show("Email Id Already Exists!!", "DUPLICATE ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            else if(txt_contact.Text == "")
            {
                errorProvider1.SetError(dateTimePicker1, "Please Enter Contact Details");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_hospitality.Text == "")
            {
                errorProvider1.SetError(txt_hospitality, "Please Enter Hospitality Details");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_speciality.Text == "")
            {
                errorProvider1.SetError(txt_speciality, "Please Enter Speciality Details");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (dateTimePicker1.Text == "")
            {
                errorProvider1.SetError(dateTimePicker1, "Please enter Registration Date");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_username.Text == "")
            {
                errorProvider1.SetError(txt_username, "Please enter Username");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                con.Close();
                con.Open();

                SqlCommand cmd_user = new SqlCommand("select * from  Hospital where username='" + txt_username.Text.Trim() + "' ", con);
                SqlDataReader dr_user = cmd_user.ExecuteReader();
                if (dr_user.HasRows)
                {
                    dr_user.Close();
                    DialogResult result1 = MessageBox.Show("Username Id Already Exists!!", "DUPLICATE USER ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            else if (txt_pass.Text == "")
            {
                errorProvider1.SetError(txt_pass, "Please enter Password");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                con.Close();
                con.Open();

                SqlCommand cmd_pass = new SqlCommand("select * from  Hospital where password='" + txt_pass.Text.Trim() + "' ", con);
                SqlDataReader dr_pass = cmd_pass.ExecuteReader();
                if (dr_pass.HasRows)
                {
                    dr_pass.Close();
                    DialogResult result1 = MessageBox.Show("PASSWORD Already Exists!!", "DUPLICATE PASSWORD ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            else if (txt_confirmPass.Text == "")
            {
                errorProvider1.SetError(txt_confirmPass, "Please Confirm Your Password");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_encrpt.Text == "")
            {
                errorProvider1.SetError(txt_encrpt, "Please Secure Your Password");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult result = MessageBox.Show("Verified All The Details?", "Exit Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                con.Close();
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Hospital VALUES('" + txt_id + "','" + txt_registrationNo + "','" + txt_name.Text + "','" + txt_state.Text + "','" + txt_city.Text + "','" + txt_emailid.Text  + "','" + txt_contact.Text + txt_hospitality.Text + "','" + txt_speciality.Text + "','" + dateTimePicker1.Text + "','" + txt_username.Text + "','" + txt_pass.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Successfully");
                con.Close();
            }
            con.Close();
            Maxid();
            datadisplay();
    }

        public void datadisplay()
        {
            try
            {
                con.Close();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Hospital order by id ", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = ds.Tables[0].Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = ds.Tables[0].Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = ds.Tables[0].Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = ds.Tables[0].Rows[i][7].ToString();
                    dataGridView1.Rows[i].Cells[8].Value = ds.Tables[0].Rows[i][8].ToString();
                    dataGridView1.Rows[i].Cells[9].Value = ds.Tables[0].Rows[i][9].ToString();
                    dataGridView1.Rows[i].Cells[10].Value = ds.Tables[0].Rows[i][10].ToString();
                    dataGridView1.Rows[i].Cells[11].Value = ds.Tables[0].Rows[i][11].ToString();
                    dataGridView1.Rows[i].Cells[12].Value = ds.Tables[0].Rows[i][12].ToString();
                    dataGridView1.Rows[i].Cells[13].Value = ds.Tables[0].Rows[i][13].ToString();
                    dataGridView1.Rows[i].Cells[14].Value = ds.Tables[0].Rows[i][14].ToString();
                }
            }
            catch { }
        }

        private void verifyPass_CheckedChanged(object sender, EventArgs e)
        {
            if (verifyPass.Checked)
            {
                txt_confirmPass.UseSystemPasswordChar = false;
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_confirmPass.UseSystemPasswordChar = true;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_registrationNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_state.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_city.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_emailid.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_contact.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_hospitality.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_speciality.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_speciality.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_pass.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_confirmPass.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_registrationNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_state.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_city.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_emailid.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_contact.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_hospitality.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_speciality.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_speciality.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            txt_pass.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            txt_confirmPass.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_registrationNo.Text = "";
            txt_name.Text = "";
            txt_state.Text = "";
            txt_city.Text = "";
            txt_emailid.Text = "";
            txt_contact.Text = "";
            txt_hospitality.Text = "";
            txt_speciality.Text = "";
            txt_username.Text = "";
            txt_pass.Text = "";
            txt_confirmPass.Text = "";
            txt_encrpt.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                videoCapture.Stop();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Please Register Your Face First!!", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }

            errorProvider1.Clear();
            if (txt_registrationNo.Text == "")
            {
                errorProvider1.SetError(txt_registrationNo, "Please Enter Hospital Registratiom Number");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (txt_name.Text == "")
            {
                errorProvider1.SetError(txt_name, "Please Enter Hospital Name");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_state.Text == "")
            {
                errorProvider1.SetError(txt_state, "Please Select State");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_city.Text == "")
            {
                errorProvider1.SetError(txt_city, "Please Select City");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_emailid.Text == "")
            {
                errorProvider1.SetError(txt_emailid, "Please enter Email ID");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                con.Close();
                con.Open();

                SqlCommand cmd_mail = new SqlCommand("select * from  DoctorTable where emailId='" + txt_emailid.Text.Trim() + "' ", con);
                SqlDataReader dr_mail = cmd_mail.ExecuteReader();
                if (dr_mail.HasRows)
                {
                    dr_mail.Close();
                    DialogResult result1 = MessageBox.Show("Email Id Already Exists!!", "DUPLICATE ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            else if (txt_contact.Text == "")
            {
                errorProvider1.SetError(dateTimePicker1, "Please Enter Contact Details");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_hospitality.Text == "")
            {
                errorProvider1.SetError(txt_hospitality, "Please Enter Hospitality Details");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_speciality.Text == "")
            {
                errorProvider1.SetError(txt_speciality, "Please Enter Speciality Details");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (dateTimePicker1.Text == "")
            {
                errorProvider1.SetError(dateTimePicker1, "Please enter Registration Date");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_username.Text == "")
            {
                errorProvider1.SetError(txt_username, "Please enter Username");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                con.Close();
                con.Open();

                SqlCommand cmd_user = new SqlCommand("select * from  Hospital where username='" + txt_username.Text.Trim() + "' ", con);
                SqlDataReader dr_user = cmd_user.ExecuteReader();
                if (dr_user.HasRows)
                {
                    dr_user.Close();
                    DialogResult result1 = MessageBox.Show("Username Id Already Exists!!", "DUPLICATE USER ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            else if (txt_pass.Text == "")
            {
                errorProvider1.SetError(txt_pass, "Please enter Password");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                con.Close();
                con.Open();

                SqlCommand cmd_pass = new SqlCommand("select * from  Hospital where password='" + txt_pass.Text.Trim() + "' ", con);
                SqlDataReader dr_pass = cmd_pass.ExecuteReader();
                if (dr_pass.HasRows)
                {
                    dr_pass.Close();
                    DialogResult result1 = MessageBox.Show("PASSWORD Already Exists!!", "DUPLICATE PASSWORD ID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }

            else if (txt_confirmPass.Text == "")
            {
                errorProvider1.SetError(txt_confirmPass, "Please Confirm Your Password");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else if (txt_encrpt.Text == "")
            {
                errorProvider1.SetError(txt_encrpt, "Please Secure Your Password");
                DialogResult result = MessageBox.Show("* Mandatory Field", "Exit Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult result = MessageBox.Show("Verified All The Details?", "Exit Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                con.Close();
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Hospital SET Id='" + txt_id +"',LicId" + txt_registrationNo + "',hospitalName='" + txt_name + "',DoctorName='" + txt_name.Text + "',state='" + txt_state + "',city=" + txt_city + "',Gender='" + "',Email='" + txt_emailid + "'Contact='" + txt_contact + "',age='" + ",Hospitality=" + txt_hospitality + ",Speciality=" +txt_speciality.Text + ",DOR=" + dateTimePicker1.Text + ",username='" + txt_username + "',password='" + txt_pass + "',Confirm='" + txt_confirmPass.Text  + "' where Id='" + txt_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Successfully");
                con.Close();
            }
            con.Close();
            Maxid();
            datadisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Hospital Where Id =@Id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Deleted Successfully");
            datadisplay();
            con.Close();
        }

        private void signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.ShowDialog();
        }

        private void loginDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnEncrpt_Click(object sender, EventArgs e)
        {

        }
    }
}
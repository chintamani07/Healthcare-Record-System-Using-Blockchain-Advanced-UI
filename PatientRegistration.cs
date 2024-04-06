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
    public partial class PatientRegistration : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=M:\Project IK\Indrayani\HospitalManagementSystem\HospitalManagementSystem\HospitalManagementSystemDB.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\HospitalManagementSystemDB.mdf;Integrated Security=True");

        string HospitalName = "";
        string HospitalId = "";


        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        Image img;
        private object msg;

        public PatientRegistration()
        {
            InitializeComponent();
        }

        public object Id { get; private set; }

        private void PatientRegistration_Load(object sender, EventArgs e)
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
                        txt_ptid.Text = (int.Parse(ds2.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                    }
                    else
                    {
                        txt_ptid.Text = "1";
                    }
                }
                else
                {
                    txt_ptid.Text = "1";
                }
            }
            catch { txt_ptid.Text = "1"; }
            finally
            {
                con.Close();
            }
        }
        public static string hospital_id = "";

        private void txt_ptname_KeyPress(object sender, KeyPressEventArgs e)
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
        public void datadisplay()
        {
            HospitalName = Login.hospitalname;
            HospitalId = Login.hospitalid;
            try
            {
                con.Close();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from DoctorTable where hospitalid='" + HospitalId.Trim().ToString() + "'order by doctorid ", con);
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
                    dataGridView1.Rows[i].Cells[15].Value = ds.Tables[0].Rows[i][15].ToString();
                    //dataGridView1.Rows[i].Cells[16].Value = ds.Tables[0].Rows[i][16].ToString();
                }
            }
            catch { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_Record_System_Using_Blockchain
{
    public partial class SearchPatient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\HealthCareRecordSystem.mdf;Integrated Security=True");

        public SearchPatient()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_PId.Text = "";
            txt_PtName.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {

            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select patientname from PatientTable ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    col.Add(dr.GetString(0));
                }
                txt_PtName.AutoCompleteCustomSource = col;
                con.Close();
            }
            catch { }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from PatientTable  where patientname='" + txt_PtName.Text.ToString() + "'", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.Rows.Clear();
                    //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    //{
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = "Hospital Id";
                    dataGridView1.Rows[0].Cells[1].Value = ds.Tables[0].Rows[0][0].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[1].Cells[0].Value = "Hospital Name";
                    dataGridView1.Rows[1].Cells[1].Value = ds.Tables[0].Rows[0][1].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[2].Cells[0].Value = "ID";
                    dataGridView1.Rows[2].Cells[1].Value = ds.Tables[0].Rows[0][2].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[3].Cells[0].Value = "Name";
                    dataGridView1.Rows[3].Cells[1].Value = ds.Tables[0].Rows[0][3].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[4].Cells[0].Value = "Address";
                    dataGridView1.Rows[4].Cells[1].Value = ds.Tables[0].Rows[0][4].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[5].Cells[0].Value = "Mobile NO";
                    dataGridView1.Rows[5].Cells[1].Value = ds.Tables[0].Rows[0][5].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[6].Cells[0].Value = "Gender";
                    dataGridView1.Rows[6].Cells[1].Value = ds.Tables[0].Rows[0][6].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[7].Cells[0].Value = "DOB";
                    dataGridView1.Rows[7].Cells[1].Value = ds.Tables[0].Rows[0][7].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[8].Cells[0].Value = "Age";
                    dataGridView1.Rows[8].Cells[1].Value = ds.Tables[0].Rows[0][8].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[9].Cells[0].Value = "Email ID";
                    dataGridView1.Rows[9].Cells[1].Value = ds.Tables[0].Rows[0][9].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[10].Cells[0].Value = "Occupation";
                    dataGridView1.Rows[10].Cells[1].Value = ds.Tables[0].Rows[0][10].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[11].Cells[0].Value = "Blood Group";
                    dataGridView1.Rows[11].Cells[1].Value = ds.Tables[0].Rows[0][11].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[12].Cells[0].Value = "Marital Staus";
                    dataGridView1.Rows[12].Cells[1].Value = ds.Tables[0].Rows[0][12].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[13].Cells[0].Value = "Adhar No";
                    dataGridView1.Rows[13].Cells[1].Value = ds.Tables[0].Rows[0][13].ToString();

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[14].Cells[0].Value = "Registration Date";
                    dataGridView1.Rows[14].Cells[1].Value = ds.Tables[0].Rows[0][14].ToString();
                    //}
                    txt_PId.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();
                }
                catch { }
            }
        }

        private void txt_PId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from PatientTable  where patientid='" + txt_PId.Text.ToString() + "'", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.Rows.Clear();
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid Id");
                    }
                    else
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[0].Cells[0].Value = "Hospital Id";
                        dataGridView1.Rows[0].Cells[1].Value = ds.Tables[0].Rows[0][0].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = "Hospital Name";
                        dataGridView1.Rows[1].Cells[1].Value = ds.Tables[0].Rows[0][1].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[2].Cells[0].Value = "ID";
                        dataGridView1.Rows[2].Cells[1].Value = ds.Tables[0].Rows[0][2].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[3].Cells[0].Value = "Name";
                        dataGridView1.Rows[3].Cells[1].Value = ds.Tables[0].Rows[0][3].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[4].Cells[0].Value = "Address";
                        dataGridView1.Rows[4].Cells[1].Value = ds.Tables[0].Rows[0][4].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[5].Cells[0].Value = "Mobile NO";
                        dataGridView1.Rows[5].Cells[1].Value = ds.Tables[0].Rows[0][5].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[6].Cells[0].Value = "Gender";
                        dataGridView1.Rows[6].Cells[1].Value = ds.Tables[0].Rows[0][6].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[7].Cells[0].Value = "DOB";
                        dataGridView1.Rows[7].Cells[1].Value = ds.Tables[0].Rows[0][7].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[8].Cells[0].Value = "Age";
                        dataGridView1.Rows[8].Cells[1].Value = ds.Tables[0].Rows[0][8].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[9].Cells[0].Value = "Email ID";
                        dataGridView1.Rows[9].Cells[1].Value = ds.Tables[0].Rows[0][9].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[10].Cells[0].Value = "Occupation";
                        dataGridView1.Rows[10].Cells[1].Value = ds.Tables[0].Rows[0][10].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[11].Cells[0].Value = "Blood Group";
                        dataGridView1.Rows[11].Cells[1].Value = ds.Tables[0].Rows[0][11].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[12].Cells[0].Value = "Marital Staus";
                        dataGridView1.Rows[12].Cells[1].Value = ds.Tables[0].Rows[0][12].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[13].Cells[0].Value = "Adhar No";
                        dataGridView1.Rows[13].Cells[1].Value = ds.Tables[0].Rows[0][13].ToString();

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[14].Cells[0].Value = "Registration Date";
                        dataGridView1.Rows[14].Cells[1].Value = ds.Tables[0].Rows[0][14].ToString();
                        txt_PtName.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();
                    }
                }
                catch { }
            }
        }

        private void heading_MouseHover(object sender, EventArgs e)
        {
            heading.ForeColor = Color.IndianRed;
        }

        private void heading_MouseLeave(object sender, EventArgs e)
        {
            heading.ForeColor = Color.White;
        }

        private void ptId_MouseHover(object sender, EventArgs e)
        {
            ptId.ForeColor = Color.White;
        }

        private void ptId_MouseLeave(object sender, EventArgs e)
        {
            ptId.ForeColor = Color.Black;
        }

        private void ptName_MouseHover(object sender, EventArgs e)
        {
            ptName.ForeColor = Color.White;
        }
        private void ptName_MouseLeave(object sender, EventArgs e)
        {
            ptName.ForeColor = Color.Black;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.IndianRed;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
        }

        private void MET_MouseHover(object sender, EventArgs e)
        {
            MET.ForeColor = Color.IndianRed;
        }

        private void MET_MouseLeave(object sender, EventArgs e)
        {
            MET.ForeColor = Color.PaleGoldenrod;
        }

        private void txt_PId_Enter(object sender, EventArgs e)
        {
            if (txt_PId.Text == "Click Enter")
            {
                txt_PId.Text = " ";
                txt_PId.ForeColor = Color.Black;
            }
        }

        private void txt_PId_Leave(object sender, EventArgs e)
        {
            if (txt_PId.Text == " ")
            {
                txt_PId.Text = "User Name";
                txt_PId.ForeColor = Color.Silver;
            }
        }
    }
}

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
    public partial class AddDisease : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\HealthCareRecordSystem.mdf;Integrated Security=True");

        public AddDisease()
        {
            InitializeComponent();
            datadisplay();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Id;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into diseaseTable(disease,Prescription) values('" + txt_disease.Text + "','" + txt_prescription.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Add Successfully");
                con.Close();
            }
            catch { }
            datadisplay();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update diseaseTable Set disease='" + txt_disease.Text + "',Prescription='" + txt_prescription.Text + "' WHERE Id='" + Id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                datadisplay();
                con.Close();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from diseaseTable Where Id =@Id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Deleted Successfully");
            datadisplay();
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_disease.Text = "";
            txt_prescription.Text = "";
        }

        private void AddDisease_Load(object sender, EventArgs e)
        {

        }
        public void datadisplay()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from diseaseTable", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = ds.Tables[0].Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                }
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_disease.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_prescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void heading_MouseHover(object sender, EventArgs e)
        {
            heading.ForeColor = Color.IndianRed;
        }

        private void heading_MouseLeave(object sender, EventArgs e)
        {
            heading.ForeColor = Color.White;
        }

        private void disease_MouseHover(object sender, EventArgs e)
        {
            disease.ForeColor = Color.White;
        }

        private void disease_MouseLeave(object sender, EventArgs e)
        {
            disease.ForeColor = Color.Black;
        }

        private void prescription_MouseHover(object sender, EventArgs e)
        {
            prescription.ForeColor = Color.White;
        }

        private void prescription_MouseLeave(object sender, EventArgs e)
        {
            prescription.ForeColor = Color.Black;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            prescription.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Black;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.White;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.ForeColor = Color.Black;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Black;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Black;
        }

        private void MET_MouseHover(object sender, EventArgs e)
        {
            MET.ForeColor = Color.IndianRed;
        }

        private void MET_MouseLeave(object sender, EventArgs e)
        {
            MET.ForeColor = Color.PaleGoldenrod;
        }
    }
}

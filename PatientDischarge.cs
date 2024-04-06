using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using blockchain_ehr;


namespace Healthcare_Record_System_Using_Blockchain
{

    public partial class PatientDischarge : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\HealthCareRecordSystem.mdf;Integrated Security=True");

        public PatientDischarge()
        {
            InitializeComponent();
        }

        private void Txt_drId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToString("dd/MM/yyyy,( dddd )");
            time.Text = DateTime.Now.ToString("hh:mm:ss");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from PatientFeedback ", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();


                }
            }
            catch { }
            con.Close();
        }

        private string username = " ";
        private int srno;
        private int patientid;
        private string patientname;
        private int doctorid;
        private string doctorname;
        private string observation;
        private string reasonforvisit;
        private string HospitalId = " ";
        private string HospitalName = " ";

        private void txt_drId_TextChanged(object sender, EventArgs e)
        {
            username = Login.hospitalname;
            try
            {
                if (txt_drId.Text == "")
                {
                    MessageBox.Show("Please Enter Docotr ID");
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from DoctorTable where hospitalname='" + username.ToString() + "' and  doctorid='" + txt_drId.Text.ToString() + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txt_drName.Text = dr["DoctorName"].ToString();
                    }
                    if (txt_drName.Text == "")
                    {
                        MessageBox.Show("No Doctor Found");
                    }
                }
            }
            catch
            {
                txt_drName.Text = "";
            }
        }

        private void txt_pId_TextChanged(object sender, EventArgs e)
        {
            username = Login.hospitalname;
            try
            {
                if (txt_pId.Text == "")
                {
                    MessageBox.Show("Please Enter Patient ID");
                }
                else
                {
                    SqlDataAdapter sda1 = new SqlDataAdapter("select * from PatientTable where hospitalname='" + username.ToString() + "' and  patientid='" + txt_pId.Text.ToString() + "'", con);
                    DataTable pt = new DataTable();
                    sda1.Fill(pt);
                    foreach (DataRow dr1 in pt.Rows)
                    {
                        txt_pName.Text = dr1["PatientName"].ToString();
                    }
                    if (txt_pName.Text == "")
                    {
                        MessageBox.Show("No Patient Found");
                    }
                }
            }
            catch
            {
                txt_drName.Text = "";
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sf.FileName = "txt_pName", FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(feed_info.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            con.Close();
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO PatientFeedback VALUES('" + HospitalId + "','" + HospitalName + "'," + drId.Text + "','" + drName.Text + "','" + ptId.Text + "','" + "','" + ptName.Text + "','" + cd_av.Text + "','" + cd_ex.Text + "','" + cd_gd.Text + "','" + cd_pr.Text + "','" + cd_sf.Text + "','" + cs_nsf + "','" + "')", con);
            MessageBox.Show("Register Successfully");
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            AES dd = new AES("00");

            e.Graphics.DrawString("Hospital Management System", new System.Drawing.Font("century gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(250));
            //e.Graphics.DrawString("Sr.No   P.Id     P.Name     Dr.Id      Dr.Name      Observation             Reason For Visit", new Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(26, 40));
            e.Graphics.DrawString("Sr.No ", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(26, 40));
            e.Graphics.DrawString("P.Id", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(85, 40));
            e.Graphics.DrawString("P.Name", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(130, 40));
            e.Graphics.DrawString("Dr.Id", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(240, 40));
            e.Graphics.DrawString("Dr.Name", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(300, 40));
            e.Graphics.DrawString("Observation", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(400, 40));
            e.Graphics.DrawString("Reason For Visit", new System.Drawing.Font("century gothic", 10, FontStyle.Bold), Brushes.Blue, new Point(535, 40));

            int count = 0, pos = 60;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (count < (dataGridView1.Rows.Count - 1))
                {
                    srno = Convert.ToInt32(row.Cells[0].Value);
                    patientid = Convert.ToInt32(row.Cells[1].Value);
                    patientname = "" + row.Cells[2].Value;
                    doctorid = Convert.ToInt32(row.Cells[3].Value);
                    doctorname = "" + row.Cells[4].Value;
                    observation = "" + dd.Decrypt_CBC(row.Cells[5].Value.ToString());
                    reasonforvisit = "" + dd.Decrypt_CBC(row.Cells[6].Value.ToString());

                    e.Graphics.DrawString(" " + srno, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(26, pos));
                    e.Graphics.DrawString(" " + patientid, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(85, pos));
                    e.Graphics.DrawString(" " + patientname, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(130, pos));
                    e.Graphics.DrawString(" " + doctorid, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(240, pos));
                    e.Graphics.DrawString(" " + doctorname, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(300, pos));
                    e.Graphics.DrawString(" " + observation, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(400, pos));
                    e.Graphics.DrawString(" " + reasonforvisit, new System.Drawing.Font("century gothic", 8, FontStyle.Regular), Brushes.Black, new Point(535, pos));
                    pos = pos + 20;
                }
                count++;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 700, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

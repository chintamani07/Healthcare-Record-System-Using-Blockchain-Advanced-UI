using System;
using System.Windows.Forms;

namespace Healthcare_Record_System_Using_Blockchain
{
    partial class HospitalRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalRegistration));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MET = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.drRegistrationDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hosId = new System.Windows.Forms.Label();
            this.hosName = new System.Windows.Forms.Label();
            this.hosState = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cameraImg = new System.Windows.Forms.PictureBox();
            this.preview = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.ComboBox();
            this.drEmail = new System.Windows.Forms.Label();
            this.txt_emailid = new System.Windows.Forms.TextBox();
            this.drCity = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.captureImg = new System.Windows.Forms.PictureBox();
            this.camera = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.layout = new System.Windows.Forms.Panel();
            this.txt_speciality = new System.Windows.Forms.ComboBox();
            this.speciality = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_hospitality = new System.Windows.Forms.ComboBox();
            this.treatment = new System.Windows.Forms.Label();
            this.txt_registrationNo = new System.Windows.Forms.TextBox();
            this.hosRegNo = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.heading = new System.Windows.Forms.Label();
            this.loginDetails = new System.Windows.Forms.GroupBox();
            this.answer = new System.Windows.Forms.Label();
            this.txt_security = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.LinkLabel();
            this.btnEncrpt = new System.Windows.Forms.Button();
            this.secure = new System.Windows.Forms.Label();
            this.txt_encrpt = new System.Windows.Forms.TextBox();
            this.verifyPass = new System.Windows.Forms.CheckBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureImg)).BeginInit();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.loginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1371, 251);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "State";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "City";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Contact";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hospitality";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Speciality";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "DOR";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MET
            // 
            this.MET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MET.AutoSize = true;
            this.MET.BackColor = System.Drawing.Color.Transparent;
            this.MET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MET.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MET.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.MET.Location = new System.Drawing.Point(206, 2);
            this.MET.Name = "MET";
            this.MET.Size = new System.Drawing.Size(961, 37);
            this.MET.TabIndex = 31;
            this.MET.Text = "METIOE, BE, department of computer engineering 2024";
            this.MET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Desktop;
            this.footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footer.Controls.Add(this.MET);
            this.footer.Location = new System.Drawing.Point(1, 707);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1370, 42);
            this.footer.TabIndex = 63;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // drRegistrationDate
            // 
            this.drRegistrationDate.AutoSize = true;
            this.drRegistrationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drRegistrationDate.Location = new System.Drawing.Point(461, 395);
            this.drRegistrationDate.Name = "drRegistrationDate";
            this.drRegistrationDate.Size = new System.Drawing.Size(45, 19);
            this.drRegistrationDate.TabIndex = 20;
            this.drRegistrationDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // hosId
            // 
            this.hosId.AutoSize = true;
            this.hosId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosId.Location = new System.Drawing.Point(13, 274);
            this.hosId.Name = "hosId";
            this.hosId.Size = new System.Drawing.Size(89, 19);
            this.hosId.TabIndex = 39;
            this.hosId.Text = "Hospital ID";
            // 
            // hosName
            // 
            this.hosName.AutoSize = true;
            this.hosName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosName.Location = new System.Drawing.Point(14, 332);
            this.hosName.Name = "hosName";
            this.hosName.Size = new System.Drawing.Size(123, 19);
            this.hosName.TabIndex = 41;
            this.hosName.Text = "Hospital Name";
            // 
            // hosState
            // 
            this.hosState.AutoSize = true;
            this.hosState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosState.Location = new System.Drawing.Point(13, 363);
            this.hosState.Name = "hosState";
            this.hosState.Size = new System.Drawing.Size(46, 19);
            this.hosState.TabIndex = 43;
            this.hosState.Text = "State";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(163, 271);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(242, 26);
            this.txt_id.TabIndex = 52;
            this.txt_id.Text = "1";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(163, 329);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 26);
            this.txt_name.TabIndex = 38;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // cameraImg
            // 
            this.cameraImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraImg.Location = new System.Drawing.Point(11, 52);
            this.cameraImg.Name = "cameraImg";
            this.cameraImg.Size = new System.Drawing.Size(264, 202);
            this.cameraImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraImg.TabIndex = 57;
            this.cameraImg.TabStop = false;
            // 
            // preview
            // 
            this.preview.AutoSize = true;
            this.preview.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.Location = new System.Drawing.Point(32, 46);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(68, 15);
            this.preview.TabIndex = 69;
            this.preview.Text = "Preview";
            // 
            // txt_state
            // 
            this.txt_state.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_state.FormattingEnabled = true;
            this.txt_state.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chattisgarh",
            "Goa",
            "Gujrat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashta",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odhisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal"});
            this.txt_state.Location = new System.Drawing.Point(163, 358);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(242, 30);
            this.txt_state.TabIndex = 71;
            // 
            // drEmail
            // 
            this.drEmail.AutoSize = true;
            this.drEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drEmail.Location = new System.Drawing.Point(460, 275);
            this.drEmail.Name = "drEmail";
            this.drEmail.Size = new System.Drawing.Size(71, 19);
            this.drEmail.TabIndex = 73;
            this.drEmail.Text = "Email ID";
            // 
            // txt_emailid
            // 
            this.txt_emailid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_emailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_emailid.Location = new System.Drawing.Point(572, 271);
            this.txt_emailid.Name = "txt_emailid";
            this.txt_emailid.Size = new System.Drawing.Size(242, 26);
            this.txt_emailid.TabIndex = 72;
            this.txt_emailid.Leave += new System.EventHandler(this.txt_emailid_Leave);
            // 
            // drCity
            // 
            this.drCity.AutoSize = true;
            this.drCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drCity.Location = new System.Drawing.Point(12, 394);
            this.drCity.Name = "drCity";
            this.drCity.Size = new System.Drawing.Size(38, 19);
            this.drCity.TabIndex = 74;
            this.drCity.Text = "City";
            // 
            // txt_city
            // 
            this.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(163, 391);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(242, 26);
            this.txt_city.TabIndex = 75;
            // 
            // captureImg
            // 
            this.captureImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.captureImg.Location = new System.Drawing.Point(300, 52);
            this.captureImg.Name = "captureImg";
            this.captureImg.Size = new System.Drawing.Size(405, 202);
            this.captureImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.captureImg.TabIndex = 63;
            this.captureImg.TabStop = false;
            // 
            // camera
            // 
            this.camera.AutoSize = true;
            this.camera.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera.Location = new System.Drawing.Point(324, 46);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(127, 15);
            this.camera.TabIndex = 76;
            this.camera.Text = "Selected Image";
            // 
            // btnUpload
            // 
            this.btnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpload.BackgroundImage")));
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(904, 97);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(120, 30);
            this.btnUpload.TabIndex = 86;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(739, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Click Upload To Manually Upload Photo";
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.layout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layout.Controls.Add(this.txt_speciality);
            this.layout.Controls.Add(this.speciality);
            this.layout.Controls.Add(this.txt_contact);
            this.layout.Controls.Add(this.contact);
            this.layout.Controls.Add(this.pictureBox1);
            this.layout.Controls.Add(this.txt_hospitality);
            this.layout.Controls.Add(this.treatment);
            this.layout.Controls.Add(this.txt_registrationNo);
            this.layout.Controls.Add(this.hosRegNo);
            this.layout.Controls.Add(this.header);
            this.layout.Controls.Add(this.loginDetails);
            this.layout.Controls.Add(this.label4);
            this.layout.Controls.Add(this.btnUpload);
            this.layout.Controls.Add(this.camera);
            this.layout.Controls.Add(this.captureImg);
            this.layout.Controls.Add(this.txt_city);
            this.layout.Controls.Add(this.drCity);
            this.layout.Controls.Add(this.txt_emailid);
            this.layout.Controls.Add(this.drEmail);
            this.layout.Controls.Add(this.txt_state);
            this.layout.Controls.Add(this.preview);
            this.layout.Controls.Add(this.cameraImg);
            this.layout.Controls.Add(this.txt_name);
            this.layout.Controls.Add(this.txt_id);
            this.layout.Controls.Add(this.hosState);
            this.layout.Controls.Add(this.hosName);
            this.layout.Controls.Add(this.hosId);
            this.layout.Controls.Add(this.dateTimePicker1);
            this.layout.Controls.Add(this.drRegistrationDate);
            this.layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(1370, 451);
            this.layout.TabIndex = 61;
            // 
            // txt_speciality
            // 
            this.txt_speciality.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_speciality.FormattingEnabled = true;
            this.txt_speciality.Items.AddRange(new object[] {
            "Aneshesiology",
            "Cardiology",
            "Corolectal Surgery",
            "Darmatology",
            "Diabetology",
            "Diagnostic Radiology",
            "Emergency Medicine",
            "Endocrinology",
            "Family Medicine",
            "Forensic Pathology",
            "Gastroenterology",
            "Geriatrics",
            "General Surgery",
            "Gynocology",
            "Hermatology",
            "Immunology",
            "Infectious Diseases",
            "Intensive Care Medicine",
            "Internal Medicine",
            "Interventional Radiology",
            "Neurosurgery",
            "Neonatology",
            "Nephrology",
            "Obstetrics & Gynocology",
            "Oncology",
            "Organ Transplantation",
            "Orthopedics",
            "Pedastric Surgery",
            "Pediatric Hematology Oncology",
            "Physical Therapy",
            "Pulmonology",
            "Radiology",
            "Rheumatology",
            "Vascular Surgery",
            "Other",
            ""});
            this.txt_speciality.Location = new System.Drawing.Point(572, 363);
            this.txt_speciality.Name = "txt_speciality";
            this.txt_speciality.Size = new System.Drawing.Size(242, 30);
            this.txt_speciality.TabIndex = 98;
            // 
            // speciality
            // 
            this.speciality.AutoSize = true;
            this.speciality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciality.Location = new System.Drawing.Point(461, 365);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(84, 19);
            this.speciality.TabIndex = 97;
            this.speciality.Text = "Speciality";
            // 
            // txt_contact
            // 
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(572, 301);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(242, 26);
            this.txt_contact.TabIndex = 96;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            this.txt_contact.Leave += new System.EventHandler(this.txt_contact_Leave);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(460, 303);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(70, 19);
            this.contact.TabIndex = 95;
            this.contact.Text = "Contact";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(743, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 56);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // txt_hospitality
            // 
            this.txt_hospitality.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_hospitality.FormattingEnabled = true;
            this.txt_hospitality.Items.AddRange(new object[] {
            "Primary",
            "Secondory",
            "Ternary",
            "Other"});
            this.txt_hospitality.Location = new System.Drawing.Point(572, 330);
            this.txt_hospitality.Name = "txt_hospitality";
            this.txt_hospitality.Size = new System.Drawing.Size(242, 30);
            this.txt_hospitality.TabIndex = 93;
            // 
            // treatment
            // 
            this.treatment.AutoSize = true;
            this.treatment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatment.Location = new System.Drawing.Point(461, 335);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(87, 19);
            this.treatment.TabIndex = 92;
            this.treatment.Text = "Hospitality";
            // 
            // txt_registrationNo
            // 
            this.txt_registrationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_registrationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_registrationNo.Location = new System.Drawing.Point(163, 300);
            this.txt_registrationNo.Name = "txt_registrationNo";
            this.txt_registrationNo.Size = new System.Drawing.Size(242, 26);
            this.txt_registrationNo.TabIndex = 90;
            // 
            // hosRegNo
            // 
            this.hosRegNo.AutoSize = true;
            this.hosRegNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosRegNo.Location = new System.Drawing.Point(14, 303);
            this.hosRegNo.Name = "hosRegNo";
            this.hosRegNo.Size = new System.Drawing.Size(89, 19);
            this.hosRegNo.TabIndex = 91;
            this.hosRegNo.Text = "Licence ID";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Desktop;
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header.Controls.Add(this.pictureBox3);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.pictureBoxClose);
            this.header.Controls.Add(this.heading);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1368, 40);
            this.header.TabIndex = 89;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(822, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 41);
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(394, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 41);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1331, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(37, 40);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 62;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.BackColor = System.Drawing.Color.Transparent;
            this.heading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heading.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.Control;
            this.heading.Location = new System.Drawing.Point(531, 8);
            this.heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(256, 23);
            this.heading.TabIndex = 3;
            this.heading.Text = "Hospital Registration";
            // 
            // loginDetails
            // 
            this.loginDetails.Controls.Add(this.answer);
            this.loginDetails.Controls.Add(this.txt_security);
            this.loginDetails.Controls.Add(this.comboBox1);
            this.loginDetails.Controls.Add(this.label1);
            this.loginDetails.Controls.Add(this.signUp);
            this.loginDetails.Controls.Add(this.btnEncrpt);
            this.loginDetails.Controls.Add(this.secure);
            this.loginDetails.Controls.Add(this.txt_encrpt);
            this.loginDetails.Controls.Add(this.verifyPass);
            this.loginDetails.Controls.Add(this.txt_username);
            this.loginDetails.Controls.Add(this.confirmPass);
            this.loginDetails.Controls.Add(this.txt_confirmPass);
            this.loginDetails.Controls.Add(this.password);
            this.loginDetails.Controls.Add(this.username);
            this.loginDetails.Controls.Add(this.btnRegister);
            this.loginDetails.Controls.Add(this.txt_pass);
            this.loginDetails.Controls.Add(this.btnClear);
            this.loginDetails.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginDetails.ForeColor = System.Drawing.Color.Crimson;
            this.loginDetails.Location = new System.Drawing.Point(842, 159);
            this.loginDetails.Name = "loginDetails";
            this.loginDetails.Size = new System.Drawing.Size(515, 273);
            this.loginDetails.TabIndex = 88;
            this.loginDetails.TabStop = false;
            this.loginDetails.Text = " Login Details";
            this.loginDetails.Enter += new System.EventHandler(this.loginDetails_Enter);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.answer.Location = new System.Drawing.Point(21, 191);
            this.answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(61, 18);
            this.answer.TabIndex = 103;
            this.answer.Text = "Answer";
            // 
            // txt_security
            // 
            this.txt_security.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_security.Location = new System.Drawing.Point(177, 180);
            this.txt_security.Margin = new System.Windows.Forms.Padding(2);
            this.txt_security.Name = "txt_security";
            this.txt_security.Size = new System.Drawing.Size(321, 26);
            this.txt_security.TabIndex = 102;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. 10th Board Seat Number",
            "2. 12th Board Seat Number",
            "3. Mother\'s Name",
            "4. Favourite Game",
            "5. Favourite Movie",
            "6. Favourite Sportsman or Sportswomen"});
            this.comboBox1.Location = new System.Drawing.Point(177, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 30);
            this.comboBox1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "*Security Question";
            // 
            // signUp
            // 
            this.signUp.ActiveLinkColor = System.Drawing.Color.Black;
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.LinkColor = System.Drawing.Color.Black;
            this.signUp.Location = new System.Drawing.Point(275, 244);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(120, 20);
            this.signUp.TabIndex = 99;
            this.signUp.TabStop = true;
            this.signUp.Text = "FORGOT PASSWORD";
            this.signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUp_LinkClicked);
            // 
            // btnEncrpt
            // 
            this.btnEncrpt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncrpt.BackgroundImage")));
            this.btnEncrpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEncrpt.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncrpt.Location = new System.Drawing.Point(197, 211);
            this.btnEncrpt.Name = "btnEncrpt";
            this.btnEncrpt.Size = new System.Drawing.Size(80, 30);
            this.btnEncrpt.TabIndex = 86;
            this.btnEncrpt.Text = "Encrypt";
            this.btnEncrpt.UseVisualStyleBackColor = true;
            this.btnEncrpt.Click += new System.EventHandler(this.btnEncrpt_Click);
            // 
            // secure
            // 
            this.secure.AutoSize = true;
            this.secure.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secure.ForeColor = System.Drawing.SystemColors.Desktop;
            this.secure.Location = new System.Drawing.Point(15, 124);
            this.secure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secure.Name = "secure";
            this.secure.Size = new System.Drawing.Size(131, 18);
            this.secure.TabIndex = 85;
            this.secure.Text = "Secure Password";
            // 
            // txt_encrpt
            // 
            this.txt_encrpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encrpt.Location = new System.Drawing.Point(177, 118);
            this.txt_encrpt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_encrpt.Name = "txt_encrpt";
            this.txt_encrpt.Size = new System.Drawing.Size(321, 26);
            this.txt_encrpt.TabIndex = 84;
            // 
            // verifyPass
            // 
            this.verifyPass.AutoSize = true;
            this.verifyPass.Checked = true;
            this.verifyPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verifyPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyPass.Location = new System.Drawing.Point(474, 67);
            this.verifyPass.Name = "verifyPass";
            this.verifyPass.Size = new System.Drawing.Size(15, 14);
            this.verifyPass.TabIndex = 82;
            this.verifyPass.UseVisualStyleBackColor = true;
            this.verifyPass.CheckedChanged += new System.EventHandler(this.verifyPass_CheckedChanged);
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(177, 31);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(321, 26);
            this.txt_username.TabIndex = 9;
            // 
            // confirmPass
            // 
            this.confirmPass.AutoSize = true;
            this.confirmPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.confirmPass.Location = new System.Drawing.Point(15, 94);
            this.confirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(137, 18);
            this.confirmPass.TabIndex = 81;
            this.confirmPass.Text = "Confirm Password";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPass.Location = new System.Drawing.Point(177, 89);
            this.txt_confirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(321, 26);
            this.txt_confirmPass.TabIndex = 80;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.Desktop;
            this.password.Location = new System.Drawing.Point(15, 64);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 18);
            this.password.TabIndex = 79;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.Desktop;
            this.username.Location = new System.Drawing.Point(14, 34);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(93, 19);
            this.username.TabIndex = 23;
            this.username.Text = "User Name";
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(292, 211);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 30);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(177, 60);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(321, 26);
            this.txt_pass.TabIndex = 78;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(394, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // HospitalRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.layout);
            this.Name = "HospitalRegistration";
            this.Text = "HospitalRegistration";
            this.Load += new System.EventHandler(this.HospitalRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureImg)).EndInit();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.loginDetails.ResumeLayout(false);
            this.loginDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label MET;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel layout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label camera;
        private System.Windows.Forms.PictureBox captureImg;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label drCity;
        private System.Windows.Forms.TextBox txt_emailid;
        private System.Windows.Forms.Label drEmail;
        private System.Windows.Forms.ComboBox txt_state;
        private System.Windows.Forms.Label preview;
        private System.Windows.Forms.PictureBox cameraImg;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label hosState;
        private System.Windows.Forms.Label hosName;
        private System.Windows.Forms.Label hosId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label drRegistrationDate;
        private System.Windows.Forms.GroupBox loginDetails;
        private System.Windows.Forms.Label secure;
        private System.Windows.Forms.TextBox txt_encrpt;
        private System.Windows.Forms.CheckBox verifyPass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label confirmPass;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.TextBox txt_registrationNo;
        private System.Windows.Forms.Label hosRegNo;
        private System.Windows.Forms.ComboBox txt_hospitality;
        private System.Windows.Forms.Label treatment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.ComboBox txt_speciality;
        private System.Windows.Forms.Label speciality;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Button btnEncrpt;
        private LinkLabel signUp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        public ComboBox comboBox1;
        public Label label1;
        private Label answer;
        private TextBox txt_security;
    }
}
namespace Healthcare_Record_System_Using_Blockchain
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.msg = new System.Windows.Forms.Label();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.HospitalSignUp = new System.Windows.Forms.LinkLabel();
            this.MET = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.drLoginBox = new System.Windows.Forms.GroupBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.adminIcon = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.wel = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.HCRS = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.layout = new System.Windows.Forms.Panel();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.drLoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).BeginInit();
            this.header.SuspendLayout();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(474, 213);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(231, 27);
            this.msg.TabIndex = 28;
            this.msg.Text = "Don\'t Have A Account?";
            this.toolTip5.SetToolTip(this.msg, "Don\'t Worry Just Click On Sign Up");
            // 
            // HospitalSignUp
            // 
            this.HospitalSignUp.ActiveLinkColor = System.Drawing.Color.Black;
            this.HospitalSignUp.AutoSize = true;
            this.HospitalSignUp.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalSignUp.LinkColor = System.Drawing.Color.Black;
            this.HospitalSignUp.Location = new System.Drawing.Point(530, 255);
            this.HospitalSignUp.Name = "HospitalSignUp";
            this.HospitalSignUp.Size = new System.Drawing.Size(121, 22);
            this.HospitalSignUp.TabIndex = 27;
            this.HospitalSignUp.TabStop = true;
            this.HospitalSignUp.Text = "SIGN UP";
            this.toolTip3.SetToolTip(this.HospitalSignUp, "Create Account By Clicking Here");
            this.HospitalSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HospitalSignUp_LinkClicked);
            // 
            // MET
            // 
            this.MET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MET.AutoSize = true;
            this.MET.BackColor = System.Drawing.Color.Transparent;
            this.MET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MET.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MET.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.MET.Location = new System.Drawing.Point(194, 4);
            this.MET.Name = "MET";
            this.MET.Size = new System.Drawing.Size(961, 37);
            this.MET.TabIndex = 31;
            this.MET.Text = "METIOE, BE, department of computer engineering 2024";
            this.MET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.Desktop;
            this.footer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.footer.Controls.Add(this.MET);
            this.footer.Location = new System.Drawing.Point(-2, 559);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1370, 50);
            this.footer.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // drLoginBox
            // 
            this.drLoginBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.drLoginBox.BackColor = System.Drawing.Color.Cornsilk;
            this.drLoginBox.Controls.Add(this.line);
            this.drLoginBox.Controls.Add(this.adminIcon);
            this.drLoginBox.Controls.Add(this.msg);
            this.drLoginBox.Controls.Add(this.HospitalSignUp);
            this.drLoginBox.Controls.Add(this.txt_username);
            this.drLoginBox.Controls.Add(this.pass);
            this.drLoginBox.Controls.Add(this.username);
            this.drLoginBox.Controls.Add(this.txt_password);
            this.drLoginBox.Controls.Add(this.btnLogin);
            this.drLoginBox.Controls.Add(this.btnCancel);
            this.drLoginBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drLoginBox.ForeColor = System.Drawing.Color.Crimson;
            this.errorProvider1.SetIconAlignment(this.drLoginBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.drLoginBox.Location = new System.Drawing.Point(282, 140);
            this.drLoginBox.Name = "drLoginBox";
            this.drLoginBox.Size = new System.Drawing.Size(799, 316);
            this.drLoginBox.TabIndex = 4;
            this.drLoginBox.TabStop = false;
            this.drLoginBox.Text = "HOSPITAL LOGIN";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(275, 13);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(11, 313);
            this.line.TabIndex = 6;
            this.line.TabStop = false;
            // 
            // adminIcon
            // 
            this.adminIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminIcon.BackgroundImage")));
            this.adminIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminIcon.Location = new System.Drawing.Point(49, 66);
            this.adminIcon.Name = "adminIcon";
            this.adminIcon.Size = new System.Drawing.Size(186, 211);
            this.adminIcon.TabIndex = 29;
            this.adminIcon.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_username.Location = new System.Drawing.Point(447, 60);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(301, 26);
            this.txt_username.TabIndex = 20;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_username, "Please Enter User Name");
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Location = new System.Drawing.Point(316, 114);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(99, 18);
            this.pass.TabIndex = 25;
            this.pass.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(316, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(104, 18);
            this.username.TabIndex = 26;
            this.username.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_password.Location = new System.Drawing.Point(447, 108);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(301, 26);
            this.txt_password.TabIndex = 21;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip2.SetToolTip(this.txt_password, "Please Enter Valid Password");
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(446, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 36);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.toolTip4.SetToolTip(this.btnLogin, "Click Here To Login");
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(616, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.toolTip4.SetToolTip(this.btnCancel, "Click Here To Cancel");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // wel
            // 
            this.wel.AutoSize = true;
            this.wel.BackColor = System.Drawing.Color.Transparent;
            this.wel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wel.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wel.Location = new System.Drawing.Point(529, 46);
            this.wel.Name = "wel";
            this.wel.Size = new System.Drawing.Size(322, 38);
            this.wel.TabIndex = 5;
            this.wel.Text = "WELCOME USER...!!!";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(12, 3);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 18);
            this.labelDate.TabIndex = 27;
            this.labelDate.Text = "Date :";
            // 
            // HCRS
            // 
            this.HCRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HCRS.AutoSize = true;
            this.HCRS.BackColor = System.Drawing.Color.Transparent;
            this.HCRS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HCRS.Font = new System.Drawing.Font("Algerian", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCRS.ForeColor = System.Drawing.SystemColors.Control;
            this.HCRS.Location = new System.Drawing.Point(355, 4);
            this.HCRS.Name = "HCRS";
            this.HCRS.Size = new System.Drawing.Size(948, 43);
            this.HCRS.TabIndex = 1;
            this.HCRS.Text = "Health Care Record System Using  Blockchain";
            this.HCRS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(84, 30);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(104, 18);
            this.time.TabIndex = 30;
            this.time.Text = "User Name";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(12, 30);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(58, 18);
            this.labelTime.TabIndex = 29;
            this.labelTime.Text = "Time :";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(84, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 18);
            this.date.TabIndex = 28;
            this.date.Text = "User Name";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Desktop;
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header.Controls.Add(this.time);
            this.header.Controls.Add(this.labelTime);
            this.header.Controls.Add(this.date);
            this.header.Controls.Add(this.labelDate);
            this.header.Controls.Add(this.HCRS);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Transparent;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1370, 50);
            this.header.TabIndex = 9;
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.layout.Controls.Add(this.footer);
            this.layout.Controls.Add(this.drLoginBox);
            this.layout.Controls.Add(this.wel);
            this.layout.ForeColor = System.Drawing.SystemColors.Control;
            this.layout.Location = new System.Drawing.Point(0, 50);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(1370, 615);
            this.layout.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 661);
            this.Controls.Add(this.header);
            this.Controls.Add(this.layout);
            this.Name = "Login";
            this.Text = "HospitalLogin";
            this.Load += new System.EventHandler(this.Login_Load);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.drLoginBox.ResumeLayout(false);
            this.drLoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminIcon)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.LinkLabel HospitalSignUp;
        private System.Windows.Forms.Label MET;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label HCRS;
        private System.Windows.Forms.Panel layout;
        private System.Windows.Forms.GroupBox drLoginBox;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox adminIcon;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label wel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
    }
}
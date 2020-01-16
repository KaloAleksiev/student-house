namespace Project1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStHouse = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.TabPage();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.complaints = new System.Windows.Forms.TabPage();
            this.btnSeeClosedComplaints = new System.Windows.Forms.Button();
            this.btnSeeOpenComplaints = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Announcements = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.complaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Announcements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblStHouse
            // 
            this.lblStHouse.AutoSize = true;
            this.lblStHouse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStHouse.ForeColor = System.Drawing.Color.Gold;
            this.lblStHouse.Location = new System.Drawing.Point(203, 28);
            this.lblStHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStHouse.Name = "lblStHouse";
            this.lblStHouse.Size = new System.Drawing.Size(331, 60);
            this.lblStHouse.TabIndex = 17;
            this.lblStHouse.Text = "Student House";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Blue;
            this.lblPage.Location = new System.Drawing.Point(561, 28);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(163, 60);
            this.lblPage.TabIndex = 16;
            this.lblPage.Text = "Admin";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Register);
            this.tabControl1.Controls.Add(this.complaints);
            this.tabControl1.Controls.Add(this.Announcements);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 553);
            this.tabControl1.TabIndex = 18;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.pictureBox2);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.label2);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(761, 524);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(199, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 60);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(557, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 60);
            this.label2.TabIndex = 19;
            this.label2.Text = "Admin";
            // 
            // Register
            // 
            this.Register.Controls.Add(this.btnCreateAccount);
            this.Register.Controls.Add(this.tbRoomId);
            this.Register.Controls.Add(this.tbPassword);
            this.Register.Controls.Add(this.tbEmail);
            this.Register.Controls.Add(this.tbLastName);
            this.Register.Controls.Add(this.tbFirstName);
            this.Register.Controls.Add(this.label9);
            this.Register.Controls.Add(this.label8);
            this.Register.Controls.Add(this.label7);
            this.Register.Controls.Add(this.label6);
            this.Register.Controls.Add(this.label5);
            this.Register.Controls.Add(this.label4);
            this.Register.Controls.Add(this.label3);
            this.Register.Controls.Add(this.pictureBox3);
            this.Register.Location = new System.Drawing.Point(4, 25);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(3);
            this.Register.Size = new System.Drawing.Size(761, 524);
            this.Register.TabIndex = 1;
            this.Register.Text = "Create an account";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(409, 300);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(176, 74);
            this.btnCreateAccount.TabIndex = 33;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbRoomId
            // 
            this.tbRoomId.Location = new System.Drawing.Point(184, 438);
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.Size = new System.Drawing.Size(100, 22);
            this.tbRoomId.TabIndex = 32;
            this.tbRoomId.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(184, 380);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 31;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(184, 326);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 22);
            this.tbEmail.TabIndex = 30;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(184, 278);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 22);
            this.tbLastName.TabIndex = 29;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(184, 230);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbFirstName.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Room Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Last name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(199, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 60);
            this.label4.TabIndex = 22;
            this.label4.Text = "Create a student account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(199, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 60);
            this.label3.TabIndex = 21;
            this.label3.Text = "Student House";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 53);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // complaints
            // 
            this.complaints.Controls.Add(this.btnSeeClosedComplaints);
            this.complaints.Controls.Add(this.btnSeeOpenComplaints);
            this.complaints.Controls.Add(this.pictureBox4);
            this.complaints.Controls.Add(this.label10);
            this.complaints.Controls.Add(this.label11);
            this.complaints.Location = new System.Drawing.Point(4, 25);
            this.complaints.Name = "complaints";
            this.complaints.Size = new System.Drawing.Size(761, 524);
            this.complaints.TabIndex = 2;
            this.complaints.Text = "Complaints";
            this.complaints.UseVisualStyleBackColor = true;
            // 
            // btnSeeClosedComplaints
            // 
            this.btnSeeClosedComplaints.Location = new System.Drawing.Point(209, 362);
            this.btnSeeClosedComplaints.Name = "btnSeeClosedComplaints";
            this.btnSeeClosedComplaints.Size = new System.Drawing.Size(237, 74);
            this.btnSeeClosedComplaints.TabIndex = 26;
            this.btnSeeClosedComplaints.Text = "See closed complaints";
            this.btnSeeClosedComplaints.UseVisualStyleBackColor = true;
            this.btnSeeClosedComplaints.Click += new System.EventHandler(this.btnSeeClosedComplaints_Click_1);
            // 
            // btnSeeOpenComplaints
            // 
            this.btnSeeOpenComplaints.Location = new System.Drawing.Point(209, 241);
            this.btnSeeOpenComplaints.Name = "btnSeeOpenComplaints";
            this.btnSeeOpenComplaints.Size = new System.Drawing.Size(237, 74);
            this.btnSeeOpenComplaints.TabIndex = 24;
            this.btnSeeOpenComplaints.Text = "See open complaints";
            this.btnSeeOpenComplaints.UseVisualStyleBackColor = true;
            this.btnSeeOpenComplaints.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 33);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(199, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 60);
            this.label10.TabIndex = 23;
            this.label10.Text = "Student House";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(213, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 60);
            this.label11.TabIndex = 22;
            this.label11.Text = "Complaints";
            // 
            // Announcements
            // 
            this.Announcements.Controls.Add(this.btnRefresh);
            this.Announcements.Controls.Add(this.btnAnnouncement);
            this.Announcements.Controls.Add(this.label12);
            this.Announcements.Controls.Add(this.lblAnnouncements);
            this.Announcements.Controls.Add(this.pictureBox5);
            this.Announcements.Controls.Add(this.lbAnnouncements);
            this.Announcements.Location = new System.Drawing.Point(4, 25);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(761, 524);
            this.Announcements.TabIndex = 3;
            this.Announcements.Text = "Announcements";
            this.Announcements.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(518, 206);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 54);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAnnouncement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncement.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncement.Location = new System.Drawing.Point(518, 424);
            this.btnAnnouncement.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(209, 80);
            this.btnAnnouncement.TabIndex = 24;
            this.btnAnnouncement.Text = "New Announcement";
            this.btnAnnouncement.UseVisualStyleBackColor = false;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(210, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(331, 60);
            this.label12.TabIndex = 23;
            this.label12.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(210, 99);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(329, 54);
            this.lblAnnouncements.TabIndex = 22;
            this.lblAnnouncements.Text = "Announcements";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(33, 21);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 134);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbAnnouncements.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnouncements.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 21;
            this.lbAnnouncements.Location = new System.Drawing.Point(33, 206);
            this.lbAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(463, 277);
            this.lbAnnouncements.TabIndex = 20;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(769, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStHouse);
            this.Controls.Add(this.lblPage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.complaints.ResumeLayout(false);
            this.complaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Announcements.ResumeLayout(false);
            this.Announcements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStHouse;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Register;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TabPage complaints;
        private System.Windows.Forms.Button btnSeeOpenComplaints;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSeeClosedComplaints;
        private System.Windows.Forms.TabPage Announcements;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAnnouncement;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox lbAnnouncements;
    }
}
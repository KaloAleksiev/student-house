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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NewTenant = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.Complaints = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.NewTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Complaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Announcements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NewTenant);
            this.tabControl1.Controls.Add(this.Complaints);
            this.tabControl1.Controls.Add(this.Announcements);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 391);
            this.tabControl1.TabIndex = 18;
            // 
            // NewTenant
            // 
            this.NewTenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.NewTenant.Controls.Add(this.label1);
            this.NewTenant.Controls.Add(this.label2);
            this.NewTenant.Controls.Add(this.pictureBox2);
            this.NewTenant.Controls.Add(this.btnCreateAccount);
            this.NewTenant.Controls.Add(this.tbRoomId);
            this.NewTenant.Controls.Add(this.tbPassword);
            this.NewTenant.Controls.Add(this.tbEmail);
            this.NewTenant.Controls.Add(this.tbLastName);
            this.NewTenant.Controls.Add(this.tbFirstName);
            this.NewTenant.Controls.Add(this.label9);
            this.NewTenant.Controls.Add(this.label8);
            this.NewTenant.Controls.Add(this.label7);
            this.NewTenant.Controls.Add(this.label6);
            this.NewTenant.Controls.Add(this.label5);
            this.NewTenant.Location = new System.Drawing.Point(4, 26);
            this.NewTenant.Margin = new System.Windows.Forms.Padding(2);
            this.NewTenant.Name = "NewTenant";
            this.NewTenant.Padding = new System.Windows.Forms.Padding(2);
            this.NewTenant.Size = new System.Drawing.Size(444, 361);
            this.NewTenant.TabIndex = 1;
            this.NewTenant.Text = "New Tenant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(151, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 47);
            this.label1.TabIndex = 36;
            this.label1.Text = "Student House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(151, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 45);
            this.label2.TabIndex = 35;
            this.label2.Text = "New tenant";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(230, 270);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(153, 44);
            this.btnCreateAccount.TabIndex = 33;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbRoomId
            // 
            this.tbRoomId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomId.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbRoomId.Location = new System.Drawing.Point(47, 289);
            this.tbRoomId.Margin = new System.Windows.Forms.Padding(2);
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.Size = new System.Drawing.Size(153, 25);
            this.tbRoomId.TabIndex = 32;
            this.tbRoomId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRoomId.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbPassword.Location = new System.Drawing.Point(230, 228);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(153, 25);
            this.tbPassword.TabIndex = 31;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbEmail.Location = new System.Drawing.Point(230, 167);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(153, 25);
            this.tbEmail.TabIndex = 30;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbLastName.Location = new System.Drawing.Point(47, 228);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(153, 25);
            this.tbLastName.TabIndex = 29;
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbFirstName.Location = new System.Drawing.Point(47, 167);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(153, 25);
            this.tbFirstName.TabIndex = 28;
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(94, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Room ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label8.Location = new System.Drawing.Point(278, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label7.Location = new System.Drawing.Point(288, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(85, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Last name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(84, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "First name";
            // 
            // Complaints
            // 
            this.Complaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Complaints.Controls.Add(this.btnSeeClosedComplaints);
            this.Complaints.Controls.Add(this.btnSeeOpenComplaints);
            this.Complaints.Controls.Add(this.pictureBox4);
            this.Complaints.Controls.Add(this.label10);
            this.Complaints.Controls.Add(this.label11);
            this.Complaints.Location = new System.Drawing.Point(4, 26);
            this.Complaints.Margin = new System.Windows.Forms.Padding(2);
            this.Complaints.Name = "Complaints";
            this.Complaints.Size = new System.Drawing.Size(444, 361);
            this.Complaints.TabIndex = 2;
            this.Complaints.Text = "Complaints";
            // 
            // btnSeeClosedComplaints
            // 
            this.btnSeeClosedComplaints.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSeeClosedComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeClosedComplaints.ForeColor = System.Drawing.Color.White;
            this.btnSeeClosedComplaints.Location = new System.Drawing.Point(133, 249);
            this.btnSeeClosedComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeClosedComplaints.Name = "btnSeeClosedComplaints";
            this.btnSeeClosedComplaints.Size = new System.Drawing.Size(178, 60);
            this.btnSeeClosedComplaints.TabIndex = 26;
            this.btnSeeClosedComplaints.Text = "Closed complaints";
            this.btnSeeClosedComplaints.UseVisualStyleBackColor = false;
            this.btnSeeClosedComplaints.Click += new System.EventHandler(this.btnSeeClosedComplaints_Click_1);
            // 
            // btnSeeOpenComplaints
            // 
            this.btnSeeOpenComplaints.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSeeOpenComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeOpenComplaints.ForeColor = System.Drawing.Color.White;
            this.btnSeeOpenComplaints.Location = new System.Drawing.Point(133, 171);
            this.btnSeeOpenComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeOpenComplaints.Name = "btnSeeOpenComplaints";
            this.btnSeeOpenComplaints.Size = new System.Drawing.Size(178, 60);
            this.btnSeeOpenComplaints.TabIndex = 24;
            this.btnSeeOpenComplaints.Text = "Open complaints";
            this.btnSeeOpenComplaints.UseVisualStyleBackColor = false;
            this.btnSeeOpenComplaints.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(149, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 47);
            this.label10.TabIndex = 23;
            this.label10.Text = "Student House";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(149, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 47);
            this.label11.TabIndex = 22;
            this.label11.Text = "Complaints";
            // 
            // Announcements
            // 
            this.Announcements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Announcements.Controls.Add(this.btnRefresh);
            this.Announcements.Controls.Add(this.btnAnnouncement);
            this.Announcements.Controls.Add(this.label12);
            this.Announcements.Controls.Add(this.lblAnnouncements);
            this.Announcements.Controls.Add(this.pictureBox5);
            this.Announcements.Controls.Add(this.lbAnnouncements);
            this.Announcements.Location = new System.Drawing.Point(4, 26);
            this.Announcements.Margin = new System.Windows.Forms.Padding(2);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(444, 361);
            this.Announcements.TabIndex = 3;
            this.Announcements.Text = "Announcements";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(17, 296);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 44);
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
            this.btnAnnouncement.Location = new System.Drawing.Point(214, 296);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(210, 44);
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
            this.label12.Location = new System.Drawing.Point(150, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 47);
            this.label12.TabIndex = 23;
            this.label12.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(150, 80);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(262, 45);
            this.lblAnnouncements.TabIndex = 22;
            this.lblAnnouncements.Text = "Announcements";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 109);
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
            this.lbAnnouncements.ItemHeight = 17;
            this.lbAnnouncements.Location = new System.Drawing.Point(17, 149);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(407, 140);
            this.lbAnnouncements.TabIndex = 20;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(447, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Administrator API";
            this.tabControl1.ResumeLayout(false);
            this.NewTenant.ResumeLayout(false);
            this.NewTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Complaints.ResumeLayout(false);
            this.Complaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Announcements.ResumeLayout(false);
            this.Announcements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NewTenant;
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
        private System.Windows.Forms.TabPage Complaints;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
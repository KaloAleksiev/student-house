namespace Project1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblStHouse = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnCleaningSchedule = new System.Windows.Forms.Button();
            this.btnGroceries = new System.Windows.Forms.Button();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateChanged = new System.Windows.Forms.Label();
            this.lblWhoCleansToday = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.lblTrashOut = new System.Windows.Forms.Label();
            this.lblNextClean = new System.Windows.Forms.Label();
            this.lblAnn = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Groceries = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lsbGroceriesStudents = new System.Windows.Forms.ListBox();
            this.lsbGroceriesPayments = new System.Windows.Forms.ListBox();
            this.tbxPurchase = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubstractAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSubmitGroceries = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.Announcements = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.Complaints = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOldComplaints = new System.Windows.Forms.Button();
            this.btnCreateComplaint = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Rules = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRules = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Schedule.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Groceries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.Announcements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Complaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Home);
            this.tabControl.Controls.Add(this.Schedule);
            this.tabControl.Controls.Add(this.Groceries);
            this.tabControl.Controls.Add(this.Announcements);
            this.tabControl.Controls.Add(this.Complaints);
            this.tabControl.Controls.Add(this.Rules);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-3, -4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(577, 468);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Home.Controls.Add(this.lblDateTime);
            this.Home.Controls.Add(this.lblStHouse);
            this.Home.Controls.Add(this.lblPage);
            this.Home.Controls.Add(this.panel2);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.lblStudentHouse);
            this.Home.Location = new System.Drawing.Point(4, 26);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(569, 438);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Blue;
            this.lblDateTime.Location = new System.Drawing.Point(373, 88);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 40);
            this.lblDateTime.TabIndex = 12;
            // 
            // lblStHouse
            // 
            this.lblStHouse.AutoSize = true;
            this.lblStHouse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStHouse.ForeColor = System.Drawing.Color.Gold;
            this.lblStHouse.Location = new System.Drawing.Point(152, 24);
            this.lblStHouse.Name = "lblStHouse";
            this.lblStHouse.Size = new System.Drawing.Size(263, 47);
            this.lblStHouse.TabIndex = 11;
            this.lblStHouse.Text = "Student House";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Blue;
            this.lblPage.Location = new System.Drawing.Point(152, 88);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(175, 40);
            this.lblPage.TabIndex = 10;
            this.lblPage.Text = "Home Page";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRules);
            this.panel2.Controls.Add(this.btnComplaints);
            this.panel2.Controls.Add(this.btnCleaningSchedule);
            this.panel2.Controls.Add(this.btnGroceries);
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Location = new System.Drawing.Point(22, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 171);
            this.panel2.TabIndex = 7;
            // 
            // btnComplaints
            // 
            this.btnComplaints.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplaints.ForeColor = System.Drawing.Color.White;
            this.btnComplaints.Location = new System.Drawing.Point(358, 98);
            this.btnComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(155, 56);
            this.btnComplaints.TabIndex = 5;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = false;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnCleaningSchedule
            // 
            this.btnCleaningSchedule.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCleaningSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleaningSchedule.ForeColor = System.Drawing.Color.White;
            this.btnCleaningSchedule.Location = new System.Drawing.Point(11, 17);
            this.btnCleaningSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnCleaningSchedule.Name = "btnCleaningSchedule";
            this.btnCleaningSchedule.Size = new System.Drawing.Size(155, 56);
            this.btnCleaningSchedule.TabIndex = 2;
            this.btnCleaningSchedule.Text = "Cleaning Schedule";
            this.btnCleaningSchedule.UseVisualStyleBackColor = false;
            this.btnCleaningSchedule.Click += new System.EventHandler(this.btnCleaningSchedule_Click);
            // 
            // btnGroceries
            // 
            this.btnGroceries.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGroceries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroceries.ForeColor = System.Drawing.Color.White;
            this.btnGroceries.Location = new System.Drawing.Point(358, 17);
            this.btnGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroceries.Name = "btnGroceries";
            this.btnGroceries.Size = new System.Drawing.Size(155, 56);
            this.btnGroceries.TabIndex = 4;
            this.btnGroceries.Text = "Groceries";
            this.btnGroceries.UseVisualStyleBackColor = false;
            this.btnGroceries.Click += new System.EventHandler(this.btnGroceries_Click);
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAnnouncements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncements.Location = new System.Drawing.Point(11, 98);
            this.btnAnnouncements.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(155, 56);
            this.btnAnnouncements.TabIndex = 3;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentHouse.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblStudentHouse.Location = new System.Drawing.Point(58, 170);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(0, 45);
            this.lblStudentHouse.TabIndex = 6;
            this.lblStudentHouse.Click += new System.EventHandler(this.lblStudentHouse_Click);
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Schedule.Controls.Add(this.panel1);
            this.Schedule.Controls.Add(this.label1);
            this.Schedule.Controls.Add(this.label2);
            this.Schedule.Controls.Add(this.pictureBox2);
            this.Schedule.Location = new System.Drawing.Point(4, 26);
            this.Schedule.Name = "Schedule";
            this.Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.Schedule.Size = new System.Drawing.Size(569, 438);
            this.Schedule.TabIndex = 1;
            this.Schedule.Text = "Schedule";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDateChanged);
            this.panel1.Controls.Add(this.lblWhoCleansToday);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.rbtnNo);
            this.panel1.Controls.Add(this.rbtnYes);
            this.panel1.Controls.Add(this.lblTrashOut);
            this.panel1.Controls.Add(this.lblNextClean);
            this.panel1.Controls.Add(this.lblAnn);
            this.panel1.Controls.Add(this.calendar);
            this.panel1.Location = new System.Drawing.Point(11, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 235);
            this.panel1.TabIndex = 15;
            // 
            // lblDateChanged
            // 
            this.lblDateChanged.AutoSize = true;
            this.lblDateChanged.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblDateChanged.Location = new System.Drawing.Point(24, 206);
            this.lblDateChanged.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateChanged.Name = "lblDateChanged";
            this.lblDateChanged.Size = new System.Drawing.Size(0, 17);
            this.lblDateChanged.TabIndex = 12;
            // 
            // lblWhoCleansToday
            // 
            this.lblWhoCleansToday.AutoSize = true;
            this.lblWhoCleansToday.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWhoCleansToday.Location = new System.Drawing.Point(237, 77);
            this.lblWhoCleansToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhoCleansToday.Name = "lblWhoCleansToday";
            this.lblWhoCleansToday.Size = new System.Drawing.Size(0, 17);
            this.lblWhoCleansToday.TabIndex = 11;
            this.lblWhoCleansToday.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(327, 152);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 32);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnNo.Location = new System.Drawing.Point(402, 123);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(50, 25);
            this.rbtnNo.TabIndex = 9;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYes.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnYes.Location = new System.Drawing.Point(327, 123);
            this.rbtnYes.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(52, 25);
            this.rbtnYes.TabIndex = 8;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblTrashOut
            // 
            this.lblTrashOut.AutoSize = true;
            this.lblTrashOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrashOut.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTrashOut.Location = new System.Drawing.Point(262, 104);
            this.lblTrashOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrashOut.Name = "lblTrashOut";
            this.lblTrashOut.Size = new System.Drawing.Size(259, 21);
            this.lblTrashOut.TabIndex = 7;
            this.lblTrashOut.Text = "Have you taken the trash out today?";
            // 
            // lblNextClean
            // 
            this.lblNextClean.AutoSize = true;
            this.lblNextClean.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextClean.ForeColor = System.Drawing.Color.Gold;
            this.lblNextClean.Location = new System.Drawing.Point(260, 53);
            this.lblNextClean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNextClean.Name = "lblNextClean";
            this.lblNextClean.Size = new System.Drawing.Size(277, 21);
            this.lblNextClean.TabIndex = 6;
            this.lblNextClean.Text = "Wash the dishes and take the trash out";
            // 
            // lblAnn
            // 
            this.lblAnn.AutoSize = true;
            this.lblAnn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnn.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblAnn.Location = new System.Drawing.Point(260, 24);
            this.lblAnn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnn.Name = "lblAnn";
            this.lblAnn.Size = new System.Drawing.Size(139, 21);
            this.lblAnn.TabIndex = 5;
            this.lblAnn.Text = "Today\'s chores for ";
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.calendar.Location = new System.Drawing.Point(26, 22);
            this.calendar.Margin = new System.Windows.Forms.Padding(7);
            this.calendar.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 4;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(152, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 47);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(152, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cleaning Schedule";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Groceries
            // 
            this.Groceries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Groceries.Controls.Add(this.label5);
            this.Groceries.Controls.Add(this.label6);
            this.Groceries.Controls.Add(this.pictureBox3);
            this.Groceries.Controls.Add(this.panel3);
            this.Groceries.Location = new System.Drawing.Point(4, 26);
            this.Groceries.Name = "Groceries";
            this.Groceries.Size = new System.Drawing.Size(569, 438);
            this.Groceries.TabIndex = 2;
            this.Groceries.Text = "Groceries";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(153, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 47);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student House";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(153, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 45);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grocery List";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lsbGroceriesStudents);
            this.panel3.Controls.Add(this.lsbGroceriesPayments);
            this.panel3.Controls.Add(this.tbxPurchase);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbSubstractAmount);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.btnSubmitGroceries);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Location = new System.Drawing.Point(23, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 287);
            this.panel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(366, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 30);
            this.label12.TabIndex = 17;
            this.label12.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label11.Location = new System.Drawing.Point(198, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 30);
            this.label11.TabIndex = 16;
            this.label11.Text = "Balances:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label10.Location = new System.Drawing.Point(3, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "Payments:";
            // 
            // lsbGroceriesStudents
            // 
            this.lsbGroceriesStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lsbGroceriesStudents.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lsbGroceriesStudents.FormattingEnabled = true;
            this.lsbGroceriesStudents.ItemHeight = 17;
            this.lsbGroceriesStudents.Location = new System.Drawing.Point(203, 118);
            this.lsbGroceriesStudents.Name = "lsbGroceriesStudents";
            this.lsbGroceriesStudents.Size = new System.Drawing.Size(112, 157);
            this.lsbGroceriesStudents.TabIndex = 14;
            // 
            // lsbGroceriesPayments
            // 
            this.lsbGroceriesPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lsbGroceriesPayments.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lsbGroceriesPayments.FormattingEnabled = true;
            this.lsbGroceriesPayments.ItemHeight = 17;
            this.lsbGroceriesPayments.Location = new System.Drawing.Point(8, 118);
            this.lsbGroceriesPayments.Name = "lsbGroceriesPayments";
            this.lsbGroceriesPayments.Size = new System.Drawing.Size(186, 157);
            this.lsbGroceriesPayments.TabIndex = 13;
            // 
            // tbxPurchase
            // 
            this.tbxPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.tbxPurchase.ForeColor = System.Drawing.Color.White;
            this.tbxPurchase.Location = new System.Drawing.Point(8, 47);
            this.tbxPurchase.Name = "tbxPurchase";
            this.tbxPurchase.Size = new System.Drawing.Size(186, 25);
            this.tbxPurchase.TabIndex = 12;
            this.tbxPurchase.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(198, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase:";
            // 
            // tbSubstractAmount
            // 
            this.tbSubstractAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.tbSubstractAmount.ForeColor = System.Drawing.Color.White;
            this.tbSubstractAmount.Location = new System.Drawing.Point(464, 207);
            this.tbSubstractAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbSubstractAmount.Name = "tbSubstractAmount";
            this.tbSubstractAmount.Size = new System.Drawing.Size(45, 25);
            this.tbSubstractAmount.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(320, 236);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(189, 39);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay selected member";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSubmitGroceries
            // 
            this.btnSubmitGroceries.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmitGroceries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGroceries.ForeColor = System.Drawing.Color.White;
            this.btnSubmitGroceries.Location = new System.Drawing.Point(320, 47);
            this.btnSubmitGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitGroceries.Name = "btnSubmitGroceries";
            this.btnSubmitGroceries.Size = new System.Drawing.Size(189, 39);
            this.btnSubmitGroceries.TabIndex = 4;
            this.btnSubmitGroceries.Text = "Submit Purchase";
            this.btnSubmitGroceries.UseVisualStyleBackColor = false;
            this.btnSubmitGroceries.Click += new System.EventHandler(this.btnSubmitGroceries_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(203, 47);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(88, 25);
            this.tbPrice.TabIndex = 1;
            // 
            // Announcements
            // 
            this.Announcements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Announcements.Controls.Add(this.btnRefresh);
            this.Announcements.Controls.Add(this.btnAnnouncement);
            this.Announcements.Controls.Add(this.label7);
            this.Announcements.Controls.Add(this.lblAnnouncements);
            this.Announcements.Controls.Add(this.pictureBox4);
            this.Announcements.Controls.Add(this.lbAnnouncements);
            this.Announcements.Location = new System.Drawing.Point(4, 26);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(569, 438);
            this.Announcements.TabIndex = 3;
            this.Announcements.Text = "Announcements";
            this.Announcements.Click += new System.EventHandler(this.Announcements_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(408, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 44);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAnnouncement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncement.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncement.Location = new System.Drawing.Point(408, 335);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(137, 65);
            this.btnAnnouncement.TabIndex = 18;
            this.btnAnnouncement.Text = "New Announcement";
            this.btnAnnouncement.UseVisualStyleBackColor = false;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(157, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 47);
            this.label7.TabIndex = 17;
            this.label7.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(157, 88);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(262, 45);
            this.lblAnnouncements.TabIndex = 16;
            this.lblAnnouncements.Text = "Announcements";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbAnnouncements.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnnouncements.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 17;
            this.lbAnnouncements.Location = new System.Drawing.Point(24, 175);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(378, 225);
            this.lbAnnouncements.TabIndex = 0;
            this.lbAnnouncements.SelectedIndexChanged += new System.EventHandler(this.lbAnnouncements_SelectedIndexChanged);
            // 
            // Complaints
            // 
            this.Complaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Complaints.Controls.Add(this.textBox1);
            this.Complaints.Controls.Add(this.btnOldComplaints);
            this.Complaints.Controls.Add(this.btnCreateComplaint);
            this.Complaints.Controls.Add(this.label8);
            this.Complaints.Controls.Add(this.label9);
            this.Complaints.Controls.Add(this.pictureBox5);
            this.Complaints.Location = new System.Drawing.Point(4, 26);
            this.Complaints.Name = "Complaints";
            this.Complaints.Size = new System.Drawing.Size(569, 438);
            this.Complaints.TabIndex = 4;
            this.Complaints.Text = "Complaints";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.textBox1.Location = new System.Drawing.Point(115, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 90);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Complaints are personal and get directly sent to the administrator.  Other tenant" +
    "s cannot access your complaints. The administrator will review and answer your m" +
    "essage.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOldComplaints
            // 
            this.btnOldComplaints.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOldComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldComplaints.ForeColor = System.Drawing.Color.White;
            this.btnOldComplaints.Location = new System.Drawing.Point(115, 284);
            this.btnOldComplaints.Name = "btnOldComplaints";
            this.btnOldComplaints.Size = new System.Drawing.Size(339, 35);
            this.btnOldComplaints.TabIndex = 26;
            this.btnOldComplaints.Text = "Your previous complaints";
            this.btnOldComplaints.UseVisualStyleBackColor = false;
            this.btnOldComplaints.Click += new System.EventHandler(this.btnOldComplaints_Click);
            // 
            // btnCreateComplaint
            // 
            this.btnCreateComplaint.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateComplaint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateComplaint.ForeColor = System.Drawing.Color.White;
            this.btnCreateComplaint.Location = new System.Drawing.Point(115, 338);
            this.btnCreateComplaint.Name = "btnCreateComplaint";
            this.btnCreateComplaint.Size = new System.Drawing.Size(339, 62);
            this.btnCreateComplaint.TabIndex = 25;
            this.btnCreateComplaint.Text = "New Complaint";
            this.btnCreateComplaint.UseVisualStyleBackColor = false;
            this.btnCreateComplaint.Click += new System.EventHandler(this.btnCreateComplaint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(155, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 47);
            this.label8.TabIndex = 14;
            this.label8.Text = "Student House";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(155, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 40);
            this.label9.TabIndex = 13;
            this.label9.Text = "Complaints";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(25, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Rules.Controls.Add(this.richTextBox1);
            this.Rules.Controls.Add(this.label13);
            this.Rules.Controls.Add(this.label14);
            this.Rules.Controls.Add(this.pictureBox6);
            this.Rules.Location = new System.Drawing.Point(4, 26);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(569, 438);
            this.Rules.TabIndex = 5;
            this.Rules.Text = "Rules";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.richTextBox1.Location = new System.Drawing.Point(25, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(522, 282);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gold;
            this.label13.Location = new System.Drawing.Point(155, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 47);
            this.label13.TabIndex = 17;
            this.label13.Text = "Student House";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(155, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 40);
            this.label14.TabIndex = 16;
            this.label14.Text = "House Rules";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(25, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(106, 109);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.White;
            this.btnRules.Location = new System.Drawing.Point(185, 61);
            this.btnRules.Margin = new System.Windows.Forms.Padding(2);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(155, 56);
            this.btnRules.TabIndex = 6;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(573, 464);
            this.Controls.Add(this.tabControl);
            this.Name = "Form5";
            this.Text = "Student House API";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Groceries.ResumeLayout(false);
            this.Groceries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Announcements.ResumeLayout(false);
            this.Announcements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Complaints.ResumeLayout(false);
            this.Complaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Rules.ResumeLayout(false);
            this.Rules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TabPage Groceries;
        private System.Windows.Forms.TabPage Announcements;
        private System.Windows.Forms.Label lblStHouse;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCleaningSchedule;
        private System.Windows.Forms.Button btnGroceries;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStudentHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWhoCleansToday;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lblTrashOut;
        private System.Windows.Forms.Label lblNextClean;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubstractAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSubmitGroceries;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblAnn;
        private System.Windows.Forms.RichTextBox tbxPurchase;
        private System.Windows.Forms.Label lblDateChanged;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Button btnAnnouncement;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage Complaints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnOldComplaints;
        private System.Windows.Forms.Button btnCreateComplaint;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lsbGroceriesStudents;
        private System.Windows.Forms.ListBox lsbGroceriesPayments;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnRules;
    }
}
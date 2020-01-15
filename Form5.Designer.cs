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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubstractAmount = new System.Windows.Forms.TextBox();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.clbGroceries = new System.Windows.Forms.CheckedListBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOldComplaints = new System.Windows.Forms.Button();
            this.btnCreateComplaint = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Home);
            this.tabControl.Controls.Add(this.Schedule);
            this.tabControl.Controls.Add(this.Groceries);
            this.tabControl.Controls.Add(this.Announcements);
            this.tabControl.Controls.Add(this.Complaints);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(-4, -5);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(769, 576);
            this.tabControl.TabIndex = 0;
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
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Size = new System.Drawing.Size(761, 547);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Blue;
            this.lblDateTime.Location = new System.Drawing.Point(497, 108);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 50);
            this.lblDateTime.TabIndex = 12;
            // 
            // lblStHouse
            // 
            this.lblStHouse.AutoSize = true;
            this.lblStHouse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStHouse.ForeColor = System.Drawing.Color.Gold;
            this.lblStHouse.Location = new System.Drawing.Point(203, 30);
            this.lblStHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStHouse.Name = "lblStHouse";
            this.lblStHouse.Size = new System.Drawing.Size(331, 60);
            this.lblStHouse.TabIndex = 11;
            this.lblStHouse.Text = "Student House";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Blue;
            this.lblPage.Location = new System.Drawing.Point(203, 108);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(222, 50);
            this.lblPage.TabIndex = 10;
            this.lblPage.Text = "Home Page";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCleaningSchedule);
            this.panel2.Controls.Add(this.btnGroceries);
            this.panel2.Controls.Add(this.btnAnnouncements);
            this.panel2.Location = new System.Drawing.Point(29, 384);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 110);
            this.panel2.TabIndex = 7;
            // 
            // btnCleaningSchedule
            // 
            this.btnCleaningSchedule.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCleaningSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleaningSchedule.ForeColor = System.Drawing.Color.White;
            this.btnCleaningSchedule.Location = new System.Drawing.Point(15, 21);
            this.btnCleaningSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleaningSchedule.Name = "btnCleaningSchedule";
            this.btnCleaningSchedule.Size = new System.Drawing.Size(207, 69);
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
            this.btnGroceries.Location = new System.Drawing.Point(247, 21);
            this.btnGroceries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGroceries.Name = "btnGroceries";
            this.btnGroceries.Size = new System.Drawing.Size(207, 69);
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
            this.btnAnnouncements.Location = new System.Drawing.Point(477, 21);
            this.btnAnnouncements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(207, 69);
            this.btnAnnouncements.TabIndex = 3;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentHouse.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblStudentHouse.Location = new System.Drawing.Point(141, 228);
            this.lblStudentHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(0, 54);
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
            this.Schedule.Location = new System.Drawing.Point(4, 25);
            this.Schedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Schedule.Name = "Schedule";
            this.Schedule.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Schedule.Size = new System.Drawing.Size(761, 547);
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
            this.panel1.Location = new System.Drawing.Point(15, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 289);
            this.panel1.TabIndex = 15;
            // 
            // lblDateChanged
            // 
            this.lblDateChanged.AutoSize = true;
            this.lblDateChanged.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateChanged.Location = new System.Drawing.Point(32, 254);
            this.lblDateChanged.Name = "lblDateChanged";
            this.lblDateChanged.Size = new System.Drawing.Size(0, 17);
            this.lblDateChanged.TabIndex = 12;
            // 
            // lblWhoCleansToday
            // 
            this.lblWhoCleansToday.AutoSize = true;
            this.lblWhoCleansToday.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWhoCleansToday.Location = new System.Drawing.Point(316, 95);
            this.lblWhoCleansToday.Name = "lblWhoCleansToday";
            this.lblWhoCleansToday.Size = new System.Drawing.Size(0, 17);
            this.lblWhoCleansToday.TabIndex = 11;
            this.lblWhoCleansToday.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(451, 192);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 39);
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
            this.rbtnNo.Location = new System.Drawing.Point(551, 156);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(60, 32);
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
            this.rbtnYes.Location = new System.Drawing.Point(451, 156);
            this.rbtnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(63, 32);
            this.rbtnYes.TabIndex = 8;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblTrashOut
            // 
            this.lblTrashOut.AutoSize = true;
            this.lblTrashOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrashOut.ForeColor = System.Drawing.Color.Blue;
            this.lblTrashOut.Location = new System.Drawing.Point(349, 128);
            this.lblTrashOut.Name = "lblTrashOut";
            this.lblTrashOut.Size = new System.Drawing.Size(328, 28);
            this.lblTrashOut.TabIndex = 7;
            this.lblTrashOut.Text = "Have you taken the trash out today?";
            // 
            // lblNextClean
            // 
            this.lblNextClean.AutoSize = true;
            this.lblNextClean.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextClean.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblNextClean.Location = new System.Drawing.Point(347, 65);
            this.lblNextClean.Name = "lblNextClean";
            this.lblNextClean.Size = new System.Drawing.Size(347, 28);
            this.lblNextClean.TabIndex = 6;
            this.lblNextClean.Text = "Wash the dishes and take the trash out";
            // 
            // lblAnn
            // 
            this.lblAnn.AutoSize = true;
            this.lblAnn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnn.ForeColor = System.Drawing.Color.Blue;
            this.lblAnn.Location = new System.Drawing.Point(347, 30);
            this.lblAnn.Name = "lblAnn";
            this.lblAnn.Size = new System.Drawing.Size(174, 28);
            this.lblAnn.TabIndex = 5;
            this.lblAnn.Text = "Today\'s chores for ";
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.calendar.Location = new System.Drawing.Point(35, 27);
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
            this.label1.Location = new System.Drawing.Point(203, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Student House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(203, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cleaning Schedule";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 134);
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
            this.Groceries.Location = new System.Drawing.Point(4, 25);
            this.Groceries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Groceries.Name = "Groceries";
            this.Groceries.Size = new System.Drawing.Size(761, 547);
            this.Groceries.TabIndex = 2;
            this.Groceries.Text = "Groceries";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(204, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 60);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student House";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(204, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 54);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grocery List";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbSubstractAmount);
            this.panel3.Controls.Add(this.btnSubstract);
            this.panel3.Controls.Add(this.clbGroceries);
            this.panel3.Controls.Add(this.btnSubmitGroceries);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Location = new System.Drawing.Point(31, 194);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 314);
            this.panel3.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(148, 28);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(116, 78);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(59, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase:";
            // 
            // tbSubstractAmount
            // 
            this.tbSubstractAmount.Location = new System.Drawing.Point(539, 181);
            this.tbSubstractAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubstractAmount.Multiline = true;
            this.tbSubstractAmount.Name = "tbSubstractAmount";
            this.tbSubstractAmount.Size = new System.Drawing.Size(116, 36);
            this.tbSubstractAmount.TabIndex = 8;
            // 
            // btnSubstract
            // 
            this.btnSubstract.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubstract.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.ForeColor = System.Drawing.Color.White;
            this.btnSubstract.Location = new System.Drawing.Point(539, 234);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(117, 46);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "Subtract";
            this.btnSubstract.UseVisualStyleBackColor = false;
            // 
            // clbGroceries
            // 
            this.clbGroceries.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGroceries.FormattingEnabled = true;
            this.clbGroceries.Location = new System.Drawing.Point(297, 28);
            this.clbGroceries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbGroceries.Name = "clbGroceries";
            this.clbGroceries.Size = new System.Drawing.Size(212, 220);
            this.clbGroceries.TabIndex = 5;
            // 
            // btnSubmitGroceries
            // 
            this.btnSubmitGroceries.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmitGroceries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGroceries.ForeColor = System.Drawing.Color.White;
            this.btnSubmitGroceries.Location = new System.Drawing.Point(37, 213);
            this.btnSubmitGroceries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitGroceries.Name = "btnSubmitGroceries";
            this.btnSubmitGroceries.Size = new System.Drawing.Size(228, 66);
            this.btnSubmitGroceries.TabIndex = 4;
            this.btnSubmitGroceries.Text = "Submit Purchase";
            this.btnSubmitGroceries.UseVisualStyleBackColor = false;
            this.btnSubmitGroceries.Click += new System.EventHandler(this.btnSubmitGroceries_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(148, 145);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(116, 36);
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
            this.Announcements.Location = new System.Drawing.Point(4, 25);
            this.Announcements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(761, 547);
            this.Announcements.TabIndex = 3;
            this.Announcements.Text = "Announcements";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(32, 486);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(367, 28);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.Location = new System.Drawing.Point(485, 321);
            this.btnAnnouncement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(187, 58);
            this.btnAnnouncement.TabIndex = 18;
            this.btnAnnouncement.Text = "New Announcement";
            this.btnAnnouncement.UseVisualStyleBackColor = true;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(209, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 60);
            this.label7.TabIndex = 17;
            this.label7.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(209, 108);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(329, 54);
            this.lblAnnouncements.TabIndex = 16;
            this.lblAnnouncements.Text = "Announcements";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 30);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 16;
            this.lbAnnouncements.Location = new System.Drawing.Point(32, 191);
            this.lbAnnouncements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(365, 276);
            this.lbAnnouncements.TabIndex = 0;
            this.lbAnnouncements.SelectedIndexChanged += new System.EventHandler(this.lbAnnouncements_SelectedIndexChanged);
            // 
            // Complaints
            // 
            this.Complaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Complaints.Controls.Add(this.btnOldComplaints);
            this.Complaints.Controls.Add(this.btnCreateComplaint);
            this.Complaints.Controls.Add(this.label8);
            this.Complaints.Controls.Add(this.label9);
            this.Complaints.Controls.Add(this.pictureBox5);
            this.Complaints.Location = new System.Drawing.Point(4, 25);
            this.Complaints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Complaints.Name = "Complaints";
            this.Complaints.Size = new System.Drawing.Size(761, 547);
            this.Complaints.TabIndex = 4;
            this.Complaints.Text = "Complaints";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(207, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 60);
            this.label8.TabIndex = 14;
            this.label8.Text = "Student House";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(207, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 50);
            this.label9.TabIndex = 13;
            this.label9.Text = "Complaints";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(33, 31);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(141, 134);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOldComplaints
            // 
            this.btnOldComplaints.Location = new System.Drawing.Point(418, 308);
            this.btnOldComplaints.Margin = new System.Windows.Forms.Padding(4);
            this.btnOldComplaints.Name = "btnOldComplaints";
            this.btnOldComplaints.Size = new System.Drawing.Size(187, 58);
            this.btnOldComplaints.TabIndex = 26;
            this.btnOldComplaints.Text = "Your old complaints";
            this.btnOldComplaints.UseVisualStyleBackColor = true;
            this.btnOldComplaints.Click += new System.EventHandler(this.btnOldComplaints_Click);
            // 
            // btnCreateComplaint
            // 
            this.btnCreateComplaint.Location = new System.Drawing.Point(132, 308);
            this.btnCreateComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateComplaint.Name = "btnCreateComplaint";
            this.btnCreateComplaint.Size = new System.Drawing.Size(187, 58);
            this.btnCreateComplaint.TabIndex = 25;
            this.btnCreateComplaint.Text = "Create new complaint";
            this.btnCreateComplaint.UseVisualStyleBackColor = true;
            this.btnCreateComplaint.Click += new System.EventHandler(this.btnCreateComplaint_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(764, 565);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Form5";
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
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.CheckedListBox clbGroceries;
        private System.Windows.Forms.Button btnSubmitGroceries;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblAnn;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
    }
}
namespace Project1
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNextClean = new System.Windows.Forms.Label();
            this.lblAnn = new System.Windows.Forms.Label();
            this.lblCleaningSchedule = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblTrashOut = new System.Windows.Forms.Label();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWhoCleansToday = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStudentHouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(816, 4);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(53, 47);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWhoCleansToday);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.rbtnNo);
            this.panel2.Controls.Add(this.rbtnYes);
            this.panel2.Controls.Add(this.lblTrashOut);
            this.panel2.Controls.Add(this.lblNextClean);
            this.panel2.Controls.Add(this.lblAnn);
            this.panel2.Controls.Add(this.lblCleaningSchedule);
            this.panel2.Controls.Add(this.calendar);
            this.panel2.Location = new System.Drawing.Point(66, 147);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 432);
            this.panel2.TabIndex = 2;
            // 
            // lblNextClean
            // 
            this.lblNextClean.AutoSize = true;
            this.lblNextClean.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNextClean.Location = new System.Drawing.Point(313, 65);
            this.lblNextClean.Name = "lblNextClean";
            this.lblNextClean.Size = new System.Drawing.Size(46, 17);
            this.lblNextClean.TabIndex = 6;
            this.lblNextClean.Text = "label2";
            // 
            // lblAnn
            // 
            this.lblAnn.AutoSize = true;
            this.lblAnn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnn.Location = new System.Drawing.Point(313, 29);
            this.lblAnn.Name = "lblAnn";
            this.lblAnn.Size = new System.Drawing.Size(46, 17);
            this.lblAnn.TabIndex = 5;
            this.lblAnn.Text = "label1";
            // 
            // lblCleaningSchedule
            // 
            this.lblCleaningSchedule.AutoSize = true;
            this.lblCleaningSchedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCleaningSchedule.Location = new System.Drawing.Point(43, 256);
            this.lblCleaningSchedule.Name = "lblCleaningSchedule";
            this.lblCleaningSchedule.Size = new System.Drawing.Size(46, 17);
            this.lblCleaningSchedule.TabIndex = 4;
            this.lblCleaningSchedule.Text = "label1";
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendar.ForeColor = System.Drawing.SystemColors.Info;
            this.calendar.Location = new System.Drawing.Point(9, 9);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 4;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentHouse.ForeColor = System.Drawing.Color.White;
            this.lblStudentHouse.Location = new System.Drawing.Point(125, 18);
            this.lblStudentHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(0, 60);
            this.lblStudentHouse.TabIndex = 0;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(125, 71);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 60);
            this.lblPage.TabIndex = 4;
            // 
            // lblTrashOut
            // 
            this.lblTrashOut.AutoSize = true;
            this.lblTrashOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrashOut.Location = new System.Drawing.Point(313, 135);
            this.lblTrashOut.Name = "lblTrashOut";
            this.lblTrashOut.Size = new System.Drawing.Size(238, 17);
            this.lblTrashOut.TabIndex = 7;
            this.lblTrashOut.Text = "Have you taken the trash out today?";
            this.lblTrashOut.Visible = false;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnYes.Location = new System.Drawing.Point(334, 174);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(53, 21);
            this.rbtnYes.TabIndex = 8;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.Visible = false;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnNo.Location = new System.Drawing.Point(448, 174);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnNo.TabIndex = 9;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(372, 215);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Schedule";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStudentHouse;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label lblCleaningSchedule;
        private System.Windows.Forms.Label lblNextClean;
        private System.Windows.Forms.Label lblAnn;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblTrashOut;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lblWhoCleansToday;
    }
}
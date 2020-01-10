namespace Project1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStHouse = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCleaningSchedule = new System.Windows.Forms.Button();
            this.btnGroceries = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.lblStHouse);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStudentHouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 239);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblStHouse
            // 
            this.lblStHouse.AutoSize = true;
            this.lblStHouse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStHouse.ForeColor = System.Drawing.Color.Gold;
            this.lblStHouse.Location = new System.Drawing.Point(142, 12);
            this.lblStHouse.Name = "lblStHouse";
            this.lblStHouse.Size = new System.Drawing.Size(263, 47);
            this.lblStHouse.TabIndex = 5;
            this.lblStHouse.Text = "Student House";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Blue;
            this.lblPage.Location = new System.Drawing.Point(357, 74);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 37);
            this.lblPage.TabIndex = 4;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(511, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 38);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCleaningSchedule);
            this.panel2.Controls.Add(this.btnGroceries);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(12, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 89);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCleaningSchedule
            // 
            this.btnCleaningSchedule.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCleaningSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleaningSchedule.ForeColor = System.Drawing.Color.White;
            this.btnCleaningSchedule.Location = new System.Drawing.Point(19, 17);
            this.btnCleaningSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnCleaningSchedule.Name = "btnCleaningSchedule";
            this.btnCleaningSchedule.Size = new System.Drawing.Size(134, 56);
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
            this.btnGroceries.Location = new System.Drawing.Point(197, 17);
            this.btnGroceries.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroceries.Name = "btnGroceries";
            this.btnGroceries.Size = new System.Drawing.Size(134, 56);
            this.btnGroceries.TabIndex = 4;
            this.btnGroceries.Text = "Groceries";
            this.btnGroceries.UseVisualStyleBackColor = false;
            this.btnGroceries.Click += new System.EventHandler(this.btnGroceries_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(379, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Messages";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentHouse.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblStudentHouse.Location = new System.Drawing.Point(143, 74);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(0, 37);
            this.lblStudentHouse.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 239);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStudentHouse;
        private System.Windows.Forms.Button btnCleaningSchedule;
        private System.Windows.Forms.Button btnGroceries;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblStHouse;
    }
}
namespace Project1
{
    partial class AdminOpenComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOpenComplaints));
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.lbOpenComplaints = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(323, 101);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(0, 54);
            this.lblAnnouncements.TabIndex = 51;
            // 
            // lbOpenComplaints
            // 
            this.lbOpenComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbOpenComplaints.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpenComplaints.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbOpenComplaints.FormattingEnabled = true;
            this.lbOpenComplaints.ItemHeight = 21;
            this.lbOpenComplaints.Location = new System.Drawing.Point(66, 138);
            this.lbOpenComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOpenComplaints.Name = "lbOpenComplaints";
            this.lbOpenComplaints.Size = new System.Drawing.Size(375, 172);
            this.lbOpenComplaints.TabIndex = 62;
            this.lbOpenComplaints.SelectedIndexChanged += new System.EventHandler(this.lbOpenComplaints_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(139, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 60);
            this.label8.TabIndex = 85;
            this.label8.Text = "Student House";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(140, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 46);
            this.label9.TabIndex = 84;
            this.label9.Text = "Open Complaints";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(16, 15);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 107);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 83;
            this.pictureBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(135, 317);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 54);
            this.btnRefresh.TabIndex = 86;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AdminOpenComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(509, 384);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbOpenComplaints);
            this.Controls.Add(this.lblAnnouncements);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminOpenComplaints";
            this.Text = "Open Complaints";
            this.Load += new System.EventHandler(this.AdminOpenComplaints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.ListBox lbOpenComplaints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRefresh;
    }
}
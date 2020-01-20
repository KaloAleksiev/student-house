namespace Project1
{
    partial class AdminClosedComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminClosedComplaints));
            this.lbClosedComplaints = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClosedComplaints
            // 
            this.lbClosedComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbClosedComplaints.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClosedComplaints.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbClosedComplaints.FormattingEnabled = true;
            this.lbClosedComplaints.ItemHeight = 21;
            this.lbClosedComplaints.Location = new System.Drawing.Point(184, 198);
            this.lbClosedComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbClosedComplaints.Name = "lbClosedComplaints";
            this.lbClosedComplaints.Size = new System.Drawing.Size(395, 172);
            this.lbClosedComplaints.TabIndex = 66;
            this.lbClosedComplaints.SelectedIndexChanged += new System.EventHandler(this.lbClosedComplaints_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(323, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 60);
            this.label7.TabIndex = 65;
            this.label7.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(323, 117);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(0, 54);
            this.lblAnnouncements.TabIndex = 64;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(146, 39);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 63;
            this.pictureBox4.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(270, 383);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 54);
            this.btnRefresh.TabIndex = 87;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AdminClosedComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbClosedComplaints);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAnnouncements);
            this.Controls.Add(this.pictureBox4);
            this.Name = "AdminClosedComplaints";
            this.Text = "AdminClosedComplaints";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClosedComplaints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRefresh;
    }
}
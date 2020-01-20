namespace Project1
{
    partial class OldComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldComplaints));
            this.lbOldComplaints = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOldComplaints
            // 
            this.lbOldComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lbOldComplaints.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldComplaints.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbOldComplaints.FormattingEnabled = true;
            this.lbOldComplaints.ItemHeight = 21;
            this.lbOldComplaints.Location = new System.Drawing.Point(77, 164);
            this.lbOldComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOldComplaints.Name = "lbOldComplaints";
            this.lbOldComplaints.Size = new System.Drawing.Size(384, 172);
            this.lbOldComplaints.TabIndex = 35;
            this.lbOldComplaints.SelectedIndexChanged += new System.EventHandler(this.lbOldComplaints_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(165, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 60);
            this.label7.TabIndex = 34;
            this.label7.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(165, 94);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(236, 54);
            this.lblAnnouncements.TabIndex = 33;
            this.lblAnnouncements.Text = "Complaints";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(156, 345);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 54);
            this.btnRefresh.TabIndex = 88;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // OldComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(540, 412);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbOldComplaints);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAnnouncements);
            this.Controls.Add(this.pictureBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OldComplaints";
            this.Text = "Old Complaints";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOldComplaints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRefresh;
    }
}
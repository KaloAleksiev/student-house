namespace Project1
{
    partial class NewComplaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewComplaint));
            this.btnSendComplaint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbComplaintTitle = new System.Windows.Forms.TextBox();
            this.lblComplaintTitle = new System.Windows.Forms.Label();
            this.lblComplaintText = new System.Windows.Forms.Label();
            this.tbComplaintText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendComplaint
            // 
            this.btnSendComplaint.Location = new System.Drawing.Point(520, 379);
            this.btnSendComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendComplaint.Name = "btnSendComplaint";
            this.btnSendComplaint.Size = new System.Drawing.Size(159, 65);
            this.btnSendComplaint.TabIndex = 23;
            this.btnSendComplaint.Text = "Send complaint to administrator";
            this.btnSendComplaint.UseVisualStyleBackColor = true;
            this.btnSendComplaint.Click += new System.EventHandler(this.btnSendComplaint_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(257, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 60);
            this.label7.TabIndex = 22;
            this.label7.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(257, 85);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(506, 54);
            this.lblAnnouncements.TabIndex = 21;
            this.lblAnnouncements.Text = "Creating a new complaint";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(80, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // tbComplaintTitle
            // 
            this.tbComplaintTitle.Location = new System.Drawing.Point(80, 212);
            this.tbComplaintTitle.Name = "tbComplaintTitle";
            this.tbComplaintTitle.Size = new System.Drawing.Size(100, 22);
            this.tbComplaintTitle.TabIndex = 24;
            // 
            // lblComplaintTitle
            // 
            this.lblComplaintTitle.AutoSize = true;
            this.lblComplaintTitle.Location = new System.Drawing.Point(77, 174);
            this.lblComplaintTitle.Name = "lblComplaintTitle";
            this.lblComplaintTitle.Size = new System.Drawing.Size(35, 17);
            this.lblComplaintTitle.TabIndex = 25;
            this.lblComplaintTitle.Text = "Title";
            // 
            // lblComplaintText
            // 
            this.lblComplaintText.AutoSize = true;
            this.lblComplaintText.Location = new System.Drawing.Point(77, 263);
            this.lblComplaintText.Name = "lblComplaintText";
            this.lblComplaintText.Size = new System.Drawing.Size(74, 17);
            this.lblComplaintText.TabIndex = 26;
            this.lblComplaintText.Text = "Complaint:";
            // 
            // tbComplaintText
            // 
            this.tbComplaintText.Location = new System.Drawing.Point(80, 315);
            this.tbComplaintText.Margin = new System.Windows.Forms.Padding(4);
            this.tbComplaintText.Multiline = true;
            this.tbComplaintText.Name = "tbComplaintText";
            this.tbComplaintText.Size = new System.Drawing.Size(311, 122);
            this.tbComplaintText.TabIndex = 27;
            // 
            // NewComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbComplaintText);
            this.Controls.Add(this.lblComplaintText);
            this.Controls.Add(this.lblComplaintTitle);
            this.Controls.Add(this.tbComplaintTitle);
            this.Controls.Add(this.btnSendComplaint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAnnouncements);
            this.Controls.Add(this.pictureBox4);
            this.Name = "NewComplaint";
            this.Text = "NewComplaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendComplaint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbComplaintTitle;
        private System.Windows.Forms.Label lblComplaintTitle;
        private System.Windows.Forms.Label lblComplaintText;
        private System.Windows.Forms.TextBox tbComplaintText;
    }
}
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
            this.tbComplaintText = new System.Windows.Forms.TextBox();
            this.lblComplaintText = new System.Windows.Forms.Label();
            this.tbComplaintTitle = new System.Windows.Forms.TextBox();
            this.btnSendComplaint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComplaintText
            // 
            this.tbComplaintText.Location = new System.Drawing.Point(60, 315);
            this.tbComplaintText.Margin = new System.Windows.Forms.Padding(4);
            this.tbComplaintText.Multiline = true;
            this.tbComplaintText.Name = "tbComplaintText";
            this.tbComplaintText.Size = new System.Drawing.Size(311, 122);
            this.tbComplaintText.TabIndex = 34;
            // 
            // lblComplaintText
            // 
            this.lblComplaintText.AutoSize = true;
            this.lblComplaintText.Location = new System.Drawing.Point(57, 263);
            this.lblComplaintText.Name = "lblComplaintText";
            this.lblComplaintText.Size = new System.Drawing.Size(74, 17);
            this.lblComplaintText.TabIndex = 33;
            this.lblComplaintText.Text = "Complaint:";
            // 
            // tbComplaintTitle
            // 
            this.tbComplaintTitle.Location = new System.Drawing.Point(60, 212);
            this.tbComplaintTitle.Name = "tbComplaintTitle";
            this.tbComplaintTitle.Size = new System.Drawing.Size(100, 22);
            this.tbComplaintTitle.TabIndex = 32;
            // 
            // btnSendComplaint
            // 
            this.btnSendComplaint.Location = new System.Drawing.Point(500, 379);
            this.btnSendComplaint.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendComplaint.Name = "btnSendComplaint";
            this.btnSendComplaint.Size = new System.Drawing.Size(159, 65);
            this.btnSendComplaint.TabIndex = 31;
            this.btnSendComplaint.Text = "Send complaint to administrator";
            this.btnSendComplaint.UseVisualStyleBackColor = true;
            this.btnSendComplaint.Click += new System.EventHandler(this.btnSendComplaint_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(237, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 60);
            this.label7.TabIndex = 30;
            this.label7.Text = "Student House";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncements.ForeColor = System.Drawing.Color.Blue;
            this.lblAnnouncements.Location = new System.Drawing.Point(237, 85);
            this.lblAnnouncements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(506, 54);
            this.lblAnnouncements.TabIndex = 29;
            this.lblAnnouncements.Text = "Creating a new complaint";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(60, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Title:";
            // 
            // NewComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComplaintText);
            this.Controls.Add(this.lblComplaintText);
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

        private System.Windows.Forms.TextBox tbComplaintText;
        private System.Windows.Forms.Label lblComplaintText;
        private System.Windows.Forms.TextBox tbComplaintTitle;
        private System.Windows.Forms.Button btnSendComplaint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}
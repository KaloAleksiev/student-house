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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComplaintText
            // 
            this.tbComplaintText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.tbComplaintText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComplaintText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbComplaintText.Location = new System.Drawing.Point(36, 196);
            this.tbComplaintText.Multiline = true;
            this.tbComplaintText.Name = "tbComplaintText";
            this.tbComplaintText.Size = new System.Drawing.Size(311, 130);
            this.tbComplaintText.TabIndex = 34;
            // 
            // lblComplaintText
            // 
            this.lblComplaintText.AutoSize = true;
            this.lblComplaintText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaintText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblComplaintText.Location = new System.Drawing.Point(177, 172);
            this.lblComplaintText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplaintText.Name = "lblComplaintText";
            this.lblComplaintText.Size = new System.Drawing.Size(40, 21);
            this.lblComplaintText.TabIndex = 33;
            this.lblComplaintText.Text = "Text";
            // 
            // tbComplaintTitle
            // 
            this.tbComplaintTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.tbComplaintTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComplaintTitle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbComplaintTitle.Location = new System.Drawing.Point(36, 140);
            this.tbComplaintTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbComplaintTitle.Name = "tbComplaintTitle";
            this.tbComplaintTitle.Size = new System.Drawing.Size(311, 25);
            this.tbComplaintTitle.TabIndex = 32;
            // 
            // btnSendComplaint
            // 
            this.btnSendComplaint.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSendComplaint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComplaint.ForeColor = System.Drawing.Color.White;
            this.btnSendComplaint.Location = new System.Drawing.Point(36, 332);
            this.btnSendComplaint.Name = "btnSendComplaint";
            this.btnSendComplaint.Size = new System.Drawing.Size(311, 42);
            this.btnSendComplaint.TabIndex = 31;
            this.btnSendComplaint.Text = "Send complaint to administrator";
            this.btnSendComplaint.UseVisualStyleBackColor = false;
            this.btnSendComplaint.Click += new System.EventHandler(this.btnSendComplaint_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(177, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(104, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 47);
            this.label8.TabIndex = 44;
            this.label8.Text = "Student House";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(105, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 37);
            this.label9.TabIndex = 43;
            this.label9.Text = "New Complaint";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 87);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // NewComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(392, 395);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComplaintText);
            this.Controls.Add(this.lblComplaintText);
            this.Controls.Add(this.tbComplaintTitle);
            this.Controls.Add(this.btnSendComplaint);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewComplaint";
            this.Text = "New Complaint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComplaintText;
        private System.Windows.Forms.Label lblComplaintText;
        private System.Windows.Forms.TextBox tbComplaintTitle;
        private System.Windows.Forms.Button btnSendComplaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
namespace Project1
{
    partial class AnnouncementForm
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPostAnnouncement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(75, 34);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(234, 20);
            this.tbTitle.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(75, 83);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(234, 100);
            this.tbMessage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text";
            // 
            // btnPostAnnouncement
            // 
            this.btnPostAnnouncement.Location = new System.Drawing.Point(75, 199);
            this.btnPostAnnouncement.Name = "btnPostAnnouncement";
            this.btnPostAnnouncement.Size = new System.Drawing.Size(234, 52);
            this.btnPostAnnouncement.TabIndex = 4;
            this.btnPostAnnouncement.Text = "Post New Announcement";
            this.btnPostAnnouncement.UseVisualStyleBackColor = true;
            this.btnPostAnnouncement.Click += new System.EventHandler(this.btnPostAnnouncement_Click);
            // 
            // AnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(394, 273);
            this.Controls.Add(this.btnPostAnnouncement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTitle);
            this.Name = "AnnouncementForm";
            this.Text = "New Announcement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPostAnnouncement;
    }
}
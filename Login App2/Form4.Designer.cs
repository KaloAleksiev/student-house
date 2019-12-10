namespace Project1
{
    partial class Groceries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groceries));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clbGroceries = new System.Windows.Forms.CheckedListBox();
            this.btnSubmitGroceries = new System.Windows.Forms.Button();
            this.rtbItems = new System.Windows.Forms.RichTextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.tbSubstractAmount = new System.Windows.Forms.TextBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSubstractAmount);
            this.panel2.Controls.Add(this.btnSubstract);
            this.panel2.Controls.Add(this.clbGroceries);
            this.panel2.Controls.Add(this.btnSubmitGroceries);
            this.panel2.Controls.Add(this.rtbItems);
            this.panel2.Controls.Add(this.tbPrice);
            this.panel2.Location = new System.Drawing.Point(61, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 432);
            this.panel2.TabIndex = 2;
            // 
            // clbGroceries
            // 
            this.clbGroceries.FormattingEnabled = true;
            this.clbGroceries.Location = new System.Drawing.Point(188, 13);
            this.clbGroceries.Name = "clbGroceries";
            this.clbGroceries.Size = new System.Drawing.Size(254, 225);
            this.clbGroceries.TabIndex = 5;
            // 
            // btnSubmitGroceries
            // 
            this.btnSubmitGroceries.Location = new System.Drawing.Point(23, 236);
            this.btnSubmitGroceries.Name = "btnSubmitGroceries";
            this.btnSubmitGroceries.Size = new System.Drawing.Size(79, 48);
            this.btnSubmitGroceries.TabIndex = 4;
            this.btnSubmitGroceries.Text = "Submit Groceries";
            this.btnSubmitGroceries.UseVisualStyleBackColor = true;
            this.btnSubmitGroceries.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbItems
            // 
            this.rtbItems.Location = new System.Drawing.Point(23, 44);
            this.rtbItems.Name = "rtbItems";
            this.rtbItems.Size = new System.Drawing.Size(100, 96);
            this.rtbItems.TabIndex = 2;
            this.rtbItems.Text = "";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(23, 193);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 1;
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
            this.lblStudentHouse.Location = new System.Drawing.Point(127, 0);
            this.lblStudentHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(0, 60);
            this.lblStudentHouse.TabIndex = 0;
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(308, 262);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(84, 23);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "Substract";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // tbSubstractAmount
            // 
            this.tbSubstractAmount.Location = new System.Drawing.Point(188, 262);
            this.tbSubstractAmount.Name = "tbSubstractAmount";
            this.tbSubstractAmount.Size = new System.Drawing.Size(100, 22);
            this.tbSubstractAmount.TabIndex = 8;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(127, 59);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 60);
            this.lblPage.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "What have you bought?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost of your purchase:";
            // 
            // Groceries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Groceries";
            this.Text = "Form4";
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
        private System.Windows.Forms.Button btnSubmitGroceries;
        private System.Windows.Forms.RichTextBox rtbItems;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.CheckedListBox clbGroceries;
        private System.Windows.Forms.TextBox tbSubstractAmount;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
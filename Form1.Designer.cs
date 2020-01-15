namespace Project1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.lblStudentHouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 450);
            this.panel1.TabIndex = 0;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(470, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 38);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Location = new System.Drawing.Point(44, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 351);
            this.panel2.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(164, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(177, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(73, 288);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(275, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(73, 226);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(275, 33);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(73, 151);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(275, 33);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Gold;
            this.lblLogin.Location = new System.Drawing.Point(324, 18);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(112, 47);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentHouse.ForeColor = System.Drawing.Color.White;
            this.lblStudentHouse.Location = new System.Drawing.Point(66, 18);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(263, 47);
            this.lblStudentHouse.TabIndex = 0;
            this.lblStudentHouse.Text = "Student House";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblStudentHouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbClose;
    }
}


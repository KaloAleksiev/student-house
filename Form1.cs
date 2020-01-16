using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Project1
{
    public partial class Form1 : Form
    {
        StudentHouse studentHouse = new StudentHouse();
        Student currentStudent = null;
        Database database;
        int count = 0;
        int currentStudentID = -1;
        public Form1()
        {
            InitializeComponent();
            database = new Database();
        }


        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void openNewForm()
        {
            var newForm = new Form5(currentStudent); //I pass to the next form the studentHouse class and the index of the logged in student
            newForm.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPassword.Text;
            if (password == "admin" && username == "admin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                currentStudent = await database.FindStudent(username, password, currentStudent);
                if (currentStudent != null)
                {
                    openNewForm();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The credentials did not match");
                }
            }
            
            

        }

        

       

           
    }
}

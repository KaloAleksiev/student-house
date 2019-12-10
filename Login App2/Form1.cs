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
        Student newStudent;
        StudentHouse studentHouse = new StudentHouse();
        int indexOfCurrentStudent;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            readDataBase();
        }
        void readDataBase()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\alexi\OneDrive\Desktop\Students.txt");
            string line=file.ReadLine();
            string[] eachPerson = new string[10];
            while(line!=null)
            {
                count++;
                eachPerson=line.Split(' ');
                newStudent = new Student(eachPerson[0], eachPerson[1], eachPerson[2], eachPerson[3], eachPerson[4]);
                studentHouse.Add(newStudent);
                line = file.ReadLine();
            }
            studentHouse.CountStudents = count;

        }

        bool findNamePassword(string username, string password)
        {
            foreach (Student student in studentHouse.GetStudents())
            {
                indexOfCurrentStudent++;
                if (username == student.GetName() && password==student.GetPassword())
                {
                    return true;
                }
               
            }
            return false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void openNewForm()
        {
            var newForm = new Form2(studentHouse,  indexOfCurrentStudent); //I pass to the next form the studentHouse class and the index of the logged in student
            newForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPassword.Text;
            indexOfCurrentStudent = -1;
            if (findNamePassword(username, password))
            {
                openNewForm();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The credentials did not match");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

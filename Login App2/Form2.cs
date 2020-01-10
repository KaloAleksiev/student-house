using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        Grocery grocery;
        int keepIndex;
        StudentHouse studentHouse;
        GroceryList groceryList = new GroceryList();
        Trash trash = new Trash(false); //I created a class for the trash being taken out thing here so that if I close the cleaning schedule tab it will be saved that the trash has been taken out
        public Form2(StudentHouse studentHouse, Student currentStudent)
        {
            InitializeComponent();
            this.studentHouse = studentHouse;
            lblStudentHouse.Text = currentStudent.GetFirstName();
            lblPage.Text = "Home page";
            initializeGroceryList(); //everyone's balance is 0 at the beginning ; I initialize it here so that if I close the grocery window the balances remain saved
        }
        void initializeGroceryList()
        {
            /*int count = -1;
            foreach (Student student in studentHouse.GetStudents())
            {
                count++;
                if (count != keepIndex) //I do not add the logged in person to the grocery list
                {
                    grocery = new Grocery(student.GetId(), student.GetFirstName(), student.GetUsername(), student.GetRoomNumber(), 0);
                    groceryList.Add(grocery);
                }
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
       }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void btnCleaningSchedule_Click(object sender, EventArgs e)
        {
            var newForm = new Schedule(studentHouse, keepIndex, trash);
            newForm.Show();

        }

        private void btnGroceries_Click(object sender, EventArgs e)
        {
            var newForm = new Groceries(studentHouse, keepIndex, groceryList);
            newForm.Show();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

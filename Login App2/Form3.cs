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
    public partial class Schedule : Form
    {
        Database database;
        bool cleaned;
        Trash trash;
        Student currentStudent;
        string today, date, day;
        int todayToInt,dayToInt;

        public Schedule(Student currentStudent, Trash trash)
        {
            InitializeComponent();
            this.currentStudent = currentStudent;
            database = new Database();
            lblStudentHouse.Text = "Hello, " + currentStudent.GetFirstName();
            lblPage.Text = "You are currently on the Cleaning schedule page.";
            this.trash = trash;
            getToday(); //gets today date
            whoseTurnIsToday(); //displays whose turn is today
            whenToCleanNext(); //displays when is the next cleaning date for the logged in student
        }
        void getToday()
        {
            today = DateTime.Now.ToString("dd/MM/yyyy"); ;
            today = today.Substring(0, 10);
            todayToInt = Convert.ToInt32(today.Substring(0, 2));
        }
        private async void whoseTurnIsToday()
        {
            int currentStudentNumber= currentStudent.GetId();
            currentStudentNumber--;
            int count = await database.GetTotalStudents();
            if (todayToInt%count == currentStudentNumber)  //if it's the logged in student turn to clean
            {
                if (!trash.TakenOut) //if trash wasnt taken out yet
                {
                    btnSubmit.Visible = true;
                    rbtnYes.Visible = true;
                    rbtnNo.Visible = true;
                    lblTrashOut.Visible = true;
                }
                else //if it was taken out, I just display a message
                {
                    lblTrashOut.Visible = true;
                    lblTrashOut.Text = "You have done your job for today. Thank you!";
                }
            }
            else //if it is not logged in student turn to clean, then I show whose turn is
            {
                lblWhoCleansToday.Visible = true;
                lblWhoCleansToday.Text = "Today is " + database.GetFirstName(todayToInt % count) + "'s (Room: " + database.GetRoomNumber(todayToInt % count) + ") turn to do some cleaning";
            }
            
        }
        private async void whenToCleanNext()
        {

            lblAnn.Text = "The next cleaning day on this month is:";
            int currentStudentNumber = currentStudent.GetId();
            currentStudentNumber--;
            int count = await database.GetTotalStudents();
            int todayToInt = this.todayToInt;
            if (todayToInt % count == currentStudentNumber) //if it's the logged in student turn to clean today
            {
                if (!trash.TakenOut)//if th trash was taken out
                {
                    lblCleaningSchedule.Text = "Today, on " + today + " you have to wash the dishes and take the trash out";
                    lblNextClean.Text= "Today, on " + today + " you have to wash the dishes and take the trash out";
                }
                else
                {
                    lblCleaningSchedule.Text = "Today, on " + today + " you have washed the dishes and taken the trash out";
                    lblNextClean.Text = "Today, on " + today + " you have washed the dishes and taken the trash out";
                }
            }
            else //if it isn't logged in student turn to clean today
            {
                lblCleaningSchedule.Text = "Today, on " + today + " you have nothing to clean";

                while (todayToInt % count != currentStudentNumber)
                {
                    todayToInt++;
                }
                if (todayToInt <= 31)
                {
                    lblNextClean.Text = todayToInt.ToString() + today.Substring(2, 8);
                }
                else
                {
                    lblNextClean.Text = "Nothing to clean this month";
                }
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = calendar.SelectionStart.ToString();
            date = date.Substring(0, 10);//I get the dd.MM.yyyy
            int count = await database.GetTotalStudents();
            int currentStudentNumber = currentStudent.GetId();
            currentStudentNumber--;
            day = date.Substring(0, 2);
            dayToInt = Convert.ToInt32(day);
            if (dayToInt%count== currentStudentNumber) //if the logged in student turn is on the selected date
            {
                if (dayToInt == todayToInt) //also, if that day is today
                {
                    if (trash.TakenOut) //if the trash wast taken out
                    {
                        lblCleaningSchedule.Text = "Today, on " + today + " you have washed the dishes and taken the trash out";
                    }
                    else
                    {
                        lblCleaningSchedule.Text = "Today, on " + today + " you have to wash the dishes and take the trash out";
                    }
                }
                else
                {
                    lblCleaningSchedule.Text = "On the " + date + " you have to wash the dishes and take the trash out";
                }
            }
            else
            {
                lblCleaningSchedule.Text = "On the " + date + " you have nothing to clean";
            }

            
        }
        bool trashSensor()
        {
            return true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(rbtnYes.Checked)
            {
                if(trashSensor())
                {
                    trash.TakenOut = true;
                    btnSubmit.Visible = false;
                    rbtnYes.Visible = false;
                    rbtnNo.Visible = false;
                    lblTrashOut.Text = "You have done your job for today. Thank you!";
                    lblCleaningSchedule.Text = "Today, on " + today + " you have washed the dishes and taken the trash out";
                    lblNextClean.Text = "Today, on " + today + " you have washed the dishes and taken the trash out";
                }
            }
        }
    }
}

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
    public partial class Form5 : Form
    {
        private Student currentStudent;
        string today;
        string arduinoLine;
        int todayToInt;
        int totalStudents;
        bool isCurrentStudentTurnToClean, trashOk = false;
        Database database;
        AnnouncementForm announcementForm;

        public Form5(Student currentStudent)
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToShortDateString();
            database = new Database();
            this.currentStudent = currentStudent;
            lblStudentHouse.Text = "Hello, " + currentStudent.GetFirstName() + " " + currentStudent.GetLastName() + "!";
            //the cleaning schedule
            getTodayDate(); //gets today date
            checkIfIsCurrentStudentTurnToClean();
            lblAnn.Text += currentStudent.GetFirstName() + " " + currentStudent.GetLastName() + ":";
        }

        private async void checkIfIsCurrentStudentTurnToClean()
        {
            totalStudents = await database.GetTotalStudents();
            int x = currentStudent.GetId() - 1;
            if (todayToInt % totalStudents == x)
            {
                isCurrentStudentTurnToClean = true;
            }
            else
            {
                isCurrentStudentTurnToClean = false;
                lblNextClean.Text = "No chores today.";
                btnSubmit.Visible = false;
                rbtnYes.Visible = false;
                rbtnNo.Visible = false;
                lblTrashOut.Visible = false;
            }

        }
        void getTodayDate()
        {
            today = DateTime.Now.ToString("dd/MM/yyyy"); ;
            today = today.Substring(0, 10);
            todayToInt = Convert.ToInt32(today.Substring(0, 2));
        }

        private void lblStudentHouse_Click(object sender, EventArgs e)
        {

        }

        private async void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date, day;
            int dayToInt;
            date = calendar.SelectionStart.ToString();
            date = date.Substring(0, 10);//I get the dd.MM.yyyy
            int count = await database.GetTotalStudents();
            int currentStudentNumber = currentStudent.GetId();
            currentStudentNumber--;
            day = date.Substring(0, 2);
            dayToInt = Convert.ToInt32(day);
            totalStudents = await database.GetTotalStudents();
            int id = dayToInt % totalStudents;
            id++;
            string firstName = await database.GetFirstName(id);
            string roomNr = await database.GetRoomNumber(id);
            lblDateChanged.Text = "On " + date + " " + firstName + " (Room number: " + roomNr + ") should do the cleaning";
        }
        string readFromArduino()
        {
            return "";
            if (serialPort1.BytesToRead > 0)                                    //if there's information to be read
            {
                string readLine = serialPort1.ReadLine();
                return readLine;
            }
            return "";
        }
        void makeToolsInvisible()
        {
            btnSubmit.Visible = false;
            rbtnYes.Visible = false;
            rbtnNo.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                if (trashOk == true)
                {
                    makeToolsInvisible();
                    lblTrashOut.Text = "Thank you!";
                    lblNextClean.Text = "Wash the dishes";
                }
                else
                {
                    MessageBox.Show("No, you did not take the trash out");
                }
            }
            if (rbtnNo.Checked)
            {
                MessageBox.Show("Then you should");
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();

        }
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            //serialPort1.Close();
        }

        private void btnCleaningSchedule_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("Schedule");
        }

        private void btnGroceries_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("Groceries");
        }

        private async void btnAnnouncements_Click(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            AnnouncementList annoList = await database.GetAllAnnouncements();
            if (annoList != null)
            {
                foreach (Announcement anno in annoList.GetAllInfo())
                {
                    lbAnnouncements.Items.Add(anno.GetInfo());
                }
            }
            tabControl.SelectTab("Announcements");
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            Announcement announcement = new Announcement(DateTime.Now.ToShortDateString(), currentStudent.GetFirstName(), null, null);
            announcementForm = new AnnouncementForm(announcement);
            announcementForm.Show();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            AnnouncementList annoList = await database.GetAllAnnouncements();
            if (annoList != null)
            {
                foreach (Announcement anno in annoList.GetAllInfo())
                {
                    lbAnnouncements.Items.Add(anno.GetInfo());
                }
            }
        }

        private async void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnnouncementList annoList = await database.GetAllAnnouncements();
            InfoForm infoForm = new InfoForm(annoList.GetAllInfo()[lbAnnouncements.SelectedIndex]);
            infoForm.Show();
        }

        private void btnCreateComplaint_Click(object sender, EventArgs e)
        {
            Announcement announcement = new Announcement(DateTime.Now.ToShortDateString(), currentStudent.GetFirstName(), null, null, currentStudent.GetId(), true);
            NewComplaint nc = new NewComplaint(announcement);
            nc.Show();
        }

        private void btnOldComplaints_Click(object sender, EventArgs e)
        {
            OldComplaints oc = new OldComplaints(currentStudent.GetId());
            oc.Show();
        }

        private async void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAnnouncements.Items.Clear();
            AnnouncementList annoList = await database.GetAllAnnouncements();
            if (annoList != null)
            {
                foreach (Announcement anno in annoList.GetAllInfo())
                {
                    lbAnnouncements.Items.Add(anno.GetInfo());
                }
            }

            refreshGroceriesTab();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("Complaints");
        }

        private void Announcements_Click(object sender, EventArgs e)
        {

        }
        private async void btnSubmitGroceries_Click(object sender, EventArgs e)
        {
            string purchase = tbxPurchase.Text;
            string price = tbPrice.Text;

            if (purchase == "" || price == "")
            {
                return;
            }

            tbxPurchase.Text = "";
            tbPrice.Text = "";

            await database.InsertPayment(currentStudent.GetFirstName() + " bought " + purchase + " for " + price + " eur.");
            await database.UpdateStudentAmount(Convert.ToInt32(price));
            refreshGroceriesTab();
        }

        private async void refreshGroceriesTab()
        {
            lsbGroceriesStudents.Items.Clear();
            lsbGroceriesPayments.Items.Clear();

            var students = await database.GetStudentsAmounts();
            var payments = await database.GetPayments();

            for (int i = 0; i < payments.Count; i++)
            {
                lsbGroceriesPayments.Items.Add(
                    payments[i].message.Value
                );
            }

            int maxAmountStudentIndex = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (maxAmountStudentIndex == -1)
                {
                    maxAmountStudentIndex = i;
                    continue;
                }

                Console.WriteLine(students[maxAmountStudentIndex].amount.Value);

                if (students[i].amount.Value > students[maxAmountStudentIndex].amount.Value)
                {
                    maxAmountStudentIndex = i;
                }
            }

            for (int i = 0; i < students.Count; i++)
            {
                if (maxAmountStudentIndex == i)
                {
                    lsbGroceriesStudents.Items.Add(
                        students[i].firstName.Value + "       0 eur."
                    );
                }
                else
                {
                    lsbGroceriesStudents.Items.Add(
                        students[i].firstName.Value + "      " + (students[i].amount.Value - students[maxAmountStudentIndex].amount.Value) + " eur."
                    );
                }
            }
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            string price = tbSubstractAmount.Text;
            if (price == "")
            {
                return;
            }

            tbSubstractAmount.Text = "";
            await database.InsertPayment(currentStudent.GetFirstName() + " deposited " + price + " eur.");
            await database.UpdateStudentAmount(Convert.ToInt32(price));
            refreshGroceriesTab();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arduinoLine = readFromArduino();
            if (arduinoLine.Contains("OK"))
            {
                trashOk = true;
            }

        }
    }
}

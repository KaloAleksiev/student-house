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
    public partial class Admin : Form
    {
        Database database = new Database();
        public Admin()
        {
            InitializeComponent();
            addAnnouncements();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(tbFirstName.Text!="" && tbLastName.Text!= "" && tbEmail.Text!= "" && tbPassword.Text!= "" && tbRoomId.Text!= "")
            {
                database.InsertNewStudent(tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPassword.Text, tbRoomId.Text);
                tbFirstName.Clear();
                tbLastName.Clear();
                tbEmail.Clear();
                tbPassword.Clear();
                tbRoomId.Clear();
                MessageBox.Show("Account created successfully.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminOpenComplaints aoc = new AdminOpenComplaints();
            aoc.Show();
        }

        private void btnSeeClosedComplaints_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSeeClosedComplaints_Click_1(object sender, EventArgs e)
        {
            AdminClosedComplaints acc = new AdminClosedComplaints();
            acc.Show();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {

        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnouncement_Click_1(object sender, EventArgs e)
        {
            Announcement announcement = new Announcement(DateTime.Now.ToShortDateString(), "Administrator", null, null);
            AnnouncementForm announcementForm = new AnnouncementForm(announcement);
            announcementForm.Show();
        }

        private async void addAnnouncements()
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
    }
}

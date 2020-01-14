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
    public partial class AnnouncementForm : Form
    {
        Announcement announcement;
        Database database = new Database();
        public AnnouncementForm(Announcement announcement)
        {
            InitializeComponent();
            this.announcement = announcement;
        }

        private void btnPostAnnouncement_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" && tbMessage.Text != "")
            {
                announcement.SetTitle(tbTitle.Text);
                announcement.SetMessage(tbMessage.Text);
                database.InsertNewAnnouncement(announcement.GetTime(), announcement.GetAuthor(), announcement.GetTitle(), announcement.GetMessage());
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill out all the fields.");
            }
        }
    }
}

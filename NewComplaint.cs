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
    public partial class NewComplaint : Form
    {
        Announcement announcement;
        Database database = new Database();
        public NewComplaint(Announcement announcement)
        {
            InitializeComponent();
            this.announcement = announcement;
        }

        private void btnSendComplaint_Click(object sender, EventArgs e)
        {
          
        }

        private async void btnSendComplaint_Click_1(object sender, EventArgs e)
        {
            if (tbComplaintTitle.Text != "" && tbComplaintText.Text != "")
            {
                announcement.SetTitle(tbComplaintTitle.Text);
                announcement.SetMessage(tbComplaintText.Text);
                database.InsertNewComplaint(announcement.GetTime(), announcement.GetAuthor(), announcement.GetTitle(), announcement.GetMessage(), announcement.GetId(), announcement.IsOpen());
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all the fields.");
            }
        }
    }
}

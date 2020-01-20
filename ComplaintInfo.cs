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
    public partial class ComplaintInfo : Form
    {
        Announcement complaint;
        Database database = new Database();
        public ComplaintInfo(Announcement complaint)
        {
            InitializeComponent();
            this.complaint = complaint;
            lblDate.Text = complaint.GetDate();
            lblTitle.Text = complaint.GetTitle();
            tbComplaint.Text = complaint.GetMessage();
            if(complaint.IsOpen())
            {
                lblStatus.Text = "Open";
                tbAdminAnswer.Text = "The administrator has not responded yet";
            }
            else
            {
                lblStatus.Text = "Closed";
                adminAnswer();
            }
        }

        private async void adminAnswer()
        {
            string answer = await database.GetAdminAnswer(Convert.ToInt32(complaint.GetComplaintId()));
            tbAdminAnswer.Text = answer;

        }

        private void ComplaintInfo_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

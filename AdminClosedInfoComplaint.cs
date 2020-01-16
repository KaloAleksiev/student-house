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
    public partial class AdminClosedInfoComplaint : Form
    {
        Announcement complaint;
        Database database = new Database();
        public AdminClosedInfoComplaint(Announcement complaint)
        {
            InitializeComponent();
            this.complaint = complaint;
            this.complaint = complaint;
            lblDate.Text = complaint.GetDate();
            lblTitle.Text = complaint.GetTitle();
            lblName.Text = complaint.GetAuthor();
            lblId.Text = complaint.GetAuthorId().ToString();
            tbComplaint.Text = complaint.GetMessage();
            lblStatus.Text = "Closed";
            lblAnnouncements.Text = "Complaint #" + complaint.GetComplaintId();
            answer();
        }
        private async void answer()
        {
            string ans = await database.GetAdminAnswer(Convert.ToInt32(complaint.GetComplaintId()));
            tbAnswer.Text = ans;

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AdminInfoComplaint : Form
    {
        Database database = new Database();
        Announcement complaint;
        public AdminInfoComplaint(Announcement complaint)
        {
            InitializeComponent();
            this.complaint=complaint;
            lblDate.Text = complaint.GetDate();
            lblTitle.Text = complaint.GetTitle();
            lblName.Text = complaint.GetAuthor();
            lblId.Text = complaint.GetAuthorId().ToString();
            tbComplaint.Text = complaint.GetMessage();
            lblStatus.Text = "Open";
            lblAnnouncements.Text = "Complaint #" + complaint.GetComplaintId();
        }

        private async void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            string answer=tbAnswer.Text;
            if(answer!="")
            {
                database.InsertNewAnswer(answer, Convert.ToInt32(complaint.GetComplaintId()));
                database.CloseComplaint(Convert.ToInt32(complaint.GetComplaintId()));
                MessageBox.Show("Complaint #" + complaint.GetComplaintId() + " closed");
                this.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

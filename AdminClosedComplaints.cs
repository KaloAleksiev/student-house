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
    public partial class AdminClosedComplaints : Form
    {
        Database database = new Database();
        AnnouncementList complaintList;
        public AdminClosedComplaints()
        {
            InitializeComponent();
            showAllComplaints();

        }
        private async void showAllComplaints()
        {
            lbClosedComplaints.Items.Clear();
            complaintList = await database.GetAllClosedComplaints();
            if (complaintList != null)
            {
                foreach (Announcement complaint in complaintList.GetAllInfo())
                {
                    lbClosedComplaints.Items.Add(complaint.GetComplaintInfo());
                }
            }
            else
            {
                lbClosedComplaints.Items.Add("There are no closed complaints");
            }
        }

        private void lbClosedComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbClosedComplaints.SelectedIndex;
            if (lbClosedComplaints.Items.Contains("There are no closed complaints")==false)
            {
                Announcement anno = complaintList.GetComplaintAtIndex(index);
                if (anno != null)
                {
                    AdminClosedInfoComplaint cf = new AdminClosedInfoComplaint(anno);
                    cf.Show();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showAllComplaints();
        }
    }
}

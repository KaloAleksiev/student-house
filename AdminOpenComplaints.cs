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
    public partial class AdminOpenComplaints : Form
    {
        Database database = new Database();
        AnnouncementList complaintList;
        public AdminOpenComplaints()
        {
            InitializeComponent();
            showAllComplaints();
        }

        private async void showAllComplaints()
        {
            lbOpenComplaints.Items.Clear();
            complaintList = await database.GetAllComplaints();
            if (complaintList != null)
            {
                foreach (Announcement complaint in complaintList.GetAllInfo())
                {
                    lbOpenComplaints.Items.Add(complaint.GetComplaintInfo());
                }
            }
            else
            {
                lbOpenComplaints.Items.Add("There are no new complaints");
            }


        }

        private void AdminOpenComplaints_Load(object sender, EventArgs e)
        {

        }

        private void lbOpenComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOpenComplaints.Items.Contains("There are no new complaints") == false)
            {

                int index = lbOpenComplaints.SelectedIndex;
                Announcement anno = complaintList.GetComplaintAtIndex(index);
                if (anno != null)
                {
                    AdminInfoComplaint cf = new AdminInfoComplaint(anno);
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

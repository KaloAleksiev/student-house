﻿using System;
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
    public partial class OldComplaints : Form
    {
        int id;
        AnnouncementList complaintList;
        Database database = new Database();
        public OldComplaints(int id)
        {
            InitializeComponent();
            this.id = id;
            showAllComplaints();
        }

        private async void showAllComplaints()
        {
            lbOldComplaints.Items.Clear();
            complaintList = await database.GetAllComplaintsByStudentId(id);
            if (complaintList != null)
            {
                foreach (Announcement complaint in complaintList.GetAllInfo())
                {
                    lbOldComplaints.Items.Add(complaint.GetComplaintInfo());
                }
            }
            else
            {
                lbOldComplaints.Items.Add("You have no past complaint");
            }


        }

        private void lbOldComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lbOldComplaints_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = lbOldComplaints.SelectedIndex;
            if (lbOldComplaints.Items.Contains("You have no past complaint") == false)
            {
                ComplaintInfo cf = new ComplaintInfo(complaintList.GetComplaintAtIndex(index));
                cf.Show();
            }
        }
    }
}

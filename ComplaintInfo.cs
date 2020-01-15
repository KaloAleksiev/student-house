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
        int index;
        public ComplaintInfo(Announcement complaint)
        {
            InitializeComponent();
            this.index = index;
            this.complaint = complaint;
            lblDate.Text = complaint.GetDate();
            lblTitle.Text = complaint.GetTitle();
            tbComplaint.Text = complaint.GetMessage();
            lblAnnouncements.Text = "Complaint #" + complaint.GetComplaintId();
        }
    }
}

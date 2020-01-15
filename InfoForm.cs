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
    public partial class InfoForm : Form
    {
        public InfoForm(Announcement announcement)
        {
            InitializeComponent();
            lblDate.Text = "on " + announcement.GetTime();
            lblAuthor.Text = "from " + announcement.GetAuthor();
            tbTitle.Text = announcement.GetTitle();
            tbText.Text = announcement.GetMessage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

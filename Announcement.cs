using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Announcement
    {
        private string time;
        private string author;
        private string title;
        private string message;
        private int id;
        private int complaintId;

        public Announcement(string time, string author, string title, string message)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
        }
        public Announcement(string time, string author, string title, string message, int id)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
            this.id = id;
        }
        public Announcement(string time, string author, string title, int complaintId, string message)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
            this.complaintId = complaintId;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void SetMessage(string message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return this.message;
        }

        public string GetTime()
        {
            return this.time;
        }

        public string GetAuthor()
        {
            return this.author;
        }
        public int GetId()
        {
            return this.id;
        }

        public string GetInfo()
        {
            return this.time + " " + this.author + " " + this.title;
        }

        public string GetDate()
        {
            return time;
        }
        public string GetComplaintId()
        {
            return complaintId.ToString();
        }
        public string GetComplaintInfo()
        {
            return "#" + this.complaintId + " " + this.time + " " + this.author + " " + this.title;
        }
    }
}

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
        private int studentId;
        private bool isOpen;

        public Announcement(string time, string author, string title, string message)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
        }
        public Announcement(string time, string author, string title, string message, int id, bool isOpen)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
            this.id = id;
            this.isOpen = isOpen;
        }
        public Announcement(string time, string author, string title, int complaintId, string message, bool isOpen)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
            this.complaintId = complaintId;
            this.isOpen = isOpen;
        }
        public Announcement(string time, string author, string title, int complaintId, string message, bool isOpen, int studentId)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
            this.complaintId = complaintId;
            this.isOpen = isOpen;
            this.studentId = studentId;
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
            return this.time + "\t" + this.author + "\t" + this.title;
        }

        public string GetDate()
        {
            return time;
        }
        public string GetComplaintId()
        {
            return complaintId.ToString();
        }
        public bool IsOpen()
        {
            return isOpen;
        }
        public int GetAuthorId()
        {
            return studentId;
        }
        public string GetComplaintInfo()
        {
            if (isOpen)
            {
                return "#" + this.complaintId + " OPEN " + this.time + " " + this.title;
            }
            else
            {
                return "#" + this.complaintId + " CLOSED " + this.time + " " + this.title;
            }
        }
    }
}

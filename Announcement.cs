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

        public Announcement(string time, string author, string title, string message)
        {
            this.time = time;
            this.author = author;
            this.title = title;
            this.message = message;
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

        public string GetInfo()
        {
            return this.time + " " + this.author + " " + this.title;
        }
    }
}

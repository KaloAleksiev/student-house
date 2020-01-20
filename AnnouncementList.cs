using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class AnnouncementList
    {
        List<Announcement> announcementList;

        public AnnouncementList()
        {
            announcementList = new List<Announcement>();
        }

        public void AddAnnouncement(Announcement announcement)
        {
            announcementList.Add(announcement);
        }

        public Announcement GetComplaintAtIndex(int index)
        {
            if (announcementList.Count >= index + 1)
            {
                return announcementList[index];
            }
            return null;
        }

        public List<Announcement> GetAllInfo()
        {
            return announcementList;
        }
    }

    
}

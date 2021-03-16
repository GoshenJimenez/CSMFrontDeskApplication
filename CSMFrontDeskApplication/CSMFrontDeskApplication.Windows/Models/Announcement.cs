using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
     public class Announcement
    {
        public Guid? Id { get; set; }

        public string Content { get; set; }

        public string AnnouncedBy { get; set; }

        public DateTime StartDate { get; set; }

        public int Month
        {
            get
            {
                return this.StartDate.Month;
            }
        }

        public int Day
        {
            get
            {
                return this.StartDate.Day;
            }
        }

        public int Year
        {
            get
            {
                return this.StartDate.Year;
            }
        }
        public DateTime EndDate { get; set; }
        public int Months
        {
            get
            {
                return this.EndDate.Month;
            }
        }

        public int Days
        {
            get
            {
                return this.EndDate.Day;
            }
        }

        public int Years
        {
            get
            {
                return this.EndDate.Year;
            }
        }
        public int isPublished { get; set; } 
    }
}

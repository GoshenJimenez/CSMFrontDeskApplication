using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
    public class GuestLog
    {
        public Guid? Id { get; set; }
        public Guid? GuestId { get; set; }
        public Guest Guest { get; set; }
        public decimal Temperature { get; set; }
        public DateTime VisitAt { get; set; }
        public int Month
        {
            get
            {
                return this.VisitAt.Month;
            }
        }

        public int Day
        {
            get
            {
                return this.VisitAt.Day;
            }
        }

        public int Year
        {
            get
            {
                return this.VisitAt.Year;
            }
        }
    }

}

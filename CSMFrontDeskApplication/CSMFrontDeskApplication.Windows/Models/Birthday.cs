using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
    public class Birthday
    {
        public Guid? Id { get; set; }
        public string PersonName { get; set; }
        public DateTime Date { get; set; }
        public int Month
        {
            get
            {
                return this.Date.Month;
            }
        }

        public int Day
        {
            get
            {
                return this.Date.Day;
            }
        }

        public int Year
        {
            get
            {
                return this.Date.Year;
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.Date.Year;
            }
        }
    }
}

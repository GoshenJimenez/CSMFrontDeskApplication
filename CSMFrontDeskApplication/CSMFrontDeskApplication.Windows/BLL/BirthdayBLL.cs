using CSMFrontDeskApplication.Windows.DAL;
using CSMFrontDeskApplication.Windows.Infrastructure;
using CSMFrontDeskApplication.Windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.BLL
{
    public static class BirthdayBLL 
    {
        private static SchoolDBContext db = new SchoolDBContext();

        public static List<Birthday> GetALL()
        {
            return db.Birthdays.ToList();
        }

        public static Paged<Birthday> Search(int pageIndex = 1, int pageSize = 10)
        {
            var birthdays = db.Birthdays;

            return new Paged<Birthday>()
            {
                Items = birthdays.OrderByDescending(b => b.Date).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList(),
                RowCount = birthdays.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,                
            };
        }
    }
}

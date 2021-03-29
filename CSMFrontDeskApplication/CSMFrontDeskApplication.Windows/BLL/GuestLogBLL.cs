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
    public static class GuestLogBLL
    {
        private static SchoolDBContext db = new SchoolDBContext();

        public static List<GuestLog> GetAll()
        {
            return db.GuestLogs.ToList();
        }
        public static Paged<GuestLog> Search(int pageIndex = 1, int pageSize = 10)
        {
            var guestlogs = db.GuestLogs;

            return new Paged<GuestLog>()
            {
                Items = guestlogs.OrderByDescending(g => g.VisitAt).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList(),

                RowCount = guestlogs.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
        }
    }
}

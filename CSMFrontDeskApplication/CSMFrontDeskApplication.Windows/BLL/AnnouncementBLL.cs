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
    public static class AnnouncementBLL
    {
        private static SchoolDBContext db = new SchoolDBContext();

        public static List<Announcement> GetALL()
        {
            return db.Announcements
                .ToList();
        }

        public static Paged<Announcement> GetAnnouncements(int pageIndex = 1, int pageSize = 10)
        {
            var query = db.Announcements.AsQueryable();
            var announcements = query.Where(a =>
                                            a.Status == Models.Enums.RecordStatus.Active
                                            && a.StartDate < DateTime.Now
                                            && a.EndDate > DateTime.Now
                                        )
                .OrderByDescending(a => a.StartDate).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();

            return new Paged<Announcement>()
            {
                Items = announcements,
                RowCount = announcements.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
        }
    }
}

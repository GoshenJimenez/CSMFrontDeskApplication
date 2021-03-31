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
    public static class StudentAssistantLogBLL
    {
        private static SchoolDBContext db = new SchoolDBContext();

        public static List<StudentAssistantLog> GetAll()
        {
            return db.StudentAssistantLogs.ToList();
        }
        public static Paged<StudentAssistantLog> Search(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            var studentassistantlogs = db.StudentAssistantLogs.Where(s => s.StudentAssistantId.ToString().Contains(keyword.ToLower()));

            return new Paged<StudentAssistantLog>()
            {
                Items = studentassistantlogs.OrderByDescending(s => s.Logout).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList(),

                RowCount = studentassistantlogs.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
        }
    }
}

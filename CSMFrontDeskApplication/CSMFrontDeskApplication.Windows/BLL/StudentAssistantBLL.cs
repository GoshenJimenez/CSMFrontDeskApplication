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
    public static class StudentAssistantBLL
    {
        private static SchoolDBContext db = new SchoolDBContext();
        
        public static List<StudentAssistant> GetAll()
        {
            return db.StudentAssistants.ToList();
        }
        public static Paged<StudentAssistant> Search(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            var studentassistants = db.StudentAssistants.Where(s => s.PersonName.ToLower().Contains(keyword.ToLower()));

            return new Paged<StudentAssistant>()
            {
                Items = studentassistants.OrderByDescending(s => s.Password).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList(),
                RowCount = studentassistants.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
            
        }
    }
}

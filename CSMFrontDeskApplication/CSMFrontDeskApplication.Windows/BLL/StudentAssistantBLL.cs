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

        public static Operation Login(string userName, string password)
        {
            var studentAssistant = db.StudentAssistants.FirstOrDefault(s => s.Username == userName);

            if(studentAssistant == null)
            {
                return new Operation()
                {
                    Code = "400",
                    Message = new List<string>() { "Invalid Login" }
                };
            }
            else
            {
                var result = DevOne.Security.Cryptography.BCrypt.BCryptHelper.CheckPassword(password, studentAssistant.Password);

                if(result == true)
                {
                    var log = db.StudentAssistantLogs.FirstOrDefault(l => l.StudentAssistantId == studentAssistant.Id
                                                                        && l.Login.Year == DateTime.Now.Year
                                                                        && l.Login.Month == DateTime.Now.Month
                                                                        && l.Login.Day == DateTime.Now.Day
                                                                     );
                    if(log == null)
                    {
                        log = new StudentAssistantLog()
                        {
                            Id = Guid.NewGuid(),
                            StudentAssistantId = studentAssistant.Id,
                            Login = DateTime.Now,
                        };

                        db.StudentAssistantLogs.Add(log);
                        db.SaveChanges();
                    }

                    return new Operation()
                    {
                        Code = "OK",
                        Message = new List<string>() { "Successfully Loggedin" }
                    };
                }
                else
                {
                    return new Operation()
                    {
                        Code = "400",
                        Message = new List<string>() { "Invalid Login" }
                    };
                }
            }
        }
    }
}

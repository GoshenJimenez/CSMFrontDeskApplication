using CSMFrontDeskApplication.Windows.DAL;
using CSMFrontDeskApplication.Windows.Infrastructure;
using CSMFrontDeskApplication.Windows.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static int MonthFromName(string keyword)
        {
            if(keyword.Length > 2)
            {
                var keywordFirst3 = keyword.ToLower().Substring(0,3);
                if (keywordFirst3 == "jan")
                {
                    return 1;
                }
                else if(keywordFirst3 == "feb")
                {
                    return 2;
                }
                else if (keywordFirst3 == "mar")
                {
                    return 3;
                }
                else if (keywordFirst3 == "apr")
                {
                    return 4;
                }
                else if (keywordFirst3 == "may")
                {
                    return 5;
                }
                else if (keywordFirst3 == "jun")
                {
                    return 6;
                }
                else if (keywordFirst3 == "jul")
                {
                    return 7;
                }
                else if (keywordFirst3 == "aug")
                {
                    return 8;
                }
                else if (keywordFirst3 == "sep")
                {
                    return 9;
                }
                else if (keywordFirst3 == "oct")
                {
                    return 10;
                }
                else if (keywordFirst3 == "nov")
                {
                    return 11;
                }
                else if (keywordFirst3 == "dec")
                {
                    return 12;
                }
                else
                {
                    return 0;
                }

            }
            return 0;
        }

        public static Paged<Birthday> Search(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {

            var query = db.Birthdays.AsQueryable();


            if (!string.IsNullOrEmpty(keyword)) {    
                query = query.Where(b => b.PersonName.ToLower().Contains(keyword.ToLower()));                
            }

            var birthdays = query.OrderByDescending(b => b.Date).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();

            if (!string.IsNullOrEmpty(keyword))
            {
                var mo = MonthFromName(keyword);
                if (mo > 0)
                {
                    birthdays = birthdays.Where(b => b.Month == mo).ToList();
                }
            }

            return new Paged<Birthday>()
            {
                Items = birthdays,
                RowCount = birthdays.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,                
            };
        }

        public static Operation Create(Birthday model)
        {
            try
            {
                db.Birthdays.Add(model);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "Ok",
                    Message = new List<string>() { "Birthday is created successfully." }
                };

            }
            catch(Exception e)
            {
                return new Operation()
                {
                    Code = "Fail",
                    Message = new List<string>() { e.Message }
                };
            }
        }

        public static Operation Update(Birthday model)
        {
            try
            {
                Birthday birthdayRecord = db.Birthdays.FirstOrDefault(b => b.Id == model.Id);

                if (birthdayRecord != null)
                {
                    birthdayRecord.PersonName = model.PersonName;
                    birthdayRecord.Date = model.Date;
                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "Ok",
                        Message = new List<string>() { "Birthday is updated successfully." }
                    };
                }

                return new Operation()
                {
                    Code = "Fail",
                    Message = new List<string>() { "Birthday record not found."}
                };
            }
            catch (Exception e)
            {
                return new Operation()
                {
                    Code = "Fail",
                    Message = new List<string>() { e.Message }
                };
            }
        }
    }
}

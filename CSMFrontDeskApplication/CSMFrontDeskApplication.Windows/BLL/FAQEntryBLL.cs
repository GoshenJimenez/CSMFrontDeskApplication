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
    public static class FAQEntryBLL
    {
        private static SchoolDBContext db = new SchoolDBContext();

        public static List<FAQEntry> GetALL() 
        {
            return db.FAQEntries.ToList();
        }

        public static Paged<FAQEntry> Search(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            var faqentries = db.FAQEntries.Where(f => f.Question.ToLower().Contains(keyword.ToLower()));

            return new Paged<FAQEntry>()
            {
                Items = faqentries.OrderByDescending(f => f.Answer).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList(),
                RowCount = faqentries.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,
            };

        }

        public static Operation Create(FAQEntry model)
        {
            try
            {
                db.FAQEntries.Add(model);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "Ok",
                    Message = new List<string>() { "Question is created successfully." }
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

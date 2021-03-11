using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            context.Birthdays.Add(new Models.Birthday()
            {
                Id = Guid.NewGuid(),
                PersonName = "Goshen Jimenez",
                Date = DateTime.Parse("08/02/1982")
            });

            context.Birthdays.Add(new Models.Birthday()
            {
                Id = Guid.NewGuid(),
                PersonName = "Xiah Alara Jimenez",
                Date = DateTime.Parse("14/12/2015")
            });

            context.Birthdays.Add(new Models.Birthday()
            {
                Id = Guid.NewGuid(),
                PersonName = "Aya Junea Jimenez",
                Date = DateTime.Parse("06/04/2006")
            });



            context.SaveChanges();
        }
    }
}

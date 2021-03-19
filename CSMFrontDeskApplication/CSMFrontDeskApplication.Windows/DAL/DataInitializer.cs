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

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Marites Lumacad",
                Course = " BSIS201",
                Username = " MrtLcd",
                Password = " Mariteslngmalakas",
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Rigor Ambulencia",
                Course = " BSIS201",
                Username = " RgrAlca",
                Password = " RigsLencia",
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Athena Guinevere",
                Course = " BSIS201",
                Username = " AtaGve",
                Password = " thenaGuiv",
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Natsu Dragneel",
                Course = "BSIS201",
                Username = "NtuDgl",
                Password = "FairyTail",
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "LeviAckerman",
                Course = "BSIS201",
                Username = "LvAkn",
                Password = "AotFs",
            });

            context.SaveChanges();

            context.StudentAssistantLogs.Add(new Models.StudentAssistantLog()
            {
                Id = Guid.NewGuid(),
                StudentAssistantId = 089,
                Login = DateTime.Parse("08/30/02"),
                Logout = DateTime.Parse("12/30/02"),
            });

            context.StudentAssistantLogs.Add(new Models.StudentAssistantLog()
            {
                Id = Guid.NewGuid(),
                StudentAssistantId = 087,
                Login = DateTime.Parse("08/35/02"),
                Logout = DateTime.Parse("12/35/39"),
            });

            context.StudentAssistantLogs.Add(new Models.StudentAssistantLog()
            {
                Id = Guid.NewGuid(),
                StudentAssistantId = 086,
                Login = DateTime.Parse("08/10/06"),
                Logout = DateTime.Parse("12/10/52"),
            });

            context.StudentAssistantLogs.Add(new Models.StudentAssistantLog()
            {
                Id = Guid.NewGuid(),
                StudentAssistantId = 088,
                Login = DateTime.Parse("08/01/57"),
                Logout = DateTime.Parse("12/00/56"),
            });

            context.StudentAssistantLogs.Add(new Models.StudentAssistantLog()
            {
                Id = Guid.NewGuid(),
                StudentAssistantId = 094,
                Login = DateTime.Parse("08/00/36"),
                Logout = DateTime.Parse("12/00/02"),
            });

            context.SaveChanges();
            //TODO: Add your Data here



        }

    }
}

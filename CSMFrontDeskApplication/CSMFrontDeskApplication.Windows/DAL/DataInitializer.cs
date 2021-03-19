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

            context.Guest.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Danilo Flores",
                Address = "Luacan, Dinalupihan, Bataan",
                Age = 25,
                Gender = Models.Enums.Gender.Male
            });
            context.Guest.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Andrea Angeles",
                Address = "Saguing, Dinalupihan, Bataan",
                Age = 18,
                Gender = Models.Enums.Gender.Female
            });
            context.Guest.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Bert Sanggalang",
                Address = "San Ramon, Dinalupihan, Bataan",
                Age = 30,
                Gender = Models.Enums.Gender.Male
            });
            context.Guest.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Danica Castro",
                Address = "Luacan, Dinalupihan, Bataan",
                Age = 17,
                Gender = Models.Enums.Gender.Female
            });
            context.Guest.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Leo Lim",
                Address = "Bacong, Hermosa, Bataan",
                Age = 21,
                Gender = Models.Enums.Gender.Male
            });
            context.SaveChanges();

            context.GuestLog.Add(new Models.GuestLog()
            {
                Id = Guid.NewGuid(),
                GuestId = 156,
                VisitAt = DateTime.Parse("03/04/2021"),
                Temperature = 36
            });
            context.GuestLog.Add(new Models.GuestLog()
            {
                Id = Guid.NewGuid(),
                GuestId = 143,
                VisitAt = DateTime.Parse("03/11/2021"),
                Temperature = 36
            });
            context.GuestLog.Add(new Models.GuestLog()
            {
                Id = Guid.NewGuid(),
                GuestId = 121,
                VisitAt = DateTime.Parse("03/15/2021"),
                Temperature = 35
            });
            context.GuestLog.Add(new Models.GuestLog()
            {
                Id = Guid.NewGuid(),
                GuestId = 159,
                VisitAt = DateTime.Parse("03/10/2021"),
                Temperature = 36
            });
            context.GuestLog.Add(new Models.GuestLog()
            {
                Id = Guid.NewGuid(),
                GuestId = 131,
                VisitAt = DateTime.Parse("03/07/2021"),
                Temperature = 37
            });
            context.SaveChanges();
            //TODO: Add your Data here
        }

    }
}

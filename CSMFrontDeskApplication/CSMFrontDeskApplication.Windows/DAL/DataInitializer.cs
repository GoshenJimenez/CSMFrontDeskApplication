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
                Date = DateTime.Parse("02/08/1982")
            });

            context.Birthdays.Add(new Models.Birthday()
            {
                Id = Guid.NewGuid(),
                PersonName = "Xiah Alara Jimenez",
                Date = DateTime.Parse("02/08/2015")
            });

            context.Birthdays.Add(new Models.Birthday()
            {
                Id = Guid.NewGuid(),
                PersonName = "Aya Junea Jimenez",
                Date = DateTime.Parse("04/06/2006")
            });

            context.SaveChanges();

            var salt = DevOne.Security.Cryptography.BCrypt.BCryptHelper.GenerateSalt();

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Marites Lumacad",
                Course = " BSIS201",
                Username = " MrtLcd",
                Password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword(" Mariteslngmalakas", salt),
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Rigor Ambulencia",
                Course = " BSIS201",
                Username = " RgrAlca",
                Password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword(" RigsLencia",salt)
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Athena Guinevere",
                Course = " BSIS201",
                Username = " AtaGve",
                Password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword(" thenaGuiv",salt)
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Ivan Arsua",
                Course = " BSIS201",
                Username = "IvnArs",
                Password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword("IvnArs", salt)
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "Natsu Dragneel",
                Course = "BSIS201",
                Username = "NtuDgl",
                Password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword("FairyTail",salt)
            });

            context.StudentAssistants.Add(new Models.StudentAssistant()
            {
                Id = Guid.NewGuid(),
                PersonName = "LeviAckerman",
                Course = "BSIS201",
                Username = "LvAkn",
                Password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword("AotFs",salt)
            });

            context.SaveChanges();         

            context.Guests.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Danilo Flores",
                Address = "Luacan, Dinalupihan, Bataan",
                Age = 25,
                Gender = Models.Enums.Gender.Male
            });
            context.Guests.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Andrea Angeles",
                Address = "Saguing, Dinalupihan, Bataan",
                Age = 18,
                Gender = Models.Enums.Gender.Female
            });
            context.Guests.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Bert Sanggalang",
                Address = "San Ramon, Dinalupihan, Bataan",
                Age = 30,
                Gender = Models.Enums.Gender.Male
            });
            context.Guests.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Danica Castro",
                Address = "Luacan, Dinalupihan, Bataan",
                Age = 17,
                Gender = Models.Enums.Gender.Female
            });
            context.Guests.Add(new Models.Guest()
            {
                Id = Guid.NewGuid(),
                PersonName = "Leo Lim",
                Address = "Bacong, Hermosa, Bataan",
                Age = 21,
                Gender = Models.Enums.Gender.Male
            });
            context.SaveChanges();

            context.FAQEntries.Add(new Models.FAQEntry()
            {
                Id = Guid.NewGuid(),
                Question = "Where to pay tuition fee?",
               Answer = "Tuition fee can be paid at windows 1 and 2, they are nearly located at CSM quadrangle"
            });
            context.FAQEntries.Add(new Models.FAQEntry()
            {
                Id = Guid.NewGuid(),
                Question = "Where graduating students can acquire their requirements?",
                Answer = "Graduating students can get their requirements at the registar office. Ask the S.A for guidance"
            });
            context.FAQEntries.Add(new Models.FAQEntry()
            {
                Id = Guid.NewGuid(),
                Question = "Where can I get the school card?",
                Answer = "You can get your school card at the CSM quadrangle"
            });
            context.FAQEntries.Add(new Models.FAQEntry()
            {
                Id = Guid.NewGuid(),
                Question = "Where should the modules be able to pass and receive another?",
                Answer = "You can pass and get another module at the registar or at the CSM quadrangle. It is better to ask S.A for guidance."
            });
            context.FAQEntries.Add(new Models.FAQEntry()
            {
                Id = Guid.NewGuid(),
                Question = "How to apply for student admission?",
                Answer = "Visit the CSM FB page. Click the link for the student registration, then properly accomplish all the information"
            });
            context.SaveChanges();
            //TODO: Add your Data here
        }

    }
}

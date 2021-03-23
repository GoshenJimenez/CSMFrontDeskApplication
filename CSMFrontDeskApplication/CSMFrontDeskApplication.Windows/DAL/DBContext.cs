using CSMFrontDeskApplication.Windows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.DAL
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("myConnectionString")
        {
            Database.SetInitializer(new CSMFrontDeskApplication.Windows.DAL.DataInitializer());
        }

        public DbSet<Birthday> Birthdays { get; set; }

        public DbSet<StudentAssistant> StudentAssistants { get; set; }

        public DbSet<StudentAssistantLog> StudentAssistantLogs { get; set; }

        public DbSet<Guest> Guest { get; set; }

        public DbSet<GuestLog> GuestLog { get; set; }

        public DbSet<FAQEntry> FAQEntries { get; set; }

        //TODO: Add your models here 1 model 1 DbSet
    }
}

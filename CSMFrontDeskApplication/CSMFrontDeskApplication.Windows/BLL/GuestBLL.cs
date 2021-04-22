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
    public static class GuestBLL
    {
        private static SchoolDBContext db = new SchoolDBContext();

        public static List<Guest> GetAll()
        {
            return db.Guests.ToList();
        }
        public static Paged<Guest> Search(int pageIndex = 1, int pageSize = 10, string keyword = "")
        {
            var guests = db.Guests.Where(g => g.PersonName.ToLower().Contains(keyword.ToLower()));

            return new Paged<Guest >()
            {
                Items = guests.OrderByDescending(g => g.Gender).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList(),

                RowCount = guests.Count(),
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
        }
        public static Operation Login(GuestLoginViewModel model)
        {
            try
            {
                Guest guest = db.Guests.FirstOrDefault(g => g.PersonName.ToLower() == model.PersonName.ToLower() && g.Gender == model.Gender);

                Guid? guestId = Guid.NewGuid();
                if (guest == null)
                { 
                    db.Guests.Add(new Guest()
                    {
                        Id = guestId,
                        Address = model.Address,
                        Age = model.Age,
                        Gender = model.Gender,
                        PersonName = model.PersonName
                    });
                }
                else
                {
                    guestId = guest.Id;
                }

                db.GuestLogs.Add(new GuestLog()
                {
                    Id = Guid.NewGuid(),
                    GuestId = guestId,
                    Temperature = model.Temperature,
                    VisitAt = DateTime.Now
                });

                db.SaveChanges();

                return new Operation()
                {
                    Code = "Ok",
                    Message = new List<string>() { "Guest is created successfully." }
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

    public class GuestLoginViewModel : Guest
    {
        public decimal Temperature { get; set; }
    }
}

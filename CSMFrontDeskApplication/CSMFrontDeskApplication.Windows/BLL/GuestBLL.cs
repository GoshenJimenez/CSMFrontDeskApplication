﻿using CSMFrontDeskApplication.Windows.DAL;
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
    }
}
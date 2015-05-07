using HotelAdvisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelAdvisor.Managers
{
    public class HotelManager
    {
        public void Create(Hotel hotel)
        {
            using (var context = new HotelAdvisorContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
            }
        }

    }
}
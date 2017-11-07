using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarberShop.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string day { get; set; }
        public Barber Barber { get; set; }

    }
}
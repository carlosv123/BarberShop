using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarberShop.Models
{
    public class Barber
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string specialty { get; set; }
        public string email { get; set; }
        public BarberShop Barbershop { get; set; }
    }
}
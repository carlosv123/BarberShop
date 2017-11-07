using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarberShop.Models
{
    public class Earnings
    {
        public int Id { get; set; }
        public int dayProfit { get; set; }
        public int weeklyProfit { get; set; }
        public int dailyCustomers { get; set; }
        
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        
    }
}
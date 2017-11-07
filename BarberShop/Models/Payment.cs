using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarberShop.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public Double amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public virtual PaymentType paymenntType { get; set; }
    }
}
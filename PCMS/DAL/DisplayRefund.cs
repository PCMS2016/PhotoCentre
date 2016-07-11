using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DisplayRefund
    {
        public int RefundID { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}

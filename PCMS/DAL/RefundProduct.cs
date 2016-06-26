using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RefundProduct
    {
        public int RefundProductID { get; set; }
        public int RefundID { get; set; }
        public int OrderLineID { get; set; }
        public string Reason { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double LineTotal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double LineTotal { get; set; }
        public string Instructions { get; set; }
    }
}

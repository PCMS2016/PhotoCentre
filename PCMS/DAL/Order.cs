using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public string Payment { get; set; }
        public string Salesperson { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool Completed { get; set; }
        public bool Collected { get; set; }
        public string Customer { get; set; }
        public double Total { get; set; }
    }
}

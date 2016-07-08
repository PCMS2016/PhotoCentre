using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Refund
    {
        public int RefundID { get; set; }
        public int OrderNumber { get; set; }
        public int SalespersonID { get; set; }
        public string Salesperson { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Reports
    {
        public int RefundID { get; set; }
        public DateTime Date { get; set; }
        public int OrderNo { get; set; }
        public string SalesPerson { get; set; }
        public string Product { get; set; }
        public string Reason { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}

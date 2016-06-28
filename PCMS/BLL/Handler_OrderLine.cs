using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_OrderLine : IHandler_OrderLine
    {
        private IDBAccess_OrderLines db = null;
        public Handler_OrderLine()
        {
            db = new DBAccess_OrderLine();
        }
        public List<OrderLine> GetOrderLines(int orderNumber)
        {
            return db.GetOrderLines(orderNumber);
        }

        public bool AddOrderLine(OrderLine orderLine)
        {
            return db.AddOrderLine(orderLine);
        }

        public bool UpdateOrderLine(OrderLine orderLine)
        {
            return db.UpdateOrderLine(orderLine);
        }

        public bool RemoveOrderLine(int OrderLineID)
        {
            return db.RemoveOrderLine(OrderLineID);
        }
    }
}

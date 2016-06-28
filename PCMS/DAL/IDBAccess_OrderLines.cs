using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_OrderLines
    {
        List<OrderLine> GetOrderLines(int orderNumber);
        bool AddOrderLine(OrderLine orderLine);
        bool UpdateOrderLine(OrderLine orderLine);
        bool RemoveOrderLine(int OrderLineID);
    }
}

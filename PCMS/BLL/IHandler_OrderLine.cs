using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_OrderLine
    {
        List<OrderLine> GetOrderLines(int orderNumber);
        bool AddOrderLine(OrderLine orderLine);
        bool UpdateOrderLine(OrderLine orderLine);
        bool RemoveOrderLine(int OrderNumber);
    }
}

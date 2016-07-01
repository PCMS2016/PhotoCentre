using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Order
    {
        bool AddOrder(Order order);
        List<Order> GetAllOrders();
        bool UpdateOrder(Order order);
        bool RemoveOrder(int OrderNumber);
        List<Order> GetOrderByNum(int OrderNumber);
        int GetOrderNumber();
    }
}

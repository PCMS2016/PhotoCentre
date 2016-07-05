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
        int GetOrderNumber();
        List<Order> GetOrderByNum(int OrderNumber);
        List<Order> getParaCustList(string firstName, string lastName);
        List<Order> getOrderDateList(DateTime date);
        bool CompleteOrder(int OrderNum);
        bool CollectOrder(int OrderNum);
    }
}

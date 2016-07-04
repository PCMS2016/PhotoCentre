using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Order : IHandler_Order 
    {
        private IDBAccess_Order db = null;
        public Handler_Order()
        {
            db = new DBAccess_Order();
        }
        public bool AddOrder(Order order)
        {
            return db.AddOrder(order);
        }
        public List<Order> GetAllOrders()
        {
            return db.GetAllOrders();
        }
        public bool UpdateOrder(Order order)
        {
            return db.UpdateOrder(order);
        }
        public bool RemoveOrder(int OrderNumber)
        {
            return db.RemoveOrder(OrderNumber);
        }
        public List<Order> getParaOrderList(int OrderNum)
        {
            return db.GetOrderByNum(OrderNum);
        }

        public List<Order> getParaCustList(string firstName, string lastName)
        {
            return db.getParaCustList(firstName, lastName);
        }

        public List<Order> getOrderDateList(DateTime date)
        {
            return db.getOrderDateList(date);
        }
    }
}

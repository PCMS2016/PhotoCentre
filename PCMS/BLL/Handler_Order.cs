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
        public List<Order> GetAllOrders(bool completed, bool collected)
        {
            return db.GetAllOrders(completed, collected);
        }
        public bool UpdateOrder(Order order)
        {
            return db.UpdateOrder(order);
        }
        public bool RemoveOrder(int OrderNumber)
        {
            return db.RemoveOrder(OrderNumber);
        }
        public int GetOrderNumber()
        {
            return db.GetOrderNumber();
        }
        public List<Order> getParaOrderList(int OrderNum)
        {
            return db.GetOrderByNum(OrderNum);
        }

        public List<Order> getParaCustList(string firstName, string lastName, bool completed, bool collected)
        {
            return db.getParaCustList(firstName, lastName, completed, collected);
        }

        public List<Order> getOrderDateList(DateTime date, bool completed, bool collected)
        {
            return db.getOrderDateList(date, completed, collected);
        }
        
        public bool CompleteOrder(int OrderNum)
        {
            return db.CompleteOrder(OrderNum);
        }

        public bool CollectOrder(int OrderNum)
        {
            return db.CollectOrder(OrderNum);
        }
    }
}

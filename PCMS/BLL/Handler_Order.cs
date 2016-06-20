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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Refund : IHandler_Refund
    {
        private IDBAccess_Refund db = null;
        public Handler_Refund()
        {
            db = new DBAccess_Refund();
        }

        public Order getOrderByNum(int OrderNum)
        {
            return db.getOrderByNum(OrderNum);
        }

        public List<OrderLine> GetOrderLines(int orderNumber)
        {
            return db.GetOrderLines(orderNumber);
        }
    }
}

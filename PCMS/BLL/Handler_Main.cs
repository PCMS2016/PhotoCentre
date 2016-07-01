using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Main : IHandler_Main
    {
        private IDBAccess_Order accessOrder = null;

        public Handler_Main()
        {
            accessOrder = new DBAccess_Order();
        }

        public List<Order> getParaOrderList(int OrderNum)
        {
            return accessOrder.GetOrderByNum(OrderNum);
        }

        public List<Order> getParaCustList(string firstName, string lastName)
        {
            return accessOrder.getParaCustList(firstName, lastName);
        }

        public List<Order> getOrderDateList(string date)
        {
            return accessOrder.getOrderDateList(date);
        }
    }
}

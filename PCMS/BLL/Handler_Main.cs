using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class Handler_Main
    {
        DBAccess_Order accessOrder;

        public Handler_Main()
        {
            accessOrder = new DBAccess_Order();
        }

        public List<Order> getOrderList(int OrderNum)
        {
            return accessOrder.GetOrderByNum(OrderNum);
        }
    }
}

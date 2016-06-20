using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Order
    {
        bool AddOrder(Order order);
        List<Order> GetAllOrders();
    }
}

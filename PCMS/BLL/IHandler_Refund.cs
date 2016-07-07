using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Refund
    {
        Order getOrderByNum(int OrderNum);
        List<OrderLine> GetOrderLines(int orderNumber);
    }
}

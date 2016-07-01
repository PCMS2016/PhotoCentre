using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Main
    {
        List<Order> getParaOrderList(int OrderNum);
        List<Order> getParaCustList(string firstName, string lastName);
        List<Order> getOrderDateList(string date);
    }
}

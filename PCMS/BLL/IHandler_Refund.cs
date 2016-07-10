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
        SizeMedium GetProdByName(string prodName);
        bool AddRefund(Refund rfnd);
        int GetSalesPersonID(string salesPFName, string salesPLName);
        int GetRefundID(int orderNumber);
        int GetOrderLineID(int orderNumber);
        List<Refund> GetAllRefunds();
        bool VoidRefund(int refundID);
        bool VoidRefundProduct(int refundProdID);
        bool AddRefundProduct(RefundProduct rfndProd);
    }
}

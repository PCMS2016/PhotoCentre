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

        public SizeMedium GetProdByName(string prodName)
        {
            return db.GetProdByName(prodName);
        }

        public bool AddRefund(Refund rfnd)
        {
            return db.AddRefund(rfnd);
        }

        public int GetSalesPersonID(string salesPFName, string salesPLName)
        {
            return db.GetSalesPersonID(salesPFName, salesPLName);
        }

        public int GetRefundID(int orderNumber)
        {
            return db.GetRefundID(orderNumber);
        }

        public int GetOrderLineID(int orderNumber)
        {
            return db.GetOrderLineID(orderNumber);
        }

        public List<Refund> GetAllRefunds()
        {
            return db.GetAllRefunds();
        }

        public bool VoidRefund(int refundID)
        {
            return db.VoidRefund(refundID);
        }

        public bool VoidRefundProduct(int refundProdID)
        {
            return db.VoidRefundProduct(refundProdID);
        }

        public bool AddRefundProduct(RefundProduct rfndProd)
        {
            return db.AddRefundProduct(rfndProd);
        }
    }
}

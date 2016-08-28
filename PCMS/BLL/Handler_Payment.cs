using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Payment : IHandler_Payment 
    {
        private IDBAccess_Payment db = null;
        public Handler_Payment()
        {
            db = new DBAccess_Payment();
        }

        public bool AddPayment(Payment payment)
        {
            return db.AddPayment(payment);
        }

        public List<Payment> GetAllPayments()
        {
            return db.GetAllPayments();
        }

        public bool RemovePayment(int PaymentID)
        {
            return db.RemovePayment(PaymentID);
        }

        public bool UpdatePayment(Payment payment)
        {
            return db.UpdatePayment(payment);
        }
    }
}

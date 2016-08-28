using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Payment
    {
        List<Payment> GetAllPayments();
        bool AddPayment(Payment payment);
        bool UpdatePayment(Payment payment);
        bool RemovePayment(int PaymentID);
    }
}

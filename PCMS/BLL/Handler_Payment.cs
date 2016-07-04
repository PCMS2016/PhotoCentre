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
        public List<Payment> GetAllPayments()
        {
            return db.GetAllPayments();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Discount : IHandler_Discount
    {
        private IDBAccess_Discount db = null;
        public Handler_Discount()
        {
            db = new DBAccess_Discount();
        }
        public List<Discount> GetAllDiscount()
        {
            return db.GetAllDiscount();
        }
    }
}

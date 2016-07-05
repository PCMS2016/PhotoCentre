using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Customer : IHandler_Customer 
    {
        private IDBAccess_Customer db = null;

        public Handler_Customer()
        {
            db = new DBAccess_Customer();
        }
        public List<Customer> SearchCustomer(string Name, string Surname)
        {
            return db.SearchCustomer(Name, Surname);
        }
        public bool AddCustomer(Customer customer)
        {
            return db.AddCustomer(customer);
        }
        public bool UpdateCustomer(Customer customer)
        {
            return db.UpdateCustomer(customer);
        }
    }
}

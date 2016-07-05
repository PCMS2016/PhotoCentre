using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Customer
    {
        List<Customer> SearchCustomer(string Name, string Surname);
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        
    }
}

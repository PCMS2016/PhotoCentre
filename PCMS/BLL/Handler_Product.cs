using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Product : IHandler_Product 
    {
        private IDBAccess_Product db = null;
        public Handler_Product()
        {
            db = new DBAccess_Product();
        }
        public List<SizeMedium> GetAllProducts()
        {
            return db.GetAllProducts();
        }
    }
}

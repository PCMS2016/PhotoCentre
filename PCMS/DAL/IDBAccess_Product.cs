using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Product
    {
        List<SizeMedium> GetAllProducts();
        bool AddProduct(SizeMedium sizeMedium);
        bool UpdateProduct(SizeMedium sizeMedium);
        bool RemoveProduct(int SizeMediumID);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Product
    {
        List<SizeMedium> GetAllProducts();
        bool AddProduct(SizeMedium sizeMedium);
        bool UpdateProduct(SizeMedium sizeMedium);
        bool RemoveProduct(int ProductID);
    }
}

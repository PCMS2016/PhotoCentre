using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Discount
    {
        List<Discount> GetAllDiscount();
        bool AddDiscount(Discount discount);
        bool UpdateDiscount(Discount discount);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Refund
    {
        Order getOrderByNum(int OrderNum);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Special
    {
        bool AddSpecial(Special special);
        bool UpdateSpecial(Special special);
        bool RemoveSpecial(int SpecialID);
        List<Special> GetAllSpecials();
        List<Special> GetSpecialsByProduct(int SizeMediumID);
        List<Special> GetSpecialsByDate(DateTime date);
    }
}

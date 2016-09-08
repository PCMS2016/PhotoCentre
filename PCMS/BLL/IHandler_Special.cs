using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Special
    {
        bool AddSpecial(Special special);
        List<Special> GetAllSpecials();
        List<Special> GetSpecialsByDate(DateTime date);
        List<Special> GetSpecialsByProduct(int SizeMediumID);
        bool RemoveSpecial(int SpecialID);
        bool UpdateSpecial(Special special);
        List<string> GetAllEmailAddresses();
    }
}

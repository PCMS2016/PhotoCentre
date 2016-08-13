using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Special : IHandler_Special
    {
        private IDBAccess_Special db = null;
        public Handler_Special()
        {
            db = new DBAccess_Special();
        }

        public bool AddSpecial(Special special)
        {
            return db.AddSpecial(special);
        }

        public List<Special> GetAllSpecials()
        {
            return db.GetAllSpecials();
        }

        public List<Special> GetSpecialsByDate(DateTime date)
        {
            return db.GetSpecialsByDate(date);
        }

        public List<Special> GetSpecialsByProduct(int SizeMediumID)
        {
            return db.GetSpecialsByProduct(SizeMediumID);
        }

        public bool RemoveSpecial(int SpecialID)
        {
            return db.RemoveSpecial(SpecialID);
        }

        public bool UpdateSpecial(Special special)
        {
            return db.UpdateSpecial(special);
        }
    }
}

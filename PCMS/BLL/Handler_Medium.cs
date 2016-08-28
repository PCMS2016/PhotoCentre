using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Medium : IHandler_Medium
    {
        private IDBAccess_Medium db = null;
        public Handler_Medium()
        {
            db = new DBAccess_Medium();
        }
        public bool AddMedium(Medium medium)
        {
            return db.AddMedium(medium);
        }

        public List<Medium> GetAllMediums()
        {
            return db.GetAllMediums();
        }

        public bool RemoveMedium(int MediumID)
        {
            return db.RemoveMedium(MediumID);
        }

        public bool UpdateMedium(Medium medium)
        {
            return db.UpdateMedium(medium);
        }
    }
}

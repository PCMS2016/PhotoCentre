using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Size : IHandler_Size 
    {
        private IDBAccess_Size db = null;
        public Handler_Size()
        {
            db = new DBAccess_Size();
        }
        public bool AddSize(Size size)
        {
            return db.AddSize(size);
        }

        public List<Size> GetAllSizes()
        {
            return db.GetAllSizes();
        }

        public bool RemoveSize(int SizeID)
        {
            return db.RemoveSize(SizeID);
        }

        public bool UpdateSize(Size size)
        {
            return db.UpdateSize(size);
        }
    }
}

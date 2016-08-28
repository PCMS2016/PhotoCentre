using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Medium
    {
        bool AddMedium(Medium medium);
        bool UpdateMedium(Medium medium);
        bool RemoveMedium(int MediumID);
        List<Medium> GetAllMediums();
    }
}

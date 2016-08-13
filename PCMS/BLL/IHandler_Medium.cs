using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Medium
    {
        bool AddMedium(Medium medium);
        bool UpdateMedium(Medium medium);
        bool RemoveMedium(int MediumID);
        List<Medium> GetAllMediums();
    }
}

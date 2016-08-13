using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Size
    {
        bool AddSize(Size size);
        bool UpdateSize(Size size);
        bool RemoveSize(int SizeID);
        List<Size> GetAllSizes();
    }
}

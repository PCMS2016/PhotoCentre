using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Login : IHandler_Login 
    {
        private IDBAccess_Login db = null;
        public Handler_Login()
        {
            db = new DBAccess_Login();
        }
        public void Login(Salesperson salesperson)
        {
            db.Login(salesperson);
        }
    }
}

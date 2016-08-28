using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Company : IHandler_Company
    {
        private IDBAccess_Company db = null;
        public Handler_Company()
        {
            db = new DBAccess_Company();
        }
        public bool AddCompany(Company company)
        {
            return db.AddCompany(company);
        }

        public Company GetCompanyDetails()
        {
            return db.GetCompanyDetails();
        }

        public bool UpdateCompany(Company company)
        {
            return db.UpdateCompany(company);
        }
    }
}

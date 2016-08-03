using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDBAccess_Company
    {
        Company GetCompanyDetails();
        bool AddCompany(Company company);
        bool UpdateCompany(Company company);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Company : IDBAccess_Company
    {

        public Company GetCompanyDetails()
        {
            Company company = new Company();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetCompany", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        company.Name = row["Name"].ToString();
                        company.Address1 = row["Address 1"].ToString();
                        company.Address2 = row["Address 2"].ToString();
                        company.Suburb = row["Suburb"].ToString();
                        company.City = row["City"].ToString();
                        company.PostalCode = row["PostalCode"].ToString();
                        company.Phone = row["Phone"].ToString();
                        company.Fax = row["Fax"].ToString();
                        company.Email = row["Email"].ToString();
                        company.RefundPeriod = Convert.ToInt32(row["RefundPeriod"].ToString());
                    }
                }
            }

            return company;
        }
    }
}

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
        public bool AddCompany(Company company)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", company.Name),
                new SqlParameter("@Address1", company.Address1),
                new SqlParameter("@Address2", company.Address2),
                new SqlParameter("@Suburb", company.Suburb),
                new SqlParameter("@City", company.City),
                new SqlParameter("@PostalCode", company.PostalCode),
                new SqlParameter("@Phone", company.Phone),
                new SqlParameter("@Fax", company.Fax),
                new SqlParameter("@Email", company.Email),
                new SqlParameter("@RefundPeriod", company.RefundPeriod)
            };
            return DBHelper.ExecuteNonQuery("sp_AddCompany", CommandType.StoredProcedure, parameters);
        }
        public bool UpdateCompany(Company company)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", company.Name),
                new SqlParameter("@Address1", company.Address1),
                new SqlParameter("@Address2", company.Address2),
                new SqlParameter("@Suburb", company.Suburb),
                new SqlParameter("@City", company.City),
                new SqlParameter("@PostalCode", company.PostalCode),
                new SqlParameter("@Phone", company.Phone),
                new SqlParameter("@Fax", company.Fax),
                new SqlParameter("@Email", company.Email),
                new SqlParameter("@RefundPeriod", company.RefundPeriod)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateCompany", CommandType.StoredProcedure, parameters);
        }
    }
}

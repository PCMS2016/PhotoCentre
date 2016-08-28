using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Salesperson : IDBAccess_Salesperson
    {
        public bool AddSalesperson(Salesperson salesperson)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", salesperson.Name),
                new SqlParameter("@Surname", salesperson.Surname),
                new SqlParameter("@Username", salesperson.Username),
                new SqlParameter("@Password", salesperson.Password),
                new SqlParameter("@Privileges", salesperson.Privileges),
                new SqlParameter("@EmployeeType", salesperson.EmployeeType)
            };
            return DBHelper.ExecuteNonQuery("sp_AddSalesperson", CommandType.StoredProcedure, parameters);
        }
        public bool UpdateSalesperson(Salesperson salesperson)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SalespersonID", salesperson.SalespersonID),
                new SqlParameter("@Name", salesperson.Name),
                new SqlParameter("@Surname", salesperson.Surname),
                new SqlParameter("@Username", salesperson.Username),
                new SqlParameter("@Password", salesperson.Password),
                new SqlParameter("@Privileges", salesperson.Privileges),
                new SqlParameter("@EmployeeType", salesperson.EmployeeType)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateSalesperson", CommandType.StoredProcedure, parameters);
        }
        public bool RemoveSalesperson(int SalespersonID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SalespersonID", SalespersonID)
            };
            return DBHelper.ExecuteNonQuery("sp_DeactivateSalesperson", CommandType.StoredProcedure, parameters);
        }
        public List<Salesperson> GetAllSalespersons()
        {
            List<Salesperson> list = new List<Salesperson>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllSalespersons", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Salesperson salesperson = new Salesperson();
                        salesperson.SalespersonID = Convert.ToInt32(row["SalespersonID"].ToString());
                        salesperson.Name = row["Name"].ToString();
                        salesperson.Surname = row["Surname"].ToString();
                        salesperson.Username = row["Username"].ToString();
                        salesperson.Password = row["Password"].ToString();
                        salesperson.Privileges = row["Privileges"].ToString();
                        salesperson.EmployeeType = row["Employee Type"].ToString();
                        list.Add(salesperson);
                    }
                }
            }
            return list;
        }
        public List<Salesperson> SearchSalesperson(string Name, string Surname)
        {
            List<Salesperson> list = new List<Salesperson>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", Name),
                new SqlParameter("@Surname", Surname)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchSalesperson", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Salesperson salesperson = new Salesperson();
                        salesperson.SalespersonID = Convert.ToInt32(row["SalespersonID"].ToString());
                        salesperson.Name = row["Name"].ToString();
                        salesperson.Surname = row["Surname"].ToString();
                        salesperson.Username = row["Username"].ToString();
                        salesperson.Password = row["Password"].ToString();
                        salesperson.Privileges = row["Privileges"].ToString();
                        salesperson.EmployeeType = row["Employee Type"].ToString();
                        list.Add(salesperson);
                    }
                }
            }
            return list;
        }
    }
}

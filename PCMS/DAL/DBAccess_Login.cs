using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Login : IDBAccess_Login 
    {
        public DBAccess_Login()
        {
        
        }
        public void Login(Salesperson salesperson)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", salesperson.Username),
                new SqlParameter("@password", salesperson.Password)
            };
            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_Login", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];
                    salesperson.SalespersonID = Convert.ToInt32(row["SalespersonID"]);
                    salesperson.Name = row["Name"].ToString();
                    salesperson.Surname = row["Surname"].ToString();
                    salesperson.Privileges = row["Privileges"].ToString();
                    salesperson.EmployeeType = row["EmployeeType"].ToString();
                }
                
            }
        }
    }
}

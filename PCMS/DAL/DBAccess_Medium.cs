using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Medium : IDBAccess_Medium
    {
        public bool AddMedium(Medium medium)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Description", medium.Description)
            };
            return DBHelper.ExecuteNonQuery("sp_AddMedium", CommandType.StoredProcedure, parameters);
        }

        public List<Medium> GetAllMediums()
        {
            List<Medium> list = new List<Medium>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllMediums", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Medium medium = new Medium();
                        medium.MediumID = Convert.ToInt32(row["MediumID"].ToString());
                        medium.Description = row["Description"].ToString();
                        list.Add(medium);
                    }
                }
            }
            return list;
        }

        public bool RemoveMedium(int MediumID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", MediumID)
            };
            return DBHelper.ExecuteNonQuery("sp_DeactivateMedium", CommandType.StoredProcedure, parameters);
        }

        public bool UpdateMedium(Medium medium)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", medium.MediumID),
                new SqlParameter("@Description", medium.Description)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateMedium", CommandType.StoredProcedure, parameters);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Size : IDBAccess_Size
    {
        public bool AddSize(Size size)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Size", size.SizeDescription)
            };
            return DBHelper.ExecuteNonQuery("sp_AddSize", CommandType.StoredProcedure, parameters);
        }
        public bool UpdateSize(Size size)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", size.SizeID),
                new SqlParameter("@Size", size.SizeDescription)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateSize", CommandType.StoredProcedure, parameters);
        }
        public bool RemoveSize(int SizeID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", SizeID)
            };
            return DBHelper.ExecuteNonQuery("sp_DeactivateSize", CommandType.StoredProcedure, parameters);
        }
        public List<Size> GetAllSizes()
        {
            List<Size> list = new List<Size>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllSizes", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach(DataRow row in table.Rows)
                    {
                        Size size = new Size();
                        size.SizeID = Convert.ToInt32(row["SizeID"].ToString());
                        size.SizeDescription = row["Size"].ToString();
                        list.Add(size);
                    }
                }
            }
            return list;
        }
    }
}

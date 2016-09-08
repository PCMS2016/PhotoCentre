using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess_Special : IDBAccess_Special
    {
        public bool AddSpecial(Special special)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SizeMediumID", Convert.ToInt32(special.Product)),
                new SqlParameter("@Qty", Convert.ToInt32(special.Quantity)),
                new SqlParameter("@Price", special.Price),
                new SqlParameter("@StartDate", special.StartDate),
                new SqlParameter("@EndDate", special.EndDate)
            };
            return DBHelper.ExecuteNonQuery("sp_AddSpecial", CommandType.StoredProcedure, parameters);
        }

        public List<string> GetAllEmailAddresses()
        {
            List<string> list = new List<string>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllEmailAddresses", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(row["Email"].ToString());
                    }
                }
            }
            return list;
        }

        public List<Special> GetAllSpecials()
        {
            List<Special> list = new List<Special>();

            using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllSpecials", CommandType.StoredProcedure))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Special special = new Special();
                        special.SpecialID = Convert.ToInt32(row["SpecialID"].ToString());
                        special.Product = row["Product"].ToString();
                        special.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        special.Price = Convert.ToDouble(row["Price"].ToString());
                        special.StartDate = Convert.ToDateTime(row["Start Date"].ToString());
                        special.EndDate = Convert.ToDateTime(row["End Date"].ToString());
                        list.Add(special);
                    }
                }
            }
            return list;
        }

        public List<Special> GetSpecialsByDate(DateTime date)
        {
            List<Special> list = new List<Special>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Date", date)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchSpecialsByDate", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Special special = new Special();
                        special.SpecialID = Convert.ToInt32(row["SpecialID"].ToString());
                        special.Product = row["Product"].ToString();
                        special.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        special.Price = Convert.ToDouble(row["Price"].ToString());
                        special.StartDate = Convert.ToDateTime(row["Start Date"].ToString());
                        special.EndDate = Convert.ToDateTime(row["End Date"].ToString());
                        list.Add(special);
                    }
                }
            }
            return list;
        }

        public List<Special> GetSpecialsByProduct(int SizeMediumID)
        {
            List<Special> list = new List<Special>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SizeMediumID", SizeMediumID)
            };

            using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_SearchSpecialsByProduct", CommandType.StoredProcedure, parameters))
            {
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Special special = new Special();
                        special.SpecialID = Convert.ToInt32(row["SpecialID"].ToString());
                        special.Product = row["Product"].ToString();
                        special.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                        special.Price = Convert.ToDouble(row["Price"].ToString());
                        special.StartDate = Convert.ToDateTime(row["Start Date"].ToString());
                        special.EndDate = Convert.ToDateTime(row["End Date"].ToString());
                        list.Add(special);
                    }
                }
            }
            return list;
        }

        public bool RemoveSpecial(int SpecialID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SpecialID", SpecialID)
            };
            return DBHelper.ExecuteNonQuery("sp_DeactivateSpecial", CommandType.StoredProcedure, parameters);
        }

        public bool UpdateSpecial(Special special)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SpecialID", special.SpecialID),
                new SqlParameter("@SizeMediumID", Convert.ToInt32(special.Product)),
                new SqlParameter("@Qty", Convert.ToInt32(special.Quantity)),
                new SqlParameter("@Price", special.Price),
                new SqlParameter("@StartDate", special.StartDate),
                new SqlParameter("@EndDate", special.EndDate)
            };
            return DBHelper.ExecuteNonQuery("sp_UpdateSpecial", CommandType.StoredProcedure, parameters);
        }
    }
}

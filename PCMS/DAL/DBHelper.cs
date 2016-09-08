using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class DBHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["PCMS_Local_Wynand"].ConnectionString;

        //Select command with parameters
        public static DataTable ExecuteParamerizedSelectCommand(string commandName, CommandType commandType, SqlParameter[] parameters)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = commandType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(parameters);
                    
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }

        //Select command without parameters
        public static DataTable ExecuteSelectCommand(string commandName, CommandType commandType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = commandType;
                    cmd.CommandText = commandName;

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }

        //Non query (Add,Update,Delete)
        public static bool ExecuteNonQuery(string commandName, CommandType commandType, SqlParameter[] parameters)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = commandType;
                    cmd.CommandText = commandName;
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        result = cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return result > 0;
        }

        //Scalar
        public static DataTable ExecuteScalarCommand(string commandName, CommandType commandType)
        {
            DataTable table = null;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = commandType;
                    cmd.CommandText = commandName;

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return table;
        }
    }
}

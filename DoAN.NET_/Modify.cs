using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAN.NET_
{
    class Modify
    {
        public Modify() 
        {
            
        }
        SqlCommand cmd;
        SqlDataReader dr;
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlCon = Connection.GetSqlConnection())
            {
                sqlCon.Open();
                cmd = new SqlCommand(query, sqlCon);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dr.GetString(0), dr.GetString(1)));
                }
                sqlCon.Close();
            }
            return taiKhoans;
        }
        SqlDataAdapter da ;
        public DataTable Table(string query)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                da = new SqlDataAdapter(query,conn);
                da.Fill(datatable);
                conn.Close();
            }
            return datatable;
        } 
        public void SqlCommand(string query)
        {
            using (SqlConnection sqlConn = Connection.GetSqlConnection())
            {
                sqlConn.Open();
                cmd = new SqlCommand(query, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
        }

        public void SqlCommand1(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

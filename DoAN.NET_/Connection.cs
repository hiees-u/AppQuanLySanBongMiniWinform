using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN.NET_
{
    class Connection
    {
        private static string strCon = @"Data Source=YN\SQLEXPRESS;Initial Catalog=QL_SanBanh1;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strCon);
        }
    }
}

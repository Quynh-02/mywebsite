using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLPhongKham
{
    class Connection
    {
        private  static string stringConnection = @"Data Source=DESKTOP-85CF1R9\SQLEXPRESS;Initial Catalog = QL_PhongKham;User = sa; Password=123";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}

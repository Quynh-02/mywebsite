using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLPhongKham
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh insert, upfate, delete...
        SqlDataReader dataReader; //dung de doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taikhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(item: new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(4)));
                } 

                sqlConnection.Close();

            }
            return taikhoans;
        }
        public void Command(string query) // dung de dang ky tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thuc thi cau truy van
                sqlConnection.Close();
            }
        }

    }
}

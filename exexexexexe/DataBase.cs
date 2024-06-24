using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace exexexexexe
{
    class DataBase
    {
        //stud-mssql.sttec.yar.ru,38325
        SqlConnection con = new SqlConnection(@"Data Source=stud-mssql.sttec.yar.ru,38325;Initial Catalog=user198_db; User=user198_db; Password=user198");
        public static Susem_dbEntities context = new Susem_dbEntities();

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
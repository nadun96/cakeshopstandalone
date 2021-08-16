using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CakeFactory
{
    class Dbconnection
    {
        public DataSet DSet = new DataSet();
        public SqlDataAdapter Sqlda = new SqlDataAdapter();
        public SqlConnection Conn = new SqlConnection();
        public SqlCommand Cmd = new SqlCommand();
        public string Sqlds = "Data Source=DESKTOP-QPJ0806\\SQLEXPRESS;Initial Catalog=CakeShop;Integrated Security=True";
    }
}
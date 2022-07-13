using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cookie_Master
{
    internal class DataBase
    {
        SqlConnection CookieSqlConnection = new SqlConnection(@"Data Source = (local); Initial Catalog = CookieMasterDB; Integrated Security = True; User ID = Tester; Password = CookieMasterTest");


        public void ConnectionOpen()
        {
            if (CookieSqlConnection.State == System.Data.ConnectionState.Closed)
            {
                CookieSqlConnection.Open();
            }
        }

        public void ConnectionClose()
        {
            if (CookieSqlConnection.State == System.Data.ConnectionState.Open)
            {
                CookieSqlConnection.Close();
            }
        }

        public SqlConnection ConnectionGet()
        {
            return CookieSqlConnection;
        }

    }
}

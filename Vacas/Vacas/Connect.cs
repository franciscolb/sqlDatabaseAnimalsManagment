using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    abstract class Connect
    {
        public static SqlConnection cn;

        public static bool verifySGBDConnection()
        {
            if (cn == null)
                getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        public static void getSGBDConnection()
        {
            cn = new SqlConnection("data source= tcp:193.136.175.33\\SQLSERVER2012,8293;initial catalog=xxxx; uid = xxxx; password = xxxx");
        }
    }
}

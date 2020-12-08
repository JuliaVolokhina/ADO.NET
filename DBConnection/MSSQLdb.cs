using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBConnection
{
    public class MSSQLdb
    {
        private static string connection;

        public static SqlConnection GetConnection()
        {
            connection = $@"Server= {"DESKTOP-EMEUIMH\\SQLEXPRESS"}; Database= {"Company"}; Integrated Security=True";
            var c = new SqlConnection(connection);
            return c;
        }
    }
}

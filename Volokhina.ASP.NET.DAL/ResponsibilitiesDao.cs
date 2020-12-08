using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;
using Volokhina.ASP.NET.DAL.Interface;
using System.Data.SqlClient;
using System.Data;
using DBConnection;

namespace Volokhina.ASP.NET.DAL
{
    public class ResponsibilitiesDao : IResponsibilitiesDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddResponsibility(Responsibilities value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddResponsibility";

                cmd.Parameters.Add(new SqlParameter("@IDPosition", value.IDPosition));
                cmd.Parameters.Add(new SqlParameter("@IDTask", value.IDTask));
                connection.Open();

                Object tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;

                //return (int)cmd.ExecuteScalar();
            }
        }

        public void DeleteResponsibility(int value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteResponsibility";

                cmd.Parameters.Add(new SqlParameter("@IDPosition", value));

                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Responsibilities> GetAllResponsibilities()
        {
            var result = new List<Responsibilities>();
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllResponsibilities", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var responsibilities = new Responsibilities
                    {
                        IDPosition = (int)reader["IDPosition"],
                        IDTask = (int)reader["IDTask"]
                    };

                    result.Add(responsibilities);
                }
            }

            return result;
        }
    }
}

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
    public class TaskDao : ITaskDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddTask(Entities.Task value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddTask";

                cmd.Parameters.Add(new SqlParameter("@IDTask", value.IDTask));
                cmd.Parameters.Add(new SqlParameter("@NameOfTask", value.NameOfTask));
                connection.Open();

                Object tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;

                //return (int)cmd.ExecuteScalar();
            }
        }

        public void DeleteTask(int value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteTask";

                cmd.Parameters.Add(new SqlParameter("@IDTask", value));

                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Entities.Task> GetAllTasks()
        {
            var result = new List<Entities.Task>();
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllTasks", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var task = new Entities.Task
                    {
                        IDTask = (int)reader["IDTask"],
                        NameOfTask = (string)reader["NameOfTask"]
                    };

                    result.Add(task);
                }
            }

            return result;
        }
    }
}

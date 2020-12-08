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
    public class ListOfWorkersDao : IListOfWorkersDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddListOfWorkers(ListOfWorkers value)
        {
            const string sqlExpression =
                    "INSERT INTO ListOfWorkers (IDEmployee, IDPosition) VALUES (@IDEmployee, @IDPosition)";
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                var param = new SqlParameter("@IDEmployee", value.IDEmployee);
                command.Parameters.Add(param);
                var param2 = new SqlParameter("@IDPosition", value.IDPosition);
                command.Parameters.Add(param2);
                var number = command.ExecuteNonQuery();
                return number;
            }
        }

        public void DeleteListOfWorkers(int value)
        {
            const string sqlExpression = "DELETE FROM ListOfWorkers WHERE IDEmployee = @idEmployee";
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                var idParam = new SqlParameter("@idEmployee", value);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ListOfWorkers> GetAllListOfWorkers()
        {
            const string sqlExpression = "SELECT * FROM ListOfWorkers";
            var result = new List<ListOfWorkers>();
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                        result.Add(new ListOfWorkers(
                            (int)dataReader["IDEmployee"],
                            (int)dataReader["IDPosition"]));
                }
            }
            return result.AsEnumerable();
        }       
    }
}

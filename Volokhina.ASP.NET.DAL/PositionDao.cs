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
    public class PositionDao : IPositionDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddPosition(Position value)
        {
            const string sqlExpression =
                    "INSERT INTO Position (IDPosition, NameOfPosition) VALUES (@IDPosition, @NameOfPosition)";
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                var param = new SqlParameter("@IDPosition", value.IDPosition);
                command.Parameters.Add(param);
                var param2 = new SqlParameter("@NameOfPosition", value.NameOfPosition);
                command.Parameters.Add(param2);
                var number = command.ExecuteNonQuery();
                return number;
            }
        }

        public void DeletePosition(int value)
        {
            const string sqlExpression = "DELETE FROM Position WHERE IDPosition = @idPosition";
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                var idParam = new SqlParameter("@idPosition", value);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Position> GetAllPositions()
        {
            const string sqlExpression = "SELECT * FROM Position";
            var result = new List<Position>();
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                        result.Add(new Position(
                            (int)dataReader["IDPosition"],
                            (string)dataReader["NameOfPosition"]));
                }
            }
            return result.AsEnumerable();
        }
    }
}

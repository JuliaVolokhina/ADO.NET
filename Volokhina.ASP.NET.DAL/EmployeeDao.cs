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
    public class EmployeeDao : IEmployeeDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddEmployee(Employee value)
        {
            const string sqlExpression =
                    "INSERT INTO Employee (FullName, Age, PhoneNumber, Email, Address) VALUES (@FullName, @Age, @PhoneNumber, @Email,  @Address)";
            using (var connection = MSSQLdb.GetConnection())
            {
                //SqlCommand cmd = connection.CreateCommand();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandText = "AddEmployee";

                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                var param = new SqlParameter("@IDEmployee", value.IDEmployee);
                command.Parameters.Add(param);
                var param2 = new SqlParameter("@FullName", value.FullName);
                command.Parameters.Add(param2);
                var param3 = new SqlParameter("@Age", value.Age);
                command.Parameters.Add(param3);
                var param4 = new SqlParameter("@PhoneNumber", value.PhoneNumber);
                command.Parameters.Add(param4);
                var param5 = new SqlParameter("@Email", value.Email);
                command.Parameters.Add(param5);
                var param6 = new SqlParameter("@Address", value.Address);
                command.Parameters.Add(param6);
                var number = command.ExecuteNonQuery();
                return number;

                //cmd.Parameters.Add(new SqlParameter("@IDEmployee", value.IDEmployee));
                //cmd.Parameters.Add(new SqlParameter("@FullName", value.FullName));
                //cmd.Parameters.Add(new SqlParameter("@Age", value.Age));
                //cmd.Parameters.Add(new SqlParameter("@PhoneNumber", value.PhoneNumber));
                //cmd.Parameters.Add(new SqlParameter("@Email", value.Email));
                //cmd.Parameters.Add(new SqlParameter("@Address", value.Address));
                //connection.Open();

                //Object tmp = cmd.ExecuteScalar();

                //if (tmp == null)
                //    return -1;
                //return (int)tmp;

                //return (int)cmd.ExecuteScalar();
            }
        }

        public void DeleteEmployee(int value)
        {
            const string sqlExpression = "DELETE FROM Employee WHERE IDEmployee = @idEmployee";
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                var idParam = new SqlParameter("@idEmployee", value);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            const string sqlExpression = "SELECT * FROM Employee";
            var result = new List<Employee>();
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                        result.Add(new Employee((int)dataReader["IDEmployee"],
                        (string)dataReader["FullName"],
                        (int)dataReader["Age"],
                        (string)dataReader["PhoneNumber"].ToString(),
                        (string)dataReader["Email"],
                        (string)dataReader["Address"]));
                }
            }
            return result.AsEnumerable();
        }

        public Employee GetEmployeeById(int id)
        {
            const string sqlExpression =
                "SELECT IDEmployee, FullName, Age, PhoneNumber, Email, Address FROM Employee where IDEmployee = @id";
            using (var connection = MSSQLdb.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@id", id);
                using (var dataReader = command.ExecuteReader())
                {
                    dataReader.Read();
                    return new Employee(
                        (int)dataReader["IDEmployee"],
                        (string)dataReader["FullName"],
                        (int)dataReader["Age"],
                        (string)dataReader["PhoneNumber"].ToString(),
                        (string)dataReader["Email"],
                        (string)dataReader["Address"]);
                }
            }
        }
    }
}

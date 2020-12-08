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
    public class SalaryDao : ISalaryDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddSalary(Salary value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddSalary";

                cmd.Parameters.Add(new SqlParameter("@IDSalary", value.IDSalary));
                cmd.Parameters.Add(new SqlParameter("@DateOfPayment", value.DateOfPayment));
                cmd.Parameters.Add(new SqlParameter("@Amount", value.Amount));
                connection.Open();

                Object tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;

                //return (int)cmd.ExecuteScalar();
            }
        }

        public void DeleteSalary(int value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteSalary";

                cmd.Parameters.Add(new SqlParameter("@IDSalary", value));

                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Salary> GetAllSalaries()
        {
            var result = new List<Salary>();
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllSalaries", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var salary = new Salary
                    {
                        IDSalary = (int)reader["IDSalary"],
                        DateOfPayment = (int)reader["DateOfPayment"],
                        Amount = (int)reader["Amount"]
                    };

                    result.Add(salary);
                }
            }

            return result;
        }
    }
}

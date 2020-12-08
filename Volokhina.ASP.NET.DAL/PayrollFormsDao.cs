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
    public class PayrollFormsDao : IPayrollFormsDao
    {
        //private string connnectionString = "Data Source=DESKTOP-EMEUIMH\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True";

        public int AddPayrollForm(PayrollForms value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddPayrollForm";

                cmd.Parameters.Add(new SqlParameter("@IDEmployee", value.IDEmployee));
                cmd.Parameters.Add(new SqlParameter("@IDSalary", value.IDSalary));
                connection.Open();

                Object tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;

                //return (int)cmd.ExecuteScalar();
            }
        }

        public void DeletePayrollForm(int value)
        {
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeletePayrollForm";

                cmd.Parameters.Add(new SqlParameter("@IDUser", value));

                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<PayrollForms> GetAllPayrollForms()
        {
            var result = new List<PayrollForms>();
            using (var connection = MSSQLdb.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllPayrollForms", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var payrollForms = new PayrollForms
                    {
                        IDEmployee = (int)reader["IDEmployee"],
                        IDSalary = (int)reader["IDSalary"]
                    };

                    result.Add(payrollForms);
                }
            }

            return result;
        }
    }
}

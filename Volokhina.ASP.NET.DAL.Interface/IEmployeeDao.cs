using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.DAL.Interface
{
    public interface IEmployeeDao
    {
        IEnumerable<Employee> GetAllEmployees();

        int AddEmployee(Employee value);

        void DeleteEmployee(int value);
        Employee GetEmployeeById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.BLL.Interface
{
    public interface IEmployeeLogic
    {
        List<Employee> GetAllEmployees();

        int AddEmployee(Employee value);

        void DeleteEmployee(int value);
        Employee GetEmployeeById(int id);
    }
}

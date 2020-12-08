using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;
using Volokhina.ASP.NET.BLL.Interface;
using Volokhina.ASP.NET.DAL;
using Volokhina.ASP.NET.DAL.Interface;

namespace Volokhina.ASP.NET.BLL
{
    public class EmployeeLogic : IEmployeeLogic
    {
        private IEmployeeDao employeeDao;
        public EmployeeLogic(IEmployeeDao employeeDao)
        {
            this.employeeDao = new EmployeeDao();
        }
        public EmployeeLogic()
        {
            this.employeeDao = new EmployeeDao();
        }

        public int AddEmployee(Employee value)
        {
            return this.employeeDao.AddEmployee(value);
        }

        public void DeleteEmployee(int value)
        {
            employeeDao.DeleteEmployee(value);
        }

        public List<Employee> GetAllEmployees()
        {
            var employeeList = employeeDao.GetAllEmployees();
            return employeeList.ToList();
        }

        /*public IEnumerable<Employee> GetAllEmployees()
        {
            return this.employeeDao.GetAllEmployees();
        }*/

        public Employee GetEmployeeById(int id)
        {
            return employeeDao.GetEmployeeById(id);
        }
    }
}

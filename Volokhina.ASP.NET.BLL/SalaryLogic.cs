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

    public class SalaryLogic : ISalaryLogic
    {
        private ISalaryDao salaryDao;

        public SalaryLogic()
        {
            this.salaryDao = new SalaryDao();
        }

        public int AddSalary(Salary value)
        {
            return this.salaryDao.AddSalary(value);
        }

        public void DeleteSalary(int value)
        {
            salaryDao.DeleteSalary(value);
        }

        public IEnumerable<Salary> GetAllSalaries()
        {
            return this.salaryDao.GetAllSalaries();
        }
    }
}
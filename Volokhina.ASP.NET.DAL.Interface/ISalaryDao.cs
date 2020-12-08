using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.DAL.Interface
{
    public interface ISalaryDao
    {
        IEnumerable<Salary> GetAllSalaries();

        int AddSalary(Salary value);

        void DeleteSalary(int value);
    }
}

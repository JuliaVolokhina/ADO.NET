using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{
    public class PayrollForms
    {
        public int IDEmployee { get; set; }
        public int IDSalary { get; set; }

        public PayrollForms()
        { }

        public PayrollForms(int idEmployee, int idSalary)
        {
            IDEmployee = idEmployee;
            IDSalary = idSalary;
        }
        public override string ToString()
        {
            return $"{IDEmployee} {IDSalary}";
        }
    }
}

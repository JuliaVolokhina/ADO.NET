using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{
    public class Salary
    {
        public int IDSalary { get; set; }
        public int DateOfPayment { get; set; }
        public int Amount { get; set; }

        public Salary()
        { }

        public Salary(int idSalary, int dateOfPayment, int amount)
        {
            IDSalary = idSalary;
            DateOfPayment = dateOfPayment;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{IDSalary} {DateOfPayment} {Amount}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class PayrollFormsModel
    {
        public int IDEmployee { get; set; }

        public int IDSalary { get; set; }
        public PayrollFormsModel(int iDEmployee, int iDSalary)
        {
            IDEmployee = iDEmployee;
            IDSalary = iDSalary;
        }
    }
}
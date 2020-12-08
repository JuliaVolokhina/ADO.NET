using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class SalaryModel
    {
        public int IDSalary { get; set; }

        public DateTime DateOfPayment { get; set; }

        public int Amount { get; set; }
        public SalaryModel(int iDSalary, DateTime dateOfPayment, int amount)
        {
            IDSalary = iDSalary;
            DateOfPayment = dateOfPayment;
            Amount = amount;
        }
    }
}
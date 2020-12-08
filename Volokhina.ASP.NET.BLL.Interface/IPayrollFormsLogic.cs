using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.BLL.Interface
{
    public interface IPayrollFormsLogic
    {
        IEnumerable<PayrollForms> GetAllPayrollForms();

        int AddPayrollForm(PayrollForms value);

        void DeletePayrollForm(int value);
    }
}

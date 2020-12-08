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

    public class PayrollFormsLogic : IPayrollFormsLogic
    {
        private IPayrollFormsDao payrollFormsDao;

        public PayrollFormsLogic()
        {
            this.payrollFormsDao = new PayrollFormsDao();
        }

        public int AddPayrollForm(PayrollForms value)
        {
            return this.payrollFormsDao.AddPayrollForm(value);
        }

        public void DeletePayrollForm(int value)
        {
            payrollFormsDao.DeletePayrollForm(value);
        }

        public IEnumerable<PayrollForms> GetAllPayrollForms()
        {
            return this.payrollFormsDao.GetAllPayrollForms();
        }
    }
}
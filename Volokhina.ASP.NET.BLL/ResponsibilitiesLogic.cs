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

    public class ResponsibilitiesLogic : IResponsibilitiesLogic
    {
        private IResponsibilitiesDao responsibilitiesDao;

        public ResponsibilitiesLogic()
        {
            this.responsibilitiesDao = new ResponsibilitiesDao();
        }

        public int AddResponsibility(Responsibilities value)
        {
            return this.responsibilitiesDao.AddResponsibility(value);
        }

        public void DeleteResponsibility(int value)
        {
            responsibilitiesDao.DeleteResponsibility(value);
        }

        public IEnumerable<Responsibilities> GetAllResponsibilities()
        {
            return this.responsibilitiesDao.GetAllResponsibilities();
        }
    }
}
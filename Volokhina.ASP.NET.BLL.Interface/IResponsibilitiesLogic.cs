using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.BLL.Interface
{
    public interface IResponsibilitiesLogic
    {
        IEnumerable<Responsibilities> GetAllResponsibilities();

        int AddResponsibility(Responsibilities value);

        void DeleteResponsibility(int value);
    }
}

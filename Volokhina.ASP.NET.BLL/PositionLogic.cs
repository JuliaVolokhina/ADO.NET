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

    public class PositionLogic : IPositionLogic
    {
        private IPositionDao positionDao;

        public PositionLogic()
        {
            this.positionDao = new PositionDao();
        }

        public int AddPosition(Position value)
        {
            return this.positionDao.AddPosition(value);
        }

        public void DeletePosition(int value)
        {
            positionDao.DeletePosition(value);
        }

        public IEnumerable<Position> GetAllPositions()
        {
            return this.positionDao.GetAllPositions();
        }
    }
}
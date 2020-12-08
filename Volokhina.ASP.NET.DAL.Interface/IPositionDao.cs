using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.DAL.Interface
{
    public interface IPositionDao
    {
        IEnumerable<Position> GetAllPositions();

        int AddPosition(Position value);

        void DeletePosition(int value);
    }
}

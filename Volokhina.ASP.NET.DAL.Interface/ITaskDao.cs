using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.DAL.Interface
{
    public interface ITaskDao
    {
        IEnumerable<Entities.Task> GetAllTasks();

        int AddTask(Entities.Task value);

        void DeleteTask(int value);
    }
}

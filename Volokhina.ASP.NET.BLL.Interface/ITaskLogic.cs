using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.BLL.Interface
{
    public interface ITaskLogic
    {
        IEnumerable<Entities.Task> GetAllTasks();

        int AddTask(Entities.Task value);

        void DeleteTask(int value);
    }
}

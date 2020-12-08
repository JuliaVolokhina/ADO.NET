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

    public class TaskLogic : ITaskLogic
    {
        private ITaskDao taskDao;

        public TaskLogic()
        {
            this.taskDao = new TaskDao();
        }

        public int AddTask(Entities.Task value)
        {
            return this.taskDao.AddTask(value);
        }

        public void DeleteTask(int value)
        {
            taskDao.DeleteTask(value);
        }

        public IEnumerable<Entities.Task> GetAllTasks()
        {
            return this.taskDao.GetAllTasks();
        }
    }
}
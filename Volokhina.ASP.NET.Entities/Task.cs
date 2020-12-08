using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{
    public class Task
    {
        public int IDTask { get; set; }
        public string NameOfTask { get; set; }

        public Task()
        { }

        public Task(int idTask, string nameOfTask)
        {
            IDTask = idTask;
            NameOfTask = nameOfTask;
        }

        public override string ToString()
        {
            return $"{IDTask} {NameOfTask}";
        }
    }
}

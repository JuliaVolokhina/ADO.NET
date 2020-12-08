using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class TaskModel
    {
        public int IDTask { get; set; }

        public string NameOfTask { get; set; }
        public TaskModel(int iDTask, string nameOfTask)
        {
            IDTask = iDTask;
            NameOfTask = nameOfTask;
        }
    }
}
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
    public class ListOfWorkersLogic : IListOfWorkersLogic
    {
        private IListOfWorkersDao listOfWorkersDao;

        public ListOfWorkersLogic()
        {
            this.listOfWorkersDao = new ListOfWorkersDao();
        }

        public int AddListOfWorkers(ListOfWorkers value)
        {
            return this.listOfWorkersDao.AddListOfWorkers(value);
        }

        public void DeleteListOfWorkers(int value)
        {
            listOfWorkersDao.DeleteListOfWorkers(value);
        }

        public IEnumerable<ListOfWorkers> GetAllListOfWorkers()
        {
            return this.listOfWorkersDao.GetAllListOfWorkers();
        }
    }
}
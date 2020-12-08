using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volokhina.ASP.NET.BLL.Interface;
using Volokhina.ASP.NET.BLL;
using Volokhina.ASP.NET.Entities;
using AutoMapper;
using Volokhina.ASP.NET.Models;

namespace Volokhina.ASP.NET.Controllers
{
    public class ListOfWorkersController : Controller
    {        
        private readonly IEmployeeLogic _employeeLogic;
        private readonly IPositionLogic _positionLogic;
        private readonly IListOfWorkersLogic _listOfWorkersLogic;
        private readonly IMapper _mapper;

        public ListOfWorkersController()
        {
        }

        public ListOfWorkersController(IEmployeeLogic employeeLogic, IListOfWorkersLogic listOfWorkersLogic, 
            IPositionLogic positionLogic, IMapper mapper)
        {
            _employeeLogic = employeeLogic;
            _listOfWorkersLogic = listOfWorkersLogic;
            _positionLogic = positionLogic;
            _mapper = mapper;
        }

        public ActionResult ListOfAllWorkers(int idEmployee)
        {
            TempData["FullName"] = _employeeLogic.GetEmployeeById(idEmployee).FullName;
            TempData["IDEmployee"] = idEmployee;

            TempData["ListOfWorkers"] = _mapper.Map<List<ListOfWorkersModel>>(_listOfWorkersLogic.GetAllListOfWorkers().ToList().FindAll(low => low.IDEmployee == idEmployee));
            return RedirectToAction("GetListOfWorkers");
        }
        public ActionResult AddPositionToEmployee(int idEmployee, int idPosition)
        {
            Console.WriteLine(_listOfWorkersLogic.AddListOfWorkers(new ListOfWorkers((int)TempData.Peek("IDEmployee"), idPosition)));
            return RedirectToAction("ListOfAllWorkers", new { idEmployee = (int)TempData["IDEmployee"] });
        }

        public ActionResult DeletePositionFromEmployee(int idEmployee, int id)
        {
            _listOfWorkersLogic.DeleteListOfWorkers(id);
            return RedirectToAction("ListOfAllWorkers", new { idEmployee });
        }

        public ActionResult GetListOfWorkers()
        {
            return View(TempData["ListOfWorkers"]);
        }
    }
}
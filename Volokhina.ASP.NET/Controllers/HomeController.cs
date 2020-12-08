using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volokhina.ASP.NET.BLL.Interface;
using Volokhina.ASP.NET.Entities;

namespace Volokhina.ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeLogic _employeeLogic;
        public HomeController()
        {
        }

        public HomeController(IEmployeeLogic employeeLogic)
        {
            _employeeLogic = employeeLogic;
        }        

        public ActionResult Index()
        {
            TempData["login"] = null;
            return View();
        }

        [HttpPost]
        public ActionResult Authorization(string login)
        {
            TempData["login"] = login;
            System.Collections.Generic.List<Entities.Employee> employees = _employeeLogic.GetAllEmployees();
            if (employees.Exists(r => r.IDEmployee.Equals(int.Parse(login))))
            {
                return RedirectToAction("ListOfAllWorkers", "ListOfWorkers", new { idEmployee = login });
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AdminAuthorization(string password)
        {
            if (password != "admin") return RedirectToAction("Index");
            TempData["login"] = "admin";
            return RedirectToAction("Employees", "Employee");
        }
    }
}
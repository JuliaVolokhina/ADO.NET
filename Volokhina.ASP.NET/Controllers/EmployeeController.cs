using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volokhina.ASP.NET.BLL.Interface;
using AutoMapper;
using Volokhina.ASP.NET.Entities;
using Volokhina.ASP.NET.BLL;
using Volokhina.ASP.NET.Models;

namespace Volokhina.ASP.NET.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeLogic _employeeLogic;

        private readonly IMapper _mapper;
        public EmployeeController()
        {
        }

        public EmployeeController(IEmployeeLogic employeeLogic, IMapper mapper)
        {
            _employeeLogic = employeeLogic;
            _mapper = mapper;
        }        

        public ActionResult AllEmployees()
        {
            var employees = _employeeLogic.GetAllEmployees();
            return View(_mapper.Map<List<EmployeeModel>>(employees));
        }

        public ActionResult AddEmployee(int idEmployee, string fullName, int age, string phoneNumber, string email, string address)
        {
            _employeeLogic.AddEmployee(new Employee(idEmployee, fullName, age, phoneNumber, email, address));
            return RedirectToAction("AllEmployees");
        }

        public ActionResult DeleteEmployee(int idEmployee)
        {
            _employeeLogic.DeleteEmployee(idEmployee);
            return RedirectToAction("AllEmployees");
        }        
    }
}
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcUI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            var result = _employeeService.GetEmployees();
            return View(result);
        }
    }
}
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcUI.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        ITaskService _taskservice;
        public TaskController(ITaskService taskservice)
        {
            _taskservice = taskservice;
        }

      

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var result= _taskservice.GetAll();
            return View(result);
        }

  

        public ActionResult Assing()
        {
            var result =_taskservice.Assing();
            return View(result);
            //return RedirectToAction("GetEmployees");
        }
    }
}
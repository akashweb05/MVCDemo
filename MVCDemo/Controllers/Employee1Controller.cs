using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class Employee1Controller : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee1> employees1 = employeeBusinessLayer.Employees1.ToList();
            return View(employees1);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}
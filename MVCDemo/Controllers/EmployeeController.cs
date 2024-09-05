using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List <Employee> employees = employeecontext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();

            return View(employees);
        }
        public ActionResult Details(int id)
        {
           EmployeeContext employeecontext = new EmployeeContext();
            Employee employee = employeecontext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }
    }
}
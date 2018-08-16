using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCDemo.Models;

namespace ASPMVCDemo.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult EmployeeDetails(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employees employee = employeeContext.Employees.Single(e => e.ID == id);
            return View(employee);
        }

        public ActionResult Index(int deptId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employees> employees = employeeContext.Employees.Where(emp => emp.DepartmentID == deptId).ToList();
            return View(employees);
        }
    }
}
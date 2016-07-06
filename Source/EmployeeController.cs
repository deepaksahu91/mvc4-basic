using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc7.Models;

namespace mvc7.Controllers
{
    public class EmployeeController : Controller
    {
       
        public ActionResult Details(int id)
        {
            EmployeeContext employeecontext = new EmployeeContext();
            Employee employee=employeecontext.Employees.Single(emp=>emp.Employeeid == id);

            return View(employee);
        }

    }
}
 //Employee employee = new Employee()
 //           {
 //                Employeeid=101,
 //                Name="Soumya",
 //                Gender="Male",
 //                City="BBSR"
 //       };
 //return View(employee);

﻿using System;
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
            EmployeeContext employeeContext = new EmployeeContext();
           List<Employee> employees = employeeContext.Employees.Where (emp => emp.DepartmentId==departmentId) .ToList();

            return View(employees);
        }
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
           Employee employee = employeeContext.Employees.Single(emp => emp.ID == id);

            return View(employee);
        }
    }
}
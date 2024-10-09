using EMSMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace EMSMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
                EmployeeClient emp = new EmployeeClient();
                ViewBag.listemployee = emp.findAll();
                return View();
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View("AddEmployee");
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            EmployeeClient emp = new EmployeeClient();
            emp.Create(model);
            TempData["SuccessMessage"] = "Record Saved Successfully";
            return RedirectToAction("Index");
        }


        public ActionResult DeleteEmployee(int id)
        {
            EmployeeClient emp = new EmployeeClient();
            emp.Delete(id);
            TempData["ErrorMessage"] = "Record Deleted Successfully";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            EmployeeClient emp = new EmployeeClient();
            Employee model = new Employee();
            model = emp.find(id);
            return View("EditEmployee", model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            EmployeeClient emp = new EmployeeClient();
            emp.Edit(model);
            TempData["SuccessMessage"] = "Record Updated Successfully";
            return RedirectToAction("Index");
        }
    }
}
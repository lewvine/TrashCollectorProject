using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var signedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            var customers = _context.Customers.Where(c=> c.Zip == signedInEmployee.Zip).ToList();
            var today = DateTime.Today;
            var todaysRegularCustomers = customers.Where(c => c.RegularPickUpDay == today.DayOfWeek.ToString()) ;
            var todaysSpecialCustomers = customers.Where(c => c.SpecialPickUpDay == today);
            var todaysCustomers = todaysRegularCustomers.Concat(todaysSpecialCustomers);
            return View(todaysCustomers);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = currentUserId;
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            var employeeInDB = _context.Employees.Where(c => c.Id == employee.Id).FirstOrDefault();
            employeeInDB.FirstName = employee.FirstName;
            employeeInDB.LastName = employee.LastName;
            employeeInDB.Zip = employee.Zip;
            employeeInDB.Email = employee.Email;
            _context.SaveChanges();
            return View("Customers", "Index");
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            _context.Remove(employee);
            _context.SaveChanges();
            return View("Customers", "Index");
        }
    }
}

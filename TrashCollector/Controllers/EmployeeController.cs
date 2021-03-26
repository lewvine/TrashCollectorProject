using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.StaticMaps;
using GoogleMapsApi.StaticMaps.Entities;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index(string dayOfWeek)
        {
            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var signedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            if (signedInEmployee != null)
            {
                var pickUpDayShown = DateTime.Today;

                //If the index search parameter is null, make dayOfWeek to today's day.
                if (dayOfWeek == null)
                {
                    dayOfWeek = DateTime.Today.DayOfWeek.ToString();
                }
                //If the default pickupDayShown isn't the value of the dayOfWeek parameter
                //Add a day to pickUpDayShown until it matches dayOfWeek
                var i = 0;
                while (pickUpDayShown.DayOfWeek.ToString() != dayOfWeek)
                {
                    i++;
                    pickUpDayShown = DateTime.Today.AddDays(i);
                }
                var todaysCustomers = _context.Customers.Where(c => c.Zip == signedInEmployee.Zip)
                                                        .Where(c => c.NextPickUp.Date == pickUpDayShown.Date);
                ViewBag.Day = pickUpDayShown;
                return View(todaysCustomers);
            }
            else
            {
                return RedirectToAction("Create", "Employee");
            }

        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        public ActionResult Create()
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View();
        }

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

        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            return View(employee);
        }

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

        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            _context.Remove(employee);
            _context.SaveChanges();
            return View("Customers", "Index");
        }

        public ActionResult DoneForToday()
        {
            return View();
        }
    }
}

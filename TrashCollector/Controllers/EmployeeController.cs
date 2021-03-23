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
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var today = DateTime.Today;
            var signedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            //If the user is registered as an employee and has created a login.
            if (signedInEmployee != null)
            {
                //Regular Customers for Today
                var regularCustomers = _context.Customers.Where(c => c.Zip == signedInEmployee.Zip)
                                                  .Where(c => c.StartDate < today)
                                                  .Where(c => c.EndDate > today)
                                                  .Where(c=>c.RecentlyPickedUp == false)
                                                  .Where(c => c.RegularPickUpDay == today.DayOfWeek.ToString());

                //Special Customers for Today
                var specialCustomers = _context.Customers.Where(c => c.Zip == signedInEmployee.Zip)
                                                  .Where(c => c.StartDate < today)
                                                  .Where(c => c.EndDate > today)
                                                  .Where(c=>c.RecentlyPickedUp == false)
                                                  .Where(c => c.SpecialPickUpDay == today);

                var todaysCustomers = regularCustomers.Concat(specialCustomers);

                if (todaysCustomers != null)
                {
                    return View(todaysCustomers);
                }
                else
                {
                    return RedirectToAction("DoneForToday", "Employee");
                }
            }
            else
            {
                return RedirectToAction("Create", "Employee");
            }
        }

        public ActionResult Tomorrow()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var today = DateTime.Today.AddDays(1);
            var signedInEmployee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();

            //If the user is registered as an employee and has created a login.
            if (signedInEmployee != null)
            {
                //Regular Customers for Today
                var regularCustomers = _context.Customers.Where(c => c.Zip == signedInEmployee.Zip)
                                                  .Where(c => c.StartDate < today)
                                                  .Where(c => c.EndDate > today)
                                                  .Where(c => c.RecentlyPickedUp == false)
                                                  .Where(c => c.RegularPickUpDay == today.DayOfWeek.ToString());

                //Special Customers for Today
                var specialCustomers = _context.Customers.Where(c => c.Zip == signedInEmployee.Zip)
                                                  .Where(c => c.StartDate < today)
                                                  .Where(c => c.EndDate > today)
                                                  .Where(c => c.RecentlyPickedUp == false)
                                                  .Where(c => c.SpecialPickUpDay == today);

                var todaysCustomers = regularCustomers.Concat(specialCustomers);

                if (todaysCustomers != null)
                {
                    return View(todaysCustomers);
                }
                else
                {
                    return RedirectToAction("DoneForToday", "Employee");
                }
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

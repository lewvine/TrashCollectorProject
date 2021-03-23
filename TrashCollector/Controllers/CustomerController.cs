﻿using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Employee, Customer")]
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (customer.IdentityUserId == currentUserId || this.User.IsInRole("Employee"))
            {
                return View(customer);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"});
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            customer.IdentityUserId = currentUserId;
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Redirect($"Details/{customer.Id}");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (customer.IdentityUserId == currentUserId || this.User.IsInRole("Employee"))
            {
                return View(customer);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            var customerInDB = _context.Customers.Where(c => c.Id == customer.Id).FirstOrDefault();
            customerInDB.FirstName = customer.FirstName;
            customerInDB.LastName = customer.LastName;
            customerInDB.Zip = customer.Zip;
            customerInDB.Email = customer.Email;
            customerInDB.AccountBalance = customer.AccountBalance;
            customerInDB.RegularPickUpDay = customer.RegularPickUpDay;
            customerInDB.SpecialPickUpDay = customer.SpecialPickUpDay;
            customerInDB.StartDate = customer.StartDate;
            customerInDB.EndDate = customer.EndDate;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            _context.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

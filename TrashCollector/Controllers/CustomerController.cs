using GoogleMapsApi;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Geocoding.Request;
using GoogleMapsApi.Entities.Geocoding.Response;
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
using TrashCollector.Utilities;

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
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customers = _context.Customers.ToList();
            var customer = customers.Where(c => c.IdentityUserId == currentUserId).SingleOrDefault();
            if(customer != null)
            {
                return RedirectToAction("Details", "Customer");
            }
            else
            {
                return RedirectToAction("Create", "Customer");
            }
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = new Customer();
            if (this.User.IsInRole("Customer"))
            {
                customer = _context.Customers.Where(c => c.IdentityUserId == currentUserId).FirstOrDefault();
            }
            else
            {
                customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            }
            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
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

            //Google Maps Stuff.  First translate customer location into latitude and longitude
            GeocodingRequest geocodeRequest = new GeocodingRequest()
            {
                Address = $"{customer.Street}, {customer.City}, {customer.State} {customer.Zip}",
                ApiKey = APIs.MapsKey,
                SigningKey = "Lew Vine",

            };

            //Save this lat and long to the customer.
            var geoCodingEngine = GoogleMaps.Geocode;
            GeocodingResponse geocode = geoCodingEngine.Query(geocodeRequest);
            customer.Latitude = geocode.Results.First().Geometry.Location.Latitude;
            customer.Longitude = geocode.Results.First().Geometry.Location.Longitude;

            //Google Maps Stuff.  Second: send the retrieved lat and long to the static maps generator.
            StaticMapsEngine staticMapGenerator = new StaticMapsEngine();
            Location location = new Location(customer.Latitude, customer.Longitude);
            ImageSize imageSize = new ImageSize(400, 400);
            int zoom = 15;
            StaticMapRequest request = new StaticMapRequest(location, zoom, imageSize);
            customer.MapLocation = staticMapGenerator.GenerateStaticMapURL(request) + $"&key={APIs.MapsKey}";

            customer.IdentityUserId = currentUserId;
            customer.SetNextPickUp();
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Redirect($"Details/{customer.Id}");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewBag.Days = new SelectList(new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });

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
            //Use Geocoding to get lat and long from customer provided addresses.

            //Google Maps Stuff.  First translate customer location into latitude and longitude
            GeocodingRequest geocodeRequest = new GeocodingRequest()
            {
                Address = $"{customer.Street}, {customer.City}, {customer.State} {customer.Zip}",
                ApiKey = APIs.MapsKey,
                SigningKey = "Lew Vine",

            };

            //Save this lat and long to the customer.
            var geoCodingEngine = GoogleMaps.Geocode;
            GeocodingResponse geocode = geoCodingEngine.Query(geocodeRequest);
            customer.Latitude = geocode.Results.First().Geometry.Location.Latitude;
            customer.Longitude = geocode.Results.First().Geometry.Location.Longitude;

            //Google Maps Stuff.  Second: send the retrieved lat and long to the static maps generator.
            StaticMapsEngine staticMapGenerator = new StaticMapsEngine();
            Location location = new Location(customer.Latitude, customer.Longitude);
            ImageSize imageSize = new ImageSize(400, 400);

            int zoom = 15;
            StaticMapRequest request = new StaticMapRequest(location, zoom, imageSize);
            customer.MapLocation = staticMapGenerator.GenerateStaticMapURL(request) + $"&key={APIs.MapsKey}";
            customer.SetNextPickUp();

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
            customerInDB.City = customer.City;
            customerInDB.Street = customer.Street;
            customerInDB.State = customer.State;
            customerInDB.Longitude = customer.Longitude;
            customerInDB.Latitude = customer.Latitude;
            customerInDB.MapLocation = customer.MapLocation;
            customerInDB.NextPickUp = customer.NextPickUp;

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

        public ActionResult PickUp(int id)
        {
            var customer = _context.Customers.SingleOrDefault(e => e.Id == id);
            customer.AccountBalance += 30;
            customer.RecentlyPickedUp = true;
            customer.SetNextPickUp();
            _context.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }


    }
}

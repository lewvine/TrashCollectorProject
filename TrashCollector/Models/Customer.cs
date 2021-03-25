using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int Zip { get; set; }

        [Display(Name = "Latitude")]
        public double Latitude { get; set; }

        [Display(Name = "Longitude")]
        public double Longitude { get; set; }

        [Display(Name = "Account Balance")]
        public int AccountBalance { get; set; }

        [Display(Name = "Regular Trash Day")]
        public string RegularPickUpDay { get; set; }

        public bool RecentlyPickedUp { get; set; }

        [Display(Name = "Special Trash Day"), DataType(DataType.Date)]
        public DateTime SpecialPickUpDay { get; set; }

        [Display(Name = "Start Day"), DataType(DataType.Date)] 
        //[Range(typeof(DateTime), DateTime.Now.ToString, DateTime StartDate)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Day"), DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string MapLocation { get; set; }

        public DateTime NextPickUp { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        public DateTime SetNextPickUp()
        {
            var date = new DateTime();

            //First, set the initial day value at either the start day or today, whichever is later.
            if (StartDate < DateTime.Today && RecentlyPickedUp == false)
            {
                date = DateTime.Today;
            }
            else if (StartDate < DateTime.Today && RecentlyPickedUp == true)
            {
                date = DateTime.Today.AddDays(1);
                RecentlyPickedUp = false;
            }
            else if (StartDate > DateTime.Today)
            {
                date = StartDate;
            }
            for (var i = 0; i < 365; i++)
            {
                //Now we incorporate iteration of the initial date value, increasing by one until a match is found.
                var newDate = date.AddDays(i);
                if (newDate == SpecialPickUpDay)
                {
                    NextPickUp = newDate;
                    break;
                }
                else if (newDate.DayOfWeek.ToString() == RegularPickUpDay)
                {
                    NextPickUp = newDate;
                    break;
                }
            }
            return NextPickUp;
        }


    }
}

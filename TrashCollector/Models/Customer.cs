﻿using Microsoft.AspNetCore.Identity;
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

        [Display(Name = "E-mail Address")]
        public string Email { get; set; }

        [Display(Name = "Zip Code")]
        public int Zip { get; set; }

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

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}

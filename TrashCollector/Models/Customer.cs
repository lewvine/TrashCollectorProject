using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public SelectList Days = new SelectList(new List<string> { "Monday", "Tuesday" });

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

        [Display(Name = "Special Trash Day")]
        public int SpecialPickUpDay { get; set; }
    }
}

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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public int Zip { get; set; }
        public int AccountBalance { get; set; }
        public string RegularPickUpDay { get; set; }
        public int SpecialPickUpDay { get; set; }
        public int MyProperty { get; set; }


    }
}

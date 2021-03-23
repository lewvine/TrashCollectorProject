using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Name = "Customer",
                        NormalizedName = "CUSTOMER"
                    },
                    new IdentityRole
                    {
                        Name = "Employee",
                        NormalizedName = "EMPLOYEE"
                    }
                );


            builder.Entity<Customer>()
                .HasData(
                    new Customer
                    {
                        Id = 3,
                        FirstName = "Right Zip Code",
                        LastName = "Customer",
                        Email = "Bob.Johnson@gmail.com",
                        Zip = 91911,
                        RegularPickUpDay = "Tuesday",
                        SpecialPickUpDay = DateTime.Today.AddDays(3),
                        StartDate = DateTime.Today.AddDays(-3),
                        EndDate = DateTime.Today.AddDays(30),
                        AccountBalance = 0,
                        RecentlyPickedUp = false
                    },
                    new Customer
                    {
                        Id = 2,
                        FirstName = "Recently Picked Up True",
                        LastName = "Customer",
                        Email = "Bob.Johnson@gmail.com",
                        Zip = 91911,
                        RegularPickUpDay = "Tuesday",
                        SpecialPickUpDay = DateTime.Today.AddDays(3),
                        StartDate = DateTime.Today.AddDays(-3),
                        EndDate = DateTime.Today.AddDays(30),
                        AccountBalance = 0,
                        RecentlyPickedUp = true
                    },
                    new Customer
                    {
                        Id = 1,
                        FirstName = "End Date False",
                        LastName = "Customer",
                        Email = "Bob.Johnson@gmail.com",
                        Zip = 91911,
                        RegularPickUpDay = "Tuesday",
                        SpecialPickUpDay = DateTime.Today.AddDays(3),
                        StartDate = DateTime.Today.AddDays(-3),
                        EndDate = DateTime.Today.AddDays(-30),
                        AccountBalance = 0,
                        RecentlyPickedUp = false
                    }
                ) ;
        }
    }
}

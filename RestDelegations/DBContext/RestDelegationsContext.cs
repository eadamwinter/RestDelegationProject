using Microsoft.EntityFrameworkCore;
using RestDelegations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDelegations.DBContext
{
    public class RestDelegationsContext : DbContext
    {
        public DbSet<Delegation> Delegations { get; set; }
        public DbSet<Employee> Employees { get; set; }


        public RestDelegationsContext(DbContextOptions<RestDelegationsContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.DateOfBirth).HasColumnType("date");
            modelBuilder.Entity<Employee>().Property(e => e.DateOfEmployment).HasColumnType("date");

            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        EmployeeId = 1,
                        Name = "Adam",
                        Surname = "Sahara",
                        DateOfBirth = new DateTime(1990, 12, 12),
                        DateOfEmployment = new DateTime(2011, 08, 08),
                        Salary = 3500
                    },
                    new Employee
                    {
                        EmployeeId = 2,
                        Name = "Sebastian",
                        Surname = "Kałamarz",
                        DateOfBirth = new DateTime(1992, 11, 24),
                        DateOfEmployment = new DateTime(2014, 02, 04),
                        Salary = 4000
                    },
                    new Employee
                    {
                        EmployeeId = 3,
                        Name = "Feliks",
                        Surname = "Stasiak",
                        DateOfBirth = new DateTime(1985, 12, 02),
                        DateOfEmployment = new DateTime(2008, 04, 04),
                        Salary = 5500
                    });
            modelBuilder.Entity<Delegation>().HasData(
                    new Delegation
                    {
                        DelegationId = 1,
                        Country = "Germany",
                        Company = "VolksWagen",
                        Code = "Z64",
                        TravelToStart = new DateTime(2018, 12, 10, 07, 15, 00),
                        TravelToEnd = new DateTime(2018, 12, 10, 18, 30, 00),
                        TravelBackStart = new DateTime(2019, 02, 02, 07, 30, 00),
                        TravelBackEnd = new DateTime(2019, 02, 02, 17, 00, 00),
                        Status = "Confirmed",
                        EmployeeId = 1
                    },
                    new Delegation
                    {
                        DelegationId = 2,
                        Country = "Spain",
                        Company = "VolksWagen",
                        Code = "Z66",
                        TravelToStart = new DateTime(2015, 08, 10, 07, 15, 00),
                        TravelToEnd = new DateTime(2015, 08, 11, 10, 30, 00),
                        TravelBackStart = new DateTime(2018, 12, 02, 07, 30, 00),
                        TravelBackEnd = new DateTime(2018, 12, 03, 14, 00, 00),
                        Status = "Confirmed",
                        EmployeeId = 1
                    },
                    new Delegation
                    {
                        DelegationId = 3,
                        Country = "Spain",
                        Company = "Opel",
                        Code = "Z68",
                        TravelToStart = new DateTime(2017, 04, 10, 07, 15, 00),
                        TravelToEnd = new DateTime(2017, 04, 11, 10, 30, 00),
                        TravelBackStart = new DateTime(2017, 04, 22, 07, 30, 00),
                        TravelBackEnd = new DateTime(2017, 04, 23, 14, 00, 00),
                        Status = "Confirmed",
                        EmployeeId = 2
                    },
                    new Delegation
                    {
                        DelegationId = 4,
                        Country = "Czech Republic",
                        Company = "Skoda",
                        Code = "Z69",
                        TravelToStart = new DateTime(2016, 05, 10, 07, 15, 00),
                        TravelToEnd = new DateTime(2016, 05, 10, 10, 30, 00),
                        TravelBackStart = new DateTime(2016, 07, 02, 09, 30, 00),
                        TravelBackEnd = new DateTime(2016, 07, 02, 14, 00, 00),
                        Status = "Confirmed",
                        EmployeeId = 3
                    });
        }
    }
}

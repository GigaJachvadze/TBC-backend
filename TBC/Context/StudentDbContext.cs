using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBC.model;

namespace TBC.context
{
    public class StudentDbContext : DbContext
    { 
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        {
            Database.EnsureCreated();
            ////////modelBuilder.Entity<Event>().HasData(
            ////////    new Event
            ////////    {
            ////////        Id = 1,
            ////////        Name = "The International 10",
            ////////        Location = "Bucharest, National Arena",
            ////////        Time = TI10Date,
            ////////        IsActive = false,
            ////////        userId = 1
            ////////    }
            ////////);
        }
        public DbSet<StudentClass> Students { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var date = new DateTime(2002, 7, 14);
        //    for (int i = 0; i < 50; i++)
        //    {
                
                
        //        modelBuilder.Entity<StudentClass>().HasData(
        //            new StudentClass
        //            {
        //                Id = 1,
        //                Name = "Giga",
        //                LastName = "Jachvadze",
        //                DateOfBirth = date,
        //                Sex = false,
        //                IdNumber = "12345678912"
        //            }
        //        );
        //    }
        //}
    }
}

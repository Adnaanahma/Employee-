using EmployeeModel.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Migrations
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Employeee> Employeees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Employeee>().ToTable("Employeees");
        }
    }
}

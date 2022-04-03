using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework.Context
{
    public class AspNetMvcContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AspNetMvc;Trusted_Connection=true");
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

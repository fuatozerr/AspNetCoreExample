using Microsoft.EntityFrameworkCore;
using Project.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concreate.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5S8RN13\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}

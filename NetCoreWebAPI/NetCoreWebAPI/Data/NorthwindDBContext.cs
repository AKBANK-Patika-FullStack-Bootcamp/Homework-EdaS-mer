using Microsoft.EntityFrameworkCore;
using NetCoreWebAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Data
{
    public class NorthwindDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Northwind;uid=sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public object Product { get; internal set; }
    }
}

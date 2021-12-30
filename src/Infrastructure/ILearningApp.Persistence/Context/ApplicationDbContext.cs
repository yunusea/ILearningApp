using ILearningApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), ProductName = "Pen", Value = 10, Quantity = 100 },
                new Product() { Id = Guid.NewGuid(), ProductName = "Paper A4", Value = 1, Quantity = 200 },
                new Product() { Id = Guid.NewGuid(), ProductName = "Book", Value = 30, Quantity = 500 });


            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havas.Domain.Entities.Products;
using Havas.Domain.Entities.Suppleirs;

namespace Havas.Data.Contexts
{
    public class HavasDBContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Suppleir> Suppleirs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionPath = "Host = 127.0.0.1; Port = 5432; Database = HavasDB; Username = postgres; Password = 1379";

            optionsBuilder.UseNpgsql(connectionPath);

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products);
        //    modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category);

        //    modelBuilder.Entity<Product>().HasOne(p => p.Suppleir).WithMany(s => s.Products);
        //    modelBuilder.Entity<Suppleir>().HasMany(s => s.Products).WithOne(p => p.Suppleir);

        //}
    }
}

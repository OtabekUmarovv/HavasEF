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
        public virtual DbSet<Product>? Products { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<Suppleir>? Suppleirs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionPath = "Host = 127.0.0.1; Port = 5432; Database = HavasDB; Username = postgres; Password = 1379";

            optionsBuilder.UseNpgsql(connectionPath);

        }

        
    }
}

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class MsSqlContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brands>().HasKey(t => t.BrandId);
            modelBuilder.Entity<Colors>().HasKey(t => t.ColorId);
            modelBuilder.Entity<Cars>().HasKey(t => t.CarId);

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UM4ROV7\SQLEXPRESS;Database=CarDatabase;Trusted_Connection=true");
        }
        public DbSet<Cars> Car { get; set; }
        public DbSet<Brands> Brand { get; set; }
        public DbSet<Colors> Color { get; set; }
        public DbSet<Rentals> Rental { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Customers> Customer { get; set; }
    }
}

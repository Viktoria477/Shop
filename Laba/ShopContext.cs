using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    internal class ShopContext:DbContext
    {
        public DbSet<Order> Orders {  get; set; }
        public DbSet<Item> Items {  get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Jacket> Jackets { get; set; }
        public DbSet<HomeAppliance> HomeAppliances { get; set; }
        public DbSet<WashingMachine> WashingMachines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasKey(i=>i.Id);
            modelBuilder.Entity<Item>().Property(i => i.Id).UseIdentityColumn();
            modelBuilder.Entity<Item>().Property(i => i.Price).HasPrecision(18, 2);
            modelBuilder.Entity<Alcohol>().ToTable("Alcohols");
            modelBuilder.Entity<Clothes>().ToTable("Clothes");
            modelBuilder.Entity<Clothes>().Property(c => c.Size).HasConversion<string>();
            modelBuilder.Entity<HomeAppliance>().ToTable("HomeAppliances");
        }
    }
}
